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
    public interface IRoutingApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Get routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <returns>InboundRouteEntityListing</returns>
        InboundRouteEntityListing RoutingEmailDomainsDomainRoutesGet (string domain);

        /// <summary>
        /// Get routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <returns>ApiResponse of InboundRouteEntityListing</returns>
        ApiResponse<InboundRouteEntityListing> RoutingEmailDomainsDomainRoutesGetWithHttpInfo (string domain);
        /// <summary>
        /// Delete a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RoutingEmailDomainsDomainRoutesIdDeleteWithHttpInfo (string domain, string id);
        /// <summary>
        /// Get a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>ApiResponse of InboundRoute</returns>
        ApiResponse<InboundRoute> RoutingEmailDomainsDomainRoutesIdGetWithHttpInfo (string domain, string id);
        /// <summary>
        /// Update a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>InboundRoute</returns>
        InboundRoute RoutingEmailDomainsDomainRoutesIdPut (string domain, string id, InboundRoute body = null);

        /// <summary>
        /// Update a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>ApiResponse of InboundRoute</returns>
        ApiResponse<InboundRoute> RoutingEmailDomainsDomainRoutesIdPutWithHttpInfo (string domain, string id, InboundRoute body = null);
        /// <summary>
        /// Create a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>InboundRoute</returns>
        InboundRoute RoutingEmailDomainsDomainRoutesPost (string domain, InboundRoute body = null);

        /// <summary>
        /// Create a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>ApiResponse of InboundRoute</returns>
        ApiResponse<InboundRoute> RoutingEmailDomainsDomainRoutesPostWithHttpInfo (string domain, InboundRoute body = null);
        /// <summary>
        /// Get domains
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InboundDomainEntityListing</returns>
        InboundDomainEntityListing RoutingEmailDomainsGet ();

        /// <summary>
        /// Get domains
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InboundDomainEntityListing</returns>
        ApiResponse<InboundDomainEntityListing> RoutingEmailDomainsGetWithHttpInfo ();
        /// <summary>
        /// Delete a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">domain ID</param>
        /// <returns>string</returns>
        string RoutingEmailDomainsIdDelete (string id);

        /// <summary>
        /// Delete a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">domain ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RoutingEmailDomainsIdDeleteWithHttpInfo (string id);
        /// <summary>
        /// Create a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Domain (optional)</param>
        /// <returns>InboundDomain</returns>
        InboundDomain RoutingEmailDomainsPost (InboundDomain body = null);

        /// <summary>
        /// Create a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Domain (optional)</param>
        /// <returns>ApiResponse of InboundDomain</returns>
        ApiResponse<InboundDomain> RoutingEmailDomainsPostWithHttpInfo (InboundDomain body = null);
        /// <summary>
        /// Get email setup
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EmailSetup</returns>
        EmailSetup RoutingEmailSetupGet ();

        /// <summary>
        /// Get email setup
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EmailSetup</returns>
        ApiResponse<EmailSetup> RoutingEmailSetupGetWithHttpInfo ();
        /// <summary>
        /// Get list of queues.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="active">Active (optional)</param>
        /// <returns>QueueEntityListing</returns>
        QueueEntityListing RoutingQueuesGet (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null);

        /// <summary>
        /// Get list of queues.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="active">Active (optional)</param>
        /// <returns>ApiResponse of QueueEntityListing</returns>
        ApiResponse<QueueEntityListing> RoutingQueuesGetWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null);
        /// <summary>
        /// Create queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Queue</returns>
        Queue RoutingQueuesPost (string queueId, Queue body = null);

        /// <summary>
        /// Create queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>ApiResponse of Queue</returns>
        ApiResponse<Queue> RoutingQueuesPostWithHttpInfo (string queueId, Queue body = null);
        /// <summary>
        /// Delete a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>string</returns>
        string RoutingQueuesQueueidDelete (string queueId);

        /// <summary>
        /// Delete a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RoutingQueuesQueueidDeleteWithHttpInfo (string queueId);
        /// <summary>
        /// Get details about this queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Queue</returns>
        Queue RoutingQueuesQueueidGet (string queueId);

        /// <summary>
        /// Get details about this queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>ApiResponse of Queue</returns>
        ApiResponse<Queue> RoutingQueuesQueueidGetWithHttpInfo (string queueId);
        /// <summary>
        /// Get members in a queue
        /// </summary>
        /// <remarks>
        /// Get the list of members of a queue
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId"></param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="userId">UserID (optional)</param>
        /// <param name="statusId">Status ID (optional)</param>
        /// <param name="joined">Joined (optional)</param>
        /// <param name="expand">expand (optional)</param>
        /// <returns>QueueMemberEntityListing</returns>
        QueueMemberEntityListing RoutingQueuesQueueidMembersGet (string queueId, int? pageSize = null, int? pageNumber = null, string userId = null, string statusId = null, bool? joined = null, string expand = null);

        /// <summary>
        /// Get members in a queue
        /// </summary>
        /// <remarks>
        /// Get the list of members of a queue
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId"></param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="userId">UserID (optional)</param>
        /// <param name="statusId">Status ID (optional)</param>
        /// <param name="joined">Joined (optional)</param>
        /// <param name="expand">expand (optional)</param>
        /// <returns>ApiResponse of QueueMemberEntityListing</returns>
        ApiResponse<QueueMemberEntityListing> RoutingQueuesQueueidMembersGetWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string userId = null, string statusId = null, bool? joined = null, string expand = null);
        /// <summary>
        /// Join or unjoin a user to the queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member/User ID</param>
        /// <param name="body">To join queue ~ \&quot;joined\&quot;:true (optional)</param>
        /// <returns>QueueMember</returns>
        QueueMember RoutingQueuesQueueidMembersMemberidPut (string queueId, string memberId, QueueMember body = null);

        /// <summary>
        /// Join or unjoin a user to the queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member/User ID</param>
        /// <param name="body">To join queue ~ \&quot;joined\&quot;:true (optional)</param>
        /// <returns>ApiResponse of QueueMember</returns>
        ApiResponse<QueueMember> RoutingQueuesQueueidMembersMemberidPutWithHttpInfo (string queueId, string memberId, QueueMember body = null);
        /// <summary>
        /// Update a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Queue</returns>
        Queue RoutingQueuesQueueidPut (string queueId, Queue body = null);

        /// <summary>
        /// Update a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>ApiResponse of Queue</returns>
        ApiResponse<Queue> RoutingQueuesQueueidPutWithHttpInfo (string queueId, Queue body = null);
        /// <summary>
        /// Get the members of this queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="directMembers">Only get users that are direct members of the queue (optional, default to false)</param>
        /// <returns>QueueMember</returns>
        QueueMember RoutingQueuesQueueidUsersGet (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null);

        /// <summary>
        /// Get the members of this queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="directMembers">Only get users that are direct members of the queue (optional, default to false)</param>
        /// <returns>ApiResponse of QueueMember</returns>
        ApiResponse<QueueMember> RoutingQueuesQueueidUsersGetWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null);
        /// <summary>
        /// Delete queue member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RoutingQueuesQueueidUsersMemberidDeleteWithHttpInfo (string queueId, string memberId);
        /// <summary>
        /// Update the ring number of joined status for a User in a Queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Queue Member (optional)</param>
        /// <returns>QueueMember</returns>
        QueueMember RoutingQueuesQueueidUsersMemberidPatch (string queueId, string memberId, QueueMember body = null);

        /// <summary>
        /// Update the ring number of joined status for a User in a Queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Queue Member (optional)</param>
        /// <returns>ApiResponse of QueueMember</returns>
        ApiResponse<QueueMember> RoutingQueuesQueueidUsersMemberidPatchWithHttpInfo (string queueId, string memberId, QueueMember body = null);
        /// <summary>
        /// Join or unjoin a set of users for a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <returns>QueueMember</returns>
        QueueMember RoutingQueuesQueueidUsersPatch (string queueId, List<QueueMember> body = null);

        /// <summary>
        /// Join or unjoin a set of users for a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <returns>ApiResponse of QueueMember</returns>
        ApiResponse<QueueMember> RoutingQueuesQueueidUsersPatchWithHttpInfo (string queueId, List<QueueMember> body = null);
        /// <summary>
        /// Bulk add or delete up to 100 queue members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <param name="delete">True to delete queue members (optional, default to false)</param>
        /// <returns>QueueMember</returns>
        QueueMember RoutingQueuesQueueidUsersPost (string queueId, List<QueueMember> body = null, bool? delete = null);

        /// <summary>
        /// Bulk add or delete up to 100 queue members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <param name="delete">True to delete queue members (optional, default to false)</param>
        /// <returns>ApiResponse of QueueMember</returns>
        ApiResponse<QueueMember> RoutingQueuesQueueidUsersPostWithHttpInfo (string queueId, List<QueueMember> body = null, bool? delete = null);
        /// <summary>
        /// Delete a wrap-up code from a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RoutingQueuesQueueidWrapupcodesCodeidDeleteWithHttpInfo (string queueId, string codeId);
        /// <summary>
        /// Get the wrap-up codes for a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> RoutingQueuesQueueidWrapupcodesGetWithHttpInfo (string queueId, string codeId);
        /// <summary>
        /// Add up to 100 wrap-up codes to a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>WrapupCode</returns>
        WrapupCode RoutingQueuesQueueidWrapupcodesPost (string queueId, string codeId, List<WrapupCode> body = null);

        /// <summary>
        /// Add up to 100 wrap-up codes to a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> RoutingQueuesQueueidWrapupcodesPostWithHttpInfo (string queueId, string codeId, List<WrapupCode> body = null);
        /// <summary>
        /// Get the list of skills.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>SkillEntityListing</returns>
        SkillEntityListing RoutingSkillsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null);

        /// <summary>
        /// Get the list of skills.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>ApiResponse of SkillEntityListing</returns>
        ApiResponse<SkillEntityListing> RoutingSkillsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null);
        /// <summary>
        /// Delete utilization settings and revert to system defaults.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>string</returns>
        string RoutingUtilizationDelete ();

        /// <summary>
        /// Delete utilization settings and revert to system defaults.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RoutingUtilizationDeleteWithHttpInfo ();
        /// <summary>
        /// Get the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Utilization</returns>
        Utilization RoutingUtilizationGet ();

        /// <summary>
        /// Get the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Utilization</returns>
        ApiResponse<Utilization> RoutingUtilizationGetWithHttpInfo ();
        /// <summary>
        /// Update the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">utilization (optional)</param>
        /// <returns>Utilization</returns>
        Utilization RoutingUtilizationPut (Utilization body = null);

        /// <summary>
        /// Update the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">utilization (optional)</param>
        /// <returns>ApiResponse of Utilization</returns>
        ApiResponse<Utilization> RoutingUtilizationPutWithHttpInfo (Utilization body = null);
        /// <summary>
        /// Delete wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>string</returns>
        string RoutingWrapupcodesCodeidDelete (string codeId);

        /// <summary>
        /// Delete wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RoutingWrapupcodesCodeidDeleteWithHttpInfo (string codeId);
        /// <summary>
        /// Get details about this wrap-up code.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>WrapupCode</returns>
        WrapupCode RoutingWrapupcodesCodeidGet (string codeId);

        /// <summary>
        /// Get details about this wrap-up code.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> RoutingWrapupcodesCodeidGetWithHttpInfo (string codeId);
        /// <summary>
        /// Update wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>WrapupCode</returns>
        WrapupCode RoutingWrapupcodesCodeidPut (string codeId, WrapupCode body = null);

        /// <summary>
        /// Update wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> RoutingWrapupcodesCodeidPutWithHttpInfo (string codeId, WrapupCode body = null);
        /// <summary>
        /// Get list of wrapup codes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>WrapupCodeEntityListing</returns>
        WrapupCodeEntityListing RoutingWrapupcodesGet (int? pageSize = null, int? pageNumber = null, string sortBy = null);

        /// <summary>
        /// Get list of wrapup codes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>ApiResponse of WrapupCodeEntityListing</returns>
        ApiResponse<WrapupCodeEntityListing> RoutingWrapupcodesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null);
        /// <summary>
        /// Create a wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>CallableTimeSet</returns>
        CallableTimeSet RoutingWrapupcodesPost (WrapupCode body = null);

        /// <summary>
        /// Create a wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        ApiResponse<CallableTimeSet> RoutingWrapupcodesPostWithHttpInfo (WrapupCode body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <returns>Task of InboundRouteEntityListing</returns>
        System.Threading.Tasks.Task<InboundRouteEntityListing> RoutingEmailDomainsDomainRoutesGetAsync (string domain);

        /// <summary>
        /// Get routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <returns>Task of ApiResponse (InboundRouteEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundRouteEntityListing>> RoutingEmailDomainsDomainRoutesGetAsyncWithHttpInfo (string domain);
        /// <summary>
        /// Delete a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> RoutingEmailDomainsDomainRoutesIdDeleteAsyncWithHttpInfo (string domain, string id);
        /// <summary>
        /// Get a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>Task of InboundRoute</returns>
        System.Threading.Tasks.Task<InboundRoute> RoutingEmailDomainsDomainRoutesIdPutAsync (string domain, string id, InboundRoute body = null);

        /// <summary>
        /// Update a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundRoute>> RoutingEmailDomainsDomainRoutesIdPutAsyncWithHttpInfo (string domain, string id, InboundRoute body = null);
        /// <summary>
        /// Create a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>Task of InboundRoute</returns>
        System.Threading.Tasks.Task<InboundRoute> RoutingEmailDomainsDomainRoutesPostAsync (string domain, InboundRoute body = null);

        /// <summary>
        /// Create a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundRoute>> RoutingEmailDomainsDomainRoutesPostAsyncWithHttpInfo (string domain, InboundRoute body = null);
        /// <summary>
        /// Get domains
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InboundDomainEntityListing</returns>
        System.Threading.Tasks.Task<InboundDomainEntityListing> RoutingEmailDomainsGetAsync ();

        /// <summary>
        /// Get domains
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InboundDomainEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundDomainEntityListing>> RoutingEmailDomainsGetAsyncWithHttpInfo ();
        /// <summary>
        /// Delete a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">domain ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> RoutingEmailDomainsIdDeleteAsync (string id);

        /// <summary>
        /// Delete a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">domain ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> RoutingEmailDomainsIdDeleteAsyncWithHttpInfo (string id);
        /// <summary>
        /// Create a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Domain (optional)</param>
        /// <returns>Task of InboundDomain</returns>
        System.Threading.Tasks.Task<InboundDomain> RoutingEmailDomainsPostAsync (InboundDomain body = null);

        /// <summary>
        /// Create a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Domain (optional)</param>
        /// <returns>Task of ApiResponse (InboundDomain)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundDomain>> RoutingEmailDomainsPostAsyncWithHttpInfo (InboundDomain body = null);
        /// <summary>
        /// Get email setup
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EmailSetup</returns>
        System.Threading.Tasks.Task<EmailSetup> RoutingEmailSetupGetAsync ();

        /// <summary>
        /// Get email setup
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EmailSetup)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailSetup>> RoutingEmailSetupGetAsyncWithHttpInfo ();
        /// <summary>
        /// Get list of queues.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="active">Active (optional)</param>
        /// <returns>Task of QueueEntityListing</returns>
        System.Threading.Tasks.Task<QueueEntityListing> RoutingQueuesGetAsync (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null);

        /// <summary>
        /// Get list of queues.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="active">Active (optional)</param>
        /// <returns>Task of ApiResponse (QueueEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueEntityListing>> RoutingQueuesGetAsyncWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null);
        /// <summary>
        /// Create queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Task of Queue</returns>
        System.Threading.Tasks.Task<Queue> RoutingQueuesPostAsync (string queueId, Queue body = null);

        /// <summary>
        /// Create queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        System.Threading.Tasks.Task<ApiResponse<Queue>> RoutingQueuesPostAsyncWithHttpInfo (string queueId, Queue body = null);
        /// <summary>
        /// Delete a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> RoutingQueuesQueueidDeleteAsync (string queueId);

        /// <summary>
        /// Delete a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> RoutingQueuesQueueidDeleteAsyncWithHttpInfo (string queueId);
        /// <summary>
        /// Get details about this queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of Queue</returns>
        System.Threading.Tasks.Task<Queue> RoutingQueuesQueueidGetAsync (string queueId);

        /// <summary>
        /// Get details about this queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        System.Threading.Tasks.Task<ApiResponse<Queue>> RoutingQueuesQueueidGetAsyncWithHttpInfo (string queueId);
        /// <summary>
        /// Get members in a queue
        /// </summary>
        /// <remarks>
        /// Get the list of members of a queue
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId"></param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="userId">UserID (optional)</param>
        /// <param name="statusId">Status ID (optional)</param>
        /// <param name="joined">Joined (optional)</param>
        /// <param name="expand">expand (optional)</param>
        /// <returns>Task of QueueMemberEntityListing</returns>
        System.Threading.Tasks.Task<QueueMemberEntityListing> RoutingQueuesQueueidMembersGetAsync (string queueId, int? pageSize = null, int? pageNumber = null, string userId = null, string statusId = null, bool? joined = null, string expand = null);

        /// <summary>
        /// Get members in a queue
        /// </summary>
        /// <remarks>
        /// Get the list of members of a queue
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId"></param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="userId">UserID (optional)</param>
        /// <param name="statusId">Status ID (optional)</param>
        /// <param name="joined">Joined (optional)</param>
        /// <param name="expand">expand (optional)</param>
        /// <returns>Task of ApiResponse (QueueMemberEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueMemberEntityListing>> RoutingQueuesQueueidMembersGetAsyncWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string userId = null, string statusId = null, bool? joined = null, string expand = null);
        /// <summary>
        /// Join or unjoin a user to the queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member/User ID</param>
        /// <param name="body">To join queue ~ \&quot;joined\&quot;:true (optional)</param>
        /// <returns>Task of QueueMember</returns>
        System.Threading.Tasks.Task<QueueMember> RoutingQueuesQueueidMembersMemberidPutAsync (string queueId, string memberId, QueueMember body = null);

        /// <summary>
        /// Join or unjoin a user to the queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member/User ID</param>
        /// <param name="body">To join queue ~ \&quot;joined\&quot;:true (optional)</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueMember>> RoutingQueuesQueueidMembersMemberidPutAsyncWithHttpInfo (string queueId, string memberId, QueueMember body = null);
        /// <summary>
        /// Update a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Task of Queue</returns>
        System.Threading.Tasks.Task<Queue> RoutingQueuesQueueidPutAsync (string queueId, Queue body = null);

        /// <summary>
        /// Update a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        System.Threading.Tasks.Task<ApiResponse<Queue>> RoutingQueuesQueueidPutAsyncWithHttpInfo (string queueId, Queue body = null);
        /// <summary>
        /// Get the members of this queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="directMembers">Only get users that are direct members of the queue (optional, default to false)</param>
        /// <returns>Task of QueueMember</returns>
        System.Threading.Tasks.Task<QueueMember> RoutingQueuesQueueidUsersGetAsync (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null);

        /// <summary>
        /// Get the members of this queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="directMembers">Only get users that are direct members of the queue (optional, default to false)</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueMember>> RoutingQueuesQueueidUsersGetAsyncWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null);
        /// <summary>
        /// Delete queue member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Queue Member (optional)</param>
        /// <returns>Task of QueueMember</returns>
        System.Threading.Tasks.Task<QueueMember> RoutingQueuesQueueidUsersMemberidPatchAsync (string queueId, string memberId, QueueMember body = null);

        /// <summary>
        /// Update the ring number of joined status for a User in a Queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Queue Member (optional)</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueMember>> RoutingQueuesQueueidUsersMemberidPatchAsyncWithHttpInfo (string queueId, string memberId, QueueMember body = null);
        /// <summary>
        /// Join or unjoin a set of users for a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <returns>Task of QueueMember</returns>
        System.Threading.Tasks.Task<QueueMember> RoutingQueuesQueueidUsersPatchAsync (string queueId, List<QueueMember> body = null);

        /// <summary>
        /// Join or unjoin a set of users for a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueMember>> RoutingQueuesQueueidUsersPatchAsyncWithHttpInfo (string queueId, List<QueueMember> body = null);
        /// <summary>
        /// Bulk add or delete up to 100 queue members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <param name="delete">True to delete queue members (optional, default to false)</param>
        /// <returns>Task of QueueMember</returns>
        System.Threading.Tasks.Task<QueueMember> RoutingQueuesQueueidUsersPostAsync (string queueId, List<QueueMember> body = null, bool? delete = null);

        /// <summary>
        /// Bulk add or delete up to 100 queue members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <param name="delete">True to delete queue members (optional, default to false)</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueMember>> RoutingQueuesQueueidUsersPostAsyncWithHttpInfo (string queueId, List<QueueMember> body = null, bool? delete = null);
        /// <summary>
        /// Delete a wrap-up code from a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> RoutingQueuesQueueidWrapupcodesCodeidDeleteAsyncWithHttpInfo (string queueId, string codeId);
        /// <summary>
        /// Get the wrap-up codes for a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> RoutingQueuesQueueidWrapupcodesPostAsync (string queueId, string codeId, List<WrapupCode> body = null);

        /// <summary>
        /// Add up to 100 wrap-up codes to a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> RoutingQueuesQueueidWrapupcodesPostAsyncWithHttpInfo (string queueId, string codeId, List<WrapupCode> body = null);
        /// <summary>
        /// Get the list of skills.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of SkillEntityListing</returns>
        System.Threading.Tasks.Task<SkillEntityListing> RoutingSkillsGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null);

        /// <summary>
        /// Get the list of skills.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of ApiResponse (SkillEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SkillEntityListing>> RoutingSkillsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null);
        /// <summary>
        /// Delete utilization settings and revert to system defaults.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> RoutingUtilizationDeleteAsync ();

        /// <summary>
        /// Delete utilization settings and revert to system defaults.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> RoutingUtilizationDeleteAsyncWithHttpInfo ();
        /// <summary>
        /// Get the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Utilization</returns>
        System.Threading.Tasks.Task<Utilization> RoutingUtilizationGetAsync ();

        /// <summary>
        /// Get the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Utilization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Utilization>> RoutingUtilizationGetAsyncWithHttpInfo ();
        /// <summary>
        /// Update the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">utilization (optional)</param>
        /// <returns>Task of Utilization</returns>
        System.Threading.Tasks.Task<Utilization> RoutingUtilizationPutAsync (Utilization body = null);

        /// <summary>
        /// Update the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">utilization (optional)</param>
        /// <returns>Task of ApiResponse (Utilization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Utilization>> RoutingUtilizationPutAsyncWithHttpInfo (Utilization body = null);
        /// <summary>
        /// Delete wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> RoutingWrapupcodesCodeidDeleteAsync (string codeId);

        /// <summary>
        /// Delete wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> RoutingWrapupcodesCodeidDeleteAsyncWithHttpInfo (string codeId);
        /// <summary>
        /// Get details about this wrap-up code.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> RoutingWrapupcodesCodeidGetAsync (string codeId);

        /// <summary>
        /// Get details about this wrap-up code.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> RoutingWrapupcodesCodeidGetAsyncWithHttpInfo (string codeId);
        /// <summary>
        /// Update wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> RoutingWrapupcodesCodeidPutAsync (string codeId, WrapupCode body = null);

        /// <summary>
        /// Update wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> RoutingWrapupcodesCodeidPutAsyncWithHttpInfo (string codeId, WrapupCode body = null);
        /// <summary>
        /// Get list of wrapup codes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>Task of WrapupCodeEntityListing</returns>
        System.Threading.Tasks.Task<WrapupCodeEntityListing> RoutingWrapupcodesGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null);

        /// <summary>
        /// Get list of wrapup codes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>Task of ApiResponse (WrapupCodeEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCodeEntityListing>> RoutingWrapupcodesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null);
        /// <summary>
        /// Create a wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>Task of CallableTimeSet</returns>
        System.Threading.Tasks.Task<CallableTimeSet> RoutingWrapupcodesPostAsync (WrapupCode body = null);

        /// <summary>
        /// Create a wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> RoutingWrapupcodesPostAsyncWithHttpInfo (WrapupCode body = null);
        #endregion Asynchronous Operations
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

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        /// Get routes 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <returns>InboundRouteEntityListing</returns>
        public InboundRouteEntityListing RoutingEmailDomainsDomainRoutesGet (string domain)
        {
             ApiResponse<InboundRouteEntityListing> localVarResponse = RoutingEmailDomainsDomainRoutesGetWithHttpInfo(domain);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get routes 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <returns>ApiResponse of InboundRouteEntityListing</returns>
        public ApiResponse< InboundRouteEntityListing > RoutingEmailDomainsDomainRoutesGetWithHttpInfo (string domain)
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingApi->RoutingEmailDomainsDomainRoutesGet");

            var localVarPath = "/api/v1/routing/email/domains/{domain}/routes";
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
            if (domain != null) localVarPathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRouteEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRouteEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRouteEntityListing)));
            
        }

        /// <summary>
        /// Get routes 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <returns>Task of InboundRouteEntityListing</returns>
        public async System.Threading.Tasks.Task<InboundRouteEntityListing> RoutingEmailDomainsDomainRoutesGetAsync (string domain)
        {
             ApiResponse<InboundRouteEntityListing> localVarResponse = await RoutingEmailDomainsDomainRoutesGetAsyncWithHttpInfo(domain);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get routes 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <returns>Task of ApiResponse (InboundRouteEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundRouteEntityListing>> RoutingEmailDomainsDomainRoutesGetAsyncWithHttpInfo (string domain)
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingApi->RoutingEmailDomainsDomainRoutesGet");

            var localVarPath = "/api/v1/routing/email/domains/{domain}/routes";
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
            if (domain != null) localVarPathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRouteEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRouteEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRouteEntityListing)));
            
        }

        /// <summary>
        /// Delete a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>string</returns>
        public string RoutingEmailDomainsDomainRoutesIdDelete (string domain, string id)
        {
             ApiResponse<string> localVarResponse = RoutingEmailDomainsDomainRoutesIdDeleteWithHttpInfo(domain, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > RoutingEmailDomainsDomainRoutesIdDeleteWithHttpInfo (string domain, string id)
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingApi->RoutingEmailDomainsDomainRoutesIdDelete");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoutingApi->RoutingEmailDomainsDomainRoutesIdDelete");

            var localVarPath = "/api/v1/routing/email/domains/{domain}/routes/{id}";
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
            if (domain != null) localVarPathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesIdDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesIdDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RoutingEmailDomainsDomainRoutesIdDeleteAsync (string domain, string id)
        {
             ApiResponse<string> localVarResponse = await RoutingEmailDomainsDomainRoutesIdDeleteAsyncWithHttpInfo(domain, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> RoutingEmailDomainsDomainRoutesIdDeleteAsyncWithHttpInfo (string domain, string id)
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingApi->RoutingEmailDomainsDomainRoutesIdDelete");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoutingApi->RoutingEmailDomainsDomainRoutesIdDelete");

            var localVarPath = "/api/v1/routing/email/domains/{domain}/routes/{id}";
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
            if (domain != null) localVarPathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesIdDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesIdDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>InboundRoute</returns>
        public InboundRoute RoutingEmailDomainsDomainRoutesIdGet (string domain, string id)
        {
             ApiResponse<InboundRoute> localVarResponse = RoutingEmailDomainsDomainRoutesIdGetWithHttpInfo(domain, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>ApiResponse of InboundRoute</returns>
        public ApiResponse< InboundRoute > RoutingEmailDomainsDomainRoutesIdGetWithHttpInfo (string domain, string id)
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingApi->RoutingEmailDomainsDomainRoutesIdGet");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoutingApi->RoutingEmailDomainsDomainRoutesIdGet");

            var localVarPath = "/api/v1/routing/email/domains/{domain}/routes/{id}";
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
            if (domain != null) localVarPathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRoute)));
            
        }

        /// <summary>
        /// Get a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>Task of InboundRoute</returns>
        public async System.Threading.Tasks.Task<InboundRoute> RoutingEmailDomainsDomainRoutesIdGetAsync (string domain, string id)
        {
             ApiResponse<InboundRoute> localVarResponse = await RoutingEmailDomainsDomainRoutesIdGetAsyncWithHttpInfo(domain, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundRoute>> RoutingEmailDomainsDomainRoutesIdGetAsyncWithHttpInfo (string domain, string id)
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingApi->RoutingEmailDomainsDomainRoutesIdGet");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoutingApi->RoutingEmailDomainsDomainRoutesIdGet");

            var localVarPath = "/api/v1/routing/email/domains/{domain}/routes/{id}";
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
            if (domain != null) localVarPathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRoute)));
            
        }

        /// <summary>
        /// Update a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>InboundRoute</returns>
        public InboundRoute RoutingEmailDomainsDomainRoutesIdPut (string domain, string id, InboundRoute body = null)
        {
             ApiResponse<InboundRoute> localVarResponse = RoutingEmailDomainsDomainRoutesIdPutWithHttpInfo(domain, id, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>ApiResponse of InboundRoute</returns>
        public ApiResponse< InboundRoute > RoutingEmailDomainsDomainRoutesIdPutWithHttpInfo (string domain, string id, InboundRoute body = null)
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingApi->RoutingEmailDomainsDomainRoutesIdPut");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoutingApi->RoutingEmailDomainsDomainRoutesIdPut");

            var localVarPath = "/api/v1/routing/email/domains/{domain}/routes/{id}";
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
            if (domain != null) localVarPathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesIdPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesIdPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRoute)));
            
        }

        /// <summary>
        /// Update a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>Task of InboundRoute</returns>
        public async System.Threading.Tasks.Task<InboundRoute> RoutingEmailDomainsDomainRoutesIdPutAsync (string domain, string id, InboundRoute body = null)
        {
             ApiResponse<InboundRoute> localVarResponse = await RoutingEmailDomainsDomainRoutesIdPutAsyncWithHttpInfo(domain, id, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundRoute>> RoutingEmailDomainsDomainRoutesIdPutAsyncWithHttpInfo (string domain, string id, InboundRoute body = null)
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingApi->RoutingEmailDomainsDomainRoutesIdPut");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoutingApi->RoutingEmailDomainsDomainRoutesIdPut");

            var localVarPath = "/api/v1/routing/email/domains/{domain}/routes/{id}";
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
            if (domain != null) localVarPathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesIdPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesIdPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRoute)));
            
        }

        /// <summary>
        /// Create a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>InboundRoute</returns>
        public InboundRoute RoutingEmailDomainsDomainRoutesPost (string domain, InboundRoute body = null)
        {
             ApiResponse<InboundRoute> localVarResponse = RoutingEmailDomainsDomainRoutesPostWithHttpInfo(domain, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>ApiResponse of InboundRoute</returns>
        public ApiResponse< InboundRoute > RoutingEmailDomainsDomainRoutesPostWithHttpInfo (string domain, InboundRoute body = null)
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingApi->RoutingEmailDomainsDomainRoutesPost");

            var localVarPath = "/api/v1/routing/email/domains/{domain}/routes";
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
            if (domain != null) localVarPathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRoute)));
            
        }

        /// <summary>
        /// Create a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>Task of InboundRoute</returns>
        public async System.Threading.Tasks.Task<InboundRoute> RoutingEmailDomainsDomainRoutesPostAsync (string domain, InboundRoute body = null)
        {
             ApiResponse<InboundRoute> localVarResponse = await RoutingEmailDomainsDomainRoutesPostAsyncWithHttpInfo(domain, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundRoute>> RoutingEmailDomainsDomainRoutesPostAsyncWithHttpInfo (string domain, InboundRoute body = null)
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingApi->RoutingEmailDomainsDomainRoutesPost");

            var localVarPath = "/api/v1/routing/email/domains/{domain}/routes";
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
            if (domain != null) localVarPathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRoute)));
            
        }

        /// <summary>
        /// Get domains 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InboundDomainEntityListing</returns>
        public InboundDomainEntityListing RoutingEmailDomainsGet ()
        {
             ApiResponse<InboundDomainEntityListing> localVarResponse = RoutingEmailDomainsGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get domains 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InboundDomainEntityListing</returns>
        public ApiResponse< InboundDomainEntityListing > RoutingEmailDomainsGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/routing/email/domains";
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundDomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundDomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundDomainEntityListing)));
            
        }

        /// <summary>
        /// Get domains 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InboundDomainEntityListing</returns>
        public async System.Threading.Tasks.Task<InboundDomainEntityListing> RoutingEmailDomainsGetAsync ()
        {
             ApiResponse<InboundDomainEntityListing> localVarResponse = await RoutingEmailDomainsGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get domains 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InboundDomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundDomainEntityListing>> RoutingEmailDomainsGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/routing/email/domains";
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundDomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundDomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundDomainEntityListing)));
            
        }

        /// <summary>
        /// Delete a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">domain ID</param>
        /// <returns>string</returns>
        public string RoutingEmailDomainsIdDelete (string id)
        {
             ApiResponse<string> localVarResponse = RoutingEmailDomainsIdDeleteWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">domain ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > RoutingEmailDomainsIdDeleteWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoutingApi->RoutingEmailDomainsIdDelete");

            var localVarPath = "/api/v1/routing/email/domains/{id}";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsIdDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsIdDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">domain ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RoutingEmailDomainsIdDeleteAsync (string id)
        {
             ApiResponse<string> localVarResponse = await RoutingEmailDomainsIdDeleteAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">domain ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> RoutingEmailDomainsIdDeleteAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoutingApi->RoutingEmailDomainsIdDelete");

            var localVarPath = "/api/v1/routing/email/domains/{id}";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsIdDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsIdDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Create a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Domain (optional)</param>
        /// <returns>InboundDomain</returns>
        public InboundDomain RoutingEmailDomainsPost (InboundDomain body = null)
        {
             ApiResponse<InboundDomain> localVarResponse = RoutingEmailDomainsPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Domain (optional)</param>
        /// <returns>ApiResponse of InboundDomain</returns>
        public ApiResponse< InboundDomain > RoutingEmailDomainsPostWithHttpInfo (InboundDomain body = null)
        {

            var localVarPath = "/api/v1/routing/email/domains";
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundDomain>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundDomain) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundDomain)));
            
        }

        /// <summary>
        /// Create a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Domain (optional)</param>
        /// <returns>Task of InboundDomain</returns>
        public async System.Threading.Tasks.Task<InboundDomain> RoutingEmailDomainsPostAsync (InboundDomain body = null)
        {
             ApiResponse<InboundDomain> localVarResponse = await RoutingEmailDomainsPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Domain (optional)</param>
        /// <returns>Task of ApiResponse (InboundDomain)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundDomain>> RoutingEmailDomainsPostAsyncWithHttpInfo (InboundDomain body = null)
        {

            var localVarPath = "/api/v1/routing/email/domains";
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundDomain>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundDomain) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundDomain)));
            
        }

        /// <summary>
        /// Get email setup 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EmailSetup</returns>
        public EmailSetup RoutingEmailSetupGet ()
        {
             ApiResponse<EmailSetup> localVarResponse = RoutingEmailSetupGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get email setup 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EmailSetup</returns>
        public ApiResponse< EmailSetup > RoutingEmailSetupGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/routing/email/setup";
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailSetupGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailSetupGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailSetup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailSetup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailSetup)));
            
        }

        /// <summary>
        /// Get email setup 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EmailSetup</returns>
        public async System.Threading.Tasks.Task<EmailSetup> RoutingEmailSetupGetAsync ()
        {
             ApiResponse<EmailSetup> localVarResponse = await RoutingEmailSetupGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get email setup 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EmailSetup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailSetup>> RoutingEmailSetupGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/routing/email/setup";
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailSetupGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailSetupGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailSetup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailSetup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailSetup)));
            
        }

        /// <summary>
        /// Get list of queues. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="active">Active (optional)</param>
        /// <returns>QueueEntityListing</returns>
        public QueueEntityListing RoutingQueuesGet (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null)
        {
             ApiResponse<QueueEntityListing> localVarResponse = RoutingQueuesGetWithHttpInfo(queueId, pageSize, pageNumber, sortBy, name, active);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of queues. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="active">Active (optional)</param>
        /// <returns>ApiResponse of QueueEntityListing</returns>
        public ApiResponse< QueueEntityListing > RoutingQueuesGetWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesGet");

            var localVarPath = "/api/v1/routing/queues";
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
            if (queueId != null) localVarPathParams.Add("QueueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (active != null) localVarQueryParams.Add("active", Configuration.ApiClient.ParameterToString(active)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueEntityListing)));
            
        }

        /// <summary>
        /// Get list of queues. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="active">Active (optional)</param>
        /// <returns>Task of QueueEntityListing</returns>
        public async System.Threading.Tasks.Task<QueueEntityListing> RoutingQueuesGetAsync (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null)
        {
             ApiResponse<QueueEntityListing> localVarResponse = await RoutingQueuesGetAsyncWithHttpInfo(queueId, pageSize, pageNumber, sortBy, name, active);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of queues. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="active">Active (optional)</param>
        /// <returns>Task of ApiResponse (QueueEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueueEntityListing>> RoutingQueuesGetAsyncWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesGet");

            var localVarPath = "/api/v1/routing/queues";
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
            if (queueId != null) localVarPathParams.Add("QueueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (active != null) localVarQueryParams.Add("active", Configuration.ApiClient.ParameterToString(active)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueEntityListing)));
            
        }

        /// <summary>
        /// Create queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Queue</returns>
        public Queue RoutingQueuesPost (string queueId, Queue body = null)
        {
             ApiResponse<Queue> localVarResponse = RoutingQueuesPostWithHttpInfo(queueId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>ApiResponse of Queue</returns>
        public ApiResponse< Queue > RoutingQueuesPostWithHttpInfo (string queueId, Queue body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesPost");

            var localVarPath = "/api/v1/routing/queues";
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
            if (queueId != null) localVarPathParams.Add("QueueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Queue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Queue)));
            
        }

        /// <summary>
        /// Create queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Task of Queue</returns>
        public async System.Threading.Tasks.Task<Queue> RoutingQueuesPostAsync (string queueId, Queue body = null)
        {
             ApiResponse<Queue> localVarResponse = await RoutingQueuesPostAsyncWithHttpInfo(queueId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Queue>> RoutingQueuesPostAsyncWithHttpInfo (string queueId, Queue body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesPost");

            var localVarPath = "/api/v1/routing/queues";
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
            if (queueId != null) localVarPathParams.Add("QueueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Queue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Queue)));
            
        }

        /// <summary>
        /// Delete a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>string</returns>
        public string RoutingQueuesQueueidDelete (string queueId)
        {
             ApiResponse<string> localVarResponse = RoutingQueuesQueueidDeleteWithHttpInfo(queueId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > RoutingQueuesQueueidDeleteWithHttpInfo (string queueId)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidDelete");

            var localVarPath = "/api/v1/routing/queues/{queueId}";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RoutingQueuesQueueidDeleteAsync (string queueId)
        {
             ApiResponse<string> localVarResponse = await RoutingQueuesQueueidDeleteAsyncWithHttpInfo(queueId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> RoutingQueuesQueueidDeleteAsyncWithHttpInfo (string queueId)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidDelete");

            var localVarPath = "/api/v1/routing/queues/{queueId}";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get details about this queue. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Queue</returns>
        public Queue RoutingQueuesQueueidGet (string queueId)
        {
             ApiResponse<Queue> localVarResponse = RoutingQueuesQueueidGetWithHttpInfo(queueId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get details about this queue. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>ApiResponse of Queue</returns>
        public ApiResponse< Queue > RoutingQueuesQueueidGetWithHttpInfo (string queueId)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidGet");

            var localVarPath = "/api/v1/routing/queues/{queueId}";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Queue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Queue)));
            
        }

        /// <summary>
        /// Get details about this queue. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of Queue</returns>
        public async System.Threading.Tasks.Task<Queue> RoutingQueuesQueueidGetAsync (string queueId)
        {
             ApiResponse<Queue> localVarResponse = await RoutingQueuesQueueidGetAsyncWithHttpInfo(queueId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get details about this queue. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Queue>> RoutingQueuesQueueidGetAsyncWithHttpInfo (string queueId)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidGet");

            var localVarPath = "/api/v1/routing/queues/{queueId}";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Queue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Queue)));
            
        }

        /// <summary>
        /// Get members in a queue Get the list of members of a queue
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId"></param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="userId">UserID (optional)</param>
        /// <param name="statusId">Status ID (optional)</param>
        /// <param name="joined">Joined (optional)</param>
        /// <param name="expand">expand (optional)</param>
        /// <returns>QueueMemberEntityListing</returns>
        public QueueMemberEntityListing RoutingQueuesQueueidMembersGet (string queueId, int? pageSize = null, int? pageNumber = null, string userId = null, string statusId = null, bool? joined = null, string expand = null)
        {
             ApiResponse<QueueMemberEntityListing> localVarResponse = RoutingQueuesQueueidMembersGetWithHttpInfo(queueId, pageSize, pageNumber, userId, statusId, joined, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get members in a queue Get the list of members of a queue
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId"></param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="userId">UserID (optional)</param>
        /// <param name="statusId">Status ID (optional)</param>
        /// <param name="joined">Joined (optional)</param>
        /// <param name="expand">expand (optional)</param>
        /// <returns>ApiResponse of QueueMemberEntityListing</returns>
        public ApiResponse< QueueMemberEntityListing > RoutingQueuesQueueidMembersGetWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string userId = null, string statusId = null, bool? joined = null, string expand = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidMembersGet");

            var localVarPath = "/api/v1/routing/queues/{queueId}/members";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (userId != null) localVarQueryParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (statusId != null) localVarQueryParams.Add("statusId", Configuration.ApiClient.ParameterToString(statusId)); // query parameter
            if (joined != null) localVarQueryParams.Add("joined", Configuration.ApiClient.ParameterToString(joined)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidMembersGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidMembersGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMemberEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMemberEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMemberEntityListing)));
            
        }

        /// <summary>
        /// Get members in a queue Get the list of members of a queue
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId"></param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="userId">UserID (optional)</param>
        /// <param name="statusId">Status ID (optional)</param>
        /// <param name="joined">Joined (optional)</param>
        /// <param name="expand">expand (optional)</param>
        /// <returns>Task of QueueMemberEntityListing</returns>
        public async System.Threading.Tasks.Task<QueueMemberEntityListing> RoutingQueuesQueueidMembersGetAsync (string queueId, int? pageSize = null, int? pageNumber = null, string userId = null, string statusId = null, bool? joined = null, string expand = null)
        {
             ApiResponse<QueueMemberEntityListing> localVarResponse = await RoutingQueuesQueueidMembersGetAsyncWithHttpInfo(queueId, pageSize, pageNumber, userId, statusId, joined, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get members in a queue Get the list of members of a queue
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId"></param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="userId">UserID (optional)</param>
        /// <param name="statusId">Status ID (optional)</param>
        /// <param name="joined">Joined (optional)</param>
        /// <param name="expand">expand (optional)</param>
        /// <returns>Task of ApiResponse (QueueMemberEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueueMemberEntityListing>> RoutingQueuesQueueidMembersGetAsyncWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string userId = null, string statusId = null, bool? joined = null, string expand = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidMembersGet");

            var localVarPath = "/api/v1/routing/queues/{queueId}/members";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (userId != null) localVarQueryParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (statusId != null) localVarQueryParams.Add("statusId", Configuration.ApiClient.ParameterToString(statusId)); // query parameter
            if (joined != null) localVarQueryParams.Add("joined", Configuration.ApiClient.ParameterToString(joined)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidMembersGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidMembersGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMemberEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMemberEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMemberEntityListing)));
            
        }

        /// <summary>
        /// Join or unjoin a user to the queue. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member/User ID</param>
        /// <param name="body">To join queue ~ \&quot;joined\&quot;:true (optional)</param>
        /// <returns>QueueMember</returns>
        public QueueMember RoutingQueuesQueueidMembersMemberidPut (string queueId, string memberId, QueueMember body = null)
        {
             ApiResponse<QueueMember> localVarResponse = RoutingQueuesQueueidMembersMemberidPutWithHttpInfo(queueId, memberId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Join or unjoin a user to the queue. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member/User ID</param>
        /// <param name="body">To join queue ~ \&quot;joined\&quot;:true (optional)</param>
        /// <returns>ApiResponse of QueueMember</returns>
        public ApiResponse< QueueMember > RoutingQueuesQueueidMembersMemberidPutWithHttpInfo (string queueId, string memberId, QueueMember body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidMembersMemberidPut");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling RoutingApi->RoutingQueuesQueueidMembersMemberidPut");

            var localVarPath = "/api/v1/routing/queues/{queueId}/members/{memberId}";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidMembersMemberidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidMembersMemberidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMember)));
            
        }

        /// <summary>
        /// Join or unjoin a user to the queue. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member/User ID</param>
        /// <param name="body">To join queue ~ \&quot;joined\&quot;:true (optional)</param>
        /// <returns>Task of QueueMember</returns>
        public async System.Threading.Tasks.Task<QueueMember> RoutingQueuesQueueidMembersMemberidPutAsync (string queueId, string memberId, QueueMember body = null)
        {
             ApiResponse<QueueMember> localVarResponse = await RoutingQueuesQueueidMembersMemberidPutAsyncWithHttpInfo(queueId, memberId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Join or unjoin a user to the queue. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member/User ID</param>
        /// <param name="body">To join queue ~ \&quot;joined\&quot;:true (optional)</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueueMember>> RoutingQueuesQueueidMembersMemberidPutAsyncWithHttpInfo (string queueId, string memberId, QueueMember body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidMembersMemberidPut");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling RoutingApi->RoutingQueuesQueueidMembersMemberidPut");

            var localVarPath = "/api/v1/routing/queues/{queueId}/members/{memberId}";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidMembersMemberidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidMembersMemberidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMember)));
            
        }

        /// <summary>
        /// Update a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Queue</returns>
        public Queue RoutingQueuesQueueidPut (string queueId, Queue body = null)
        {
             ApiResponse<Queue> localVarResponse = RoutingQueuesQueueidPutWithHttpInfo(queueId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>ApiResponse of Queue</returns>
        public ApiResponse< Queue > RoutingQueuesQueueidPutWithHttpInfo (string queueId, Queue body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidPut");

            var localVarPath = "/api/v1/routing/queues/{queueId}";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Queue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Queue)));
            
        }

        /// <summary>
        /// Update a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Task of Queue</returns>
        public async System.Threading.Tasks.Task<Queue> RoutingQueuesQueueidPutAsync (string queueId, Queue body = null)
        {
             ApiResponse<Queue> localVarResponse = await RoutingQueuesQueueidPutAsyncWithHttpInfo(queueId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Queue>> RoutingQueuesQueueidPutAsyncWithHttpInfo (string queueId, Queue body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidPut");

            var localVarPath = "/api/v1/routing/queues/{queueId}";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Queue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Queue)));
            
        }

        /// <summary>
        /// Get the members of this queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="directMembers">Only get users that are direct members of the queue (optional, default to false)</param>
        /// <returns>QueueMember</returns>
        public QueueMember RoutingQueuesQueueidUsersGet (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null)
        {
             ApiResponse<QueueMember> localVarResponse = RoutingQueuesQueueidUsersGetWithHttpInfo(queueId, pageSize, pageNumber, sortBy, expand, directMembers);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the members of this queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="directMembers">Only get users that are direct members of the queue (optional, default to false)</param>
        /// <returns>ApiResponse of QueueMember</returns>
        public ApiResponse< QueueMember > RoutingQueuesQueueidUsersGetWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidUsersGet");

            var localVarPath = "/api/v1/routing/queues/{queueId}/users";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (directMembers != null) localVarQueryParams.Add("directMembers", Configuration.ApiClient.ParameterToString(directMembers)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMember)));
            
        }

        /// <summary>
        /// Get the members of this queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="directMembers">Only get users that are direct members of the queue (optional, default to false)</param>
        /// <returns>Task of QueueMember</returns>
        public async System.Threading.Tasks.Task<QueueMember> RoutingQueuesQueueidUsersGetAsync (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null)
        {
             ApiResponse<QueueMember> localVarResponse = await RoutingQueuesQueueidUsersGetAsyncWithHttpInfo(queueId, pageSize, pageNumber, sortBy, expand, directMembers);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the members of this queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="directMembers">Only get users that are direct members of the queue (optional, default to false)</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueueMember>> RoutingQueuesQueueidUsersGetAsyncWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidUsersGet");

            var localVarPath = "/api/v1/routing/queues/{queueId}/users";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (directMembers != null) localVarQueryParams.Add("directMembers", Configuration.ApiClient.ParameterToString(directMembers)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMember)));
            
        }

        /// <summary>
        /// Delete queue member 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>string</returns>
        public string RoutingQueuesQueueidUsersMemberidDelete (string queueId, string memberId)
        {
             ApiResponse<string> localVarResponse = RoutingQueuesQueueidUsersMemberidDeleteWithHttpInfo(queueId, memberId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete queue member 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > RoutingQueuesQueueidUsersMemberidDeleteWithHttpInfo (string queueId, string memberId)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidUsersMemberidDelete");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling RoutingApi->RoutingQueuesQueueidUsersMemberidDelete");

            var localVarPath = "/api/v1/routing/queues/{queueId}/users/{memberId}";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersMemberidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersMemberidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete queue member 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RoutingQueuesQueueidUsersMemberidDeleteAsync (string queueId, string memberId)
        {
             ApiResponse<string> localVarResponse = await RoutingQueuesQueueidUsersMemberidDeleteAsyncWithHttpInfo(queueId, memberId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete queue member 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> RoutingQueuesQueueidUsersMemberidDeleteAsyncWithHttpInfo (string queueId, string memberId)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidUsersMemberidDelete");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling RoutingApi->RoutingQueuesQueueidUsersMemberidDelete");

            var localVarPath = "/api/v1/routing/queues/{queueId}/users/{memberId}";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersMemberidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersMemberidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Update the ring number of joined status for a User in a Queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Queue Member (optional)</param>
        /// <returns>QueueMember</returns>
        public QueueMember RoutingQueuesQueueidUsersMemberidPatch (string queueId, string memberId, QueueMember body = null)
        {
             ApiResponse<QueueMember> localVarResponse = RoutingQueuesQueueidUsersMemberidPatchWithHttpInfo(queueId, memberId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the ring number of joined status for a User in a Queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Queue Member (optional)</param>
        /// <returns>ApiResponse of QueueMember</returns>
        public ApiResponse< QueueMember > RoutingQueuesQueueidUsersMemberidPatchWithHttpInfo (string queueId, string memberId, QueueMember body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidUsersMemberidPatch");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling RoutingApi->RoutingQueuesQueueidUsersMemberidPatch");

            var localVarPath = "/api/v1/routing/queues/{queueId}/users/{memberId}";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersMemberidPatch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersMemberidPatch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMember)));
            
        }

        /// <summary>
        /// Update the ring number of joined status for a User in a Queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Queue Member (optional)</param>
        /// <returns>Task of QueueMember</returns>
        public async System.Threading.Tasks.Task<QueueMember> RoutingQueuesQueueidUsersMemberidPatchAsync (string queueId, string memberId, QueueMember body = null)
        {
             ApiResponse<QueueMember> localVarResponse = await RoutingQueuesQueueidUsersMemberidPatchAsyncWithHttpInfo(queueId, memberId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the ring number of joined status for a User in a Queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Queue Member (optional)</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueueMember>> RoutingQueuesQueueidUsersMemberidPatchAsyncWithHttpInfo (string queueId, string memberId, QueueMember body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidUsersMemberidPatch");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling RoutingApi->RoutingQueuesQueueidUsersMemberidPatch");

            var localVarPath = "/api/v1/routing/queues/{queueId}/users/{memberId}";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersMemberidPatch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersMemberidPatch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMember)));
            
        }

        /// <summary>
        /// Join or unjoin a set of users for a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <returns>QueueMember</returns>
        public QueueMember RoutingQueuesQueueidUsersPatch (string queueId, List<QueueMember> body = null)
        {
             ApiResponse<QueueMember> localVarResponse = RoutingQueuesQueueidUsersPatchWithHttpInfo(queueId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Join or unjoin a set of users for a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <returns>ApiResponse of QueueMember</returns>
        public ApiResponse< QueueMember > RoutingQueuesQueueidUsersPatchWithHttpInfo (string queueId, List<QueueMember> body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidUsersPatch");

            var localVarPath = "/api/v1/routing/queues/{queueId}/users";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersPatch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersPatch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMember)));
            
        }

        /// <summary>
        /// Join or unjoin a set of users for a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <returns>Task of QueueMember</returns>
        public async System.Threading.Tasks.Task<QueueMember> RoutingQueuesQueueidUsersPatchAsync (string queueId, List<QueueMember> body = null)
        {
             ApiResponse<QueueMember> localVarResponse = await RoutingQueuesQueueidUsersPatchAsyncWithHttpInfo(queueId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Join or unjoin a set of users for a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueueMember>> RoutingQueuesQueueidUsersPatchAsyncWithHttpInfo (string queueId, List<QueueMember> body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidUsersPatch");

            var localVarPath = "/api/v1/routing/queues/{queueId}/users";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersPatch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersPatch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMember)));
            
        }

        /// <summary>
        /// Bulk add or delete up to 100 queue members 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <param name="delete">True to delete queue members (optional, default to false)</param>
        /// <returns>QueueMember</returns>
        public QueueMember RoutingQueuesQueueidUsersPost (string queueId, List<QueueMember> body = null, bool? delete = null)
        {
             ApiResponse<QueueMember> localVarResponse = RoutingQueuesQueueidUsersPostWithHttpInfo(queueId, body, delete);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk add or delete up to 100 queue members 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <param name="delete">True to delete queue members (optional, default to false)</param>
        /// <returns>ApiResponse of QueueMember</returns>
        public ApiResponse< QueueMember > RoutingQueuesQueueidUsersPostWithHttpInfo (string queueId, List<QueueMember> body = null, bool? delete = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidUsersPost");

            var localVarPath = "/api/v1/routing/queues/{queueId}/users";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (delete != null) localVarQueryParams.Add("delete", Configuration.ApiClient.ParameterToString(delete)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMember)));
            
        }

        /// <summary>
        /// Bulk add or delete up to 100 queue members 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <param name="delete">True to delete queue members (optional, default to false)</param>
        /// <returns>Task of QueueMember</returns>
        public async System.Threading.Tasks.Task<QueueMember> RoutingQueuesQueueidUsersPostAsync (string queueId, List<QueueMember> body = null, bool? delete = null)
        {
             ApiResponse<QueueMember> localVarResponse = await RoutingQueuesQueueidUsersPostAsyncWithHttpInfo(queueId, body, delete);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bulk add or delete up to 100 queue members 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <param name="delete">True to delete queue members (optional, default to false)</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueueMember>> RoutingQueuesQueueidUsersPostAsyncWithHttpInfo (string queueId, List<QueueMember> body = null, bool? delete = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidUsersPost");

            var localVarPath = "/api/v1/routing/queues/{queueId}/users";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (delete != null) localVarQueryParams.Add("delete", Configuration.ApiClient.ParameterToString(delete)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMember)));
            
        }

        /// <summary>
        /// Delete a wrap-up code from a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>string</returns>
        public string RoutingQueuesQueueidWrapupcodesCodeidDelete (string queueId, string codeId)
        {
             ApiResponse<string> localVarResponse = RoutingQueuesQueueidWrapupcodesCodeidDeleteWithHttpInfo(queueId, codeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a wrap-up code from a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > RoutingQueuesQueueidWrapupcodesCodeidDeleteWithHttpInfo (string queueId, string codeId)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidWrapupcodesCodeidDelete");
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->RoutingQueuesQueueidWrapupcodesCodeidDelete");

            var localVarPath = "/api/v1/routing/queues/{queueId}/wrapupcodes/{codeId}";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (codeId != null) localVarPathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidWrapupcodesCodeidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidWrapupcodesCodeidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a wrap-up code from a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RoutingQueuesQueueidWrapupcodesCodeidDeleteAsync (string queueId, string codeId)
        {
             ApiResponse<string> localVarResponse = await RoutingQueuesQueueidWrapupcodesCodeidDeleteAsyncWithHttpInfo(queueId, codeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a wrap-up code from a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> RoutingQueuesQueueidWrapupcodesCodeidDeleteAsyncWithHttpInfo (string queueId, string codeId)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidWrapupcodesCodeidDelete");
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->RoutingQueuesQueueidWrapupcodesCodeidDelete");

            var localVarPath = "/api/v1/routing/queues/{queueId}/wrapupcodes/{codeId}";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (codeId != null) localVarPathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidWrapupcodesCodeidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidWrapupcodesCodeidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get the wrap-up codes for a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>WrapupCode</returns>
        public WrapupCode RoutingQueuesQueueidWrapupcodesGet (string queueId, string codeId)
        {
             ApiResponse<WrapupCode> localVarResponse = RoutingQueuesQueueidWrapupcodesGetWithHttpInfo(queueId, codeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the wrap-up codes for a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > RoutingQueuesQueueidWrapupcodesGetWithHttpInfo (string queueId, string codeId)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidWrapupcodesGet");
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->RoutingQueuesQueueidWrapupcodesGet");

            var localVarPath = "/api/v1/routing/queues/{queueId}/wrapupcodes";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (codeId != null) localVarPathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidWrapupcodesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidWrapupcodesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        /// <summary>
        /// Get the wrap-up codes for a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> RoutingQueuesQueueidWrapupcodesGetAsync (string queueId, string codeId)
        {
             ApiResponse<WrapupCode> localVarResponse = await RoutingQueuesQueueidWrapupcodesGetAsyncWithHttpInfo(queueId, codeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the wrap-up codes for a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> RoutingQueuesQueueidWrapupcodesGetAsyncWithHttpInfo (string queueId, string codeId)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidWrapupcodesGet");
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->RoutingQueuesQueueidWrapupcodesGet");

            var localVarPath = "/api/v1/routing/queues/{queueId}/wrapupcodes";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (codeId != null) localVarPathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidWrapupcodesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidWrapupcodesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        /// <summary>
        /// Add up to 100 wrap-up codes to a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>WrapupCode</returns>
        public WrapupCode RoutingQueuesQueueidWrapupcodesPost (string queueId, string codeId, List<WrapupCode> body = null)
        {
             ApiResponse<WrapupCode> localVarResponse = RoutingQueuesQueueidWrapupcodesPostWithHttpInfo(queueId, codeId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add up to 100 wrap-up codes to a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > RoutingQueuesQueueidWrapupcodesPostWithHttpInfo (string queueId, string codeId, List<WrapupCode> body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidWrapupcodesPost");
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->RoutingQueuesQueueidWrapupcodesPost");

            var localVarPath = "/api/v1/routing/queues/{queueId}/wrapupcodes";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (codeId != null) localVarPathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidWrapupcodesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidWrapupcodesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        /// <summary>
        /// Add up to 100 wrap-up codes to a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> RoutingQueuesQueueidWrapupcodesPostAsync (string queueId, string codeId, List<WrapupCode> body = null)
        {
             ApiResponse<WrapupCode> localVarResponse = await RoutingQueuesQueueidWrapupcodesPostAsyncWithHttpInfo(queueId, codeId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add up to 100 wrap-up codes to a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> RoutingQueuesQueueidWrapupcodesPostAsyncWithHttpInfo (string queueId, string codeId, List<WrapupCode> body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidWrapupcodesPost");
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->RoutingQueuesQueueidWrapupcodesPost");

            var localVarPath = "/api/v1/routing/queues/{queueId}/wrapupcodes";
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
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (codeId != null) localVarPathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidWrapupcodesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidWrapupcodesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        /// <summary>
        /// Get the list of skills. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>SkillEntityListing</returns>
        public SkillEntityListing RoutingSkillsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null)
        {
             ApiResponse<SkillEntityListing> localVarResponse = RoutingSkillsGetWithHttpInfo(pageSize, pageNumber, sortBy, name);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of skills. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>ApiResponse of SkillEntityListing</returns>
        public ApiResponse< SkillEntityListing > RoutingSkillsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null)
        {

            var localVarPath = "/api/v1/routing/skills";
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
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingSkillsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingSkillsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SkillEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SkillEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SkillEntityListing)));
            
        }

        /// <summary>
        /// Get the list of skills. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of SkillEntityListing</returns>
        public async System.Threading.Tasks.Task<SkillEntityListing> RoutingSkillsGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null)
        {
             ApiResponse<SkillEntityListing> localVarResponse = await RoutingSkillsGetAsyncWithHttpInfo(pageSize, pageNumber, sortBy, name);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of skills. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of ApiResponse (SkillEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SkillEntityListing>> RoutingSkillsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null)
        {

            var localVarPath = "/api/v1/routing/skills";
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
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingSkillsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingSkillsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SkillEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SkillEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SkillEntityListing)));
            
        }

        /// <summary>
        /// Delete utilization settings and revert to system defaults. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>string</returns>
        public string RoutingUtilizationDelete ()
        {
             ApiResponse<string> localVarResponse = RoutingUtilizationDeleteWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete utilization settings and revert to system defaults. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > RoutingUtilizationDeleteWithHttpInfo ()
        {

            var localVarPath = "/api/v1/routing/utilization";
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingUtilizationDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingUtilizationDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete utilization settings and revert to system defaults. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RoutingUtilizationDeleteAsync ()
        {
             ApiResponse<string> localVarResponse = await RoutingUtilizationDeleteAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete utilization settings and revert to system defaults. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> RoutingUtilizationDeleteAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/routing/utilization";
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingUtilizationDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingUtilizationDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Utilization</returns>
        public Utilization RoutingUtilizationGet ()
        {
             ApiResponse<Utilization> localVarResponse = RoutingUtilizationGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Utilization</returns>
        public ApiResponse< Utilization > RoutingUtilizationGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/routing/utilization";
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingUtilizationGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingUtilizationGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Utilization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Utilization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Utilization)));
            
        }

        /// <summary>
        /// Get the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Utilization</returns>
        public async System.Threading.Tasks.Task<Utilization> RoutingUtilizationGetAsync ()
        {
             ApiResponse<Utilization> localVarResponse = await RoutingUtilizationGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Utilization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Utilization>> RoutingUtilizationGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/routing/utilization";
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingUtilizationGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingUtilizationGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Utilization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Utilization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Utilization)));
            
        }

        /// <summary>
        /// Update the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">utilization (optional)</param>
        /// <returns>Utilization</returns>
        public Utilization RoutingUtilizationPut (Utilization body = null)
        {
             ApiResponse<Utilization> localVarResponse = RoutingUtilizationPutWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">utilization (optional)</param>
        /// <returns>ApiResponse of Utilization</returns>
        public ApiResponse< Utilization > RoutingUtilizationPutWithHttpInfo (Utilization body = null)
        {

            var localVarPath = "/api/v1/routing/utilization";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RoutingUtilizationPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingUtilizationPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Utilization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Utilization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Utilization)));
            
        }

        /// <summary>
        /// Update the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">utilization (optional)</param>
        /// <returns>Task of Utilization</returns>
        public async System.Threading.Tasks.Task<Utilization> RoutingUtilizationPutAsync (Utilization body = null)
        {
             ApiResponse<Utilization> localVarResponse = await RoutingUtilizationPutAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">utilization (optional)</param>
        /// <returns>Task of ApiResponse (Utilization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Utilization>> RoutingUtilizationPutAsyncWithHttpInfo (Utilization body = null)
        {

            var localVarPath = "/api/v1/routing/utilization";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RoutingUtilizationPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingUtilizationPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Utilization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Utilization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Utilization)));
            
        }

        /// <summary>
        /// Delete wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>string</returns>
        public string RoutingWrapupcodesCodeidDelete (string codeId)
        {
             ApiResponse<string> localVarResponse = RoutingWrapupcodesCodeidDeleteWithHttpInfo(codeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > RoutingWrapupcodesCodeidDeleteWithHttpInfo (string codeId)
        {
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->RoutingWrapupcodesCodeidDelete");

            var localVarPath = "/api/v1/routing/wrapupcodes/{codeId}";
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
            if (codeId != null) localVarPathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesCodeidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesCodeidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RoutingWrapupcodesCodeidDeleteAsync (string codeId)
        {
             ApiResponse<string> localVarResponse = await RoutingWrapupcodesCodeidDeleteAsyncWithHttpInfo(codeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> RoutingWrapupcodesCodeidDeleteAsyncWithHttpInfo (string codeId)
        {
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->RoutingWrapupcodesCodeidDelete");

            var localVarPath = "/api/v1/routing/wrapupcodes/{codeId}";
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
            if (codeId != null) localVarPathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesCodeidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesCodeidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get details about this wrap-up code. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>WrapupCode</returns>
        public WrapupCode RoutingWrapupcodesCodeidGet (string codeId)
        {
             ApiResponse<WrapupCode> localVarResponse = RoutingWrapupcodesCodeidGetWithHttpInfo(codeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get details about this wrap-up code. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > RoutingWrapupcodesCodeidGetWithHttpInfo (string codeId)
        {
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->RoutingWrapupcodesCodeidGet");

            var localVarPath = "/api/v1/routing/wrapupcodes/{codeId}";
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
            if (codeId != null) localVarPathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesCodeidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesCodeidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        /// <summary>
        /// Get details about this wrap-up code. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> RoutingWrapupcodesCodeidGetAsync (string codeId)
        {
             ApiResponse<WrapupCode> localVarResponse = await RoutingWrapupcodesCodeidGetAsyncWithHttpInfo(codeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get details about this wrap-up code. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> RoutingWrapupcodesCodeidGetAsyncWithHttpInfo (string codeId)
        {
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->RoutingWrapupcodesCodeidGet");

            var localVarPath = "/api/v1/routing/wrapupcodes/{codeId}";
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
            if (codeId != null) localVarPathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesCodeidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesCodeidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        /// <summary>
        /// Update wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>WrapupCode</returns>
        public WrapupCode RoutingWrapupcodesCodeidPut (string codeId, WrapupCode body = null)
        {
             ApiResponse<WrapupCode> localVarResponse = RoutingWrapupcodesCodeidPutWithHttpInfo(codeId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > RoutingWrapupcodesCodeidPutWithHttpInfo (string codeId, WrapupCode body = null)
        {
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->RoutingWrapupcodesCodeidPut");

            var localVarPath = "/api/v1/routing/wrapupcodes/{codeId}";
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
            if (codeId != null) localVarPathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesCodeidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesCodeidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        /// <summary>
        /// Update wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> RoutingWrapupcodesCodeidPutAsync (string codeId, WrapupCode body = null)
        {
             ApiResponse<WrapupCode> localVarResponse = await RoutingWrapupcodesCodeidPutAsyncWithHttpInfo(codeId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> RoutingWrapupcodesCodeidPutAsyncWithHttpInfo (string codeId, WrapupCode body = null)
        {
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->RoutingWrapupcodesCodeidPut");

            var localVarPath = "/api/v1/routing/wrapupcodes/{codeId}";
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
            if (codeId != null) localVarPathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesCodeidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesCodeidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        /// <summary>
        /// Get list of wrapup codes. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>WrapupCodeEntityListing</returns>
        public WrapupCodeEntityListing RoutingWrapupcodesGet (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {
             ApiResponse<WrapupCodeEntityListing> localVarResponse = RoutingWrapupcodesGetWithHttpInfo(pageSize, pageNumber, sortBy);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of wrapup codes. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>ApiResponse of WrapupCodeEntityListing</returns>
        public ApiResponse< WrapupCodeEntityListing > RoutingWrapupcodesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {

            var localVarPath = "/api/v1/routing/wrapupcodes";
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
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCodeEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCodeEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCodeEntityListing)));
            
        }

        /// <summary>
        /// Get list of wrapup codes. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>Task of WrapupCodeEntityListing</returns>
        public async System.Threading.Tasks.Task<WrapupCodeEntityListing> RoutingWrapupcodesGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {
             ApiResponse<WrapupCodeEntityListing> localVarResponse = await RoutingWrapupcodesGetAsyncWithHttpInfo(pageSize, pageNumber, sortBy);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of wrapup codes. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>Task of ApiResponse (WrapupCodeEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCodeEntityListing>> RoutingWrapupcodesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {

            var localVarPath = "/api/v1/routing/wrapupcodes";
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
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCodeEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCodeEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCodeEntityListing)));
            
        }

        /// <summary>
        /// Create a wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>CallableTimeSet</returns>
        public CallableTimeSet RoutingWrapupcodesPost (WrapupCode body = null)
        {
             ApiResponse<CallableTimeSet> localVarResponse = RoutingWrapupcodesPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        public ApiResponse< CallableTimeSet > RoutingWrapupcodesPostWithHttpInfo (WrapupCode body = null)
        {

            var localVarPath = "/api/v1/routing/wrapupcodes";
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSet)));
            
        }

        /// <summary>
        /// Create a wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>Task of CallableTimeSet</returns>
        public async System.Threading.Tasks.Task<CallableTimeSet> RoutingWrapupcodesPostAsync (WrapupCode body = null)
        {
             ApiResponse<CallableTimeSet> localVarResponse = await RoutingWrapupcodesPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> RoutingWrapupcodesPostAsyncWithHttpInfo (WrapupCode body = null)
        {

            var localVarPath = "/api/v1/routing/wrapupcodes";
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
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSet)));
            
        }

    }
}
