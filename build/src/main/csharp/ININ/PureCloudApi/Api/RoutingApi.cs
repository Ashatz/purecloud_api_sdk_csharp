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
    public interface IRoutingApi
    {
        
        /// <summary>
        /// Get domains
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>InboundDomainEntityListing</returns>
        InboundDomainEntityListing GetEmailDomains ();
  
        /// <summary>
        /// Get domains
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of InboundDomainEntityListing</returns>
        ApiResponse<InboundDomainEntityListing> GetEmailDomainsWithHttpInfo ();

        /// <summary>
        /// Get domains
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of InboundDomainEntityListing</returns>
        System.Threading.Tasks.Task<InboundDomainEntityListing> GetEmailDomainsAsync ();

        /// <summary>
        /// Get domains
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (InboundDomainEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundDomainEntityListing>> GetEmailDomainsAsyncWithHttpInfo ();
        
        /// <summary>
        /// Create a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Domain</param>
        /// <returns>InboundDomain</returns>
        InboundDomain PostEmailDomains (InboundDomain body = null);
  
        /// <summary>
        /// Create a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Domain</param>
        /// <returns>ApiResponse of InboundDomain</returns>
        ApiResponse<InboundDomain> PostEmailDomainsWithHttpInfo (InboundDomain body = null);

        /// <summary>
        /// Create a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Domain</param>
        /// <returns>Task of InboundDomain</returns>
        System.Threading.Tasks.Task<InboundDomain> PostEmailDomainsAsync (InboundDomain body = null);

        /// <summary>
        /// Create a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Domain</param>
        /// <returns>Task of ApiResponse (InboundDomain)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundDomain>> PostEmailDomainsAsyncWithHttpInfo (InboundDomain body = null);
        
        /// <summary>
        /// Get routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <returns>InboundRouteEntityListing</returns>
        InboundRouteEntityListing GetEmailDomainsDomainRoutes (string domain);
  
        /// <summary>
        /// Get routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <returns>ApiResponse of InboundRouteEntityListing</returns>
        ApiResponse<InboundRouteEntityListing> GetEmailDomainsDomainRoutesWithHttpInfo (string domain);

        /// <summary>
        /// Get routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <returns>Task of InboundRouteEntityListing</returns>
        System.Threading.Tasks.Task<InboundRouteEntityListing> GetEmailDomainsDomainRoutesAsync (string domain);

        /// <summary>
        /// Get routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <returns>Task of ApiResponse (InboundRouteEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundRouteEntityListing>> GetEmailDomainsDomainRoutesAsyncWithHttpInfo (string domain);
        
        /// <summary>
        /// Create a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="body">Route</param>
        /// <returns>InboundRoute</returns>
        InboundRoute PostEmailDomainsDomainRoutes (string domain, InboundRoute body = null);
  
        /// <summary>
        /// Create a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="body">Route</param>
        /// <returns>ApiResponse of InboundRoute</returns>
        ApiResponse<InboundRoute> PostEmailDomainsDomainRoutesWithHttpInfo (string domain, InboundRoute body = null);

        /// <summary>
        /// Create a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="body">Route</param>
        /// <returns>Task of InboundRoute</returns>
        System.Threading.Tasks.Task<InboundRoute> PostEmailDomainsDomainRoutesAsync (string domain, InboundRoute body = null);

        /// <summary>
        /// Create a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="body">Route</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundRoute>> PostEmailDomainsDomainRoutesAsyncWithHttpInfo (string domain, InboundRoute body = null);
        
        /// <summary>
        /// Get a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>InboundRoute</returns>
        InboundRoute GetEmailDomainsDomainRoutesId (string domain, string id);
  
        /// <summary>
        /// Get a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>ApiResponse of InboundRoute</returns>
        ApiResponse<InboundRoute> GetEmailDomainsDomainRoutesIdWithHttpInfo (string domain, string id);

        /// <summary>
        /// Get a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>Task of InboundRoute</returns>
        System.Threading.Tasks.Task<InboundRoute> GetEmailDomainsDomainRoutesIdAsync (string domain, string id);

        /// <summary>
        /// Get a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundRoute>> GetEmailDomainsDomainRoutesIdAsyncWithHttpInfo (string domain, string id);
        
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
        InboundRoute PutEmailDomainsDomainRoutesId (string domain, string id, InboundRoute body = null);
  
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
        ApiResponse<InboundRoute> PutEmailDomainsDomainRoutesIdWithHttpInfo (string domain, string id, InboundRoute body = null);

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
        System.Threading.Tasks.Task<InboundRoute> PutEmailDomainsDomainRoutesIdAsync (string domain, string id, InboundRoute body = null);

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
        System.Threading.Tasks.Task<ApiResponse<InboundRoute>> PutEmailDomainsDomainRoutesIdAsyncWithHttpInfo (string domain, string id, InboundRoute body = null);
        
        /// <summary>
        /// Delete a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>string</returns>
        string DeleteEmailDomainsDomainRoutesId (string domain, string id);
  
        /// <summary>
        /// Delete a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteEmailDomainsDomainRoutesIdWithHttpInfo (string domain, string id);

        /// <summary>
        /// Delete a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteEmailDomainsDomainRoutesIdAsync (string domain, string id);

        /// <summary>
        /// Delete a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteEmailDomainsDomainRoutesIdAsyncWithHttpInfo (string domain, string id);
        
        /// <summary>
        /// Delete a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">domain ID</param>
        /// <returns>string</returns>
        string DeleteEmailDomainsId (string id);
  
        /// <summary>
        /// Delete a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">domain ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteEmailDomainsIdWithHttpInfo (string id);

        /// <summary>
        /// Delete a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">domain ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteEmailDomainsIdAsync (string id);

        /// <summary>
        /// Delete a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">domain ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteEmailDomainsIdAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// Get email setup
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>EmailSetup</returns>
        EmailSetup GetEmailSetup ();
  
        /// <summary>
        /// Get email setup
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of EmailSetup</returns>
        ApiResponse<EmailSetup> GetEmailSetupWithHttpInfo ();

        /// <summary>
        /// Get email setup
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of EmailSetup</returns>
        System.Threading.Tasks.Task<EmailSetup> GetEmailSetupAsync ();

        /// <summary>
        /// Get email setup
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (EmailSetup)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailSetup>> GetEmailSetupAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get list of queues.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="name">Name</param>
        /// <param name="active">Active</param>
        /// <returns>QueueEntityListing</returns>
        QueueEntityListing GetQueues (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null);
  
        /// <summary>
        /// Get list of queues.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="name">Name</param>
        /// <param name="active">Active</param>
        /// <returns>ApiResponse of QueueEntityListing</returns>
        ApiResponse<QueueEntityListing> GetQueuesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null);

        /// <summary>
        /// Get list of queues.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="name">Name</param>
        /// <param name="active">Active</param>
        /// <returns>Task of QueueEntityListing</returns>
        System.Threading.Tasks.Task<QueueEntityListing> GetQueuesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null);

        /// <summary>
        /// Get list of queues.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="name">Name</param>
        /// <param name="active">Active</param>
        /// <returns>Task of ApiResponse (QueueEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueEntityListing>> GetQueuesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null);
        
        /// <summary>
        /// Create queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Queue</param>
        /// <returns>Queue</returns>
        Queue PostQueues (Queue body = null);
  
        /// <summary>
        /// Create queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Queue</param>
        /// <returns>ApiResponse of Queue</returns>
        ApiResponse<Queue> PostQueuesWithHttpInfo (Queue body = null);

        /// <summary>
        /// Create queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Queue</param>
        /// <returns>Task of Queue</returns>
        System.Threading.Tasks.Task<Queue> PostQueuesAsync (Queue body = null);

        /// <summary>
        /// Create queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Queue</param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        System.Threading.Tasks.Task<ApiResponse<Queue>> PostQueuesAsyncWithHttpInfo (Queue body = null);
        
        /// <summary>
        /// Get details about this queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Queue</returns>
        Queue GetQueuesQueueId (string queueId);
  
        /// <summary>
        /// Get details about this queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <returns>ApiResponse of Queue</returns>
        ApiResponse<Queue> GetQueuesQueueIdWithHttpInfo (string queueId);

        /// <summary>
        /// Get details about this queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of Queue</returns>
        System.Threading.Tasks.Task<Queue> GetQueuesQueueIdAsync (string queueId);

        /// <summary>
        /// Get details about this queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        System.Threading.Tasks.Task<ApiResponse<Queue>> GetQueuesQueueIdAsyncWithHttpInfo (string queueId);
        
        /// <summary>
        /// Update a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue</param>
        /// <returns>Queue</returns>
        Queue PutQueuesQueueId (string queueId, Queue body = null);
  
        /// <summary>
        /// Update a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue</param>
        /// <returns>ApiResponse of Queue</returns>
        ApiResponse<Queue> PutQueuesQueueIdWithHttpInfo (string queueId, Queue body = null);

        /// <summary>
        /// Update a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue</param>
        /// <returns>Task of Queue</returns>
        System.Threading.Tasks.Task<Queue> PutQueuesQueueIdAsync (string queueId, Queue body = null);

        /// <summary>
        /// Update a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue</param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        System.Threading.Tasks.Task<ApiResponse<Queue>> PutQueuesQueueIdAsyncWithHttpInfo (string queueId, Queue body = null);
        
        /// <summary>
        /// Delete a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="forceDelete"></param>
        /// <returns>string</returns>
        string DeleteQueuesQueueId (string queueId, bool? forceDelete = null);
  
        /// <summary>
        /// Delete a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="forceDelete"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteQueuesQueueIdWithHttpInfo (string queueId, bool? forceDelete = null);

        /// <summary>
        /// Delete a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="forceDelete"></param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteQueuesQueueIdAsync (string queueId, bool? forceDelete = null);

        /// <summary>
        /// Delete a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="forceDelete"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteQueuesQueueIdAsyncWithHttpInfo (string queueId, bool? forceDelete = null);
        
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
        QueueMemberEntityListing GetQueuesQueueIdMembers (string queueId, int? pageSize = null, int? pageNumber = null, string userId = null, string statusId = null, bool? joined = null, string expand = null);
  
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
        ApiResponse<QueueMemberEntityListing> GetQueuesQueueIdMembersWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string userId = null, string statusId = null, bool? joined = null, string expand = null);

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
        System.Threading.Tasks.Task<QueueMemberEntityListing> GetQueuesQueueIdMembersAsync (string queueId, int? pageSize = null, int? pageNumber = null, string userId = null, string statusId = null, bool? joined = null, string expand = null);

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
        System.Threading.Tasks.Task<ApiResponse<QueueMemberEntityListing>> GetQueuesQueueIdMembersAsyncWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string userId = null, string statusId = null, bool? joined = null, string expand = null);
        
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
        QueueMember PutQueuesQueueIdMembersMemberId (string queueId, string memberId, QueueMember body = null);
  
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
        ApiResponse<QueueMember> PutQueuesQueueIdMembersMemberIdWithHttpInfo (string queueId, string memberId, QueueMember body = null);

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
        System.Threading.Tasks.Task<QueueMember> PutQueuesQueueIdMembersMemberIdAsync (string queueId, string memberId, QueueMember body = null);

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
        System.Threading.Tasks.Task<ApiResponse<QueueMember>> PutQueuesQueueIdMembersMemberIdAsyncWithHttpInfo (string queueId, string memberId, QueueMember body = null);
        
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
        QueueMember GetQueuesQueueIdUsers (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null);
  
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
        ApiResponse<QueueMember> GetQueuesQueueIdUsersWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null);

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
        System.Threading.Tasks.Task<QueueMember> GetQueuesQueueIdUsersAsync (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null);

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
        System.Threading.Tasks.Task<ApiResponse<QueueMember>> GetQueuesQueueIdUsersAsyncWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null);
        
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
        QueueMember PostQueuesQueueIdUsers (string queueId, List<QueueMember> body = null, bool? delete = null);
  
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
        ApiResponse<QueueMember> PostQueuesQueueIdUsersWithHttpInfo (string queueId, List<QueueMember> body = null, bool? delete = null);

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
        System.Threading.Tasks.Task<QueueMember> PostQueuesQueueIdUsersAsync (string queueId, List<QueueMember> body = null, bool? delete = null);

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
        System.Threading.Tasks.Task<ApiResponse<QueueMember>> PostQueuesQueueIdUsersAsyncWithHttpInfo (string queueId, List<QueueMember> body = null, bool? delete = null);
        
        /// <summary>
        /// Join or unjoin a set of users for a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members</param>
        /// <returns>QueueMember</returns>
        QueueMember PatchQueuesQueueIdUsers (string queueId, List<QueueMember> body = null);
  
        /// <summary>
        /// Join or unjoin a set of users for a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members</param>
        /// <returns>ApiResponse of QueueMember</returns>
        ApiResponse<QueueMember> PatchQueuesQueueIdUsersWithHttpInfo (string queueId, List<QueueMember> body = null);

        /// <summary>
        /// Join or unjoin a set of users for a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members</param>
        /// <returns>Task of QueueMember</returns>
        System.Threading.Tasks.Task<QueueMember> PatchQueuesQueueIdUsersAsync (string queueId, List<QueueMember> body = null);

        /// <summary>
        /// Join or unjoin a set of users for a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueMember>> PatchQueuesQueueIdUsersAsyncWithHttpInfo (string queueId, List<QueueMember> body = null);
        
        /// <summary>
        /// Delete queue member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>string</returns>
        string DeleteQueuesQueueIdUsersMemberId (string queueId, string memberId);
  
        /// <summary>
        /// Delete queue member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteQueuesQueueIdUsersMemberIdWithHttpInfo (string queueId, string memberId);

        /// <summary>
        /// Delete queue member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteQueuesQueueIdUsersMemberIdAsync (string queueId, string memberId);

        /// <summary>
        /// Delete queue member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteQueuesQueueIdUsersMemberIdAsyncWithHttpInfo (string queueId, string memberId);
        
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
        QueueMember PatchQueuesQueueIdUsersMemberId (string queueId, string memberId, QueueMember body = null);
  
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
        ApiResponse<QueueMember> PatchQueuesQueueIdUsersMemberIdWithHttpInfo (string queueId, string memberId, QueueMember body = null);

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
        System.Threading.Tasks.Task<QueueMember> PatchQueuesQueueIdUsersMemberIdAsync (string queueId, string memberId, QueueMember body = null);

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
        System.Threading.Tasks.Task<ApiResponse<QueueMember>> PatchQueuesQueueIdUsersMemberIdAsyncWithHttpInfo (string queueId, string memberId, QueueMember body = null);
        
        /// <summary>
        /// Get the wrap-up codes for a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>WrapupCode</returns>
        WrapupCode GetQueuesQueueIdWrapupcodes (string queueId, string codeId);
  
        /// <summary>
        /// Get the wrap-up codes for a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> GetQueuesQueueIdWrapupcodesWithHttpInfo (string queueId, string codeId);

        /// <summary>
        /// Get the wrap-up codes for a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> GetQueuesQueueIdWrapupcodesAsync (string queueId, string codeId);

        /// <summary>
        /// Get the wrap-up codes for a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetQueuesQueueIdWrapupcodesAsyncWithHttpInfo (string queueId, string codeId);
        
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
        WrapupCode PostQueuesQueueIdWrapupcodes (string queueId, string codeId, List<WrapupCode> body = null);
  
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
        ApiResponse<WrapupCode> PostQueuesQueueIdWrapupcodesWithHttpInfo (string queueId, string codeId, List<WrapupCode> body = null);

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
        System.Threading.Tasks.Task<WrapupCode> PostQueuesQueueIdWrapupcodesAsync (string queueId, string codeId, List<WrapupCode> body = null);

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
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> PostQueuesQueueIdWrapupcodesAsyncWithHttpInfo (string queueId, string codeId, List<WrapupCode> body = null);
        
        /// <summary>
        /// Delete a wrap-up code from a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>string</returns>
        string DeleteQueuesQueueIdWrapupcodesCodeId (string queueId, string codeId);
  
        /// <summary>
        /// Delete a wrap-up code from a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteQueuesQueueIdWrapupcodesCodeIdWithHttpInfo (string queueId, string codeId);

        /// <summary>
        /// Delete a wrap-up code from a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteQueuesQueueIdWrapupcodesCodeIdAsync (string queueId, string codeId);

        /// <summary>
        /// Delete a wrap-up code from a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteQueuesQueueIdWrapupcodesCodeIdAsyncWithHttpInfo (string queueId, string codeId);
        
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
        SkillEntityListing GetSkills (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null);
  
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
        ApiResponse<SkillEntityListing> GetSkillsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null);

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
        System.Threading.Tasks.Task<SkillEntityListing> GetSkillsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null);

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
        System.Threading.Tasks.Task<ApiResponse<SkillEntityListing>> GetSkillsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null);
        
        /// <summary>
        /// Get the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Utilization</returns>
        Utilization GetUtilization ();
  
        /// <summary>
        /// Get the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of Utilization</returns>
        ApiResponse<Utilization> GetUtilizationWithHttpInfo ();

        /// <summary>
        /// Get the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of Utilization</returns>
        System.Threading.Tasks.Task<Utilization> GetUtilizationAsync ();

        /// <summary>
        /// Get the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (Utilization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Utilization>> GetUtilizationAsyncWithHttpInfo ();
        
        /// <summary>
        /// Update the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">utilization</param>
        /// <returns>Utilization</returns>
        Utilization PutUtilization (Utilization body = null);
  
        /// <summary>
        /// Update the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">utilization</param>
        /// <returns>ApiResponse of Utilization</returns>
        ApiResponse<Utilization> PutUtilizationWithHttpInfo (Utilization body = null);

        /// <summary>
        /// Update the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">utilization</param>
        /// <returns>Task of Utilization</returns>
        System.Threading.Tasks.Task<Utilization> PutUtilizationAsync (Utilization body = null);

        /// <summary>
        /// Update the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">utilization</param>
        /// <returns>Task of ApiResponse (Utilization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Utilization>> PutUtilizationAsyncWithHttpInfo (Utilization body = null);
        
        /// <summary>
        /// Delete utilization settings and revert to system defaults.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>string</returns>
        string DeleteUtilization ();
  
        /// <summary>
        /// Delete utilization settings and revert to system defaults.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteUtilizationWithHttpInfo ();

        /// <summary>
        /// Delete utilization settings and revert to system defaults.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteUtilizationAsync ();

        /// <summary>
        /// Delete utilization settings and revert to system defaults.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteUtilizationAsyncWithHttpInfo ();
        
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
        WrapupCodeEntityListing GetWrapupcodes (int? pageSize = null, int? pageNumber = null, string sortBy = null);
  
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
        ApiResponse<WrapupCodeEntityListing> GetWrapupcodesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null);

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
        System.Threading.Tasks.Task<WrapupCodeEntityListing> GetWrapupcodesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null);

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
        System.Threading.Tasks.Task<ApiResponse<WrapupCodeEntityListing>> GetWrapupcodesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null);
        
        /// <summary>
        /// Create a wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">WrapupCode</param>
        /// <returns>CallableTimeSet</returns>
        CallableTimeSet PostWrapupcodes (WrapupCode body = null);
  
        /// <summary>
        /// Create a wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">WrapupCode</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        ApiResponse<CallableTimeSet> PostWrapupcodesWithHttpInfo (WrapupCode body = null);

        /// <summary>
        /// Create a wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">WrapupCode</param>
        /// <returns>Task of CallableTimeSet</returns>
        System.Threading.Tasks.Task<CallableTimeSet> PostWrapupcodesAsync (WrapupCode body = null);

        /// <summary>
        /// Create a wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">WrapupCode</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> PostWrapupcodesAsyncWithHttpInfo (WrapupCode body = null);
        
        /// <summary>
        /// Get details about this wrap-up code.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>WrapupCode</returns>
        WrapupCode GetWrapupcodesCodeId (string codeId);
  
        /// <summary>
        /// Get details about this wrap-up code.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> GetWrapupcodesCodeIdWithHttpInfo (string codeId);

        /// <summary>
        /// Get details about this wrap-up code.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> GetWrapupcodesCodeIdAsync (string codeId);

        /// <summary>
        /// Get details about this wrap-up code.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetWrapupcodesCodeIdAsyncWithHttpInfo (string codeId);
        
        /// <summary>
        /// Update wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode</param>
        /// <returns>WrapupCode</returns>
        WrapupCode PutWrapupcodesCodeId (string codeId, WrapupCode body = null);
  
        /// <summary>
        /// Update wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> PutWrapupcodesCodeIdWithHttpInfo (string codeId, WrapupCode body = null);

        /// <summary>
        /// Update wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> PutWrapupcodesCodeIdAsync (string codeId, WrapupCode body = null);

        /// <summary>
        /// Update wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> PutWrapupcodesCodeIdAsyncWithHttpInfo (string codeId, WrapupCode body = null);
        
        /// <summary>
        /// Delete wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>string</returns>
        string DeleteWrapupcodesCodeId (string codeId);
  
        /// <summary>
        /// Delete wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteWrapupcodesCodeIdWithHttpInfo (string codeId);

        /// <summary>
        /// Delete wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteWrapupcodesCodeIdAsync (string codeId);

        /// <summary>
        /// Delete wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteWrapupcodesCodeIdAsyncWithHttpInfo (string codeId);
        
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
        public InboundDomainEntityListing GetEmailDomains ()
        {
             ApiResponse<InboundDomainEntityListing> response = GetEmailDomainsWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get domains 
        /// </summary>
        /// <returns>ApiResponse of InboundDomainEntityListing</returns>
        public ApiResponse< InboundDomainEntityListing > GetEmailDomainsWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/routing/email/domains";
    
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
                throw new ApiException (statusCode, "Error calling GetEmailDomains: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEmailDomains: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InboundDomainEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundDomainEntityListing) Configuration.ApiClient.Deserialize(response, typeof(InboundDomainEntityListing)));
            
        }
    
        /// <summary>
        /// Get domains 
        /// </summary>
        /// <returns>Task of InboundDomainEntityListing</returns>
        public async System.Threading.Tasks.Task<InboundDomainEntityListing> GetEmailDomainsAsync ()
        {
             ApiResponse<InboundDomainEntityListing> response = await GetEmailDomainsAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get domains 
        /// </summary>
        /// <returns>Task of ApiResponse (InboundDomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundDomainEntityListing>> GetEmailDomainsAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/routing/email/domains";
    
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
                throw new ApiException (statusCode, "Error calling GetEmailDomains: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEmailDomains: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InboundDomainEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundDomainEntityListing) Configuration.ApiClient.Deserialize(response, typeof(InboundDomainEntityListing)));
            
        }
        
        /// <summary>
        /// Create a domain 
        /// </summary>
        /// <param name="body">Domain</param> 
        /// <returns>InboundDomain</returns>
        public InboundDomain PostEmailDomains (InboundDomain body = null)
        {
             ApiResponse<InboundDomain> response = PostEmailDomainsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a domain 
        /// </summary>
        /// <param name="body">Domain</param> 
        /// <returns>ApiResponse of InboundDomain</returns>
        public ApiResponse< InboundDomain > PostEmailDomainsWithHttpInfo (InboundDomain body = null)
        {
            
    
            var path_ = "/api/v1/routing/email/domains";
    
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
                throw new ApiException (statusCode, "Error calling PostEmailDomains: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEmailDomains: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InboundDomain>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundDomain) Configuration.ApiClient.Deserialize(response, typeof(InboundDomain)));
            
        }
    
        /// <summary>
        /// Create a domain 
        /// </summary>
        /// <param name="body">Domain</param>
        /// <returns>Task of InboundDomain</returns>
        public async System.Threading.Tasks.Task<InboundDomain> PostEmailDomainsAsync (InboundDomain body = null)
        {
             ApiResponse<InboundDomain> response = await PostEmailDomainsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a domain 
        /// </summary>
        /// <param name="body">Domain</param>
        /// <returns>Task of ApiResponse (InboundDomain)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundDomain>> PostEmailDomainsAsyncWithHttpInfo (InboundDomain body = null)
        {
            
    
            var path_ = "/api/v1/routing/email/domains";
    
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
                throw new ApiException (statusCode, "Error calling PostEmailDomains: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEmailDomains: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InboundDomain>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundDomain) Configuration.ApiClient.Deserialize(response, typeof(InboundDomain)));
            
        }
        
        /// <summary>
        /// Get routes 
        /// </summary>
        /// <param name="domain">email domain</param> 
        /// <returns>InboundRouteEntityListing</returns>
        public InboundRouteEntityListing GetEmailDomainsDomainRoutes (string domain)
        {
             ApiResponse<InboundRouteEntityListing> response = GetEmailDomainsDomainRoutesWithHttpInfo(domain);
             return response.Data;
        }

        /// <summary>
        /// Get routes 
        /// </summary>
        /// <param name="domain">email domain</param> 
        /// <returns>ApiResponse of InboundRouteEntityListing</returns>
        public ApiResponse< InboundRouteEntityListing > GetEmailDomainsDomainRoutesWithHttpInfo (string domain)
        {
            
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingApi->GetEmailDomainsDomainRoutes");
            
    
            var path_ = "/api/v1/routing/email/domains/{domain}/routes";
    
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
            if (domain != null) pathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetEmailDomainsDomainRoutes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEmailDomainsDomainRoutes: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InboundRouteEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRouteEntityListing) Configuration.ApiClient.Deserialize(response, typeof(InboundRouteEntityListing)));
            
        }
    
        /// <summary>
        /// Get routes 
        /// </summary>
        /// <param name="domain">email domain</param>
        /// <returns>Task of InboundRouteEntityListing</returns>
        public async System.Threading.Tasks.Task<InboundRouteEntityListing> GetEmailDomainsDomainRoutesAsync (string domain)
        {
             ApiResponse<InboundRouteEntityListing> response = await GetEmailDomainsDomainRoutesAsyncWithHttpInfo(domain);
             return response.Data;

        }

        /// <summary>
        /// Get routes 
        /// </summary>
        /// <param name="domain">email domain</param>
        /// <returns>Task of ApiResponse (InboundRouteEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundRouteEntityListing>> GetEmailDomainsDomainRoutesAsyncWithHttpInfo (string domain)
        {
            // verify the required parameter 'domain' is set
            if (domain == null) throw new ApiException(400, "Missing required parameter 'domain' when calling GetEmailDomainsDomainRoutes");
            
    
            var path_ = "/api/v1/routing/email/domains/{domain}/routes";
    
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
            if (domain != null) pathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetEmailDomainsDomainRoutes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEmailDomainsDomainRoutes: " + response.ErrorMessage, response.ErrorMessage);

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
        public InboundRoute PostEmailDomainsDomainRoutes (string domain, InboundRoute body = null)
        {
             ApiResponse<InboundRoute> response = PostEmailDomainsDomainRoutesWithHttpInfo(domain, body);
             return response.Data;
        }

        /// <summary>
        /// Create a route 
        /// </summary>
        /// <param name="domain">email domain</param> 
        /// <param name="body">Route</param> 
        /// <returns>ApiResponse of InboundRoute</returns>
        public ApiResponse< InboundRoute > PostEmailDomainsDomainRoutesWithHttpInfo (string domain, InboundRoute body = null)
        {
            
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingApi->PostEmailDomainsDomainRoutes");
            
    
            var path_ = "/api/v1/routing/email/domains/{domain}/routes";
    
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
            if (domain != null) pathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PostEmailDomainsDomainRoutes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEmailDomainsDomainRoutes: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<InboundRoute> PostEmailDomainsDomainRoutesAsync (string domain, InboundRoute body = null)
        {
             ApiResponse<InboundRoute> response = await PostEmailDomainsDomainRoutesAsyncWithHttpInfo(domain, body);
             return response.Data;

        }

        /// <summary>
        /// Create a route 
        /// </summary>
        /// <param name="domain">email domain</param>
        /// <param name="body">Route</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundRoute>> PostEmailDomainsDomainRoutesAsyncWithHttpInfo (string domain, InboundRoute body = null)
        {
            // verify the required parameter 'domain' is set
            if (domain == null) throw new ApiException(400, "Missing required parameter 'domain' when calling PostEmailDomainsDomainRoutes");
            
    
            var path_ = "/api/v1/routing/email/domains/{domain}/routes";
    
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
            if (domain != null) pathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PostEmailDomainsDomainRoutes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEmailDomainsDomainRoutes: " + response.ErrorMessage, response.ErrorMessage);

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
        public InboundRoute GetEmailDomainsDomainRoutesId (string domain, string id)
        {
             ApiResponse<InboundRoute> response = GetEmailDomainsDomainRoutesIdWithHttpInfo(domain, id);
             return response.Data;
        }

        /// <summary>
        /// Get a route 
        /// </summary>
        /// <param name="domain">email domain</param> 
        /// <param name="id">route ID</param> 
        /// <returns>ApiResponse of InboundRoute</returns>
        public ApiResponse< InboundRoute > GetEmailDomainsDomainRoutesIdWithHttpInfo (string domain, string id)
        {
            
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingApi->GetEmailDomainsDomainRoutesId");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoutingApi->GetEmailDomainsDomainRoutesId");
            
    
            var path_ = "/api/v1/routing/email/domains/{domain}/routes/{id}";
    
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
            if (domain != null) pathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
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
                throw new ApiException (statusCode, "Error calling GetEmailDomainsDomainRoutesId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEmailDomainsDomainRoutesId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<InboundRoute> GetEmailDomainsDomainRoutesIdAsync (string domain, string id)
        {
             ApiResponse<InboundRoute> response = await GetEmailDomainsDomainRoutesIdAsyncWithHttpInfo(domain, id);
             return response.Data;

        }

        /// <summary>
        /// Get a route 
        /// </summary>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundRoute>> GetEmailDomainsDomainRoutesIdAsyncWithHttpInfo (string domain, string id)
        {
            // verify the required parameter 'domain' is set
            if (domain == null) throw new ApiException(400, "Missing required parameter 'domain' when calling GetEmailDomainsDomainRoutesId");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetEmailDomainsDomainRoutesId");
            
    
            var path_ = "/api/v1/routing/email/domains/{domain}/routes/{id}";
    
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
            if (domain != null) pathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
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
                throw new ApiException (statusCode, "Error calling GetEmailDomainsDomainRoutesId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEmailDomainsDomainRoutesId: " + response.ErrorMessage, response.ErrorMessage);

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
        public InboundRoute PutEmailDomainsDomainRoutesId (string domain, string id, InboundRoute body = null)
        {
             ApiResponse<InboundRoute> response = PutEmailDomainsDomainRoutesIdWithHttpInfo(domain, id, body);
             return response.Data;
        }

        /// <summary>
        /// Update a route 
        /// </summary>
        /// <param name="domain">email domain</param> 
        /// <param name="id">route ID</param> 
        /// <param name="body">Route</param> 
        /// <returns>ApiResponse of InboundRoute</returns>
        public ApiResponse< InboundRoute > PutEmailDomainsDomainRoutesIdWithHttpInfo (string domain, string id, InboundRoute body = null)
        {
            
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingApi->PutEmailDomainsDomainRoutesId");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoutingApi->PutEmailDomainsDomainRoutesId");
            
    
            var path_ = "/api/v1/routing/email/domains/{domain}/routes/{id}";
    
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
            if (domain != null) pathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutEmailDomainsDomainRoutesId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutEmailDomainsDomainRoutesId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<InboundRoute> PutEmailDomainsDomainRoutesIdAsync (string domain, string id, InboundRoute body = null)
        {
             ApiResponse<InboundRoute> response = await PutEmailDomainsDomainRoutesIdAsyncWithHttpInfo(domain, id, body);
             return response.Data;

        }

        /// <summary>
        /// Update a route 
        /// </summary>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <param name="body">Route</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundRoute>> PutEmailDomainsDomainRoutesIdAsyncWithHttpInfo (string domain, string id, InboundRoute body = null)
        {
            // verify the required parameter 'domain' is set
            if (domain == null) throw new ApiException(400, "Missing required parameter 'domain' when calling PutEmailDomainsDomainRoutesId");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PutEmailDomainsDomainRoutesId");
            
    
            var path_ = "/api/v1/routing/email/domains/{domain}/routes/{id}";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutEmailDomainsDomainRoutesId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutEmailDomainsDomainRoutesId: " + response.ErrorMessage, response.ErrorMessage);

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
        public string DeleteEmailDomainsDomainRoutesId (string domain, string id)
        {
             ApiResponse<string> response = DeleteEmailDomainsDomainRoutesIdWithHttpInfo(domain, id);
             return response.Data;
        }

        /// <summary>
        /// Delete a route 
        /// </summary>
        /// <param name="domain">email domain</param> 
        /// <param name="id">route ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteEmailDomainsDomainRoutesIdWithHttpInfo (string domain, string id)
        {
            
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingApi->DeleteEmailDomainsDomainRoutesId");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoutingApi->DeleteEmailDomainsDomainRoutesId");
            
    
            var path_ = "/api/v1/routing/email/domains/{domain}/routes/{id}";
    
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
            if (domain != null) pathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteEmailDomainsDomainRoutesId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEmailDomainsDomainRoutesId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<string> DeleteEmailDomainsDomainRoutesIdAsync (string domain, string id)
        {
             ApiResponse<string> response = await DeleteEmailDomainsDomainRoutesIdAsyncWithHttpInfo(domain, id);
             return response.Data;

        }

        /// <summary>
        /// Delete a route 
        /// </summary>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteEmailDomainsDomainRoutesIdAsyncWithHttpInfo (string domain, string id)
        {
            // verify the required parameter 'domain' is set
            if (domain == null) throw new ApiException(400, "Missing required parameter 'domain' when calling DeleteEmailDomainsDomainRoutesId");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteEmailDomainsDomainRoutesId");
            
    
            var path_ = "/api/v1/routing/email/domains/{domain}/routes/{id}";
    
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
            if (domain != null) pathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteEmailDomainsDomainRoutesId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEmailDomainsDomainRoutesId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Delete a domain 
        /// </summary>
        /// <param name="id">domain ID</param> 
        /// <returns>string</returns>
        public string DeleteEmailDomainsId (string id)
        {
             ApiResponse<string> response = DeleteEmailDomainsIdWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        /// Delete a domain 
        /// </summary>
        /// <param name="id">domain ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteEmailDomainsIdWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoutingApi->DeleteEmailDomainsId");
            
    
            var path_ = "/api/v1/routing/email/domains/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteEmailDomainsId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEmailDomainsId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a domain 
        /// </summary>
        /// <param name="id">domain ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteEmailDomainsIdAsync (string id)
        {
             ApiResponse<string> response = await DeleteEmailDomainsIdAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        /// Delete a domain 
        /// </summary>
        /// <param name="id">domain ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteEmailDomainsIdAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteEmailDomainsId");
            
    
            var path_ = "/api/v1/routing/email/domains/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteEmailDomainsId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEmailDomainsId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get email setup 
        /// </summary>
        /// <returns>EmailSetup</returns>
        public EmailSetup GetEmailSetup ()
        {
             ApiResponse<EmailSetup> response = GetEmailSetupWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get email setup 
        /// </summary>
        /// <returns>ApiResponse of EmailSetup</returns>
        public ApiResponse< EmailSetup > GetEmailSetupWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/routing/email/setup";
    
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
                throw new ApiException (statusCode, "Error calling GetEmailSetup: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEmailSetup: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EmailSetup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailSetup) Configuration.ApiClient.Deserialize(response, typeof(EmailSetup)));
            
        }
    
        /// <summary>
        /// Get email setup 
        /// </summary>
        /// <returns>Task of EmailSetup</returns>
        public async System.Threading.Tasks.Task<EmailSetup> GetEmailSetupAsync ()
        {
             ApiResponse<EmailSetup> response = await GetEmailSetupAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get email setup 
        /// </summary>
        /// <returns>Task of ApiResponse (EmailSetup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailSetup>> GetEmailSetupAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/routing/email/setup";
    
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
                throw new ApiException (statusCode, "Error calling GetEmailSetup: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEmailSetup: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EmailSetup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailSetup) Configuration.ApiClient.Deserialize(response, typeof(EmailSetup)));
            
        }
        
        /// <summary>
        /// Get list of queues. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="name">Name</param> 
        /// <param name="active">Active</param> 
        /// <returns>QueueEntityListing</returns>
        public QueueEntityListing GetQueues (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null)
        {
             ApiResponse<QueueEntityListing> response = GetQueuesWithHttpInfo(pageSize, pageNumber, sortBy, name, active);
             return response.Data;
        }

        /// <summary>
        /// Get list of queues. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="name">Name</param> 
        /// <param name="active">Active</param> 
        /// <returns>ApiResponse of QueueEntityListing</returns>
        public ApiResponse< QueueEntityListing > GetQueuesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null)
        {
            
    
            var path_ = "/api/v1/routing/queues";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetQueues: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetQueues: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<QueueEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueEntityListing) Configuration.ApiClient.Deserialize(response, typeof(QueueEntityListing)));
            
        }
    
        /// <summary>
        /// Get list of queues. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="name">Name</param>
        /// <param name="active">Active</param>
        /// <returns>Task of QueueEntityListing</returns>
        public async System.Threading.Tasks.Task<QueueEntityListing> GetQueuesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null)
        {
             ApiResponse<QueueEntityListing> response = await GetQueuesAsyncWithHttpInfo(pageSize, pageNumber, sortBy, name, active);
             return response.Data;

        }

        /// <summary>
        /// Get list of queues. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="name">Name</param>
        /// <param name="active">Active</param>
        /// <returns>Task of ApiResponse (QueueEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueueEntityListing>> GetQueuesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null)
        {
            
    
            var path_ = "/api/v1/routing/queues";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetQueues: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetQueues: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<QueueEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueEntityListing) Configuration.ApiClient.Deserialize(response, typeof(QueueEntityListing)));
            
        }
        
        /// <summary>
        /// Create queue 
        /// </summary>
        /// <param name="body">Queue</param> 
        /// <returns>Queue</returns>
        public Queue PostQueues (Queue body = null)
        {
             ApiResponse<Queue> response = PostQueuesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create queue 
        /// </summary>
        /// <param name="body">Queue</param> 
        /// <returns>ApiResponse of Queue</returns>
        public ApiResponse< Queue > PostQueuesWithHttpInfo (Queue body = null)
        {
            
    
            var path_ = "/api/v1/routing/queues";
    
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
                throw new ApiException (statusCode, "Error calling PostQueues: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostQueues: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Queue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(response, typeof(Queue)));
            
        }
    
        /// <summary>
        /// Create queue 
        /// </summary>
        /// <param name="body">Queue</param>
        /// <returns>Task of Queue</returns>
        public async System.Threading.Tasks.Task<Queue> PostQueuesAsync (Queue body = null)
        {
             ApiResponse<Queue> response = await PostQueuesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create queue 
        /// </summary>
        /// <param name="body">Queue</param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Queue>> PostQueuesAsyncWithHttpInfo (Queue body = null)
        {
            
    
            var path_ = "/api/v1/routing/queues";
    
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
                throw new ApiException (statusCode, "Error calling PostQueues: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostQueues: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Queue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(response, typeof(Queue)));
            
        }
        
        /// <summary>
        /// Get details about this queue. 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <returns>Queue</returns>
        public Queue GetQueuesQueueId (string queueId)
        {
             ApiResponse<Queue> response = GetQueuesQueueIdWithHttpInfo(queueId);
             return response.Data;
        }

        /// <summary>
        /// Get details about this queue. 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <returns>ApiResponse of Queue</returns>
        public ApiResponse< Queue > GetQueuesQueueIdWithHttpInfo (string queueId)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->GetQueuesQueueId");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetQueuesQueueId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetQueuesQueueId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Queue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(response, typeof(Queue)));
            
        }
    
        /// <summary>
        /// Get details about this queue. 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of Queue</returns>
        public async System.Threading.Tasks.Task<Queue> GetQueuesQueueIdAsync (string queueId)
        {
             ApiResponse<Queue> response = await GetQueuesQueueIdAsyncWithHttpInfo(queueId);
             return response.Data;

        }

        /// <summary>
        /// Get details about this queue. 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Queue>> GetQueuesQueueIdAsyncWithHttpInfo (string queueId)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling GetQueuesQueueId");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetQueuesQueueId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetQueuesQueueId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Queue PutQueuesQueueId (string queueId, Queue body = null)
        {
             ApiResponse<Queue> response = PutQueuesQueueIdWithHttpInfo(queueId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="body">Queue</param> 
        /// <returns>ApiResponse of Queue</returns>
        public ApiResponse< Queue > PutQueuesQueueIdWithHttpInfo (string queueId, Queue body = null)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->PutQueuesQueueId");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutQueuesQueueId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutQueuesQueueId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Queue> PutQueuesQueueIdAsync (string queueId, Queue body = null)
        {
             ApiResponse<Queue> response = await PutQueuesQueueIdAsyncWithHttpInfo(queueId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue</param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Queue>> PutQueuesQueueIdAsyncWithHttpInfo (string queueId, Queue body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling PutQueuesQueueId");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutQueuesQueueId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutQueuesQueueId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Queue>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(response, typeof(Queue)));
            
        }
        
        /// <summary>
        /// Delete a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="forceDelete"></param> 
        /// <returns>string</returns>
        public string DeleteQueuesQueueId (string queueId, bool? forceDelete = null)
        {
             ApiResponse<string> response = DeleteQueuesQueueIdWithHttpInfo(queueId, forceDelete);
             return response.Data;
        }

        /// <summary>
        /// Delete a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="forceDelete"></param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteQueuesQueueIdWithHttpInfo (string queueId, bool? forceDelete = null)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->DeleteQueuesQueueId");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            if (forceDelete != null) queryParams.Add("forceDelete", Configuration.ApiClient.ParameterToString(forceDelete)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteQueuesQueueId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteQueuesQueueId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="forceDelete"></param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteQueuesQueueIdAsync (string queueId, bool? forceDelete = null)
        {
             ApiResponse<string> response = await DeleteQueuesQueueIdAsyncWithHttpInfo(queueId, forceDelete);
             return response.Data;

        }

        /// <summary>
        /// Delete a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="forceDelete"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteQueuesQueueIdAsyncWithHttpInfo (string queueId, bool? forceDelete = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling DeleteQueuesQueueId");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            if (forceDelete != null) queryParams.Add("forceDelete", Configuration.ApiClient.ParameterToString(forceDelete)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteQueuesQueueId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteQueuesQueueId: " + response.ErrorMessage, response.ErrorMessage);

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
        public QueueMemberEntityListing GetQueuesQueueIdMembers (string queueId, int? pageSize = null, int? pageNumber = null, string userId = null, string statusId = null, bool? joined = null, string expand = null)
        {
             ApiResponse<QueueMemberEntityListing> response = GetQueuesQueueIdMembersWithHttpInfo(queueId, pageSize, pageNumber, userId, statusId, joined, expand);
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
        public ApiResponse< QueueMemberEntityListing > GetQueuesQueueIdMembersWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string userId = null, string statusId = null, bool? joined = null, string expand = null)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->GetQueuesQueueIdMembers");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/members";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetQueuesQueueIdMembers: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetQueuesQueueIdMembers: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<QueueMemberEntityListing> GetQueuesQueueIdMembersAsync (string queueId, int? pageSize = null, int? pageNumber = null, string userId = null, string statusId = null, bool? joined = null, string expand = null)
        {
             ApiResponse<QueueMemberEntityListing> response = await GetQueuesQueueIdMembersAsyncWithHttpInfo(queueId, pageSize, pageNumber, userId, statusId, joined, expand);
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
        public async System.Threading.Tasks.Task<ApiResponse<QueueMemberEntityListing>> GetQueuesQueueIdMembersAsyncWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string userId = null, string statusId = null, bool? joined = null, string expand = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling GetQueuesQueueIdMembers");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/members";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetQueuesQueueIdMembers: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetQueuesQueueIdMembers: " + response.ErrorMessage, response.ErrorMessage);

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
        public QueueMember PutQueuesQueueIdMembersMemberId (string queueId, string memberId, QueueMember body = null)
        {
             ApiResponse<QueueMember> response = PutQueuesQueueIdMembersMemberIdWithHttpInfo(queueId, memberId, body);
             return response.Data;
        }

        /// <summary>
        /// Join or unjoin a user to the queue. 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="memberId">Member/User ID</param> 
        /// <param name="body">To join queue ~ \&quot;joined\&quot;:true</param> 
        /// <returns>ApiResponse of QueueMember</returns>
        public ApiResponse< QueueMember > PutQueuesQueueIdMembersMemberIdWithHttpInfo (string queueId, string memberId, QueueMember body = null)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->PutQueuesQueueIdMembersMemberId");
            
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling RoutingApi->PutQueuesQueueIdMembersMemberId");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/members/{memberId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (memberId != null) pathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutQueuesQueueIdMembersMemberId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutQueuesQueueIdMembersMemberId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<QueueMember> PutQueuesQueueIdMembersMemberIdAsync (string queueId, string memberId, QueueMember body = null)
        {
             ApiResponse<QueueMember> response = await PutQueuesQueueIdMembersMemberIdAsyncWithHttpInfo(queueId, memberId, body);
             return response.Data;

        }

        /// <summary>
        /// Join or unjoin a user to the queue. 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member/User ID</param>
        /// <param name="body">To join queue ~ \&quot;joined\&quot;:true</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueueMember>> PutQueuesQueueIdMembersMemberIdAsyncWithHttpInfo (string queueId, string memberId, QueueMember body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling PutQueuesQueueIdMembersMemberId");
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling PutQueuesQueueIdMembersMemberId");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/members/{memberId}";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutQueuesQueueIdMembersMemberId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutQueuesQueueIdMembersMemberId: " + response.ErrorMessage, response.ErrorMessage);

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
        public QueueMember GetQueuesQueueIdUsers (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null)
        {
             ApiResponse<QueueMember> response = GetQueuesQueueIdUsersWithHttpInfo(queueId, pageSize, pageNumber, sortBy, expand, directMembers);
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
        public ApiResponse< QueueMember > GetQueuesQueueIdUsersWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->GetQueuesQueueIdUsers");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/users";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetQueuesQueueIdUsers: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetQueuesQueueIdUsers: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<QueueMember> GetQueuesQueueIdUsersAsync (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null)
        {
             ApiResponse<QueueMember> response = await GetQueuesQueueIdUsersAsyncWithHttpInfo(queueId, pageSize, pageNumber, sortBy, expand, directMembers);
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
        public async System.Threading.Tasks.Task<ApiResponse<QueueMember>> GetQueuesQueueIdUsersAsyncWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling GetQueuesQueueIdUsers");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/users";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetQueuesQueueIdUsers: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetQueuesQueueIdUsers: " + response.ErrorMessage, response.ErrorMessage);

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
        public QueueMember PostQueuesQueueIdUsers (string queueId, List<QueueMember> body = null, bool? delete = null)
        {
             ApiResponse<QueueMember> response = PostQueuesQueueIdUsersWithHttpInfo(queueId, body, delete);
             return response.Data;
        }

        /// <summary>
        /// Bulk add or delete up to 100 queue members 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="body">Queue Members</param> 
        /// <param name="delete">True to delete queue members</param> 
        /// <returns>ApiResponse of QueueMember</returns>
        public ApiResponse< QueueMember > PostQueuesQueueIdUsersWithHttpInfo (string queueId, List<QueueMember> body = null, bool? delete = null)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->PostQueuesQueueIdUsers");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/users";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            if (delete != null) queryParams.Add("delete", Configuration.ApiClient.ParameterToString(delete)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling PostQueuesQueueIdUsers: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostQueuesQueueIdUsers: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<QueueMember> PostQueuesQueueIdUsersAsync (string queueId, List<QueueMember> body = null, bool? delete = null)
        {
             ApiResponse<QueueMember> response = await PostQueuesQueueIdUsersAsyncWithHttpInfo(queueId, body, delete);
             return response.Data;

        }

        /// <summary>
        /// Bulk add or delete up to 100 queue members 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members</param>
        /// <param name="delete">True to delete queue members</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueueMember>> PostQueuesQueueIdUsersAsyncWithHttpInfo (string queueId, List<QueueMember> body = null, bool? delete = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling PostQueuesQueueIdUsers");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/users";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostQueuesQueueIdUsers: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostQueuesQueueIdUsers: " + response.ErrorMessage, response.ErrorMessage);

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
        public QueueMember PatchQueuesQueueIdUsers (string queueId, List<QueueMember> body = null)
        {
             ApiResponse<QueueMember> response = PatchQueuesQueueIdUsersWithHttpInfo(queueId, body);
             return response.Data;
        }

        /// <summary>
        /// Join or unjoin a set of users for a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="body">Queue Members</param> 
        /// <returns>ApiResponse of QueueMember</returns>
        public ApiResponse< QueueMember > PatchQueuesQueueIdUsersWithHttpInfo (string queueId, List<QueueMember> body = null)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->PatchQueuesQueueIdUsers");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/users";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            
            
            
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
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PatchQueuesQueueIdUsers: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchQueuesQueueIdUsers: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<QueueMember> PatchQueuesQueueIdUsersAsync (string queueId, List<QueueMember> body = null)
        {
             ApiResponse<QueueMember> response = await PatchQueuesQueueIdUsersAsyncWithHttpInfo(queueId, body);
             return response.Data;

        }

        /// <summary>
        /// Join or unjoin a set of users for a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueueMember>> PatchQueuesQueueIdUsersAsyncWithHttpInfo (string queueId, List<QueueMember> body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling PatchQueuesQueueIdUsers");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/users";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PatchQueuesQueueIdUsers: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchQueuesQueueIdUsers: " + response.ErrorMessage, response.ErrorMessage);

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
        public string DeleteQueuesQueueIdUsersMemberId (string queueId, string memberId)
        {
             ApiResponse<string> response = DeleteQueuesQueueIdUsersMemberIdWithHttpInfo(queueId, memberId);
             return response.Data;
        }

        /// <summary>
        /// Delete queue member 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="memberId">Member ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteQueuesQueueIdUsersMemberIdWithHttpInfo (string queueId, string memberId)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->DeleteQueuesQueueIdUsersMemberId");
            
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling RoutingApi->DeleteQueuesQueueIdUsersMemberId");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/users/{memberId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (memberId != null) pathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteQueuesQueueIdUsersMemberId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteQueuesQueueIdUsersMemberId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<string> DeleteQueuesQueueIdUsersMemberIdAsync (string queueId, string memberId)
        {
             ApiResponse<string> response = await DeleteQueuesQueueIdUsersMemberIdAsyncWithHttpInfo(queueId, memberId);
             return response.Data;

        }

        /// <summary>
        /// Delete queue member 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteQueuesQueueIdUsersMemberIdAsyncWithHttpInfo (string queueId, string memberId)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling DeleteQueuesQueueIdUsersMemberId");
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling DeleteQueuesQueueIdUsersMemberId");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/users/{memberId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (memberId != null) pathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteQueuesQueueIdUsersMemberId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteQueuesQueueIdUsersMemberId: " + response.ErrorMessage, response.ErrorMessage);

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
        public QueueMember PatchQueuesQueueIdUsersMemberId (string queueId, string memberId, QueueMember body = null)
        {
             ApiResponse<QueueMember> response = PatchQueuesQueueIdUsersMemberIdWithHttpInfo(queueId, memberId, body);
             return response.Data;
        }

        /// <summary>
        /// Update the ring number of joined status for a User in a Queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="memberId">Member ID</param> 
        /// <param name="body">Queue Member</param> 
        /// <returns>ApiResponse of QueueMember</returns>
        public ApiResponse< QueueMember > PatchQueuesQueueIdUsersMemberIdWithHttpInfo (string queueId, string memberId, QueueMember body = null)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->PatchQueuesQueueIdUsersMemberId");
            
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling RoutingApi->PatchQueuesQueueIdUsersMemberId");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/users/{memberId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (memberId != null) pathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            
            
            
            
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
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PatchQueuesQueueIdUsersMemberId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchQueuesQueueIdUsersMemberId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<QueueMember> PatchQueuesQueueIdUsersMemberIdAsync (string queueId, string memberId, QueueMember body = null)
        {
             ApiResponse<QueueMember> response = await PatchQueuesQueueIdUsersMemberIdAsyncWithHttpInfo(queueId, memberId, body);
             return response.Data;

        }

        /// <summary>
        /// Update the ring number of joined status for a User in a Queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Queue Member</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueueMember>> PatchQueuesQueueIdUsersMemberIdAsyncWithHttpInfo (string queueId, string memberId, QueueMember body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling PatchQueuesQueueIdUsersMemberId");
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling PatchQueuesQueueIdUsersMemberId");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/users/{memberId}";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PatchQueuesQueueIdUsersMemberId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchQueuesQueueIdUsersMemberId: " + response.ErrorMessage, response.ErrorMessage);

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
        public WrapupCode GetQueuesQueueIdWrapupcodes (string queueId, string codeId)
        {
             ApiResponse<WrapupCode> response = GetQueuesQueueIdWrapupcodesWithHttpInfo(queueId, codeId);
             return response.Data;
        }

        /// <summary>
        /// Get the wrap-up codes for a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="codeId">Code ID</param> 
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > GetQueuesQueueIdWrapupcodesWithHttpInfo (string queueId, string codeId)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->GetQueuesQueueIdWrapupcodes");
            
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->GetQueuesQueueIdWrapupcodes");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/wrapupcodes";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (codeId != null) pathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetQueuesQueueIdWrapupcodes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetQueuesQueueIdWrapupcodes: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<WrapupCode> GetQueuesQueueIdWrapupcodesAsync (string queueId, string codeId)
        {
             ApiResponse<WrapupCode> response = await GetQueuesQueueIdWrapupcodesAsyncWithHttpInfo(queueId, codeId);
             return response.Data;

        }

        /// <summary>
        /// Get the wrap-up codes for a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetQueuesQueueIdWrapupcodesAsyncWithHttpInfo (string queueId, string codeId)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling GetQueuesQueueIdWrapupcodes");
            // verify the required parameter 'codeId' is set
            if (codeId == null) throw new ApiException(400, "Missing required parameter 'codeId' when calling GetQueuesQueueIdWrapupcodes");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/wrapupcodes";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (codeId != null) pathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetQueuesQueueIdWrapupcodes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetQueuesQueueIdWrapupcodes: " + response.ErrorMessage, response.ErrorMessage);

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
        public WrapupCode PostQueuesQueueIdWrapupcodes (string queueId, string codeId, List<WrapupCode> body = null)
        {
             ApiResponse<WrapupCode> response = PostQueuesQueueIdWrapupcodesWithHttpInfo(queueId, codeId, body);
             return response.Data;
        }

        /// <summary>
        /// Add up to 100 wrap-up codes to a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="codeId">Code ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > PostQueuesQueueIdWrapupcodesWithHttpInfo (string queueId, string codeId, List<WrapupCode> body = null)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->PostQueuesQueueIdWrapupcodes");
            
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->PostQueuesQueueIdWrapupcodes");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/wrapupcodes";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (codeId != null) pathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PostQueuesQueueIdWrapupcodes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostQueuesQueueIdWrapupcodes: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<WrapupCode> PostQueuesQueueIdWrapupcodesAsync (string queueId, string codeId, List<WrapupCode> body = null)
        {
             ApiResponse<WrapupCode> response = await PostQueuesQueueIdWrapupcodesAsyncWithHttpInfo(queueId, codeId, body);
             return response.Data;

        }

        /// <summary>
        /// Add up to 100 wrap-up codes to a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> PostQueuesQueueIdWrapupcodesAsyncWithHttpInfo (string queueId, string codeId, List<WrapupCode> body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling PostQueuesQueueIdWrapupcodes");
            // verify the required parameter 'codeId' is set
            if (codeId == null) throw new ApiException(400, "Missing required parameter 'codeId' when calling PostQueuesQueueIdWrapupcodes");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/wrapupcodes";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostQueuesQueueIdWrapupcodes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostQueuesQueueIdWrapupcodes: " + response.ErrorMessage, response.ErrorMessage);

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
        public string DeleteQueuesQueueIdWrapupcodesCodeId (string queueId, string codeId)
        {
             ApiResponse<string> response = DeleteQueuesQueueIdWrapupcodesCodeIdWithHttpInfo(queueId, codeId);
             return response.Data;
        }

        /// <summary>
        /// Delete a wrap-up code from a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param> 
        /// <param name="codeId">Code ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteQueuesQueueIdWrapupcodesCodeIdWithHttpInfo (string queueId, string codeId)
        {
            
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->DeleteQueuesQueueIdWrapupcodesCodeId");
            
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->DeleteQueuesQueueIdWrapupcodesCodeId");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/wrapupcodes/{codeId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (codeId != null) pathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteQueuesQueueIdWrapupcodesCodeId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteQueuesQueueIdWrapupcodesCodeId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<string> DeleteQueuesQueueIdWrapupcodesCodeIdAsync (string queueId, string codeId)
        {
             ApiResponse<string> response = await DeleteQueuesQueueIdWrapupcodesCodeIdAsyncWithHttpInfo(queueId, codeId);
             return response.Data;

        }

        /// <summary>
        /// Delete a wrap-up code from a queue 
        /// </summary>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteQueuesQueueIdWrapupcodesCodeIdAsyncWithHttpInfo (string queueId, string codeId)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null) throw new ApiException(400, "Missing required parameter 'queueId' when calling DeleteQueuesQueueIdWrapupcodesCodeId");
            // verify the required parameter 'codeId' is set
            if (codeId == null) throw new ApiException(400, "Missing required parameter 'codeId' when calling DeleteQueuesQueueIdWrapupcodesCodeId");
            
    
            var path_ = "/api/v1/routing/queues/{queueId}/wrapupcodes/{codeId}";
    
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
            if (queueId != null) pathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (codeId != null) pathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteQueuesQueueIdWrapupcodesCodeId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteQueuesQueueIdWrapupcodesCodeId: " + response.ErrorMessage, response.ErrorMessage);

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
        public SkillEntityListing GetSkills (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null)
        {
             ApiResponse<SkillEntityListing> response = GetSkillsWithHttpInfo(pageSize, pageNumber, sortBy, name);
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
        public ApiResponse< SkillEntityListing > GetSkillsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null)
        {
            
    
            var path_ = "/api/v1/routing/skills";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSkills: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSkills: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<SkillEntityListing> GetSkillsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null)
        {
             ApiResponse<SkillEntityListing> response = await GetSkillsAsyncWithHttpInfo(pageSize, pageNumber, sortBy, name);
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
        public async System.Threading.Tasks.Task<ApiResponse<SkillEntityListing>> GetSkillsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null)
        {
            
    
            var path_ = "/api/v1/routing/skills";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSkills: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSkills: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SkillEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SkillEntityListing) Configuration.ApiClient.Deserialize(response, typeof(SkillEntityListing)));
            
        }
        
        /// <summary>
        /// Get the utilization settings. 
        /// </summary>
        /// <returns>Utilization</returns>
        public Utilization GetUtilization ()
        {
             ApiResponse<Utilization> response = GetUtilizationWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get the utilization settings. 
        /// </summary>
        /// <returns>ApiResponse of Utilization</returns>
        public ApiResponse< Utilization > GetUtilizationWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/routing/utilization";
    
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
                throw new ApiException (statusCode, "Error calling GetUtilization: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUtilization: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Utilization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Utilization) Configuration.ApiClient.Deserialize(response, typeof(Utilization)));
            
        }
    
        /// <summary>
        /// Get the utilization settings. 
        /// </summary>
        /// <returns>Task of Utilization</returns>
        public async System.Threading.Tasks.Task<Utilization> GetUtilizationAsync ()
        {
             ApiResponse<Utilization> response = await GetUtilizationAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get the utilization settings. 
        /// </summary>
        /// <returns>Task of ApiResponse (Utilization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Utilization>> GetUtilizationAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/routing/utilization";
    
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
                throw new ApiException (statusCode, "Error calling GetUtilization: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUtilization: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Utilization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Utilization) Configuration.ApiClient.Deserialize(response, typeof(Utilization)));
            
        }
        
        /// <summary>
        /// Update the utilization settings. 
        /// </summary>
        /// <param name="body">utilization</param> 
        /// <returns>Utilization</returns>
        public Utilization PutUtilization (Utilization body = null)
        {
             ApiResponse<Utilization> response = PutUtilizationWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Update the utilization settings. 
        /// </summary>
        /// <param name="body">utilization</param> 
        /// <returns>ApiResponse of Utilization</returns>
        public ApiResponse< Utilization > PutUtilizationWithHttpInfo (Utilization body = null)
        {
            
    
            var path_ = "/api/v1/routing/utilization";
    
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
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutUtilization: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutUtilization: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Utilization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Utilization) Configuration.ApiClient.Deserialize(response, typeof(Utilization)));
            
        }
    
        /// <summary>
        /// Update the utilization settings. 
        /// </summary>
        /// <param name="body">utilization</param>
        /// <returns>Task of Utilization</returns>
        public async System.Threading.Tasks.Task<Utilization> PutUtilizationAsync (Utilization body = null)
        {
             ApiResponse<Utilization> response = await PutUtilizationAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Update the utilization settings. 
        /// </summary>
        /// <param name="body">utilization</param>
        /// <returns>Task of ApiResponse (Utilization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Utilization>> PutUtilizationAsyncWithHttpInfo (Utilization body = null)
        {
            
    
            var path_ = "/api/v1/routing/utilization";
    
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
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutUtilization: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutUtilization: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Utilization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Utilization) Configuration.ApiClient.Deserialize(response, typeof(Utilization)));
            
        }
        
        /// <summary>
        /// Delete utilization settings and revert to system defaults. 
        /// </summary>
        /// <returns>string</returns>
        public string DeleteUtilization ()
        {
             ApiResponse<string> response = DeleteUtilizationWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Delete utilization settings and revert to system defaults. 
        /// </summary>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteUtilizationWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/routing/utilization";
    
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
                throw new ApiException (statusCode, "Error calling DeleteUtilization: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteUtilization: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete utilization settings and revert to system defaults. 
        /// </summary>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteUtilizationAsync ()
        {
             ApiResponse<string> response = await DeleteUtilizationAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Delete utilization settings and revert to system defaults. 
        /// </summary>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteUtilizationAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/routing/utilization";
    
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
                throw new ApiException (statusCode, "Error calling DeleteUtilization: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteUtilization: " + response.ErrorMessage, response.ErrorMessage);

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
        public WrapupCodeEntityListing GetWrapupcodes (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {
             ApiResponse<WrapupCodeEntityListing> response = GetWrapupcodesWithHttpInfo(pageSize, pageNumber, sortBy);
             return response.Data;
        }

        /// <summary>
        /// Get list of wrapup codes. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <returns>ApiResponse of WrapupCodeEntityListing</returns>
        public ApiResponse< WrapupCodeEntityListing > GetWrapupcodesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {
            
    
            var path_ = "/api/v1/routing/wrapupcodes";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetWrapupcodes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetWrapupcodes: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<WrapupCodeEntityListing> GetWrapupcodesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {
             ApiResponse<WrapupCodeEntityListing> response = await GetWrapupcodesAsyncWithHttpInfo(pageSize, pageNumber, sortBy);
             return response.Data;

        }

        /// <summary>
        /// Get list of wrapup codes. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of ApiResponse (WrapupCodeEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCodeEntityListing>> GetWrapupcodesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {
            
    
            var path_ = "/api/v1/routing/wrapupcodes";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetWrapupcodes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetWrapupcodes: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<WrapupCodeEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCodeEntityListing) Configuration.ApiClient.Deserialize(response, typeof(WrapupCodeEntityListing)));
            
        }
        
        /// <summary>
        /// Create a wrap-up code 
        /// </summary>
        /// <param name="body">WrapupCode</param> 
        /// <returns>CallableTimeSet</returns>
        public CallableTimeSet PostWrapupcodes (WrapupCode body = null)
        {
             ApiResponse<CallableTimeSet> response = PostWrapupcodesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a wrap-up code 
        /// </summary>
        /// <param name="body">WrapupCode</param> 
        /// <returns>ApiResponse of CallableTimeSet</returns>
        public ApiResponse< CallableTimeSet > PostWrapupcodesWithHttpInfo (WrapupCode body = null)
        {
            
    
            var path_ = "/api/v1/routing/wrapupcodes";
    
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
                throw new ApiException (statusCode, "Error calling PostWrapupcodes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostWrapupcodes: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CallableTimeSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(response, typeof(CallableTimeSet)));
            
        }
    
        /// <summary>
        /// Create a wrap-up code 
        /// </summary>
        /// <param name="body">WrapupCode</param>
        /// <returns>Task of CallableTimeSet</returns>
        public async System.Threading.Tasks.Task<CallableTimeSet> PostWrapupcodesAsync (WrapupCode body = null)
        {
             ApiResponse<CallableTimeSet> response = await PostWrapupcodesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a wrap-up code 
        /// </summary>
        /// <param name="body">WrapupCode</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> PostWrapupcodesAsyncWithHttpInfo (WrapupCode body = null)
        {
            
    
            var path_ = "/api/v1/routing/wrapupcodes";
    
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
                throw new ApiException (statusCode, "Error calling PostWrapupcodes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostWrapupcodes: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(response, typeof(CallableTimeSet)));
            
        }
        
        /// <summary>
        /// Get details about this wrap-up code. 
        /// </summary>
        /// <param name="codeId">Wrapup Code ID</param> 
        /// <returns>WrapupCode</returns>
        public WrapupCode GetWrapupcodesCodeId (string codeId)
        {
             ApiResponse<WrapupCode> response = GetWrapupcodesCodeIdWithHttpInfo(codeId);
             return response.Data;
        }

        /// <summary>
        /// Get details about this wrap-up code. 
        /// </summary>
        /// <param name="codeId">Wrapup Code ID</param> 
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > GetWrapupcodesCodeIdWithHttpInfo (string codeId)
        {
            
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->GetWrapupcodesCodeId");
            
    
            var path_ = "/api/v1/routing/wrapupcodes/{codeId}";
    
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
            if (codeId != null) pathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetWrapupcodesCodeId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetWrapupcodesCodeId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<WrapupCode>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(response, typeof(WrapupCode)));
            
        }
    
        /// <summary>
        /// Get details about this wrap-up code. 
        /// </summary>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> GetWrapupcodesCodeIdAsync (string codeId)
        {
             ApiResponse<WrapupCode> response = await GetWrapupcodesCodeIdAsyncWithHttpInfo(codeId);
             return response.Data;

        }

        /// <summary>
        /// Get details about this wrap-up code. 
        /// </summary>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetWrapupcodesCodeIdAsyncWithHttpInfo (string codeId)
        {
            // verify the required parameter 'codeId' is set
            if (codeId == null) throw new ApiException(400, "Missing required parameter 'codeId' when calling GetWrapupcodesCodeId");
            
    
            var path_ = "/api/v1/routing/wrapupcodes/{codeId}";
    
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
            if (codeId != null) pathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetWrapupcodesCodeId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetWrapupcodesCodeId: " + response.ErrorMessage, response.ErrorMessage);

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
        public WrapupCode PutWrapupcodesCodeId (string codeId, WrapupCode body = null)
        {
             ApiResponse<WrapupCode> response = PutWrapupcodesCodeIdWithHttpInfo(codeId, body);
             return response.Data;
        }

        /// <summary>
        /// Update wrap-up code 
        /// </summary>
        /// <param name="codeId">Wrapup Code ID</param> 
        /// <param name="body">WrapupCode</param> 
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > PutWrapupcodesCodeIdWithHttpInfo (string codeId, WrapupCode body = null)
        {
            
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->PutWrapupcodesCodeId");
            
    
            var path_ = "/api/v1/routing/wrapupcodes/{codeId}";
    
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
            if (codeId != null) pathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutWrapupcodesCodeId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutWrapupcodesCodeId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<WrapupCode> PutWrapupcodesCodeIdAsync (string codeId, WrapupCode body = null)
        {
             ApiResponse<WrapupCode> response = await PutWrapupcodesCodeIdAsyncWithHttpInfo(codeId, body);
             return response.Data;

        }

        /// <summary>
        /// Update wrap-up code 
        /// </summary>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> PutWrapupcodesCodeIdAsyncWithHttpInfo (string codeId, WrapupCode body = null)
        {
            // verify the required parameter 'codeId' is set
            if (codeId == null) throw new ApiException(400, "Missing required parameter 'codeId' when calling PutWrapupcodesCodeId");
            
    
            var path_ = "/api/v1/routing/wrapupcodes/{codeId}";
    
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
            if (codeId != null) pathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutWrapupcodesCodeId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutWrapupcodesCodeId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<WrapupCode>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(response, typeof(WrapupCode)));
            
        }
        
        /// <summary>
        /// Delete wrap-up code 
        /// </summary>
        /// <param name="codeId">Wrapup Code ID</param> 
        /// <returns>string</returns>
        public string DeleteWrapupcodesCodeId (string codeId)
        {
             ApiResponse<string> response = DeleteWrapupcodesCodeIdWithHttpInfo(codeId);
             return response.Data;
        }

        /// <summary>
        /// Delete wrap-up code 
        /// </summary>
        /// <param name="codeId">Wrapup Code ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteWrapupcodesCodeIdWithHttpInfo (string codeId)
        {
            
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->DeleteWrapupcodesCodeId");
            
    
            var path_ = "/api/v1/routing/wrapupcodes/{codeId}";
    
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
            if (codeId != null) pathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteWrapupcodesCodeId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteWrapupcodesCodeId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete wrap-up code 
        /// </summary>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteWrapupcodesCodeIdAsync (string codeId)
        {
             ApiResponse<string> response = await DeleteWrapupcodesCodeIdAsyncWithHttpInfo(codeId);
             return response.Data;

        }

        /// <summary>
        /// Delete wrap-up code 
        /// </summary>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteWrapupcodesCodeIdAsyncWithHttpInfo (string codeId)
        {
            // verify the required parameter 'codeId' is set
            if (codeId == null) throw new ApiException(400, "Missing required parameter 'codeId' when calling DeleteWrapupcodesCodeId");
            
    
            var path_ = "/api/v1/routing/wrapupcodes/{codeId}";
    
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
            if (codeId != null) pathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteWrapupcodesCodeId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteWrapupcodesCodeId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
    }
    
}
