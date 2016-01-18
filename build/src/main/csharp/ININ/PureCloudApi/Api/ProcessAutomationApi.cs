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
    public interface IProcessAutomationApi
    {
        
        /// <summary>
        /// Get flow history by Document
        /// </summary>
        /// <remarks>
        /// Gets the flow history elements for flows that related to the given document.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>FlowHistoryResultItemEntityListing</returns>
        FlowHistoryResultItemEntityListing ProcessautomationAssociationsDocumentsIdHistoryGet (string id);
  
        /// <summary>
        /// Get flow history by Document
        /// </summary>
        /// <remarks>
        /// Gets the flow history elements for flows that related to the given document.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>ApiResponse of FlowHistoryResultItemEntityListing</returns>
        ApiResponse<FlowHistoryResultItemEntityListing> ProcessautomationAssociationsDocumentsIdHistoryGetWithHttpInfo (string id);

        /// <summary>
        /// Get flow history by Document
        /// </summary>
        /// <remarks>
        /// Gets the flow history elements for flows that related to the given document.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>Task of FlowHistoryResultItemEntityListing</returns>
        System.Threading.Tasks.Task<FlowHistoryResultItemEntityListing> ProcessautomationAssociationsDocumentsIdHistoryGetAsync (string id);

        /// <summary>
        /// Get flow history by Document
        /// </summary>
        /// <remarks>
        /// Gets the flow history elements for flows that related to the given document.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse (FlowHistoryResultItemEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowHistoryResultItemEntityListing>> ProcessautomationAssociationsDocumentsIdHistoryGetAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// Get all base flows for an organization
        /// </summary>
        /// <remarks>
        /// This method will get all the flows defined in your organization.&lt;br&gt; The method will get the flows without regard to individual versions.  So a particular flow might have many versions but only a single entry representing them all as a unit will be returned.&lt;br&gt;&lt;br&gt;The method supports two kinds of filters on what data gets returned:&lt;br&gt;&lt;p&gt;+  The &#39;typeFilter&#39; param can be a comma-separated list of flow types that you want, or empty/omitted to get them all. Currently only the Workflow type is supported, but in the future other might be supported as well.&lt;/p&gt;&lt;br&gt;&lt;p&gt;+  The &#39;stateFilter&#39; param can be a comma-separated list of state types, or empty/omitted to get them all.\n So values like \&quot;Active,Inactive,Deleted\&quot; or any combination thereof are appropriate here.&lt;/p&gt;&lt;br&gt;&lt;p&gt;+  The &#39;permissionFilter&#39; param can be a comma-separated list of permissions you want to limit the list to, or empty/omitted to get them all.\n So a value like \&quot;Launch\&quot; is useful here to just get the flows you&#39;re permitted to launch.&lt;/p&gt;
        /// </remarks>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param>
        /// <param name="typeFilter">A comma-separated list of flow types that you want, or empty/omitted to get them all.</param>
        /// <param name="stateFilter">A comma-separated list of state types, or empty/omitted to get them all.</param>
        /// <param name="permissionFilter">A comma-separated list of permissions to restrict by, or empty/omitted to get them all.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="sortFields">A list of field names of the format xxx.ASC or xxx.DESC. Declare each entry SEPARATELY on the parameter list (EG &amp;sortFields=name.ASC&amp;sortFields=user.DESC</param>
        /// <returns>FlowConfigMetaDataEntityListing</returns>
        FlowConfigMetaDataEntityListing ProcessautomationFlowsDefinitionsGet (int? pageSize = null, int? pageNumber = null, string typeFilter = null, string stateFilter = null, string permissionFilter = null, string expand = null, List<string> sortFields = null);
  
        /// <summary>
        /// Get all base flows for an organization
        /// </summary>
        /// <remarks>
        /// This method will get all the flows defined in your organization.&lt;br&gt; The method will get the flows without regard to individual versions.  So a particular flow might have many versions but only a single entry representing them all as a unit will be returned.&lt;br&gt;&lt;br&gt;The method supports two kinds of filters on what data gets returned:&lt;br&gt;&lt;p&gt;+  The &#39;typeFilter&#39; param can be a comma-separated list of flow types that you want, or empty/omitted to get them all. Currently only the Workflow type is supported, but in the future other might be supported as well.&lt;/p&gt;&lt;br&gt;&lt;p&gt;+  The &#39;stateFilter&#39; param can be a comma-separated list of state types, or empty/omitted to get them all.\n So values like \&quot;Active,Inactive,Deleted\&quot; or any combination thereof are appropriate here.&lt;/p&gt;&lt;br&gt;&lt;p&gt;+  The &#39;permissionFilter&#39; param can be a comma-separated list of permissions you want to limit the list to, or empty/omitted to get them all.\n So a value like \&quot;Launch\&quot; is useful here to just get the flows you&#39;re permitted to launch.&lt;/p&gt;
        /// </remarks>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param>
        /// <param name="typeFilter">A comma-separated list of flow types that you want, or empty/omitted to get them all.</param>
        /// <param name="stateFilter">A comma-separated list of state types, or empty/omitted to get them all.</param>
        /// <param name="permissionFilter">A comma-separated list of permissions to restrict by, or empty/omitted to get them all.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="sortFields">A list of field names of the format xxx.ASC or xxx.DESC. Declare each entry SEPARATELY on the parameter list (EG &amp;sortFields=name.ASC&amp;sortFields=user.DESC</param>
        /// <returns>ApiResponse of FlowConfigMetaDataEntityListing</returns>
        ApiResponse<FlowConfigMetaDataEntityListing> ProcessautomationFlowsDefinitionsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string typeFilter = null, string stateFilter = null, string permissionFilter = null, string expand = null, List<string> sortFields = null);

        /// <summary>
        /// Get all base flows for an organization
        /// </summary>
        /// <remarks>
        /// This method will get all the flows defined in your organization.&lt;br&gt; The method will get the flows without regard to individual versions.  So a particular flow might have many versions but only a single entry representing them all as a unit will be returned.&lt;br&gt;&lt;br&gt;The method supports two kinds of filters on what data gets returned:&lt;br&gt;&lt;p&gt;+  The &#39;typeFilter&#39; param can be a comma-separated list of flow types that you want, or empty/omitted to get them all. Currently only the Workflow type is supported, but in the future other might be supported as well.&lt;/p&gt;&lt;br&gt;&lt;p&gt;+  The &#39;stateFilter&#39; param can be a comma-separated list of state types, or empty/omitted to get them all.\n So values like \&quot;Active,Inactive,Deleted\&quot; or any combination thereof are appropriate here.&lt;/p&gt;&lt;br&gt;&lt;p&gt;+  The &#39;permissionFilter&#39; param can be a comma-separated list of permissions you want to limit the list to, or empty/omitted to get them all.\n So a value like \&quot;Launch\&quot; is useful here to just get the flows you&#39;re permitted to launch.&lt;/p&gt;
        /// </remarks>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param>
        /// <param name="typeFilter">A comma-separated list of flow types that you want, or empty/omitted to get them all.</param>
        /// <param name="stateFilter">A comma-separated list of state types, or empty/omitted to get them all.</param>
        /// <param name="permissionFilter">A comma-separated list of permissions to restrict by, or empty/omitted to get them all.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="sortFields">A list of field names of the format xxx.ASC or xxx.DESC. Declare each entry SEPARATELY on the parameter list (EG &amp;sortFields=name.ASC&amp;sortFields=user.DESC</param>
        /// <returns>Task of FlowConfigMetaDataEntityListing</returns>
        System.Threading.Tasks.Task<FlowConfigMetaDataEntityListing> ProcessautomationFlowsDefinitionsGetAsync (int? pageSize = null, int? pageNumber = null, string typeFilter = null, string stateFilter = null, string permissionFilter = null, string expand = null, List<string> sortFields = null);

        /// <summary>
        /// Get all base flows for an organization
        /// </summary>
        /// <remarks>
        /// This method will get all the flows defined in your organization.&lt;br&gt; The method will get the flows without regard to individual versions.  So a particular flow might have many versions but only a single entry representing them all as a unit will be returned.&lt;br&gt;&lt;br&gt;The method supports two kinds of filters on what data gets returned:&lt;br&gt;&lt;p&gt;+  The &#39;typeFilter&#39; param can be a comma-separated list of flow types that you want, or empty/omitted to get them all. Currently only the Workflow type is supported, but in the future other might be supported as well.&lt;/p&gt;&lt;br&gt;&lt;p&gt;+  The &#39;stateFilter&#39; param can be a comma-separated list of state types, or empty/omitted to get them all.\n So values like \&quot;Active,Inactive,Deleted\&quot; or any combination thereof are appropriate here.&lt;/p&gt;&lt;br&gt;&lt;p&gt;+  The &#39;permissionFilter&#39; param can be a comma-separated list of permissions you want to limit the list to, or empty/omitted to get them all.\n So a value like \&quot;Launch\&quot; is useful here to just get the flows you&#39;re permitted to launch.&lt;/p&gt;
        /// </remarks>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param>
        /// <param name="typeFilter">A comma-separated list of flow types that you want, or empty/omitted to get them all.</param>
        /// <param name="stateFilter">A comma-separated list of state types, or empty/omitted to get them all.</param>
        /// <param name="permissionFilter">A comma-separated list of permissions to restrict by, or empty/omitted to get them all.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="sortFields">A list of field names of the format xxx.ASC or xxx.DESC. Declare each entry SEPARATELY on the parameter list (EG &amp;sortFields=name.ASC&amp;sortFields=user.DESC</param>
        /// <returns>Task of ApiResponse (FlowConfigMetaDataEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowConfigMetaDataEntityListing>> ProcessautomationFlowsDefinitionsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string typeFilter = null, string stateFilter = null, string permissionFilter = null, string expand = null, List<string> sortFields = null);
        
        /// <summary>
        /// create a new base flow object
        /// </summary>
        /// <remarks>
        /// The base flows are the flow that don&#39;t consider the specific versions of that flow - the base flow refers to all of its versions as one unit.  So base flows have a one-to-many relationship with versioned flows.&lt;br&gt;&lt;br&gt;This method will create a new base flow object, and assign it a new id.&lt;br&gt;&lt;br&gt;The usual process is that you&#39;ll want to create a base flow first, giving the flow a name and description which apply to all the versions as a whole, then create one or more versioned flows that reference that base.
        /// </remarks>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body"></param>
        /// <returns>FlowConfigMetaData</returns>
        FlowConfigMetaData ProcessautomationFlowsDefinitionsPost (string expand = null, FlowConfigMetaData body = null);
  
        /// <summary>
        /// create a new base flow object
        /// </summary>
        /// <remarks>
        /// The base flows are the flow that don&#39;t consider the specific versions of that flow - the base flow refers to all of its versions as one unit.  So base flows have a one-to-many relationship with versioned flows.&lt;br&gt;&lt;br&gt;This method will create a new base flow object, and assign it a new id.&lt;br&gt;&lt;br&gt;The usual process is that you&#39;ll want to create a base flow first, giving the flow a name and description which apply to all the versions as a whole, then create one or more versioned flows that reference that base.
        /// </remarks>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of FlowConfigMetaData</returns>
        ApiResponse<FlowConfigMetaData> ProcessautomationFlowsDefinitionsPostWithHttpInfo (string expand = null, FlowConfigMetaData body = null);

        /// <summary>
        /// create a new base flow object
        /// </summary>
        /// <remarks>
        /// The base flows are the flow that don&#39;t consider the specific versions of that flow - the base flow refers to all of its versions as one unit.  So base flows have a one-to-many relationship with versioned flows.&lt;br&gt;&lt;br&gt;This method will create a new base flow object, and assign it a new id.&lt;br&gt;&lt;br&gt;The usual process is that you&#39;ll want to create a base flow first, giving the flow a name and description which apply to all the versions as a whole, then create one or more versioned flows that reference that base.
        /// </remarks>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body"></param>
        /// <returns>Task of FlowConfigMetaData</returns>
        System.Threading.Tasks.Task<FlowConfigMetaData> ProcessautomationFlowsDefinitionsPostAsync (string expand = null, FlowConfigMetaData body = null);

        /// <summary>
        /// create a new base flow object
        /// </summary>
        /// <remarks>
        /// The base flows are the flow that don&#39;t consider the specific versions of that flow - the base flow refers to all of its versions as one unit.  So base flows have a one-to-many relationship with versioned flows.&lt;br&gt;&lt;br&gt;This method will create a new base flow object, and assign it a new id.&lt;br&gt;&lt;br&gt;The usual process is that you&#39;ll want to create a base flow first, giving the flow a name and description which apply to all the versions as a whole, then create one or more versioned flows that reference that base.
        /// </remarks>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (FlowConfigMetaData)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowConfigMetaData>> ProcessautomationFlowsDefinitionsPostAsyncWithHttpInfo (string expand = null, FlowConfigMetaData body = null);
        
        /// <summary>
        /// Get a specific base flow meta-data by flow id
        /// </summary>
        /// <remarks>
        /// This returns the stuff about a given flow that is not specific to individual versions of that flow, like its name, description, activation state, and current locking owner, etc.&lt;br&gt;NOTE: be careful to check the Deleted state of the object you get back, and don&#39;t let the UI change it if it&#39;s marked as deleted!&lt;br&gt;The requesting user must have permission to view the flow information.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>FlowConfigMetaData</returns>
        FlowConfigMetaData ProcessautomationFlowsDefinitionsIdGet (string id, string expand = null);
  
        /// <summary>
        /// Get a specific base flow meta-data by flow id
        /// </summary>
        /// <remarks>
        /// This returns the stuff about a given flow that is not specific to individual versions of that flow, like its name, description, activation state, and current locking owner, etc.&lt;br&gt;NOTE: be careful to check the Deleted state of the object you get back, and don&#39;t let the UI change it if it&#39;s marked as deleted!&lt;br&gt;The requesting user must have permission to view the flow information.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>ApiResponse of FlowConfigMetaData</returns>
        ApiResponse<FlowConfigMetaData> ProcessautomationFlowsDefinitionsIdGetWithHttpInfo (string id, string expand = null);

        /// <summary>
        /// Get a specific base flow meta-data by flow id
        /// </summary>
        /// <remarks>
        /// This returns the stuff about a given flow that is not specific to individual versions of that flow, like its name, description, activation state, and current locking owner, etc.&lt;br&gt;NOTE: be careful to check the Deleted state of the object you get back, and don&#39;t let the UI change it if it&#39;s marked as deleted!&lt;br&gt;The requesting user must have permission to view the flow information.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of FlowConfigMetaData</returns>
        System.Threading.Tasks.Task<FlowConfigMetaData> ProcessautomationFlowsDefinitionsIdGetAsync (string id, string expand = null);

        /// <summary>
        /// Get a specific base flow meta-data by flow id
        /// </summary>
        /// <remarks>
        /// This returns the stuff about a given flow that is not specific to individual versions of that flow, like its name, description, activation state, and current locking owner, etc.&lt;br&gt;NOTE: be careful to check the Deleted state of the object you get back, and don&#39;t let the UI change it if it&#39;s marked as deleted!&lt;br&gt;The requesting user must have permission to view the flow information.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of ApiResponse (FlowConfigMetaData)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowConfigMetaData>> ProcessautomationFlowsDefinitionsIdGetAsyncWithHttpInfo (string id, string expand = null);
        
        /// <summary>
        /// Updates the Activation state of a flow, which in part controls whether or not it is publicly launchable
        /// </summary>
        /// <remarks>
        /// Updates the Activation state of a flow, which in part controls whether or not it is publicly launchable
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">activate options</param>
        /// <returns>FlowConfigMetaData</returns>
        FlowConfigMetaData ProcessautomationFlowsDefinitionsIdCommandsActivatePost (string id, string expand = null, FlowActivateRequest body = null);
  
        /// <summary>
        /// Updates the Activation state of a flow, which in part controls whether or not it is publicly launchable
        /// </summary>
        /// <remarks>
        /// Updates the Activation state of a flow, which in part controls whether or not it is publicly launchable
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">activate options</param>
        /// <returns>ApiResponse of FlowConfigMetaData</returns>
        ApiResponse<FlowConfigMetaData> ProcessautomationFlowsDefinitionsIdCommandsActivatePostWithHttpInfo (string id, string expand = null, FlowActivateRequest body = null);

        /// <summary>
        /// Updates the Activation state of a flow, which in part controls whether or not it is publicly launchable
        /// </summary>
        /// <remarks>
        /// Updates the Activation state of a flow, which in part controls whether or not it is publicly launchable
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">activate options</param>
        /// <returns>Task of FlowConfigMetaData</returns>
        System.Threading.Tasks.Task<FlowConfigMetaData> ProcessautomationFlowsDefinitionsIdCommandsActivatePostAsync (string id, string expand = null, FlowActivateRequest body = null);

        /// <summary>
        /// Updates the Activation state of a flow, which in part controls whether or not it is publicly launchable
        /// </summary>
        /// <remarks>
        /// Updates the Activation state of a flow, which in part controls whether or not it is publicly launchable
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">activate options</param>
        /// <returns>Task of ApiResponse (FlowConfigMetaData)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowConfigMetaData>> ProcessautomationFlowsDefinitionsIdCommandsActivatePostAsyncWithHttpInfo (string id, string expand = null, FlowActivateRequest body = null);
        
        /// <summary>
        /// Adjusts the association between a flow and zero or more Workspaces.
        /// </summary>
        /// <remarks>
        /// Adjusts the association between a flow and zero or more Workspaces.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">activate options</param>
        /// <returns>FlowConfigMetaData</returns>
        FlowConfigMetaData ProcessautomationFlowsDefinitionsIdCommandsAssociatewithworkspacesPost (string id, string expand = null, FlowAssociateWorkspacesRequest body = null);
  
        /// <summary>
        /// Adjusts the association between a flow and zero or more Workspaces.
        /// </summary>
        /// <remarks>
        /// Adjusts the association between a flow and zero or more Workspaces.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">activate options</param>
        /// <returns>ApiResponse of FlowConfigMetaData</returns>
        ApiResponse<FlowConfigMetaData> ProcessautomationFlowsDefinitionsIdCommandsAssociatewithworkspacesPostWithHttpInfo (string id, string expand = null, FlowAssociateWorkspacesRequest body = null);

        /// <summary>
        /// Adjusts the association between a flow and zero or more Workspaces.
        /// </summary>
        /// <remarks>
        /// Adjusts the association between a flow and zero or more Workspaces.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">activate options</param>
        /// <returns>Task of FlowConfigMetaData</returns>
        System.Threading.Tasks.Task<FlowConfigMetaData> ProcessautomationFlowsDefinitionsIdCommandsAssociatewithworkspacesPostAsync (string id, string expand = null, FlowAssociateWorkspacesRequest body = null);

        /// <summary>
        /// Adjusts the association between a flow and zero or more Workspaces.
        /// </summary>
        /// <remarks>
        /// Adjusts the association between a flow and zero or more Workspaces.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">activate options</param>
        /// <returns>Task of ApiResponse (FlowConfigMetaData)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowConfigMetaData>> ProcessautomationFlowsDefinitionsIdCommandsAssociatewithworkspacesPostAsyncWithHttpInfo (string id, string expand = null, FlowAssociateWorkspacesRequest body = null);
        
        /// <summary>
        /// Permanently marks the base flow as deleted.
        /// </summary>
        /// <remarks>
        /// Permanently marks the base flow as deleted.  It is still available for historical use; the flow will no longer be launchable.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns></returns>
        void ProcessautomationFlowsDefinitionsIdCommandsDeletePost (string id);
  
        /// <summary>
        /// Permanently marks the base flow as deleted.
        /// </summary>
        /// <remarks>
        /// Permanently marks the base flow as deleted.  It is still available for historical use; the flow will no longer be launchable.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ProcessautomationFlowsDefinitionsIdCommandsDeletePostWithHttpInfo (string id);

        /// <summary>
        /// Permanently marks the base flow as deleted.
        /// </summary>
        /// <remarks>
        /// Permanently marks the base flow as deleted.  It is still available for historical use; the flow will no longer be launchable.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ProcessautomationFlowsDefinitionsIdCommandsDeletePostAsync (string id);

        /// <summary>
        /// Permanently marks the base flow as deleted.
        /// </summary>
        /// <remarks>
        /// Permanently marks the base flow as deleted.  It is still available for historical use; the flow will no longer be launchable.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ProcessautomationFlowsDefinitionsIdCommandsDeletePostAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// Updates the locked state of a flow, which affects a caller&#39;s ability to make changes to a flow
        /// </summary>
        /// <remarks>
        /// Updates the locked state of a flow, which affects a caller&#39;s ability to make changes to a flow
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">lock options</param>
        /// <returns>FlowConfigMetaData</returns>
        FlowConfigMetaData ProcessautomationFlowsDefinitionsIdCommandsLockPost (string id, string expand = null, FlowLockRequest body = null);
  
        /// <summary>
        /// Updates the locked state of a flow, which affects a caller&#39;s ability to make changes to a flow
        /// </summary>
        /// <remarks>
        /// Updates the locked state of a flow, which affects a caller&#39;s ability to make changes to a flow
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">lock options</param>
        /// <returns>ApiResponse of FlowConfigMetaData</returns>
        ApiResponse<FlowConfigMetaData> ProcessautomationFlowsDefinitionsIdCommandsLockPostWithHttpInfo (string id, string expand = null, FlowLockRequest body = null);

        /// <summary>
        /// Updates the locked state of a flow, which affects a caller&#39;s ability to make changes to a flow
        /// </summary>
        /// <remarks>
        /// Updates the locked state of a flow, which affects a caller&#39;s ability to make changes to a flow
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">lock options</param>
        /// <returns>Task of FlowConfigMetaData</returns>
        System.Threading.Tasks.Task<FlowConfigMetaData> ProcessautomationFlowsDefinitionsIdCommandsLockPostAsync (string id, string expand = null, FlowLockRequest body = null);

        /// <summary>
        /// Updates the locked state of a flow, which affects a caller&#39;s ability to make changes to a flow
        /// </summary>
        /// <remarks>
        /// Updates the locked state of a flow, which affects a caller&#39;s ability to make changes to a flow
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">lock options</param>
        /// <returns>Task of ApiResponse (FlowConfigMetaData)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowConfigMetaData>> ProcessautomationFlowsDefinitionsIdCommandsLockPostAsyncWithHttpInfo (string id, string expand = null, FlowLockRequest body = null);
        
        /// <summary>
        /// Rename a flow (both the name and the description)
        /// </summary>
        /// <remarks>
        /// Rename a flow.  Both the name and the description should be included, as both are eligible to be changed with this endpoint.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body"></param>
        /// <returns>FlowConfigMetaData</returns>
        FlowConfigMetaData ProcessautomationFlowsDefinitionsIdCommandsRenamePost (string id, string expand = null, FlowConfigMetaData body = null);
  
        /// <summary>
        /// Rename a flow (both the name and the description)
        /// </summary>
        /// <remarks>
        /// Rename a flow.  Both the name and the description should be included, as both are eligible to be changed with this endpoint.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of FlowConfigMetaData</returns>
        ApiResponse<FlowConfigMetaData> ProcessautomationFlowsDefinitionsIdCommandsRenamePostWithHttpInfo (string id, string expand = null, FlowConfigMetaData body = null);

        /// <summary>
        /// Rename a flow (both the name and the description)
        /// </summary>
        /// <remarks>
        /// Rename a flow.  Both the name and the description should be included, as both are eligible to be changed with this endpoint.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body"></param>
        /// <returns>Task of FlowConfigMetaData</returns>
        System.Threading.Tasks.Task<FlowConfigMetaData> ProcessautomationFlowsDefinitionsIdCommandsRenamePostAsync (string id, string expand = null, FlowConfigMetaData body = null);

        /// <summary>
        /// Rename a flow (both the name and the description)
        /// </summary>
        /// <remarks>
        /// Rename a flow.  Both the name and the description should be included, as both are eligible to be changed with this endpoint.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (FlowConfigMetaData)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowConfigMetaData>> ProcessautomationFlowsDefinitionsIdCommandsRenamePostAsyncWithHttpInfo (string id, string expand = null, FlowConfigMetaData body = null);
        
        /// <summary>
        /// Gets an optional cache for a given flow definition.
        /// </summary>
        /// <remarks>
        /// Gets a user saved version of a flow definition.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>string</returns>
        string ProcessautomationFlowsDefinitionsIdFlowcacheGet (string id);
  
        /// <summary>
        /// Gets an optional cache for a given flow definition.
        /// </summary>
        /// <remarks>
        /// Gets a user saved version of a flow definition.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ProcessautomationFlowsDefinitionsIdFlowcacheGetWithHttpInfo (string id);

        /// <summary>
        /// Gets an optional cache for a given flow definition.
        /// </summary>
        /// <remarks>
        /// Gets a user saved version of a flow definition.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ProcessautomationFlowsDefinitionsIdFlowcacheGetAsync (string id);

        /// <summary>
        /// Gets an optional cache for a given flow definition.
        /// </summary>
        /// <remarks>
        /// Gets a user saved version of a flow definition.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ProcessautomationFlowsDefinitionsIdFlowcacheGetAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// Saves a flow definition to a temporary location for flows that are not ready to be added to a versioned flow.
        /// </summary>
        /// <remarks>
        /// This cache is used to save a flow&#39;s definition that is still in progress and is not ready to be made official.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="body">flow definition data</param>
        /// <returns></returns>
        void ProcessautomationFlowsDefinitionsIdFlowcachePut (string id, string body = null);
  
        /// <summary>
        /// Saves a flow definition to a temporary location for flows that are not ready to be added to a versioned flow.
        /// </summary>
        /// <remarks>
        /// This cache is used to save a flow&#39;s definition that is still in progress and is not ready to be made official.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="body">flow definition data</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ProcessautomationFlowsDefinitionsIdFlowcachePutWithHttpInfo (string id, string body = null);

        /// <summary>
        /// Saves a flow definition to a temporary location for flows that are not ready to be added to a versioned flow.
        /// </summary>
        /// <remarks>
        /// This cache is used to save a flow&#39;s definition that is still in progress and is not ready to be made official.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="body">flow definition data</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ProcessautomationFlowsDefinitionsIdFlowcachePutAsync (string id, string body = null);

        /// <summary>
        /// Saves a flow definition to a temporary location for flows that are not ready to be added to a versioned flow.
        /// </summary>
        /// <remarks>
        /// This cache is used to save a flow&#39;s definition that is still in progress and is not ready to be made official.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="body">flow definition data</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ProcessautomationFlowsDefinitionsIdFlowcachePutAsyncWithHttpInfo (string id, string body = null);
        
        /// <summary>
        /// Publishes what is saved in the flow definition cache.
        /// </summary>
        /// <remarks>
        /// Publishes what is saved in the flow definition cache. The contents are first validated to ensure they constitute a legal workflow definition. The calling user must have the lock on the flow in order to call this method.  The return value will be the newly created FlowVersionConfigMetaData object.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>FlowVersionConfigMetaData</returns>
        FlowVersionConfigMetaData ProcessautomationFlowsDefinitionsIdFlowcacheCommandsPublishPost (string id, string expand = null);
  
        /// <summary>
        /// Publishes what is saved in the flow definition cache.
        /// </summary>
        /// <remarks>
        /// Publishes what is saved in the flow definition cache. The contents are first validated to ensure they constitute a legal workflow definition. The calling user must have the lock on the flow in order to call this method.  The return value will be the newly created FlowVersionConfigMetaData object.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>ApiResponse of FlowVersionConfigMetaData</returns>
        ApiResponse<FlowVersionConfigMetaData> ProcessautomationFlowsDefinitionsIdFlowcacheCommandsPublishPostWithHttpInfo (string id, string expand = null);

        /// <summary>
        /// Publishes what is saved in the flow definition cache.
        /// </summary>
        /// <remarks>
        /// Publishes what is saved in the flow definition cache. The contents are first validated to ensure they constitute a legal workflow definition. The calling user must have the lock on the flow in order to call this method.  The return value will be the newly created FlowVersionConfigMetaData object.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of FlowVersionConfigMetaData</returns>
        System.Threading.Tasks.Task<FlowVersionConfigMetaData> ProcessautomationFlowsDefinitionsIdFlowcacheCommandsPublishPostAsync (string id, string expand = null);

        /// <summary>
        /// Publishes what is saved in the flow definition cache.
        /// </summary>
        /// <remarks>
        /// Publishes what is saved in the flow definition cache. The contents are first validated to ensure they constitute a legal workflow definition. The calling user must have the lock on the flow in order to call this method.  The return value will be the newly created FlowVersionConfigMetaData object.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of ApiResponse (FlowVersionConfigMetaData)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowVersionConfigMetaData>> ProcessautomationFlowsDefinitionsIdFlowcacheCommandsPublishPostAsyncWithHttpInfo (string id, string expand = null);
        
        /// <summary>
        /// Get all versioned flows for one particular base flow.
        /// </summary>
        /// <remarks>
        /// This is for getting a list of all versioned flows.  So there could potentially be a lot of data here. Like if some designer guy decides to publish one hundred versions of his workflow they might all get returned here.&lt;br&gt;NOTE: be careful because this API does not check to see if the base flow is marked as Deleted or not.&lt;br&gt;You probably won&#39;t want to call this API very often, usually for situations like where the UI has a \&quot;restore a previous version of the flow\&quot; listbox.
        /// </remarks>
        /// <param name="id">Flow ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>FlowVersionConfigMetaDataEntityListing</returns>
        FlowVersionConfigMetaDataEntityListing ProcessautomationFlowsDefinitionsIdVersionsGet (string id, int? pageSize = null, int? pageNumber = null, string expand = null);
  
        /// <summary>
        /// Get all versioned flows for one particular base flow.
        /// </summary>
        /// <remarks>
        /// This is for getting a list of all versioned flows.  So there could potentially be a lot of data here. Like if some designer guy decides to publish one hundred versions of his workflow they might all get returned here.&lt;br&gt;NOTE: be careful because this API does not check to see if the base flow is marked as Deleted or not.&lt;br&gt;You probably won&#39;t want to call this API very often, usually for situations like where the UI has a \&quot;restore a previous version of the flow\&quot; listbox.
        /// </remarks>
        /// <param name="id">Flow ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>ApiResponse of FlowVersionConfigMetaDataEntityListing</returns>
        ApiResponse<FlowVersionConfigMetaDataEntityListing> ProcessautomationFlowsDefinitionsIdVersionsGetWithHttpInfo (string id, int? pageSize = null, int? pageNumber = null, string expand = null);

        /// <summary>
        /// Get all versioned flows for one particular base flow.
        /// </summary>
        /// <remarks>
        /// This is for getting a list of all versioned flows.  So there could potentially be a lot of data here. Like if some designer guy decides to publish one hundred versions of his workflow they might all get returned here.&lt;br&gt;NOTE: be careful because this API does not check to see if the base flow is marked as Deleted or not.&lt;br&gt;You probably won&#39;t want to call this API very often, usually for situations like where the UI has a \&quot;restore a previous version of the flow\&quot; listbox.
        /// </remarks>
        /// <param name="id">Flow ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of FlowVersionConfigMetaDataEntityListing</returns>
        System.Threading.Tasks.Task<FlowVersionConfigMetaDataEntityListing> ProcessautomationFlowsDefinitionsIdVersionsGetAsync (string id, int? pageSize = null, int? pageNumber = null, string expand = null);

        /// <summary>
        /// Get all versioned flows for one particular base flow.
        /// </summary>
        /// <remarks>
        /// This is for getting a list of all versioned flows.  So there could potentially be a lot of data here. Like if some designer guy decides to publish one hundred versions of his workflow they might all get returned here.&lt;br&gt;NOTE: be careful because this API does not check to see if the base flow is marked as Deleted or not.&lt;br&gt;You probably won&#39;t want to call this API very often, usually for situations like where the UI has a \&quot;restore a previous version of the flow\&quot; listbox.
        /// </remarks>
        /// <param name="id">Flow ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of ApiResponse (FlowVersionConfigMetaDataEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowVersionConfigMetaDataEntityListing>> ProcessautomationFlowsDefinitionsIdVersionsGetAsyncWithHttpInfo (string id, int? pageSize = null, int? pageNumber = null, string expand = null);
        
        /// <summary>
        /// Create a new versioned flow
        /// </summary>
        /// <remarks>
        /// This method requires the base flow to be already created... and then (with permission) you can create a versioned flow that references it.  This method will set the meta-data of that versioned flow you&#39;re creating, and return to you a Uri of the user-upload-service where you can supply the bits of the flow definition.&lt;br&gt;&lt;br&gt;There is a Process Definition File for each version of a process.  The Process Definition File contains all of the definitions for everything used by the process.  Eventually, we may support Shared Data Types, Shared Sequences, etc. that are defined in separate files, are organization-global and useable across multiple process definitions for the same organization, but such shared objects are beyond the scope of the initial release.&lt;br&gt;&lt;br&gt;The Process Definition File contains Data Type Definitions, Variable Definitions, Sequence Definitions, and Actions, Outputs and Connections.&lt;br&gt;&lt;br&gt;Variable Definitions can be created in process-scope or sequence-scope.  A Variable Definition always references a Data Type Definition, regardless of whether the Variable Definition is defining a basic, simple or complex variable.  ( In IPA, basic variables did not have a separate data type definition, but simple and complex variables did.)  The Data Type Definition does not indicate whether a variable is or is not a collection; that configuration is on the Variable Definition.  Variable Definitions scoped to the Process Definition or a Task Definition may be marked as Input Parameters and/or Output Parameters, but Variable Definitions scoped to a State Sequence Definition can marked as neither Input nor Output Parameters.&lt;br&gt;&lt;br&gt;An Action is the smallest unit of executable.  Actions are added to Sequence Definitions, and no Action can exist outside of a Sequence Definition.  There are currently two types of Sequence Definitions: State Sequence Definitions and Task Sequence Definitions.  They are very similar, and may generally contain the same kinds of actions, with few restrictions.  A State Sequence Definition is called via a ChangeState action, cannot have input or output parameters, does not induce any Outputs onto the ChangeState action that calls the sequence, and cannot use the ExitTask action.  A Task Sequence Definition is called via the CallTaskSync action, can have input and/or output parameters, may induce Outputs onto the CallTaskSync action that calls the sequence, and can use the ExitTask action.&lt;br&gt;&lt;br&gt;An Action may have zero or more Outputs, where each Output is essentially just a pointer to another Action within the same Sequence Definition via an associated Connection object.  An Action with no Outputs is a Terminating Action because it causes the current sequence to end.  Examples of terminating actions are ChangeState, ExitTask and EndProcess.  All non-terminating actions will have at least one Output.  Some actions have a fixed set of outputs (i.e. Conditional if with true/false).  Many actions will have a Default Output that is always present.  Sometimes the Default Output may be the only Output (i.e. UpdateVariables).  Sometimes Outputs get induced into an action by something the action references (i.e. RunProcessSync has a Default Output, but may also gets induced outputs due to Process End Reasons from the referenced Process Definition).&lt;br&gt;&lt;br&gt;A Connection connects a specific Output of a specific Action to another Action, or even back to the same Action.  Think of Connections as the \&quot;arrows\&quot; that the server follows while the server is executing a flow: the server runs an Action; if it is a non-terminating Action, then after the action has completed the server selects an Output on that Action; once the Output is selected, the server looks for a Connection from that Output to another Action, but if there is no Connection for that output then the server exits the sequence (i.e. ExitTask(Default) if it is a Task Sequence Definition, or EndProcess(Default) if it is a State Sequence Definition).&lt;br&gt;&lt;br&gt;Note:  There is no need for a Loop action.  This is because a Connection can point from an Output of an Action back to the same action, which is itself inherently a loop.&lt;br&gt;&lt;br&gt;&lt;br&gt;Page Definition JSON Guidelines&lt;br&gt;The following subsections list the general guides lines to follow when creating JSON objects to be include on the Process Definition File.&lt;br&gt;&lt;br&gt;Keep the JSON Shallow Instead of Deep&lt;br&gt;There will always be some level of nesting within JSON: JSON itself always has one root object that contains everything else.  But, as a general rule, we want to keep the JSON shallow instead of deep.  This necessarily implies that fields that reference really complex objects are preferred over fields that contain really complex objects.  For example, rather than nest actions inside of actions that are also nested inside of other actions, all actions within the same sequence are defined within a single list because they are in the scope.  Then, there is another list at sequence scope that contains all of the connections between all of the actions.  Keep things shallow generally makes it easy to find the object you are looking for given it&#39;s ID, and nesting deep does not easily allow for structures like actions that connect back to another action earlier in the flow.&lt;br&gt;&lt;br&gt;Mind the Well-Known Field Names&lt;br&gt;This file format uses several well-known field names, such as the ones below:&lt;br&gt;    \&quot;_meta\&quot;&lt;br&gt;    \&quot;id\&quot;&lt;br&gt;    \&quot;refId\&quot;&lt;br&gt;    \&quot;designer\&quot;&lt;br&gt;    \&quot;config\&quot;&lt;br&gt;&lt;br&gt;That list of well-known field names above is not necessarily complete at this time, and will be extended as necessary.  All of the field names within that list should be discussed in this page.\n&lt;br&gt;The well-known field names shall only be used for their intended purposes.  Other fields may contain the well known names within a substring of their entire field names. (i.e. \&quot;designer\&quot; must conform to the rules for \&quot;designer\&quot;, but \&quot;myDesigner\&quot; could be used for something else.\n&lt;br&gt;The \&quot;_meta\&quot; Field\n&lt;br&gt;For deserialization or interpretation purposes, some objects may need a meta section to capture information such as the version of a serialization format.  When present, the field name shall be \&quot;_meta\&quot;, and it shall always be the first field within the object.\n&lt;br&gt;There is not currently a specific set of what may or may not appear in a meta object.  Each meta object will likely have the \&quot;objectType\&quot; field, which holds a string that indicates what type of data is contained by the object with the \&quot;_meta\&quot; field.  Other possible fields that may be used are \&quot;formatType\&quot; and/or \&quot;formatVersion\&quot;.  The idea is that the meta object should contain any information that may be necessary for an application to know or understand the other fields that are siblings of the \&quot;_meta\&quot; field within the same object. \n&lt;br&gt;Generally speaking, the fields within a JSON object are allowed to be in any order, and some serializers may choose to always write the fields in alphabetic order by default.  But, it is somewhat pointless to even have the \&quot;_meta\&quot; field if it is not first since it&#39;s information could not then be used to know what to expect while deserializing the remainder of the object.  Therefore, the meta field intentionally starts with an underscore character to force it to the top if the fields get sorted during serialization.\n&lt;br&gt;Also, it is intended that the meta can really appear within almost any object.  Basically, if a bit of extra information is is needed to understand or parse something, a \&quot;_meta\&quot; field can be added to help interpret the other fields that are siblings of the _meta field.  All \&quot;definition\&quot; objects should have a meta object that, at a minimum, indicates \&quot;objectType\&quot;.\n&lt;br&gt;&lt;br&gt;&lt;pre&gt;{    // This field, if present, must always be first!&lt;br&gt;    \&quot;_meta\&quot;:&lt;br&gt;    {&lt;br&gt;        // These are some suggest field names, but may not apply in all cases&lt;br&gt;        \&quot;objectType\&quot;: &lt;string&gt;&lt;br&gt;        \&quot;formatType\&quot;: &lt;string&gt;,&lt;br&gt;        \&quot;formatRevision\&quot;: &lt;version&gt;,&lt;br&gt; &lt;br&gt;        // Could really have just about anything else here, too&lt;br&gt;        ....&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    // More fields for this specific object must come after the \&quot;_meta\&quot;&lt;br&gt;    ...&lt;br&gt;}&lt;br&gt; &lt;br&gt;// Null \&quot;_meta\&quot; is allowed&lt;br&gt;{&lt;br&gt;    \&quot;_meta\&quot;: null,&lt;br&gt;    ...&lt;br&gt;}&lt;br&gt; &lt;br&gt;// Empty object \&quot;_meta\&quot; is allowed&lt;br&gt;{&lt;br&gt;    \&quot;_meta: {},&lt;br&gt;    ...&lt;br&gt;}&lt;br&gt;// Omitted \&quot;_meta\&quot; is allowed&lt;br&gt;{&lt;br&gt;    ...&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;&lt;br&gt;IDs and \&quot;id\&quot; &amp; \&quot;refId\&quot; Fields&lt;br&gt;&lt;br&gt;The process definition uses IDs!!!  Think of an ID as something that uniquely identifies an object definition.  Conceptually, they are like GUIDs.  However, in reality, something a bit less verbose than GUIDs may be used.&lt;br&gt;&lt;br&gt;In an attempt to more easily figure out which object owns/defines/declares the ID vs. which objects just reference the ID, the field name of all owned IDs will be \&quot;id\&quot; and the field name for all referenced IDs will be \&quot;refId\&quot;.  Additionally, the \&quot;refId\&quot; shall always be inside a container object, which is intended to&lt;br&gt;&lt;br&gt;    Allow for additional information that describe the scope/context in which the ID indicated by \&quot;refId\&quot; can be found, if necessary&lt;br&gt;    Accommodate the need to reference multiple objects from within the same parent object&lt;br&gt;    Eventually support the ability to reference objects defined outside of the Process Definition, such as shared Data Type Definitins or PureCloud Composer Scripts.&lt;br&gt;&lt;br&gt;The field name of the \&quot;refId\&quot; container object should generally end with \&quot;Ref\&quot;.&lt;br&gt;&lt;pre&gt;// Object definition that is assigning an ID to itself; The \&quot;id\&quot; field does not have to be first&lt;br&gt;{&lt;br&gt;    ...,&lt;br&gt;    \&quot;id\&quot;: &lt;id&gt;,&lt;br&gt;    ...&lt;br&gt;}&lt;/pre&gt;&lt;br&gt; &lt;br&gt;// Object definition that is referencing the object above via the \&quot;refId\&quot; field&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    // Container object for the \&quot;fieldOne\&quot; reference&lt;br&gt;    \&quot;fieldOneRef\&quot;:&lt;br&gt;    {&lt;br&gt;        ...,&lt;br&gt; &lt;br&gt;        // This field indicates the ID of that other object that is being referenced&lt;br&gt;        \&quot;refId\&quot;: &lt;id&gt;,&lt;br&gt; &lt;br&gt;        // If necessary, we can add additional fields that describe the scope/context in which&lt;br&gt;        // the object being referenced is expected to be found.&lt;br&gt;        ...&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    // Since \&quot;refId\&quot; is a well-known field name but the containing object&#39;s field names are not&lt;br&gt;    // (i.e. \&quot;fieldOneRef\&quot; and \&quot;fieldTwoRef\&quot; are not well-known field names) the same parent object&lt;br&gt;    // can easily reference multiple other objects, while keeping the \&quot;refId\&quot; field name consistent.&lt;br&gt;    \&quot;fieldTwoRef\&quot;:&lt;br&gt;    {&lt;br&gt;        ...,&lt;br&gt;        \&quot;refId\&quot;: &lt;id&gt;,&lt;br&gt;        ...&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;The \&quot;identity\&quot; Field\n&lt;br&gt;Everything about declaring the identity of the object is stored in the \&quot;identity\&quot; field.  This includes things like the \&quot;id\&quot; field, if necessary, as well as optional \&quot;name\&quot; and \&quot;description\&quot; fields in which store information entered by the user via the designer; it is unclear at this point whether the designer will or will not actually allow the user to view and/or enter a label and/or description for every major object, but the format will at least support it wherever the designer chooses to allow it!  Other information specific to certain object types, such as the revision of the Process Definition, could potentially also be stored in this object.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    \&quot;identity\&quot;:&lt;br&gt;    {&lt;br&gt;        \&quot;id\&quot;:&lt;id&gt;,&lt;br&gt;        \&quot;name\&quot;:string,&lt;br&gt;        \&quot;description\&quot;:&lt;string&gt;&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;Note:  The \&quot;name\&quot; and \&quot;description\&quot; fields should generally be treated as user-mutable, display only – so don&#39;t write any code to make any decisions based on a string value in \&quot;name or description\&quot;!  For example, don&#39;t look for an output named \&quot;true\&quot; on a ConditionalIf action, because it could be localized to another language, or the user may have changed it to \&quot;yes\&quot;, \&quot;on\&quot;, etc.&lt;br&gt;The \&quot;designer\&quot; Field&lt;br&gt;&lt;br&gt;Any designer-specific information shall be isolated into an object under a \&quot;designer\&quot; field.  This is a well-known field name, and is intended to better faciliate the creation of a streamlined, compiled version of the process definition, etc. should the server decide that it wants to do so.  It is assumed that anything within an object used as the value for a \&quot;designer\&quot; field is not needed at runtime by the server or by clients.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    \&quot;designer\&quot;:&lt;br&gt;    {&lt;br&gt;        ...,&lt;br&gt;        \&quot;notes\&quot;: &lt;string&gt;,&lt;br&gt;        ...&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;A \&quot;designer\&quot; field can occur at many levels within the JSON, and can always be ignored by the server.  As an example of something that may be added to a designer field, consider the Connections between an Action&#39;s Output an the next Action.  The server needs to know what the connection is (i.e. Action&#39;s Output points to another Action), but does not need how the connection looks when \&quot;drawn\&quot; by the user (i.e. goes up, right, down, right, etc.)&lt;br&gt;&lt;br&gt;The sample JSON above shows a \&quot;notes\&quot; field in object used as the value for the \&quot;designer\&quot; field.  The \&quot;identity\&quot; section mentioned previously had \&quot;name\&quot; and \&quot;description\&quot; fields.  The idea of adding \&quot;notes\&quot; into the designer field is to allow people designing the process to add very verbose notes about design decisions, etc.  That differs from the identity.descripion, which is intended to be more of a an end-user viewable description, such as a description that assists the user to select the correct Process Definition to launch.&lt;br&gt;The \&quot;config\&quot; Field&lt;br&gt;&lt;br&gt;Many of the objects may have a \&quot;config\&quot; field.  The contents of this field will generally be specific to the object.  This is were details about Action configuration, Variables configuration, etc. will be located.&lt;br&gt;The \&quot;definitions\&quot; field and Definition Lists&lt;br&gt;&lt;br&gt;Many of the JSON definition objects will themselves also contain definition lists.  For example the Process Definition objects will have a Data Type Definitions list, Variable Definitions list, Sequence Definitions list, End Process Reasons List,. etc.  The Sequence Definition will have an Action Definitions List, Connection Definitions List, Exit Reasons Definitions List, etc. &lt;br&gt;&lt;br&gt;When an object definition itself needs to include one or more definition lists, the object shall have a \&quot;definitions\&quot; field, and the value of that field is an object where the field names are the names of the definition lists.  Additionally, each of those field names that contains a single definition list will generally end with \&quot;Def\&quot;, and every object definition within a definition list will have an \&quot;identity\&quot; field.  If the objects with a specific definition list have identity.name fields, then each of those identity.name fields shall be unique among all of the objects within that same definition list!&lt;br&gt;// This is a definition object.  Generally speaking, definition lists will exist within some other definition object.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    ...,&lt;br&gt; &lt;br&gt;    // This field contains all of the definition lists,if any&lt;br&gt;    \&quot;definitions\&quot;:&lt;br&gt;    {&lt;br&gt;        // This is the definition list for abcDef objects&lt;br&gt;        \&quot;abcDefs\&quot;:&lt;br&gt;        [&lt;br&gt;            // Each abcDef object has an identity.id&lt;br&gt;            {&lt;br&gt;                \&quot;identity\&quot;:&lt;br&gt;                {&lt;br&gt;                    \&quot;id\&quot;:&lt;id&gt;,&lt;br&gt;                    \&quot;name\&quot;:&lt;string&gt;,&lt;br&gt;                }&lt;br&gt;            },&lt;br&gt; &lt;br&gt;            // There can be any number of definition objects within this definition list,&lt;br&gt;            // but each of them must have a different value for identity.name.&lt;br&gt;            ...&lt;br&gt;        ],&lt;br&gt; &lt;br&gt;        // This is the definition list of xyzDef objects&lt;br&gt;        \&quot;xyzDefs\&quot;:&lt;br&gt;        [&lt;br&gt;            // Each xyzDef object has an identity.id&lt;br&gt;            {&lt;br&gt;                \&quot;identity\&quot;:&lt;br&gt;                {&lt;br&gt;                    \&quot;id\&quot;:&lt;id&gt;,&lt;br&gt; &lt;br&gt;                    // The value of this identity.name field could be the same as a definition&lt;br&gt;                    // object within the \&quot;abcDefs\&quot; definition list above because the definition&lt;br&gt;                    // objects exist within different definition lists.&lt;br&gt;                    \&quot;name\&quot;:&lt;string&gt;&lt;br&gt;                }&lt;br&gt;            },&lt;br&gt;            ...&lt;br&gt;        ]&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    ...,&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;No Back-Pointers&lt;br&gt;&lt;br&gt;Generally speaking, the JSON should stay away from back-pointers.  A back-pointer is a reference back to the parent object definition that has the definitions list that contains the object doing the back-pointing.  For example, a StateSequenceDefinition exists within the ProcessDefinition.definitions.stateSequenceDefs list:&lt;br&gt;&lt;br&gt;    Process Definition&lt;br&gt;        definitions&lt;br&gt;            stateSequenceDefs&lt;br&gt;                StateSequenceDefinition&lt;br&gt;&lt;br&gt; &lt;br&gt;&lt;br&gt;In the example above, the JSON for the StateSeqenceDefinition should not point back to the stateSequenceDefs definitions list, or to the definitions field that contains that definitions list, or the Process Definition that contains that definitions field.  There is no need for such back-pointers because the relationship is already implied by the structure of the JSON.  With that said, however, it is likely that applications may find it useful to create such back-pointers in memory for the purpose of navigating through and manipulating the object graph; they just don&#39;t need to serialize it into the JSON.&lt;br&gt;Object Definition Template&lt;br&gt;&lt;br&gt;Given the guidelines above, the following is kind of a template for all JSON object definitions.  For any specific definition, however, some of the sections or fields within those sections may not apply.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    \&quot;_meta\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    \&quot;identity\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    // Keep in mind that the \&quot;designer\&quot; fields can really exist anywhere,&lt;br&gt;    // not just at the top of a definition.&lt;br&gt;    \&quot;designer\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    \&quot;config\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    \&quot;definitions\&quot;:&lt;br&gt;    {&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;
        /// </remarks>
        /// <param name="id">Flow ID</param>
        /// <param name="keepDraft">Keep flow draft</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body"></param>
        /// <returns>FlowVersionConfigMetaData</returns>
        FlowVersionConfigMetaData ProcessautomationFlowsDefinitionsIdVersionsPost (string id, bool? keepDraft = null, string expand = null, FlowVersionConfigMetaData body = null);
  
        /// <summary>
        /// Create a new versioned flow
        /// </summary>
        /// <remarks>
        /// This method requires the base flow to be already created... and then (with permission) you can create a versioned flow that references it.  This method will set the meta-data of that versioned flow you&#39;re creating, and return to you a Uri of the user-upload-service where you can supply the bits of the flow definition.&lt;br&gt;&lt;br&gt;There is a Process Definition File for each version of a process.  The Process Definition File contains all of the definitions for everything used by the process.  Eventually, we may support Shared Data Types, Shared Sequences, etc. that are defined in separate files, are organization-global and useable across multiple process definitions for the same organization, but such shared objects are beyond the scope of the initial release.&lt;br&gt;&lt;br&gt;The Process Definition File contains Data Type Definitions, Variable Definitions, Sequence Definitions, and Actions, Outputs and Connections.&lt;br&gt;&lt;br&gt;Variable Definitions can be created in process-scope or sequence-scope.  A Variable Definition always references a Data Type Definition, regardless of whether the Variable Definition is defining a basic, simple or complex variable.  ( In IPA, basic variables did not have a separate data type definition, but simple and complex variables did.)  The Data Type Definition does not indicate whether a variable is or is not a collection; that configuration is on the Variable Definition.  Variable Definitions scoped to the Process Definition or a Task Definition may be marked as Input Parameters and/or Output Parameters, but Variable Definitions scoped to a State Sequence Definition can marked as neither Input nor Output Parameters.&lt;br&gt;&lt;br&gt;An Action is the smallest unit of executable.  Actions are added to Sequence Definitions, and no Action can exist outside of a Sequence Definition.  There are currently two types of Sequence Definitions: State Sequence Definitions and Task Sequence Definitions.  They are very similar, and may generally contain the same kinds of actions, with few restrictions.  A State Sequence Definition is called via a ChangeState action, cannot have input or output parameters, does not induce any Outputs onto the ChangeState action that calls the sequence, and cannot use the ExitTask action.  A Task Sequence Definition is called via the CallTaskSync action, can have input and/or output parameters, may induce Outputs onto the CallTaskSync action that calls the sequence, and can use the ExitTask action.&lt;br&gt;&lt;br&gt;An Action may have zero or more Outputs, where each Output is essentially just a pointer to another Action within the same Sequence Definition via an associated Connection object.  An Action with no Outputs is a Terminating Action because it causes the current sequence to end.  Examples of terminating actions are ChangeState, ExitTask and EndProcess.  All non-terminating actions will have at least one Output.  Some actions have a fixed set of outputs (i.e. Conditional if with true/false).  Many actions will have a Default Output that is always present.  Sometimes the Default Output may be the only Output (i.e. UpdateVariables).  Sometimes Outputs get induced into an action by something the action references (i.e. RunProcessSync has a Default Output, but may also gets induced outputs due to Process End Reasons from the referenced Process Definition).&lt;br&gt;&lt;br&gt;A Connection connects a specific Output of a specific Action to another Action, or even back to the same Action.  Think of Connections as the \&quot;arrows\&quot; that the server follows while the server is executing a flow: the server runs an Action; if it is a non-terminating Action, then after the action has completed the server selects an Output on that Action; once the Output is selected, the server looks for a Connection from that Output to another Action, but if there is no Connection for that output then the server exits the sequence (i.e. ExitTask(Default) if it is a Task Sequence Definition, or EndProcess(Default) if it is a State Sequence Definition).&lt;br&gt;&lt;br&gt;Note:  There is no need for a Loop action.  This is because a Connection can point from an Output of an Action back to the same action, which is itself inherently a loop.&lt;br&gt;&lt;br&gt;&lt;br&gt;Page Definition JSON Guidelines&lt;br&gt;The following subsections list the general guides lines to follow when creating JSON objects to be include on the Process Definition File.&lt;br&gt;&lt;br&gt;Keep the JSON Shallow Instead of Deep&lt;br&gt;There will always be some level of nesting within JSON: JSON itself always has one root object that contains everything else.  But, as a general rule, we want to keep the JSON shallow instead of deep.  This necessarily implies that fields that reference really complex objects are preferred over fields that contain really complex objects.  For example, rather than nest actions inside of actions that are also nested inside of other actions, all actions within the same sequence are defined within a single list because they are in the scope.  Then, there is another list at sequence scope that contains all of the connections between all of the actions.  Keep things shallow generally makes it easy to find the object you are looking for given it&#39;s ID, and nesting deep does not easily allow for structures like actions that connect back to another action earlier in the flow.&lt;br&gt;&lt;br&gt;Mind the Well-Known Field Names&lt;br&gt;This file format uses several well-known field names, such as the ones below:&lt;br&gt;    \&quot;_meta\&quot;&lt;br&gt;    \&quot;id\&quot;&lt;br&gt;    \&quot;refId\&quot;&lt;br&gt;    \&quot;designer\&quot;&lt;br&gt;    \&quot;config\&quot;&lt;br&gt;&lt;br&gt;That list of well-known field names above is not necessarily complete at this time, and will be extended as necessary.  All of the field names within that list should be discussed in this page.\n&lt;br&gt;The well-known field names shall only be used for their intended purposes.  Other fields may contain the well known names within a substring of their entire field names. (i.e. \&quot;designer\&quot; must conform to the rules for \&quot;designer\&quot;, but \&quot;myDesigner\&quot; could be used for something else.\n&lt;br&gt;The \&quot;_meta\&quot; Field\n&lt;br&gt;For deserialization or interpretation purposes, some objects may need a meta section to capture information such as the version of a serialization format.  When present, the field name shall be \&quot;_meta\&quot;, and it shall always be the first field within the object.\n&lt;br&gt;There is not currently a specific set of what may or may not appear in a meta object.  Each meta object will likely have the \&quot;objectType\&quot; field, which holds a string that indicates what type of data is contained by the object with the \&quot;_meta\&quot; field.  Other possible fields that may be used are \&quot;formatType\&quot; and/or \&quot;formatVersion\&quot;.  The idea is that the meta object should contain any information that may be necessary for an application to know or understand the other fields that are siblings of the \&quot;_meta\&quot; field within the same object. \n&lt;br&gt;Generally speaking, the fields within a JSON object are allowed to be in any order, and some serializers may choose to always write the fields in alphabetic order by default.  But, it is somewhat pointless to even have the \&quot;_meta\&quot; field if it is not first since it&#39;s information could not then be used to know what to expect while deserializing the remainder of the object.  Therefore, the meta field intentionally starts with an underscore character to force it to the top if the fields get sorted during serialization.\n&lt;br&gt;Also, it is intended that the meta can really appear within almost any object.  Basically, if a bit of extra information is is needed to understand or parse something, a \&quot;_meta\&quot; field can be added to help interpret the other fields that are siblings of the _meta field.  All \&quot;definition\&quot; objects should have a meta object that, at a minimum, indicates \&quot;objectType\&quot;.\n&lt;br&gt;&lt;br&gt;&lt;pre&gt;{    // This field, if present, must always be first!&lt;br&gt;    \&quot;_meta\&quot;:&lt;br&gt;    {&lt;br&gt;        // These are some suggest field names, but may not apply in all cases&lt;br&gt;        \&quot;objectType\&quot;: &lt;string&gt;&lt;br&gt;        \&quot;formatType\&quot;: &lt;string&gt;,&lt;br&gt;        \&quot;formatRevision\&quot;: &lt;version&gt;,&lt;br&gt; &lt;br&gt;        // Could really have just about anything else here, too&lt;br&gt;        ....&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    // More fields for this specific object must come after the \&quot;_meta\&quot;&lt;br&gt;    ...&lt;br&gt;}&lt;br&gt; &lt;br&gt;// Null \&quot;_meta\&quot; is allowed&lt;br&gt;{&lt;br&gt;    \&quot;_meta\&quot;: null,&lt;br&gt;    ...&lt;br&gt;}&lt;br&gt; &lt;br&gt;// Empty object \&quot;_meta\&quot; is allowed&lt;br&gt;{&lt;br&gt;    \&quot;_meta: {},&lt;br&gt;    ...&lt;br&gt;}&lt;br&gt;// Omitted \&quot;_meta\&quot; is allowed&lt;br&gt;{&lt;br&gt;    ...&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;&lt;br&gt;IDs and \&quot;id\&quot; &amp; \&quot;refId\&quot; Fields&lt;br&gt;&lt;br&gt;The process definition uses IDs!!!  Think of an ID as something that uniquely identifies an object definition.  Conceptually, they are like GUIDs.  However, in reality, something a bit less verbose than GUIDs may be used.&lt;br&gt;&lt;br&gt;In an attempt to more easily figure out which object owns/defines/declares the ID vs. which objects just reference the ID, the field name of all owned IDs will be \&quot;id\&quot; and the field name for all referenced IDs will be \&quot;refId\&quot;.  Additionally, the \&quot;refId\&quot; shall always be inside a container object, which is intended to&lt;br&gt;&lt;br&gt;    Allow for additional information that describe the scope/context in which the ID indicated by \&quot;refId\&quot; can be found, if necessary&lt;br&gt;    Accommodate the need to reference multiple objects from within the same parent object&lt;br&gt;    Eventually support the ability to reference objects defined outside of the Process Definition, such as shared Data Type Definitins or PureCloud Composer Scripts.&lt;br&gt;&lt;br&gt;The field name of the \&quot;refId\&quot; container object should generally end with \&quot;Ref\&quot;.&lt;br&gt;&lt;pre&gt;// Object definition that is assigning an ID to itself; The \&quot;id\&quot; field does not have to be first&lt;br&gt;{&lt;br&gt;    ...,&lt;br&gt;    \&quot;id\&quot;: &lt;id&gt;,&lt;br&gt;    ...&lt;br&gt;}&lt;/pre&gt;&lt;br&gt; &lt;br&gt;// Object definition that is referencing the object above via the \&quot;refId\&quot; field&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    // Container object for the \&quot;fieldOne\&quot; reference&lt;br&gt;    \&quot;fieldOneRef\&quot;:&lt;br&gt;    {&lt;br&gt;        ...,&lt;br&gt; &lt;br&gt;        // This field indicates the ID of that other object that is being referenced&lt;br&gt;        \&quot;refId\&quot;: &lt;id&gt;,&lt;br&gt; &lt;br&gt;        // If necessary, we can add additional fields that describe the scope/context in which&lt;br&gt;        // the object being referenced is expected to be found.&lt;br&gt;        ...&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    // Since \&quot;refId\&quot; is a well-known field name but the containing object&#39;s field names are not&lt;br&gt;    // (i.e. \&quot;fieldOneRef\&quot; and \&quot;fieldTwoRef\&quot; are not well-known field names) the same parent object&lt;br&gt;    // can easily reference multiple other objects, while keeping the \&quot;refId\&quot; field name consistent.&lt;br&gt;    \&quot;fieldTwoRef\&quot;:&lt;br&gt;    {&lt;br&gt;        ...,&lt;br&gt;        \&quot;refId\&quot;: &lt;id&gt;,&lt;br&gt;        ...&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;The \&quot;identity\&quot; Field\n&lt;br&gt;Everything about declaring the identity of the object is stored in the \&quot;identity\&quot; field.  This includes things like the \&quot;id\&quot; field, if necessary, as well as optional \&quot;name\&quot; and \&quot;description\&quot; fields in which store information entered by the user via the designer; it is unclear at this point whether the designer will or will not actually allow the user to view and/or enter a label and/or description for every major object, but the format will at least support it wherever the designer chooses to allow it!  Other information specific to certain object types, such as the revision of the Process Definition, could potentially also be stored in this object.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    \&quot;identity\&quot;:&lt;br&gt;    {&lt;br&gt;        \&quot;id\&quot;:&lt;id&gt;,&lt;br&gt;        \&quot;name\&quot;:string,&lt;br&gt;        \&quot;description\&quot;:&lt;string&gt;&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;Note:  The \&quot;name\&quot; and \&quot;description\&quot; fields should generally be treated as user-mutable, display only – so don&#39;t write any code to make any decisions based on a string value in \&quot;name or description\&quot;!  For example, don&#39;t look for an output named \&quot;true\&quot; on a ConditionalIf action, because it could be localized to another language, or the user may have changed it to \&quot;yes\&quot;, \&quot;on\&quot;, etc.&lt;br&gt;The \&quot;designer\&quot; Field&lt;br&gt;&lt;br&gt;Any designer-specific information shall be isolated into an object under a \&quot;designer\&quot; field.  This is a well-known field name, and is intended to better faciliate the creation of a streamlined, compiled version of the process definition, etc. should the server decide that it wants to do so.  It is assumed that anything within an object used as the value for a \&quot;designer\&quot; field is not needed at runtime by the server or by clients.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    \&quot;designer\&quot;:&lt;br&gt;    {&lt;br&gt;        ...,&lt;br&gt;        \&quot;notes\&quot;: &lt;string&gt;,&lt;br&gt;        ...&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;A \&quot;designer\&quot; field can occur at many levels within the JSON, and can always be ignored by the server.  As an example of something that may be added to a designer field, consider the Connections between an Action&#39;s Output an the next Action.  The server needs to know what the connection is (i.e. Action&#39;s Output points to another Action), but does not need how the connection looks when \&quot;drawn\&quot; by the user (i.e. goes up, right, down, right, etc.)&lt;br&gt;&lt;br&gt;The sample JSON above shows a \&quot;notes\&quot; field in object used as the value for the \&quot;designer\&quot; field.  The \&quot;identity\&quot; section mentioned previously had \&quot;name\&quot; and \&quot;description\&quot; fields.  The idea of adding \&quot;notes\&quot; into the designer field is to allow people designing the process to add very verbose notes about design decisions, etc.  That differs from the identity.descripion, which is intended to be more of a an end-user viewable description, such as a description that assists the user to select the correct Process Definition to launch.&lt;br&gt;The \&quot;config\&quot; Field&lt;br&gt;&lt;br&gt;Many of the objects may have a \&quot;config\&quot; field.  The contents of this field will generally be specific to the object.  This is were details about Action configuration, Variables configuration, etc. will be located.&lt;br&gt;The \&quot;definitions\&quot; field and Definition Lists&lt;br&gt;&lt;br&gt;Many of the JSON definition objects will themselves also contain definition lists.  For example the Process Definition objects will have a Data Type Definitions list, Variable Definitions list, Sequence Definitions list, End Process Reasons List,. etc.  The Sequence Definition will have an Action Definitions List, Connection Definitions List, Exit Reasons Definitions List, etc. &lt;br&gt;&lt;br&gt;When an object definition itself needs to include one or more definition lists, the object shall have a \&quot;definitions\&quot; field, and the value of that field is an object where the field names are the names of the definition lists.  Additionally, each of those field names that contains a single definition list will generally end with \&quot;Def\&quot;, and every object definition within a definition list will have an \&quot;identity\&quot; field.  If the objects with a specific definition list have identity.name fields, then each of those identity.name fields shall be unique among all of the objects within that same definition list!&lt;br&gt;// This is a definition object.  Generally speaking, definition lists will exist within some other definition object.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    ...,&lt;br&gt; &lt;br&gt;    // This field contains all of the definition lists,if any&lt;br&gt;    \&quot;definitions\&quot;:&lt;br&gt;    {&lt;br&gt;        // This is the definition list for abcDef objects&lt;br&gt;        \&quot;abcDefs\&quot;:&lt;br&gt;        [&lt;br&gt;            // Each abcDef object has an identity.id&lt;br&gt;            {&lt;br&gt;                \&quot;identity\&quot;:&lt;br&gt;                {&lt;br&gt;                    \&quot;id\&quot;:&lt;id&gt;,&lt;br&gt;                    \&quot;name\&quot;:&lt;string&gt;,&lt;br&gt;                }&lt;br&gt;            },&lt;br&gt; &lt;br&gt;            // There can be any number of definition objects within this definition list,&lt;br&gt;            // but each of them must have a different value for identity.name.&lt;br&gt;            ...&lt;br&gt;        ],&lt;br&gt; &lt;br&gt;        // This is the definition list of xyzDef objects&lt;br&gt;        \&quot;xyzDefs\&quot;:&lt;br&gt;        [&lt;br&gt;            // Each xyzDef object has an identity.id&lt;br&gt;            {&lt;br&gt;                \&quot;identity\&quot;:&lt;br&gt;                {&lt;br&gt;                    \&quot;id\&quot;:&lt;id&gt;,&lt;br&gt; &lt;br&gt;                    // The value of this identity.name field could be the same as a definition&lt;br&gt;                    // object within the \&quot;abcDefs\&quot; definition list above because the definition&lt;br&gt;                    // objects exist within different definition lists.&lt;br&gt;                    \&quot;name\&quot;:&lt;string&gt;&lt;br&gt;                }&lt;br&gt;            },&lt;br&gt;            ...&lt;br&gt;        ]&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    ...,&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;No Back-Pointers&lt;br&gt;&lt;br&gt;Generally speaking, the JSON should stay away from back-pointers.  A back-pointer is a reference back to the parent object definition that has the definitions list that contains the object doing the back-pointing.  For example, a StateSequenceDefinition exists within the ProcessDefinition.definitions.stateSequenceDefs list:&lt;br&gt;&lt;br&gt;    Process Definition&lt;br&gt;        definitions&lt;br&gt;            stateSequenceDefs&lt;br&gt;                StateSequenceDefinition&lt;br&gt;&lt;br&gt; &lt;br&gt;&lt;br&gt;In the example above, the JSON for the StateSeqenceDefinition should not point back to the stateSequenceDefs definitions list, or to the definitions field that contains that definitions list, or the Process Definition that contains that definitions field.  There is no need for such back-pointers because the relationship is already implied by the structure of the JSON.  With that said, however, it is likely that applications may find it useful to create such back-pointers in memory for the purpose of navigating through and manipulating the object graph; they just don&#39;t need to serialize it into the JSON.&lt;br&gt;Object Definition Template&lt;br&gt;&lt;br&gt;Given the guidelines above, the following is kind of a template for all JSON object definitions.  For any specific definition, however, some of the sections or fields within those sections may not apply.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    \&quot;_meta\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    \&quot;identity\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    // Keep in mind that the \&quot;designer\&quot; fields can really exist anywhere,&lt;br&gt;    // not just at the top of a definition.&lt;br&gt;    \&quot;designer\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    \&quot;config\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    \&quot;definitions\&quot;:&lt;br&gt;    {&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;
        /// </remarks>
        /// <param name="id">Flow ID</param>
        /// <param name="keepDraft">Keep flow draft</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of FlowVersionConfigMetaData</returns>
        ApiResponse<FlowVersionConfigMetaData> ProcessautomationFlowsDefinitionsIdVersionsPostWithHttpInfo (string id, bool? keepDraft = null, string expand = null, FlowVersionConfigMetaData body = null);

        /// <summary>
        /// Create a new versioned flow
        /// </summary>
        /// <remarks>
        /// This method requires the base flow to be already created... and then (with permission) you can create a versioned flow that references it.  This method will set the meta-data of that versioned flow you&#39;re creating, and return to you a Uri of the user-upload-service where you can supply the bits of the flow definition.&lt;br&gt;&lt;br&gt;There is a Process Definition File for each version of a process.  The Process Definition File contains all of the definitions for everything used by the process.  Eventually, we may support Shared Data Types, Shared Sequences, etc. that are defined in separate files, are organization-global and useable across multiple process definitions for the same organization, but such shared objects are beyond the scope of the initial release.&lt;br&gt;&lt;br&gt;The Process Definition File contains Data Type Definitions, Variable Definitions, Sequence Definitions, and Actions, Outputs and Connections.&lt;br&gt;&lt;br&gt;Variable Definitions can be created in process-scope or sequence-scope.  A Variable Definition always references a Data Type Definition, regardless of whether the Variable Definition is defining a basic, simple or complex variable.  ( In IPA, basic variables did not have a separate data type definition, but simple and complex variables did.)  The Data Type Definition does not indicate whether a variable is or is not a collection; that configuration is on the Variable Definition.  Variable Definitions scoped to the Process Definition or a Task Definition may be marked as Input Parameters and/or Output Parameters, but Variable Definitions scoped to a State Sequence Definition can marked as neither Input nor Output Parameters.&lt;br&gt;&lt;br&gt;An Action is the smallest unit of executable.  Actions are added to Sequence Definitions, and no Action can exist outside of a Sequence Definition.  There are currently two types of Sequence Definitions: State Sequence Definitions and Task Sequence Definitions.  They are very similar, and may generally contain the same kinds of actions, with few restrictions.  A State Sequence Definition is called via a ChangeState action, cannot have input or output parameters, does not induce any Outputs onto the ChangeState action that calls the sequence, and cannot use the ExitTask action.  A Task Sequence Definition is called via the CallTaskSync action, can have input and/or output parameters, may induce Outputs onto the CallTaskSync action that calls the sequence, and can use the ExitTask action.&lt;br&gt;&lt;br&gt;An Action may have zero or more Outputs, where each Output is essentially just a pointer to another Action within the same Sequence Definition via an associated Connection object.  An Action with no Outputs is a Terminating Action because it causes the current sequence to end.  Examples of terminating actions are ChangeState, ExitTask and EndProcess.  All non-terminating actions will have at least one Output.  Some actions have a fixed set of outputs (i.e. Conditional if with true/false).  Many actions will have a Default Output that is always present.  Sometimes the Default Output may be the only Output (i.e. UpdateVariables).  Sometimes Outputs get induced into an action by something the action references (i.e. RunProcessSync has a Default Output, but may also gets induced outputs due to Process End Reasons from the referenced Process Definition).&lt;br&gt;&lt;br&gt;A Connection connects a specific Output of a specific Action to another Action, or even back to the same Action.  Think of Connections as the \&quot;arrows\&quot; that the server follows while the server is executing a flow: the server runs an Action; if it is a non-terminating Action, then after the action has completed the server selects an Output on that Action; once the Output is selected, the server looks for a Connection from that Output to another Action, but if there is no Connection for that output then the server exits the sequence (i.e. ExitTask(Default) if it is a Task Sequence Definition, or EndProcess(Default) if it is a State Sequence Definition).&lt;br&gt;&lt;br&gt;Note:  There is no need for a Loop action.  This is because a Connection can point from an Output of an Action back to the same action, which is itself inherently a loop.&lt;br&gt;&lt;br&gt;&lt;br&gt;Page Definition JSON Guidelines&lt;br&gt;The following subsections list the general guides lines to follow when creating JSON objects to be include on the Process Definition File.&lt;br&gt;&lt;br&gt;Keep the JSON Shallow Instead of Deep&lt;br&gt;There will always be some level of nesting within JSON: JSON itself always has one root object that contains everything else.  But, as a general rule, we want to keep the JSON shallow instead of deep.  This necessarily implies that fields that reference really complex objects are preferred over fields that contain really complex objects.  For example, rather than nest actions inside of actions that are also nested inside of other actions, all actions within the same sequence are defined within a single list because they are in the scope.  Then, there is another list at sequence scope that contains all of the connections between all of the actions.  Keep things shallow generally makes it easy to find the object you are looking for given it&#39;s ID, and nesting deep does not easily allow for structures like actions that connect back to another action earlier in the flow.&lt;br&gt;&lt;br&gt;Mind the Well-Known Field Names&lt;br&gt;This file format uses several well-known field names, such as the ones below:&lt;br&gt;    \&quot;_meta\&quot;&lt;br&gt;    \&quot;id\&quot;&lt;br&gt;    \&quot;refId\&quot;&lt;br&gt;    \&quot;designer\&quot;&lt;br&gt;    \&quot;config\&quot;&lt;br&gt;&lt;br&gt;That list of well-known field names above is not necessarily complete at this time, and will be extended as necessary.  All of the field names within that list should be discussed in this page.\n&lt;br&gt;The well-known field names shall only be used for their intended purposes.  Other fields may contain the well known names within a substring of their entire field names. (i.e. \&quot;designer\&quot; must conform to the rules for \&quot;designer\&quot;, but \&quot;myDesigner\&quot; could be used for something else.\n&lt;br&gt;The \&quot;_meta\&quot; Field\n&lt;br&gt;For deserialization or interpretation purposes, some objects may need a meta section to capture information such as the version of a serialization format.  When present, the field name shall be \&quot;_meta\&quot;, and it shall always be the first field within the object.\n&lt;br&gt;There is not currently a specific set of what may or may not appear in a meta object.  Each meta object will likely have the \&quot;objectType\&quot; field, which holds a string that indicates what type of data is contained by the object with the \&quot;_meta\&quot; field.  Other possible fields that may be used are \&quot;formatType\&quot; and/or \&quot;formatVersion\&quot;.  The idea is that the meta object should contain any information that may be necessary for an application to know or understand the other fields that are siblings of the \&quot;_meta\&quot; field within the same object. \n&lt;br&gt;Generally speaking, the fields within a JSON object are allowed to be in any order, and some serializers may choose to always write the fields in alphabetic order by default.  But, it is somewhat pointless to even have the \&quot;_meta\&quot; field if it is not first since it&#39;s information could not then be used to know what to expect while deserializing the remainder of the object.  Therefore, the meta field intentionally starts with an underscore character to force it to the top if the fields get sorted during serialization.\n&lt;br&gt;Also, it is intended that the meta can really appear within almost any object.  Basically, if a bit of extra information is is needed to understand or parse something, a \&quot;_meta\&quot; field can be added to help interpret the other fields that are siblings of the _meta field.  All \&quot;definition\&quot; objects should have a meta object that, at a minimum, indicates \&quot;objectType\&quot;.\n&lt;br&gt;&lt;br&gt;&lt;pre&gt;{    // This field, if present, must always be first!&lt;br&gt;    \&quot;_meta\&quot;:&lt;br&gt;    {&lt;br&gt;        // These are some suggest field names, but may not apply in all cases&lt;br&gt;        \&quot;objectType\&quot;: &lt;string&gt;&lt;br&gt;        \&quot;formatType\&quot;: &lt;string&gt;,&lt;br&gt;        \&quot;formatRevision\&quot;: &lt;version&gt;,&lt;br&gt; &lt;br&gt;        // Could really have just about anything else here, too&lt;br&gt;        ....&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    // More fields for this specific object must come after the \&quot;_meta\&quot;&lt;br&gt;    ...&lt;br&gt;}&lt;br&gt; &lt;br&gt;// Null \&quot;_meta\&quot; is allowed&lt;br&gt;{&lt;br&gt;    \&quot;_meta\&quot;: null,&lt;br&gt;    ...&lt;br&gt;}&lt;br&gt; &lt;br&gt;// Empty object \&quot;_meta\&quot; is allowed&lt;br&gt;{&lt;br&gt;    \&quot;_meta: {},&lt;br&gt;    ...&lt;br&gt;}&lt;br&gt;// Omitted \&quot;_meta\&quot; is allowed&lt;br&gt;{&lt;br&gt;    ...&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;&lt;br&gt;IDs and \&quot;id\&quot; &amp; \&quot;refId\&quot; Fields&lt;br&gt;&lt;br&gt;The process definition uses IDs!!!  Think of an ID as something that uniquely identifies an object definition.  Conceptually, they are like GUIDs.  However, in reality, something a bit less verbose than GUIDs may be used.&lt;br&gt;&lt;br&gt;In an attempt to more easily figure out which object owns/defines/declares the ID vs. which objects just reference the ID, the field name of all owned IDs will be \&quot;id\&quot; and the field name for all referenced IDs will be \&quot;refId\&quot;.  Additionally, the \&quot;refId\&quot; shall always be inside a container object, which is intended to&lt;br&gt;&lt;br&gt;    Allow for additional information that describe the scope/context in which the ID indicated by \&quot;refId\&quot; can be found, if necessary&lt;br&gt;    Accommodate the need to reference multiple objects from within the same parent object&lt;br&gt;    Eventually support the ability to reference objects defined outside of the Process Definition, such as shared Data Type Definitins or PureCloud Composer Scripts.&lt;br&gt;&lt;br&gt;The field name of the \&quot;refId\&quot; container object should generally end with \&quot;Ref\&quot;.&lt;br&gt;&lt;pre&gt;// Object definition that is assigning an ID to itself; The \&quot;id\&quot; field does not have to be first&lt;br&gt;{&lt;br&gt;    ...,&lt;br&gt;    \&quot;id\&quot;: &lt;id&gt;,&lt;br&gt;    ...&lt;br&gt;}&lt;/pre&gt;&lt;br&gt; &lt;br&gt;// Object definition that is referencing the object above via the \&quot;refId\&quot; field&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    // Container object for the \&quot;fieldOne\&quot; reference&lt;br&gt;    \&quot;fieldOneRef\&quot;:&lt;br&gt;    {&lt;br&gt;        ...,&lt;br&gt; &lt;br&gt;        // This field indicates the ID of that other object that is being referenced&lt;br&gt;        \&quot;refId\&quot;: &lt;id&gt;,&lt;br&gt; &lt;br&gt;        // If necessary, we can add additional fields that describe the scope/context in which&lt;br&gt;        // the object being referenced is expected to be found.&lt;br&gt;        ...&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    // Since \&quot;refId\&quot; is a well-known field name but the containing object&#39;s field names are not&lt;br&gt;    // (i.e. \&quot;fieldOneRef\&quot; and \&quot;fieldTwoRef\&quot; are not well-known field names) the same parent object&lt;br&gt;    // can easily reference multiple other objects, while keeping the \&quot;refId\&quot; field name consistent.&lt;br&gt;    \&quot;fieldTwoRef\&quot;:&lt;br&gt;    {&lt;br&gt;        ...,&lt;br&gt;        \&quot;refId\&quot;: &lt;id&gt;,&lt;br&gt;        ...&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;The \&quot;identity\&quot; Field\n&lt;br&gt;Everything about declaring the identity of the object is stored in the \&quot;identity\&quot; field.  This includes things like the \&quot;id\&quot; field, if necessary, as well as optional \&quot;name\&quot; and \&quot;description\&quot; fields in which store information entered by the user via the designer; it is unclear at this point whether the designer will or will not actually allow the user to view and/or enter a label and/or description for every major object, but the format will at least support it wherever the designer chooses to allow it!  Other information specific to certain object types, such as the revision of the Process Definition, could potentially also be stored in this object.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    \&quot;identity\&quot;:&lt;br&gt;    {&lt;br&gt;        \&quot;id\&quot;:&lt;id&gt;,&lt;br&gt;        \&quot;name\&quot;:string,&lt;br&gt;        \&quot;description\&quot;:&lt;string&gt;&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;Note:  The \&quot;name\&quot; and \&quot;description\&quot; fields should generally be treated as user-mutable, display only – so don&#39;t write any code to make any decisions based on a string value in \&quot;name or description\&quot;!  For example, don&#39;t look for an output named \&quot;true\&quot; on a ConditionalIf action, because it could be localized to another language, or the user may have changed it to \&quot;yes\&quot;, \&quot;on\&quot;, etc.&lt;br&gt;The \&quot;designer\&quot; Field&lt;br&gt;&lt;br&gt;Any designer-specific information shall be isolated into an object under a \&quot;designer\&quot; field.  This is a well-known field name, and is intended to better faciliate the creation of a streamlined, compiled version of the process definition, etc. should the server decide that it wants to do so.  It is assumed that anything within an object used as the value for a \&quot;designer\&quot; field is not needed at runtime by the server or by clients.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    \&quot;designer\&quot;:&lt;br&gt;    {&lt;br&gt;        ...,&lt;br&gt;        \&quot;notes\&quot;: &lt;string&gt;,&lt;br&gt;        ...&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;A \&quot;designer\&quot; field can occur at many levels within the JSON, and can always be ignored by the server.  As an example of something that may be added to a designer field, consider the Connections between an Action&#39;s Output an the next Action.  The server needs to know what the connection is (i.e. Action&#39;s Output points to another Action), but does not need how the connection looks when \&quot;drawn\&quot; by the user (i.e. goes up, right, down, right, etc.)&lt;br&gt;&lt;br&gt;The sample JSON above shows a \&quot;notes\&quot; field in object used as the value for the \&quot;designer\&quot; field.  The \&quot;identity\&quot; section mentioned previously had \&quot;name\&quot; and \&quot;description\&quot; fields.  The idea of adding \&quot;notes\&quot; into the designer field is to allow people designing the process to add very verbose notes about design decisions, etc.  That differs from the identity.descripion, which is intended to be more of a an end-user viewable description, such as a description that assists the user to select the correct Process Definition to launch.&lt;br&gt;The \&quot;config\&quot; Field&lt;br&gt;&lt;br&gt;Many of the objects may have a \&quot;config\&quot; field.  The contents of this field will generally be specific to the object.  This is were details about Action configuration, Variables configuration, etc. will be located.&lt;br&gt;The \&quot;definitions\&quot; field and Definition Lists&lt;br&gt;&lt;br&gt;Many of the JSON definition objects will themselves also contain definition lists.  For example the Process Definition objects will have a Data Type Definitions list, Variable Definitions list, Sequence Definitions list, End Process Reasons List,. etc.  The Sequence Definition will have an Action Definitions List, Connection Definitions List, Exit Reasons Definitions List, etc. &lt;br&gt;&lt;br&gt;When an object definition itself needs to include one or more definition lists, the object shall have a \&quot;definitions\&quot; field, and the value of that field is an object where the field names are the names of the definition lists.  Additionally, each of those field names that contains a single definition list will generally end with \&quot;Def\&quot;, and every object definition within a definition list will have an \&quot;identity\&quot; field.  If the objects with a specific definition list have identity.name fields, then each of those identity.name fields shall be unique among all of the objects within that same definition list!&lt;br&gt;// This is a definition object.  Generally speaking, definition lists will exist within some other definition object.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    ...,&lt;br&gt; &lt;br&gt;    // This field contains all of the definition lists,if any&lt;br&gt;    \&quot;definitions\&quot;:&lt;br&gt;    {&lt;br&gt;        // This is the definition list for abcDef objects&lt;br&gt;        \&quot;abcDefs\&quot;:&lt;br&gt;        [&lt;br&gt;            // Each abcDef object has an identity.id&lt;br&gt;            {&lt;br&gt;                \&quot;identity\&quot;:&lt;br&gt;                {&lt;br&gt;                    \&quot;id\&quot;:&lt;id&gt;,&lt;br&gt;                    \&quot;name\&quot;:&lt;string&gt;,&lt;br&gt;                }&lt;br&gt;            },&lt;br&gt; &lt;br&gt;            // There can be any number of definition objects within this definition list,&lt;br&gt;            // but each of them must have a different value for identity.name.&lt;br&gt;            ...&lt;br&gt;        ],&lt;br&gt; &lt;br&gt;        // This is the definition list of xyzDef objects&lt;br&gt;        \&quot;xyzDefs\&quot;:&lt;br&gt;        [&lt;br&gt;            // Each xyzDef object has an identity.id&lt;br&gt;            {&lt;br&gt;                \&quot;identity\&quot;:&lt;br&gt;                {&lt;br&gt;                    \&quot;id\&quot;:&lt;id&gt;,&lt;br&gt; &lt;br&gt;                    // The value of this identity.name field could be the same as a definition&lt;br&gt;                    // object within the \&quot;abcDefs\&quot; definition list above because the definition&lt;br&gt;                    // objects exist within different definition lists.&lt;br&gt;                    \&quot;name\&quot;:&lt;string&gt;&lt;br&gt;                }&lt;br&gt;            },&lt;br&gt;            ...&lt;br&gt;        ]&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    ...,&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;No Back-Pointers&lt;br&gt;&lt;br&gt;Generally speaking, the JSON should stay away from back-pointers.  A back-pointer is a reference back to the parent object definition that has the definitions list that contains the object doing the back-pointing.  For example, a StateSequenceDefinition exists within the ProcessDefinition.definitions.stateSequenceDefs list:&lt;br&gt;&lt;br&gt;    Process Definition&lt;br&gt;        definitions&lt;br&gt;            stateSequenceDefs&lt;br&gt;                StateSequenceDefinition&lt;br&gt;&lt;br&gt; &lt;br&gt;&lt;br&gt;In the example above, the JSON for the StateSeqenceDefinition should not point back to the stateSequenceDefs definitions list, or to the definitions field that contains that definitions list, or the Process Definition that contains that definitions field.  There is no need for such back-pointers because the relationship is already implied by the structure of the JSON.  With that said, however, it is likely that applications may find it useful to create such back-pointers in memory for the purpose of navigating through and manipulating the object graph; they just don&#39;t need to serialize it into the JSON.&lt;br&gt;Object Definition Template&lt;br&gt;&lt;br&gt;Given the guidelines above, the following is kind of a template for all JSON object definitions.  For any specific definition, however, some of the sections or fields within those sections may not apply.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    \&quot;_meta\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    \&quot;identity\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    // Keep in mind that the \&quot;designer\&quot; fields can really exist anywhere,&lt;br&gt;    // not just at the top of a definition.&lt;br&gt;    \&quot;designer\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    \&quot;config\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    \&quot;definitions\&quot;:&lt;br&gt;    {&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;
        /// </remarks>
        /// <param name="id">Flow ID</param>
        /// <param name="keepDraft">Keep flow draft</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body"></param>
        /// <returns>Task of FlowVersionConfigMetaData</returns>
        System.Threading.Tasks.Task<FlowVersionConfigMetaData> ProcessautomationFlowsDefinitionsIdVersionsPostAsync (string id, bool? keepDraft = null, string expand = null, FlowVersionConfigMetaData body = null);

        /// <summary>
        /// Create a new versioned flow
        /// </summary>
        /// <remarks>
        /// This method requires the base flow to be already created... and then (with permission) you can create a versioned flow that references it.  This method will set the meta-data of that versioned flow you&#39;re creating, and return to you a Uri of the user-upload-service where you can supply the bits of the flow definition.&lt;br&gt;&lt;br&gt;There is a Process Definition File for each version of a process.  The Process Definition File contains all of the definitions for everything used by the process.  Eventually, we may support Shared Data Types, Shared Sequences, etc. that are defined in separate files, are organization-global and useable across multiple process definitions for the same organization, but such shared objects are beyond the scope of the initial release.&lt;br&gt;&lt;br&gt;The Process Definition File contains Data Type Definitions, Variable Definitions, Sequence Definitions, and Actions, Outputs and Connections.&lt;br&gt;&lt;br&gt;Variable Definitions can be created in process-scope or sequence-scope.  A Variable Definition always references a Data Type Definition, regardless of whether the Variable Definition is defining a basic, simple or complex variable.  ( In IPA, basic variables did not have a separate data type definition, but simple and complex variables did.)  The Data Type Definition does not indicate whether a variable is or is not a collection; that configuration is on the Variable Definition.  Variable Definitions scoped to the Process Definition or a Task Definition may be marked as Input Parameters and/or Output Parameters, but Variable Definitions scoped to a State Sequence Definition can marked as neither Input nor Output Parameters.&lt;br&gt;&lt;br&gt;An Action is the smallest unit of executable.  Actions are added to Sequence Definitions, and no Action can exist outside of a Sequence Definition.  There are currently two types of Sequence Definitions: State Sequence Definitions and Task Sequence Definitions.  They are very similar, and may generally contain the same kinds of actions, with few restrictions.  A State Sequence Definition is called via a ChangeState action, cannot have input or output parameters, does not induce any Outputs onto the ChangeState action that calls the sequence, and cannot use the ExitTask action.  A Task Sequence Definition is called via the CallTaskSync action, can have input and/or output parameters, may induce Outputs onto the CallTaskSync action that calls the sequence, and can use the ExitTask action.&lt;br&gt;&lt;br&gt;An Action may have zero or more Outputs, where each Output is essentially just a pointer to another Action within the same Sequence Definition via an associated Connection object.  An Action with no Outputs is a Terminating Action because it causes the current sequence to end.  Examples of terminating actions are ChangeState, ExitTask and EndProcess.  All non-terminating actions will have at least one Output.  Some actions have a fixed set of outputs (i.e. Conditional if with true/false).  Many actions will have a Default Output that is always present.  Sometimes the Default Output may be the only Output (i.e. UpdateVariables).  Sometimes Outputs get induced into an action by something the action references (i.e. RunProcessSync has a Default Output, but may also gets induced outputs due to Process End Reasons from the referenced Process Definition).&lt;br&gt;&lt;br&gt;A Connection connects a specific Output of a specific Action to another Action, or even back to the same Action.  Think of Connections as the \&quot;arrows\&quot; that the server follows while the server is executing a flow: the server runs an Action; if it is a non-terminating Action, then after the action has completed the server selects an Output on that Action; once the Output is selected, the server looks for a Connection from that Output to another Action, but if there is no Connection for that output then the server exits the sequence (i.e. ExitTask(Default) if it is a Task Sequence Definition, or EndProcess(Default) if it is a State Sequence Definition).&lt;br&gt;&lt;br&gt;Note:  There is no need for a Loop action.  This is because a Connection can point from an Output of an Action back to the same action, which is itself inherently a loop.&lt;br&gt;&lt;br&gt;&lt;br&gt;Page Definition JSON Guidelines&lt;br&gt;The following subsections list the general guides lines to follow when creating JSON objects to be include on the Process Definition File.&lt;br&gt;&lt;br&gt;Keep the JSON Shallow Instead of Deep&lt;br&gt;There will always be some level of nesting within JSON: JSON itself always has one root object that contains everything else.  But, as a general rule, we want to keep the JSON shallow instead of deep.  This necessarily implies that fields that reference really complex objects are preferred over fields that contain really complex objects.  For example, rather than nest actions inside of actions that are also nested inside of other actions, all actions within the same sequence are defined within a single list because they are in the scope.  Then, there is another list at sequence scope that contains all of the connections between all of the actions.  Keep things shallow generally makes it easy to find the object you are looking for given it&#39;s ID, and nesting deep does not easily allow for structures like actions that connect back to another action earlier in the flow.&lt;br&gt;&lt;br&gt;Mind the Well-Known Field Names&lt;br&gt;This file format uses several well-known field names, such as the ones below:&lt;br&gt;    \&quot;_meta\&quot;&lt;br&gt;    \&quot;id\&quot;&lt;br&gt;    \&quot;refId\&quot;&lt;br&gt;    \&quot;designer\&quot;&lt;br&gt;    \&quot;config\&quot;&lt;br&gt;&lt;br&gt;That list of well-known field names above is not necessarily complete at this time, and will be extended as necessary.  All of the field names within that list should be discussed in this page.\n&lt;br&gt;The well-known field names shall only be used for their intended purposes.  Other fields may contain the well known names within a substring of their entire field names. (i.e. \&quot;designer\&quot; must conform to the rules for \&quot;designer\&quot;, but \&quot;myDesigner\&quot; could be used for something else.\n&lt;br&gt;The \&quot;_meta\&quot; Field\n&lt;br&gt;For deserialization or interpretation purposes, some objects may need a meta section to capture information such as the version of a serialization format.  When present, the field name shall be \&quot;_meta\&quot;, and it shall always be the first field within the object.\n&lt;br&gt;There is not currently a specific set of what may or may not appear in a meta object.  Each meta object will likely have the \&quot;objectType\&quot; field, which holds a string that indicates what type of data is contained by the object with the \&quot;_meta\&quot; field.  Other possible fields that may be used are \&quot;formatType\&quot; and/or \&quot;formatVersion\&quot;.  The idea is that the meta object should contain any information that may be necessary for an application to know or understand the other fields that are siblings of the \&quot;_meta\&quot; field within the same object. \n&lt;br&gt;Generally speaking, the fields within a JSON object are allowed to be in any order, and some serializers may choose to always write the fields in alphabetic order by default.  But, it is somewhat pointless to even have the \&quot;_meta\&quot; field if it is not first since it&#39;s information could not then be used to know what to expect while deserializing the remainder of the object.  Therefore, the meta field intentionally starts with an underscore character to force it to the top if the fields get sorted during serialization.\n&lt;br&gt;Also, it is intended that the meta can really appear within almost any object.  Basically, if a bit of extra information is is needed to understand or parse something, a \&quot;_meta\&quot; field can be added to help interpret the other fields that are siblings of the _meta field.  All \&quot;definition\&quot; objects should have a meta object that, at a minimum, indicates \&quot;objectType\&quot;.\n&lt;br&gt;&lt;br&gt;&lt;pre&gt;{    // This field, if present, must always be first!&lt;br&gt;    \&quot;_meta\&quot;:&lt;br&gt;    {&lt;br&gt;        // These are some suggest field names, but may not apply in all cases&lt;br&gt;        \&quot;objectType\&quot;: &lt;string&gt;&lt;br&gt;        \&quot;formatType\&quot;: &lt;string&gt;,&lt;br&gt;        \&quot;formatRevision\&quot;: &lt;version&gt;,&lt;br&gt; &lt;br&gt;        // Could really have just about anything else here, too&lt;br&gt;        ....&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    // More fields for this specific object must come after the \&quot;_meta\&quot;&lt;br&gt;    ...&lt;br&gt;}&lt;br&gt; &lt;br&gt;// Null \&quot;_meta\&quot; is allowed&lt;br&gt;{&lt;br&gt;    \&quot;_meta\&quot;: null,&lt;br&gt;    ...&lt;br&gt;}&lt;br&gt; &lt;br&gt;// Empty object \&quot;_meta\&quot; is allowed&lt;br&gt;{&lt;br&gt;    \&quot;_meta: {},&lt;br&gt;    ...&lt;br&gt;}&lt;br&gt;// Omitted \&quot;_meta\&quot; is allowed&lt;br&gt;{&lt;br&gt;    ...&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;&lt;br&gt;IDs and \&quot;id\&quot; &amp; \&quot;refId\&quot; Fields&lt;br&gt;&lt;br&gt;The process definition uses IDs!!!  Think of an ID as something that uniquely identifies an object definition.  Conceptually, they are like GUIDs.  However, in reality, something a bit less verbose than GUIDs may be used.&lt;br&gt;&lt;br&gt;In an attempt to more easily figure out which object owns/defines/declares the ID vs. which objects just reference the ID, the field name of all owned IDs will be \&quot;id\&quot; and the field name for all referenced IDs will be \&quot;refId\&quot;.  Additionally, the \&quot;refId\&quot; shall always be inside a container object, which is intended to&lt;br&gt;&lt;br&gt;    Allow for additional information that describe the scope/context in which the ID indicated by \&quot;refId\&quot; can be found, if necessary&lt;br&gt;    Accommodate the need to reference multiple objects from within the same parent object&lt;br&gt;    Eventually support the ability to reference objects defined outside of the Process Definition, such as shared Data Type Definitins or PureCloud Composer Scripts.&lt;br&gt;&lt;br&gt;The field name of the \&quot;refId\&quot; container object should generally end with \&quot;Ref\&quot;.&lt;br&gt;&lt;pre&gt;// Object definition that is assigning an ID to itself; The \&quot;id\&quot; field does not have to be first&lt;br&gt;{&lt;br&gt;    ...,&lt;br&gt;    \&quot;id\&quot;: &lt;id&gt;,&lt;br&gt;    ...&lt;br&gt;}&lt;/pre&gt;&lt;br&gt; &lt;br&gt;// Object definition that is referencing the object above via the \&quot;refId\&quot; field&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    // Container object for the \&quot;fieldOne\&quot; reference&lt;br&gt;    \&quot;fieldOneRef\&quot;:&lt;br&gt;    {&lt;br&gt;        ...,&lt;br&gt; &lt;br&gt;        // This field indicates the ID of that other object that is being referenced&lt;br&gt;        \&quot;refId\&quot;: &lt;id&gt;,&lt;br&gt; &lt;br&gt;        // If necessary, we can add additional fields that describe the scope/context in which&lt;br&gt;        // the object being referenced is expected to be found.&lt;br&gt;        ...&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    // Since \&quot;refId\&quot; is a well-known field name but the containing object&#39;s field names are not&lt;br&gt;    // (i.e. \&quot;fieldOneRef\&quot; and \&quot;fieldTwoRef\&quot; are not well-known field names) the same parent object&lt;br&gt;    // can easily reference multiple other objects, while keeping the \&quot;refId\&quot; field name consistent.&lt;br&gt;    \&quot;fieldTwoRef\&quot;:&lt;br&gt;    {&lt;br&gt;        ...,&lt;br&gt;        \&quot;refId\&quot;: &lt;id&gt;,&lt;br&gt;        ...&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;The \&quot;identity\&quot; Field\n&lt;br&gt;Everything about declaring the identity of the object is stored in the \&quot;identity\&quot; field.  This includes things like the \&quot;id\&quot; field, if necessary, as well as optional \&quot;name\&quot; and \&quot;description\&quot; fields in which store information entered by the user via the designer; it is unclear at this point whether the designer will or will not actually allow the user to view and/or enter a label and/or description for every major object, but the format will at least support it wherever the designer chooses to allow it!  Other information specific to certain object types, such as the revision of the Process Definition, could potentially also be stored in this object.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    \&quot;identity\&quot;:&lt;br&gt;    {&lt;br&gt;        \&quot;id\&quot;:&lt;id&gt;,&lt;br&gt;        \&quot;name\&quot;:string,&lt;br&gt;        \&quot;description\&quot;:&lt;string&gt;&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;Note:  The \&quot;name\&quot; and \&quot;description\&quot; fields should generally be treated as user-mutable, display only – so don&#39;t write any code to make any decisions based on a string value in \&quot;name or description\&quot;!  For example, don&#39;t look for an output named \&quot;true\&quot; on a ConditionalIf action, because it could be localized to another language, or the user may have changed it to \&quot;yes\&quot;, \&quot;on\&quot;, etc.&lt;br&gt;The \&quot;designer\&quot; Field&lt;br&gt;&lt;br&gt;Any designer-specific information shall be isolated into an object under a \&quot;designer\&quot; field.  This is a well-known field name, and is intended to better faciliate the creation of a streamlined, compiled version of the process definition, etc. should the server decide that it wants to do so.  It is assumed that anything within an object used as the value for a \&quot;designer\&quot; field is not needed at runtime by the server or by clients.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    \&quot;designer\&quot;:&lt;br&gt;    {&lt;br&gt;        ...,&lt;br&gt;        \&quot;notes\&quot;: &lt;string&gt;,&lt;br&gt;        ...&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;A \&quot;designer\&quot; field can occur at many levels within the JSON, and can always be ignored by the server.  As an example of something that may be added to a designer field, consider the Connections between an Action&#39;s Output an the next Action.  The server needs to know what the connection is (i.e. Action&#39;s Output points to another Action), but does not need how the connection looks when \&quot;drawn\&quot; by the user (i.e. goes up, right, down, right, etc.)&lt;br&gt;&lt;br&gt;The sample JSON above shows a \&quot;notes\&quot; field in object used as the value for the \&quot;designer\&quot; field.  The \&quot;identity\&quot; section mentioned previously had \&quot;name\&quot; and \&quot;description\&quot; fields.  The idea of adding \&quot;notes\&quot; into the designer field is to allow people designing the process to add very verbose notes about design decisions, etc.  That differs from the identity.descripion, which is intended to be more of a an end-user viewable description, such as a description that assists the user to select the correct Process Definition to launch.&lt;br&gt;The \&quot;config\&quot; Field&lt;br&gt;&lt;br&gt;Many of the objects may have a \&quot;config\&quot; field.  The contents of this field will generally be specific to the object.  This is were details about Action configuration, Variables configuration, etc. will be located.&lt;br&gt;The \&quot;definitions\&quot; field and Definition Lists&lt;br&gt;&lt;br&gt;Many of the JSON definition objects will themselves also contain definition lists.  For example the Process Definition objects will have a Data Type Definitions list, Variable Definitions list, Sequence Definitions list, End Process Reasons List,. etc.  The Sequence Definition will have an Action Definitions List, Connection Definitions List, Exit Reasons Definitions List, etc. &lt;br&gt;&lt;br&gt;When an object definition itself needs to include one or more definition lists, the object shall have a \&quot;definitions\&quot; field, and the value of that field is an object where the field names are the names of the definition lists.  Additionally, each of those field names that contains a single definition list will generally end with \&quot;Def\&quot;, and every object definition within a definition list will have an \&quot;identity\&quot; field.  If the objects with a specific definition list have identity.name fields, then each of those identity.name fields shall be unique among all of the objects within that same definition list!&lt;br&gt;// This is a definition object.  Generally speaking, definition lists will exist within some other definition object.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    ...,&lt;br&gt; &lt;br&gt;    // This field contains all of the definition lists,if any&lt;br&gt;    \&quot;definitions\&quot;:&lt;br&gt;    {&lt;br&gt;        // This is the definition list for abcDef objects&lt;br&gt;        \&quot;abcDefs\&quot;:&lt;br&gt;        [&lt;br&gt;            // Each abcDef object has an identity.id&lt;br&gt;            {&lt;br&gt;                \&quot;identity\&quot;:&lt;br&gt;                {&lt;br&gt;                    \&quot;id\&quot;:&lt;id&gt;,&lt;br&gt;                    \&quot;name\&quot;:&lt;string&gt;,&lt;br&gt;                }&lt;br&gt;            },&lt;br&gt; &lt;br&gt;            // There can be any number of definition objects within this definition list,&lt;br&gt;            // but each of them must have a different value for identity.name.&lt;br&gt;            ...&lt;br&gt;        ],&lt;br&gt; &lt;br&gt;        // This is the definition list of xyzDef objects&lt;br&gt;        \&quot;xyzDefs\&quot;:&lt;br&gt;        [&lt;br&gt;            // Each xyzDef object has an identity.id&lt;br&gt;            {&lt;br&gt;                \&quot;identity\&quot;:&lt;br&gt;                {&lt;br&gt;                    \&quot;id\&quot;:&lt;id&gt;,&lt;br&gt; &lt;br&gt;                    // The value of this identity.name field could be the same as a definition&lt;br&gt;                    // object within the \&quot;abcDefs\&quot; definition list above because the definition&lt;br&gt;                    // objects exist within different definition lists.&lt;br&gt;                    \&quot;name\&quot;:&lt;string&gt;&lt;br&gt;                }&lt;br&gt;            },&lt;br&gt;            ...&lt;br&gt;        ]&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    ...,&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;No Back-Pointers&lt;br&gt;&lt;br&gt;Generally speaking, the JSON should stay away from back-pointers.  A back-pointer is a reference back to the parent object definition that has the definitions list that contains the object doing the back-pointing.  For example, a StateSequenceDefinition exists within the ProcessDefinition.definitions.stateSequenceDefs list:&lt;br&gt;&lt;br&gt;    Process Definition&lt;br&gt;        definitions&lt;br&gt;            stateSequenceDefs&lt;br&gt;                StateSequenceDefinition&lt;br&gt;&lt;br&gt; &lt;br&gt;&lt;br&gt;In the example above, the JSON for the StateSeqenceDefinition should not point back to the stateSequenceDefs definitions list, or to the definitions field that contains that definitions list, or the Process Definition that contains that definitions field.  There is no need for such back-pointers because the relationship is already implied by the structure of the JSON.  With that said, however, it is likely that applications may find it useful to create such back-pointers in memory for the purpose of navigating through and manipulating the object graph; they just don&#39;t need to serialize it into the JSON.&lt;br&gt;Object Definition Template&lt;br&gt;&lt;br&gt;Given the guidelines above, the following is kind of a template for all JSON object definitions.  For any specific definition, however, some of the sections or fields within those sections may not apply.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    \&quot;_meta\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    \&quot;identity\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    // Keep in mind that the \&quot;designer\&quot; fields can really exist anywhere,&lt;br&gt;    // not just at the top of a definition.&lt;br&gt;    \&quot;designer\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    \&quot;config\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    \&quot;definitions\&quot;:&lt;br&gt;    {&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;
        /// </remarks>
        /// <param name="id">Flow ID</param>
        /// <param name="keepDraft">Keep flow draft</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (FlowVersionConfigMetaData)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowVersionConfigMetaData>> ProcessautomationFlowsDefinitionsIdVersionsPostAsyncWithHttpInfo (string id, bool? keepDraft = null, string expand = null, FlowVersionConfigMetaData body = null);
        
        /// <summary>
        /// Get the meta-data about a versioned flow
        /// </summary>
        /// <remarks>
        /// This will get the meta-data about a particular version of a flow.&lt;br&gt;Also, if you specify a query parameter of  &#39;wantDownloadUri=true&#39;, the service will return to you an Uri of a location where you can download the flow  definition content.
        /// </remarks>
        /// <param name="id">Flow ID</param>
        /// <param name="version">Flow Version</param>
        /// <param name="wantDownloadUri">True if you want an Uri to download the flow definition content.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>FlowVersionConfigMetaData</returns>
        FlowVersionConfigMetaData ProcessautomationFlowsDefinitionsIdVersionsVersionGet (string id, string version, bool? wantDownloadUri = null, string expand = null);
  
        /// <summary>
        /// Get the meta-data about a versioned flow
        /// </summary>
        /// <remarks>
        /// This will get the meta-data about a particular version of a flow.&lt;br&gt;Also, if you specify a query parameter of  &#39;wantDownloadUri=true&#39;, the service will return to you an Uri of a location where you can download the flow  definition content.
        /// </remarks>
        /// <param name="id">Flow ID</param>
        /// <param name="version">Flow Version</param>
        /// <param name="wantDownloadUri">True if you want an Uri to download the flow definition content.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>ApiResponse of FlowVersionConfigMetaData</returns>
        ApiResponse<FlowVersionConfigMetaData> ProcessautomationFlowsDefinitionsIdVersionsVersionGetWithHttpInfo (string id, string version, bool? wantDownloadUri = null, string expand = null);

        /// <summary>
        /// Get the meta-data about a versioned flow
        /// </summary>
        /// <remarks>
        /// This will get the meta-data about a particular version of a flow.&lt;br&gt;Also, if you specify a query parameter of  &#39;wantDownloadUri=true&#39;, the service will return to you an Uri of a location where you can download the flow  definition content.
        /// </remarks>
        /// <param name="id">Flow ID</param>
        /// <param name="version">Flow Version</param>
        /// <param name="wantDownloadUri">True if you want an Uri to download the flow definition content.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of FlowVersionConfigMetaData</returns>
        System.Threading.Tasks.Task<FlowVersionConfigMetaData> ProcessautomationFlowsDefinitionsIdVersionsVersionGetAsync (string id, string version, bool? wantDownloadUri = null, string expand = null);

        /// <summary>
        /// Get the meta-data about a versioned flow
        /// </summary>
        /// <remarks>
        /// This will get the meta-data about a particular version of a flow.&lt;br&gt;Also, if you specify a query parameter of  &#39;wantDownloadUri=true&#39;, the service will return to you an Uri of a location where you can download the flow  definition content.
        /// </remarks>
        /// <param name="id">Flow ID</param>
        /// <param name="version">Flow Version</param>
        /// <param name="wantDownloadUri">True if you want an Uri to download the flow definition content.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of ApiResponse (FlowVersionConfigMetaData)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowVersionConfigMetaData>> ProcessautomationFlowsDefinitionsIdVersionsVersionGetAsyncWithHttpInfo (string id, string version, bool? wantDownloadUri = null, string expand = null);
        
        /// <summary>
        /// publish a minor version of a flow to a major version
        /// </summary>
        /// <remarks>
        /// Minor versions are not \&quot;seen\&quot; by regular agents, they&#39;re only seen by the Designer for intermediate work. &lt;br&gt;When a flow is considered suitable for general use, it gets promoted to a major version with this API, which then makes it visible to regular agents for use. &lt;br&gt;Note that there is no \&quot;unpublish\&quot; action, if you find there&#39;s a problem with your flow then you can either mark is as inactive (so nobody can launch that flow) or re-publish a prior version that you have from some export over the top of the one you don&#39;t like.
        /// </remarks>
        /// <param name="id">Flow ID</param>
        /// <param name="version">Flow Version</param>
        /// <returns>FlowPublish</returns>
        FlowPublish ProcessautomationFlowsDefinitionsIdVersionsVersionCommandsPublishPost (string id, string version);
  
        /// <summary>
        /// publish a minor version of a flow to a major version
        /// </summary>
        /// <remarks>
        /// Minor versions are not \&quot;seen\&quot; by regular agents, they&#39;re only seen by the Designer for intermediate work. &lt;br&gt;When a flow is considered suitable for general use, it gets promoted to a major version with this API, which then makes it visible to regular agents for use. &lt;br&gt;Note that there is no \&quot;unpublish\&quot; action, if you find there&#39;s a problem with your flow then you can either mark is as inactive (so nobody can launch that flow) or re-publish a prior version that you have from some export over the top of the one you don&#39;t like.
        /// </remarks>
        /// <param name="id">Flow ID</param>
        /// <param name="version">Flow Version</param>
        /// <returns>ApiResponse of FlowPublish</returns>
        ApiResponse<FlowPublish> ProcessautomationFlowsDefinitionsIdVersionsVersionCommandsPublishPostWithHttpInfo (string id, string version);

        /// <summary>
        /// publish a minor version of a flow to a major version
        /// </summary>
        /// <remarks>
        /// Minor versions are not \&quot;seen\&quot; by regular agents, they&#39;re only seen by the Designer for intermediate work. &lt;br&gt;When a flow is considered suitable for general use, it gets promoted to a major version with this API, which then makes it visible to regular agents for use. &lt;br&gt;Note that there is no \&quot;unpublish\&quot; action, if you find there&#39;s a problem with your flow then you can either mark is as inactive (so nobody can launch that flow) or re-publish a prior version that you have from some export over the top of the one you don&#39;t like.
        /// </remarks>
        /// <param name="id">Flow ID</param>
        /// <param name="version">Flow Version</param>
        /// <returns>Task of FlowPublish</returns>
        System.Threading.Tasks.Task<FlowPublish> ProcessautomationFlowsDefinitionsIdVersionsVersionCommandsPublishPostAsync (string id, string version);

        /// <summary>
        /// publish a minor version of a flow to a major version
        /// </summary>
        /// <remarks>
        /// Minor versions are not \&quot;seen\&quot; by regular agents, they&#39;re only seen by the Designer for intermediate work. &lt;br&gt;When a flow is considered suitable for general use, it gets promoted to a major version with this API, which then makes it visible to regular agents for use. &lt;br&gt;Note that there is no \&quot;unpublish\&quot; action, if you find there&#39;s a problem with your flow then you can either mark is as inactive (so nobody can launch that flow) or re-publish a prior version that you have from some export over the top of the one you don&#39;t like.
        /// </remarks>
        /// <param name="id">Flow ID</param>
        /// <param name="version">Flow Version</param>
        /// <returns>Task of ApiResponse (FlowPublish)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowPublish>> ProcessautomationFlowsDefinitionsIdVersionsVersionCommandsPublishPostAsyncWithHttpInfo (string id, string version);
        
        /// <summary>
        /// Launches a flow
        /// </summary>
        /// <remarks>
        /// Launches the most recently published version of the flow.  Accepts a FlowLaunch data object as a payload.
        /// </remarks>
        /// <param name="flowLaunch"></param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>FlowDetails</returns>
        FlowDetails ProcessautomationFlowsInstancesPost (FlowLaunchRequest flowLaunch, string expand = null);
  
        /// <summary>
        /// Launches a flow
        /// </summary>
        /// <remarks>
        /// Launches the most recently published version of the flow.  Accepts a FlowLaunch data object as a payload.
        /// </remarks>
        /// <param name="flowLaunch"></param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>ApiResponse of FlowDetails</returns>
        ApiResponse<FlowDetails> ProcessautomationFlowsInstancesPostWithHttpInfo (FlowLaunchRequest flowLaunch, string expand = null);

        /// <summary>
        /// Launches a flow
        /// </summary>
        /// <remarks>
        /// Launches the most recently published version of the flow.  Accepts a FlowLaunch data object as a payload.
        /// </remarks>
        /// <param name="flowLaunch"></param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of FlowDetails</returns>
        System.Threading.Tasks.Task<FlowDetails> ProcessautomationFlowsInstancesPostAsync (FlowLaunchRequest flowLaunch, string expand = null);

        /// <summary>
        /// Launches a flow
        /// </summary>
        /// <remarks>
        /// Launches the most recently published version of the flow.  Accepts a FlowLaunch data object as a payload.
        /// </remarks>
        /// <param name="flowLaunch"></param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of ApiResponse (FlowDetails)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowDetails>> ProcessautomationFlowsInstancesPostAsyncWithHttpInfo (FlowLaunchRequest flowLaunch, string expand = null);
        
        /// <summary>
        /// Search the currently running flow instances
        /// </summary>
        /// <remarks>
        /// Searches the pool of running flow instances given a SearchRequest object and returns the matching results. Some Search Examples:&lt;br&gt;Note the various filters, sort and searchPhrase options can be combined/omitted as needed.&lt;br&gt;Search for a specific definition id:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowConfigId.id\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;e88db9fb-aaa0-46f8-81d5-4a30e323bdfa\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;&lt;br&gt;Search for a specific execution instance and sort on the config name:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowExecId\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;99\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;],&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sort\&quot; : [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;:\&quot;flowConfigName\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sortType\&quot;:\&quot;ASCENDING\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;Search for a specific phrase:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;searchPhrase\&quot; : \&quot;hi mom!\&quot; &lt;br&gt;}&lt;br&gt;
        /// </remarks>
        /// <param name="body">SearchRequest data containing search parameters and paging response.</param>
        /// <returns>FlowDetailsSearchResult</returns>
        FlowDetailsSearchResult ProcessautomationFlowsInstancesCommandsSearchPost (SearchRequest body);
  
        /// <summary>
        /// Search the currently running flow instances
        /// </summary>
        /// <remarks>
        /// Searches the pool of running flow instances given a SearchRequest object and returns the matching results. Some Search Examples:&lt;br&gt;Note the various filters, sort and searchPhrase options can be combined/omitted as needed.&lt;br&gt;Search for a specific definition id:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowConfigId.id\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;e88db9fb-aaa0-46f8-81d5-4a30e323bdfa\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;&lt;br&gt;Search for a specific execution instance and sort on the config name:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowExecId\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;99\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;],&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sort\&quot; : [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;:\&quot;flowConfigName\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sortType\&quot;:\&quot;ASCENDING\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;Search for a specific phrase:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;searchPhrase\&quot; : \&quot;hi mom!\&quot; &lt;br&gt;}&lt;br&gt;
        /// </remarks>
        /// <param name="body">SearchRequest data containing search parameters and paging response.</param>
        /// <returns>ApiResponse of FlowDetailsSearchResult</returns>
        ApiResponse<FlowDetailsSearchResult> ProcessautomationFlowsInstancesCommandsSearchPostWithHttpInfo (SearchRequest body);

        /// <summary>
        /// Search the currently running flow instances
        /// </summary>
        /// <remarks>
        /// Searches the pool of running flow instances given a SearchRequest object and returns the matching results. Some Search Examples:&lt;br&gt;Note the various filters, sort and searchPhrase options can be combined/omitted as needed.&lt;br&gt;Search for a specific definition id:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowConfigId.id\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;e88db9fb-aaa0-46f8-81d5-4a30e323bdfa\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;&lt;br&gt;Search for a specific execution instance and sort on the config name:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowExecId\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;99\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;],&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sort\&quot; : [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;:\&quot;flowConfigName\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sortType\&quot;:\&quot;ASCENDING\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;Search for a specific phrase:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;searchPhrase\&quot; : \&quot;hi mom!\&quot; &lt;br&gt;}&lt;br&gt;
        /// </remarks>
        /// <param name="body">SearchRequest data containing search parameters and paging response.</param>
        /// <returns>Task of FlowDetailsSearchResult</returns>
        System.Threading.Tasks.Task<FlowDetailsSearchResult> ProcessautomationFlowsInstancesCommandsSearchPostAsync (SearchRequest body);

        /// <summary>
        /// Search the currently running flow instances
        /// </summary>
        /// <remarks>
        /// Searches the pool of running flow instances given a SearchRequest object and returns the matching results. Some Search Examples:&lt;br&gt;Note the various filters, sort and searchPhrase options can be combined/omitted as needed.&lt;br&gt;Search for a specific definition id:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowConfigId.id\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;e88db9fb-aaa0-46f8-81d5-4a30e323bdfa\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;&lt;br&gt;Search for a specific execution instance and sort on the config name:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowExecId\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;99\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;],&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sort\&quot; : [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;:\&quot;flowConfigName\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sortType\&quot;:\&quot;ASCENDING\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;Search for a specific phrase:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;searchPhrase\&quot; : \&quot;hi mom!\&quot; &lt;br&gt;}&lt;br&gt;
        /// </remarks>
        /// <param name="body">SearchRequest data containing search parameters and paging response.</param>
        /// <returns>Task of ApiResponse (FlowDetailsSearchResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowDetailsSearchResult>> ProcessautomationFlowsInstancesCommandsSearchPostAsyncWithHttpInfo (SearchRequest body);
        
        /// <summary>
        /// Get the data for a running flow
        /// </summary>
        /// <remarks>
        /// This will get the information about the current running state of the flow.
        /// </remarks>
        /// <param name="id">Flow Exec ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>FlowDetails</returns>
        FlowDetails ProcessautomationFlowsInstancesIdGet (string id, string expand = null);
  
        /// <summary>
        /// Get the data for a running flow
        /// </summary>
        /// <remarks>
        /// This will get the information about the current running state of the flow.
        /// </remarks>
        /// <param name="id">Flow Exec ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>ApiResponse of FlowDetails</returns>
        ApiResponse<FlowDetails> ProcessautomationFlowsInstancesIdGetWithHttpInfo (string id, string expand = null);

        /// <summary>
        /// Get the data for a running flow
        /// </summary>
        /// <remarks>
        /// This will get the information about the current running state of the flow.
        /// </remarks>
        /// <param name="id">Flow Exec ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of FlowDetails</returns>
        System.Threading.Tasks.Task<FlowDetails> ProcessautomationFlowsInstancesIdGetAsync (string id, string expand = null);

        /// <summary>
        /// Get the data for a running flow
        /// </summary>
        /// <remarks>
        /// This will get the information about the current running state of the flow.
        /// </remarks>
        /// <param name="id">Flow Exec ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of ApiResponse (FlowDetails)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowDetails>> ProcessautomationFlowsInstancesIdGetAsyncWithHttpInfo (string id, string expand = null);
        
        /// <summary>
        /// Retries a flow instance
        /// </summary>
        /// <remarks>
        /// Retries a flow instance
        /// </remarks>
        /// <param name="id">Flow Exec ID</param>
        /// <returns></returns>
        void ProcessautomationFlowsInstancesIdCommandsRetryPost (string id);
  
        /// <summary>
        /// Retries a flow instance
        /// </summary>
        /// <remarks>
        /// Retries a flow instance
        /// </remarks>
        /// <param name="id">Flow Exec ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ProcessautomationFlowsInstancesIdCommandsRetryPostWithHttpInfo (string id);

        /// <summary>
        /// Retries a flow instance
        /// </summary>
        /// <remarks>
        /// Retries a flow instance
        /// </remarks>
        /// <param name="id">Flow Exec ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ProcessautomationFlowsInstancesIdCommandsRetryPostAsync (string id);

        /// <summary>
        /// Retries a flow instance
        /// </summary>
        /// <remarks>
        /// Retries a flow instance
        /// </remarks>
        /// <param name="id">Flow Exec ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ProcessautomationFlowsInstancesIdCommandsRetryPostAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// Terminates a flow instance
        /// </summary>
        /// <remarks>
        /// Terminates a flow instance
        /// </remarks>
        /// <param name="id">Flow Exec ID</param>
        /// <param name="body">terminate options</param>
        /// <returns></returns>
        void ProcessautomationFlowsInstancesIdCommandsTerminatePost (string id, FlowTerminateRequest body = null);
  
        /// <summary>
        /// Terminates a flow instance
        /// </summary>
        /// <remarks>
        /// Terminates a flow instance
        /// </remarks>
        /// <param name="id">Flow Exec ID</param>
        /// <param name="body">terminate options</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ProcessautomationFlowsInstancesIdCommandsTerminatePostWithHttpInfo (string id, FlowTerminateRequest body = null);

        /// <summary>
        /// Terminates a flow instance
        /// </summary>
        /// <remarks>
        /// Terminates a flow instance
        /// </remarks>
        /// <param name="id">Flow Exec ID</param>
        /// <param name="body">terminate options</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ProcessautomationFlowsInstancesIdCommandsTerminatePostAsync (string id, FlowTerminateRequest body = null);

        /// <summary>
        /// Terminates a flow instance
        /// </summary>
        /// <remarks>
        /// Terminates a flow instance
        /// </remarks>
        /// <param name="id">Flow Exec ID</param>
        /// <param name="body">terminate options</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ProcessautomationFlowsInstancesIdCommandsTerminatePostAsyncWithHttpInfo (string id, FlowTerminateRequest body = null);
        
        /// <summary>
        /// Get the history of a flow instance
        /// </summary>
        /// <remarks>
        /// Get the history of a flow instance
        /// </remarks>
        /// <param name="id">Flow Exec ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>FlowHistoryResultItem</returns>
        FlowHistoryResultItem ProcessautomationFlowsInstancesIdHistoryGet (string id, string expand = null);
  
        /// <summary>
        /// Get the history of a flow instance
        /// </summary>
        /// <remarks>
        /// Get the history of a flow instance
        /// </remarks>
        /// <param name="id">Flow Exec ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>ApiResponse of FlowHistoryResultItem</returns>
        ApiResponse<FlowHistoryResultItem> ProcessautomationFlowsInstancesIdHistoryGetWithHttpInfo (string id, string expand = null);

        /// <summary>
        /// Get the history of a flow instance
        /// </summary>
        /// <remarks>
        /// Get the history of a flow instance
        /// </remarks>
        /// <param name="id">Flow Exec ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of FlowHistoryResultItem</returns>
        System.Threading.Tasks.Task<FlowHistoryResultItem> ProcessautomationFlowsInstancesIdHistoryGetAsync (string id, string expand = null);

        /// <summary>
        /// Get the history of a flow instance
        /// </summary>
        /// <remarks>
        /// Get the history of a flow instance
        /// </remarks>
        /// <param name="id">Flow Exec ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of ApiResponse (FlowHistoryResultItem)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowHistoryResultItem>> ProcessautomationFlowsInstancesIdHistoryGetAsyncWithHttpInfo (string id, string expand = null);
        
        /// <summary>
        /// Get all queues for an organization
        /// </summary>
        /// <remarks>
        /// This method will get all the queues defined in your organization.
        /// </remarks>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="name">Search phrase to match on the queue&#39;s name.</param>
        /// <returns>QueuesEntityListing</returns>
        QueuesEntityListing ProcessautomationQueuesGet (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null);
  
        /// <summary>
        /// Get all queues for an organization
        /// </summary>
        /// <remarks>
        /// This method will get all the queues defined in your organization.
        /// </remarks>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="name">Search phrase to match on the queue&#39;s name.</param>
        /// <returns>ApiResponse of QueuesEntityListing</returns>
        ApiResponse<QueuesEntityListing> ProcessautomationQueuesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null);

        /// <summary>
        /// Get all queues for an organization
        /// </summary>
        /// <remarks>
        /// This method will get all the queues defined in your organization.
        /// </remarks>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="name">Search phrase to match on the queue&#39;s name.</param>
        /// <returns>Task of QueuesEntityListing</returns>
        System.Threading.Tasks.Task<QueuesEntityListing> ProcessautomationQueuesGetAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null);

        /// <summary>
        /// Get all queues for an organization
        /// </summary>
        /// <remarks>
        /// This method will get all the queues defined in your organization.
        /// </remarks>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="name">Search phrase to match on the queue&#39;s name.</param>
        /// <returns>Task of ApiResponse (QueuesEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueuesEntityListing>> ProcessautomationQueuesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null);
        
        /// <summary>
        /// Create a new queue object
        /// </summary>
        /// <remarks>
        /// This method will create a new queue and assign it a new id.
        /// </remarks>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body"></param>
        /// <returns>AutomateQueue</returns>
        AutomateQueue ProcessautomationQueuesPost (string expand = null, AutomateQueue body = null);
  
        /// <summary>
        /// Create a new queue object
        /// </summary>
        /// <remarks>
        /// This method will create a new queue and assign it a new id.
        /// </remarks>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of AutomateQueue</returns>
        ApiResponse<AutomateQueue> ProcessautomationQueuesPostWithHttpInfo (string expand = null, AutomateQueue body = null);

        /// <summary>
        /// Create a new queue object
        /// </summary>
        /// <remarks>
        /// This method will create a new queue and assign it a new id.
        /// </remarks>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body"></param>
        /// <returns>Task of AutomateQueue</returns>
        System.Threading.Tasks.Task<AutomateQueue> ProcessautomationQueuesPostAsync (string expand = null, AutomateQueue body = null);

        /// <summary>
        /// Create a new queue object
        /// </summary>
        /// <remarks>
        /// This method will create a new queue and assign it a new id.
        /// </remarks>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (AutomateQueue)</returns>
        System.Threading.Tasks.Task<ApiResponse<AutomateQueue>> ProcessautomationQueuesPostAsyncWithHttpInfo (string expand = null, AutomateQueue body = null);
        
        /// <summary>
        /// Get details about this queue
        /// </summary>
        /// <remarks>
        /// This returns details about the queue like the name and description.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>AutomateQueue</returns>
        AutomateQueue ProcessautomationQueuesIdGet (string id, string expand = null);
  
        /// <summary>
        /// Get details about this queue
        /// </summary>
        /// <remarks>
        /// This returns details about the queue like the name and description.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>ApiResponse of AutomateQueue</returns>
        ApiResponse<AutomateQueue> ProcessautomationQueuesIdGetWithHttpInfo (string id, string expand = null);

        /// <summary>
        /// Get details about this queue
        /// </summary>
        /// <remarks>
        /// This returns details about the queue like the name and description.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of AutomateQueue</returns>
        System.Threading.Tasks.Task<AutomateQueue> ProcessautomationQueuesIdGetAsync (string id, string expand = null);

        /// <summary>
        /// Get details about this queue
        /// </summary>
        /// <remarks>
        /// This returns details about the queue like the name and description.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of ApiResponse (AutomateQueue)</returns>
        System.Threading.Tasks.Task<ApiResponse<AutomateQueue>> ProcessautomationQueuesIdGetAsyncWithHttpInfo (string id, string expand = null);
        
        /// <summary>
        /// Update a queue
        /// </summary>
        /// <remarks>
        /// Update the name and description of a queue.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="body">updated queue</param>
        /// <returns>AutomateQueue</returns>
        AutomateQueue ProcessautomationQueuesIdPut (string id, AutomateQueue body = null);
  
        /// <summary>
        /// Update a queue
        /// </summary>
        /// <remarks>
        /// Update the name and description of a queue.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="body">updated queue</param>
        /// <returns>ApiResponse of AutomateQueue</returns>
        ApiResponse<AutomateQueue> ProcessautomationQueuesIdPutWithHttpInfo (string id, AutomateQueue body = null);

        /// <summary>
        /// Update a queue
        /// </summary>
        /// <remarks>
        /// Update the name and description of a queue.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="body">updated queue</param>
        /// <returns>Task of AutomateQueue</returns>
        System.Threading.Tasks.Task<AutomateQueue> ProcessautomationQueuesIdPutAsync (string id, AutomateQueue body = null);

        /// <summary>
        /// Update a queue
        /// </summary>
        /// <remarks>
        /// Update the name and description of a queue.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <param name="body">updated queue</param>
        /// <returns>Task of ApiResponse (AutomateQueue)</returns>
        System.Threading.Tasks.Task<ApiResponse<AutomateQueue>> ProcessautomationQueuesIdPutAsyncWithHttpInfo (string id, AutomateQueue body = null);
        
        /// <summary>
        /// Delete a queue
        /// </summary>
        /// <remarks>
        /// Removes a queue for an organization.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns></returns>
        void ProcessautomationQueuesIdDelete (string id);
  
        /// <summary>
        /// Delete a queue
        /// </summary>
        /// <remarks>
        /// Removes a queue for an organization.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ProcessautomationQueuesIdDeleteWithHttpInfo (string id);

        /// <summary>
        /// Delete a queue
        /// </summary>
        /// <remarks>
        /// Removes a queue for an organization.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ProcessautomationQueuesIdDeleteAsync (string id);

        /// <summary>
        /// Delete a queue
        /// </summary>
        /// <remarks>
        /// Removes a queue for an organization.
        /// </remarks>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ProcessautomationQueuesIdDeleteAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// Get members in a queue
        /// </summary>
        /// <remarks>
        /// Get the list of members in a queue.
        /// </remarks>
        /// <param name="id">Queue ID</param>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="name">Search phrase to match on the queue member&#39;s name.</param>
        /// <returns>QueueMemberEntityListing</returns>
        QueueMemberEntityListing ProcessautomationQueuesIdMembersGet (string id, int? pageSize = null, int? pageNumber = null, string expand = null, string name = null);
  
        /// <summary>
        /// Get members in a queue
        /// </summary>
        /// <remarks>
        /// Get the list of members in a queue.
        /// </remarks>
        /// <param name="id">Queue ID</param>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="name">Search phrase to match on the queue member&#39;s name.</param>
        /// <returns>ApiResponse of QueueMemberEntityListing</returns>
        ApiResponse<QueueMemberEntityListing> ProcessautomationQueuesIdMembersGetWithHttpInfo (string id, int? pageSize = null, int? pageNumber = null, string expand = null, string name = null);

        /// <summary>
        /// Get members in a queue
        /// </summary>
        /// <remarks>
        /// Get the list of members in a queue.
        /// </remarks>
        /// <param name="id">Queue ID</param>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="name">Search phrase to match on the queue member&#39;s name.</param>
        /// <returns>Task of QueueMemberEntityListing</returns>
        System.Threading.Tasks.Task<QueueMemberEntityListing> ProcessautomationQueuesIdMembersGetAsync (string id, int? pageSize = null, int? pageNumber = null, string expand = null, string name = null);

        /// <summary>
        /// Get members in a queue
        /// </summary>
        /// <remarks>
        /// Get the list of members in a queue.
        /// </remarks>
        /// <param name="id">Queue ID</param>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="name">Search phrase to match on the queue member&#39;s name.</param>
        /// <returns>Task of ApiResponse (QueueMemberEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueMemberEntityListing>> ProcessautomationQueuesIdMembersGetAsyncWithHttpInfo (string id, int? pageSize = null, int? pageNumber = null, string expand = null, string name = null);
        
        /// <summary>
        /// Edit the members in a queue
        /// </summary>
        /// <remarks>
        /// Updates the members of the specified queue from the given list.
        /// </remarks>
        /// <param name="id">Queue ID</param>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">Queue Member List</param>
        /// <returns>QueueMemberEntityListing</returns>
        QueueMemberEntityListing ProcessautomationQueuesIdMembersPut (string id, int? pageSize = null, int? pageNumber = null, string expand = null, List<AutomateQueueMember> body = null);
  
        /// <summary>
        /// Edit the members in a queue
        /// </summary>
        /// <remarks>
        /// Updates the members of the specified queue from the given list.
        /// </remarks>
        /// <param name="id">Queue ID</param>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">Queue Member List</param>
        /// <returns>ApiResponse of QueueMemberEntityListing</returns>
        ApiResponse<QueueMemberEntityListing> ProcessautomationQueuesIdMembersPutWithHttpInfo (string id, int? pageSize = null, int? pageNumber = null, string expand = null, List<AutomateQueueMember> body = null);

        /// <summary>
        /// Edit the members in a queue
        /// </summary>
        /// <remarks>
        /// Updates the members of the specified queue from the given list.
        /// </remarks>
        /// <param name="id">Queue ID</param>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">Queue Member List</param>
        /// <returns>Task of QueueMemberEntityListing</returns>
        System.Threading.Tasks.Task<QueueMemberEntityListing> ProcessautomationQueuesIdMembersPutAsync (string id, int? pageSize = null, int? pageNumber = null, string expand = null, List<AutomateQueueMember> body = null);

        /// <summary>
        /// Edit the members in a queue
        /// </summary>
        /// <remarks>
        /// Updates the members of the specified queue from the given list.
        /// </remarks>
        /// <param name="id">Queue ID</param>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">Queue Member List</param>
        /// <returns>Task of ApiResponse (QueueMemberEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueMemberEntityListing>> ProcessautomationQueuesIdMembersPutAsyncWithHttpInfo (string id, int? pageSize = null, int? pageNumber = null, string expand = null, List<AutomateQueueMember> body = null);
        
        /// <summary>
        /// Get a member from a queue
        /// </summary>
        /// <remarks>
        /// This will get the specified member from the queue.
        /// </remarks>
        /// <param name="id">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>AutomateQueueMember</returns>
        AutomateQueueMember ProcessautomationQueuesIdMembersMemberidGet (string id, string memberId, string expand = null);
  
        /// <summary>
        /// Get a member from a queue
        /// </summary>
        /// <remarks>
        /// This will get the specified member from the queue.
        /// </remarks>
        /// <param name="id">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>ApiResponse of AutomateQueueMember</returns>
        ApiResponse<AutomateQueueMember> ProcessautomationQueuesIdMembersMemberidGetWithHttpInfo (string id, string memberId, string expand = null);

        /// <summary>
        /// Get a member from a queue
        /// </summary>
        /// <remarks>
        /// This will get the specified member from the queue.
        /// </remarks>
        /// <param name="id">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of AutomateQueueMember</returns>
        System.Threading.Tasks.Task<AutomateQueueMember> ProcessautomationQueuesIdMembersMemberidGetAsync (string id, string memberId, string expand = null);

        /// <summary>
        /// Get a member from a queue
        /// </summary>
        /// <remarks>
        /// This will get the specified member from the queue.
        /// </remarks>
        /// <param name="id">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of ApiResponse (AutomateQueueMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<AutomateQueueMember>> ProcessautomationQueuesIdMembersMemberidGetAsyncWithHttpInfo (string id, string memberId, string expand = null);
        
        /// <summary>
        /// Add a member to a queue
        /// </summary>
        /// <remarks>
        /// This will add the specified member to the given queue.
        /// </remarks>
        /// <param name="id">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">Queue Member</param>
        /// <returns>AutomateQueueMember</returns>
        AutomateQueueMember ProcessautomationQueuesIdMembersMemberidPut (string id, string memberId, string expand = null, AutomateQueueMember body = null);
  
        /// <summary>
        /// Add a member to a queue
        /// </summary>
        /// <remarks>
        /// This will add the specified member to the given queue.
        /// </remarks>
        /// <param name="id">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">Queue Member</param>
        /// <returns>ApiResponse of AutomateQueueMember</returns>
        ApiResponse<AutomateQueueMember> ProcessautomationQueuesIdMembersMemberidPutWithHttpInfo (string id, string memberId, string expand = null, AutomateQueueMember body = null);

        /// <summary>
        /// Add a member to a queue
        /// </summary>
        /// <remarks>
        /// This will add the specified member to the given queue.
        /// </remarks>
        /// <param name="id">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">Queue Member</param>
        /// <returns>Task of AutomateQueueMember</returns>
        System.Threading.Tasks.Task<AutomateQueueMember> ProcessautomationQueuesIdMembersMemberidPutAsync (string id, string memberId, string expand = null, AutomateQueueMember body = null);

        /// <summary>
        /// Add a member to a queue
        /// </summary>
        /// <remarks>
        /// This will add the specified member to the given queue.
        /// </remarks>
        /// <param name="id">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">Queue Member</param>
        /// <returns>Task of ApiResponse (AutomateQueueMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<AutomateQueueMember>> ProcessautomationQueuesIdMembersMemberidPutAsyncWithHttpInfo (string id, string memberId, string expand = null, AutomateQueueMember body = null);
        
        /// <summary>
        /// Delete a member from a queue
        /// </summary>
        /// <remarks>
        /// This will delete the specified member from the given queue.
        /// </remarks>
        /// <param name="id">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns></returns>
        void ProcessautomationQueuesIdMembersMemberidDelete (string id, string memberId);
  
        /// <summary>
        /// Delete a member from a queue
        /// </summary>
        /// <remarks>
        /// This will delete the specified member from the given queue.
        /// </remarks>
        /// <param name="id">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ProcessautomationQueuesIdMembersMemberidDeleteWithHttpInfo (string id, string memberId);

        /// <summary>
        /// Delete a member from a queue
        /// </summary>
        /// <remarks>
        /// This will delete the specified member from the given queue.
        /// </remarks>
        /// <param name="id">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ProcessautomationQueuesIdMembersMemberidDeleteAsync (string id, string memberId);

        /// <summary>
        /// Delete a member from a queue
        /// </summary>
        /// <remarks>
        /// This will delete the specified member from the given queue.
        /// </remarks>
        /// <param name="id">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ProcessautomationQueuesIdMembersMemberidDeleteAsyncWithHttpInfo (string id, string memberId);
        
        /// <summary>
        /// Generates a list of active and/or completed flows based upon the specified filters and facets.
        /// </summary>
        /// <remarks>
        /// Searches the pool of running and completed flow instances given a ReportRequest object and returns the matching results.
        /// </remarks>
        /// <param name="body">ReportRequest data containing search parameters and paging response.</param>
        /// <returns>FlowReportResultItem</returns>
        FlowReportResultItem ProcessautomationReportsFlowSearchPost (ReportRequest body);
  
        /// <summary>
        /// Generates a list of active and/or completed flows based upon the specified filters and facets.
        /// </summary>
        /// <remarks>
        /// Searches the pool of running and completed flow instances given a ReportRequest object and returns the matching results.
        /// </remarks>
        /// <param name="body">ReportRequest data containing search parameters and paging response.</param>
        /// <returns>ApiResponse of FlowReportResultItem</returns>
        ApiResponse<FlowReportResultItem> ProcessautomationReportsFlowSearchPostWithHttpInfo (ReportRequest body);

        /// <summary>
        /// Generates a list of active and/or completed flows based upon the specified filters and facets.
        /// </summary>
        /// <remarks>
        /// Searches the pool of running and completed flow instances given a ReportRequest object and returns the matching results.
        /// </remarks>
        /// <param name="body">ReportRequest data containing search parameters and paging response.</param>
        /// <returns>Task of FlowReportResultItem</returns>
        System.Threading.Tasks.Task<FlowReportResultItem> ProcessautomationReportsFlowSearchPostAsync (ReportRequest body);

        /// <summary>
        /// Generates a list of active and/or completed flows based upon the specified filters and facets.
        /// </summary>
        /// <remarks>
        /// Searches the pool of running and completed flow instances given a ReportRequest object and returns the matching results.
        /// </remarks>
        /// <param name="body">ReportRequest data containing search parameters and paging response.</param>
        /// <returns>Task of ApiResponse (FlowReportResultItem)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowReportResultItem>> ProcessautomationReportsFlowSearchPostAsyncWithHttpInfo (ReportRequest body);
        
        /// <summary>
        /// Search the currently running workitems
        /// </summary>
        /// <remarks>
        /// Searches the pool of running workitems given a SearchRequest object and returns the results.  Some search examples:&lt;br&gt;Note the various filters, sort and searchPhrase options can be combined/omitted as needed.&lt;br&gt;Search for a specific definition id:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowConfigId.id\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;e88db9fb-aaa0-46f8-81d5-4a30e323bdfa\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;&lt;br&gt;Search for a specific execution instance and sort on the config name:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowExecId\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;99\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;],&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sort\&quot; : [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;:\&quot;flowConfigName\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sortType\&quot;:\&quot;ASCENDING\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;Search for a specific phrase:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;searchPhrase\&quot; : \&quot;hi mom!\&quot; &lt;br&gt;}&lt;br&gt;
        /// </remarks>
        /// <param name="body">SearchRequest data containing search parameters and paging response.</param>
        /// <returns>WorkItemSearchDetailsSearchResult</returns>
        WorkItemSearchDetailsSearchResult ProcessautomationWorkitemsInstancesCommandsSearchPost (SearchRequest body);
  
        /// <summary>
        /// Search the currently running workitems
        /// </summary>
        /// <remarks>
        /// Searches the pool of running workitems given a SearchRequest object and returns the results.  Some search examples:&lt;br&gt;Note the various filters, sort and searchPhrase options can be combined/omitted as needed.&lt;br&gt;Search for a specific definition id:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowConfigId.id\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;e88db9fb-aaa0-46f8-81d5-4a30e323bdfa\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;&lt;br&gt;Search for a specific execution instance and sort on the config name:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowExecId\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;99\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;],&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sort\&quot; : [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;:\&quot;flowConfigName\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sortType\&quot;:\&quot;ASCENDING\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;Search for a specific phrase:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;searchPhrase\&quot; : \&quot;hi mom!\&quot; &lt;br&gt;}&lt;br&gt;
        /// </remarks>
        /// <param name="body">SearchRequest data containing search parameters and paging response.</param>
        /// <returns>ApiResponse of WorkItemSearchDetailsSearchResult</returns>
        ApiResponse<WorkItemSearchDetailsSearchResult> ProcessautomationWorkitemsInstancesCommandsSearchPostWithHttpInfo (SearchRequest body);

        /// <summary>
        /// Search the currently running workitems
        /// </summary>
        /// <remarks>
        /// Searches the pool of running workitems given a SearchRequest object and returns the results.  Some search examples:&lt;br&gt;Note the various filters, sort and searchPhrase options can be combined/omitted as needed.&lt;br&gt;Search for a specific definition id:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowConfigId.id\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;e88db9fb-aaa0-46f8-81d5-4a30e323bdfa\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;&lt;br&gt;Search for a specific execution instance and sort on the config name:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowExecId\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;99\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;],&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sort\&quot; : [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;:\&quot;flowConfigName\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sortType\&quot;:\&quot;ASCENDING\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;Search for a specific phrase:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;searchPhrase\&quot; : \&quot;hi mom!\&quot; &lt;br&gt;}&lt;br&gt;
        /// </remarks>
        /// <param name="body">SearchRequest data containing search parameters and paging response.</param>
        /// <returns>Task of WorkItemSearchDetailsSearchResult</returns>
        System.Threading.Tasks.Task<WorkItemSearchDetailsSearchResult> ProcessautomationWorkitemsInstancesCommandsSearchPostAsync (SearchRequest body);

        /// <summary>
        /// Search the currently running workitems
        /// </summary>
        /// <remarks>
        /// Searches the pool of running workitems given a SearchRequest object and returns the results.  Some search examples:&lt;br&gt;Note the various filters, sort and searchPhrase options can be combined/omitted as needed.&lt;br&gt;Search for a specific definition id:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowConfigId.id\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;e88db9fb-aaa0-46f8-81d5-4a30e323bdfa\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;&lt;br&gt;Search for a specific execution instance and sort on the config name:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowExecId\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;99\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;],&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sort\&quot; : [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;:\&quot;flowConfigName\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sortType\&quot;:\&quot;ASCENDING\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;Search for a specific phrase:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;searchPhrase\&quot; : \&quot;hi mom!\&quot; &lt;br&gt;}&lt;br&gt;
        /// </remarks>
        /// <param name="body">SearchRequest data containing search parameters and paging response.</param>
        /// <returns>Task of ApiResponse (WorkItemSearchDetailsSearchResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkItemSearchDetailsSearchResult>> ProcessautomationWorkitemsInstancesCommandsSearchPostAsyncWithHttpInfo (SearchRequest body);
        
        /// <summary>
        /// Get a Work Item&#39;s Details
        /// </summary>
        /// <remarks>
        /// Gets the details of a work item including the information needed to display its simple form, if it has one.
        /// </remarks>
        /// <param name="id">Work Item Exec ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>WorkItemDetails</returns>
        WorkItemDetails ProcessautomationWorkitemsInstancesIdGet (string id, string expand = null);
  
        /// <summary>
        /// Get a Work Item&#39;s Details
        /// </summary>
        /// <remarks>
        /// Gets the details of a work item including the information needed to display its simple form, if it has one.
        /// </remarks>
        /// <param name="id">Work Item Exec ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>ApiResponse of WorkItemDetails</returns>
        ApiResponse<WorkItemDetails> ProcessautomationWorkitemsInstancesIdGetWithHttpInfo (string id, string expand = null);

        /// <summary>
        /// Get a Work Item&#39;s Details
        /// </summary>
        /// <remarks>
        /// Gets the details of a work item including the information needed to display its simple form, if it has one.
        /// </remarks>
        /// <param name="id">Work Item Exec ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of WorkItemDetails</returns>
        System.Threading.Tasks.Task<WorkItemDetails> ProcessautomationWorkitemsInstancesIdGetAsync (string id, string expand = null);

        /// <summary>
        /// Get a Work Item&#39;s Details
        /// </summary>
        /// <remarks>
        /// Gets the details of a work item including the information needed to display its simple form, if it has one.
        /// </remarks>
        /// <param name="id">Work Item Exec ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of ApiResponse (WorkItemDetails)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkItemDetails>> ProcessautomationWorkitemsInstancesIdGetAsyncWithHttpInfo (string id, string expand = null);
        
        /// <summary>
        /// Submits a work item
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;Signals the flow to continue executing using the specified command of the given work item.&lt;/p&gt;&lt;p&gt;Common error conditions to be aware of are:&lt;dl&gt;&lt;dd&gt;error.workflow.flows.workItem.ownership - the given user was denied the ability to own the work item&lt;/dd&gt;&lt;dd&gt;error.workflow.flows.workItem.owned - the work item is already owned by somebody else&lt;/dd&gt;&lt;dd&gt;error.workflow.flows.workItem.notExist - the work item does not exist, possibly because it was already submitted by someone else&lt;/dd&gt;&lt;dd&gt;error.workflow.flows.workItem.submit - some other error submitting the work item&lt;/dd&gt;&lt;/dl&gt;&lt;/p&gt;
        /// </remarks>
        /// <param name="id">Work Item Exec ID</param>
        /// <param name="body">submit request data</param>
        /// <returns></returns>
        void ProcessautomationWorkitemsInstancesIdCommandsSubmitPost (string id, WorkItemSubmitRequest body = null);
  
        /// <summary>
        /// Submits a work item
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;Signals the flow to continue executing using the specified command of the given work item.&lt;/p&gt;&lt;p&gt;Common error conditions to be aware of are:&lt;dl&gt;&lt;dd&gt;error.workflow.flows.workItem.ownership - the given user was denied the ability to own the work item&lt;/dd&gt;&lt;dd&gt;error.workflow.flows.workItem.owned - the work item is already owned by somebody else&lt;/dd&gt;&lt;dd&gt;error.workflow.flows.workItem.notExist - the work item does not exist, possibly because it was already submitted by someone else&lt;/dd&gt;&lt;dd&gt;error.workflow.flows.workItem.submit - some other error submitting the work item&lt;/dd&gt;&lt;/dl&gt;&lt;/p&gt;
        /// </remarks>
        /// <param name="id">Work Item Exec ID</param>
        /// <param name="body">submit request data</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ProcessautomationWorkitemsInstancesIdCommandsSubmitPostWithHttpInfo (string id, WorkItemSubmitRequest body = null);

        /// <summary>
        /// Submits a work item
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;Signals the flow to continue executing using the specified command of the given work item.&lt;/p&gt;&lt;p&gt;Common error conditions to be aware of are:&lt;dl&gt;&lt;dd&gt;error.workflow.flows.workItem.ownership - the given user was denied the ability to own the work item&lt;/dd&gt;&lt;dd&gt;error.workflow.flows.workItem.owned - the work item is already owned by somebody else&lt;/dd&gt;&lt;dd&gt;error.workflow.flows.workItem.notExist - the work item does not exist, possibly because it was already submitted by someone else&lt;/dd&gt;&lt;dd&gt;error.workflow.flows.workItem.submit - some other error submitting the work item&lt;/dd&gt;&lt;/dl&gt;&lt;/p&gt;
        /// </remarks>
        /// <param name="id">Work Item Exec ID</param>
        /// <param name="body">submit request data</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ProcessautomationWorkitemsInstancesIdCommandsSubmitPostAsync (string id, WorkItemSubmitRequest body = null);

        /// <summary>
        /// Submits a work item
        /// </summary>
        /// <remarks>
        /// &lt;p&gt;Signals the flow to continue executing using the specified command of the given work item.&lt;/p&gt;&lt;p&gt;Common error conditions to be aware of are:&lt;dl&gt;&lt;dd&gt;error.workflow.flows.workItem.ownership - the given user was denied the ability to own the work item&lt;/dd&gt;&lt;dd&gt;error.workflow.flows.workItem.owned - the work item is already owned by somebody else&lt;/dd&gt;&lt;dd&gt;error.workflow.flows.workItem.notExist - the work item does not exist, possibly because it was already submitted by someone else&lt;/dd&gt;&lt;dd&gt;error.workflow.flows.workItem.submit - some other error submitting the work item&lt;/dd&gt;&lt;/dl&gt;&lt;/p&gt;
        /// </remarks>
        /// <param name="id">Work Item Exec ID</param>
        /// <param name="body">submit request data</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ProcessautomationWorkitemsInstancesIdCommandsSubmitPostAsyncWithHttpInfo (string id, WorkItemSubmitRequest body = null);
        
        /// <summary>
        /// Attempts to take ownership of a work item
        /// </summary>
        /// <remarks>
        /// Basically, this is called by a client to assign ownership to the currently connected user.  Only the user that has ownership can submit against a work item.  This will be rejected is someone else owns it, like if it’s in a queue and somebody grabs it at the same time.  The first guy wins the ownership.
        /// </remarks>
        /// <param name="id">Work Item Exec ID</param>
        /// <returns></returns>
        void ProcessautomationWorkitemsInstancesIdCommandsTakeownershipPost (string id);
  
        /// <summary>
        /// Attempts to take ownership of a work item
        /// </summary>
        /// <remarks>
        /// Basically, this is called by a client to assign ownership to the currently connected user.  Only the user that has ownership can submit against a work item.  This will be rejected is someone else owns it, like if it’s in a queue and somebody grabs it at the same time.  The first guy wins the ownership.
        /// </remarks>
        /// <param name="id">Work Item Exec ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ProcessautomationWorkitemsInstancesIdCommandsTakeownershipPostWithHttpInfo (string id);

        /// <summary>
        /// Attempts to take ownership of a work item
        /// </summary>
        /// <remarks>
        /// Basically, this is called by a client to assign ownership to the currently connected user.  Only the user that has ownership can submit against a work item.  This will be rejected is someone else owns it, like if it’s in a queue and somebody grabs it at the same time.  The first guy wins the ownership.
        /// </remarks>
        /// <param name="id">Work Item Exec ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ProcessautomationWorkitemsInstancesIdCommandsTakeownershipPostAsync (string id);

        /// <summary>
        /// Attempts to take ownership of a work item
        /// </summary>
        /// <remarks>
        /// Basically, this is called by a client to assign ownership to the currently connected user.  Only the user that has ownership can submit against a work item.  This will be rejected is someone else owns it, like if it’s in a queue and somebody grabs it at the same time.  The first guy wins the ownership.
        /// </remarks>
        /// <param name="id">Work Item Exec ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ProcessautomationWorkitemsInstancesIdCommandsTakeownershipPostAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// Transfers a work item
        /// </summary>
        /// <remarks>
        /// Unassigns a work item, if currently assigned, and offers a work item to another user or queue; the work item is initially unassigned (meaning un-owned).   You have to own the item to transfer it, unless you’re an admin and using a “force” flag.
        /// </remarks>
        /// <param name="id">Work Item Exec ID</param>
        /// <param name="body">transfer request data</param>
        /// <returns></returns>
        void ProcessautomationWorkitemsInstancesIdCommandsTransferPost (string id, WorkItemTransferRequest body = null);
  
        /// <summary>
        /// Transfers a work item
        /// </summary>
        /// <remarks>
        /// Unassigns a work item, if currently assigned, and offers a work item to another user or queue; the work item is initially unassigned (meaning un-owned).   You have to own the item to transfer it, unless you’re an admin and using a “force” flag.
        /// </remarks>
        /// <param name="id">Work Item Exec ID</param>
        /// <param name="body">transfer request data</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ProcessautomationWorkitemsInstancesIdCommandsTransferPostWithHttpInfo (string id, WorkItemTransferRequest body = null);

        /// <summary>
        /// Transfers a work item
        /// </summary>
        /// <remarks>
        /// Unassigns a work item, if currently assigned, and offers a work item to another user or queue; the work item is initially unassigned (meaning un-owned).   You have to own the item to transfer it, unless you’re an admin and using a “force” flag.
        /// </remarks>
        /// <param name="id">Work Item Exec ID</param>
        /// <param name="body">transfer request data</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ProcessautomationWorkitemsInstancesIdCommandsTransferPostAsync (string id, WorkItemTransferRequest body = null);

        /// <summary>
        /// Transfers a work item
        /// </summary>
        /// <remarks>
        /// Unassigns a work item, if currently assigned, and offers a work item to another user or queue; the work item is initially unassigned (meaning un-owned).   You have to own the item to transfer it, unless you’re an admin and using a “force” flag.
        /// </remarks>
        /// <param name="id">Work Item Exec ID</param>
        /// <param name="body">transfer request data</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ProcessautomationWorkitemsInstancesIdCommandsTransferPostAsyncWithHttpInfo (string id, WorkItemTransferRequest body = null);
        
        /// <summary>
        /// Gets an optional cache for a given workItem.
        /// </summary>
        /// <remarks>
        /// Gets a user saved cache of workItem data.
        /// </remarks>
        /// <param name="id">Work Item Exec ID</param>
        /// <returns>WorkItemCache</returns>
        WorkItemCache ProcessautomationWorkitemsInstancesIdWorkitemcacheGet (string id);
  
        /// <summary>
        /// Gets an optional cache for a given workItem.
        /// </summary>
        /// <remarks>
        /// Gets a user saved cache of workItem data.
        /// </remarks>
        /// <param name="id">Work Item Exec ID</param>
        /// <returns>ApiResponse of WorkItemCache</returns>
        ApiResponse<WorkItemCache> ProcessautomationWorkitemsInstancesIdWorkitemcacheGetWithHttpInfo (string id);

        /// <summary>
        /// Gets an optional cache for a given workItem.
        /// </summary>
        /// <remarks>
        /// Gets a user saved cache of workItem data.
        /// </remarks>
        /// <param name="id">Work Item Exec ID</param>
        /// <returns>Task of WorkItemCache</returns>
        System.Threading.Tasks.Task<WorkItemCache> ProcessautomationWorkitemsInstancesIdWorkitemcacheGetAsync (string id);

        /// <summary>
        /// Gets an optional cache for a given workItem.
        /// </summary>
        /// <remarks>
        /// Gets a user saved cache of workItem data.
        /// </remarks>
        /// <param name="id">Work Item Exec ID</param>
        /// <returns>Task of ApiResponse (WorkItemCache)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkItemCache>> ProcessautomationWorkitemsInstancesIdWorkitemcacheGetAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// Saves workItem data to a temporary location.
        /// </summary>
        /// <remarks>
        /// The cache is automatically deleted when a workItem is submitted.
        /// </remarks>
        /// <param name="id">Work Item Exec ID</param>
        /// <param name="body">workItem cache data</param>
        /// <returns></returns>
        void ProcessautomationWorkitemsInstancesIdWorkitemcachePut (string id, WorkItemCache body = null);
  
        /// <summary>
        /// Saves workItem data to a temporary location.
        /// </summary>
        /// <remarks>
        /// The cache is automatically deleted when a workItem is submitted.
        /// </remarks>
        /// <param name="id">Work Item Exec ID</param>
        /// <param name="body">workItem cache data</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ProcessautomationWorkitemsInstancesIdWorkitemcachePutWithHttpInfo (string id, WorkItemCache body = null);

        /// <summary>
        /// Saves workItem data to a temporary location.
        /// </summary>
        /// <remarks>
        /// The cache is automatically deleted when a workItem is submitted.
        /// </remarks>
        /// <param name="id">Work Item Exec ID</param>
        /// <param name="body">workItem cache data</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ProcessautomationWorkitemsInstancesIdWorkitemcachePutAsync (string id, WorkItemCache body = null);

        /// <summary>
        /// Saves workItem data to a temporary location.
        /// </summary>
        /// <remarks>
        /// The cache is automatically deleted when a workItem is submitted.
        /// </remarks>
        /// <param name="id">Work Item Exec ID</param>
        /// <param name="body">workItem cache data</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ProcessautomationWorkitemsInstancesIdWorkitemcachePutAsyncWithHttpInfo (string id, WorkItemCache body = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ProcessAutomationApi : IProcessAutomationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessAutomationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProcessAutomationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessAutomationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProcessAutomationApi(Configuration configuration = null)
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
        /// Get flow history by Document Gets the flow history elements for flows that related to the given document.
        /// </summary>
        /// <param name="id">ID</param> 
        /// <returns>FlowHistoryResultItemEntityListing</returns>
        public FlowHistoryResultItemEntityListing ProcessautomationAssociationsDocumentsIdHistoryGet (string id)
        {
             ApiResponse<FlowHistoryResultItemEntityListing> response = ProcessautomationAssociationsDocumentsIdHistoryGetWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        /// Get flow history by Document Gets the flow history elements for flows that related to the given document.
        /// </summary>
        /// <param name="id">ID</param> 
        /// <returns>ApiResponse of FlowHistoryResultItemEntityListing</returns>
        public ApiResponse< FlowHistoryResultItemEntityListing > ProcessautomationAssociationsDocumentsIdHistoryGetWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationAssociationsDocumentsIdHistoryGet");
            
    
            var path_ = "/api/v1/processautomation/associations/documents/{id}/history";
    
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
                throw new ApiException (statusCode, "Error calling ProcessautomationAssociationsDocumentsIdHistoryGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationAssociationsDocumentsIdHistoryGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FlowHistoryResultItemEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowHistoryResultItemEntityListing) Configuration.ApiClient.Deserialize(response, typeof(FlowHistoryResultItemEntityListing)));
            
        }
    
        /// <summary>
        /// Get flow history by Document Gets the flow history elements for flows that related to the given document.
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Task of FlowHistoryResultItemEntityListing</returns>
        public async System.Threading.Tasks.Task<FlowHistoryResultItemEntityListing> ProcessautomationAssociationsDocumentsIdHistoryGetAsync (string id)
        {
             ApiResponse<FlowHistoryResultItemEntityListing> response = await ProcessautomationAssociationsDocumentsIdHistoryGetAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        /// Get flow history by Document Gets the flow history elements for flows that related to the given document.
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse (FlowHistoryResultItemEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowHistoryResultItemEntityListing>> ProcessautomationAssociationsDocumentsIdHistoryGetAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationAssociationsDocumentsIdHistoryGet");
            
    
            var path_ = "/api/v1/processautomation/associations/documents/{id}/history";
    
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
                throw new ApiException (statusCode, "Error calling ProcessautomationAssociationsDocumentsIdHistoryGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationAssociationsDocumentsIdHistoryGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FlowHistoryResultItemEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowHistoryResultItemEntityListing) Configuration.ApiClient.Deserialize(response, typeof(FlowHistoryResultItemEntityListing)));
            
        }
        
        /// <summary>
        /// Get all base flows for an organization This method will get all the flows defined in your organization.&lt;br&gt; The method will get the flows without regard to individual versions.  So a particular flow might have many versions but only a single entry representing them all as a unit will be returned.&lt;br&gt;&lt;br&gt;The method supports two kinds of filters on what data gets returned:&lt;br&gt;&lt;p&gt;+  The &#39;typeFilter&#39; param can be a comma-separated list of flow types that you want, or empty/omitted to get them all. Currently only the Workflow type is supported, but in the future other might be supported as well.&lt;/p&gt;&lt;br&gt;&lt;p&gt;+  The &#39;stateFilter&#39; param can be a comma-separated list of state types, or empty/omitted to get them all.\n So values like \&quot;Active,Inactive,Deleted\&quot; or any combination thereof are appropriate here.&lt;/p&gt;&lt;br&gt;&lt;p&gt;+  The &#39;permissionFilter&#39; param can be a comma-separated list of permissions you want to limit the list to, or empty/omitted to get them all.\n So a value like \&quot;Launch\&quot; is useful here to just get the flows you&#39;re permitted to launch.&lt;/p&gt;
        /// </summary>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param> 
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param> 
        /// <param name="typeFilter">A comma-separated list of flow types that you want, or empty/omitted to get them all.</param> 
        /// <param name="stateFilter">A comma-separated list of state types, or empty/omitted to get them all.</param> 
        /// <param name="permissionFilter">A comma-separated list of permissions to restrict by, or empty/omitted to get them all.</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <param name="sortFields">A list of field names of the format xxx.ASC or xxx.DESC. Declare each entry SEPARATELY on the parameter list (EG &amp;sortFields=name.ASC&amp;sortFields=user.DESC</param> 
        /// <returns>FlowConfigMetaDataEntityListing</returns>
        public FlowConfigMetaDataEntityListing ProcessautomationFlowsDefinitionsGet (int? pageSize = null, int? pageNumber = null, string typeFilter = null, string stateFilter = null, string permissionFilter = null, string expand = null, List<string> sortFields = null)
        {
             ApiResponse<FlowConfigMetaDataEntityListing> response = ProcessautomationFlowsDefinitionsGetWithHttpInfo(pageSize, pageNumber, typeFilter, stateFilter, permissionFilter, expand, sortFields);
             return response.Data;
        }

        /// <summary>
        /// Get all base flows for an organization This method will get all the flows defined in your organization.&lt;br&gt; The method will get the flows without regard to individual versions.  So a particular flow might have many versions but only a single entry representing them all as a unit will be returned.&lt;br&gt;&lt;br&gt;The method supports two kinds of filters on what data gets returned:&lt;br&gt;&lt;p&gt;+  The &#39;typeFilter&#39; param can be a comma-separated list of flow types that you want, or empty/omitted to get them all. Currently only the Workflow type is supported, but in the future other might be supported as well.&lt;/p&gt;&lt;br&gt;&lt;p&gt;+  The &#39;stateFilter&#39; param can be a comma-separated list of state types, or empty/omitted to get them all.\n So values like \&quot;Active,Inactive,Deleted\&quot; or any combination thereof are appropriate here.&lt;/p&gt;&lt;br&gt;&lt;p&gt;+  The &#39;permissionFilter&#39; param can be a comma-separated list of permissions you want to limit the list to, or empty/omitted to get them all.\n So a value like \&quot;Launch\&quot; is useful here to just get the flows you&#39;re permitted to launch.&lt;/p&gt;
        /// </summary>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param> 
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param> 
        /// <param name="typeFilter">A comma-separated list of flow types that you want, or empty/omitted to get them all.</param> 
        /// <param name="stateFilter">A comma-separated list of state types, or empty/omitted to get them all.</param> 
        /// <param name="permissionFilter">A comma-separated list of permissions to restrict by, or empty/omitted to get them all.</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <param name="sortFields">A list of field names of the format xxx.ASC or xxx.DESC. Declare each entry SEPARATELY on the parameter list (EG &amp;sortFields=name.ASC&amp;sortFields=user.DESC</param> 
        /// <returns>ApiResponse of FlowConfigMetaDataEntityListing</returns>
        public ApiResponse< FlowConfigMetaDataEntityListing > ProcessautomationFlowsDefinitionsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string typeFilter = null, string stateFilter = null, string permissionFilter = null, string expand = null, List<string> sortFields = null)
        {
            
    
            var path_ = "/api/v1/processautomation/flows/definitions";
    
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
            if (typeFilter != null) queryParams.Add("typeFilter", Configuration.ApiClient.ParameterToString(typeFilter)); // query parameter
            if (stateFilter != null) queryParams.Add("stateFilter", Configuration.ApiClient.ParameterToString(stateFilter)); // query parameter
            if (permissionFilter != null) queryParams.Add("permissionFilter", Configuration.ApiClient.ParameterToString(permissionFilter)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (sortFields != null) queryParams.Add("sortFields", Configuration.ApiClient.ParameterToString(sortFields)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FlowConfigMetaDataEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowConfigMetaDataEntityListing) Configuration.ApiClient.Deserialize(response, typeof(FlowConfigMetaDataEntityListing)));
            
        }
    
        /// <summary>
        /// Get all base flows for an organization This method will get all the flows defined in your organization.&lt;br&gt; The method will get the flows without regard to individual versions.  So a particular flow might have many versions but only a single entry representing them all as a unit will be returned.&lt;br&gt;&lt;br&gt;The method supports two kinds of filters on what data gets returned:&lt;br&gt;&lt;p&gt;+  The &#39;typeFilter&#39; param can be a comma-separated list of flow types that you want, or empty/omitted to get them all. Currently only the Workflow type is supported, but in the future other might be supported as well.&lt;/p&gt;&lt;br&gt;&lt;p&gt;+  The &#39;stateFilter&#39; param can be a comma-separated list of state types, or empty/omitted to get them all.\n So values like \&quot;Active,Inactive,Deleted\&quot; or any combination thereof are appropriate here.&lt;/p&gt;&lt;br&gt;&lt;p&gt;+  The &#39;permissionFilter&#39; param can be a comma-separated list of permissions you want to limit the list to, or empty/omitted to get them all.\n So a value like \&quot;Launch\&quot; is useful here to just get the flows you&#39;re permitted to launch.&lt;/p&gt;
        /// </summary>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param>
        /// <param name="typeFilter">A comma-separated list of flow types that you want, or empty/omitted to get them all.</param>
        /// <param name="stateFilter">A comma-separated list of state types, or empty/omitted to get them all.</param>
        /// <param name="permissionFilter">A comma-separated list of permissions to restrict by, or empty/omitted to get them all.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="sortFields">A list of field names of the format xxx.ASC or xxx.DESC. Declare each entry SEPARATELY on the parameter list (EG &amp;sortFields=name.ASC&amp;sortFields=user.DESC</param>
        /// <returns>Task of FlowConfigMetaDataEntityListing</returns>
        public async System.Threading.Tasks.Task<FlowConfigMetaDataEntityListing> ProcessautomationFlowsDefinitionsGetAsync (int? pageSize = null, int? pageNumber = null, string typeFilter = null, string stateFilter = null, string permissionFilter = null, string expand = null, List<string> sortFields = null)
        {
             ApiResponse<FlowConfigMetaDataEntityListing> response = await ProcessautomationFlowsDefinitionsGetAsyncWithHttpInfo(pageSize, pageNumber, typeFilter, stateFilter, permissionFilter, expand, sortFields);
             return response.Data;

        }

        /// <summary>
        /// Get all base flows for an organization This method will get all the flows defined in your organization.&lt;br&gt; The method will get the flows without regard to individual versions.  So a particular flow might have many versions but only a single entry representing them all as a unit will be returned.&lt;br&gt;&lt;br&gt;The method supports two kinds of filters on what data gets returned:&lt;br&gt;&lt;p&gt;+  The &#39;typeFilter&#39; param can be a comma-separated list of flow types that you want, or empty/omitted to get them all. Currently only the Workflow type is supported, but in the future other might be supported as well.&lt;/p&gt;&lt;br&gt;&lt;p&gt;+  The &#39;stateFilter&#39; param can be a comma-separated list of state types, or empty/omitted to get them all.\n So values like \&quot;Active,Inactive,Deleted\&quot; or any combination thereof are appropriate here.&lt;/p&gt;&lt;br&gt;&lt;p&gt;+  The &#39;permissionFilter&#39; param can be a comma-separated list of permissions you want to limit the list to, or empty/omitted to get them all.\n So a value like \&quot;Launch\&quot; is useful here to just get the flows you&#39;re permitted to launch.&lt;/p&gt;
        /// </summary>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param>
        /// <param name="typeFilter">A comma-separated list of flow types that you want, or empty/omitted to get them all.</param>
        /// <param name="stateFilter">A comma-separated list of state types, or empty/omitted to get them all.</param>
        /// <param name="permissionFilter">A comma-separated list of permissions to restrict by, or empty/omitted to get them all.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="sortFields">A list of field names of the format xxx.ASC or xxx.DESC. Declare each entry SEPARATELY on the parameter list (EG &amp;sortFields=name.ASC&amp;sortFields=user.DESC</param>
        /// <returns>Task of ApiResponse (FlowConfigMetaDataEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowConfigMetaDataEntityListing>> ProcessautomationFlowsDefinitionsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string typeFilter = null, string stateFilter = null, string permissionFilter = null, string expand = null, List<string> sortFields = null)
        {
            
    
            var path_ = "/api/v1/processautomation/flows/definitions";
    
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
            if (typeFilter != null) queryParams.Add("typeFilter", Configuration.ApiClient.ParameterToString(typeFilter)); // query parameter
            if (stateFilter != null) queryParams.Add("stateFilter", Configuration.ApiClient.ParameterToString(stateFilter)); // query parameter
            if (permissionFilter != null) queryParams.Add("permissionFilter", Configuration.ApiClient.ParameterToString(permissionFilter)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (sortFields != null) queryParams.Add("sortFields", Configuration.ApiClient.ParameterToString(sortFields)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FlowConfigMetaDataEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowConfigMetaDataEntityListing) Configuration.ApiClient.Deserialize(response, typeof(FlowConfigMetaDataEntityListing)));
            
        }
        
        /// <summary>
        /// create a new base flow object The base flows are the flow that don&#39;t consider the specific versions of that flow - the base flow refers to all of its versions as one unit.  So base flows have a one-to-many relationship with versioned flows.&lt;br&gt;&lt;br&gt;This method will create a new base flow object, and assign it a new id.&lt;br&gt;&lt;br&gt;The usual process is that you&#39;ll want to create a base flow first, giving the flow a name and description which apply to all the versions as a whole, then create one or more versioned flows that reference that base.
        /// </summary>
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <param name="body"></param> 
        /// <returns>FlowConfigMetaData</returns>
        public FlowConfigMetaData ProcessautomationFlowsDefinitionsPost (string expand = null, FlowConfigMetaData body = null)
        {
             ApiResponse<FlowConfigMetaData> response = ProcessautomationFlowsDefinitionsPostWithHttpInfo(expand, body);
             return response.Data;
        }

        /// <summary>
        /// create a new base flow object The base flows are the flow that don&#39;t consider the specific versions of that flow - the base flow refers to all of its versions as one unit.  So base flows have a one-to-many relationship with versioned flows.&lt;br&gt;&lt;br&gt;This method will create a new base flow object, and assign it a new id.&lt;br&gt;&lt;br&gt;The usual process is that you&#39;ll want to create a base flow first, giving the flow a name and description which apply to all the versions as a whole, then create one or more versioned flows that reference that base.
        /// </summary>
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of FlowConfigMetaData</returns>
        public ApiResponse< FlowConfigMetaData > ProcessautomationFlowsDefinitionsPostWithHttpInfo (string expand = null, FlowConfigMetaData body = null)
        {
            
    
            var path_ = "/api/v1/processautomation/flows/definitions";
    
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
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FlowConfigMetaData>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowConfigMetaData) Configuration.ApiClient.Deserialize(response, typeof(FlowConfigMetaData)));
            
        }
    
        /// <summary>
        /// create a new base flow object The base flows are the flow that don&#39;t consider the specific versions of that flow - the base flow refers to all of its versions as one unit.  So base flows have a one-to-many relationship with versioned flows.&lt;br&gt;&lt;br&gt;This method will create a new base flow object, and assign it a new id.&lt;br&gt;&lt;br&gt;The usual process is that you&#39;ll want to create a base flow first, giving the flow a name and description which apply to all the versions as a whole, then create one or more versioned flows that reference that base.
        /// </summary>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body"></param>
        /// <returns>Task of FlowConfigMetaData</returns>
        public async System.Threading.Tasks.Task<FlowConfigMetaData> ProcessautomationFlowsDefinitionsPostAsync (string expand = null, FlowConfigMetaData body = null)
        {
             ApiResponse<FlowConfigMetaData> response = await ProcessautomationFlowsDefinitionsPostAsyncWithHttpInfo(expand, body);
             return response.Data;

        }

        /// <summary>
        /// create a new base flow object The base flows are the flow that don&#39;t consider the specific versions of that flow - the base flow refers to all of its versions as one unit.  So base flows have a one-to-many relationship with versioned flows.&lt;br&gt;&lt;br&gt;This method will create a new base flow object, and assign it a new id.&lt;br&gt;&lt;br&gt;The usual process is that you&#39;ll want to create a base flow first, giving the flow a name and description which apply to all the versions as a whole, then create one or more versioned flows that reference that base.
        /// </summary>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (FlowConfigMetaData)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowConfigMetaData>> ProcessautomationFlowsDefinitionsPostAsyncWithHttpInfo (string expand = null, FlowConfigMetaData body = null)
        {
            
    
            var path_ = "/api/v1/processautomation/flows/definitions";
    
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
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FlowConfigMetaData>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowConfigMetaData) Configuration.ApiClient.Deserialize(response, typeof(FlowConfigMetaData)));
            
        }
        
        /// <summary>
        /// Get a specific base flow meta-data by flow id This returns the stuff about a given flow that is not specific to individual versions of that flow, like its name, description, activation state, and current locking owner, etc.&lt;br&gt;NOTE: be careful to check the Deleted state of the object you get back, and don&#39;t let the UI change it if it&#39;s marked as deleted!&lt;br&gt;The requesting user must have permission to view the flow information.
        /// </summary>
        /// <param name="id">ID</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <returns>FlowConfigMetaData</returns>
        public FlowConfigMetaData ProcessautomationFlowsDefinitionsIdGet (string id, string expand = null)
        {
             ApiResponse<FlowConfigMetaData> response = ProcessautomationFlowsDefinitionsIdGetWithHttpInfo(id, expand);
             return response.Data;
        }

        /// <summary>
        /// Get a specific base flow meta-data by flow id This returns the stuff about a given flow that is not specific to individual versions of that flow, like its name, description, activation state, and current locking owner, etc.&lt;br&gt;NOTE: be careful to check the Deleted state of the object you get back, and don&#39;t let the UI change it if it&#39;s marked as deleted!&lt;br&gt;The requesting user must have permission to view the flow information.
        /// </summary>
        /// <param name="id">ID</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <returns>ApiResponse of FlowConfigMetaData</returns>
        public ApiResponse< FlowConfigMetaData > ProcessautomationFlowsDefinitionsIdGetWithHttpInfo (string id, string expand = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsDefinitionsIdGet");
            
    
            var path_ = "/api/v1/processautomation/flows/definitions/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FlowConfigMetaData>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowConfigMetaData) Configuration.ApiClient.Deserialize(response, typeof(FlowConfigMetaData)));
            
        }
    
        /// <summary>
        /// Get a specific base flow meta-data by flow id This returns the stuff about a given flow that is not specific to individual versions of that flow, like its name, description, activation state, and current locking owner, etc.&lt;br&gt;NOTE: be careful to check the Deleted state of the object you get back, and don&#39;t let the UI change it if it&#39;s marked as deleted!&lt;br&gt;The requesting user must have permission to view the flow information.
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of FlowConfigMetaData</returns>
        public async System.Threading.Tasks.Task<FlowConfigMetaData> ProcessautomationFlowsDefinitionsIdGetAsync (string id, string expand = null)
        {
             ApiResponse<FlowConfigMetaData> response = await ProcessautomationFlowsDefinitionsIdGetAsyncWithHttpInfo(id, expand);
             return response.Data;

        }

        /// <summary>
        /// Get a specific base flow meta-data by flow id This returns the stuff about a given flow that is not specific to individual versions of that flow, like its name, description, activation state, and current locking owner, etc.&lt;br&gt;NOTE: be careful to check the Deleted state of the object you get back, and don&#39;t let the UI change it if it&#39;s marked as deleted!&lt;br&gt;The requesting user must have permission to view the flow information.
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of ApiResponse (FlowConfigMetaData)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowConfigMetaData>> ProcessautomationFlowsDefinitionsIdGetAsyncWithHttpInfo (string id, string expand = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsDefinitionsIdGet");
            
    
            var path_ = "/api/v1/processautomation/flows/definitions/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FlowConfigMetaData>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowConfigMetaData) Configuration.ApiClient.Deserialize(response, typeof(FlowConfigMetaData)));
            
        }
        
        /// <summary>
        /// Updates the Activation state of a flow, which in part controls whether or not it is publicly launchable Updates the Activation state of a flow, which in part controls whether or not it is publicly launchable
        /// </summary>
        /// <param name="id">ID</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <param name="body">activate options</param> 
        /// <returns>FlowConfigMetaData</returns>
        public FlowConfigMetaData ProcessautomationFlowsDefinitionsIdCommandsActivatePost (string id, string expand = null, FlowActivateRequest body = null)
        {
             ApiResponse<FlowConfigMetaData> response = ProcessautomationFlowsDefinitionsIdCommandsActivatePostWithHttpInfo(id, expand, body);
             return response.Data;
        }

        /// <summary>
        /// Updates the Activation state of a flow, which in part controls whether or not it is publicly launchable Updates the Activation state of a flow, which in part controls whether or not it is publicly launchable
        /// </summary>
        /// <param name="id">ID</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <param name="body">activate options</param> 
        /// <returns>ApiResponse of FlowConfigMetaData</returns>
        public ApiResponse< FlowConfigMetaData > ProcessautomationFlowsDefinitionsIdCommandsActivatePostWithHttpInfo (string id, string expand = null, FlowActivateRequest body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsDefinitionsIdCommandsActivatePost");
            
    
            var path_ = "/api/v1/processautomation/flows/definitions/{id}/commands/activate";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdCommandsActivatePost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdCommandsActivatePost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FlowConfigMetaData>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowConfigMetaData) Configuration.ApiClient.Deserialize(response, typeof(FlowConfigMetaData)));
            
        }
    
        /// <summary>
        /// Updates the Activation state of a flow, which in part controls whether or not it is publicly launchable Updates the Activation state of a flow, which in part controls whether or not it is publicly launchable
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">activate options</param>
        /// <returns>Task of FlowConfigMetaData</returns>
        public async System.Threading.Tasks.Task<FlowConfigMetaData> ProcessautomationFlowsDefinitionsIdCommandsActivatePostAsync (string id, string expand = null, FlowActivateRequest body = null)
        {
             ApiResponse<FlowConfigMetaData> response = await ProcessautomationFlowsDefinitionsIdCommandsActivatePostAsyncWithHttpInfo(id, expand, body);
             return response.Data;

        }

        /// <summary>
        /// Updates the Activation state of a flow, which in part controls whether or not it is publicly launchable Updates the Activation state of a flow, which in part controls whether or not it is publicly launchable
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">activate options</param>
        /// <returns>Task of ApiResponse (FlowConfigMetaData)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowConfigMetaData>> ProcessautomationFlowsDefinitionsIdCommandsActivatePostAsyncWithHttpInfo (string id, string expand = null, FlowActivateRequest body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsDefinitionsIdCommandsActivatePost");
            
    
            var path_ = "/api/v1/processautomation/flows/definitions/{id}/commands/activate";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdCommandsActivatePost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdCommandsActivatePost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FlowConfigMetaData>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowConfigMetaData) Configuration.ApiClient.Deserialize(response, typeof(FlowConfigMetaData)));
            
        }
        
        /// <summary>
        /// Adjusts the association between a flow and zero or more Workspaces. Adjusts the association between a flow and zero or more Workspaces.
        /// </summary>
        /// <param name="id">ID</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <param name="body">activate options</param> 
        /// <returns>FlowConfigMetaData</returns>
        public FlowConfigMetaData ProcessautomationFlowsDefinitionsIdCommandsAssociatewithworkspacesPost (string id, string expand = null, FlowAssociateWorkspacesRequest body = null)
        {
             ApiResponse<FlowConfigMetaData> response = ProcessautomationFlowsDefinitionsIdCommandsAssociatewithworkspacesPostWithHttpInfo(id, expand, body);
             return response.Data;
        }

        /// <summary>
        /// Adjusts the association between a flow and zero or more Workspaces. Adjusts the association between a flow and zero or more Workspaces.
        /// </summary>
        /// <param name="id">ID</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <param name="body">activate options</param> 
        /// <returns>ApiResponse of FlowConfigMetaData</returns>
        public ApiResponse< FlowConfigMetaData > ProcessautomationFlowsDefinitionsIdCommandsAssociatewithworkspacesPostWithHttpInfo (string id, string expand = null, FlowAssociateWorkspacesRequest body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsDefinitionsIdCommandsAssociatewithworkspacesPost");
            
    
            var path_ = "/api/v1/processautomation/flows/definitions/{id}/commands/associatewithworkspaces";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdCommandsAssociatewithworkspacesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdCommandsAssociatewithworkspacesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FlowConfigMetaData>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowConfigMetaData) Configuration.ApiClient.Deserialize(response, typeof(FlowConfigMetaData)));
            
        }
    
        /// <summary>
        /// Adjusts the association between a flow and zero or more Workspaces. Adjusts the association between a flow and zero or more Workspaces.
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">activate options</param>
        /// <returns>Task of FlowConfigMetaData</returns>
        public async System.Threading.Tasks.Task<FlowConfigMetaData> ProcessautomationFlowsDefinitionsIdCommandsAssociatewithworkspacesPostAsync (string id, string expand = null, FlowAssociateWorkspacesRequest body = null)
        {
             ApiResponse<FlowConfigMetaData> response = await ProcessautomationFlowsDefinitionsIdCommandsAssociatewithworkspacesPostAsyncWithHttpInfo(id, expand, body);
             return response.Data;

        }

        /// <summary>
        /// Adjusts the association between a flow and zero or more Workspaces. Adjusts the association between a flow and zero or more Workspaces.
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">activate options</param>
        /// <returns>Task of ApiResponse (FlowConfigMetaData)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowConfigMetaData>> ProcessautomationFlowsDefinitionsIdCommandsAssociatewithworkspacesPostAsyncWithHttpInfo (string id, string expand = null, FlowAssociateWorkspacesRequest body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsDefinitionsIdCommandsAssociatewithworkspacesPost");
            
    
            var path_ = "/api/v1/processautomation/flows/definitions/{id}/commands/associatewithworkspaces";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdCommandsAssociatewithworkspacesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdCommandsAssociatewithworkspacesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FlowConfigMetaData>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowConfigMetaData) Configuration.ApiClient.Deserialize(response, typeof(FlowConfigMetaData)));
            
        }
        
        /// <summary>
        /// Permanently marks the base flow as deleted. Permanently marks the base flow as deleted.  It is still available for historical use; the flow will no longer be launchable.
        /// </summary>
        /// <param name="id">ID</param> 
        /// <returns></returns>
        public void ProcessautomationFlowsDefinitionsIdCommandsDeletePost (string id)
        {
             ProcessautomationFlowsDefinitionsIdCommandsDeletePostWithHttpInfo(id);
        }

        /// <summary>
        /// Permanently marks the base flow as deleted. Permanently marks the base flow as deleted.  It is still available for historical use; the flow will no longer be launchable.
        /// </summary>
        /// <param name="id">ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ProcessautomationFlowsDefinitionsIdCommandsDeletePostWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsDefinitionsIdCommandsDeletePost");
            
    
            var path_ = "/api/v1/processautomation/flows/definitions/{id}/commands/delete";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdCommandsDeletePost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdCommandsDeletePost: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Permanently marks the base flow as deleted. Permanently marks the base flow as deleted.  It is still available for historical use; the flow will no longer be launchable.
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ProcessautomationFlowsDefinitionsIdCommandsDeletePostAsync (string id)
        {
             await ProcessautomationFlowsDefinitionsIdCommandsDeletePostAsyncWithHttpInfo(id);

        }

        /// <summary>
        /// Permanently marks the base flow as deleted. Permanently marks the base flow as deleted.  It is still available for historical use; the flow will no longer be launchable.
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ProcessautomationFlowsDefinitionsIdCommandsDeletePostAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsDefinitionsIdCommandsDeletePost");
            
    
            var path_ = "/api/v1/processautomation/flows/definitions/{id}/commands/delete";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdCommandsDeletePost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdCommandsDeletePost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Updates the locked state of a flow, which affects a caller&#39;s ability to make changes to a flow Updates the locked state of a flow, which affects a caller&#39;s ability to make changes to a flow
        /// </summary>
        /// <param name="id">ID</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <param name="body">lock options</param> 
        /// <returns>FlowConfigMetaData</returns>
        public FlowConfigMetaData ProcessautomationFlowsDefinitionsIdCommandsLockPost (string id, string expand = null, FlowLockRequest body = null)
        {
             ApiResponse<FlowConfigMetaData> response = ProcessautomationFlowsDefinitionsIdCommandsLockPostWithHttpInfo(id, expand, body);
             return response.Data;
        }

        /// <summary>
        /// Updates the locked state of a flow, which affects a caller&#39;s ability to make changes to a flow Updates the locked state of a flow, which affects a caller&#39;s ability to make changes to a flow
        /// </summary>
        /// <param name="id">ID</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <param name="body">lock options</param> 
        /// <returns>ApiResponse of FlowConfigMetaData</returns>
        public ApiResponse< FlowConfigMetaData > ProcessautomationFlowsDefinitionsIdCommandsLockPostWithHttpInfo (string id, string expand = null, FlowLockRequest body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsDefinitionsIdCommandsLockPost");
            
    
            var path_ = "/api/v1/processautomation/flows/definitions/{id}/commands/lock";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdCommandsLockPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdCommandsLockPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FlowConfigMetaData>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowConfigMetaData) Configuration.ApiClient.Deserialize(response, typeof(FlowConfigMetaData)));
            
        }
    
        /// <summary>
        /// Updates the locked state of a flow, which affects a caller&#39;s ability to make changes to a flow Updates the locked state of a flow, which affects a caller&#39;s ability to make changes to a flow
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">lock options</param>
        /// <returns>Task of FlowConfigMetaData</returns>
        public async System.Threading.Tasks.Task<FlowConfigMetaData> ProcessautomationFlowsDefinitionsIdCommandsLockPostAsync (string id, string expand = null, FlowLockRequest body = null)
        {
             ApiResponse<FlowConfigMetaData> response = await ProcessautomationFlowsDefinitionsIdCommandsLockPostAsyncWithHttpInfo(id, expand, body);
             return response.Data;

        }

        /// <summary>
        /// Updates the locked state of a flow, which affects a caller&#39;s ability to make changes to a flow Updates the locked state of a flow, which affects a caller&#39;s ability to make changes to a flow
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">lock options</param>
        /// <returns>Task of ApiResponse (FlowConfigMetaData)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowConfigMetaData>> ProcessautomationFlowsDefinitionsIdCommandsLockPostAsyncWithHttpInfo (string id, string expand = null, FlowLockRequest body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsDefinitionsIdCommandsLockPost");
            
    
            var path_ = "/api/v1/processautomation/flows/definitions/{id}/commands/lock";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdCommandsLockPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdCommandsLockPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FlowConfigMetaData>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowConfigMetaData) Configuration.ApiClient.Deserialize(response, typeof(FlowConfigMetaData)));
            
        }
        
        /// <summary>
        /// Rename a flow (both the name and the description) Rename a flow.  Both the name and the description should be included, as both are eligible to be changed with this endpoint.
        /// </summary>
        /// <param name="id">ID</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <param name="body"></param> 
        /// <returns>FlowConfigMetaData</returns>
        public FlowConfigMetaData ProcessautomationFlowsDefinitionsIdCommandsRenamePost (string id, string expand = null, FlowConfigMetaData body = null)
        {
             ApiResponse<FlowConfigMetaData> response = ProcessautomationFlowsDefinitionsIdCommandsRenamePostWithHttpInfo(id, expand, body);
             return response.Data;
        }

        /// <summary>
        /// Rename a flow (both the name and the description) Rename a flow.  Both the name and the description should be included, as both are eligible to be changed with this endpoint.
        /// </summary>
        /// <param name="id">ID</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of FlowConfigMetaData</returns>
        public ApiResponse< FlowConfigMetaData > ProcessautomationFlowsDefinitionsIdCommandsRenamePostWithHttpInfo (string id, string expand = null, FlowConfigMetaData body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsDefinitionsIdCommandsRenamePost");
            
    
            var path_ = "/api/v1/processautomation/flows/definitions/{id}/commands/rename";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdCommandsRenamePost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdCommandsRenamePost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FlowConfigMetaData>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowConfigMetaData) Configuration.ApiClient.Deserialize(response, typeof(FlowConfigMetaData)));
            
        }
    
        /// <summary>
        /// Rename a flow (both the name and the description) Rename a flow.  Both the name and the description should be included, as both are eligible to be changed with this endpoint.
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body"></param>
        /// <returns>Task of FlowConfigMetaData</returns>
        public async System.Threading.Tasks.Task<FlowConfigMetaData> ProcessautomationFlowsDefinitionsIdCommandsRenamePostAsync (string id, string expand = null, FlowConfigMetaData body = null)
        {
             ApiResponse<FlowConfigMetaData> response = await ProcessautomationFlowsDefinitionsIdCommandsRenamePostAsyncWithHttpInfo(id, expand, body);
             return response.Data;

        }

        /// <summary>
        /// Rename a flow (both the name and the description) Rename a flow.  Both the name and the description should be included, as both are eligible to be changed with this endpoint.
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (FlowConfigMetaData)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowConfigMetaData>> ProcessautomationFlowsDefinitionsIdCommandsRenamePostAsyncWithHttpInfo (string id, string expand = null, FlowConfigMetaData body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsDefinitionsIdCommandsRenamePost");
            
    
            var path_ = "/api/v1/processautomation/flows/definitions/{id}/commands/rename";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdCommandsRenamePost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdCommandsRenamePost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FlowConfigMetaData>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowConfigMetaData) Configuration.ApiClient.Deserialize(response, typeof(FlowConfigMetaData)));
            
        }
        
        /// <summary>
        /// Gets an optional cache for a given flow definition. Gets a user saved version of a flow definition.
        /// </summary>
        /// <param name="id">ID</param> 
        /// <returns>string</returns>
        public string ProcessautomationFlowsDefinitionsIdFlowcacheGet (string id)
        {
             ApiResponse<string> response = ProcessautomationFlowsDefinitionsIdFlowcacheGetWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        /// Gets an optional cache for a given flow definition. Gets a user saved version of a flow definition.
        /// </summary>
        /// <param name="id">ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ProcessautomationFlowsDefinitionsIdFlowcacheGetWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsDefinitionsIdFlowcacheGet");
            
    
            var path_ = "/api/v1/processautomation/flows/definitions/{id}/flowcache";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "text/plain"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdFlowcacheGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdFlowcacheGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Gets an optional cache for a given flow definition. Gets a user saved version of a flow definition.
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ProcessautomationFlowsDefinitionsIdFlowcacheGetAsync (string id)
        {
             ApiResponse<string> response = await ProcessautomationFlowsDefinitionsIdFlowcacheGetAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        /// Gets an optional cache for a given flow definition. Gets a user saved version of a flow definition.
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ProcessautomationFlowsDefinitionsIdFlowcacheGetAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsDefinitionsIdFlowcacheGet");
            
    
            var path_ = "/api/v1/processautomation/flows/definitions/{id}/flowcache";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "text/plain"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdFlowcacheGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdFlowcacheGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Saves a flow definition to a temporary location for flows that are not ready to be added to a versioned flow. This cache is used to save a flow&#39;s definition that is still in progress and is not ready to be made official.
        /// </summary>
        /// <param name="id">ID</param> 
        /// <param name="body">flow definition data</param> 
        /// <returns></returns>
        public void ProcessautomationFlowsDefinitionsIdFlowcachePut (string id, string body = null)
        {
             ProcessautomationFlowsDefinitionsIdFlowcachePutWithHttpInfo(id, body);
        }

        /// <summary>
        /// Saves a flow definition to a temporary location for flows that are not ready to be added to a versioned flow. This cache is used to save a flow&#39;s definition that is still in progress and is not ready to be made official.
        /// </summary>
        /// <param name="id">ID</param> 
        /// <param name="body">flow definition data</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ProcessautomationFlowsDefinitionsIdFlowcachePutWithHttpInfo (string id, string body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsDefinitionsIdFlowcachePut");
            
    
            var path_ = "/api/v1/processautomation/flows/definitions/{id}/flowcache";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdFlowcachePut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdFlowcachePut: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Saves a flow definition to a temporary location for flows that are not ready to be added to a versioned flow. This cache is used to save a flow&#39;s definition that is still in progress and is not ready to be made official.
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="body">flow definition data</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ProcessautomationFlowsDefinitionsIdFlowcachePutAsync (string id, string body = null)
        {
             await ProcessautomationFlowsDefinitionsIdFlowcachePutAsyncWithHttpInfo(id, body);

        }

        /// <summary>
        /// Saves a flow definition to a temporary location for flows that are not ready to be added to a versioned flow. This cache is used to save a flow&#39;s definition that is still in progress and is not ready to be made official.
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="body">flow definition data</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ProcessautomationFlowsDefinitionsIdFlowcachePutAsyncWithHttpInfo (string id, string body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsDefinitionsIdFlowcachePut");
            
    
            var path_ = "/api/v1/processautomation/flows/definitions/{id}/flowcache";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdFlowcachePut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdFlowcachePut: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Publishes what is saved in the flow definition cache. Publishes what is saved in the flow definition cache. The contents are first validated to ensure they constitute a legal workflow definition. The calling user must have the lock on the flow in order to call this method.  The return value will be the newly created FlowVersionConfigMetaData object.
        /// </summary>
        /// <param name="id">ID</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <returns>FlowVersionConfigMetaData</returns>
        public FlowVersionConfigMetaData ProcessautomationFlowsDefinitionsIdFlowcacheCommandsPublishPost (string id, string expand = null)
        {
             ApiResponse<FlowVersionConfigMetaData> response = ProcessautomationFlowsDefinitionsIdFlowcacheCommandsPublishPostWithHttpInfo(id, expand);
             return response.Data;
        }

        /// <summary>
        /// Publishes what is saved in the flow definition cache. Publishes what is saved in the flow definition cache. The contents are first validated to ensure they constitute a legal workflow definition. The calling user must have the lock on the flow in order to call this method.  The return value will be the newly created FlowVersionConfigMetaData object.
        /// </summary>
        /// <param name="id">ID</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <returns>ApiResponse of FlowVersionConfigMetaData</returns>
        public ApiResponse< FlowVersionConfigMetaData > ProcessautomationFlowsDefinitionsIdFlowcacheCommandsPublishPostWithHttpInfo (string id, string expand = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsDefinitionsIdFlowcacheCommandsPublishPost");
            
    
            var path_ = "/api/v1/processautomation/flows/definitions/{id}/flowcache/commands/publish";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdFlowcacheCommandsPublishPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdFlowcacheCommandsPublishPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FlowVersionConfigMetaData>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowVersionConfigMetaData) Configuration.ApiClient.Deserialize(response, typeof(FlowVersionConfigMetaData)));
            
        }
    
        /// <summary>
        /// Publishes what is saved in the flow definition cache. Publishes what is saved in the flow definition cache. The contents are first validated to ensure they constitute a legal workflow definition. The calling user must have the lock on the flow in order to call this method.  The return value will be the newly created FlowVersionConfigMetaData object.
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of FlowVersionConfigMetaData</returns>
        public async System.Threading.Tasks.Task<FlowVersionConfigMetaData> ProcessautomationFlowsDefinitionsIdFlowcacheCommandsPublishPostAsync (string id, string expand = null)
        {
             ApiResponse<FlowVersionConfigMetaData> response = await ProcessautomationFlowsDefinitionsIdFlowcacheCommandsPublishPostAsyncWithHttpInfo(id, expand);
             return response.Data;

        }

        /// <summary>
        /// Publishes what is saved in the flow definition cache. Publishes what is saved in the flow definition cache. The contents are first validated to ensure they constitute a legal workflow definition. The calling user must have the lock on the flow in order to call this method.  The return value will be the newly created FlowVersionConfigMetaData object.
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of ApiResponse (FlowVersionConfigMetaData)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowVersionConfigMetaData>> ProcessautomationFlowsDefinitionsIdFlowcacheCommandsPublishPostAsyncWithHttpInfo (string id, string expand = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsDefinitionsIdFlowcacheCommandsPublishPost");
            
    
            var path_ = "/api/v1/processautomation/flows/definitions/{id}/flowcache/commands/publish";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdFlowcacheCommandsPublishPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdFlowcacheCommandsPublishPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FlowVersionConfigMetaData>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowVersionConfigMetaData) Configuration.ApiClient.Deserialize(response, typeof(FlowVersionConfigMetaData)));
            
        }
        
        /// <summary>
        /// Get all versioned flows for one particular base flow. This is for getting a list of all versioned flows.  So there could potentially be a lot of data here. Like if some designer guy decides to publish one hundred versions of his workflow they might all get returned here.&lt;br&gt;NOTE: be careful because this API does not check to see if the base flow is marked as Deleted or not.&lt;br&gt;You probably won&#39;t want to call this API very often, usually for situations like where the UI has a \&quot;restore a previous version of the flow\&quot; listbox.
        /// </summary>
        /// <param name="id">Flow ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <returns>FlowVersionConfigMetaDataEntityListing</returns>
        public FlowVersionConfigMetaDataEntityListing ProcessautomationFlowsDefinitionsIdVersionsGet (string id, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
             ApiResponse<FlowVersionConfigMetaDataEntityListing> response = ProcessautomationFlowsDefinitionsIdVersionsGetWithHttpInfo(id, pageSize, pageNumber, expand);
             return response.Data;
        }

        /// <summary>
        /// Get all versioned flows for one particular base flow. This is for getting a list of all versioned flows.  So there could potentially be a lot of data here. Like if some designer guy decides to publish one hundred versions of his workflow they might all get returned here.&lt;br&gt;NOTE: be careful because this API does not check to see if the base flow is marked as Deleted or not.&lt;br&gt;You probably won&#39;t want to call this API very often, usually for situations like where the UI has a \&quot;restore a previous version of the flow\&quot; listbox.
        /// </summary>
        /// <param name="id">Flow ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <returns>ApiResponse of FlowVersionConfigMetaDataEntityListing</returns>
        public ApiResponse< FlowVersionConfigMetaDataEntityListing > ProcessautomationFlowsDefinitionsIdVersionsGetWithHttpInfo (string id, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsDefinitionsIdVersionsGet");
            
    
            var path_ = "/api/v1/processautomation/flows/definitions/{id}/versions";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdVersionsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdVersionsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FlowVersionConfigMetaDataEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowVersionConfigMetaDataEntityListing) Configuration.ApiClient.Deserialize(response, typeof(FlowVersionConfigMetaDataEntityListing)));
            
        }
    
        /// <summary>
        /// Get all versioned flows for one particular base flow. This is for getting a list of all versioned flows.  So there could potentially be a lot of data here. Like if some designer guy decides to publish one hundred versions of his workflow they might all get returned here.&lt;br&gt;NOTE: be careful because this API does not check to see if the base flow is marked as Deleted or not.&lt;br&gt;You probably won&#39;t want to call this API very often, usually for situations like where the UI has a \&quot;restore a previous version of the flow\&quot; listbox.
        /// </summary>
        /// <param name="id">Flow ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of FlowVersionConfigMetaDataEntityListing</returns>
        public async System.Threading.Tasks.Task<FlowVersionConfigMetaDataEntityListing> ProcessautomationFlowsDefinitionsIdVersionsGetAsync (string id, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
             ApiResponse<FlowVersionConfigMetaDataEntityListing> response = await ProcessautomationFlowsDefinitionsIdVersionsGetAsyncWithHttpInfo(id, pageSize, pageNumber, expand);
             return response.Data;

        }

        /// <summary>
        /// Get all versioned flows for one particular base flow. This is for getting a list of all versioned flows.  So there could potentially be a lot of data here. Like if some designer guy decides to publish one hundred versions of his workflow they might all get returned here.&lt;br&gt;NOTE: be careful because this API does not check to see if the base flow is marked as Deleted or not.&lt;br&gt;You probably won&#39;t want to call this API very often, usually for situations like where the UI has a \&quot;restore a previous version of the flow\&quot; listbox.
        /// </summary>
        /// <param name="id">Flow ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of ApiResponse (FlowVersionConfigMetaDataEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowVersionConfigMetaDataEntityListing>> ProcessautomationFlowsDefinitionsIdVersionsGetAsyncWithHttpInfo (string id, int? pageSize = null, int? pageNumber = null, string expand = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsDefinitionsIdVersionsGet");
            
    
            var path_ = "/api/v1/processautomation/flows/definitions/{id}/versions";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdVersionsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdVersionsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FlowVersionConfigMetaDataEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowVersionConfigMetaDataEntityListing) Configuration.ApiClient.Deserialize(response, typeof(FlowVersionConfigMetaDataEntityListing)));
            
        }
        
        /// <summary>
        /// Create a new versioned flow This method requires the base flow to be already created... and then (with permission) you can create a versioned flow that references it.  This method will set the meta-data of that versioned flow you&#39;re creating, and return to you a Uri of the user-upload-service where you can supply the bits of the flow definition.&lt;br&gt;&lt;br&gt;There is a Process Definition File for each version of a process.  The Process Definition File contains all of the definitions for everything used by the process.  Eventually, we may support Shared Data Types, Shared Sequences, etc. that are defined in separate files, are organization-global and useable across multiple process definitions for the same organization, but such shared objects are beyond the scope of the initial release.&lt;br&gt;&lt;br&gt;The Process Definition File contains Data Type Definitions, Variable Definitions, Sequence Definitions, and Actions, Outputs and Connections.&lt;br&gt;&lt;br&gt;Variable Definitions can be created in process-scope or sequence-scope.  A Variable Definition always references a Data Type Definition, regardless of whether the Variable Definition is defining a basic, simple or complex variable.  ( In IPA, basic variables did not have a separate data type definition, but simple and complex variables did.)  The Data Type Definition does not indicate whether a variable is or is not a collection; that configuration is on the Variable Definition.  Variable Definitions scoped to the Process Definition or a Task Definition may be marked as Input Parameters and/or Output Parameters, but Variable Definitions scoped to a State Sequence Definition can marked as neither Input nor Output Parameters.&lt;br&gt;&lt;br&gt;An Action is the smallest unit of executable.  Actions are added to Sequence Definitions, and no Action can exist outside of a Sequence Definition.  There are currently two types of Sequence Definitions: State Sequence Definitions and Task Sequence Definitions.  They are very similar, and may generally contain the same kinds of actions, with few restrictions.  A State Sequence Definition is called via a ChangeState action, cannot have input or output parameters, does not induce any Outputs onto the ChangeState action that calls the sequence, and cannot use the ExitTask action.  A Task Sequence Definition is called via the CallTaskSync action, can have input and/or output parameters, may induce Outputs onto the CallTaskSync action that calls the sequence, and can use the ExitTask action.&lt;br&gt;&lt;br&gt;An Action may have zero or more Outputs, where each Output is essentially just a pointer to another Action within the same Sequence Definition via an associated Connection object.  An Action with no Outputs is a Terminating Action because it causes the current sequence to end.  Examples of terminating actions are ChangeState, ExitTask and EndProcess.  All non-terminating actions will have at least one Output.  Some actions have a fixed set of outputs (i.e. Conditional if with true/false).  Many actions will have a Default Output that is always present.  Sometimes the Default Output may be the only Output (i.e. UpdateVariables).  Sometimes Outputs get induced into an action by something the action references (i.e. RunProcessSync has a Default Output, but may also gets induced outputs due to Process End Reasons from the referenced Process Definition).&lt;br&gt;&lt;br&gt;A Connection connects a specific Output of a specific Action to another Action, or even back to the same Action.  Think of Connections as the \&quot;arrows\&quot; that the server follows while the server is executing a flow: the server runs an Action; if it is a non-terminating Action, then after the action has completed the server selects an Output on that Action; once the Output is selected, the server looks for a Connection from that Output to another Action, but if there is no Connection for that output then the server exits the sequence (i.e. ExitTask(Default) if it is a Task Sequence Definition, or EndProcess(Default) if it is a State Sequence Definition).&lt;br&gt;&lt;br&gt;Note:  There is no need for a Loop action.  This is because a Connection can point from an Output of an Action back to the same action, which is itself inherently a loop.&lt;br&gt;&lt;br&gt;&lt;br&gt;Page Definition JSON Guidelines&lt;br&gt;The following subsections list the general guides lines to follow when creating JSON objects to be include on the Process Definition File.&lt;br&gt;&lt;br&gt;Keep the JSON Shallow Instead of Deep&lt;br&gt;There will always be some level of nesting within JSON: JSON itself always has one root object that contains everything else.  But, as a general rule, we want to keep the JSON shallow instead of deep.  This necessarily implies that fields that reference really complex objects are preferred over fields that contain really complex objects.  For example, rather than nest actions inside of actions that are also nested inside of other actions, all actions within the same sequence are defined within a single list because they are in the scope.  Then, there is another list at sequence scope that contains all of the connections between all of the actions.  Keep things shallow generally makes it easy to find the object you are looking for given it&#39;s ID, and nesting deep does not easily allow for structures like actions that connect back to another action earlier in the flow.&lt;br&gt;&lt;br&gt;Mind the Well-Known Field Names&lt;br&gt;This file format uses several well-known field names, such as the ones below:&lt;br&gt;    \&quot;_meta\&quot;&lt;br&gt;    \&quot;id\&quot;&lt;br&gt;    \&quot;refId\&quot;&lt;br&gt;    \&quot;designer\&quot;&lt;br&gt;    \&quot;config\&quot;&lt;br&gt;&lt;br&gt;That list of well-known field names above is not necessarily complete at this time, and will be extended as necessary.  All of the field names within that list should be discussed in this page.\n&lt;br&gt;The well-known field names shall only be used for their intended purposes.  Other fields may contain the well known names within a substring of their entire field names. (i.e. \&quot;designer\&quot; must conform to the rules for \&quot;designer\&quot;, but \&quot;myDesigner\&quot; could be used for something else.\n&lt;br&gt;The \&quot;_meta\&quot; Field\n&lt;br&gt;For deserialization or interpretation purposes, some objects may need a meta section to capture information such as the version of a serialization format.  When present, the field name shall be \&quot;_meta\&quot;, and it shall always be the first field within the object.\n&lt;br&gt;There is not currently a specific set of what may or may not appear in a meta object.  Each meta object will likely have the \&quot;objectType\&quot; field, which holds a string that indicates what type of data is contained by the object with the \&quot;_meta\&quot; field.  Other possible fields that may be used are \&quot;formatType\&quot; and/or \&quot;formatVersion\&quot;.  The idea is that the meta object should contain any information that may be necessary for an application to know or understand the other fields that are siblings of the \&quot;_meta\&quot; field within the same object. \n&lt;br&gt;Generally speaking, the fields within a JSON object are allowed to be in any order, and some serializers may choose to always write the fields in alphabetic order by default.  But, it is somewhat pointless to even have the \&quot;_meta\&quot; field if it is not first since it&#39;s information could not then be used to know what to expect while deserializing the remainder of the object.  Therefore, the meta field intentionally starts with an underscore character to force it to the top if the fields get sorted during serialization.\n&lt;br&gt;Also, it is intended that the meta can really appear within almost any object.  Basically, if a bit of extra information is is needed to understand or parse something, a \&quot;_meta\&quot; field can be added to help interpret the other fields that are siblings of the _meta field.  All \&quot;definition\&quot; objects should have a meta object that, at a minimum, indicates \&quot;objectType\&quot;.\n&lt;br&gt;&lt;br&gt;&lt;pre&gt;{    // This field, if present, must always be first!&lt;br&gt;    \&quot;_meta\&quot;:&lt;br&gt;    {&lt;br&gt;        // These are some suggest field names, but may not apply in all cases&lt;br&gt;        \&quot;objectType\&quot;: &lt;string&gt;&lt;br&gt;        \&quot;formatType\&quot;: &lt;string&gt;,&lt;br&gt;        \&quot;formatRevision\&quot;: &lt;version&gt;,&lt;br&gt; &lt;br&gt;        // Could really have just about anything else here, too&lt;br&gt;        ....&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    // More fields for this specific object must come after the \&quot;_meta\&quot;&lt;br&gt;    ...&lt;br&gt;}&lt;br&gt; &lt;br&gt;// Null \&quot;_meta\&quot; is allowed&lt;br&gt;{&lt;br&gt;    \&quot;_meta\&quot;: null,&lt;br&gt;    ...&lt;br&gt;}&lt;br&gt; &lt;br&gt;// Empty object \&quot;_meta\&quot; is allowed&lt;br&gt;{&lt;br&gt;    \&quot;_meta: {},&lt;br&gt;    ...&lt;br&gt;}&lt;br&gt;// Omitted \&quot;_meta\&quot; is allowed&lt;br&gt;{&lt;br&gt;    ...&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;&lt;br&gt;IDs and \&quot;id\&quot; &amp; \&quot;refId\&quot; Fields&lt;br&gt;&lt;br&gt;The process definition uses IDs!!!  Think of an ID as something that uniquely identifies an object definition.  Conceptually, they are like GUIDs.  However, in reality, something a bit less verbose than GUIDs may be used.&lt;br&gt;&lt;br&gt;In an attempt to more easily figure out which object owns/defines/declares the ID vs. which objects just reference the ID, the field name of all owned IDs will be \&quot;id\&quot; and the field name for all referenced IDs will be \&quot;refId\&quot;.  Additionally, the \&quot;refId\&quot; shall always be inside a container object, which is intended to&lt;br&gt;&lt;br&gt;    Allow for additional information that describe the scope/context in which the ID indicated by \&quot;refId\&quot; can be found, if necessary&lt;br&gt;    Accommodate the need to reference multiple objects from within the same parent object&lt;br&gt;    Eventually support the ability to reference objects defined outside of the Process Definition, such as shared Data Type Definitins or PureCloud Composer Scripts.&lt;br&gt;&lt;br&gt;The field name of the \&quot;refId\&quot; container object should generally end with \&quot;Ref\&quot;.&lt;br&gt;&lt;pre&gt;// Object definition that is assigning an ID to itself; The \&quot;id\&quot; field does not have to be first&lt;br&gt;{&lt;br&gt;    ...,&lt;br&gt;    \&quot;id\&quot;: &lt;id&gt;,&lt;br&gt;    ...&lt;br&gt;}&lt;/pre&gt;&lt;br&gt; &lt;br&gt;// Object definition that is referencing the object above via the \&quot;refId\&quot; field&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    // Container object for the \&quot;fieldOne\&quot; reference&lt;br&gt;    \&quot;fieldOneRef\&quot;:&lt;br&gt;    {&lt;br&gt;        ...,&lt;br&gt; &lt;br&gt;        // This field indicates the ID of that other object that is being referenced&lt;br&gt;        \&quot;refId\&quot;: &lt;id&gt;,&lt;br&gt; &lt;br&gt;        // If necessary, we can add additional fields that describe the scope/context in which&lt;br&gt;        // the object being referenced is expected to be found.&lt;br&gt;        ...&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    // Since \&quot;refId\&quot; is a well-known field name but the containing object&#39;s field names are not&lt;br&gt;    // (i.e. \&quot;fieldOneRef\&quot; and \&quot;fieldTwoRef\&quot; are not well-known field names) the same parent object&lt;br&gt;    // can easily reference multiple other objects, while keeping the \&quot;refId\&quot; field name consistent.&lt;br&gt;    \&quot;fieldTwoRef\&quot;:&lt;br&gt;    {&lt;br&gt;        ...,&lt;br&gt;        \&quot;refId\&quot;: &lt;id&gt;,&lt;br&gt;        ...&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;The \&quot;identity\&quot; Field\n&lt;br&gt;Everything about declaring the identity of the object is stored in the \&quot;identity\&quot; field.  This includes things like the \&quot;id\&quot; field, if necessary, as well as optional \&quot;name\&quot; and \&quot;description\&quot; fields in which store information entered by the user via the designer; it is unclear at this point whether the designer will or will not actually allow the user to view and/or enter a label and/or description for every major object, but the format will at least support it wherever the designer chooses to allow it!  Other information specific to certain object types, such as the revision of the Process Definition, could potentially also be stored in this object.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    \&quot;identity\&quot;:&lt;br&gt;    {&lt;br&gt;        \&quot;id\&quot;:&lt;id&gt;,&lt;br&gt;        \&quot;name\&quot;:string,&lt;br&gt;        \&quot;description\&quot;:&lt;string&gt;&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;Note:  The \&quot;name\&quot; and \&quot;description\&quot; fields should generally be treated as user-mutable, display only – so don&#39;t write any code to make any decisions based on a string value in \&quot;name or description\&quot;!  For example, don&#39;t look for an output named \&quot;true\&quot; on a ConditionalIf action, because it could be localized to another language, or the user may have changed it to \&quot;yes\&quot;, \&quot;on\&quot;, etc.&lt;br&gt;The \&quot;designer\&quot; Field&lt;br&gt;&lt;br&gt;Any designer-specific information shall be isolated into an object under a \&quot;designer\&quot; field.  This is a well-known field name, and is intended to better faciliate the creation of a streamlined, compiled version of the process definition, etc. should the server decide that it wants to do so.  It is assumed that anything within an object used as the value for a \&quot;designer\&quot; field is not needed at runtime by the server or by clients.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    \&quot;designer\&quot;:&lt;br&gt;    {&lt;br&gt;        ...,&lt;br&gt;        \&quot;notes\&quot;: &lt;string&gt;,&lt;br&gt;        ...&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;A \&quot;designer\&quot; field can occur at many levels within the JSON, and can always be ignored by the server.  As an example of something that may be added to a designer field, consider the Connections between an Action&#39;s Output an the next Action.  The server needs to know what the connection is (i.e. Action&#39;s Output points to another Action), but does not need how the connection looks when \&quot;drawn\&quot; by the user (i.e. goes up, right, down, right, etc.)&lt;br&gt;&lt;br&gt;The sample JSON above shows a \&quot;notes\&quot; field in object used as the value for the \&quot;designer\&quot; field.  The \&quot;identity\&quot; section mentioned previously had \&quot;name\&quot; and \&quot;description\&quot; fields.  The idea of adding \&quot;notes\&quot; into the designer field is to allow people designing the process to add very verbose notes about design decisions, etc.  That differs from the identity.descripion, which is intended to be more of a an end-user viewable description, such as a description that assists the user to select the correct Process Definition to launch.&lt;br&gt;The \&quot;config\&quot; Field&lt;br&gt;&lt;br&gt;Many of the objects may have a \&quot;config\&quot; field.  The contents of this field will generally be specific to the object.  This is were details about Action configuration, Variables configuration, etc. will be located.&lt;br&gt;The \&quot;definitions\&quot; field and Definition Lists&lt;br&gt;&lt;br&gt;Many of the JSON definition objects will themselves also contain definition lists.  For example the Process Definition objects will have a Data Type Definitions list, Variable Definitions list, Sequence Definitions list, End Process Reasons List,. etc.  The Sequence Definition will have an Action Definitions List, Connection Definitions List, Exit Reasons Definitions List, etc. &lt;br&gt;&lt;br&gt;When an object definition itself needs to include one or more definition lists, the object shall have a \&quot;definitions\&quot; field, and the value of that field is an object where the field names are the names of the definition lists.  Additionally, each of those field names that contains a single definition list will generally end with \&quot;Def\&quot;, and every object definition within a definition list will have an \&quot;identity\&quot; field.  If the objects with a specific definition list have identity.name fields, then each of those identity.name fields shall be unique among all of the objects within that same definition list!&lt;br&gt;// This is a definition object.  Generally speaking, definition lists will exist within some other definition object.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    ...,&lt;br&gt; &lt;br&gt;    // This field contains all of the definition lists,if any&lt;br&gt;    \&quot;definitions\&quot;:&lt;br&gt;    {&lt;br&gt;        // This is the definition list for abcDef objects&lt;br&gt;        \&quot;abcDefs\&quot;:&lt;br&gt;        [&lt;br&gt;            // Each abcDef object has an identity.id&lt;br&gt;            {&lt;br&gt;                \&quot;identity\&quot;:&lt;br&gt;                {&lt;br&gt;                    \&quot;id\&quot;:&lt;id&gt;,&lt;br&gt;                    \&quot;name\&quot;:&lt;string&gt;,&lt;br&gt;                }&lt;br&gt;            },&lt;br&gt; &lt;br&gt;            // There can be any number of definition objects within this definition list,&lt;br&gt;            // but each of them must have a different value for identity.name.&lt;br&gt;            ...&lt;br&gt;        ],&lt;br&gt; &lt;br&gt;        // This is the definition list of xyzDef objects&lt;br&gt;        \&quot;xyzDefs\&quot;:&lt;br&gt;        [&lt;br&gt;            // Each xyzDef object has an identity.id&lt;br&gt;            {&lt;br&gt;                \&quot;identity\&quot;:&lt;br&gt;                {&lt;br&gt;                    \&quot;id\&quot;:&lt;id&gt;,&lt;br&gt; &lt;br&gt;                    // The value of this identity.name field could be the same as a definition&lt;br&gt;                    // object within the \&quot;abcDefs\&quot; definition list above because the definition&lt;br&gt;                    // objects exist within different definition lists.&lt;br&gt;                    \&quot;name\&quot;:&lt;string&gt;&lt;br&gt;                }&lt;br&gt;            },&lt;br&gt;            ...&lt;br&gt;        ]&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    ...,&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;No Back-Pointers&lt;br&gt;&lt;br&gt;Generally speaking, the JSON should stay away from back-pointers.  A back-pointer is a reference back to the parent object definition that has the definitions list that contains the object doing the back-pointing.  For example, a StateSequenceDefinition exists within the ProcessDefinition.definitions.stateSequenceDefs list:&lt;br&gt;&lt;br&gt;    Process Definition&lt;br&gt;        definitions&lt;br&gt;            stateSequenceDefs&lt;br&gt;                StateSequenceDefinition&lt;br&gt;&lt;br&gt; &lt;br&gt;&lt;br&gt;In the example above, the JSON for the StateSeqenceDefinition should not point back to the stateSequenceDefs definitions list, or to the definitions field that contains that definitions list, or the Process Definition that contains that definitions field.  There is no need for such back-pointers because the relationship is already implied by the structure of the JSON.  With that said, however, it is likely that applications may find it useful to create such back-pointers in memory for the purpose of navigating through and manipulating the object graph; they just don&#39;t need to serialize it into the JSON.&lt;br&gt;Object Definition Template&lt;br&gt;&lt;br&gt;Given the guidelines above, the following is kind of a template for all JSON object definitions.  For any specific definition, however, some of the sections or fields within those sections may not apply.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    \&quot;_meta\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    \&quot;identity\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    // Keep in mind that the \&quot;designer\&quot; fields can really exist anywhere,&lt;br&gt;    // not just at the top of a definition.&lt;br&gt;    \&quot;designer\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    \&quot;config\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    \&quot;definitions\&quot;:&lt;br&gt;    {&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;
        /// </summary>
        /// <param name="id">Flow ID</param> 
        /// <param name="keepDraft">Keep flow draft</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <param name="body"></param> 
        /// <returns>FlowVersionConfigMetaData</returns>
        public FlowVersionConfigMetaData ProcessautomationFlowsDefinitionsIdVersionsPost (string id, bool? keepDraft = null, string expand = null, FlowVersionConfigMetaData body = null)
        {
             ApiResponse<FlowVersionConfigMetaData> response = ProcessautomationFlowsDefinitionsIdVersionsPostWithHttpInfo(id, keepDraft, expand, body);
             return response.Data;
        }

        /// <summary>
        /// Create a new versioned flow This method requires the base flow to be already created... and then (with permission) you can create a versioned flow that references it.  This method will set the meta-data of that versioned flow you&#39;re creating, and return to you a Uri of the user-upload-service where you can supply the bits of the flow definition.&lt;br&gt;&lt;br&gt;There is a Process Definition File for each version of a process.  The Process Definition File contains all of the definitions for everything used by the process.  Eventually, we may support Shared Data Types, Shared Sequences, etc. that are defined in separate files, are organization-global and useable across multiple process definitions for the same organization, but such shared objects are beyond the scope of the initial release.&lt;br&gt;&lt;br&gt;The Process Definition File contains Data Type Definitions, Variable Definitions, Sequence Definitions, and Actions, Outputs and Connections.&lt;br&gt;&lt;br&gt;Variable Definitions can be created in process-scope or sequence-scope.  A Variable Definition always references a Data Type Definition, regardless of whether the Variable Definition is defining a basic, simple or complex variable.  ( In IPA, basic variables did not have a separate data type definition, but simple and complex variables did.)  The Data Type Definition does not indicate whether a variable is or is not a collection; that configuration is on the Variable Definition.  Variable Definitions scoped to the Process Definition or a Task Definition may be marked as Input Parameters and/or Output Parameters, but Variable Definitions scoped to a State Sequence Definition can marked as neither Input nor Output Parameters.&lt;br&gt;&lt;br&gt;An Action is the smallest unit of executable.  Actions are added to Sequence Definitions, and no Action can exist outside of a Sequence Definition.  There are currently two types of Sequence Definitions: State Sequence Definitions and Task Sequence Definitions.  They are very similar, and may generally contain the same kinds of actions, with few restrictions.  A State Sequence Definition is called via a ChangeState action, cannot have input or output parameters, does not induce any Outputs onto the ChangeState action that calls the sequence, and cannot use the ExitTask action.  A Task Sequence Definition is called via the CallTaskSync action, can have input and/or output parameters, may induce Outputs onto the CallTaskSync action that calls the sequence, and can use the ExitTask action.&lt;br&gt;&lt;br&gt;An Action may have zero or more Outputs, where each Output is essentially just a pointer to another Action within the same Sequence Definition via an associated Connection object.  An Action with no Outputs is a Terminating Action because it causes the current sequence to end.  Examples of terminating actions are ChangeState, ExitTask and EndProcess.  All non-terminating actions will have at least one Output.  Some actions have a fixed set of outputs (i.e. Conditional if with true/false).  Many actions will have a Default Output that is always present.  Sometimes the Default Output may be the only Output (i.e. UpdateVariables).  Sometimes Outputs get induced into an action by something the action references (i.e. RunProcessSync has a Default Output, but may also gets induced outputs due to Process End Reasons from the referenced Process Definition).&lt;br&gt;&lt;br&gt;A Connection connects a specific Output of a specific Action to another Action, or even back to the same Action.  Think of Connections as the \&quot;arrows\&quot; that the server follows while the server is executing a flow: the server runs an Action; if it is a non-terminating Action, then after the action has completed the server selects an Output on that Action; once the Output is selected, the server looks for a Connection from that Output to another Action, but if there is no Connection for that output then the server exits the sequence (i.e. ExitTask(Default) if it is a Task Sequence Definition, or EndProcess(Default) if it is a State Sequence Definition).&lt;br&gt;&lt;br&gt;Note:  There is no need for a Loop action.  This is because a Connection can point from an Output of an Action back to the same action, which is itself inherently a loop.&lt;br&gt;&lt;br&gt;&lt;br&gt;Page Definition JSON Guidelines&lt;br&gt;The following subsections list the general guides lines to follow when creating JSON objects to be include on the Process Definition File.&lt;br&gt;&lt;br&gt;Keep the JSON Shallow Instead of Deep&lt;br&gt;There will always be some level of nesting within JSON: JSON itself always has one root object that contains everything else.  But, as a general rule, we want to keep the JSON shallow instead of deep.  This necessarily implies that fields that reference really complex objects are preferred over fields that contain really complex objects.  For example, rather than nest actions inside of actions that are also nested inside of other actions, all actions within the same sequence are defined within a single list because they are in the scope.  Then, there is another list at sequence scope that contains all of the connections between all of the actions.  Keep things shallow generally makes it easy to find the object you are looking for given it&#39;s ID, and nesting deep does not easily allow for structures like actions that connect back to another action earlier in the flow.&lt;br&gt;&lt;br&gt;Mind the Well-Known Field Names&lt;br&gt;This file format uses several well-known field names, such as the ones below:&lt;br&gt;    \&quot;_meta\&quot;&lt;br&gt;    \&quot;id\&quot;&lt;br&gt;    \&quot;refId\&quot;&lt;br&gt;    \&quot;designer\&quot;&lt;br&gt;    \&quot;config\&quot;&lt;br&gt;&lt;br&gt;That list of well-known field names above is not necessarily complete at this time, and will be extended as necessary.  All of the field names within that list should be discussed in this page.\n&lt;br&gt;The well-known field names shall only be used for their intended purposes.  Other fields may contain the well known names within a substring of their entire field names. (i.e. \&quot;designer\&quot; must conform to the rules for \&quot;designer\&quot;, but \&quot;myDesigner\&quot; could be used for something else.\n&lt;br&gt;The \&quot;_meta\&quot; Field\n&lt;br&gt;For deserialization or interpretation purposes, some objects may need a meta section to capture information such as the version of a serialization format.  When present, the field name shall be \&quot;_meta\&quot;, and it shall always be the first field within the object.\n&lt;br&gt;There is not currently a specific set of what may or may not appear in a meta object.  Each meta object will likely have the \&quot;objectType\&quot; field, which holds a string that indicates what type of data is contained by the object with the \&quot;_meta\&quot; field.  Other possible fields that may be used are \&quot;formatType\&quot; and/or \&quot;formatVersion\&quot;.  The idea is that the meta object should contain any information that may be necessary for an application to know or understand the other fields that are siblings of the \&quot;_meta\&quot; field within the same object. \n&lt;br&gt;Generally speaking, the fields within a JSON object are allowed to be in any order, and some serializers may choose to always write the fields in alphabetic order by default.  But, it is somewhat pointless to even have the \&quot;_meta\&quot; field if it is not first since it&#39;s information could not then be used to know what to expect while deserializing the remainder of the object.  Therefore, the meta field intentionally starts with an underscore character to force it to the top if the fields get sorted during serialization.\n&lt;br&gt;Also, it is intended that the meta can really appear within almost any object.  Basically, if a bit of extra information is is needed to understand or parse something, a \&quot;_meta\&quot; field can be added to help interpret the other fields that are siblings of the _meta field.  All \&quot;definition\&quot; objects should have a meta object that, at a minimum, indicates \&quot;objectType\&quot;.\n&lt;br&gt;&lt;br&gt;&lt;pre&gt;{    // This field, if present, must always be first!&lt;br&gt;    \&quot;_meta\&quot;:&lt;br&gt;    {&lt;br&gt;        // These are some suggest field names, but may not apply in all cases&lt;br&gt;        \&quot;objectType\&quot;: &lt;string&gt;&lt;br&gt;        \&quot;formatType\&quot;: &lt;string&gt;,&lt;br&gt;        \&quot;formatRevision\&quot;: &lt;version&gt;,&lt;br&gt; &lt;br&gt;        // Could really have just about anything else here, too&lt;br&gt;        ....&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    // More fields for this specific object must come after the \&quot;_meta\&quot;&lt;br&gt;    ...&lt;br&gt;}&lt;br&gt; &lt;br&gt;// Null \&quot;_meta\&quot; is allowed&lt;br&gt;{&lt;br&gt;    \&quot;_meta\&quot;: null,&lt;br&gt;    ...&lt;br&gt;}&lt;br&gt; &lt;br&gt;// Empty object \&quot;_meta\&quot; is allowed&lt;br&gt;{&lt;br&gt;    \&quot;_meta: {},&lt;br&gt;    ...&lt;br&gt;}&lt;br&gt;// Omitted \&quot;_meta\&quot; is allowed&lt;br&gt;{&lt;br&gt;    ...&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;&lt;br&gt;IDs and \&quot;id\&quot; &amp; \&quot;refId\&quot; Fields&lt;br&gt;&lt;br&gt;The process definition uses IDs!!!  Think of an ID as something that uniquely identifies an object definition.  Conceptually, they are like GUIDs.  However, in reality, something a bit less verbose than GUIDs may be used.&lt;br&gt;&lt;br&gt;In an attempt to more easily figure out which object owns/defines/declares the ID vs. which objects just reference the ID, the field name of all owned IDs will be \&quot;id\&quot; and the field name for all referenced IDs will be \&quot;refId\&quot;.  Additionally, the \&quot;refId\&quot; shall always be inside a container object, which is intended to&lt;br&gt;&lt;br&gt;    Allow for additional information that describe the scope/context in which the ID indicated by \&quot;refId\&quot; can be found, if necessary&lt;br&gt;    Accommodate the need to reference multiple objects from within the same parent object&lt;br&gt;    Eventually support the ability to reference objects defined outside of the Process Definition, such as shared Data Type Definitins or PureCloud Composer Scripts.&lt;br&gt;&lt;br&gt;The field name of the \&quot;refId\&quot; container object should generally end with \&quot;Ref\&quot;.&lt;br&gt;&lt;pre&gt;// Object definition that is assigning an ID to itself; The \&quot;id\&quot; field does not have to be first&lt;br&gt;{&lt;br&gt;    ...,&lt;br&gt;    \&quot;id\&quot;: &lt;id&gt;,&lt;br&gt;    ...&lt;br&gt;}&lt;/pre&gt;&lt;br&gt; &lt;br&gt;// Object definition that is referencing the object above via the \&quot;refId\&quot; field&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    // Container object for the \&quot;fieldOne\&quot; reference&lt;br&gt;    \&quot;fieldOneRef\&quot;:&lt;br&gt;    {&lt;br&gt;        ...,&lt;br&gt; &lt;br&gt;        // This field indicates the ID of that other object that is being referenced&lt;br&gt;        \&quot;refId\&quot;: &lt;id&gt;,&lt;br&gt; &lt;br&gt;        // If necessary, we can add additional fields that describe the scope/context in which&lt;br&gt;        // the object being referenced is expected to be found.&lt;br&gt;        ...&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    // Since \&quot;refId\&quot; is a well-known field name but the containing object&#39;s field names are not&lt;br&gt;    // (i.e. \&quot;fieldOneRef\&quot; and \&quot;fieldTwoRef\&quot; are not well-known field names) the same parent object&lt;br&gt;    // can easily reference multiple other objects, while keeping the \&quot;refId\&quot; field name consistent.&lt;br&gt;    \&quot;fieldTwoRef\&quot;:&lt;br&gt;    {&lt;br&gt;        ...,&lt;br&gt;        \&quot;refId\&quot;: &lt;id&gt;,&lt;br&gt;        ...&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;The \&quot;identity\&quot; Field\n&lt;br&gt;Everything about declaring the identity of the object is stored in the \&quot;identity\&quot; field.  This includes things like the \&quot;id\&quot; field, if necessary, as well as optional \&quot;name\&quot; and \&quot;description\&quot; fields in which store information entered by the user via the designer; it is unclear at this point whether the designer will or will not actually allow the user to view and/or enter a label and/or description for every major object, but the format will at least support it wherever the designer chooses to allow it!  Other information specific to certain object types, such as the revision of the Process Definition, could potentially also be stored in this object.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    \&quot;identity\&quot;:&lt;br&gt;    {&lt;br&gt;        \&quot;id\&quot;:&lt;id&gt;,&lt;br&gt;        \&quot;name\&quot;:string,&lt;br&gt;        \&quot;description\&quot;:&lt;string&gt;&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;Note:  The \&quot;name\&quot; and \&quot;description\&quot; fields should generally be treated as user-mutable, display only – so don&#39;t write any code to make any decisions based on a string value in \&quot;name or description\&quot;!  For example, don&#39;t look for an output named \&quot;true\&quot; on a ConditionalIf action, because it could be localized to another language, or the user may have changed it to \&quot;yes\&quot;, \&quot;on\&quot;, etc.&lt;br&gt;The \&quot;designer\&quot; Field&lt;br&gt;&lt;br&gt;Any designer-specific information shall be isolated into an object under a \&quot;designer\&quot; field.  This is a well-known field name, and is intended to better faciliate the creation of a streamlined, compiled version of the process definition, etc. should the server decide that it wants to do so.  It is assumed that anything within an object used as the value for a \&quot;designer\&quot; field is not needed at runtime by the server or by clients.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    \&quot;designer\&quot;:&lt;br&gt;    {&lt;br&gt;        ...,&lt;br&gt;        \&quot;notes\&quot;: &lt;string&gt;,&lt;br&gt;        ...&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;A \&quot;designer\&quot; field can occur at many levels within the JSON, and can always be ignored by the server.  As an example of something that may be added to a designer field, consider the Connections between an Action&#39;s Output an the next Action.  The server needs to know what the connection is (i.e. Action&#39;s Output points to another Action), but does not need how the connection looks when \&quot;drawn\&quot; by the user (i.e. goes up, right, down, right, etc.)&lt;br&gt;&lt;br&gt;The sample JSON above shows a \&quot;notes\&quot; field in object used as the value for the \&quot;designer\&quot; field.  The \&quot;identity\&quot; section mentioned previously had \&quot;name\&quot; and \&quot;description\&quot; fields.  The idea of adding \&quot;notes\&quot; into the designer field is to allow people designing the process to add very verbose notes about design decisions, etc.  That differs from the identity.descripion, which is intended to be more of a an end-user viewable description, such as a description that assists the user to select the correct Process Definition to launch.&lt;br&gt;The \&quot;config\&quot; Field&lt;br&gt;&lt;br&gt;Many of the objects may have a \&quot;config\&quot; field.  The contents of this field will generally be specific to the object.  This is were details about Action configuration, Variables configuration, etc. will be located.&lt;br&gt;The \&quot;definitions\&quot; field and Definition Lists&lt;br&gt;&lt;br&gt;Many of the JSON definition objects will themselves also contain definition lists.  For example the Process Definition objects will have a Data Type Definitions list, Variable Definitions list, Sequence Definitions list, End Process Reasons List,. etc.  The Sequence Definition will have an Action Definitions List, Connection Definitions List, Exit Reasons Definitions List, etc. &lt;br&gt;&lt;br&gt;When an object definition itself needs to include one or more definition lists, the object shall have a \&quot;definitions\&quot; field, and the value of that field is an object where the field names are the names of the definition lists.  Additionally, each of those field names that contains a single definition list will generally end with \&quot;Def\&quot;, and every object definition within a definition list will have an \&quot;identity\&quot; field.  If the objects with a specific definition list have identity.name fields, then each of those identity.name fields shall be unique among all of the objects within that same definition list!&lt;br&gt;// This is a definition object.  Generally speaking, definition lists will exist within some other definition object.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    ...,&lt;br&gt; &lt;br&gt;    // This field contains all of the definition lists,if any&lt;br&gt;    \&quot;definitions\&quot;:&lt;br&gt;    {&lt;br&gt;        // This is the definition list for abcDef objects&lt;br&gt;        \&quot;abcDefs\&quot;:&lt;br&gt;        [&lt;br&gt;            // Each abcDef object has an identity.id&lt;br&gt;            {&lt;br&gt;                \&quot;identity\&quot;:&lt;br&gt;                {&lt;br&gt;                    \&quot;id\&quot;:&lt;id&gt;,&lt;br&gt;                    \&quot;name\&quot;:&lt;string&gt;,&lt;br&gt;                }&lt;br&gt;            },&lt;br&gt; &lt;br&gt;            // There can be any number of definition objects within this definition list,&lt;br&gt;            // but each of them must have a different value for identity.name.&lt;br&gt;            ...&lt;br&gt;        ],&lt;br&gt; &lt;br&gt;        // This is the definition list of xyzDef objects&lt;br&gt;        \&quot;xyzDefs\&quot;:&lt;br&gt;        [&lt;br&gt;            // Each xyzDef object has an identity.id&lt;br&gt;            {&lt;br&gt;                \&quot;identity\&quot;:&lt;br&gt;                {&lt;br&gt;                    \&quot;id\&quot;:&lt;id&gt;,&lt;br&gt; &lt;br&gt;                    // The value of this identity.name field could be the same as a definition&lt;br&gt;                    // object within the \&quot;abcDefs\&quot; definition list above because the definition&lt;br&gt;                    // objects exist within different definition lists.&lt;br&gt;                    \&quot;name\&quot;:&lt;string&gt;&lt;br&gt;                }&lt;br&gt;            },&lt;br&gt;            ...&lt;br&gt;        ]&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    ...,&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;No Back-Pointers&lt;br&gt;&lt;br&gt;Generally speaking, the JSON should stay away from back-pointers.  A back-pointer is a reference back to the parent object definition that has the definitions list that contains the object doing the back-pointing.  For example, a StateSequenceDefinition exists within the ProcessDefinition.definitions.stateSequenceDefs list:&lt;br&gt;&lt;br&gt;    Process Definition&lt;br&gt;        definitions&lt;br&gt;            stateSequenceDefs&lt;br&gt;                StateSequenceDefinition&lt;br&gt;&lt;br&gt; &lt;br&gt;&lt;br&gt;In the example above, the JSON for the StateSeqenceDefinition should not point back to the stateSequenceDefs definitions list, or to the definitions field that contains that definitions list, or the Process Definition that contains that definitions field.  There is no need for such back-pointers because the relationship is already implied by the structure of the JSON.  With that said, however, it is likely that applications may find it useful to create such back-pointers in memory for the purpose of navigating through and manipulating the object graph; they just don&#39;t need to serialize it into the JSON.&lt;br&gt;Object Definition Template&lt;br&gt;&lt;br&gt;Given the guidelines above, the following is kind of a template for all JSON object definitions.  For any specific definition, however, some of the sections or fields within those sections may not apply.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    \&quot;_meta\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    \&quot;identity\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    // Keep in mind that the \&quot;designer\&quot; fields can really exist anywhere,&lt;br&gt;    // not just at the top of a definition.&lt;br&gt;    \&quot;designer\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    \&quot;config\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    \&quot;definitions\&quot;:&lt;br&gt;    {&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;
        /// </summary>
        /// <param name="id">Flow ID</param> 
        /// <param name="keepDraft">Keep flow draft</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of FlowVersionConfigMetaData</returns>
        public ApiResponse< FlowVersionConfigMetaData > ProcessautomationFlowsDefinitionsIdVersionsPostWithHttpInfo (string id, bool? keepDraft = null, string expand = null, FlowVersionConfigMetaData body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsDefinitionsIdVersionsPost");
            
    
            var path_ = "/api/v1/processautomation/flows/definitions/{id}/versions";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (keepDraft != null) queryParams.Add("keepDraft", Configuration.ApiClient.ParameterToString(keepDraft)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdVersionsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdVersionsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FlowVersionConfigMetaData>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowVersionConfigMetaData) Configuration.ApiClient.Deserialize(response, typeof(FlowVersionConfigMetaData)));
            
        }
    
        /// <summary>
        /// Create a new versioned flow This method requires the base flow to be already created... and then (with permission) you can create a versioned flow that references it.  This method will set the meta-data of that versioned flow you&#39;re creating, and return to you a Uri of the user-upload-service where you can supply the bits of the flow definition.&lt;br&gt;&lt;br&gt;There is a Process Definition File for each version of a process.  The Process Definition File contains all of the definitions for everything used by the process.  Eventually, we may support Shared Data Types, Shared Sequences, etc. that are defined in separate files, are organization-global and useable across multiple process definitions for the same organization, but such shared objects are beyond the scope of the initial release.&lt;br&gt;&lt;br&gt;The Process Definition File contains Data Type Definitions, Variable Definitions, Sequence Definitions, and Actions, Outputs and Connections.&lt;br&gt;&lt;br&gt;Variable Definitions can be created in process-scope or sequence-scope.  A Variable Definition always references a Data Type Definition, regardless of whether the Variable Definition is defining a basic, simple or complex variable.  ( In IPA, basic variables did not have a separate data type definition, but simple and complex variables did.)  The Data Type Definition does not indicate whether a variable is or is not a collection; that configuration is on the Variable Definition.  Variable Definitions scoped to the Process Definition or a Task Definition may be marked as Input Parameters and/or Output Parameters, but Variable Definitions scoped to a State Sequence Definition can marked as neither Input nor Output Parameters.&lt;br&gt;&lt;br&gt;An Action is the smallest unit of executable.  Actions are added to Sequence Definitions, and no Action can exist outside of a Sequence Definition.  There are currently two types of Sequence Definitions: State Sequence Definitions and Task Sequence Definitions.  They are very similar, and may generally contain the same kinds of actions, with few restrictions.  A State Sequence Definition is called via a ChangeState action, cannot have input or output parameters, does not induce any Outputs onto the ChangeState action that calls the sequence, and cannot use the ExitTask action.  A Task Sequence Definition is called via the CallTaskSync action, can have input and/or output parameters, may induce Outputs onto the CallTaskSync action that calls the sequence, and can use the ExitTask action.&lt;br&gt;&lt;br&gt;An Action may have zero or more Outputs, where each Output is essentially just a pointer to another Action within the same Sequence Definition via an associated Connection object.  An Action with no Outputs is a Terminating Action because it causes the current sequence to end.  Examples of terminating actions are ChangeState, ExitTask and EndProcess.  All non-terminating actions will have at least one Output.  Some actions have a fixed set of outputs (i.e. Conditional if with true/false).  Many actions will have a Default Output that is always present.  Sometimes the Default Output may be the only Output (i.e. UpdateVariables).  Sometimes Outputs get induced into an action by something the action references (i.e. RunProcessSync has a Default Output, but may also gets induced outputs due to Process End Reasons from the referenced Process Definition).&lt;br&gt;&lt;br&gt;A Connection connects a specific Output of a specific Action to another Action, or even back to the same Action.  Think of Connections as the \&quot;arrows\&quot; that the server follows while the server is executing a flow: the server runs an Action; if it is a non-terminating Action, then after the action has completed the server selects an Output on that Action; once the Output is selected, the server looks for a Connection from that Output to another Action, but if there is no Connection for that output then the server exits the sequence (i.e. ExitTask(Default) if it is a Task Sequence Definition, or EndProcess(Default) if it is a State Sequence Definition).&lt;br&gt;&lt;br&gt;Note:  There is no need for a Loop action.  This is because a Connection can point from an Output of an Action back to the same action, which is itself inherently a loop.&lt;br&gt;&lt;br&gt;&lt;br&gt;Page Definition JSON Guidelines&lt;br&gt;The following subsections list the general guides lines to follow when creating JSON objects to be include on the Process Definition File.&lt;br&gt;&lt;br&gt;Keep the JSON Shallow Instead of Deep&lt;br&gt;There will always be some level of nesting within JSON: JSON itself always has one root object that contains everything else.  But, as a general rule, we want to keep the JSON shallow instead of deep.  This necessarily implies that fields that reference really complex objects are preferred over fields that contain really complex objects.  For example, rather than nest actions inside of actions that are also nested inside of other actions, all actions within the same sequence are defined within a single list because they are in the scope.  Then, there is another list at sequence scope that contains all of the connections between all of the actions.  Keep things shallow generally makes it easy to find the object you are looking for given it&#39;s ID, and nesting deep does not easily allow for structures like actions that connect back to another action earlier in the flow.&lt;br&gt;&lt;br&gt;Mind the Well-Known Field Names&lt;br&gt;This file format uses several well-known field names, such as the ones below:&lt;br&gt;    \&quot;_meta\&quot;&lt;br&gt;    \&quot;id\&quot;&lt;br&gt;    \&quot;refId\&quot;&lt;br&gt;    \&quot;designer\&quot;&lt;br&gt;    \&quot;config\&quot;&lt;br&gt;&lt;br&gt;That list of well-known field names above is not necessarily complete at this time, and will be extended as necessary.  All of the field names within that list should be discussed in this page.\n&lt;br&gt;The well-known field names shall only be used for their intended purposes.  Other fields may contain the well known names within a substring of their entire field names. (i.e. \&quot;designer\&quot; must conform to the rules for \&quot;designer\&quot;, but \&quot;myDesigner\&quot; could be used for something else.\n&lt;br&gt;The \&quot;_meta\&quot; Field\n&lt;br&gt;For deserialization or interpretation purposes, some objects may need a meta section to capture information such as the version of a serialization format.  When present, the field name shall be \&quot;_meta\&quot;, and it shall always be the first field within the object.\n&lt;br&gt;There is not currently a specific set of what may or may not appear in a meta object.  Each meta object will likely have the \&quot;objectType\&quot; field, which holds a string that indicates what type of data is contained by the object with the \&quot;_meta\&quot; field.  Other possible fields that may be used are \&quot;formatType\&quot; and/or \&quot;formatVersion\&quot;.  The idea is that the meta object should contain any information that may be necessary for an application to know or understand the other fields that are siblings of the \&quot;_meta\&quot; field within the same object. \n&lt;br&gt;Generally speaking, the fields within a JSON object are allowed to be in any order, and some serializers may choose to always write the fields in alphabetic order by default.  But, it is somewhat pointless to even have the \&quot;_meta\&quot; field if it is not first since it&#39;s information could not then be used to know what to expect while deserializing the remainder of the object.  Therefore, the meta field intentionally starts with an underscore character to force it to the top if the fields get sorted during serialization.\n&lt;br&gt;Also, it is intended that the meta can really appear within almost any object.  Basically, if a bit of extra information is is needed to understand or parse something, a \&quot;_meta\&quot; field can be added to help interpret the other fields that are siblings of the _meta field.  All \&quot;definition\&quot; objects should have a meta object that, at a minimum, indicates \&quot;objectType\&quot;.\n&lt;br&gt;&lt;br&gt;&lt;pre&gt;{    // This field, if present, must always be first!&lt;br&gt;    \&quot;_meta\&quot;:&lt;br&gt;    {&lt;br&gt;        // These are some suggest field names, but may not apply in all cases&lt;br&gt;        \&quot;objectType\&quot;: &lt;string&gt;&lt;br&gt;        \&quot;formatType\&quot;: &lt;string&gt;,&lt;br&gt;        \&quot;formatRevision\&quot;: &lt;version&gt;,&lt;br&gt; &lt;br&gt;        // Could really have just about anything else here, too&lt;br&gt;        ....&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    // More fields for this specific object must come after the \&quot;_meta\&quot;&lt;br&gt;    ...&lt;br&gt;}&lt;br&gt; &lt;br&gt;// Null \&quot;_meta\&quot; is allowed&lt;br&gt;{&lt;br&gt;    \&quot;_meta\&quot;: null,&lt;br&gt;    ...&lt;br&gt;}&lt;br&gt; &lt;br&gt;// Empty object \&quot;_meta\&quot; is allowed&lt;br&gt;{&lt;br&gt;    \&quot;_meta: {},&lt;br&gt;    ...&lt;br&gt;}&lt;br&gt;// Omitted \&quot;_meta\&quot; is allowed&lt;br&gt;{&lt;br&gt;    ...&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;&lt;br&gt;IDs and \&quot;id\&quot; &amp; \&quot;refId\&quot; Fields&lt;br&gt;&lt;br&gt;The process definition uses IDs!!!  Think of an ID as something that uniquely identifies an object definition.  Conceptually, they are like GUIDs.  However, in reality, something a bit less verbose than GUIDs may be used.&lt;br&gt;&lt;br&gt;In an attempt to more easily figure out which object owns/defines/declares the ID vs. which objects just reference the ID, the field name of all owned IDs will be \&quot;id\&quot; and the field name for all referenced IDs will be \&quot;refId\&quot;.  Additionally, the \&quot;refId\&quot; shall always be inside a container object, which is intended to&lt;br&gt;&lt;br&gt;    Allow for additional information that describe the scope/context in which the ID indicated by \&quot;refId\&quot; can be found, if necessary&lt;br&gt;    Accommodate the need to reference multiple objects from within the same parent object&lt;br&gt;    Eventually support the ability to reference objects defined outside of the Process Definition, such as shared Data Type Definitins or PureCloud Composer Scripts.&lt;br&gt;&lt;br&gt;The field name of the \&quot;refId\&quot; container object should generally end with \&quot;Ref\&quot;.&lt;br&gt;&lt;pre&gt;// Object definition that is assigning an ID to itself; The \&quot;id\&quot; field does not have to be first&lt;br&gt;{&lt;br&gt;    ...,&lt;br&gt;    \&quot;id\&quot;: &lt;id&gt;,&lt;br&gt;    ...&lt;br&gt;}&lt;/pre&gt;&lt;br&gt; &lt;br&gt;// Object definition that is referencing the object above via the \&quot;refId\&quot; field&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    // Container object for the \&quot;fieldOne\&quot; reference&lt;br&gt;    \&quot;fieldOneRef\&quot;:&lt;br&gt;    {&lt;br&gt;        ...,&lt;br&gt; &lt;br&gt;        // This field indicates the ID of that other object that is being referenced&lt;br&gt;        \&quot;refId\&quot;: &lt;id&gt;,&lt;br&gt; &lt;br&gt;        // If necessary, we can add additional fields that describe the scope/context in which&lt;br&gt;        // the object being referenced is expected to be found.&lt;br&gt;        ...&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    // Since \&quot;refId\&quot; is a well-known field name but the containing object&#39;s field names are not&lt;br&gt;    // (i.e. \&quot;fieldOneRef\&quot; and \&quot;fieldTwoRef\&quot; are not well-known field names) the same parent object&lt;br&gt;    // can easily reference multiple other objects, while keeping the \&quot;refId\&quot; field name consistent.&lt;br&gt;    \&quot;fieldTwoRef\&quot;:&lt;br&gt;    {&lt;br&gt;        ...,&lt;br&gt;        \&quot;refId\&quot;: &lt;id&gt;,&lt;br&gt;        ...&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;The \&quot;identity\&quot; Field\n&lt;br&gt;Everything about declaring the identity of the object is stored in the \&quot;identity\&quot; field.  This includes things like the \&quot;id\&quot; field, if necessary, as well as optional \&quot;name\&quot; and \&quot;description\&quot; fields in which store information entered by the user via the designer; it is unclear at this point whether the designer will or will not actually allow the user to view and/or enter a label and/or description for every major object, but the format will at least support it wherever the designer chooses to allow it!  Other information specific to certain object types, such as the revision of the Process Definition, could potentially also be stored in this object.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    \&quot;identity\&quot;:&lt;br&gt;    {&lt;br&gt;        \&quot;id\&quot;:&lt;id&gt;,&lt;br&gt;        \&quot;name\&quot;:string,&lt;br&gt;        \&quot;description\&quot;:&lt;string&gt;&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;Note:  The \&quot;name\&quot; and \&quot;description\&quot; fields should generally be treated as user-mutable, display only – so don&#39;t write any code to make any decisions based on a string value in \&quot;name or description\&quot;!  For example, don&#39;t look for an output named \&quot;true\&quot; on a ConditionalIf action, because it could be localized to another language, or the user may have changed it to \&quot;yes\&quot;, \&quot;on\&quot;, etc.&lt;br&gt;The \&quot;designer\&quot; Field&lt;br&gt;&lt;br&gt;Any designer-specific information shall be isolated into an object under a \&quot;designer\&quot; field.  This is a well-known field name, and is intended to better faciliate the creation of a streamlined, compiled version of the process definition, etc. should the server decide that it wants to do so.  It is assumed that anything within an object used as the value for a \&quot;designer\&quot; field is not needed at runtime by the server or by clients.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    \&quot;designer\&quot;:&lt;br&gt;    {&lt;br&gt;        ...,&lt;br&gt;        \&quot;notes\&quot;: &lt;string&gt;,&lt;br&gt;        ...&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;A \&quot;designer\&quot; field can occur at many levels within the JSON, and can always be ignored by the server.  As an example of something that may be added to a designer field, consider the Connections between an Action&#39;s Output an the next Action.  The server needs to know what the connection is (i.e. Action&#39;s Output points to another Action), but does not need how the connection looks when \&quot;drawn\&quot; by the user (i.e. goes up, right, down, right, etc.)&lt;br&gt;&lt;br&gt;The sample JSON above shows a \&quot;notes\&quot; field in object used as the value for the \&quot;designer\&quot; field.  The \&quot;identity\&quot; section mentioned previously had \&quot;name\&quot; and \&quot;description\&quot; fields.  The idea of adding \&quot;notes\&quot; into the designer field is to allow people designing the process to add very verbose notes about design decisions, etc.  That differs from the identity.descripion, which is intended to be more of a an end-user viewable description, such as a description that assists the user to select the correct Process Definition to launch.&lt;br&gt;The \&quot;config\&quot; Field&lt;br&gt;&lt;br&gt;Many of the objects may have a \&quot;config\&quot; field.  The contents of this field will generally be specific to the object.  This is were details about Action configuration, Variables configuration, etc. will be located.&lt;br&gt;The \&quot;definitions\&quot; field and Definition Lists&lt;br&gt;&lt;br&gt;Many of the JSON definition objects will themselves also contain definition lists.  For example the Process Definition objects will have a Data Type Definitions list, Variable Definitions list, Sequence Definitions list, End Process Reasons List,. etc.  The Sequence Definition will have an Action Definitions List, Connection Definitions List, Exit Reasons Definitions List, etc. &lt;br&gt;&lt;br&gt;When an object definition itself needs to include one or more definition lists, the object shall have a \&quot;definitions\&quot; field, and the value of that field is an object where the field names are the names of the definition lists.  Additionally, each of those field names that contains a single definition list will generally end with \&quot;Def\&quot;, and every object definition within a definition list will have an \&quot;identity\&quot; field.  If the objects with a specific definition list have identity.name fields, then each of those identity.name fields shall be unique among all of the objects within that same definition list!&lt;br&gt;// This is a definition object.  Generally speaking, definition lists will exist within some other definition object.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    ...,&lt;br&gt; &lt;br&gt;    // This field contains all of the definition lists,if any&lt;br&gt;    \&quot;definitions\&quot;:&lt;br&gt;    {&lt;br&gt;        // This is the definition list for abcDef objects&lt;br&gt;        \&quot;abcDefs\&quot;:&lt;br&gt;        [&lt;br&gt;            // Each abcDef object has an identity.id&lt;br&gt;            {&lt;br&gt;                \&quot;identity\&quot;:&lt;br&gt;                {&lt;br&gt;                    \&quot;id\&quot;:&lt;id&gt;,&lt;br&gt;                    \&quot;name\&quot;:&lt;string&gt;,&lt;br&gt;                }&lt;br&gt;            },&lt;br&gt; &lt;br&gt;            // There can be any number of definition objects within this definition list,&lt;br&gt;            // but each of them must have a different value for identity.name.&lt;br&gt;            ...&lt;br&gt;        ],&lt;br&gt; &lt;br&gt;        // This is the definition list of xyzDef objects&lt;br&gt;        \&quot;xyzDefs\&quot;:&lt;br&gt;        [&lt;br&gt;            // Each xyzDef object has an identity.id&lt;br&gt;            {&lt;br&gt;                \&quot;identity\&quot;:&lt;br&gt;                {&lt;br&gt;                    \&quot;id\&quot;:&lt;id&gt;,&lt;br&gt; &lt;br&gt;                    // The value of this identity.name field could be the same as a definition&lt;br&gt;                    // object within the \&quot;abcDefs\&quot; definition list above because the definition&lt;br&gt;                    // objects exist within different definition lists.&lt;br&gt;                    \&quot;name\&quot;:&lt;string&gt;&lt;br&gt;                }&lt;br&gt;            },&lt;br&gt;            ...&lt;br&gt;        ]&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    ...,&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;No Back-Pointers&lt;br&gt;&lt;br&gt;Generally speaking, the JSON should stay away from back-pointers.  A back-pointer is a reference back to the parent object definition that has the definitions list that contains the object doing the back-pointing.  For example, a StateSequenceDefinition exists within the ProcessDefinition.definitions.stateSequenceDefs list:&lt;br&gt;&lt;br&gt;    Process Definition&lt;br&gt;        definitions&lt;br&gt;            stateSequenceDefs&lt;br&gt;                StateSequenceDefinition&lt;br&gt;&lt;br&gt; &lt;br&gt;&lt;br&gt;In the example above, the JSON for the StateSeqenceDefinition should not point back to the stateSequenceDefs definitions list, or to the definitions field that contains that definitions list, or the Process Definition that contains that definitions field.  There is no need for such back-pointers because the relationship is already implied by the structure of the JSON.  With that said, however, it is likely that applications may find it useful to create such back-pointers in memory for the purpose of navigating through and manipulating the object graph; they just don&#39;t need to serialize it into the JSON.&lt;br&gt;Object Definition Template&lt;br&gt;&lt;br&gt;Given the guidelines above, the following is kind of a template for all JSON object definitions.  For any specific definition, however, some of the sections or fields within those sections may not apply.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    \&quot;_meta\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    \&quot;identity\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    // Keep in mind that the \&quot;designer\&quot; fields can really exist anywhere,&lt;br&gt;    // not just at the top of a definition.&lt;br&gt;    \&quot;designer\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    \&quot;config\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    \&quot;definitions\&quot;:&lt;br&gt;    {&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;
        /// </summary>
        /// <param name="id">Flow ID</param>
        /// <param name="keepDraft">Keep flow draft</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body"></param>
        /// <returns>Task of FlowVersionConfigMetaData</returns>
        public async System.Threading.Tasks.Task<FlowVersionConfigMetaData> ProcessautomationFlowsDefinitionsIdVersionsPostAsync (string id, bool? keepDraft = null, string expand = null, FlowVersionConfigMetaData body = null)
        {
             ApiResponse<FlowVersionConfigMetaData> response = await ProcessautomationFlowsDefinitionsIdVersionsPostAsyncWithHttpInfo(id, keepDraft, expand, body);
             return response.Data;

        }

        /// <summary>
        /// Create a new versioned flow This method requires the base flow to be already created... and then (with permission) you can create a versioned flow that references it.  This method will set the meta-data of that versioned flow you&#39;re creating, and return to you a Uri of the user-upload-service where you can supply the bits of the flow definition.&lt;br&gt;&lt;br&gt;There is a Process Definition File for each version of a process.  The Process Definition File contains all of the definitions for everything used by the process.  Eventually, we may support Shared Data Types, Shared Sequences, etc. that are defined in separate files, are organization-global and useable across multiple process definitions for the same organization, but such shared objects are beyond the scope of the initial release.&lt;br&gt;&lt;br&gt;The Process Definition File contains Data Type Definitions, Variable Definitions, Sequence Definitions, and Actions, Outputs and Connections.&lt;br&gt;&lt;br&gt;Variable Definitions can be created in process-scope or sequence-scope.  A Variable Definition always references a Data Type Definition, regardless of whether the Variable Definition is defining a basic, simple or complex variable.  ( In IPA, basic variables did not have a separate data type definition, but simple and complex variables did.)  The Data Type Definition does not indicate whether a variable is or is not a collection; that configuration is on the Variable Definition.  Variable Definitions scoped to the Process Definition or a Task Definition may be marked as Input Parameters and/or Output Parameters, but Variable Definitions scoped to a State Sequence Definition can marked as neither Input nor Output Parameters.&lt;br&gt;&lt;br&gt;An Action is the smallest unit of executable.  Actions are added to Sequence Definitions, and no Action can exist outside of a Sequence Definition.  There are currently two types of Sequence Definitions: State Sequence Definitions and Task Sequence Definitions.  They are very similar, and may generally contain the same kinds of actions, with few restrictions.  A State Sequence Definition is called via a ChangeState action, cannot have input or output parameters, does not induce any Outputs onto the ChangeState action that calls the sequence, and cannot use the ExitTask action.  A Task Sequence Definition is called via the CallTaskSync action, can have input and/or output parameters, may induce Outputs onto the CallTaskSync action that calls the sequence, and can use the ExitTask action.&lt;br&gt;&lt;br&gt;An Action may have zero or more Outputs, where each Output is essentially just a pointer to another Action within the same Sequence Definition via an associated Connection object.  An Action with no Outputs is a Terminating Action because it causes the current sequence to end.  Examples of terminating actions are ChangeState, ExitTask and EndProcess.  All non-terminating actions will have at least one Output.  Some actions have a fixed set of outputs (i.e. Conditional if with true/false).  Many actions will have a Default Output that is always present.  Sometimes the Default Output may be the only Output (i.e. UpdateVariables).  Sometimes Outputs get induced into an action by something the action references (i.e. RunProcessSync has a Default Output, but may also gets induced outputs due to Process End Reasons from the referenced Process Definition).&lt;br&gt;&lt;br&gt;A Connection connects a specific Output of a specific Action to another Action, or even back to the same Action.  Think of Connections as the \&quot;arrows\&quot; that the server follows while the server is executing a flow: the server runs an Action; if it is a non-terminating Action, then after the action has completed the server selects an Output on that Action; once the Output is selected, the server looks for a Connection from that Output to another Action, but if there is no Connection for that output then the server exits the sequence (i.e. ExitTask(Default) if it is a Task Sequence Definition, or EndProcess(Default) if it is a State Sequence Definition).&lt;br&gt;&lt;br&gt;Note:  There is no need for a Loop action.  This is because a Connection can point from an Output of an Action back to the same action, which is itself inherently a loop.&lt;br&gt;&lt;br&gt;&lt;br&gt;Page Definition JSON Guidelines&lt;br&gt;The following subsections list the general guides lines to follow when creating JSON objects to be include on the Process Definition File.&lt;br&gt;&lt;br&gt;Keep the JSON Shallow Instead of Deep&lt;br&gt;There will always be some level of nesting within JSON: JSON itself always has one root object that contains everything else.  But, as a general rule, we want to keep the JSON shallow instead of deep.  This necessarily implies that fields that reference really complex objects are preferred over fields that contain really complex objects.  For example, rather than nest actions inside of actions that are also nested inside of other actions, all actions within the same sequence are defined within a single list because they are in the scope.  Then, there is another list at sequence scope that contains all of the connections between all of the actions.  Keep things shallow generally makes it easy to find the object you are looking for given it&#39;s ID, and nesting deep does not easily allow for structures like actions that connect back to another action earlier in the flow.&lt;br&gt;&lt;br&gt;Mind the Well-Known Field Names&lt;br&gt;This file format uses several well-known field names, such as the ones below:&lt;br&gt;    \&quot;_meta\&quot;&lt;br&gt;    \&quot;id\&quot;&lt;br&gt;    \&quot;refId\&quot;&lt;br&gt;    \&quot;designer\&quot;&lt;br&gt;    \&quot;config\&quot;&lt;br&gt;&lt;br&gt;That list of well-known field names above is not necessarily complete at this time, and will be extended as necessary.  All of the field names within that list should be discussed in this page.\n&lt;br&gt;The well-known field names shall only be used for their intended purposes.  Other fields may contain the well known names within a substring of their entire field names. (i.e. \&quot;designer\&quot; must conform to the rules for \&quot;designer\&quot;, but \&quot;myDesigner\&quot; could be used for something else.\n&lt;br&gt;The \&quot;_meta\&quot; Field\n&lt;br&gt;For deserialization or interpretation purposes, some objects may need a meta section to capture information such as the version of a serialization format.  When present, the field name shall be \&quot;_meta\&quot;, and it shall always be the first field within the object.\n&lt;br&gt;There is not currently a specific set of what may or may not appear in a meta object.  Each meta object will likely have the \&quot;objectType\&quot; field, which holds a string that indicates what type of data is contained by the object with the \&quot;_meta\&quot; field.  Other possible fields that may be used are \&quot;formatType\&quot; and/or \&quot;formatVersion\&quot;.  The idea is that the meta object should contain any information that may be necessary for an application to know or understand the other fields that are siblings of the \&quot;_meta\&quot; field within the same object. \n&lt;br&gt;Generally speaking, the fields within a JSON object are allowed to be in any order, and some serializers may choose to always write the fields in alphabetic order by default.  But, it is somewhat pointless to even have the \&quot;_meta\&quot; field if it is not first since it&#39;s information could not then be used to know what to expect while deserializing the remainder of the object.  Therefore, the meta field intentionally starts with an underscore character to force it to the top if the fields get sorted during serialization.\n&lt;br&gt;Also, it is intended that the meta can really appear within almost any object.  Basically, if a bit of extra information is is needed to understand or parse something, a \&quot;_meta\&quot; field can be added to help interpret the other fields that are siblings of the _meta field.  All \&quot;definition\&quot; objects should have a meta object that, at a minimum, indicates \&quot;objectType\&quot;.\n&lt;br&gt;&lt;br&gt;&lt;pre&gt;{    // This field, if present, must always be first!&lt;br&gt;    \&quot;_meta\&quot;:&lt;br&gt;    {&lt;br&gt;        // These are some suggest field names, but may not apply in all cases&lt;br&gt;        \&quot;objectType\&quot;: &lt;string&gt;&lt;br&gt;        \&quot;formatType\&quot;: &lt;string&gt;,&lt;br&gt;        \&quot;formatRevision\&quot;: &lt;version&gt;,&lt;br&gt; &lt;br&gt;        // Could really have just about anything else here, too&lt;br&gt;        ....&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    // More fields for this specific object must come after the \&quot;_meta\&quot;&lt;br&gt;    ...&lt;br&gt;}&lt;br&gt; &lt;br&gt;// Null \&quot;_meta\&quot; is allowed&lt;br&gt;{&lt;br&gt;    \&quot;_meta\&quot;: null,&lt;br&gt;    ...&lt;br&gt;}&lt;br&gt; &lt;br&gt;// Empty object \&quot;_meta\&quot; is allowed&lt;br&gt;{&lt;br&gt;    \&quot;_meta: {},&lt;br&gt;    ...&lt;br&gt;}&lt;br&gt;// Omitted \&quot;_meta\&quot; is allowed&lt;br&gt;{&lt;br&gt;    ...&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;&lt;br&gt;IDs and \&quot;id\&quot; &amp; \&quot;refId\&quot; Fields&lt;br&gt;&lt;br&gt;The process definition uses IDs!!!  Think of an ID as something that uniquely identifies an object definition.  Conceptually, they are like GUIDs.  However, in reality, something a bit less verbose than GUIDs may be used.&lt;br&gt;&lt;br&gt;In an attempt to more easily figure out which object owns/defines/declares the ID vs. which objects just reference the ID, the field name of all owned IDs will be \&quot;id\&quot; and the field name for all referenced IDs will be \&quot;refId\&quot;.  Additionally, the \&quot;refId\&quot; shall always be inside a container object, which is intended to&lt;br&gt;&lt;br&gt;    Allow for additional information that describe the scope/context in which the ID indicated by \&quot;refId\&quot; can be found, if necessary&lt;br&gt;    Accommodate the need to reference multiple objects from within the same parent object&lt;br&gt;    Eventually support the ability to reference objects defined outside of the Process Definition, such as shared Data Type Definitins or PureCloud Composer Scripts.&lt;br&gt;&lt;br&gt;The field name of the \&quot;refId\&quot; container object should generally end with \&quot;Ref\&quot;.&lt;br&gt;&lt;pre&gt;// Object definition that is assigning an ID to itself; The \&quot;id\&quot; field does not have to be first&lt;br&gt;{&lt;br&gt;    ...,&lt;br&gt;    \&quot;id\&quot;: &lt;id&gt;,&lt;br&gt;    ...&lt;br&gt;}&lt;/pre&gt;&lt;br&gt; &lt;br&gt;// Object definition that is referencing the object above via the \&quot;refId\&quot; field&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    // Container object for the \&quot;fieldOne\&quot; reference&lt;br&gt;    \&quot;fieldOneRef\&quot;:&lt;br&gt;    {&lt;br&gt;        ...,&lt;br&gt; &lt;br&gt;        // This field indicates the ID of that other object that is being referenced&lt;br&gt;        \&quot;refId\&quot;: &lt;id&gt;,&lt;br&gt; &lt;br&gt;        // If necessary, we can add additional fields that describe the scope/context in which&lt;br&gt;        // the object being referenced is expected to be found.&lt;br&gt;        ...&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    // Since \&quot;refId\&quot; is a well-known field name but the containing object&#39;s field names are not&lt;br&gt;    // (i.e. \&quot;fieldOneRef\&quot; and \&quot;fieldTwoRef\&quot; are not well-known field names) the same parent object&lt;br&gt;    // can easily reference multiple other objects, while keeping the \&quot;refId\&quot; field name consistent.&lt;br&gt;    \&quot;fieldTwoRef\&quot;:&lt;br&gt;    {&lt;br&gt;        ...,&lt;br&gt;        \&quot;refId\&quot;: &lt;id&gt;,&lt;br&gt;        ...&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;The \&quot;identity\&quot; Field\n&lt;br&gt;Everything about declaring the identity of the object is stored in the \&quot;identity\&quot; field.  This includes things like the \&quot;id\&quot; field, if necessary, as well as optional \&quot;name\&quot; and \&quot;description\&quot; fields in which store information entered by the user via the designer; it is unclear at this point whether the designer will or will not actually allow the user to view and/or enter a label and/or description for every major object, but the format will at least support it wherever the designer chooses to allow it!  Other information specific to certain object types, such as the revision of the Process Definition, could potentially also be stored in this object.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    \&quot;identity\&quot;:&lt;br&gt;    {&lt;br&gt;        \&quot;id\&quot;:&lt;id&gt;,&lt;br&gt;        \&quot;name\&quot;:string,&lt;br&gt;        \&quot;description\&quot;:&lt;string&gt;&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;Note:  The \&quot;name\&quot; and \&quot;description\&quot; fields should generally be treated as user-mutable, display only – so don&#39;t write any code to make any decisions based on a string value in \&quot;name or description\&quot;!  For example, don&#39;t look for an output named \&quot;true\&quot; on a ConditionalIf action, because it could be localized to another language, or the user may have changed it to \&quot;yes\&quot;, \&quot;on\&quot;, etc.&lt;br&gt;The \&quot;designer\&quot; Field&lt;br&gt;&lt;br&gt;Any designer-specific information shall be isolated into an object under a \&quot;designer\&quot; field.  This is a well-known field name, and is intended to better faciliate the creation of a streamlined, compiled version of the process definition, etc. should the server decide that it wants to do so.  It is assumed that anything within an object used as the value for a \&quot;designer\&quot; field is not needed at runtime by the server or by clients.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    \&quot;designer\&quot;:&lt;br&gt;    {&lt;br&gt;        ...,&lt;br&gt;        \&quot;notes\&quot;: &lt;string&gt;,&lt;br&gt;        ...&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;&lt;br&gt;A \&quot;designer\&quot; field can occur at many levels within the JSON, and can always be ignored by the server.  As an example of something that may be added to a designer field, consider the Connections between an Action&#39;s Output an the next Action.  The server needs to know what the connection is (i.e. Action&#39;s Output points to another Action), but does not need how the connection looks when \&quot;drawn\&quot; by the user (i.e. goes up, right, down, right, etc.)&lt;br&gt;&lt;br&gt;The sample JSON above shows a \&quot;notes\&quot; field in object used as the value for the \&quot;designer\&quot; field.  The \&quot;identity\&quot; section mentioned previously had \&quot;name\&quot; and \&quot;description\&quot; fields.  The idea of adding \&quot;notes\&quot; into the designer field is to allow people designing the process to add very verbose notes about design decisions, etc.  That differs from the identity.descripion, which is intended to be more of a an end-user viewable description, such as a description that assists the user to select the correct Process Definition to launch.&lt;br&gt;The \&quot;config\&quot; Field&lt;br&gt;&lt;br&gt;Many of the objects may have a \&quot;config\&quot; field.  The contents of this field will generally be specific to the object.  This is were details about Action configuration, Variables configuration, etc. will be located.&lt;br&gt;The \&quot;definitions\&quot; field and Definition Lists&lt;br&gt;&lt;br&gt;Many of the JSON definition objects will themselves also contain definition lists.  For example the Process Definition objects will have a Data Type Definitions list, Variable Definitions list, Sequence Definitions list, End Process Reasons List,. etc.  The Sequence Definition will have an Action Definitions List, Connection Definitions List, Exit Reasons Definitions List, etc. &lt;br&gt;&lt;br&gt;When an object definition itself needs to include one or more definition lists, the object shall have a \&quot;definitions\&quot; field, and the value of that field is an object where the field names are the names of the definition lists.  Additionally, each of those field names that contains a single definition list will generally end with \&quot;Def\&quot;, and every object definition within a definition list will have an \&quot;identity\&quot; field.  If the objects with a specific definition list have identity.name fields, then each of those identity.name fields shall be unique among all of the objects within that same definition list!&lt;br&gt;// This is a definition object.  Generally speaking, definition lists will exist within some other definition object.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    ...,&lt;br&gt; &lt;br&gt;    // This field contains all of the definition lists,if any&lt;br&gt;    \&quot;definitions\&quot;:&lt;br&gt;    {&lt;br&gt;        // This is the definition list for abcDef objects&lt;br&gt;        \&quot;abcDefs\&quot;:&lt;br&gt;        [&lt;br&gt;            // Each abcDef object has an identity.id&lt;br&gt;            {&lt;br&gt;                \&quot;identity\&quot;:&lt;br&gt;                {&lt;br&gt;                    \&quot;id\&quot;:&lt;id&gt;,&lt;br&gt;                    \&quot;name\&quot;:&lt;string&gt;,&lt;br&gt;                }&lt;br&gt;            },&lt;br&gt; &lt;br&gt;            // There can be any number of definition objects within this definition list,&lt;br&gt;            // but each of them must have a different value for identity.name.&lt;br&gt;            ...&lt;br&gt;        ],&lt;br&gt; &lt;br&gt;        // This is the definition list of xyzDef objects&lt;br&gt;        \&quot;xyzDefs\&quot;:&lt;br&gt;        [&lt;br&gt;            // Each xyzDef object has an identity.id&lt;br&gt;            {&lt;br&gt;                \&quot;identity\&quot;:&lt;br&gt;                {&lt;br&gt;                    \&quot;id\&quot;:&lt;id&gt;,&lt;br&gt; &lt;br&gt;                    // The value of this identity.name field could be the same as a definition&lt;br&gt;                    // object within the \&quot;abcDefs\&quot; definition list above because the definition&lt;br&gt;                    // objects exist within different definition lists.&lt;br&gt;                    \&quot;name\&quot;:&lt;string&gt;&lt;br&gt;                }&lt;br&gt;            },&lt;br&gt;            ...&lt;br&gt;        ]&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    ...,&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;No Back-Pointers&lt;br&gt;&lt;br&gt;Generally speaking, the JSON should stay away from back-pointers.  A back-pointer is a reference back to the parent object definition that has the definitions list that contains the object doing the back-pointing.  For example, a StateSequenceDefinition exists within the ProcessDefinition.definitions.stateSequenceDefs list:&lt;br&gt;&lt;br&gt;    Process Definition&lt;br&gt;        definitions&lt;br&gt;            stateSequenceDefs&lt;br&gt;                StateSequenceDefinition&lt;br&gt;&lt;br&gt; &lt;br&gt;&lt;br&gt;In the example above, the JSON for the StateSeqenceDefinition should not point back to the stateSequenceDefs definitions list, or to the definitions field that contains that definitions list, or the Process Definition that contains that definitions field.  There is no need for such back-pointers because the relationship is already implied by the structure of the JSON.  With that said, however, it is likely that applications may find it useful to create such back-pointers in memory for the purpose of navigating through and manipulating the object graph; they just don&#39;t need to serialize it into the JSON.&lt;br&gt;Object Definition Template&lt;br&gt;&lt;br&gt;Given the guidelines above, the following is kind of a template for all JSON object definitions.  For any specific definition, however, some of the sections or fields within those sections may not apply.&lt;br&gt;&lt;pre&gt;{&lt;br&gt;    \&quot;_meta\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    \&quot;identity\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    // Keep in mind that the \&quot;designer\&quot; fields can really exist anywhere,&lt;br&gt;    // not just at the top of a definition.&lt;br&gt;    \&quot;designer\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    \&quot;config\&quot;:&lt;br&gt;    {&lt;br&gt;    },&lt;br&gt; &lt;br&gt;    \&quot;definitions\&quot;:&lt;br&gt;    {&lt;br&gt;    }&lt;br&gt;}&lt;/pre&gt;&lt;br&gt;
        /// </summary>
        /// <param name="id">Flow ID</param>
        /// <param name="keepDraft">Keep flow draft</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (FlowVersionConfigMetaData)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowVersionConfigMetaData>> ProcessautomationFlowsDefinitionsIdVersionsPostAsyncWithHttpInfo (string id, bool? keepDraft = null, string expand = null, FlowVersionConfigMetaData body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsDefinitionsIdVersionsPost");
            
    
            var path_ = "/api/v1/processautomation/flows/definitions/{id}/versions";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (keepDraft != null) queryParams.Add("keepDraft", Configuration.ApiClient.ParameterToString(keepDraft)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdVersionsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdVersionsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FlowVersionConfigMetaData>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowVersionConfigMetaData) Configuration.ApiClient.Deserialize(response, typeof(FlowVersionConfigMetaData)));
            
        }
        
        /// <summary>
        /// Get the meta-data about a versioned flow This will get the meta-data about a particular version of a flow.&lt;br&gt;Also, if you specify a query parameter of  &#39;wantDownloadUri=true&#39;, the service will return to you an Uri of a location where you can download the flow  definition content.
        /// </summary>
        /// <param name="id">Flow ID</param> 
        /// <param name="version">Flow Version</param> 
        /// <param name="wantDownloadUri">True if you want an Uri to download the flow definition content.</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <returns>FlowVersionConfigMetaData</returns>
        public FlowVersionConfigMetaData ProcessautomationFlowsDefinitionsIdVersionsVersionGet (string id, string version, bool? wantDownloadUri = null, string expand = null)
        {
             ApiResponse<FlowVersionConfigMetaData> response = ProcessautomationFlowsDefinitionsIdVersionsVersionGetWithHttpInfo(id, version, wantDownloadUri, expand);
             return response.Data;
        }

        /// <summary>
        /// Get the meta-data about a versioned flow This will get the meta-data about a particular version of a flow.&lt;br&gt;Also, if you specify a query parameter of  &#39;wantDownloadUri=true&#39;, the service will return to you an Uri of a location where you can download the flow  definition content.
        /// </summary>
        /// <param name="id">Flow ID</param> 
        /// <param name="version">Flow Version</param> 
        /// <param name="wantDownloadUri">True if you want an Uri to download the flow definition content.</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <returns>ApiResponse of FlowVersionConfigMetaData</returns>
        public ApiResponse< FlowVersionConfigMetaData > ProcessautomationFlowsDefinitionsIdVersionsVersionGetWithHttpInfo (string id, string version, bool? wantDownloadUri = null, string expand = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsDefinitionsIdVersionsVersionGet");
            
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling ProcessautomationFlowsDefinitionsIdVersionsVersionGet");
            
    
            var path_ = "/api/v1/processautomation/flows/definitions/{id}/versions/{version}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (version != null) pathParams.Add("version", Configuration.ApiClient.ParameterToString(version)); // path parameter
            
            if (wantDownloadUri != null) queryParams.Add("wantDownloadUri", Configuration.ApiClient.ParameterToString(wantDownloadUri)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdVersionsVersionGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdVersionsVersionGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FlowVersionConfigMetaData>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowVersionConfigMetaData) Configuration.ApiClient.Deserialize(response, typeof(FlowVersionConfigMetaData)));
            
        }
    
        /// <summary>
        /// Get the meta-data about a versioned flow This will get the meta-data about a particular version of a flow.&lt;br&gt;Also, if you specify a query parameter of  &#39;wantDownloadUri=true&#39;, the service will return to you an Uri of a location where you can download the flow  definition content.
        /// </summary>
        /// <param name="id">Flow ID</param>
        /// <param name="version">Flow Version</param>
        /// <param name="wantDownloadUri">True if you want an Uri to download the flow definition content.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of FlowVersionConfigMetaData</returns>
        public async System.Threading.Tasks.Task<FlowVersionConfigMetaData> ProcessautomationFlowsDefinitionsIdVersionsVersionGetAsync (string id, string version, bool? wantDownloadUri = null, string expand = null)
        {
             ApiResponse<FlowVersionConfigMetaData> response = await ProcessautomationFlowsDefinitionsIdVersionsVersionGetAsyncWithHttpInfo(id, version, wantDownloadUri, expand);
             return response.Data;

        }

        /// <summary>
        /// Get the meta-data about a versioned flow This will get the meta-data about a particular version of a flow.&lt;br&gt;Also, if you specify a query parameter of  &#39;wantDownloadUri=true&#39;, the service will return to you an Uri of a location where you can download the flow  definition content.
        /// </summary>
        /// <param name="id">Flow ID</param>
        /// <param name="version">Flow Version</param>
        /// <param name="wantDownloadUri">True if you want an Uri to download the flow definition content.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of ApiResponse (FlowVersionConfigMetaData)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowVersionConfigMetaData>> ProcessautomationFlowsDefinitionsIdVersionsVersionGetAsyncWithHttpInfo (string id, string version, bool? wantDownloadUri = null, string expand = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsDefinitionsIdVersionsVersionGet");
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling ProcessautomationFlowsDefinitionsIdVersionsVersionGet");
            
    
            var path_ = "/api/v1/processautomation/flows/definitions/{id}/versions/{version}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (version != null) pathParams.Add("version", Configuration.ApiClient.ParameterToString(version)); // path parameter
            
            if (wantDownloadUri != null) queryParams.Add("wantDownloadUri", Configuration.ApiClient.ParameterToString(wantDownloadUri)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdVersionsVersionGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdVersionsVersionGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FlowVersionConfigMetaData>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowVersionConfigMetaData) Configuration.ApiClient.Deserialize(response, typeof(FlowVersionConfigMetaData)));
            
        }
        
        /// <summary>
        /// publish a minor version of a flow to a major version Minor versions are not \&quot;seen\&quot; by regular agents, they&#39;re only seen by the Designer for intermediate work. &lt;br&gt;When a flow is considered suitable for general use, it gets promoted to a major version with this API, which then makes it visible to regular agents for use. &lt;br&gt;Note that there is no \&quot;unpublish\&quot; action, if you find there&#39;s a problem with your flow then you can either mark is as inactive (so nobody can launch that flow) or re-publish a prior version that you have from some export over the top of the one you don&#39;t like.
        /// </summary>
        /// <param name="id">Flow ID</param> 
        /// <param name="version">Flow Version</param> 
        /// <returns>FlowPublish</returns>
        public FlowPublish ProcessautomationFlowsDefinitionsIdVersionsVersionCommandsPublishPost (string id, string version)
        {
             ApiResponse<FlowPublish> response = ProcessautomationFlowsDefinitionsIdVersionsVersionCommandsPublishPostWithHttpInfo(id, version);
             return response.Data;
        }

        /// <summary>
        /// publish a minor version of a flow to a major version Minor versions are not \&quot;seen\&quot; by regular agents, they&#39;re only seen by the Designer for intermediate work. &lt;br&gt;When a flow is considered suitable for general use, it gets promoted to a major version with this API, which then makes it visible to regular agents for use. &lt;br&gt;Note that there is no \&quot;unpublish\&quot; action, if you find there&#39;s a problem with your flow then you can either mark is as inactive (so nobody can launch that flow) or re-publish a prior version that you have from some export over the top of the one you don&#39;t like.
        /// </summary>
        /// <param name="id">Flow ID</param> 
        /// <param name="version">Flow Version</param> 
        /// <returns>ApiResponse of FlowPublish</returns>
        public ApiResponse< FlowPublish > ProcessautomationFlowsDefinitionsIdVersionsVersionCommandsPublishPostWithHttpInfo (string id, string version)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsDefinitionsIdVersionsVersionCommandsPublishPost");
            
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling ProcessautomationFlowsDefinitionsIdVersionsVersionCommandsPublishPost");
            
    
            var path_ = "/api/v1/processautomation/flows/definitions/{id}/versions/{version}/commands/publish";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (version != null) pathParams.Add("version", Configuration.ApiClient.ParameterToString(version)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdVersionsVersionCommandsPublishPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdVersionsVersionCommandsPublishPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FlowPublish>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowPublish) Configuration.ApiClient.Deserialize(response, typeof(FlowPublish)));
            
        }
    
        /// <summary>
        /// publish a minor version of a flow to a major version Minor versions are not \&quot;seen\&quot; by regular agents, they&#39;re only seen by the Designer for intermediate work. &lt;br&gt;When a flow is considered suitable for general use, it gets promoted to a major version with this API, which then makes it visible to regular agents for use. &lt;br&gt;Note that there is no \&quot;unpublish\&quot; action, if you find there&#39;s a problem with your flow then you can either mark is as inactive (so nobody can launch that flow) or re-publish a prior version that you have from some export over the top of the one you don&#39;t like.
        /// </summary>
        /// <param name="id">Flow ID</param>
        /// <param name="version">Flow Version</param>
        /// <returns>Task of FlowPublish</returns>
        public async System.Threading.Tasks.Task<FlowPublish> ProcessautomationFlowsDefinitionsIdVersionsVersionCommandsPublishPostAsync (string id, string version)
        {
             ApiResponse<FlowPublish> response = await ProcessautomationFlowsDefinitionsIdVersionsVersionCommandsPublishPostAsyncWithHttpInfo(id, version);
             return response.Data;

        }

        /// <summary>
        /// publish a minor version of a flow to a major version Minor versions are not \&quot;seen\&quot; by regular agents, they&#39;re only seen by the Designer for intermediate work. &lt;br&gt;When a flow is considered suitable for general use, it gets promoted to a major version with this API, which then makes it visible to regular agents for use. &lt;br&gt;Note that there is no \&quot;unpublish\&quot; action, if you find there&#39;s a problem with your flow then you can either mark is as inactive (so nobody can launch that flow) or re-publish a prior version that you have from some export over the top of the one you don&#39;t like.
        /// </summary>
        /// <param name="id">Flow ID</param>
        /// <param name="version">Flow Version</param>
        /// <returns>Task of ApiResponse (FlowPublish)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowPublish>> ProcessautomationFlowsDefinitionsIdVersionsVersionCommandsPublishPostAsyncWithHttpInfo (string id, string version)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsDefinitionsIdVersionsVersionCommandsPublishPost");
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling ProcessautomationFlowsDefinitionsIdVersionsVersionCommandsPublishPost");
            
    
            var path_ = "/api/v1/processautomation/flows/definitions/{id}/versions/{version}/commands/publish";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (version != null) pathParams.Add("version", Configuration.ApiClient.ParameterToString(version)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdVersionsVersionCommandsPublishPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsDefinitionsIdVersionsVersionCommandsPublishPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FlowPublish>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowPublish) Configuration.ApiClient.Deserialize(response, typeof(FlowPublish)));
            
        }
        
        /// <summary>
        /// Launches a flow Launches the most recently published version of the flow.  Accepts a FlowLaunch data object as a payload.
        /// </summary>
        /// <param name="flowLaunch"></param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <returns>FlowDetails</returns>
        public FlowDetails ProcessautomationFlowsInstancesPost (FlowLaunchRequest flowLaunch, string expand = null)
        {
             ApiResponse<FlowDetails> response = ProcessautomationFlowsInstancesPostWithHttpInfo(flowLaunch, expand);
             return response.Data;
        }

        /// <summary>
        /// Launches a flow Launches the most recently published version of the flow.  Accepts a FlowLaunch data object as a payload.
        /// </summary>
        /// <param name="flowLaunch"></param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <returns>ApiResponse of FlowDetails</returns>
        public ApiResponse< FlowDetails > ProcessautomationFlowsInstancesPostWithHttpInfo (FlowLaunchRequest flowLaunch, string expand = null)
        {
            
            // verify the required parameter 'flowLaunch' is set
            if (flowLaunch == null) throw new ApiException(400, "Missing required parameter 'flowLaunch' when calling ProcessautomationFlowsInstancesPost");
            
    
            var path_ = "/api/v1/processautomation/flows/instances";
    
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
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(flowLaunch); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsInstancesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsInstancesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FlowDetails>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowDetails) Configuration.ApiClient.Deserialize(response, typeof(FlowDetails)));
            
        }
    
        /// <summary>
        /// Launches a flow Launches the most recently published version of the flow.  Accepts a FlowLaunch data object as a payload.
        /// </summary>
        /// <param name="flowLaunch"></param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of FlowDetails</returns>
        public async System.Threading.Tasks.Task<FlowDetails> ProcessautomationFlowsInstancesPostAsync (FlowLaunchRequest flowLaunch, string expand = null)
        {
             ApiResponse<FlowDetails> response = await ProcessautomationFlowsInstancesPostAsyncWithHttpInfo(flowLaunch, expand);
             return response.Data;

        }

        /// <summary>
        /// Launches a flow Launches the most recently published version of the flow.  Accepts a FlowLaunch data object as a payload.
        /// </summary>
        /// <param name="flowLaunch"></param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of ApiResponse (FlowDetails)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowDetails>> ProcessautomationFlowsInstancesPostAsyncWithHttpInfo (FlowLaunchRequest flowLaunch, string expand = null)
        {
            // verify the required parameter 'flowLaunch' is set
            if (flowLaunch == null) throw new ApiException(400, "Missing required parameter 'flowLaunch' when calling ProcessautomationFlowsInstancesPost");
            
    
            var path_ = "/api/v1/processautomation/flows/instances";
    
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
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(flowLaunch); // http body (model) parameter
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsInstancesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsInstancesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FlowDetails>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowDetails) Configuration.ApiClient.Deserialize(response, typeof(FlowDetails)));
            
        }
        
        /// <summary>
        /// Search the currently running flow instances Searches the pool of running flow instances given a SearchRequest object and returns the matching results. Some Search Examples:&lt;br&gt;Note the various filters, sort and searchPhrase options can be combined/omitted as needed.&lt;br&gt;Search for a specific definition id:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowConfigId.id\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;e88db9fb-aaa0-46f8-81d5-4a30e323bdfa\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;&lt;br&gt;Search for a specific execution instance and sort on the config name:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowExecId\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;99\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;],&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sort\&quot; : [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;:\&quot;flowConfigName\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sortType\&quot;:\&quot;ASCENDING\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;Search for a specific phrase:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;searchPhrase\&quot; : \&quot;hi mom!\&quot; &lt;br&gt;}&lt;br&gt;
        /// </summary>
        /// <param name="body">SearchRequest data containing search parameters and paging response.</param> 
        /// <returns>FlowDetailsSearchResult</returns>
        public FlowDetailsSearchResult ProcessautomationFlowsInstancesCommandsSearchPost (SearchRequest body)
        {
             ApiResponse<FlowDetailsSearchResult> response = ProcessautomationFlowsInstancesCommandsSearchPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Search the currently running flow instances Searches the pool of running flow instances given a SearchRequest object and returns the matching results. Some Search Examples:&lt;br&gt;Note the various filters, sort and searchPhrase options can be combined/omitted as needed.&lt;br&gt;Search for a specific definition id:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowConfigId.id\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;e88db9fb-aaa0-46f8-81d5-4a30e323bdfa\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;&lt;br&gt;Search for a specific execution instance and sort on the config name:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowExecId\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;99\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;],&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sort\&quot; : [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;:\&quot;flowConfigName\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sortType\&quot;:\&quot;ASCENDING\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;Search for a specific phrase:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;searchPhrase\&quot; : \&quot;hi mom!\&quot; &lt;br&gt;}&lt;br&gt;
        /// </summary>
        /// <param name="body">SearchRequest data containing search parameters and paging response.</param> 
        /// <returns>ApiResponse of FlowDetailsSearchResult</returns>
        public ApiResponse< FlowDetailsSearchResult > ProcessautomationFlowsInstancesCommandsSearchPostWithHttpInfo (SearchRequest body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ProcessautomationFlowsInstancesCommandsSearchPost");
            
    
            var path_ = "/api/v1/processautomation/flows/instances/commands/search";
    
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsInstancesCommandsSearchPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsInstancesCommandsSearchPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FlowDetailsSearchResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowDetailsSearchResult) Configuration.ApiClient.Deserialize(response, typeof(FlowDetailsSearchResult)));
            
        }
    
        /// <summary>
        /// Search the currently running flow instances Searches the pool of running flow instances given a SearchRequest object and returns the matching results. Some Search Examples:&lt;br&gt;Note the various filters, sort and searchPhrase options can be combined/omitted as needed.&lt;br&gt;Search for a specific definition id:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowConfigId.id\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;e88db9fb-aaa0-46f8-81d5-4a30e323bdfa\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;&lt;br&gt;Search for a specific execution instance and sort on the config name:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowExecId\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;99\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;],&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sort\&quot; : [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;:\&quot;flowConfigName\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sortType\&quot;:\&quot;ASCENDING\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;Search for a specific phrase:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;searchPhrase\&quot; : \&quot;hi mom!\&quot; &lt;br&gt;}&lt;br&gt;
        /// </summary>
        /// <param name="body">SearchRequest data containing search parameters and paging response.</param>
        /// <returns>Task of FlowDetailsSearchResult</returns>
        public async System.Threading.Tasks.Task<FlowDetailsSearchResult> ProcessautomationFlowsInstancesCommandsSearchPostAsync (SearchRequest body)
        {
             ApiResponse<FlowDetailsSearchResult> response = await ProcessautomationFlowsInstancesCommandsSearchPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Search the currently running flow instances Searches the pool of running flow instances given a SearchRequest object and returns the matching results. Some Search Examples:&lt;br&gt;Note the various filters, sort and searchPhrase options can be combined/omitted as needed.&lt;br&gt;Search for a specific definition id:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowConfigId.id\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;e88db9fb-aaa0-46f8-81d5-4a30e323bdfa\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;&lt;br&gt;Search for a specific execution instance and sort on the config name:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowExecId\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;99\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;],&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sort\&quot; : [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;:\&quot;flowConfigName\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sortType\&quot;:\&quot;ASCENDING\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;Search for a specific phrase:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;searchPhrase\&quot; : \&quot;hi mom!\&quot; &lt;br&gt;}&lt;br&gt;
        /// </summary>
        /// <param name="body">SearchRequest data containing search parameters and paging response.</param>
        /// <returns>Task of ApiResponse (FlowDetailsSearchResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowDetailsSearchResult>> ProcessautomationFlowsInstancesCommandsSearchPostAsyncWithHttpInfo (SearchRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ProcessautomationFlowsInstancesCommandsSearchPost");
            
    
            var path_ = "/api/v1/processautomation/flows/instances/commands/search";
    
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsInstancesCommandsSearchPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsInstancesCommandsSearchPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FlowDetailsSearchResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowDetailsSearchResult) Configuration.ApiClient.Deserialize(response, typeof(FlowDetailsSearchResult)));
            
        }
        
        /// <summary>
        /// Get the data for a running flow This will get the information about the current running state of the flow.
        /// </summary>
        /// <param name="id">Flow Exec ID</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <returns>FlowDetails</returns>
        public FlowDetails ProcessautomationFlowsInstancesIdGet (string id, string expand = null)
        {
             ApiResponse<FlowDetails> response = ProcessautomationFlowsInstancesIdGetWithHttpInfo(id, expand);
             return response.Data;
        }

        /// <summary>
        /// Get the data for a running flow This will get the information about the current running state of the flow.
        /// </summary>
        /// <param name="id">Flow Exec ID</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <returns>ApiResponse of FlowDetails</returns>
        public ApiResponse< FlowDetails > ProcessautomationFlowsInstancesIdGetWithHttpInfo (string id, string expand = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsInstancesIdGet");
            
    
            var path_ = "/api/v1/processautomation/flows/instances/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsInstancesIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsInstancesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FlowDetails>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowDetails) Configuration.ApiClient.Deserialize(response, typeof(FlowDetails)));
            
        }
    
        /// <summary>
        /// Get the data for a running flow This will get the information about the current running state of the flow.
        /// </summary>
        /// <param name="id">Flow Exec ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of FlowDetails</returns>
        public async System.Threading.Tasks.Task<FlowDetails> ProcessautomationFlowsInstancesIdGetAsync (string id, string expand = null)
        {
             ApiResponse<FlowDetails> response = await ProcessautomationFlowsInstancesIdGetAsyncWithHttpInfo(id, expand);
             return response.Data;

        }

        /// <summary>
        /// Get the data for a running flow This will get the information about the current running state of the flow.
        /// </summary>
        /// <param name="id">Flow Exec ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of ApiResponse (FlowDetails)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowDetails>> ProcessautomationFlowsInstancesIdGetAsyncWithHttpInfo (string id, string expand = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsInstancesIdGet");
            
    
            var path_ = "/api/v1/processautomation/flows/instances/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsInstancesIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsInstancesIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FlowDetails>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowDetails) Configuration.ApiClient.Deserialize(response, typeof(FlowDetails)));
            
        }
        
        /// <summary>
        /// Retries a flow instance Retries a flow instance
        /// </summary>
        /// <param name="id">Flow Exec ID</param> 
        /// <returns></returns>
        public void ProcessautomationFlowsInstancesIdCommandsRetryPost (string id)
        {
             ProcessautomationFlowsInstancesIdCommandsRetryPostWithHttpInfo(id);
        }

        /// <summary>
        /// Retries a flow instance Retries a flow instance
        /// </summary>
        /// <param name="id">Flow Exec ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ProcessautomationFlowsInstancesIdCommandsRetryPostWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsInstancesIdCommandsRetryPost");
            
    
            var path_ = "/api/v1/processautomation/flows/instances/{id}/commands/retry";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsInstancesIdCommandsRetryPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsInstancesIdCommandsRetryPost: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Retries a flow instance Retries a flow instance
        /// </summary>
        /// <param name="id">Flow Exec ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ProcessautomationFlowsInstancesIdCommandsRetryPostAsync (string id)
        {
             await ProcessautomationFlowsInstancesIdCommandsRetryPostAsyncWithHttpInfo(id);

        }

        /// <summary>
        /// Retries a flow instance Retries a flow instance
        /// </summary>
        /// <param name="id">Flow Exec ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ProcessautomationFlowsInstancesIdCommandsRetryPostAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsInstancesIdCommandsRetryPost");
            
    
            var path_ = "/api/v1/processautomation/flows/instances/{id}/commands/retry";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsInstancesIdCommandsRetryPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsInstancesIdCommandsRetryPost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Terminates a flow instance Terminates a flow instance
        /// </summary>
        /// <param name="id">Flow Exec ID</param> 
        /// <param name="body">terminate options</param> 
        /// <returns></returns>
        public void ProcessautomationFlowsInstancesIdCommandsTerminatePost (string id, FlowTerminateRequest body = null)
        {
             ProcessautomationFlowsInstancesIdCommandsTerminatePostWithHttpInfo(id, body);
        }

        /// <summary>
        /// Terminates a flow instance Terminates a flow instance
        /// </summary>
        /// <param name="id">Flow Exec ID</param> 
        /// <param name="body">terminate options</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ProcessautomationFlowsInstancesIdCommandsTerminatePostWithHttpInfo (string id, FlowTerminateRequest body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsInstancesIdCommandsTerminatePost");
            
    
            var path_ = "/api/v1/processautomation/flows/instances/{id}/commands/terminate";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsInstancesIdCommandsTerminatePost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsInstancesIdCommandsTerminatePost: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Terminates a flow instance Terminates a flow instance
        /// </summary>
        /// <param name="id">Flow Exec ID</param>
        /// <param name="body">terminate options</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ProcessautomationFlowsInstancesIdCommandsTerminatePostAsync (string id, FlowTerminateRequest body = null)
        {
             await ProcessautomationFlowsInstancesIdCommandsTerminatePostAsyncWithHttpInfo(id, body);

        }

        /// <summary>
        /// Terminates a flow instance Terminates a flow instance
        /// </summary>
        /// <param name="id">Flow Exec ID</param>
        /// <param name="body">terminate options</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ProcessautomationFlowsInstancesIdCommandsTerminatePostAsyncWithHttpInfo (string id, FlowTerminateRequest body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsInstancesIdCommandsTerminatePost");
            
    
            var path_ = "/api/v1/processautomation/flows/instances/{id}/commands/terminate";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsInstancesIdCommandsTerminatePost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsInstancesIdCommandsTerminatePost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get the history of a flow instance Get the history of a flow instance
        /// </summary>
        /// <param name="id">Flow Exec ID</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <returns>FlowHistoryResultItem</returns>
        public FlowHistoryResultItem ProcessautomationFlowsInstancesIdHistoryGet (string id, string expand = null)
        {
             ApiResponse<FlowHistoryResultItem> response = ProcessautomationFlowsInstancesIdHistoryGetWithHttpInfo(id, expand);
             return response.Data;
        }

        /// <summary>
        /// Get the history of a flow instance Get the history of a flow instance
        /// </summary>
        /// <param name="id">Flow Exec ID</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <returns>ApiResponse of FlowHistoryResultItem</returns>
        public ApiResponse< FlowHistoryResultItem > ProcessautomationFlowsInstancesIdHistoryGetWithHttpInfo (string id, string expand = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsInstancesIdHistoryGet");
            
    
            var path_ = "/api/v1/processautomation/flows/instances/{id}/history";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsInstancesIdHistoryGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsInstancesIdHistoryGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FlowHistoryResultItem>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowHistoryResultItem) Configuration.ApiClient.Deserialize(response, typeof(FlowHistoryResultItem)));
            
        }
    
        /// <summary>
        /// Get the history of a flow instance Get the history of a flow instance
        /// </summary>
        /// <param name="id">Flow Exec ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of FlowHistoryResultItem</returns>
        public async System.Threading.Tasks.Task<FlowHistoryResultItem> ProcessautomationFlowsInstancesIdHistoryGetAsync (string id, string expand = null)
        {
             ApiResponse<FlowHistoryResultItem> response = await ProcessautomationFlowsInstancesIdHistoryGetAsyncWithHttpInfo(id, expand);
             return response.Data;

        }

        /// <summary>
        /// Get the history of a flow instance Get the history of a flow instance
        /// </summary>
        /// <param name="id">Flow Exec ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of ApiResponse (FlowHistoryResultItem)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowHistoryResultItem>> ProcessautomationFlowsInstancesIdHistoryGetAsyncWithHttpInfo (string id, string expand = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationFlowsInstancesIdHistoryGet");
            
    
            var path_ = "/api/v1/processautomation/flows/instances/{id}/history";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsInstancesIdHistoryGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationFlowsInstancesIdHistoryGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FlowHistoryResultItem>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowHistoryResultItem) Configuration.ApiClient.Deserialize(response, typeof(FlowHistoryResultItem)));
            
        }
        
        /// <summary>
        /// Get all queues for an organization This method will get all the queues defined in your organization.
        /// </summary>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param> 
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <param name="name">Search phrase to match on the queue&#39;s name.</param> 
        /// <returns>QueuesEntityListing</returns>
        public QueuesEntityListing ProcessautomationQueuesGet (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null)
        {
             ApiResponse<QueuesEntityListing> response = ProcessautomationQueuesGetWithHttpInfo(pageSize, pageNumber, expand, name);
             return response.Data;
        }

        /// <summary>
        /// Get all queues for an organization This method will get all the queues defined in your organization.
        /// </summary>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param> 
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <param name="name">Search phrase to match on the queue&#39;s name.</param> 
        /// <returns>ApiResponse of QueuesEntityListing</returns>
        public ApiResponse< QueuesEntityListing > ProcessautomationQueuesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null)
        {
            
    
            var path_ = "/api/v1/processautomation/queues";
    
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
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<QueuesEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueuesEntityListing) Configuration.ApiClient.Deserialize(response, typeof(QueuesEntityListing)));
            
        }
    
        /// <summary>
        /// Get all queues for an organization This method will get all the queues defined in your organization.
        /// </summary>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="name">Search phrase to match on the queue&#39;s name.</param>
        /// <returns>Task of QueuesEntityListing</returns>
        public async System.Threading.Tasks.Task<QueuesEntityListing> ProcessautomationQueuesGetAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null)
        {
             ApiResponse<QueuesEntityListing> response = await ProcessautomationQueuesGetAsyncWithHttpInfo(pageSize, pageNumber, expand, name);
             return response.Data;

        }

        /// <summary>
        /// Get all queues for an organization This method will get all the queues defined in your organization.
        /// </summary>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="name">Search phrase to match on the queue&#39;s name.</param>
        /// <returns>Task of ApiResponse (QueuesEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueuesEntityListing>> ProcessautomationQueuesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null)
        {
            
    
            var path_ = "/api/v1/processautomation/queues";
    
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
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<QueuesEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueuesEntityListing) Configuration.ApiClient.Deserialize(response, typeof(QueuesEntityListing)));
            
        }
        
        /// <summary>
        /// Create a new queue object This method will create a new queue and assign it a new id.
        /// </summary>
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <param name="body"></param> 
        /// <returns>AutomateQueue</returns>
        public AutomateQueue ProcessautomationQueuesPost (string expand = null, AutomateQueue body = null)
        {
             ApiResponse<AutomateQueue> response = ProcessautomationQueuesPostWithHttpInfo(expand, body);
             return response.Data;
        }

        /// <summary>
        /// Create a new queue object This method will create a new queue and assign it a new id.
        /// </summary>
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of AutomateQueue</returns>
        public ApiResponse< AutomateQueue > ProcessautomationQueuesPostWithHttpInfo (string expand = null, AutomateQueue body = null)
        {
            
    
            var path_ = "/api/v1/processautomation/queues";
    
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
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<AutomateQueue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AutomateQueue) Configuration.ApiClient.Deserialize(response, typeof(AutomateQueue)));
            
        }
    
        /// <summary>
        /// Create a new queue object This method will create a new queue and assign it a new id.
        /// </summary>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body"></param>
        /// <returns>Task of AutomateQueue</returns>
        public async System.Threading.Tasks.Task<AutomateQueue> ProcessautomationQueuesPostAsync (string expand = null, AutomateQueue body = null)
        {
             ApiResponse<AutomateQueue> response = await ProcessautomationQueuesPostAsyncWithHttpInfo(expand, body);
             return response.Data;

        }

        /// <summary>
        /// Create a new queue object This method will create a new queue and assign it a new id.
        /// </summary>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (AutomateQueue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AutomateQueue>> ProcessautomationQueuesPostAsyncWithHttpInfo (string expand = null, AutomateQueue body = null)
        {
            
    
            var path_ = "/api/v1/processautomation/queues";
    
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
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AutomateQueue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AutomateQueue) Configuration.ApiClient.Deserialize(response, typeof(AutomateQueue)));
            
        }
        
        /// <summary>
        /// Get details about this queue This returns details about the queue like the name and description.
        /// </summary>
        /// <param name="id">ID</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <returns>AutomateQueue</returns>
        public AutomateQueue ProcessautomationQueuesIdGet (string id, string expand = null)
        {
             ApiResponse<AutomateQueue> response = ProcessautomationQueuesIdGetWithHttpInfo(id, expand);
             return response.Data;
        }

        /// <summary>
        /// Get details about this queue This returns details about the queue like the name and description.
        /// </summary>
        /// <param name="id">ID</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <returns>ApiResponse of AutomateQueue</returns>
        public ApiResponse< AutomateQueue > ProcessautomationQueuesIdGetWithHttpInfo (string id, string expand = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationQueuesIdGet");
            
    
            var path_ = "/api/v1/processautomation/queues/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<AutomateQueue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AutomateQueue) Configuration.ApiClient.Deserialize(response, typeof(AutomateQueue)));
            
        }
    
        /// <summary>
        /// Get details about this queue This returns details about the queue like the name and description.
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of AutomateQueue</returns>
        public async System.Threading.Tasks.Task<AutomateQueue> ProcessautomationQueuesIdGetAsync (string id, string expand = null)
        {
             ApiResponse<AutomateQueue> response = await ProcessautomationQueuesIdGetAsyncWithHttpInfo(id, expand);
             return response.Data;

        }

        /// <summary>
        /// Get details about this queue This returns details about the queue like the name and description.
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of ApiResponse (AutomateQueue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AutomateQueue>> ProcessautomationQueuesIdGetAsyncWithHttpInfo (string id, string expand = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationQueuesIdGet");
            
    
            var path_ = "/api/v1/processautomation/queues/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AutomateQueue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AutomateQueue) Configuration.ApiClient.Deserialize(response, typeof(AutomateQueue)));
            
        }
        
        /// <summary>
        /// Update a queue Update the name and description of a queue.
        /// </summary>
        /// <param name="id">ID</param> 
        /// <param name="body">updated queue</param> 
        /// <returns>AutomateQueue</returns>
        public AutomateQueue ProcessautomationQueuesIdPut (string id, AutomateQueue body = null)
        {
             ApiResponse<AutomateQueue> response = ProcessautomationQueuesIdPutWithHttpInfo(id, body);
             return response.Data;
        }

        /// <summary>
        /// Update a queue Update the name and description of a queue.
        /// </summary>
        /// <param name="id">ID</param> 
        /// <param name="body">updated queue</param> 
        /// <returns>ApiResponse of AutomateQueue</returns>
        public ApiResponse< AutomateQueue > ProcessautomationQueuesIdPutWithHttpInfo (string id, AutomateQueue body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationQueuesIdPut");
            
    
            var path_ = "/api/v1/processautomation/queues/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<AutomateQueue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AutomateQueue) Configuration.ApiClient.Deserialize(response, typeof(AutomateQueue)));
            
        }
    
        /// <summary>
        /// Update a queue Update the name and description of a queue.
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="body">updated queue</param>
        /// <returns>Task of AutomateQueue</returns>
        public async System.Threading.Tasks.Task<AutomateQueue> ProcessautomationQueuesIdPutAsync (string id, AutomateQueue body = null)
        {
             ApiResponse<AutomateQueue> response = await ProcessautomationQueuesIdPutAsyncWithHttpInfo(id, body);
             return response.Data;

        }

        /// <summary>
        /// Update a queue Update the name and description of a queue.
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="body">updated queue</param>
        /// <returns>Task of ApiResponse (AutomateQueue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AutomateQueue>> ProcessautomationQueuesIdPutAsyncWithHttpInfo (string id, AutomateQueue body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationQueuesIdPut");
            
    
            var path_ = "/api/v1/processautomation/queues/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AutomateQueue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AutomateQueue) Configuration.ApiClient.Deserialize(response, typeof(AutomateQueue)));
            
        }
        
        /// <summary>
        /// Delete a queue Removes a queue for an organization.
        /// </summary>
        /// <param name="id">ID</param> 
        /// <returns></returns>
        public void ProcessautomationQueuesIdDelete (string id)
        {
             ProcessautomationQueuesIdDeleteWithHttpInfo(id);
        }

        /// <summary>
        /// Delete a queue Removes a queue for an organization.
        /// </summary>
        /// <param name="id">ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ProcessautomationQueuesIdDeleteWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationQueuesIdDelete");
            
    
            var path_ = "/api/v1/processautomation/queues/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete a queue Removes a queue for an organization.
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ProcessautomationQueuesIdDeleteAsync (string id)
        {
             await ProcessautomationQueuesIdDeleteAsyncWithHttpInfo(id);

        }

        /// <summary>
        /// Delete a queue Removes a queue for an organization.
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ProcessautomationQueuesIdDeleteAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationQueuesIdDelete");
            
    
            var path_ = "/api/v1/processautomation/queues/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdDelete: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get members in a queue Get the list of members in a queue.
        /// </summary>
        /// <param name="id">Queue ID</param> 
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param> 
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <param name="name">Search phrase to match on the queue member&#39;s name.</param> 
        /// <returns>QueueMemberEntityListing</returns>
        public QueueMemberEntityListing ProcessautomationQueuesIdMembersGet (string id, int? pageSize = null, int? pageNumber = null, string expand = null, string name = null)
        {
             ApiResponse<QueueMemberEntityListing> response = ProcessautomationQueuesIdMembersGetWithHttpInfo(id, pageSize, pageNumber, expand, name);
             return response.Data;
        }

        /// <summary>
        /// Get members in a queue Get the list of members in a queue.
        /// </summary>
        /// <param name="id">Queue ID</param> 
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param> 
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <param name="name">Search phrase to match on the queue member&#39;s name.</param> 
        /// <returns>ApiResponse of QueueMemberEntityListing</returns>
        public ApiResponse< QueueMemberEntityListing > ProcessautomationQueuesIdMembersGetWithHttpInfo (string id, int? pageSize = null, int? pageNumber = null, string expand = null, string name = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationQueuesIdMembersGet");
            
    
            var path_ = "/api/v1/processautomation/queues/{id}/members";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdMembersGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdMembersGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<QueueMemberEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMemberEntityListing) Configuration.ApiClient.Deserialize(response, typeof(QueueMemberEntityListing)));
            
        }
    
        /// <summary>
        /// Get members in a queue Get the list of members in a queue.
        /// </summary>
        /// <param name="id">Queue ID</param>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="name">Search phrase to match on the queue member&#39;s name.</param>
        /// <returns>Task of QueueMemberEntityListing</returns>
        public async System.Threading.Tasks.Task<QueueMemberEntityListing> ProcessautomationQueuesIdMembersGetAsync (string id, int? pageSize = null, int? pageNumber = null, string expand = null, string name = null)
        {
             ApiResponse<QueueMemberEntityListing> response = await ProcessautomationQueuesIdMembersGetAsyncWithHttpInfo(id, pageSize, pageNumber, expand, name);
             return response.Data;

        }

        /// <summary>
        /// Get members in a queue Get the list of members in a queue.
        /// </summary>
        /// <param name="id">Queue ID</param>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="name">Search phrase to match on the queue member&#39;s name.</param>
        /// <returns>Task of ApiResponse (QueueMemberEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueueMemberEntityListing>> ProcessautomationQueuesIdMembersGetAsyncWithHttpInfo (string id, int? pageSize = null, int? pageNumber = null, string expand = null, string name = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationQueuesIdMembersGet");
            
    
            var path_ = "/api/v1/processautomation/queues/{id}/members";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdMembersGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdMembersGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<QueueMemberEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMemberEntityListing) Configuration.ApiClient.Deserialize(response, typeof(QueueMemberEntityListing)));
            
        }
        
        /// <summary>
        /// Edit the members in a queue Updates the members of the specified queue from the given list.
        /// </summary>
        /// <param name="id">Queue ID</param> 
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param> 
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <param name="body">Queue Member List</param> 
        /// <returns>QueueMemberEntityListing</returns>
        public QueueMemberEntityListing ProcessautomationQueuesIdMembersPut (string id, int? pageSize = null, int? pageNumber = null, string expand = null, List<AutomateQueueMember> body = null)
        {
             ApiResponse<QueueMemberEntityListing> response = ProcessautomationQueuesIdMembersPutWithHttpInfo(id, pageSize, pageNumber, expand, body);
             return response.Data;
        }

        /// <summary>
        /// Edit the members in a queue Updates the members of the specified queue from the given list.
        /// </summary>
        /// <param name="id">Queue ID</param> 
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param> 
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <param name="body">Queue Member List</param> 
        /// <returns>ApiResponse of QueueMemberEntityListing</returns>
        public ApiResponse< QueueMemberEntityListing > ProcessautomationQueuesIdMembersPutWithHttpInfo (string id, int? pageSize = null, int? pageNumber = null, string expand = null, List<AutomateQueueMember> body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationQueuesIdMembersPut");
            
    
            var path_ = "/api/v1/processautomation/queues/{id}/members";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdMembersPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdMembersPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<QueueMemberEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMemberEntityListing) Configuration.ApiClient.Deserialize(response, typeof(QueueMemberEntityListing)));
            
        }
    
        /// <summary>
        /// Edit the members in a queue Updates the members of the specified queue from the given list.
        /// </summary>
        /// <param name="id">Queue ID</param>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">Queue Member List</param>
        /// <returns>Task of QueueMemberEntityListing</returns>
        public async System.Threading.Tasks.Task<QueueMemberEntityListing> ProcessautomationQueuesIdMembersPutAsync (string id, int? pageSize = null, int? pageNumber = null, string expand = null, List<AutomateQueueMember> body = null)
        {
             ApiResponse<QueueMemberEntityListing> response = await ProcessautomationQueuesIdMembersPutAsyncWithHttpInfo(id, pageSize, pageNumber, expand, body);
             return response.Data;

        }

        /// <summary>
        /// Edit the members in a queue Updates the members of the specified queue from the given list.
        /// </summary>
        /// <param name="id">Queue ID</param>
        /// <param name="pageSize">The number of entries to return per page, or omitted for the default.</param>
        /// <param name="pageNumber">The page number to return, or omitted for the first page.</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">Queue Member List</param>
        /// <returns>Task of ApiResponse (QueueMemberEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueueMemberEntityListing>> ProcessautomationQueuesIdMembersPutAsyncWithHttpInfo (string id, int? pageSize = null, int? pageNumber = null, string expand = null, List<AutomateQueueMember> body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationQueuesIdMembersPut");
            
    
            var path_ = "/api/v1/processautomation/queues/{id}/members";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdMembersPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdMembersPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<QueueMemberEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMemberEntityListing) Configuration.ApiClient.Deserialize(response, typeof(QueueMemberEntityListing)));
            
        }
        
        /// <summary>
        /// Get a member from a queue This will get the specified member from the queue.
        /// </summary>
        /// <param name="id">Queue ID</param> 
        /// <param name="memberId">Member ID</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <returns>AutomateQueueMember</returns>
        public AutomateQueueMember ProcessautomationQueuesIdMembersMemberidGet (string id, string memberId, string expand = null)
        {
             ApiResponse<AutomateQueueMember> response = ProcessautomationQueuesIdMembersMemberidGetWithHttpInfo(id, memberId, expand);
             return response.Data;
        }

        /// <summary>
        /// Get a member from a queue This will get the specified member from the queue.
        /// </summary>
        /// <param name="id">Queue ID</param> 
        /// <param name="memberId">Member ID</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <returns>ApiResponse of AutomateQueueMember</returns>
        public ApiResponse< AutomateQueueMember > ProcessautomationQueuesIdMembersMemberidGetWithHttpInfo (string id, string memberId, string expand = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationQueuesIdMembersMemberidGet");
            
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling ProcessautomationQueuesIdMembersMemberidGet");
            
    
            var path_ = "/api/v1/processautomation/queues/{id}/members/{memberId}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (memberId != null) pathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdMembersMemberidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdMembersMemberidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<AutomateQueueMember>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AutomateQueueMember) Configuration.ApiClient.Deserialize(response, typeof(AutomateQueueMember)));
            
        }
    
        /// <summary>
        /// Get a member from a queue This will get the specified member from the queue.
        /// </summary>
        /// <param name="id">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of AutomateQueueMember</returns>
        public async System.Threading.Tasks.Task<AutomateQueueMember> ProcessautomationQueuesIdMembersMemberidGetAsync (string id, string memberId, string expand = null)
        {
             ApiResponse<AutomateQueueMember> response = await ProcessautomationQueuesIdMembersMemberidGetAsyncWithHttpInfo(id, memberId, expand);
             return response.Data;

        }

        /// <summary>
        /// Get a member from a queue This will get the specified member from the queue.
        /// </summary>
        /// <param name="id">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of ApiResponse (AutomateQueueMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AutomateQueueMember>> ProcessautomationQueuesIdMembersMemberidGetAsyncWithHttpInfo (string id, string memberId, string expand = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationQueuesIdMembersMemberidGet");
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling ProcessautomationQueuesIdMembersMemberidGet");
            
    
            var path_ = "/api/v1/processautomation/queues/{id}/members/{memberId}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (memberId != null) pathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdMembersMemberidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdMembersMemberidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AutomateQueueMember>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AutomateQueueMember) Configuration.ApiClient.Deserialize(response, typeof(AutomateQueueMember)));
            
        }
        
        /// <summary>
        /// Add a member to a queue This will add the specified member to the given queue.
        /// </summary>
        /// <param name="id">Queue ID</param> 
        /// <param name="memberId">Member ID</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <param name="body">Queue Member</param> 
        /// <returns>AutomateQueueMember</returns>
        public AutomateQueueMember ProcessautomationQueuesIdMembersMemberidPut (string id, string memberId, string expand = null, AutomateQueueMember body = null)
        {
             ApiResponse<AutomateQueueMember> response = ProcessautomationQueuesIdMembersMemberidPutWithHttpInfo(id, memberId, expand, body);
             return response.Data;
        }

        /// <summary>
        /// Add a member to a queue This will add the specified member to the given queue.
        /// </summary>
        /// <param name="id">Queue ID</param> 
        /// <param name="memberId">Member ID</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <param name="body">Queue Member</param> 
        /// <returns>ApiResponse of AutomateQueueMember</returns>
        public ApiResponse< AutomateQueueMember > ProcessautomationQueuesIdMembersMemberidPutWithHttpInfo (string id, string memberId, string expand = null, AutomateQueueMember body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationQueuesIdMembersMemberidPut");
            
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling ProcessautomationQueuesIdMembersMemberidPut");
            
    
            var path_ = "/api/v1/processautomation/queues/{id}/members/{memberId}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (memberId != null) pathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdMembersMemberidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdMembersMemberidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<AutomateQueueMember>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AutomateQueueMember) Configuration.ApiClient.Deserialize(response, typeof(AutomateQueueMember)));
            
        }
    
        /// <summary>
        /// Add a member to a queue This will add the specified member to the given queue.
        /// </summary>
        /// <param name="id">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">Queue Member</param>
        /// <returns>Task of AutomateQueueMember</returns>
        public async System.Threading.Tasks.Task<AutomateQueueMember> ProcessautomationQueuesIdMembersMemberidPutAsync (string id, string memberId, string expand = null, AutomateQueueMember body = null)
        {
             ApiResponse<AutomateQueueMember> response = await ProcessautomationQueuesIdMembersMemberidPutAsyncWithHttpInfo(id, memberId, expand, body);
             return response.Data;

        }

        /// <summary>
        /// Add a member to a queue This will add the specified member to the given queue.
        /// </summary>
        /// <param name="id">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <param name="body">Queue Member</param>
        /// <returns>Task of ApiResponse (AutomateQueueMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AutomateQueueMember>> ProcessautomationQueuesIdMembersMemberidPutAsyncWithHttpInfo (string id, string memberId, string expand = null, AutomateQueueMember body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationQueuesIdMembersMemberidPut");
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling ProcessautomationQueuesIdMembersMemberidPut");
            
    
            var path_ = "/api/v1/processautomation/queues/{id}/members/{memberId}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (memberId != null) pathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdMembersMemberidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdMembersMemberidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AutomateQueueMember>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AutomateQueueMember) Configuration.ApiClient.Deserialize(response, typeof(AutomateQueueMember)));
            
        }
        
        /// <summary>
        /// Delete a member from a queue This will delete the specified member from the given queue.
        /// </summary>
        /// <param name="id">Queue ID</param> 
        /// <param name="memberId">Member ID</param> 
        /// <returns></returns>
        public void ProcessautomationQueuesIdMembersMemberidDelete (string id, string memberId)
        {
             ProcessautomationQueuesIdMembersMemberidDeleteWithHttpInfo(id, memberId);
        }

        /// <summary>
        /// Delete a member from a queue This will delete the specified member from the given queue.
        /// </summary>
        /// <param name="id">Queue ID</param> 
        /// <param name="memberId">Member ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ProcessautomationQueuesIdMembersMemberidDeleteWithHttpInfo (string id, string memberId)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationQueuesIdMembersMemberidDelete");
            
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling ProcessautomationQueuesIdMembersMemberidDelete");
            
    
            var path_ = "/api/v1/processautomation/queues/{id}/members/{memberId}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (memberId != null) pathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdMembersMemberidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdMembersMemberidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete a member from a queue This will delete the specified member from the given queue.
        /// </summary>
        /// <param name="id">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ProcessautomationQueuesIdMembersMemberidDeleteAsync (string id, string memberId)
        {
             await ProcessautomationQueuesIdMembersMemberidDeleteAsyncWithHttpInfo(id, memberId);

        }

        /// <summary>
        /// Delete a member from a queue This will delete the specified member from the given queue.
        /// </summary>
        /// <param name="id">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ProcessautomationQueuesIdMembersMemberidDeleteAsyncWithHttpInfo (string id, string memberId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationQueuesIdMembersMemberidDelete");
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling ProcessautomationQueuesIdMembersMemberidDelete");
            
    
            var path_ = "/api/v1/processautomation/queues/{id}/members/{memberId}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (memberId != null) pathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdMembersMemberidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationQueuesIdMembersMemberidDelete: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Generates a list of active and/or completed flows based upon the specified filters and facets. Searches the pool of running and completed flow instances given a ReportRequest object and returns the matching results.
        /// </summary>
        /// <param name="body">ReportRequest data containing search parameters and paging response.</param> 
        /// <returns>FlowReportResultItem</returns>
        public FlowReportResultItem ProcessautomationReportsFlowSearchPost (ReportRequest body)
        {
             ApiResponse<FlowReportResultItem> response = ProcessautomationReportsFlowSearchPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Generates a list of active and/or completed flows based upon the specified filters and facets. Searches the pool of running and completed flow instances given a ReportRequest object and returns the matching results.
        /// </summary>
        /// <param name="body">ReportRequest data containing search parameters and paging response.</param> 
        /// <returns>ApiResponse of FlowReportResultItem</returns>
        public ApiResponse< FlowReportResultItem > ProcessautomationReportsFlowSearchPostWithHttpInfo (ReportRequest body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ProcessautomationReportsFlowSearchPost");
            
    
            var path_ = "/api/v1/processautomation/reports/flow/search";
    
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
                throw new ApiException (statusCode, "Error calling ProcessautomationReportsFlowSearchPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationReportsFlowSearchPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FlowReportResultItem>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowReportResultItem) Configuration.ApiClient.Deserialize(response, typeof(FlowReportResultItem)));
            
        }
    
        /// <summary>
        /// Generates a list of active and/or completed flows based upon the specified filters and facets. Searches the pool of running and completed flow instances given a ReportRequest object and returns the matching results.
        /// </summary>
        /// <param name="body">ReportRequest data containing search parameters and paging response.</param>
        /// <returns>Task of FlowReportResultItem</returns>
        public async System.Threading.Tasks.Task<FlowReportResultItem> ProcessautomationReportsFlowSearchPostAsync (ReportRequest body)
        {
             ApiResponse<FlowReportResultItem> response = await ProcessautomationReportsFlowSearchPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Generates a list of active and/or completed flows based upon the specified filters and facets. Searches the pool of running and completed flow instances given a ReportRequest object and returns the matching results.
        /// </summary>
        /// <param name="body">ReportRequest data containing search parameters and paging response.</param>
        /// <returns>Task of ApiResponse (FlowReportResultItem)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowReportResultItem>> ProcessautomationReportsFlowSearchPostAsyncWithHttpInfo (ReportRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ProcessautomationReportsFlowSearchPost");
            
    
            var path_ = "/api/v1/processautomation/reports/flow/search";
    
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
                throw new ApiException (statusCode, "Error calling ProcessautomationReportsFlowSearchPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationReportsFlowSearchPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FlowReportResultItem>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowReportResultItem) Configuration.ApiClient.Deserialize(response, typeof(FlowReportResultItem)));
            
        }
        
        /// <summary>
        /// Search the currently running workitems Searches the pool of running workitems given a SearchRequest object and returns the results.  Some search examples:&lt;br&gt;Note the various filters, sort and searchPhrase options can be combined/omitted as needed.&lt;br&gt;Search for a specific definition id:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowConfigId.id\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;e88db9fb-aaa0-46f8-81d5-4a30e323bdfa\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;&lt;br&gt;Search for a specific execution instance and sort on the config name:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowExecId\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;99\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;],&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sort\&quot; : [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;:\&quot;flowConfigName\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sortType\&quot;:\&quot;ASCENDING\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;Search for a specific phrase:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;searchPhrase\&quot; : \&quot;hi mom!\&quot; &lt;br&gt;}&lt;br&gt;
        /// </summary>
        /// <param name="body">SearchRequest data containing search parameters and paging response.</param> 
        /// <returns>WorkItemSearchDetailsSearchResult</returns>
        public WorkItemSearchDetailsSearchResult ProcessautomationWorkitemsInstancesCommandsSearchPost (SearchRequest body)
        {
             ApiResponse<WorkItemSearchDetailsSearchResult> response = ProcessautomationWorkitemsInstancesCommandsSearchPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Search the currently running workitems Searches the pool of running workitems given a SearchRequest object and returns the results.  Some search examples:&lt;br&gt;Note the various filters, sort and searchPhrase options can be combined/omitted as needed.&lt;br&gt;Search for a specific definition id:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowConfigId.id\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;e88db9fb-aaa0-46f8-81d5-4a30e323bdfa\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;&lt;br&gt;Search for a specific execution instance and sort on the config name:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowExecId\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;99\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;],&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sort\&quot; : [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;:\&quot;flowConfigName\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sortType\&quot;:\&quot;ASCENDING\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;Search for a specific phrase:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;searchPhrase\&quot; : \&quot;hi mom!\&quot; &lt;br&gt;}&lt;br&gt;
        /// </summary>
        /// <param name="body">SearchRequest data containing search parameters and paging response.</param> 
        /// <returns>ApiResponse of WorkItemSearchDetailsSearchResult</returns>
        public ApiResponse< WorkItemSearchDetailsSearchResult > ProcessautomationWorkitemsInstancesCommandsSearchPostWithHttpInfo (SearchRequest body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ProcessautomationWorkitemsInstancesCommandsSearchPost");
            
    
            var path_ = "/api/v1/processautomation/workitems/instances/commands/search";
    
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
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesCommandsSearchPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesCommandsSearchPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<WorkItemSearchDetailsSearchResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkItemSearchDetailsSearchResult) Configuration.ApiClient.Deserialize(response, typeof(WorkItemSearchDetailsSearchResult)));
            
        }
    
        /// <summary>
        /// Search the currently running workitems Searches the pool of running workitems given a SearchRequest object and returns the results.  Some search examples:&lt;br&gt;Note the various filters, sort and searchPhrase options can be combined/omitted as needed.&lt;br&gt;Search for a specific definition id:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowConfigId.id\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;e88db9fb-aaa0-46f8-81d5-4a30e323bdfa\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;&lt;br&gt;Search for a specific execution instance and sort on the config name:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowExecId\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;99\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;],&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sort\&quot; : [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;:\&quot;flowConfigName\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sortType\&quot;:\&quot;ASCENDING\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;Search for a specific phrase:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;searchPhrase\&quot; : \&quot;hi mom!\&quot; &lt;br&gt;}&lt;br&gt;
        /// </summary>
        /// <param name="body">SearchRequest data containing search parameters and paging response.</param>
        /// <returns>Task of WorkItemSearchDetailsSearchResult</returns>
        public async System.Threading.Tasks.Task<WorkItemSearchDetailsSearchResult> ProcessautomationWorkitemsInstancesCommandsSearchPostAsync (SearchRequest body)
        {
             ApiResponse<WorkItemSearchDetailsSearchResult> response = await ProcessautomationWorkitemsInstancesCommandsSearchPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Search the currently running workitems Searches the pool of running workitems given a SearchRequest object and returns the results.  Some search examples:&lt;br&gt;Note the various filters, sort and searchPhrase options can be combined/omitted as needed.&lt;br&gt;Search for a specific definition id:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowConfigId.id\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;e88db9fb-aaa0-46f8-81d5-4a30e323bdfa\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;&lt;br&gt;Search for a specific execution instance and sort on the config name:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;filters\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;: \&quot;flowExecId\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;type\&quot;: \&quot;STRING\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;operator\&quot;: \&quot;EQUALS\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;values\&quot;: [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;99\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;],&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sort\&quot; : [&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;name\&quot;:\&quot;flowConfigName\&quot;,&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;sortType\&quot;:\&quot;ASCENDING\&quot;&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;}&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;]&lt;br&gt;}&lt;br&gt;Search for a specific phrase:&lt;br&gt;{&lt;br&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;\&quot;searchPhrase\&quot; : \&quot;hi mom!\&quot; &lt;br&gt;}&lt;br&gt;
        /// </summary>
        /// <param name="body">SearchRequest data containing search parameters and paging response.</param>
        /// <returns>Task of ApiResponse (WorkItemSearchDetailsSearchResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkItemSearchDetailsSearchResult>> ProcessautomationWorkitemsInstancesCommandsSearchPostAsyncWithHttpInfo (SearchRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ProcessautomationWorkitemsInstancesCommandsSearchPost");
            
    
            var path_ = "/api/v1/processautomation/workitems/instances/commands/search";
    
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
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesCommandsSearchPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesCommandsSearchPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<WorkItemSearchDetailsSearchResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkItemSearchDetailsSearchResult) Configuration.ApiClient.Deserialize(response, typeof(WorkItemSearchDetailsSearchResult)));
            
        }
        
        /// <summary>
        /// Get a Work Item&#39;s Details Gets the details of a work item including the information needed to display its simple form, if it has one.
        /// </summary>
        /// <param name="id">Work Item Exec ID</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <returns>WorkItemDetails</returns>
        public WorkItemDetails ProcessautomationWorkitemsInstancesIdGet (string id, string expand = null)
        {
             ApiResponse<WorkItemDetails> response = ProcessautomationWorkitemsInstancesIdGetWithHttpInfo(id, expand);
             return response.Data;
        }

        /// <summary>
        /// Get a Work Item&#39;s Details Gets the details of a work item including the information needed to display its simple form, if it has one.
        /// </summary>
        /// <param name="id">Work Item Exec ID</param> 
        /// <param name="expand">Expand instructions for the return value.</param> 
        /// <returns>ApiResponse of WorkItemDetails</returns>
        public ApiResponse< WorkItemDetails > ProcessautomationWorkitemsInstancesIdGetWithHttpInfo (string id, string expand = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationWorkitemsInstancesIdGet");
            
    
            var path_ = "/api/v1/processautomation/workitems/instances/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<WorkItemDetails>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkItemDetails) Configuration.ApiClient.Deserialize(response, typeof(WorkItemDetails)));
            
        }
    
        /// <summary>
        /// Get a Work Item&#39;s Details Gets the details of a work item including the information needed to display its simple form, if it has one.
        /// </summary>
        /// <param name="id">Work Item Exec ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of WorkItemDetails</returns>
        public async System.Threading.Tasks.Task<WorkItemDetails> ProcessautomationWorkitemsInstancesIdGetAsync (string id, string expand = null)
        {
             ApiResponse<WorkItemDetails> response = await ProcessautomationWorkitemsInstancesIdGetAsyncWithHttpInfo(id, expand);
             return response.Data;

        }

        /// <summary>
        /// Get a Work Item&#39;s Details Gets the details of a work item including the information needed to display its simple form, if it has one.
        /// </summary>
        /// <param name="id">Work Item Exec ID</param>
        /// <param name="expand">Expand instructions for the return value.</param>
        /// <returns>Task of ApiResponse (WorkItemDetails)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkItemDetails>> ProcessautomationWorkitemsInstancesIdGetAsyncWithHttpInfo (string id, string expand = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationWorkitemsInstancesIdGet");
            
    
            var path_ = "/api/v1/processautomation/workitems/instances/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<WorkItemDetails>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkItemDetails) Configuration.ApiClient.Deserialize(response, typeof(WorkItemDetails)));
            
        }
        
        /// <summary>
        /// Submits a work item &lt;p&gt;Signals the flow to continue executing using the specified command of the given work item.&lt;/p&gt;&lt;p&gt;Common error conditions to be aware of are:&lt;dl&gt;&lt;dd&gt;error.workflow.flows.workItem.ownership - the given user was denied the ability to own the work item&lt;/dd&gt;&lt;dd&gt;error.workflow.flows.workItem.owned - the work item is already owned by somebody else&lt;/dd&gt;&lt;dd&gt;error.workflow.flows.workItem.notExist - the work item does not exist, possibly because it was already submitted by someone else&lt;/dd&gt;&lt;dd&gt;error.workflow.flows.workItem.submit - some other error submitting the work item&lt;/dd&gt;&lt;/dl&gt;&lt;/p&gt;
        /// </summary>
        /// <param name="id">Work Item Exec ID</param> 
        /// <param name="body">submit request data</param> 
        /// <returns></returns>
        public void ProcessautomationWorkitemsInstancesIdCommandsSubmitPost (string id, WorkItemSubmitRequest body = null)
        {
             ProcessautomationWorkitemsInstancesIdCommandsSubmitPostWithHttpInfo(id, body);
        }

        /// <summary>
        /// Submits a work item &lt;p&gt;Signals the flow to continue executing using the specified command of the given work item.&lt;/p&gt;&lt;p&gt;Common error conditions to be aware of are:&lt;dl&gt;&lt;dd&gt;error.workflow.flows.workItem.ownership - the given user was denied the ability to own the work item&lt;/dd&gt;&lt;dd&gt;error.workflow.flows.workItem.owned - the work item is already owned by somebody else&lt;/dd&gt;&lt;dd&gt;error.workflow.flows.workItem.notExist - the work item does not exist, possibly because it was already submitted by someone else&lt;/dd&gt;&lt;dd&gt;error.workflow.flows.workItem.submit - some other error submitting the work item&lt;/dd&gt;&lt;/dl&gt;&lt;/p&gt;
        /// </summary>
        /// <param name="id">Work Item Exec ID</param> 
        /// <param name="body">submit request data</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ProcessautomationWorkitemsInstancesIdCommandsSubmitPostWithHttpInfo (string id, WorkItemSubmitRequest body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationWorkitemsInstancesIdCommandsSubmitPost");
            
    
            var path_ = "/api/v1/processautomation/workitems/instances/{id}/commands/submit";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesIdCommandsSubmitPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesIdCommandsSubmitPost: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Submits a work item &lt;p&gt;Signals the flow to continue executing using the specified command of the given work item.&lt;/p&gt;&lt;p&gt;Common error conditions to be aware of are:&lt;dl&gt;&lt;dd&gt;error.workflow.flows.workItem.ownership - the given user was denied the ability to own the work item&lt;/dd&gt;&lt;dd&gt;error.workflow.flows.workItem.owned - the work item is already owned by somebody else&lt;/dd&gt;&lt;dd&gt;error.workflow.flows.workItem.notExist - the work item does not exist, possibly because it was already submitted by someone else&lt;/dd&gt;&lt;dd&gt;error.workflow.flows.workItem.submit - some other error submitting the work item&lt;/dd&gt;&lt;/dl&gt;&lt;/p&gt;
        /// </summary>
        /// <param name="id">Work Item Exec ID</param>
        /// <param name="body">submit request data</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ProcessautomationWorkitemsInstancesIdCommandsSubmitPostAsync (string id, WorkItemSubmitRequest body = null)
        {
             await ProcessautomationWorkitemsInstancesIdCommandsSubmitPostAsyncWithHttpInfo(id, body);

        }

        /// <summary>
        /// Submits a work item &lt;p&gt;Signals the flow to continue executing using the specified command of the given work item.&lt;/p&gt;&lt;p&gt;Common error conditions to be aware of are:&lt;dl&gt;&lt;dd&gt;error.workflow.flows.workItem.ownership - the given user was denied the ability to own the work item&lt;/dd&gt;&lt;dd&gt;error.workflow.flows.workItem.owned - the work item is already owned by somebody else&lt;/dd&gt;&lt;dd&gt;error.workflow.flows.workItem.notExist - the work item does not exist, possibly because it was already submitted by someone else&lt;/dd&gt;&lt;dd&gt;error.workflow.flows.workItem.submit - some other error submitting the work item&lt;/dd&gt;&lt;/dl&gt;&lt;/p&gt;
        /// </summary>
        /// <param name="id">Work Item Exec ID</param>
        /// <param name="body">submit request data</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ProcessautomationWorkitemsInstancesIdCommandsSubmitPostAsyncWithHttpInfo (string id, WorkItemSubmitRequest body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationWorkitemsInstancesIdCommandsSubmitPost");
            
    
            var path_ = "/api/v1/processautomation/workitems/instances/{id}/commands/submit";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesIdCommandsSubmitPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesIdCommandsSubmitPost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Attempts to take ownership of a work item Basically, this is called by a client to assign ownership to the currently connected user.  Only the user that has ownership can submit against a work item.  This will be rejected is someone else owns it, like if it’s in a queue and somebody grabs it at the same time.  The first guy wins the ownership.
        /// </summary>
        /// <param name="id">Work Item Exec ID</param> 
        /// <returns></returns>
        public void ProcessautomationWorkitemsInstancesIdCommandsTakeownershipPost (string id)
        {
             ProcessautomationWorkitemsInstancesIdCommandsTakeownershipPostWithHttpInfo(id);
        }

        /// <summary>
        /// Attempts to take ownership of a work item Basically, this is called by a client to assign ownership to the currently connected user.  Only the user that has ownership can submit against a work item.  This will be rejected is someone else owns it, like if it’s in a queue and somebody grabs it at the same time.  The first guy wins the ownership.
        /// </summary>
        /// <param name="id">Work Item Exec ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ProcessautomationWorkitemsInstancesIdCommandsTakeownershipPostWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationWorkitemsInstancesIdCommandsTakeownershipPost");
            
    
            var path_ = "/api/v1/processautomation/workitems/instances/{id}/commands/takeownership";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesIdCommandsTakeownershipPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesIdCommandsTakeownershipPost: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Attempts to take ownership of a work item Basically, this is called by a client to assign ownership to the currently connected user.  Only the user that has ownership can submit against a work item.  This will be rejected is someone else owns it, like if it’s in a queue and somebody grabs it at the same time.  The first guy wins the ownership.
        /// </summary>
        /// <param name="id">Work Item Exec ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ProcessautomationWorkitemsInstancesIdCommandsTakeownershipPostAsync (string id)
        {
             await ProcessautomationWorkitemsInstancesIdCommandsTakeownershipPostAsyncWithHttpInfo(id);

        }

        /// <summary>
        /// Attempts to take ownership of a work item Basically, this is called by a client to assign ownership to the currently connected user.  Only the user that has ownership can submit against a work item.  This will be rejected is someone else owns it, like if it’s in a queue and somebody grabs it at the same time.  The first guy wins the ownership.
        /// </summary>
        /// <param name="id">Work Item Exec ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ProcessautomationWorkitemsInstancesIdCommandsTakeownershipPostAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationWorkitemsInstancesIdCommandsTakeownershipPost");
            
    
            var path_ = "/api/v1/processautomation/workitems/instances/{id}/commands/takeownership";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesIdCommandsTakeownershipPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesIdCommandsTakeownershipPost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Transfers a work item Unassigns a work item, if currently assigned, and offers a work item to another user or queue; the work item is initially unassigned (meaning un-owned).   You have to own the item to transfer it, unless you’re an admin and using a “force” flag.
        /// </summary>
        /// <param name="id">Work Item Exec ID</param> 
        /// <param name="body">transfer request data</param> 
        /// <returns></returns>
        public void ProcessautomationWorkitemsInstancesIdCommandsTransferPost (string id, WorkItemTransferRequest body = null)
        {
             ProcessautomationWorkitemsInstancesIdCommandsTransferPostWithHttpInfo(id, body);
        }

        /// <summary>
        /// Transfers a work item Unassigns a work item, if currently assigned, and offers a work item to another user or queue; the work item is initially unassigned (meaning un-owned).   You have to own the item to transfer it, unless you’re an admin and using a “force” flag.
        /// </summary>
        /// <param name="id">Work Item Exec ID</param> 
        /// <param name="body">transfer request data</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ProcessautomationWorkitemsInstancesIdCommandsTransferPostWithHttpInfo (string id, WorkItemTransferRequest body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationWorkitemsInstancesIdCommandsTransferPost");
            
    
            var path_ = "/api/v1/processautomation/workitems/instances/{id}/commands/transfer";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesIdCommandsTransferPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesIdCommandsTransferPost: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Transfers a work item Unassigns a work item, if currently assigned, and offers a work item to another user or queue; the work item is initially unassigned (meaning un-owned).   You have to own the item to transfer it, unless you’re an admin and using a “force” flag.
        /// </summary>
        /// <param name="id">Work Item Exec ID</param>
        /// <param name="body">transfer request data</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ProcessautomationWorkitemsInstancesIdCommandsTransferPostAsync (string id, WorkItemTransferRequest body = null)
        {
             await ProcessautomationWorkitemsInstancesIdCommandsTransferPostAsyncWithHttpInfo(id, body);

        }

        /// <summary>
        /// Transfers a work item Unassigns a work item, if currently assigned, and offers a work item to another user or queue; the work item is initially unassigned (meaning un-owned).   You have to own the item to transfer it, unless you’re an admin and using a “force” flag.
        /// </summary>
        /// <param name="id">Work Item Exec ID</param>
        /// <param name="body">transfer request data</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ProcessautomationWorkitemsInstancesIdCommandsTransferPostAsyncWithHttpInfo (string id, WorkItemTransferRequest body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationWorkitemsInstancesIdCommandsTransferPost");
            
    
            var path_ = "/api/v1/processautomation/workitems/instances/{id}/commands/transfer";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesIdCommandsTransferPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesIdCommandsTransferPost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Gets an optional cache for a given workItem. Gets a user saved cache of workItem data.
        /// </summary>
        /// <param name="id">Work Item Exec ID</param> 
        /// <returns>WorkItemCache</returns>
        public WorkItemCache ProcessautomationWorkitemsInstancesIdWorkitemcacheGet (string id)
        {
             ApiResponse<WorkItemCache> response = ProcessautomationWorkitemsInstancesIdWorkitemcacheGetWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        /// Gets an optional cache for a given workItem. Gets a user saved cache of workItem data.
        /// </summary>
        /// <param name="id">Work Item Exec ID</param> 
        /// <returns>ApiResponse of WorkItemCache</returns>
        public ApiResponse< WorkItemCache > ProcessautomationWorkitemsInstancesIdWorkitemcacheGetWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationWorkitemsInstancesIdWorkitemcacheGet");
            
    
            var path_ = "/api/v1/processautomation/workitems/instances/{id}/workitemcache";
    
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
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesIdWorkitemcacheGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesIdWorkitemcacheGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<WorkItemCache>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkItemCache) Configuration.ApiClient.Deserialize(response, typeof(WorkItemCache)));
            
        }
    
        /// <summary>
        /// Gets an optional cache for a given workItem. Gets a user saved cache of workItem data.
        /// </summary>
        /// <param name="id">Work Item Exec ID</param>
        /// <returns>Task of WorkItemCache</returns>
        public async System.Threading.Tasks.Task<WorkItemCache> ProcessautomationWorkitemsInstancesIdWorkitemcacheGetAsync (string id)
        {
             ApiResponse<WorkItemCache> response = await ProcessautomationWorkitemsInstancesIdWorkitemcacheGetAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        /// Gets an optional cache for a given workItem. Gets a user saved cache of workItem data.
        /// </summary>
        /// <param name="id">Work Item Exec ID</param>
        /// <returns>Task of ApiResponse (WorkItemCache)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkItemCache>> ProcessautomationWorkitemsInstancesIdWorkitemcacheGetAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationWorkitemsInstancesIdWorkitemcacheGet");
            
    
            var path_ = "/api/v1/processautomation/workitems/instances/{id}/workitemcache";
    
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
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesIdWorkitemcacheGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesIdWorkitemcacheGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<WorkItemCache>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WorkItemCache) Configuration.ApiClient.Deserialize(response, typeof(WorkItemCache)));
            
        }
        
        /// <summary>
        /// Saves workItem data to a temporary location. The cache is automatically deleted when a workItem is submitted.
        /// </summary>
        /// <param name="id">Work Item Exec ID</param> 
        /// <param name="body">workItem cache data</param> 
        /// <returns></returns>
        public void ProcessautomationWorkitemsInstancesIdWorkitemcachePut (string id, WorkItemCache body = null)
        {
             ProcessautomationWorkitemsInstancesIdWorkitemcachePutWithHttpInfo(id, body);
        }

        /// <summary>
        /// Saves workItem data to a temporary location. The cache is automatically deleted when a workItem is submitted.
        /// </summary>
        /// <param name="id">Work Item Exec ID</param> 
        /// <param name="body">workItem cache data</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ProcessautomationWorkitemsInstancesIdWorkitemcachePutWithHttpInfo (string id, WorkItemCache body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationWorkitemsInstancesIdWorkitemcachePut");
            
    
            var path_ = "/api/v1/processautomation/workitems/instances/{id}/workitemcache";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesIdWorkitemcachePut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesIdWorkitemcachePut: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Saves workItem data to a temporary location. The cache is automatically deleted when a workItem is submitted.
        /// </summary>
        /// <param name="id">Work Item Exec ID</param>
        /// <param name="body">workItem cache data</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ProcessautomationWorkitemsInstancesIdWorkitemcachePutAsync (string id, WorkItemCache body = null)
        {
             await ProcessautomationWorkitemsInstancesIdWorkitemcachePutAsyncWithHttpInfo(id, body);

        }

        /// <summary>
        /// Saves workItem data to a temporary location. The cache is automatically deleted when a workItem is submitted.
        /// </summary>
        /// <param name="id">Work Item Exec ID</param>
        /// <param name="body">workItem cache data</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ProcessautomationWorkitemsInstancesIdWorkitemcachePutAsyncWithHttpInfo (string id, WorkItemCache body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ProcessautomationWorkitemsInstancesIdWorkitemcachePut");
            
    
            var path_ = "/api/v1/processautomation/workitems/instances/{id}/workitemcache";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesIdWorkitemcachePut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ProcessautomationWorkitemsInstancesIdWorkitemcachePut: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
