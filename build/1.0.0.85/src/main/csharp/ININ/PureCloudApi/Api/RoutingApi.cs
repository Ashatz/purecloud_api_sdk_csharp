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
    public interface IRoutingApi
    {
        
        /// <summary>
        /// Get domains
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>InboundDomainEntityListing</returns>
        InboundDomainEntityListing RoutingEmailDomainsGet ();
  
        /// <summary>
        /// Get domains
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of InboundDomainEntityListing</returns>
        ApiResponse<InboundDomainEntityListing> RoutingEmailDomainsGetWithHttpInfo ();

        /// <summary>
        /// Get domains
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of InboundDomainEntityListing</returns>
        System.Threading.Tasks.Task<InboundDomainEntityListing> RoutingEmailDomainsGetAsync ();

        /// <summary>
        /// Get domains
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (InboundDomainEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundDomainEntityListing>> RoutingEmailDomainsGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Create a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Domain</param>
        /// <returns>InboundDomain</returns>
        InboundDomain RoutingEmailDomainsPost (InboundDomain body = null);
  
        /// <summary>
        /// Create a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Domain</param>
        /// <returns>ApiResponse of InboundDomain</returns>
        ApiResponse<InboundDomain> RoutingEmailDomainsPostWithHttpInfo (InboundDomain body = null);

        /// <summary>
        /// Create a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Domain</param>
        /// <returns>Task of InboundDomain</returns>
        System.Threading.Tasks.Task<InboundDomain> RoutingEmailDomainsPostAsync (InboundDomain body = null);

        /// <summary>
        /// Create a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Domain</param>
        /// <returns>Task of ApiResponse (InboundDomain)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundDomain>> RoutingEmailDomainsPostAsyncWithHttpInfo (InboundDomain body = null);
        
        /// <summary>
        /// Get routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <returns>InboundRouteEntityListing</returns>
        InboundRouteEntityListing RoutingEmailDomainsDomainRoutesGet (string domain);
  
        /// <summary>
        /// Get routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <returns>ApiResponse of InboundRouteEntityListing</returns>
        ApiResponse<InboundRouteEntityListing> RoutingEmailDomainsDomainRoutesGetWithHttpInfo (string domain);

        /// <summary>
        /// Get routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <returns>Task of InboundRouteEntityListing</returns>
        System.Threading.Tasks.Task<InboundRouteEntityListing> RoutingEmailDomainsDomainRoutesGetAsync (string domain);

        /// <summary>
        /// Get routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <returns>Task of ApiResponse (InboundRouteEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundRouteEntityListing>> RoutingEmailDomainsDomainRoutesGetAsyncWithHttpInfo (string domain);
        
        /// <summary>
        /// Create a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="body">Route</param>
        /// <returns>InboundRoute</returns>
        InboundRoute RoutingEmailDomainsDomainRoutesPost (string domain, InboundRoute body = null);
  
        /// <summary>
        /// Create a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="body">Route</param>
        /// <returns>ApiResponse of InboundRoute</returns>
        ApiResponse<InboundRoute> RoutingEmailDomainsDomainRoutesPostWithHttpInfo (string domain, InboundRoute body = null);

        /// <summary>
        /// Create a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="body">Route</param>
        /// <returns>Task of InboundRoute</returns>
        System.Threading.Tasks.Task<InboundRoute> RoutingEmailDomainsDomainRoutesPostAsync (string domain, InboundRoute body = null);

        /// <summary>
        /// Create a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="body">Route</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundRoute>> RoutingEmailDomainsDomainRoutesPostAsyncWithHttpInfo (string domain, InboundRoute body = null);
        
        /// <summary>
        /// Get a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>InboundRoute</returns>
        InboundRoute RoutingEmailDomainsDomainRoutesIdGet (string domain, string id);
  
        /// <summary>
        /// Get a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>ApiResponse of InboundRoute</returns>
        ApiResponse<InboundRoute> RoutingEmailDomainsDomainRoutesIdGetWithHttpInfo (string domain, string id);

        /// <summary>
        /// Get a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>Task of InboundRoute</returns>
        System.Threading.Tasks.Task<InboundRoute> RoutingEmailDomainsDomainRoutesIdGetAsync (string domain, string id);

        /// <summary>
        /// Get a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundRoute>> RoutingEmailDomainsDomainRoutesIdGetAsyncWithHttpInfo (string domain, string id);
        
        /// <summary>
        /// Update a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <param name="body">Route</param>
        /// <returns>InboundRoute</returns>
        InboundRoute RoutingEmailDomainsDomainRoutesIdPut (string domain, string id, InboundRoute body = null);
  
        /// <summary>
        /// Update a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <param name="body">Route</param>
        /// <returns>ApiResponse of InboundRoute</returns>
        ApiResponse<InboundRoute> RoutingEmailDomainsDomainRoutesIdPutWithHttpInfo (string domain, string id, InboundRoute body = null);

        /// <summary>
        /// Update a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <param name="body">Route</param>
        /// <returns>Task of InboundRoute</returns>
        System.Threading.Tasks.Task<InboundRoute> RoutingEmailDomainsDomainRoutesIdPutAsync (string domain, string id, InboundRoute body = null);

        /// <summary>
        /// Update a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <param name="body">Route</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundRoute>> RoutingEmailDomainsDomainRoutesIdPutAsyncWithHttpInfo (string domain, string id, InboundRoute body = null);
        
        /// <summary>
        /// Delete a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>string</returns>
        string RoutingEmailDomainsDomainRoutesIdDelete (string domain, string id);
  
        /// <summary>
        /// Delete a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RoutingEmailDomainsDomainRoutesIdDeleteWithHttpInfo (string domain, string id);

        /// <summary>
        /// Delete a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> RoutingEmailDomainsDomainRoutesIdDeleteAsync (string domain, string id);

        /// <summary>
        /// Delete a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> RoutingEmailDomainsDomainRoutesIdDeleteAsyncWithHttpInfo (string domain, string id);
        
        /// <summary>
        /// Delete a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">domain ID</param>
        /// <returns>string</returns>
        string RoutingEmailDomainsIdDelete (string id);
  
        /// <summary>
        /// Delete a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">domain ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RoutingEmailDomainsIdDeleteWithHttpInfo (string id);

        /// <summary>
        /// Delete a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">domain ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> RoutingEmailDomainsIdDeleteAsync (string id);

        /// <summary>
        /// Delete a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">domain ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> RoutingEmailDomainsIdDeleteAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// Get email setup
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>EmailSetup</returns>
        EmailSetup RoutingEmailSetupGet ();
  
        /// <summary>
        /// Get email setup
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of EmailSetup</returns>
        ApiResponse<EmailSetup> RoutingEmailSetupGetWithHttpInfo ();

        /// <summary>
        /// Get email setup
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of EmailSetup</returns>
        System.Threading.Tasks.Task<EmailSetup> RoutingEmailSetupGetAsync ();

        /// <summary>
        /// Get email setup
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (EmailSetup)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailSetup>> RoutingEmailSetupGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get list of queues.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="name">Name</param>
        /// <param name="active">Active</param>
        /// <returns>QueueEntityListing</returns>
        QueueEntityListing RoutingQueuesGet (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null);
  
        /// <summary>
        /// Get list of queues.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="name">Name</param>
        /// <param name="active">Active</param>
        /// <returns>ApiResponse of QueueEntityListing</returns>
        ApiResponse<QueueEntityListing> RoutingQueuesGetWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null);

        /// <summary>
        /// Get list of queues.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="name">Name</param>
        /// <param name="active">Active</param>
        /// <returns>Task of QueueEntityListing</returns>
        System.Threading.Tasks.Task<QueueEntityListing> RoutingQueuesGetAsync (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null);

        /// <summary>
        /// Get list of queues.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="name">Name</param>
        /// <param name="active">Active</param>
        /// <returns>Task of ApiResponse (QueueEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueEntityListing>> RoutingQueuesGetAsyncWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null);
        
        /// <summary>
        /// Create queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue</param>
        /// <returns>Queue</returns>
        Queue RoutingQueuesPost (string queueId, Queue body = null);
  
        /// <summary>
        /// Create queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue</param>
        /// <returns>ApiResponse of Queue</returns>
        ApiResponse<Queue> RoutingQueuesPostWithHttpInfo (string queueId, Queue body = null);

        /// <summary>
        /// Create queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue</param>
        /// <returns>Task of Queue</returns>
        System.Threading.Tasks.Task<Queue> RoutingQueuesPostAsync (string queueId, Queue body = null);

        /// <summary>
        /// Create queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue</param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        System.Threading.Tasks.Task<ApiResponse<Queue>> RoutingQueuesPostAsyncWithHttpInfo (string queueId, Queue body = null);
        
        /// <summary>
        /// Get details about this queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Queue</returns>
        Queue RoutingQueuesQueueidGet (string queueId);
  
        /// <summary>
        /// Get details about this queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <returns>ApiResponse of Queue</returns>
        ApiResponse<Queue> RoutingQueuesQueueidGetWithHttpInfo (string queueId);

        /// <summary>
        /// Get details about this queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of Queue</returns>
        System.Threading.Tasks.Task<Queue> RoutingQueuesQueueidGetAsync (string queueId);

        /// <summary>
        /// Get details about this queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        System.Threading.Tasks.Task<ApiResponse<Queue>> RoutingQueuesQueueidGetAsyncWithHttpInfo (string queueId);
        
        /// <summary>
        /// Update a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue</param>
        /// <returns>Queue</returns>
        Queue RoutingQueuesQueueidPut (string queueId, Queue body = null);
  
        /// <summary>
        /// Update a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue</param>
        /// <returns>ApiResponse of Queue</returns>
        ApiResponse<Queue> RoutingQueuesQueueidPutWithHttpInfo (string queueId, Queue body = null);

        /// <summary>
        /// Update a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue</param>
        /// <returns>Task of Queue</returns>
        System.Threading.Tasks.Task<Queue> RoutingQueuesQueueidPutAsync (string queueId, Queue body = null);

        /// <summary>
        /// Update a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue</param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        System.Threading.Tasks.Task<ApiResponse<Queue>> RoutingQueuesQueueidPutAsyncWithHttpInfo (string queueId, Queue body = null);
        
        /// <summary>
        /// Delete a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <returns>string</returns>
        string RoutingQueuesQueueidDelete (string queueId);
  
        /// <summary>
        /// Delete a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RoutingQueuesQueueidDeleteWithHttpInfo (string queueId);

        /// <summary>
        /// Delete a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> RoutingQueuesQueueidDeleteAsync (string queueId);

        /// <summary>
        /// Delete a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> RoutingQueuesQueueidDeleteAsyncWithHttpInfo (string queueId);
        
        /// <summary>
        /// Get members in a queue
        /// </summary>
        /// <remarks>
        /// Get the list of members of a queue
        /// </remarks>
        /// <param name="queueId"></param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="userId">UserID</param>
        /// <param name="statusId">Status ID</param>
        /// <param name="joined">Joined</param>
        /// <param name="expand">expand</param>
        /// <returns>QueueMemberEntityListing</returns>
        QueueMemberEntityListing RoutingQueuesQueueidMembersGet (string queueId, int? pageSize = null, int? pageNumber = null, string userId = null, string statusId = null, bool? joined = null, string expand = null);
  
        /// <summary>
        /// Get members in a queue
        /// </summary>
        /// <remarks>
        /// Get the list of members of a queue
        /// </remarks>
        /// <param name="queueId"></param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="userId">UserID</param>
        /// <param name="statusId">Status ID</param>
        /// <param name="joined">Joined</param>
        /// <param name="expand">expand</param>
        /// <returns>ApiResponse of QueueMemberEntityListing</returns>
        ApiResponse<QueueMemberEntityListing> RoutingQueuesQueueidMembersGetWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string userId = null, string statusId = null, bool? joined = null, string expand = null);

        /// <summary>
        /// Get members in a queue
        /// </summary>
        /// <remarks>
        /// Get the list of members of a queue
        /// </remarks>
        /// <param name="queueId"></param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="userId">UserID</param>
        /// <param name="statusId">Status ID</param>
        /// <param name="joined">Joined</param>
        /// <param name="expand">expand</param>
        /// <returns>Task of QueueMemberEntityListing</returns>
        System.Threading.Tasks.Task<QueueMemberEntityListing> RoutingQueuesQueueidMembersGetAsync (string queueId, int? pageSize = null, int? pageNumber = null, string userId = null, string statusId = null, bool? joined = null, string expand = null);

        /// <summary>
        /// Get members in a queue
        /// </summary>
        /// <remarks>
        /// Get the list of members of a queue
        /// </remarks>
        /// <param name="queueId"></param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="userId">UserID</param>
        /// <param name="statusId">Status ID</param>
        /// <param name="joined">Joined</param>
        /// <param name="expand">expand</param>
        /// <returns>Task of ApiResponse (QueueMemberEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueMemberEntityListing>> RoutingQueuesQueueidMembersGetAsyncWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string userId = null, string statusId = null, bool? joined = null, string expand = null);
        
        /// <summary>
        /// Join or unjoin a user to the queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member/User ID</param>
        /// <param name="body">To join queue ~ \&quot;joined\&quot;:true</param>
        /// <returns>QueueMember</returns>
        QueueMember RoutingQueuesQueueidMembersMemberidPut (string queueId, string memberId, QueueMember body = null);
  
        /// <summary>
        /// Join or unjoin a user to the queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member/User ID</param>
        /// <param name="body">To join queue ~ \&quot;joined\&quot;:true</param>
        /// <returns>ApiResponse of QueueMember</returns>
        ApiResponse<QueueMember> RoutingQueuesQueueidMembersMemberidPutWithHttpInfo (string queueId, string memberId, QueueMember body = null);

        /// <summary>
        /// Join or unjoin a user to the queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member/User ID</param>
        /// <param name="body">To join queue ~ \&quot;joined\&quot;:true</param>
        /// <returns>Task of QueueMember</returns>
        System.Threading.Tasks.Task<QueueMember> RoutingQueuesQueueidMembersMemberidPutAsync (string queueId, string memberId, QueueMember body = null);

        /// <summary>
        /// Join or unjoin a user to the queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member/User ID</param>
        /// <param name="body">To join queue ~ \&quot;joined\&quot;:true</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueMember>> RoutingQueuesQueueidMembersMemberidPutAsyncWithHttpInfo (string queueId, string memberId, QueueMember body = null);
        
        /// <summary>
        /// Get the members of this queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="expand">expand</param>
        /// <param name="directMembers">Only get users that are direct members of the queue</param>
        /// <returns>QueueMember</returns>
        QueueMember RoutingQueuesQueueidUsersGet (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null);
  
        /// <summary>
        /// Get the members of this queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="expand">expand</param>
        /// <param name="directMembers">Only get users that are direct members of the queue</param>
        /// <returns>ApiResponse of QueueMember</returns>
        ApiResponse<QueueMember> RoutingQueuesQueueidUsersGetWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null);

        /// <summary>
        /// Get the members of this queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="expand">expand</param>
        /// <param name="directMembers">Only get users that are direct members of the queue</param>
        /// <returns>Task of QueueMember</returns>
        System.Threading.Tasks.Task<QueueMember> RoutingQueuesQueueidUsersGetAsync (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null);

        /// <summary>
        /// Get the members of this queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="expand">expand</param>
        /// <param name="directMembers">Only get users that are direct members of the queue</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueMember>> RoutingQueuesQueueidUsersGetAsyncWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null);
        
        /// <summary>
        /// Bulk add or delete up to 100 queue members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members</param>
        /// <param name="delete">True to delete queue members</param>
        /// <returns>QueueMember</returns>
        QueueMember RoutingQueuesQueueidUsersPost (string queueId, List<QueueMember> body = null, bool? delete = null);
  
        /// <summary>
        /// Bulk add or delete up to 100 queue members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members</param>
        /// <param name="delete">True to delete queue members</param>
        /// <returns>ApiResponse of QueueMember</returns>
        ApiResponse<QueueMember> RoutingQueuesQueueidUsersPostWithHttpInfo (string queueId, List<QueueMember> body = null, bool? delete = null);

        /// <summary>
        /// Bulk add or delete up to 100 queue members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members</param>
        /// <param name="delete">True to delete queue members</param>
        /// <returns>Task of QueueMember</returns>
        System.Threading.Tasks.Task<QueueMember> RoutingQueuesQueueidUsersPostAsync (string queueId, List<QueueMember> body = null, bool? delete = null);

        /// <summary>
        /// Bulk add or delete up to 100 queue members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members</param>
        /// <param name="delete">True to delete queue members</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueMember>> RoutingQueuesQueueidUsersPostAsyncWithHttpInfo (string queueId, List<QueueMember> body = null, bool? delete = null);
        
        /// <summary>
        /// Join or unjoin a set of users for a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members</param>
        /// <returns>QueueMember</returns>
        QueueMember RoutingQueuesQueueidUsersPatch (string queueId, List<QueueMember> body = null);
  
        /// <summary>
        /// Join or unjoin a set of users for a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members</param>
        /// <returns>ApiResponse of QueueMember</returns>
        ApiResponse<QueueMember> RoutingQueuesQueueidUsersPatchWithHttpInfo (string queueId, List<QueueMember> body = null);

        /// <summary>
        /// Join or unjoin a set of users for a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members</param>
        /// <returns>Task of QueueMember</returns>
        System.Threading.Tasks.Task<QueueMember> RoutingQueuesQueueidUsersPatchAsync (string queueId, List<QueueMember> body = null);

        /// <summary>
        /// Join or unjoin a set of users for a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueMember>> RoutingQueuesQueueidUsersPatchAsyncWithHttpInfo (string queueId, List<QueueMember> body = null);
        
        /// <summary>
        /// Delete queue member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>string</returns>
        string RoutingQueuesQueueidUsersMemberidDelete (string queueId, string memberId);
  
        /// <summary>
        /// Delete queue member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RoutingQueuesQueueidUsersMemberidDeleteWithHttpInfo (string queueId, string memberId);

        /// <summary>
        /// Delete queue member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> RoutingQueuesQueueidUsersMemberidDeleteAsync (string queueId, string memberId);

        /// <summary>
        /// Delete queue member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> RoutingQueuesQueueidUsersMemberidDeleteAsyncWithHttpInfo (string queueId, string memberId);
        
        /// <summary>
        /// Update the ring number of joined status for a User in a Queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Queue Member</param>
        /// <returns>QueueMember</returns>
        QueueMember RoutingQueuesQueueidUsersMemberidPatch (string queueId, string memberId, QueueMember body = null);
  
        /// <summary>
        /// Update the ring number of joined status for a User in a Queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Queue Member</param>
        /// <returns>ApiResponse of QueueMember</returns>
        ApiResponse<QueueMember> RoutingQueuesQueueidUsersMemberidPatchWithHttpInfo (string queueId, string memberId, QueueMember body = null);

        /// <summary>
        /// Update the ring number of joined status for a User in a Queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Queue Member</param>
        /// <returns>Task of QueueMember</returns>
        System.Threading.Tasks.Task<QueueMember> RoutingQueuesQueueidUsersMemberidPatchAsync (string queueId, string memberId, QueueMember body = null);

        /// <summary>
        /// Update the ring number of joined status for a User in a Queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Queue Member</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueMember>> RoutingQueuesQueueidUsersMemberidPatchAsyncWithHttpInfo (string queueId, string memberId, QueueMember body = null);
        
        /// <summary>
        /// Get the wrap-up codes for a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>WrapupCode</returns>
        WrapupCode RoutingQueuesQueueidWrapupcodesGet (string queueId, string codeId);
  
        /// <summary>
        /// Get the wrap-up codes for a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> RoutingQueuesQueueidWrapupcodesGetWithHttpInfo (string queueId, string codeId);

        /// <summary>
        /// Get the wrap-up codes for a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> RoutingQueuesQueueidWrapupcodesGetAsync (string queueId, string codeId);

        /// <summary>
        /// Get the wrap-up codes for a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> RoutingQueuesQueueidWrapupcodesGetAsyncWithHttpInfo (string queueId, string codeId);
        
        /// <summary>
        /// Add up to 100 wrap-up codes to a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <param name="body"></param>
        /// <returns>WrapupCode</returns>
        WrapupCode RoutingQueuesQueueidWrapupcodesPost (string queueId, string codeId, List<WrapupCode> body = null);
  
        /// <summary>
        /// Add up to 100 wrap-up codes to a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> RoutingQueuesQueueidWrapupcodesPostWithHttpInfo (string queueId, string codeId, List<WrapupCode> body = null);

        /// <summary>
        /// Add up to 100 wrap-up codes to a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <param name="body"></param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> RoutingQueuesQueueidWrapupcodesPostAsync (string queueId, string codeId, List<WrapupCode> body = null);

        /// <summary>
        /// Add up to 100 wrap-up codes to a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> RoutingQueuesQueueidWrapupcodesPostAsyncWithHttpInfo (string queueId, string codeId, List<WrapupCode> body = null);
        
        /// <summary>
        /// Delete a wrap-up code from a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>string</returns>
        string RoutingQueuesQueueidWrapupcodesCodeidDelete (string queueId, string codeId);
  
        /// <summary>
        /// Delete a wrap-up code from a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RoutingQueuesQueueidWrapupcodesCodeidDeleteWithHttpInfo (string queueId, string codeId);

        /// <summary>
        /// Delete a wrap-up code from a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> RoutingQueuesQueueidWrapupcodesCodeidDeleteAsync (string queueId, string codeId);

        /// <summary>
        /// Delete a wrap-up code from a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> RoutingQueuesQueueidWrapupcodesCodeidDeleteAsyncWithHttpInfo (string queueId, string codeId);
        
        /// <summary>
        /// Get the list of skills.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="name">Name</param>
        /// <returns>SkillEntityListing</returns>
        SkillEntityListing RoutingSkillsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null);
  
        /// <summary>
        /// Get the list of skills.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="name">Name</param>
        /// <returns>ApiResponse of SkillEntityListing</returns>
        ApiResponse<SkillEntityListing> RoutingSkillsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null);

        /// <summary>
        /// Get the list of skills.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="name">Name</param>
        /// <returns>Task of SkillEntityListing</returns>
        System.Threading.Tasks.Task<SkillEntityListing> RoutingSkillsGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null);

        /// <summary>
        /// Get the list of skills.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="name">Name</param>
        /// <returns>Task of ApiResponse (SkillEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SkillEntityListing>> RoutingSkillsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null);
        
        /// <summary>
        /// Get the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Utilization</returns>
        Utilization RoutingUtilizationGet ();
  
        /// <summary>
        /// Get the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of Utilization</returns>
        ApiResponse<Utilization> RoutingUtilizationGetWithHttpInfo ();

        /// <summary>
        /// Get the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of Utilization</returns>
        System.Threading.Tasks.Task<Utilization> RoutingUtilizationGetAsync ();

        /// <summary>
        /// Get the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (Utilization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Utilization>> RoutingUtilizationGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Update the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">utilization</param>
        /// <returns>Utilization</returns>
        Utilization RoutingUtilizationPut (Utilization body = null);
  
        /// <summary>
        /// Update the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">utilization</param>
        /// <returns>ApiResponse of Utilization</returns>
        ApiResponse<Utilization> RoutingUtilizationPutWithHttpInfo (Utilization body = null);

        /// <summary>
        /// Update the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">utilization</param>
        /// <returns>Task of Utilization</returns>
        System.Threading.Tasks.Task<Utilization> RoutingUtilizationPutAsync (Utilization body = null);

        /// <summary>
        /// Update the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">utilization</param>
        /// <returns>Task of ApiResponse (Utilization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Utilization>> RoutingUtilizationPutAsyncWithHttpInfo (Utilization body = null);
        
        /// <summary>
        /// Delete utilization settings and revert to system defaults.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>string</returns>
        string RoutingUtilizationDelete ();
  
        /// <summary>
        /// Delete utilization settings and revert to system defaults.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RoutingUtilizationDeleteWithHttpInfo ();

        /// <summary>
        /// Delete utilization settings and revert to system defaults.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> RoutingUtilizationDeleteAsync ();

        /// <summary>
        /// Delete utilization settings and revert to system defaults.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> RoutingUtilizationDeleteAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get list of wrapup codes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>WrapupCodeEntityListing</returns>
        WrapupCodeEntityListing RoutingWrapupcodesGet (int? pageSize = null, int? pageNumber = null, string sortBy = null);
  
        /// <summary>
        /// Get list of wrapup codes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>ApiResponse of WrapupCodeEntityListing</returns>
        ApiResponse<WrapupCodeEntityListing> RoutingWrapupcodesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null);

        /// <summary>
        /// Get list of wrapup codes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of WrapupCodeEntityListing</returns>
        System.Threading.Tasks.Task<WrapupCodeEntityListing> RoutingWrapupcodesGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null);

        /// <summary>
        /// Get list of wrapup codes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of ApiResponse (WrapupCodeEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCodeEntityListing>> RoutingWrapupcodesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null);
        
        /// <summary>
        /// Create a wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">WrapupCode</param>
        /// <returns>CallableTimeSet</returns>
        CallableTimeSet RoutingWrapupcodesPost (WrapupCode body = null);
  
        /// <summary>
        /// Create a wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">WrapupCode</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        ApiResponse<CallableTimeSet> RoutingWrapupcodesPostWithHttpInfo (WrapupCode body = null);

        /// <summary>
        /// Create a wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">WrapupCode</param>
        /// <returns>Task of CallableTimeSet</returns>
        System.Threading.Tasks.Task<CallableTimeSet> RoutingWrapupcodesPostAsync (WrapupCode body = null);

        /// <summary>
        /// Create a wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">WrapupCode</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> RoutingWrapupcodesPostAsyncWithHttpInfo (WrapupCode body = null);
        
        /// <summary>
        /// Get details about this wrap-up code.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>WrapupCode</returns>
        WrapupCode RoutingWrapupcodesCodeidGet (string codeId);
  
        /// <summary>
        /// Get details about this wrap-up code.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> RoutingWrapupcodesCodeidGetWithHttpInfo (string codeId);

        /// <summary>
        /// Get details about this wrap-up code.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> RoutingWrapupcodesCodeidGetAsync (string codeId);

        /// <summary>
        /// Get details about this wrap-up code.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> RoutingWrapupcodesCodeidGetAsyncWithHttpInfo (string codeId);
        
        /// <summary>
        /// Update wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode</param>
        /// <returns>WrapupCode</returns>
        WrapupCode RoutingWrapupcodesCodeidPut (string codeId, WrapupCode body = null);
  
        /// <summary>
        /// Update wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> RoutingWrapupcodesCodeidPutWithHttpInfo (string codeId, WrapupCode body = null);

        /// <summary>
        /// Update wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> RoutingWrapupcodesCodeidPutAsync (string codeId, WrapupCode body = null);

        /// <summary>
        /// Update wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> RoutingWrapupcodesCodeidPutAsyncWithHttpInfo (string codeId, WrapupCode body = null);
        
        /// <summary>
        /// Delete wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>string</returns>
        string RoutingWrapupcodesCodeidDelete (string codeId);
  
        /// <summary>
        /// Delete wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RoutingWrapupcodesCodeidDeleteWithHttpInfo (string codeId);

        /// <summary>
        /// Delete wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> RoutingWrapupcodesCodeidDeleteAsync (string codeId);

        /// <summary>
        /// Delete wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> RoutingWrapupcodesCodeidDeleteAsyncWithHttpInfo (string codeId);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RoutingApi : IRoutingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RoutingApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RoutingApi(Configuration configuration = null)
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
        /// Get domains 
        /// </summary>
        /// <returns>InboundDomainEntityListing</returns>
        public InboundDomainEntityListing RoutingEmailDomainsGet ()
        {
             ApiResponse<InboundDomainEntityListing> response = RoutingEmailDomainsGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get domains 
        /// </summary>
        /// <returns>ApiResponse of InboundDomainEntityListing</returns>
        public ApiResponse< InboundDomainEntityListing > RoutingEmailDomainsGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/routing/email/domains";
    
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
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InboundDomainEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundDomainEntityListing) Configuration.ApiClient.Deserialize(response, typeof(InboundDomainEntityListing)));
            
        }
    
        /// <summary>
        /// Get domains 
        /// </summary>
        /// <returns>Task of InboundDomainEntityListing</returns>
        public async System.Threading.Tasks.Task<InboundDomainEntityListing> RoutingEmailDomainsGetAsync ()
        {
             ApiResponse<InboundDomainEntityListing> response = await RoutingEmailDomainsGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get domains 
        /// </summary>
        /// <returns>Task of ApiResponse (InboundDomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundDomainEntityListing>> RoutingEmailDomainsGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/routing/email/domains";
    
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
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InboundDomainEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundDomainEntityListing) Configuration.ApiClient.Deserialize(response, typeof(InboundDomainEntityListing)));
            
        }
        
        /// <summary>
        /// Create a domain 
        /// </summary>
        /// <param name="body">Domain</param> 
        /// <returns>InboundDomain</returns>
        public InboundDomain RoutingEmailDomainsPost (InboundDomain body = null)
        {
             ApiResponse<InboundDomain> response = RoutingEmailDomainsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a domain 
        /// </summary>
        /// <param name="body">Domain</param> 
        /// <returns>ApiResponse of InboundDomain</returns>
        public ApiResponse< InboundDomain > RoutingEmailDomainsPostWithHttpInfo (InboundDomain body = null)
        {
            
    
            var path_ = "/api/v1/routing/email/domains";
    
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
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InboundDomain>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundDomain) Configuration.ApiClient.Deserialize(response, typeof(InboundDomain)));
            
        }
    
        /// <summary>
        /// Create a domain 
        /// </summary>
        /// <param name="body">Domain</param>
        /// <returns>Task of InboundDomain</returns>
        public async System.Threading.Tasks.Task<InboundDomain> RoutingEmailDomainsPostAsync (InboundDomain body = null)
        {
             ApiResponse<InboundDomain> response = await RoutingEmailDomainsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a domain 
        /// </summary>
        /// <param name="body">Domain</param>
        /// <returns>Task of ApiResponse (InboundDomain)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundDomain>> RoutingEmailDomainsPostAsyncWithHttpInfo (InboundDomain body = null)
        {
            
    
            var path_ = "/api/v1/routing/email/domains";
    
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
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InboundDomain>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundDomain) Configuration.ApiClient.Deserialize(response, typeof(InboundDomain)));
            
        }
        
        /// <summary>
        /// Get routes 
        /// </summary>
        /// <param name="domain">email domain</param> 
        /// <returns>InboundRouteEntityListing</returns>
        public InboundRouteEntityListing RoutingEmailDomainsDomainRoutesGet (string domain)
        {
             ApiResponse<InboundRouteEntityListing> response = RoutingEmailDomainsDomainRoutesGetWithHttpInfo(domain);
             return response.Data;
        }

        /// <summary>
        /// Get routes 
        /// </summary>
        /// <param name="domain">email domain</param> 
        /// <returns>ApiResponse of InboundRouteEntityListing</returns>
        public ApiResponse< InboundRouteEntityListing > RoutingEmailDomainsDomainRoutesGetWithHttpInfo (string domain)
        {
            
            // verify the required parameter 'domain' is set
            if (domain == null) throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingEmailDomainsDomainRoutesGet");
            
    
            var path_ = "/api/v1/routing/email/domains/{domain}/routes";
    
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
            if (domain != null) pathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsDomainRoutesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsDomainRoutesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InboundRouteEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRouteEntityListing) Configuration.ApiClient.Deserialize(response, typeof(InboundRouteEntityListing)));
            
        }
    
        /// <summary>
        /// Get routes 
        /// </summary>
        /// <param name="domain">email domain</param>
        /// <returns>Task of InboundRouteEntityListing</returns>
        public async System.Threading.Tasks.Task<InboundRouteEntityListing> RoutingEmailDomainsDomainRoutesGetAsync (string domain)
        {
             ApiResponse<InboundRouteEntityListing> response = await RoutingEmailDomainsDomainRoutesGetAsyncWithHttpInfo(domain);
             return response.Data;

        }

        /// <summary>
        /// Get routes 
        /// </summary>
        /// <param name="domain">email domain</param>
        /// <returns>Task of ApiResponse (InboundRouteEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundRouteEntityListing>> RoutingEmailDomainsDomainRoutesGetAsyncWithHttpInfo (string domain)
        {
            // verify the required parameter 'domain' is set
            if (domain == null) throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingEmailDomainsDomainRoutesGet");
            
    
            var path_ = "/api/v1/routing/email/domains/{domain}/routes";
    
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
            if (domain != null) pathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsDomainRoutesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsDomainRoutesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InboundRouteEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRouteEntityListing) Configuration.ApiClient.Deserialize(response, typeof(InboundRouteEntityListing)));
            
        }
        
        /// <summary>
        /// Create a route 
        /// </summary>
        /// <param name="domain">email domain</param> 
        /// <param name="body">Route</param> 
        /// <returns>InboundRoute</returns>
        public InboundRoute RoutingEmailDomainsDomainRoutesPost (string domain, InboundRoute body = null)
        {
             ApiResponse<InboundRoute> response = RoutingEmailDomainsDomainRoutesPostWithHttpInfo(domain, body);
             return response.Data;
        }

        /// <summary>
        /// Create a route 
        /// </summary>
        /// <param name="domain">email domain</param> 
        /// <param name="body">Route</param> 
        /// <returns>ApiResponse of InboundRoute</returns>
        public ApiResponse< InboundRoute > RoutingEmailDomainsDomainRoutesPostWithHttpInfo (string domain, InboundRoute body = null)
        {
            
            // verify the required parameter 'domain' is set
            if (domain == null) throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingEmailDomainsDomainRoutesPost");
            
    
            var path_ = "/api/v1/routing/email/domains/{domain}/routes";
    
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
            if (domain != null) pathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsDomainRoutesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsDomainRoutesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InboundRoute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(response, typeof(InboundRoute)));
            
        }
    
        /// <summary>
        /// Create a route 
        /// </summary>
        /// <param name="domain">email domain</param>
        /// <param name="body">Route</param>
        /// <returns>Task of InboundRoute</returns>
        public async System.Threading.Tasks.Task<InboundRoute> RoutingEmailDomainsDomainRoutesPostAsync (string domain, InboundRoute body = null)
        {
             ApiResponse<InboundRoute> response = await RoutingEmailDomainsDomainRoutesPostAsyncWithHttpInfo(domain, body);
             return response.Data;

        }

        /// <summary>
        /// Create a route 
        /// </summary>
        /// <param name="domain">email domain</param>
        /// <param name="body">Route</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundRoute>> RoutingEmailDomainsDomainRoutesPostAsyncWithHttpInfo (string domain, InboundRoute body = null)
        {
            // verify the required parameter 'domain' is set
            if (domain == null) throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingEmailDomainsDomainRoutesPost");
            
    
            var path_ = "/api/v1/routing/email/domains/{domain}/routes";
    
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
            if (domain != null) pathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsDomainRoutesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsDomainRoutesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InboundRoute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(response, typeof(InboundRoute)));
            
        }
        
        /// <summary>
        /// Get a route 
        /// </summary>
        /// <param name="domain">email domain</param> 
        /// <param name="id">route ID</param> 
        /// <returns>InboundRoute</returns>
        public InboundRoute RoutingEmailDomainsDomainRoutesIdGet (string domain, string id)
        {
             ApiResponse<InboundRoute> response = RoutingEmailDomainsDomainRoutesIdGetWithHttpInfo(domain, id);
             return response.Data;
        }

        /// <summary>
        /// Get a route 
        /// </summary>
        /// <param name="domain">email domain</param> 
        /// <param name="id">route ID</param> 
        /// <returns>ApiResponse of InboundRoute</returns>
        public ApiResponse< InboundRoute > RoutingEmailDomainsDomainRoutesIdGetWithHttpInfo (string domain, string id)
        {
            
            // verify the required parameter 'domain' is set
            if (domain == null) throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingEmailDomainsDomainRoutesIdGet");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RoutingEmailDomainsDomainRoutesIdGet");
            
    
            var path_ = "/api/v1/routing/email/domains/{domain}/routes/{id}";
    
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
            if (domain != null) pathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
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
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsDomainRoutesIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsDomainRoutesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InboundRoute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(response, typeof(InboundRoute)));
            
        }
    
        /// <summary>
        /// Get a route 
        /// </summary>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>Task of InboundRoute</returns>
        public async System.Threading.Tasks.Task<InboundRoute> RoutingEmailDomainsDomainRoutesIdGetAsync (string domain, string id)
        {
             ApiResponse<InboundRoute> response = await RoutingEmailDomainsDomainRoutesIdGetAsyncWithHttpInfo(domain, id);
             return response.Data;

        }

        /// <summary>
        /// Get a route 
        /// </summary>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundRoute>> RoutingEmailDomainsDomainRoutesIdGetAsyncWithHttpInfo (string domain, string id)
        {
            // verify the required parameter 'domain' is set
            if (domain == null) throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingEmailDomainsDomainRoutesIdGet");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RoutingEmailDomainsDomainRoutesIdGet");
            
    
            var path_ = "/api/v1/routing/email/domains/{domain}/routes/{id}";
    
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
            if (domain != null) pathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
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
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsDomainRoutesIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsDomainRoutesIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InboundRoute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(response, typeof(InboundRoute)));
            
        }
        
        /// <summary>
        /// Update a route 
        /// </summary>
        /// <param name="domain">email domain</param> 
        /// <param name="id">route ID</param> 
        /// <param name="body">Route</param> 
        /// <returns>InboundRoute</returns>
        public InboundRoute RoutingEmailDomainsDomainRoutesIdPut (string domain, string id, InboundRoute body = null)
        {
             ApiResponse<InboundRoute> response = RoutingEmailDomainsDomainRoutesIdPutWithHttpInfo(domain, id, body);
             return response.Data;
        }

        /// <summary>
        /// Update a route 
        /// </summary>
        /// <param name="domain">email domain</param> 
        /// <param name="id">route ID</param> 
        /// <param name="body">Route</param> 
        /// <returns>ApiResponse of InboundRoute</returns>
        public ApiResponse< InboundRoute > RoutingEmailDomainsDomainRoutesIdPutWithHttpInfo (string domain, string id, InboundRoute body = null)
        {
            
            // verify the required parameter 'domain' is set
            if (domain == null) throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingEmailDomainsDomainRoutesIdPut");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RoutingEmailDomainsDomainRoutesIdPut");
            
    
            var path_ = "/api/v1/routing/email/domains/{domain}/routes/{id}";
    
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
            if (domain != null) pathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
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
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsDomainRoutesIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsDomainRoutesIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InboundRoute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(response, typeof(InboundRoute)));
            
        }
    
        /// <summary>
        /// Update a route 
        /// </summary>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <param name="body">Route</param>
        /// <returns>Task of InboundRoute</returns>
        public async System.Threading.Tasks.Task<InboundRoute> RoutingEmailDomainsDomainRoutesIdPutAsync (string domain, string id, InboundRoute body = null)
        {
             ApiResponse<InboundRoute> response = await RoutingEmailDomainsDomainRoutesIdPutAsyncWithHttpInfo(domain, id, body);
             return response.Data;

        }

        /// <summary>
        /// Update a route 
        /// </summary>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <param name="body">Route</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundRoute>> RoutingEmailDomainsDomainRoutesIdPutAsyncWithHttpInfo (string domain, string id, InboundRoute body = null)
        {
            // verify the required parameter 'domain' is set
            if (domain == null) throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingEmailDomainsDomainRoutesIdPut");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RoutingEmailDomainsDomainRoutesIdPut");
            
    
            var path_ = "/api/v1/routing/email/domains/{domain}/routes/{id}";
    
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
            if (domain != null) pathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
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
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsDomainRoutesIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsDomainRoutesIdPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InboundRoute>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(response, typeof(InboundRoute)));
            
        }
        
        /// <summary>
        /// Delete a route 
        /// </summary>
        /// <param name="domain">email domain</param> 
        /// <param name="id">route ID</param> 
        /// <returns>string</returns>
        public string RoutingEmailDomainsDomainRoutesIdDelete (string domain, string id)
        {
             ApiResponse<string> response = RoutingEmailDomainsDomainRoutesIdDeleteWithHttpInfo(domain, id);
             return response.Data;
        }

        /// <summary>
        /// Delete a route 
        /// </summary>
        /// <param name="domain">email domain</param> 
        /// <param name="id">route ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > RoutingEmailDomainsDomainRoutesIdDeleteWithHttpInfo (string domain, string id)
        {
            
            // verify the required parameter 'domain' is set
            if (domain == null) throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingEmailDomainsDomainRoutesIdDelete");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RoutingEmailDomainsDomainRoutesIdDelete");
            
    
            var path_ = "/api/v1/routing/email/domains/{domain}/routes/{id}";
    
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
            if (domain != null) pathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
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
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsDomainRoutesIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsDomainRoutesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a route 
        /// </summary>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RoutingEmailDomainsDomainRoutesIdDeleteAsync (string domain, string id)
        {
             ApiResponse<string> response = await RoutingEmailDomainsDomainRoutesIdDeleteAsyncWithHttpInfo(domain, id);
             return response.Data;

        }

        /// <summary>
        /// Delete a route 
        /// </summary>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> RoutingEmailDomainsDomainRoutesIdDeleteAsyncWithHttpInfo (string domain, string id)
        {
            // verify the required parameter 'domain' is set
            if (domain == null) throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingEmailDomainsDomainRoutesIdDelete");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RoutingEmailDomainsDomainRoutesIdDelete");
            
    
            var path_ = "/api/v1/routing/email/domains/{domain}/routes/{id}";
    
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
            if (domain != null) pathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
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
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsDomainRoutesIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsDomainRoutesIdDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Delete a domain 
        /// </summary>
        /// <param name="id">domain ID</param> 
        /// <returns>string</returns>
        public string RoutingEmailDomainsIdDelete (string id)
        {
             ApiResponse<string> response = RoutingEmailDomainsIdDeleteWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        /// Delete a domain 
        /// </summary>
        /// <param name="id">domain ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > RoutingEmailDomainsIdDeleteWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RoutingEmailDomainsIdDelete");
            
    
            var path_ = "/api/v1/routing/email/domains/{id}";
    
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
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a domain 
        /// </summary>
        /// <param name="id">domain ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RoutingEmailDomainsIdDeleteAsync (string id)
        {
             ApiResponse<string> response = await RoutingEmailDomainsIdDeleteAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        /// Delete a domain 
        /// </summary>
        /// <param name="id">domain ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> RoutingEmailDomainsIdDeleteAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RoutingEmailDomainsIdDelete");
            
    
            var path_ = "/api/v1/routing/email/domains/{id}";
    
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
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingEmailDomainsIdDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get email setup 
        /// </summary>
        /// <returns>EmailSetup</returns>
        public EmailSetup RoutingEmailSetupGet ()
        {
             ApiResponse<EmailSetup> response = RoutingEmailSetupGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get email setup 
        /// </summary>
        /// <returns>ApiResponse of EmailSetup</returns>
        public ApiResponse< EmailSetup > RoutingEmailSetupGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/routing/email/setup";
    
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
                throw new ApiException (statusCode, "Error calling RoutingEmailSetupGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingEmailSetupGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EmailSetup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailSetup) Configuration.ApiClient.Deserialize(response, typeof(EmailSetup)));
            
        }
    
        /// <summary>
        /// Get email setup 
        /// </summary>
        /// <returns>Task of EmailSetup</returns>
        public async System.Threading.Tasks.Task<EmailSetup> RoutingEmailSetupGetAsync ()
        {
             ApiResponse<EmailSetup> response = await RoutingEmailSetupGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get email setup 
        /// </summary>
        /// <returns>Task of ApiResponse (EmailSetup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailSetup>> RoutingEmailSetupGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/routing/email/setup";
    
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
                throw new ApiException (statusCode, "Error calling RoutingEmailSetupGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingEmailSetupGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EmailSetup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailSetup) Configuration.ApiClient.Deserialize(response, typeof(EmailSetup)));
            
        }
        
        /// <summary>
        /// Get list of queues. 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="name">Name</param> 
        /// <param name="active">Active</param> 
        /// <returns>QueueEntityListing</returns>
        public QueueEntityListing RoutingQueuesGet (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null)
        {
             ApiResponse<QueueEntityListing> response = RoutingQueuesGetWithHttpInfo(queueId, pageSize, pageNumber, sortBy, name, active);
             return response.Data;
        }

        /// <summary>
        /// Get list of queues. 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="name">Name</param> 
        /// <param name="active">Active</param> 
        /// <returns>ApiResponse of QueueEntityListing</returns>
        public ApiResponse< QueueEntityListing > RoutingQueuesGetWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesGet");
            
    
            var path_ = "/api/v1/routing/queues";
    
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
            if (queueId != null) pathParams.Add("QueueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (active != null) queryParams.Add("active", Configuration.ApiClient.ParameterToString(active)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling RoutingQueuesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<QueueEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueEntityListing) Configuration.ApiClient.Deserialize(response, typeof(QueueEntityListing)));
            
        }
    
        /// <summary>
        /// Get list of queues. 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="name">Name</param>
        /// <param name="active">Active</param>
        /// <returns>Task of QueueEntityListing</returns>
        public async System.Threading.Tasks.Task<QueueEntityListing> RoutingQueuesGetAsync (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null)
        {
             ApiResponse<QueueEntityListing> response = await RoutingQueuesGetAsyncWithHttpInfo(queueId, pageSize, pageNumber, sortBy, name, active);
             return response.Data;

        }

        /// <summary>
        /// Get list of queues. 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="name">Name</param>
        /// <param name="active">Active</param>
        /// <returns>Task of ApiResponse (QueueEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueueEntityListing>> RoutingQueuesGetAsyncWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesGet");
            
    
            var path_ = "/api/v1/routing/queues";
    
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
            if (queueId != null) pathParams.Add("QueueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (active != null) queryParams.Add("active", Configuration.ApiClient.ParameterToString(active)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling RoutingQueuesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<QueueEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueEntityListing) Configuration.ApiClient.Deserialize(response, typeof(QueueEntityListing)));
            
        }
        
        /// <summary>
        /// Create queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="body">Queue</param> 
        /// <returns>Queue</returns>
        public Queue RoutingQueuesPost (string queueId, Queue body = null)
        {
             ApiResponse<Queue> response = RoutingQueuesPostWithHttpInfo(queueId, body);
             return response.Data;
        }

        /// <summary>
        /// Create queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="body">Queue</param> 
        /// <returns>ApiResponse of Queue</returns>
        public ApiResponse< Queue > RoutingQueuesPostWithHttpInfo (string queueId, Queue body = null)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesPost");
            
    
            var path_ = "/api/v1/routing/queues";
    
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
            if (queueId != null) pathParams.Add("QueueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling RoutingQueuesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Queue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(response, typeof(Queue)));
            
        }
    
        /// <summary>
        /// Create queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue</param>
        /// <returns>Task of Queue</returns>
        public async System.Threading.Tasks.Task<Queue> RoutingQueuesPostAsync (string queueId, Queue body = null)
        {
             ApiResponse<Queue> response = await RoutingQueuesPostAsyncWithHttpInfo(queueId, body);
             return response.Data;

        }

        /// <summary>
        /// Create queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue</param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Queue>> RoutingQueuesPostAsyncWithHttpInfo (string queueId, Queue body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesPost");
            
    
            var path_ = "/api/v1/routing/queues";
    
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
            if (queueId != null) pathParams.Add("QueueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling RoutingQueuesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Queue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(response, typeof(Queue)));
            
        }
        
        /// <summary>
        /// Get details about this queue. 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <returns>Queue</returns>
        public Queue RoutingQueuesQueueidGet (string queueId)
        {
             ApiResponse<Queue> response = RoutingQueuesQueueidGetWithHttpInfo(queueId);
             return response.Data;
        }

        /// <summary>
        /// Get details about this queue. 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <returns>ApiResponse of Queue</returns>
        public ApiResponse< Queue > RoutingQueuesQueueidGetWithHttpInfo (string queueId)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesQueueidGet");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Queue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(response, typeof(Queue)));
            
        }
    
        /// <summary>
        /// Get details about this queue. 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of Queue</returns>
        public async System.Threading.Tasks.Task<Queue> RoutingQueuesQueueidGetAsync (string queueId)
        {
             ApiResponse<Queue> response = await RoutingQueuesQueueidGetAsyncWithHttpInfo(queueId);
             return response.Data;

        }

        /// <summary>
        /// Get details about this queue. 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Queue>> RoutingQueuesQueueidGetAsyncWithHttpInfo (string queueId)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesQueueidGet");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Queue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(response, typeof(Queue)));
            
        }
        
        /// <summary>
        /// Update a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="body">Queue</param> 
        /// <returns>Queue</returns>
        public Queue RoutingQueuesQueueidPut (string queueId, Queue body = null)
        {
             ApiResponse<Queue> response = RoutingQueuesQueueidPutWithHttpInfo(queueId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="body">Queue</param> 
        /// <returns>ApiResponse of Queue</returns>
        public ApiResponse< Queue > RoutingQueuesQueueidPutWithHttpInfo (string queueId, Queue body = null)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesQueueidPut");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Queue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(response, typeof(Queue)));
            
        }
    
        /// <summary>
        /// Update a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue</param>
        /// <returns>Task of Queue</returns>
        public async System.Threading.Tasks.Task<Queue> RoutingQueuesQueueidPutAsync (string queueId, Queue body = null)
        {
             ApiResponse<Queue> response = await RoutingQueuesQueueidPutAsyncWithHttpInfo(queueId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue</param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Queue>> RoutingQueuesQueueidPutAsyncWithHttpInfo (string queueId, Queue body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesQueueidPut");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Queue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(response, typeof(Queue)));
            
        }
        
        /// <summary>
        /// Delete a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <returns>string</returns>
        public string RoutingQueuesQueueidDelete (string queueId)
        {
             ApiResponse<string> response = RoutingQueuesQueueidDeleteWithHttpInfo(queueId);
             return response.Data;
        }

        /// <summary>
        /// Delete a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > RoutingQueuesQueueidDeleteWithHttpInfo (string queueId)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesQueueidDelete");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RoutingQueuesQueueidDeleteAsync (string queueId)
        {
             ApiResponse<string> response = await RoutingQueuesQueueidDeleteAsyncWithHttpInfo(queueId);
             return response.Data;

        }

        /// <summary>
        /// Delete a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> RoutingQueuesQueueidDeleteAsyncWithHttpInfo (string queueId)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesQueueidDelete");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get members in a queue Get the list of members of a queue
        /// </summary>
        /// <param name="queueId"></param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="userId">UserID</param> 
        /// <param name="statusId">Status ID</param> 
        /// <param name="joined">Joined</param> 
        /// <param name="expand">expand</param> 
        /// <returns>QueueMemberEntityListing</returns>
        public QueueMemberEntityListing RoutingQueuesQueueidMembersGet (string queueId, int? pageSize = null, int? pageNumber = null, string userId = null, string statusId = null, bool? joined = null, string expand = null)
        {
             ApiResponse<QueueMemberEntityListing> response = RoutingQueuesQueueidMembersGetWithHttpInfo(queueId, pageSize, pageNumber, userId, statusId, joined, expand);
             return response.Data;
        }

        /// <summary>
        /// Get members in a queue Get the list of members of a queue
        /// </summary>
        /// <param name="queueId"></param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="userId">UserID</param> 
        /// <param name="statusId">Status ID</param> 
        /// <param name="joined">Joined</param> 
        /// <param name="expand">expand</param> 
        /// <returns>ApiResponse of QueueMemberEntityListing</returns>
        public ApiResponse< QueueMemberEntityListing > RoutingQueuesQueueidMembersGetWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string userId = null, string statusId = null, bool? joined = null, string expand = null)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesQueueidMembersGet");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/members";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (userId != null) queryParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (statusId != null) queryParams.Add("statusId", Configuration.ApiClient.ParameterToString(statusId)); // query parameter
            if (joined != null) queryParams.Add("joined", Configuration.ApiClient.ParameterToString(joined)); // query parameter
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
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidMembersGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidMembersGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<QueueMemberEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMemberEntityListing) Configuration.ApiClient.Deserialize(response, typeof(QueueMemberEntityListing)));
            
        }
    
        /// <summary>
        /// Get members in a queue Get the list of members of a queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="userId">UserID</param>
        /// <param name="statusId">Status ID</param>
        /// <param name="joined">Joined</param>
        /// <param name="expand">expand</param>
        /// <returns>Task of QueueMemberEntityListing</returns>
        public async System.Threading.Tasks.Task<QueueMemberEntityListing> RoutingQueuesQueueidMembersGetAsync (string queueId, int? pageSize = null, int? pageNumber = null, string userId = null, string statusId = null, bool? joined = null, string expand = null)
        {
             ApiResponse<QueueMemberEntityListing> response = await RoutingQueuesQueueidMembersGetAsyncWithHttpInfo(queueId, pageSize, pageNumber, userId, statusId, joined, expand);
             return response.Data;

        }

        /// <summary>
        /// Get members in a queue Get the list of members of a queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="userId">UserID</param>
        /// <param name="statusId">Status ID</param>
        /// <param name="joined">Joined</param>
        /// <param name="expand">expand</param>
        /// <returns>Task of ApiResponse (QueueMemberEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueueMemberEntityListing>> RoutingQueuesQueueidMembersGetAsyncWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string userId = null, string statusId = null, bool? joined = null, string expand = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesQueueidMembersGet");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/members";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (userId != null) queryParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (statusId != null) queryParams.Add("statusId", Configuration.ApiClient.ParameterToString(statusId)); // query parameter
            if (joined != null) queryParams.Add("joined", Configuration.ApiClient.ParameterToString(joined)); // query parameter
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
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidMembersGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidMembersGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<QueueMemberEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMemberEntityListing) Configuration.ApiClient.Deserialize(response, typeof(QueueMemberEntityListing)));
            
        }
        
        /// <summary>
        /// Join or unjoin a user to the queue. 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="memberId">Member/User ID</param> 
        /// <param name="body">To join queue ~ \&quot;joined\&quot;:true</param> 
        /// <returns>QueueMember</returns>
        public QueueMember RoutingQueuesQueueidMembersMemberidPut (string queueId, string memberId, QueueMember body = null)
        {
             ApiResponse<QueueMember> response = RoutingQueuesQueueidMembersMemberidPutWithHttpInfo(queueId, memberId, body);
             return response.Data;
        }

        /// <summary>
        /// Join or unjoin a user to the queue. 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="memberId">Member/User ID</param> 
        /// <param name="body">To join queue ~ \&quot;joined\&quot;:true</param> 
        /// <returns>ApiResponse of QueueMember</returns>
        public ApiResponse< QueueMember > RoutingQueuesQueueidMembersMemberidPutWithHttpInfo (string queueId, string memberId, QueueMember body = null)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesQueueidMembersMemberidPut");
            
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling RoutingQueuesQueueidMembersMemberidPut");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/members/{memberId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (memberId != null) pathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidMembersMemberidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidMembersMemberidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<QueueMember>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(response, typeof(QueueMember)));
            
        }
    
        /// <summary>
        /// Join or unjoin a user to the queue. 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member/User ID</param>
        /// <param name="body">To join queue ~ \&quot;joined\&quot;:true</param>
        /// <returns>Task of QueueMember</returns>
        public async System.Threading.Tasks.Task<QueueMember> RoutingQueuesQueueidMembersMemberidPutAsync (string queueId, string memberId, QueueMember body = null)
        {
             ApiResponse<QueueMember> response = await RoutingQueuesQueueidMembersMemberidPutAsyncWithHttpInfo(queueId, memberId, body);
             return response.Data;

        }

        /// <summary>
        /// Join or unjoin a user to the queue. 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member/User ID</param>
        /// <param name="body">To join queue ~ \&quot;joined\&quot;:true</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueueMember>> RoutingQueuesQueueidMembersMemberidPutAsyncWithHttpInfo (string queueId, string memberId, QueueMember body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesQueueidMembersMemberidPut");
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling RoutingQueuesQueueidMembersMemberidPut");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/members/{memberId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (memberId != null) pathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidMembersMemberidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidMembersMemberidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<QueueMember>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(response, typeof(QueueMember)));
            
        }
        
        /// <summary>
        /// Get the members of this queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="expand">expand</param> 
        /// <param name="directMembers">Only get users that are direct members of the queue</param> 
        /// <returns>QueueMember</returns>
        public QueueMember RoutingQueuesQueueidUsersGet (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null)
        {
             ApiResponse<QueueMember> response = RoutingQueuesQueueidUsersGetWithHttpInfo(queueId, pageSize, pageNumber, sortBy, expand, directMembers);
             return response.Data;
        }

        /// <summary>
        /// Get the members of this queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="expand">expand</param> 
        /// <param name="directMembers">Only get users that are direct members of the queue</param> 
        /// <returns>ApiResponse of QueueMember</returns>
        public ApiResponse< QueueMember > RoutingQueuesQueueidUsersGetWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesQueueidUsersGet");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/users";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (directMembers != null) queryParams.Add("directMembers", Configuration.ApiClient.ParameterToString(directMembers)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidUsersGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidUsersGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<QueueMember>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(response, typeof(QueueMember)));
            
        }
    
        /// <summary>
        /// Get the members of this queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="expand">expand</param>
        /// <param name="directMembers">Only get users that are direct members of the queue</param>
        /// <returns>Task of QueueMember</returns>
        public async System.Threading.Tasks.Task<QueueMember> RoutingQueuesQueueidUsersGetAsync (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null)
        {
             ApiResponse<QueueMember> response = await RoutingQueuesQueueidUsersGetAsyncWithHttpInfo(queueId, pageSize, pageNumber, sortBy, expand, directMembers);
             return response.Data;

        }

        /// <summary>
        /// Get the members of this queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="expand">expand</param>
        /// <param name="directMembers">Only get users that are direct members of the queue</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueueMember>> RoutingQueuesQueueidUsersGetAsyncWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesQueueidUsersGet");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/users";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (directMembers != null) queryParams.Add("directMembers", Configuration.ApiClient.ParameterToString(directMembers)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidUsersGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidUsersGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<QueueMember>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(response, typeof(QueueMember)));
            
        }
        
        /// <summary>
        /// Bulk add or delete up to 100 queue members 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="body">Queue Members</param> 
        /// <param name="delete">True to delete queue members</param> 
        /// <returns>QueueMember</returns>
        public QueueMember RoutingQueuesQueueidUsersPost (string queueId, List<QueueMember> body = null, bool? delete = null)
        {
             ApiResponse<QueueMember> response = RoutingQueuesQueueidUsersPostWithHttpInfo(queueId, body, delete);
             return response.Data;
        }

        /// <summary>
        /// Bulk add or delete up to 100 queue members 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="body">Queue Members</param> 
        /// <param name="delete">True to delete queue members</param> 
        /// <returns>ApiResponse of QueueMember</returns>
        public ApiResponse< QueueMember > RoutingQueuesQueueidUsersPostWithHttpInfo (string queueId, List<QueueMember> body = null, bool? delete = null)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesQueueidUsersPost");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/users";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            if (delete != null) queryParams.Add("delete", Configuration.ApiClient.ParameterToString(delete)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidUsersPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidUsersPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<QueueMember>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(response, typeof(QueueMember)));
            
        }
    
        /// <summary>
        /// Bulk add or delete up to 100 queue members 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members</param>
        /// <param name="delete">True to delete queue members</param>
        /// <returns>Task of QueueMember</returns>
        public async System.Threading.Tasks.Task<QueueMember> RoutingQueuesQueueidUsersPostAsync (string queueId, List<QueueMember> body = null, bool? delete = null)
        {
             ApiResponse<QueueMember> response = await RoutingQueuesQueueidUsersPostAsyncWithHttpInfo(queueId, body, delete);
             return response.Data;

        }

        /// <summary>
        /// Bulk add or delete up to 100 queue members 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members</param>
        /// <param name="delete">True to delete queue members</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueueMember>> RoutingQueuesQueueidUsersPostAsyncWithHttpInfo (string queueId, List<QueueMember> body = null, bool? delete = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesQueueidUsersPost");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/users";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            if (delete != null) queryParams.Add("delete", Configuration.ApiClient.ParameterToString(delete)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidUsersPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidUsersPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<QueueMember>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(response, typeof(QueueMember)));
            
        }
        
        /// <summary>
        /// Join or unjoin a set of users for a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="body">Queue Members</param> 
        /// <returns>QueueMember</returns>
        public QueueMember RoutingQueuesQueueidUsersPatch (string queueId, List<QueueMember> body = null)
        {
             ApiResponse<QueueMember> response = RoutingQueuesQueueidUsersPatchWithHttpInfo(queueId, body);
             return response.Data;
        }

        /// <summary>
        /// Join or unjoin a set of users for a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="body">Queue Members</param> 
        /// <returns>ApiResponse of QueueMember</returns>
        public ApiResponse< QueueMember > RoutingQueuesQueueidUsersPatchWithHttpInfo (string queueId, List<QueueMember> body = null)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesQueueidUsersPatch");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/users";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidUsersPatch: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidUsersPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<QueueMember>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(response, typeof(QueueMember)));
            
        }
    
        /// <summary>
        /// Join or unjoin a set of users for a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members</param>
        /// <returns>Task of QueueMember</returns>
        public async System.Threading.Tasks.Task<QueueMember> RoutingQueuesQueueidUsersPatchAsync (string queueId, List<QueueMember> body = null)
        {
             ApiResponse<QueueMember> response = await RoutingQueuesQueueidUsersPatchAsyncWithHttpInfo(queueId, body);
             return response.Data;

        }

        /// <summary>
        /// Join or unjoin a set of users for a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueueMember>> RoutingQueuesQueueidUsersPatchAsyncWithHttpInfo (string queueId, List<QueueMember> body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesQueueidUsersPatch");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/users";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidUsersPatch: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidUsersPatch: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<QueueMember>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(response, typeof(QueueMember)));
            
        }
        
        /// <summary>
        /// Delete queue member 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="memberId">Member ID</param> 
        /// <returns>string</returns>
        public string RoutingQueuesQueueidUsersMemberidDelete (string queueId, string memberId)
        {
             ApiResponse<string> response = RoutingQueuesQueueidUsersMemberidDeleteWithHttpInfo(queueId, memberId);
             return response.Data;
        }

        /// <summary>
        /// Delete queue member 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="memberId">Member ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > RoutingQueuesQueueidUsersMemberidDeleteWithHttpInfo (string queueId, string memberId)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesQueueidUsersMemberidDelete");
            
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling RoutingQueuesQueueidUsersMemberidDelete");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/users/{memberId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
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
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidUsersMemberidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidUsersMemberidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete queue member 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RoutingQueuesQueueidUsersMemberidDeleteAsync (string queueId, string memberId)
        {
             ApiResponse<string> response = await RoutingQueuesQueueidUsersMemberidDeleteAsyncWithHttpInfo(queueId, memberId);
             return response.Data;

        }

        /// <summary>
        /// Delete queue member 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> RoutingQueuesQueueidUsersMemberidDeleteAsyncWithHttpInfo (string queueId, string memberId)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesQueueidUsersMemberidDelete");
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling RoutingQueuesQueueidUsersMemberidDelete");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/users/{memberId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
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
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidUsersMemberidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidUsersMemberidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Update the ring number of joined status for a User in a Queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="memberId">Member ID</param> 
        /// <param name="body">Queue Member</param> 
        /// <returns>QueueMember</returns>
        public QueueMember RoutingQueuesQueueidUsersMemberidPatch (string queueId, string memberId, QueueMember body = null)
        {
             ApiResponse<QueueMember> response = RoutingQueuesQueueidUsersMemberidPatchWithHttpInfo(queueId, memberId, body);
             return response.Data;
        }

        /// <summary>
        /// Update the ring number of joined status for a User in a Queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="memberId">Member ID</param> 
        /// <param name="body">Queue Member</param> 
        /// <returns>ApiResponse of QueueMember</returns>
        public ApiResponse< QueueMember > RoutingQueuesQueueidUsersMemberidPatchWithHttpInfo (string queueId, string memberId, QueueMember body = null)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesQueueidUsersMemberidPatch");
            
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling RoutingQueuesQueueidUsersMemberidPatch");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/users/{memberId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (memberId != null) pathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidUsersMemberidPatch: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidUsersMemberidPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<QueueMember>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(response, typeof(QueueMember)));
            
        }
    
        /// <summary>
        /// Update the ring number of joined status for a User in a Queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Queue Member</param>
        /// <returns>Task of QueueMember</returns>
        public async System.Threading.Tasks.Task<QueueMember> RoutingQueuesQueueidUsersMemberidPatchAsync (string queueId, string memberId, QueueMember body = null)
        {
             ApiResponse<QueueMember> response = await RoutingQueuesQueueidUsersMemberidPatchAsyncWithHttpInfo(queueId, memberId, body);
             return response.Data;

        }

        /// <summary>
        /// Update the ring number of joined status for a User in a Queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Queue Member</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueueMember>> RoutingQueuesQueueidUsersMemberidPatchAsyncWithHttpInfo (string queueId, string memberId, QueueMember body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesQueueidUsersMemberidPatch");
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling RoutingQueuesQueueidUsersMemberidPatch");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/users/{memberId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (memberId != null) pathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidUsersMemberidPatch: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidUsersMemberidPatch: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<QueueMember>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(response, typeof(QueueMember)));
            
        }
        
        /// <summary>
        /// Get the wrap-up codes for a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="codeId">Code ID</param> 
        /// <returns>WrapupCode</returns>
        public WrapupCode RoutingQueuesQueueidWrapupcodesGet (string queueId, string codeId)
        {
             ApiResponse<WrapupCode> response = RoutingQueuesQueueidWrapupcodesGetWithHttpInfo(queueId, codeId);
             return response.Data;
        }

        /// <summary>
        /// Get the wrap-up codes for a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="codeId">Code ID</param> 
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > RoutingQueuesQueueidWrapupcodesGetWithHttpInfo (string queueId, string codeId)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesQueueidWrapupcodesGet");
            
            // verify the required parameter 'codeId' is set
            if (codeId == null) throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingQueuesQueueidWrapupcodesGet");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/wrapupcodes";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (codeId != null) pathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidWrapupcodesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidWrapupcodesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<WrapupCode>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(response, typeof(WrapupCode)));
            
        }
    
        /// <summary>
        /// Get the wrap-up codes for a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> RoutingQueuesQueueidWrapupcodesGetAsync (string queueId, string codeId)
        {
             ApiResponse<WrapupCode> response = await RoutingQueuesQueueidWrapupcodesGetAsyncWithHttpInfo(queueId, codeId);
             return response.Data;

        }

        /// <summary>
        /// Get the wrap-up codes for a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> RoutingQueuesQueueidWrapupcodesGetAsyncWithHttpInfo (string queueId, string codeId)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesQueueidWrapupcodesGet");
            // verify the required parameter 'codeId' is set
            if (codeId == null) throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingQueuesQueueidWrapupcodesGet");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/wrapupcodes";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (codeId != null) pathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidWrapupcodesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidWrapupcodesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<WrapupCode>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(response, typeof(WrapupCode)));
            
        }
        
        /// <summary>
        /// Add up to 100 wrap-up codes to a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="codeId">Code ID</param> 
        /// <param name="body"></param> 
        /// <returns>WrapupCode</returns>
        public WrapupCode RoutingQueuesQueueidWrapupcodesPost (string queueId, string codeId, List<WrapupCode> body = null)
        {
             ApiResponse<WrapupCode> response = RoutingQueuesQueueidWrapupcodesPostWithHttpInfo(queueId, codeId, body);
             return response.Data;
        }

        /// <summary>
        /// Add up to 100 wrap-up codes to a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="codeId">Code ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > RoutingQueuesQueueidWrapupcodesPostWithHttpInfo (string queueId, string codeId, List<WrapupCode> body = null)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesQueueidWrapupcodesPost");
            
            // verify the required parameter 'codeId' is set
            if (codeId == null) throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingQueuesQueueidWrapupcodesPost");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/wrapupcodes";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (codeId != null) pathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidWrapupcodesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidWrapupcodesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<WrapupCode>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(response, typeof(WrapupCode)));
            
        }
    
        /// <summary>
        /// Add up to 100 wrap-up codes to a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <param name="body"></param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> RoutingQueuesQueueidWrapupcodesPostAsync (string queueId, string codeId, List<WrapupCode> body = null)
        {
             ApiResponse<WrapupCode> response = await RoutingQueuesQueueidWrapupcodesPostAsyncWithHttpInfo(queueId, codeId, body);
             return response.Data;

        }

        /// <summary>
        /// Add up to 100 wrap-up codes to a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> RoutingQueuesQueueidWrapupcodesPostAsyncWithHttpInfo (string queueId, string codeId, List<WrapupCode> body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesQueueidWrapupcodesPost");
            // verify the required parameter 'codeId' is set
            if (codeId == null) throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingQueuesQueueidWrapupcodesPost");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/wrapupcodes";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (codeId != null) pathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidWrapupcodesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidWrapupcodesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<WrapupCode>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(response, typeof(WrapupCode)));
            
        }
        
        /// <summary>
        /// Delete a wrap-up code from a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="codeId">Code ID</param> 
        /// <returns>string</returns>
        public string RoutingQueuesQueueidWrapupcodesCodeidDelete (string queueId, string codeId)
        {
             ApiResponse<string> response = RoutingQueuesQueueidWrapupcodesCodeidDeleteWithHttpInfo(queueId, codeId);
             return response.Data;
        }

        /// <summary>
        /// Delete a wrap-up code from a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="codeId">Code ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > RoutingQueuesQueueidWrapupcodesCodeidDeleteWithHttpInfo (string queueId, string codeId)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesQueueidWrapupcodesCodeidDelete");
            
            // verify the required parameter 'codeId' is set
            if (codeId == null) throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingQueuesQueueidWrapupcodesCodeidDelete");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/wrapupcodes/{codeId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (codeId != null) pathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidWrapupcodesCodeidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidWrapupcodesCodeidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a wrap-up code from a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RoutingQueuesQueueidWrapupcodesCodeidDeleteAsync (string queueId, string codeId)
        {
             ApiResponse<string> response = await RoutingQueuesQueueidWrapupcodesCodeidDeleteAsyncWithHttpInfo(queueId, codeId);
             return response.Data;

        }

        /// <summary>
        /// Delete a wrap-up code from a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> RoutingQueuesQueueidWrapupcodesCodeidDeleteAsyncWithHttpInfo (string queueId, string codeId)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingQueuesQueueidWrapupcodesCodeidDelete");
            // verify the required parameter 'codeId' is set
            if (codeId == null) throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingQueuesQueueidWrapupcodesCodeidDelete");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/wrapupcodes/{codeId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (codeId != null) pathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidWrapupcodesCodeidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingQueuesQueueidWrapupcodesCodeidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get the list of skills. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="name">Name</param> 
        /// <returns>SkillEntityListing</returns>
        public SkillEntityListing RoutingSkillsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null)
        {
             ApiResponse<SkillEntityListing> response = RoutingSkillsGetWithHttpInfo(pageSize, pageNumber, sortBy, name);
             return response.Data;
        }

        /// <summary>
        /// Get the list of skills. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="name">Name</param> 
        /// <returns>ApiResponse of SkillEntityListing</returns>
        public ApiResponse< SkillEntityListing > RoutingSkillsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null)
        {
            
    
            var path_ = "/api/v1/routing/skills";
    
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
                throw new ApiException (statusCode, "Error calling RoutingSkillsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingSkillsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SkillEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SkillEntityListing) Configuration.ApiClient.Deserialize(response, typeof(SkillEntityListing)));
            
        }
    
        /// <summary>
        /// Get the list of skills. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="name">Name</param>
        /// <returns>Task of SkillEntityListing</returns>
        public async System.Threading.Tasks.Task<SkillEntityListing> RoutingSkillsGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null)
        {
             ApiResponse<SkillEntityListing> response = await RoutingSkillsGetAsyncWithHttpInfo(pageSize, pageNumber, sortBy, name);
             return response.Data;

        }

        /// <summary>
        /// Get the list of skills. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="name">Name</param>
        /// <returns>Task of ApiResponse (SkillEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SkillEntityListing>> RoutingSkillsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null)
        {
            
    
            var path_ = "/api/v1/routing/skills";
    
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
                throw new ApiException (statusCode, "Error calling RoutingSkillsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingSkillsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SkillEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SkillEntityListing) Configuration.ApiClient.Deserialize(response, typeof(SkillEntityListing)));
            
        }
        
        /// <summary>
        /// Get the utilization settings. 
        /// </summary>
        /// <returns>Utilization</returns>
        public Utilization RoutingUtilizationGet ()
        {
             ApiResponse<Utilization> response = RoutingUtilizationGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get the utilization settings. 
        /// </summary>
        /// <returns>ApiResponse of Utilization</returns>
        public ApiResponse< Utilization > RoutingUtilizationGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/routing/utilization";
    
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
                throw new ApiException (statusCode, "Error calling RoutingUtilizationGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingUtilizationGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Utilization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Utilization) Configuration.ApiClient.Deserialize(response, typeof(Utilization)));
            
        }
    
        /// <summary>
        /// Get the utilization settings. 
        /// </summary>
        /// <returns>Task of Utilization</returns>
        public async System.Threading.Tasks.Task<Utilization> RoutingUtilizationGetAsync ()
        {
             ApiResponse<Utilization> response = await RoutingUtilizationGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get the utilization settings. 
        /// </summary>
        /// <returns>Task of ApiResponse (Utilization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Utilization>> RoutingUtilizationGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/routing/utilization";
    
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
                throw new ApiException (statusCode, "Error calling RoutingUtilizationGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingUtilizationGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Utilization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Utilization) Configuration.ApiClient.Deserialize(response, typeof(Utilization)));
            
        }
        
        /// <summary>
        /// Update the utilization settings. 
        /// </summary>
        /// <param name="body">utilization</param> 
        /// <returns>Utilization</returns>
        public Utilization RoutingUtilizationPut (Utilization body = null)
        {
             ApiResponse<Utilization> response = RoutingUtilizationPutWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Update the utilization settings. 
        /// </summary>
        /// <param name="body">utilization</param> 
        /// <returns>ApiResponse of Utilization</returns>
        public ApiResponse< Utilization > RoutingUtilizationPutWithHttpInfo (Utilization body = null)
        {
            
    
            var path_ = "/api/v1/routing/utilization";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling RoutingUtilizationPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingUtilizationPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Utilization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Utilization) Configuration.ApiClient.Deserialize(response, typeof(Utilization)));
            
        }
    
        /// <summary>
        /// Update the utilization settings. 
        /// </summary>
        /// <param name="body">utilization</param>
        /// <returns>Task of Utilization</returns>
        public async System.Threading.Tasks.Task<Utilization> RoutingUtilizationPutAsync (Utilization body = null)
        {
             ApiResponse<Utilization> response = await RoutingUtilizationPutAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Update the utilization settings. 
        /// </summary>
        /// <param name="body">utilization</param>
        /// <returns>Task of ApiResponse (Utilization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Utilization>> RoutingUtilizationPutAsyncWithHttpInfo (Utilization body = null)
        {
            
    
            var path_ = "/api/v1/routing/utilization";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling RoutingUtilizationPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingUtilizationPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Utilization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Utilization) Configuration.ApiClient.Deserialize(response, typeof(Utilization)));
            
        }
        
        /// <summary>
        /// Delete utilization settings and revert to system defaults. 
        /// </summary>
        /// <returns>string</returns>
        public string RoutingUtilizationDelete ()
        {
             ApiResponse<string> response = RoutingUtilizationDeleteWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Delete utilization settings and revert to system defaults. 
        /// </summary>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > RoutingUtilizationDeleteWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/routing/utilization";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling RoutingUtilizationDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingUtilizationDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete utilization settings and revert to system defaults. 
        /// </summary>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RoutingUtilizationDeleteAsync ()
        {
             ApiResponse<string> response = await RoutingUtilizationDeleteAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Delete utilization settings and revert to system defaults. 
        /// </summary>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> RoutingUtilizationDeleteAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/routing/utilization";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling RoutingUtilizationDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingUtilizationDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get list of wrapup codes. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <returns>WrapupCodeEntityListing</returns>
        public WrapupCodeEntityListing RoutingWrapupcodesGet (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {
             ApiResponse<WrapupCodeEntityListing> response = RoutingWrapupcodesGetWithHttpInfo(pageSize, pageNumber, sortBy);
             return response.Data;
        }

        /// <summary>
        /// Get list of wrapup codes. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <returns>ApiResponse of WrapupCodeEntityListing</returns>
        public ApiResponse< WrapupCodeEntityListing > RoutingWrapupcodesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {
            
    
            var path_ = "/api/v1/routing/wrapupcodes";
    
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
                throw new ApiException (statusCode, "Error calling RoutingWrapupcodesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingWrapupcodesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<WrapupCodeEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCodeEntityListing) Configuration.ApiClient.Deserialize(response, typeof(WrapupCodeEntityListing)));
            
        }
    
        /// <summary>
        /// Get list of wrapup codes. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of WrapupCodeEntityListing</returns>
        public async System.Threading.Tasks.Task<WrapupCodeEntityListing> RoutingWrapupcodesGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {
             ApiResponse<WrapupCodeEntityListing> response = await RoutingWrapupcodesGetAsyncWithHttpInfo(pageSize, pageNumber, sortBy);
             return response.Data;

        }

        /// <summary>
        /// Get list of wrapup codes. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of ApiResponse (WrapupCodeEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCodeEntityListing>> RoutingWrapupcodesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {
            
    
            var path_ = "/api/v1/routing/wrapupcodes";
    
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
                throw new ApiException (statusCode, "Error calling RoutingWrapupcodesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingWrapupcodesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<WrapupCodeEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCodeEntityListing) Configuration.ApiClient.Deserialize(response, typeof(WrapupCodeEntityListing)));
            
        }
        
        /// <summary>
        /// Create a wrap-up code 
        /// </summary>
        /// <param name="body">WrapupCode</param> 
        /// <returns>CallableTimeSet</returns>
        public CallableTimeSet RoutingWrapupcodesPost (WrapupCode body = null)
        {
             ApiResponse<CallableTimeSet> response = RoutingWrapupcodesPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a wrap-up code 
        /// </summary>
        /// <param name="body">WrapupCode</param> 
        /// <returns>ApiResponse of CallableTimeSet</returns>
        public ApiResponse< CallableTimeSet > RoutingWrapupcodesPostWithHttpInfo (WrapupCode body = null)
        {
            
    
            var path_ = "/api/v1/routing/wrapupcodes";
    
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
                throw new ApiException (statusCode, "Error calling RoutingWrapupcodesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingWrapupcodesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CallableTimeSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(response, typeof(CallableTimeSet)));
            
        }
    
        /// <summary>
        /// Create a wrap-up code 
        /// </summary>
        /// <param name="body">WrapupCode</param>
        /// <returns>Task of CallableTimeSet</returns>
        public async System.Threading.Tasks.Task<CallableTimeSet> RoutingWrapupcodesPostAsync (WrapupCode body = null)
        {
             ApiResponse<CallableTimeSet> response = await RoutingWrapupcodesPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a wrap-up code 
        /// </summary>
        /// <param name="body">WrapupCode</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> RoutingWrapupcodesPostAsyncWithHttpInfo (WrapupCode body = null)
        {
            
    
            var path_ = "/api/v1/routing/wrapupcodes";
    
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
                throw new ApiException (statusCode, "Error calling RoutingWrapupcodesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingWrapupcodesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(response, typeof(CallableTimeSet)));
            
        }
        
        /// <summary>
        /// Get details about this wrap-up code. 
        /// </summary>
        /// <param name="codeId">Wrapup Code ID</param> 
        /// <returns>WrapupCode</returns>
        public WrapupCode RoutingWrapupcodesCodeidGet (string codeId)
        {
             ApiResponse<WrapupCode> response = RoutingWrapupcodesCodeidGetWithHttpInfo(codeId);
             return response.Data;
        }

        /// <summary>
        /// Get details about this wrap-up code. 
        /// </summary>
        /// <param name="codeId">Wrapup Code ID</param> 
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > RoutingWrapupcodesCodeidGetWithHttpInfo (string codeId)
        {
            
            // verify the required parameter 'codeId' is set
            if (codeId == null) throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingWrapupcodesCodeidGet");
            
    
            var path_ = "/api/v1/routing/wrapupcodes/{codeId}";
    
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
            if (codeId != null) pathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling RoutingWrapupcodesCodeidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingWrapupcodesCodeidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<WrapupCode>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(response, typeof(WrapupCode)));
            
        }
    
        /// <summary>
        /// Get details about this wrap-up code. 
        /// </summary>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> RoutingWrapupcodesCodeidGetAsync (string codeId)
        {
             ApiResponse<WrapupCode> response = await RoutingWrapupcodesCodeidGetAsyncWithHttpInfo(codeId);
             return response.Data;

        }

        /// <summary>
        /// Get details about this wrap-up code. 
        /// </summary>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> RoutingWrapupcodesCodeidGetAsyncWithHttpInfo (string codeId)
        {
            // verify the required parameter 'codeId' is set
            if (codeId == null) throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingWrapupcodesCodeidGet");
            
    
            var path_ = "/api/v1/routing/wrapupcodes/{codeId}";
    
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
            if (codeId != null) pathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling RoutingWrapupcodesCodeidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingWrapupcodesCodeidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<WrapupCode>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(response, typeof(WrapupCode)));
            
        }
        
        /// <summary>
        /// Update wrap-up code 
        /// </summary>
        /// <param name="codeId">Wrapup Code ID</param> 
        /// <param name="body">WrapupCode</param> 
        /// <returns>WrapupCode</returns>
        public WrapupCode RoutingWrapupcodesCodeidPut (string codeId, WrapupCode body = null)
        {
             ApiResponse<WrapupCode> response = RoutingWrapupcodesCodeidPutWithHttpInfo(codeId, body);
             return response.Data;
        }

        /// <summary>
        /// Update wrap-up code 
        /// </summary>
        /// <param name="codeId">Wrapup Code ID</param> 
        /// <param name="body">WrapupCode</param> 
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > RoutingWrapupcodesCodeidPutWithHttpInfo (string codeId, WrapupCode body = null)
        {
            
            // verify the required parameter 'codeId' is set
            if (codeId == null) throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingWrapupcodesCodeidPut");
            
    
            var path_ = "/api/v1/routing/wrapupcodes/{codeId}";
    
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
            if (codeId != null) pathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling RoutingWrapupcodesCodeidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingWrapupcodesCodeidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<WrapupCode>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(response, typeof(WrapupCode)));
            
        }
    
        /// <summary>
        /// Update wrap-up code 
        /// </summary>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode</param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> RoutingWrapupcodesCodeidPutAsync (string codeId, WrapupCode body = null)
        {
             ApiResponse<WrapupCode> response = await RoutingWrapupcodesCodeidPutAsyncWithHttpInfo(codeId, body);
             return response.Data;

        }

        /// <summary>
        /// Update wrap-up code 
        /// </summary>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> RoutingWrapupcodesCodeidPutAsyncWithHttpInfo (string codeId, WrapupCode body = null)
        {
            // verify the required parameter 'codeId' is set
            if (codeId == null) throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingWrapupcodesCodeidPut");
            
    
            var path_ = "/api/v1/routing/wrapupcodes/{codeId}";
    
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
            if (codeId != null) pathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling RoutingWrapupcodesCodeidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingWrapupcodesCodeidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<WrapupCode>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(response, typeof(WrapupCode)));
            
        }
        
        /// <summary>
        /// Delete wrap-up code 
        /// </summary>
        /// <param name="codeId">Wrapup Code ID</param> 
        /// <returns>string</returns>
        public string RoutingWrapupcodesCodeidDelete (string codeId)
        {
             ApiResponse<string> response = RoutingWrapupcodesCodeidDeleteWithHttpInfo(codeId);
             return response.Data;
        }

        /// <summary>
        /// Delete wrap-up code 
        /// </summary>
        /// <param name="codeId">Wrapup Code ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > RoutingWrapupcodesCodeidDeleteWithHttpInfo (string codeId)
        {
            
            // verify the required parameter 'codeId' is set
            if (codeId == null) throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingWrapupcodesCodeidDelete");
            
    
            var path_ = "/api/v1/routing/wrapupcodes/{codeId}";
    
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
            if (codeId != null) pathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling RoutingWrapupcodesCodeidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingWrapupcodesCodeidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete wrap-up code 
        /// </summary>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RoutingWrapupcodesCodeidDeleteAsync (string codeId)
        {
             ApiResponse<string> response = await RoutingWrapupcodesCodeidDeleteAsyncWithHttpInfo(codeId);
             return response.Data;

        }

        /// <summary>
        /// Delete wrap-up code 
        /// </summary>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> RoutingWrapupcodesCodeidDeleteAsyncWithHttpInfo (string codeId)
        {
            // verify the required parameter 'codeId' is set
            if (codeId == null) throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingWrapupcodesCodeidDelete");
            
    
            var path_ = "/api/v1/routing/wrapupcodes/{codeId}";
    
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
            if (codeId != null) pathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling RoutingWrapupcodesCodeidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RoutingWrapupcodesCodeidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
    }
    
}
