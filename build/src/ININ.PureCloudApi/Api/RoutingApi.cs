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
    public interface IRoutingApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">domain ID</param>
        /// <returns>string</returns>
        string DeleteEmailDomainsDomainId (string domainId);

        /// <summary>
        /// Delete a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">domain ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteEmailDomainsDomainIdWithHttpInfo (string domainId);
        /// <summary>
        /// Delete a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="routeId">route ID</param>
        /// <returns>string</returns>
        string DeleteEmailDomainsDomainnameRoutesRouteId (string domainName, string routeId);

        /// <summary>
        /// Delete a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="routeId">route ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteEmailDomainsDomainnameRoutesRouteIdWithHttpInfo (string domainName, string routeId);
        /// <summary>
        /// Delete a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="forceDelete"> (optional)</param>
        /// <returns>string</returns>
        string DeleteQueuesQueueId (string queueId, bool? forceDelete = null);

        /// <summary>
        /// Delete a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="forceDelete"> (optional)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteQueuesQueueIdWithHttpInfo (string queueId, bool? forceDelete = null);
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
        string DeleteQueuesQueueIdUsersMemberId (string queueId, string memberId);

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
        ApiResponse<string> DeleteQueuesQueueIdUsersMemberIdWithHttpInfo (string queueId, string memberId);
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
        string DeleteQueuesQueueIdWrapupcodesCodeId (string queueId, string codeId);

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
        ApiResponse<string> DeleteQueuesQueueIdWrapupcodesCodeIdWithHttpInfo (string queueId, string codeId);
        /// <summary>
        /// Delete Routing Skill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skillId">Skill ID</param>
        /// <returns>string</returns>
        string DeleteSkillsSkillId (string skillId);

        /// <summary>
        /// Delete Routing Skill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skillId">Skill ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteSkillsSkillIdWithHttpInfo (string skillId);
        /// <summary>
        /// Remove routing skill from user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId"></param>
        /// <returns>string</returns>
        string DeleteUserIdRoutingskillsSkillId (string userId, string skillId);

        /// <summary>
        /// Remove routing skill from user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteUserIdRoutingskillsSkillIdWithHttpInfo (string userId, string skillId);
        /// <summary>
        /// Delete utilization settings and revert to system defaults.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>string</returns>
        string DeleteUtilization ();

        /// <summary>
        /// Delete utilization settings and revert to system defaults.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteUtilizationWithHttpInfo ();
        /// <summary>
        /// Delete wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>string</returns>
        string DeleteWrapupcodesCodeId (string codeId);

        /// <summary>
        /// Delete wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteWrapupcodesCodeIdWithHttpInfo (string codeId);
        /// <summary>
        /// Get domains
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InboundDomainEntityListing</returns>
        InboundDomainEntityListing GetEmailDomains ();

        /// <summary>
        /// Get domains
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InboundDomainEntityListing</returns>
        ApiResponse<InboundDomainEntityListing> GetEmailDomainsWithHttpInfo ();
        /// <summary>
        /// Get routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <returns>InboundRouteEntityListing</returns>
        InboundRouteEntityListing GetEmailDomainsDomainnameRoutes (string domainName);

        /// <summary>
        /// Get routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <returns>ApiResponse of InboundRouteEntityListing</returns>
        ApiResponse<InboundRouteEntityListing> GetEmailDomainsDomainnameRoutesWithHttpInfo (string domainName);
        /// <summary>
        /// Get a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="routeId">route ID</param>
        /// <returns>InboundRoute</returns>
        InboundRoute GetEmailDomainsDomainnameRoutesRouteId (string domainName, string routeId);

        /// <summary>
        /// Get a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="routeId">route ID</param>
        /// <returns>ApiResponse of InboundRoute</returns>
        ApiResponse<InboundRoute> GetEmailDomainsDomainnameRoutesRouteIdWithHttpInfo (string domainName, string routeId);
        /// <summary>
        /// Get email setup
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EmailSetup</returns>
        EmailSetup GetEmailSetup ();

        /// <summary>
        /// Get email setup
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EmailSetup</returns>
        ApiResponse<EmailSetup> GetEmailSetupWithHttpInfo ();
        /// <summary>
        /// Get list of queues.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="active">Active (optional)</param>
        /// <returns>QueueEntityListing</returns>
        QueueEntityListing GetQueues (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null);

        /// <summary>
        /// Get list of queues.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="active">Active (optional)</param>
        /// <returns>ApiResponse of QueueEntityListing</returns>
        ApiResponse<QueueEntityListing> GetQueuesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null);
        /// <summary>
        /// Get details about this queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Queue</returns>
        Queue GetQueuesQueueId (string queueId);

        /// <summary>
        /// Get details about this queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>ApiResponse of Queue</returns>
        ApiResponse<Queue> GetQueuesQueueIdWithHttpInfo (string queueId);
        /// <summary>
        /// Get Estimated Wait Time
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">queueId</param>
        /// <param name="conversationId">conversationId (optional)</param>
        /// <returns>EstimatedWaitTimePredictions</returns>
        EstimatedWaitTimePredictions GetQueuesQueueIdEstimatedwaittime (string queueId, string conversationId = null);

        /// <summary>
        /// Get Estimated Wait Time
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">queueId</param>
        /// <param name="conversationId">conversationId (optional)</param>
        /// <returns>ApiResponse of EstimatedWaitTimePredictions</returns>
        ApiResponse<EstimatedWaitTimePredictions> GetQueuesQueueIdEstimatedwaittimeWithHttpInfo (string queueId, string conversationId = null);
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
        QueueMember GetQueuesQueueIdUsers (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null);

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
        ApiResponse<QueueMember> GetQueuesQueueIdUsersWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null);
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
        WrapupCode GetQueuesQueueIdWrapupcodes (string queueId, string codeId);

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
        ApiResponse<WrapupCode> GetQueuesQueueIdWrapupcodesWithHttpInfo (string queueId, string codeId);
        /// <summary>
        /// Get the list of routing skills.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>SkillEntityListing</returns>
        SkillEntityListing GetSkills (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get the list of routing skills.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of SkillEntityListing</returns>
        ApiResponse<SkillEntityListing> GetSkillsWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get Routing Skill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skillId">Skill ID</param>
        /// <returns>RoutingSkill</returns>
        RoutingSkill GetSkillsSkillId (string skillId);

        /// <summary>
        /// Get Routing Skill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skillId">Skill ID</param>
        /// <returns>ApiResponse of RoutingSkill</returns>
        ApiResponse<RoutingSkill> GetSkillsSkillIdWithHttpInfo (string skillId);
        /// <summary>
        /// List routing skills for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <returns>UserSkillEntityListing</returns>
        UserSkillEntityListing GetUserIdRoutingskills (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);

        /// <summary>
        /// List routing skills for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <returns>ApiResponse of UserSkillEntityListing</returns>
        ApiResponse<UserSkillEntityListing> GetUserIdRoutingskillsWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);
        /// <summary>
        /// Get the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Utilization</returns>
        Utilization GetUtilization ();

        /// <summary>
        /// Get the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Utilization</returns>
        ApiResponse<Utilization> GetUtilizationWithHttpInfo ();
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
        WrapupCodeEntityListing GetWrapupcodes (int? pageSize = null, int? pageNumber = null, string sortBy = null);

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
        ApiResponse<WrapupCodeEntityListing> GetWrapupcodesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null);
        /// <summary>
        /// Get details about this wrap-up code.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>WrapupCode</returns>
        WrapupCode GetWrapupcodesCodeId (string codeId);

        /// <summary>
        /// Get details about this wrap-up code.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> GetWrapupcodesCodeIdWithHttpInfo (string codeId);
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
        QueueMember PatchQueuesQueueIdUsers (string queueId, List<QueueMember> body = null);

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
        ApiResponse<QueueMember> PatchQueuesQueueIdUsersWithHttpInfo (string queueId, List<QueueMember> body = null);
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
        QueueMember PatchQueuesQueueIdUsersMemberId (string queueId, string memberId, QueueMember body = null);

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
        ApiResponse<QueueMember> PatchQueuesQueueIdUsersMemberIdWithHttpInfo (string queueId, string memberId, QueueMember body = null);
        /// <summary>
        /// Create a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Domain (optional)</param>
        /// <returns>InboundDomain</returns>
        InboundDomain PostEmailDomains (InboundDomain body = null);

        /// <summary>
        /// Create a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Domain (optional)</param>
        /// <returns>ApiResponse of InboundDomain</returns>
        ApiResponse<InboundDomain> PostEmailDomainsWithHttpInfo (InboundDomain body = null);
        /// <summary>
        /// Create a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>InboundRoute</returns>
        InboundRoute PostEmailDomainsDomainnameRoutes (string domainName, InboundRoute body = null);

        /// <summary>
        /// Create a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>ApiResponse of InboundRoute</returns>
        ApiResponse<InboundRoute> PostEmailDomainsDomainnameRoutesWithHttpInfo (string domainName, InboundRoute body = null);
        /// <summary>
        /// Create queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Queue</returns>
        Queue PostQueues (Queue body = null);

        /// <summary>
        /// Create queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Queue (optional)</param>
        /// <returns>ApiResponse of Queue</returns>
        ApiResponse<Queue> PostQueuesWithHttpInfo (Queue body = null);
        /// <summary>
        /// Query for queue observations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>ObservationQueryResponse</returns>
        ObservationQueryResponse PostQueuesObservationsQuery (ObservationQuery body = null);

        /// <summary>
        /// Query for queue observations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>ApiResponse of ObservationQueryResponse</returns>
        ApiResponse<ObservationQueryResponse> PostQueuesObservationsQueryWithHttpInfo (ObservationQuery body = null);
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
        QueueMember PostQueuesQueueIdUsers (string queueId, List<QueueMember> body = null, bool? delete = null);

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
        ApiResponse<QueueMember> PostQueuesQueueIdUsersWithHttpInfo (string queueId, List<QueueMember> body = null, bool? delete = null);
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
        WrapupCode PostQueuesQueueIdWrapupcodes (string queueId, string codeId, List<WrapupCode> body = null);

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
        ApiResponse<WrapupCode> PostQueuesQueueIdWrapupcodesWithHttpInfo (string queueId, string codeId, List<WrapupCode> body = null);
        /// <summary>
        /// Create Skill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Skill (optional)</param>
        /// <returns>RoutingSkill</returns>
        RoutingSkill PostSkills (RoutingSkill body = null);

        /// <summary>
        /// Create Skill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Skill (optional)</param>
        /// <returns>ApiResponse of RoutingSkill</returns>
        ApiResponse<RoutingSkill> PostSkillsWithHttpInfo (RoutingSkill body = null);
        /// <summary>
        /// Add routing skill to user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>UserRoutingSkill</returns>
        UserRoutingSkill PostUserIdRoutingskills (string userId, UserRoutingSkill body = null);

        /// <summary>
        /// Add routing skill to user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>ApiResponse of UserRoutingSkill</returns>
        ApiResponse<UserRoutingSkill> PostUserIdRoutingskillsWithHttpInfo (string userId, UserRoutingSkill body = null);
        /// <summary>
        /// Create a wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>CallableTimeSet</returns>
        CallableTimeSet PostWrapupcodes (WrapupCode body = null);

        /// <summary>
        /// Create a wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        ApiResponse<CallableTimeSet> PostWrapupcodesWithHttpInfo (WrapupCode body = null);
        /// <summary>
        /// Update a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="routeId">route ID</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>InboundRoute</returns>
        InboundRoute PutEmailDomainsDomainnameRoutesRouteId (string domainName, string routeId, InboundRoute body = null);

        /// <summary>
        /// Update a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="routeId">route ID</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>ApiResponse of InboundRoute</returns>
        ApiResponse<InboundRoute> PutEmailDomainsDomainnameRoutesRouteIdWithHttpInfo (string domainName, string routeId, InboundRoute body = null);
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
        Queue PutQueuesQueueId (string queueId, Queue body = null);

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
        ApiResponse<Queue> PutQueuesQueueIdWithHttpInfo (string queueId, Queue body = null);
        /// <summary>
        /// Update routing skill proficiency or state.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId"></param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>UserRoutingSkill</returns>
        UserRoutingSkill PutUserIdRoutingskillsSkillId (string userId, string skillId, UserRoutingSkill body = null);

        /// <summary>
        /// Update routing skill proficiency or state.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId"></param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>ApiResponse of UserRoutingSkill</returns>
        ApiResponse<UserRoutingSkill> PutUserIdRoutingskillsSkillIdWithHttpInfo (string userId, string skillId, UserRoutingSkill body = null);
        /// <summary>
        /// Update the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">utilization (optional)</param>
        /// <returns>Utilization</returns>
        Utilization PutUtilization (Utilization body = null);

        /// <summary>
        /// Update the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">utilization (optional)</param>
        /// <returns>ApiResponse of Utilization</returns>
        ApiResponse<Utilization> PutUtilizationWithHttpInfo (Utilization body = null);
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
        WrapupCode PutWrapupcodesCodeId (string codeId, WrapupCode body = null);

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
        ApiResponse<WrapupCode> PutWrapupcodesCodeIdWithHttpInfo (string codeId, WrapupCode body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">domain ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteEmailDomainsDomainIdAsync (string domainId);

        /// <summary>
        /// Delete a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">domain ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteEmailDomainsDomainIdAsyncWithHttpInfo (string domainId);
        /// <summary>
        /// Delete a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="routeId">route ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteEmailDomainsDomainnameRoutesRouteIdAsync (string domainName, string routeId);

        /// <summary>
        /// Delete a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="routeId">route ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteEmailDomainsDomainnameRoutesRouteIdAsyncWithHttpInfo (string domainName, string routeId);
        /// <summary>
        /// Delete a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="forceDelete"> (optional)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteQueuesQueueIdAsync (string queueId, bool? forceDelete = null);

        /// <summary>
        /// Delete a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="forceDelete"> (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteQueuesQueueIdAsyncWithHttpInfo (string queueId, bool? forceDelete = null);
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
        System.Threading.Tasks.Task<string> DeleteQueuesQueueIdUsersMemberIdAsync (string queueId, string memberId);

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
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteQueuesQueueIdUsersMemberIdAsyncWithHttpInfo (string queueId, string memberId);
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
        System.Threading.Tasks.Task<string> DeleteQueuesQueueIdWrapupcodesCodeIdAsync (string queueId, string codeId);

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
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteQueuesQueueIdWrapupcodesCodeIdAsyncWithHttpInfo (string queueId, string codeId);
        /// <summary>
        /// Delete Routing Skill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skillId">Skill ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteSkillsSkillIdAsync (string skillId);

        /// <summary>
        /// Delete Routing Skill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skillId">Skill ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteSkillsSkillIdAsyncWithHttpInfo (string skillId);
        /// <summary>
        /// Remove routing skill from user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId"></param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteUserIdRoutingskillsSkillIdAsync (string userId, string skillId);

        /// <summary>
        /// Remove routing skill from user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteUserIdRoutingskillsSkillIdAsyncWithHttpInfo (string userId, string skillId);
        /// <summary>
        /// Delete utilization settings and revert to system defaults.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteUtilizationAsync ();

        /// <summary>
        /// Delete utilization settings and revert to system defaults.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteUtilizationAsyncWithHttpInfo ();
        /// <summary>
        /// Delete wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteWrapupcodesCodeIdAsync (string codeId);

        /// <summary>
        /// Delete wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteWrapupcodesCodeIdAsyncWithHttpInfo (string codeId);
        /// <summary>
        /// Get domains
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InboundDomainEntityListing</returns>
        System.Threading.Tasks.Task<InboundDomainEntityListing> GetEmailDomainsAsync ();

        /// <summary>
        /// Get domains
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InboundDomainEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundDomainEntityListing>> GetEmailDomainsAsyncWithHttpInfo ();
        /// <summary>
        /// Get routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <returns>Task of InboundRouteEntityListing</returns>
        System.Threading.Tasks.Task<InboundRouteEntityListing> GetEmailDomainsDomainnameRoutesAsync (string domainName);

        /// <summary>
        /// Get routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <returns>Task of ApiResponse (InboundRouteEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundRouteEntityListing>> GetEmailDomainsDomainnameRoutesAsyncWithHttpInfo (string domainName);
        /// <summary>
        /// Get a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="routeId">route ID</param>
        /// <returns>Task of InboundRoute</returns>
        System.Threading.Tasks.Task<InboundRoute> GetEmailDomainsDomainnameRoutesRouteIdAsync (string domainName, string routeId);

        /// <summary>
        /// Get a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="routeId">route ID</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundRoute>> GetEmailDomainsDomainnameRoutesRouteIdAsyncWithHttpInfo (string domainName, string routeId);
        /// <summary>
        /// Get email setup
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EmailSetup</returns>
        System.Threading.Tasks.Task<EmailSetup> GetEmailSetupAsync ();

        /// <summary>
        /// Get email setup
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EmailSetup)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailSetup>> GetEmailSetupAsyncWithHttpInfo ();
        /// <summary>
        /// Get list of queues.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="active">Active (optional)</param>
        /// <returns>Task of QueueEntityListing</returns>
        System.Threading.Tasks.Task<QueueEntityListing> GetQueuesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null);

        /// <summary>
        /// Get list of queues.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="active">Active (optional)</param>
        /// <returns>Task of ApiResponse (QueueEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueEntityListing>> GetQueuesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null);
        /// <summary>
        /// Get details about this queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of Queue</returns>
        System.Threading.Tasks.Task<Queue> GetQueuesQueueIdAsync (string queueId);

        /// <summary>
        /// Get details about this queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        System.Threading.Tasks.Task<ApiResponse<Queue>> GetQueuesQueueIdAsyncWithHttpInfo (string queueId);
        /// <summary>
        /// Get Estimated Wait Time
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">queueId</param>
        /// <param name="conversationId">conversationId (optional)</param>
        /// <returns>Task of EstimatedWaitTimePredictions</returns>
        System.Threading.Tasks.Task<EstimatedWaitTimePredictions> GetQueuesQueueIdEstimatedwaittimeAsync (string queueId, string conversationId = null);

        /// <summary>
        /// Get Estimated Wait Time
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">queueId</param>
        /// <param name="conversationId">conversationId (optional)</param>
        /// <returns>Task of ApiResponse (EstimatedWaitTimePredictions)</returns>
        System.Threading.Tasks.Task<ApiResponse<EstimatedWaitTimePredictions>> GetQueuesQueueIdEstimatedwaittimeAsyncWithHttpInfo (string queueId, string conversationId = null);
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
        System.Threading.Tasks.Task<QueueMember> GetQueuesQueueIdUsersAsync (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null);

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
        System.Threading.Tasks.Task<ApiResponse<QueueMember>> GetQueuesQueueIdUsersAsyncWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null);
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
        System.Threading.Tasks.Task<WrapupCode> GetQueuesQueueIdWrapupcodesAsync (string queueId, string codeId);

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
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetQueuesQueueIdWrapupcodesAsyncWithHttpInfo (string queueId, string codeId);
        /// <summary>
        /// Get the list of routing skills.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of SkillEntityListing</returns>
        System.Threading.Tasks.Task<SkillEntityListing> GetSkillsAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get the list of routing skills.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (SkillEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SkillEntityListing>> GetSkillsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get Routing Skill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skillId">Skill ID</param>
        /// <returns>Task of RoutingSkill</returns>
        System.Threading.Tasks.Task<RoutingSkill> GetSkillsSkillIdAsync (string skillId);

        /// <summary>
        /// Get Routing Skill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skillId">Skill ID</param>
        /// <returns>Task of ApiResponse (RoutingSkill)</returns>
        System.Threading.Tasks.Task<ApiResponse<RoutingSkill>> GetSkillsSkillIdAsyncWithHttpInfo (string skillId);
        /// <summary>
        /// List routing skills for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <returns>Task of UserSkillEntityListing</returns>
        System.Threading.Tasks.Task<UserSkillEntityListing> GetUserIdRoutingskillsAsync (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);

        /// <summary>
        /// List routing skills for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <returns>Task of ApiResponse (UserSkillEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserSkillEntityListing>> GetUserIdRoutingskillsAsyncWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);
        /// <summary>
        /// Get the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Utilization</returns>
        System.Threading.Tasks.Task<Utilization> GetUtilizationAsync ();

        /// <summary>
        /// Get the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Utilization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Utilization>> GetUtilizationAsyncWithHttpInfo ();
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
        System.Threading.Tasks.Task<WrapupCodeEntityListing> GetWrapupcodesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null);

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
        System.Threading.Tasks.Task<ApiResponse<WrapupCodeEntityListing>> GetWrapupcodesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null);
        /// <summary>
        /// Get details about this wrap-up code.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> GetWrapupcodesCodeIdAsync (string codeId);

        /// <summary>
        /// Get details about this wrap-up code.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetWrapupcodesCodeIdAsyncWithHttpInfo (string codeId);
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
        System.Threading.Tasks.Task<QueueMember> PatchQueuesQueueIdUsersAsync (string queueId, List<QueueMember> body = null);

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
        System.Threading.Tasks.Task<ApiResponse<QueueMember>> PatchQueuesQueueIdUsersAsyncWithHttpInfo (string queueId, List<QueueMember> body = null);
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
        System.Threading.Tasks.Task<QueueMember> PatchQueuesQueueIdUsersMemberIdAsync (string queueId, string memberId, QueueMember body = null);

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
        System.Threading.Tasks.Task<ApiResponse<QueueMember>> PatchQueuesQueueIdUsersMemberIdAsyncWithHttpInfo (string queueId, string memberId, QueueMember body = null);
        /// <summary>
        /// Create a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Domain (optional)</param>
        /// <returns>Task of InboundDomain</returns>
        System.Threading.Tasks.Task<InboundDomain> PostEmailDomainsAsync (InboundDomain body = null);

        /// <summary>
        /// Create a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Domain (optional)</param>
        /// <returns>Task of ApiResponse (InboundDomain)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundDomain>> PostEmailDomainsAsyncWithHttpInfo (InboundDomain body = null);
        /// <summary>
        /// Create a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>Task of InboundRoute</returns>
        System.Threading.Tasks.Task<InboundRoute> PostEmailDomainsDomainnameRoutesAsync (string domainName, InboundRoute body = null);

        /// <summary>
        /// Create a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundRoute>> PostEmailDomainsDomainnameRoutesAsyncWithHttpInfo (string domainName, InboundRoute body = null);
        /// <summary>
        /// Create queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Task of Queue</returns>
        System.Threading.Tasks.Task<Queue> PostQueuesAsync (Queue body = null);

        /// <summary>
        /// Create queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        System.Threading.Tasks.Task<ApiResponse<Queue>> PostQueuesAsyncWithHttpInfo (Queue body = null);
        /// <summary>
        /// Query for queue observations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>Task of ObservationQueryResponse</returns>
        System.Threading.Tasks.Task<ObservationQueryResponse> PostQueuesObservationsQueryAsync (ObservationQuery body = null);

        /// <summary>
        /// Query for queue observations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>Task of ApiResponse (ObservationQueryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ObservationQueryResponse>> PostQueuesObservationsQueryAsyncWithHttpInfo (ObservationQuery body = null);
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
        System.Threading.Tasks.Task<QueueMember> PostQueuesQueueIdUsersAsync (string queueId, List<QueueMember> body = null, bool? delete = null);

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
        System.Threading.Tasks.Task<ApiResponse<QueueMember>> PostQueuesQueueIdUsersAsyncWithHttpInfo (string queueId, List<QueueMember> body = null, bool? delete = null);
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
        System.Threading.Tasks.Task<WrapupCode> PostQueuesQueueIdWrapupcodesAsync (string queueId, string codeId, List<WrapupCode> body = null);

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
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> PostQueuesQueueIdWrapupcodesAsyncWithHttpInfo (string queueId, string codeId, List<WrapupCode> body = null);
        /// <summary>
        /// Create Skill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Skill (optional)</param>
        /// <returns>Task of RoutingSkill</returns>
        System.Threading.Tasks.Task<RoutingSkill> PostSkillsAsync (RoutingSkill body = null);

        /// <summary>
        /// Create Skill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Skill (optional)</param>
        /// <returns>Task of ApiResponse (RoutingSkill)</returns>
        System.Threading.Tasks.Task<ApiResponse<RoutingSkill>> PostSkillsAsyncWithHttpInfo (RoutingSkill body = null);
        /// <summary>
        /// Add routing skill to user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>Task of UserRoutingSkill</returns>
        System.Threading.Tasks.Task<UserRoutingSkill> PostUserIdRoutingskillsAsync (string userId, UserRoutingSkill body = null);

        /// <summary>
        /// Add routing skill to user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>Task of ApiResponse (UserRoutingSkill)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserRoutingSkill>> PostUserIdRoutingskillsAsyncWithHttpInfo (string userId, UserRoutingSkill body = null);
        /// <summary>
        /// Create a wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>Task of CallableTimeSet</returns>
        System.Threading.Tasks.Task<CallableTimeSet> PostWrapupcodesAsync (WrapupCode body = null);

        /// <summary>
        /// Create a wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> PostWrapupcodesAsyncWithHttpInfo (WrapupCode body = null);
        /// <summary>
        /// Update a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="routeId">route ID</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>Task of InboundRoute</returns>
        System.Threading.Tasks.Task<InboundRoute> PutEmailDomainsDomainnameRoutesRouteIdAsync (string domainName, string routeId, InboundRoute body = null);

        /// <summary>
        /// Update a route
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="routeId">route ID</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundRoute>> PutEmailDomainsDomainnameRoutesRouteIdAsyncWithHttpInfo (string domainName, string routeId, InboundRoute body = null);
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
        System.Threading.Tasks.Task<Queue> PutQueuesQueueIdAsync (string queueId, Queue body = null);

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
        System.Threading.Tasks.Task<ApiResponse<Queue>> PutQueuesQueueIdAsyncWithHttpInfo (string queueId, Queue body = null);
        /// <summary>
        /// Update routing skill proficiency or state.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId"></param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>Task of UserRoutingSkill</returns>
        System.Threading.Tasks.Task<UserRoutingSkill> PutUserIdRoutingskillsSkillIdAsync (string userId, string skillId, UserRoutingSkill body = null);

        /// <summary>
        /// Update routing skill proficiency or state.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId"></param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>Task of ApiResponse (UserRoutingSkill)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserRoutingSkill>> PutUserIdRoutingskillsSkillIdAsyncWithHttpInfo (string userId, string skillId, UserRoutingSkill body = null);
        /// <summary>
        /// Update the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">utilization (optional)</param>
        /// <returns>Task of Utilization</returns>
        System.Threading.Tasks.Task<Utilization> PutUtilizationAsync (Utilization body = null);

        /// <summary>
        /// Update the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">utilization (optional)</param>
        /// <returns>Task of ApiResponse (Utilization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Utilization>> PutUtilizationAsyncWithHttpInfo (Utilization body = null);
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
        System.Threading.Tasks.Task<WrapupCode> PutWrapupcodesCodeIdAsync (string codeId, WrapupCode body = null);

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
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> PutWrapupcodesCodeIdAsyncWithHttpInfo (string codeId, WrapupCode body = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RoutingApi : IRoutingApi
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
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
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
        /// Delete a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">domain ID</param>
        /// <returns>string</returns>
        public string DeleteEmailDomainsDomainId (string domainId)
        {
             ApiResponse<string> localVarResponse = DeleteEmailDomainsDomainIdWithHttpInfo(domainId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">domain ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteEmailDomainsDomainIdWithHttpInfo (string domainId)
        {
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling RoutingApi->DeleteEmailDomainsDomainId");

            var localVarPath = "/api/v2/routing/email/domains/{domainId}";
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
            if (domainId != null) localVarPathParams.Add("domainId", Configuration.ApiClient.ParameterToString(domainId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailDomainsDomainId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailDomainsDomainId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">domain ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteEmailDomainsDomainIdAsync (string domainId)
        {
             ApiResponse<string> localVarResponse = await DeleteEmailDomainsDomainIdAsyncWithHttpInfo(domainId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainId">domain ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteEmailDomainsDomainIdAsyncWithHttpInfo (string domainId)
        {
            // verify the required parameter 'domainId' is set
            if (domainId == null)
                throw new ApiException(400, "Missing required parameter 'domainId' when calling RoutingApi->DeleteEmailDomainsDomainId");

            var localVarPath = "/api/v2/routing/email/domains/{domainId}";
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
            if (domainId != null) localVarPathParams.Add("domainId", Configuration.ApiClient.ParameterToString(domainId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailDomainsDomainId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailDomainsDomainId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="routeId">route ID</param>
        /// <returns>string</returns>
        public string DeleteEmailDomainsDomainnameRoutesRouteId (string domainName, string routeId)
        {
             ApiResponse<string> localVarResponse = DeleteEmailDomainsDomainnameRoutesRouteIdWithHttpInfo(domainName, routeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="routeId">route ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteEmailDomainsDomainnameRoutesRouteIdWithHttpInfo (string domainName, string routeId)
        {
            // verify the required parameter 'domainName' is set
            if (domainName == null)
                throw new ApiException(400, "Missing required parameter 'domainName' when calling RoutingApi->DeleteEmailDomainsDomainnameRoutesRouteId");
            // verify the required parameter 'routeId' is set
            if (routeId == null)
                throw new ApiException(400, "Missing required parameter 'routeId' when calling RoutingApi->DeleteEmailDomainsDomainnameRoutesRouteId");

            var localVarPath = "/api/v2/routing/email/domains/{domainName}/routes/{routeId}";
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
            if (domainName != null) localVarPathParams.Add("domainName", Configuration.ApiClient.ParameterToString(domainName)); // path parameter
            if (routeId != null) localVarPathParams.Add("routeId", Configuration.ApiClient.ParameterToString(routeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailDomainsDomainnameRoutesRouteId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailDomainsDomainnameRoutesRouteId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="routeId">route ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteEmailDomainsDomainnameRoutesRouteIdAsync (string domainName, string routeId)
        {
             ApiResponse<string> localVarResponse = await DeleteEmailDomainsDomainnameRoutesRouteIdAsyncWithHttpInfo(domainName, routeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="routeId">route ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteEmailDomainsDomainnameRoutesRouteIdAsyncWithHttpInfo (string domainName, string routeId)
        {
            // verify the required parameter 'domainName' is set
            if (domainName == null)
                throw new ApiException(400, "Missing required parameter 'domainName' when calling RoutingApi->DeleteEmailDomainsDomainnameRoutesRouteId");
            // verify the required parameter 'routeId' is set
            if (routeId == null)
                throw new ApiException(400, "Missing required parameter 'routeId' when calling RoutingApi->DeleteEmailDomainsDomainnameRoutesRouteId");

            var localVarPath = "/api/v2/routing/email/domains/{domainName}/routes/{routeId}";
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
            if (domainName != null) localVarPathParams.Add("domainName", Configuration.ApiClient.ParameterToString(domainName)); // path parameter
            if (routeId != null) localVarPathParams.Add("routeId", Configuration.ApiClient.ParameterToString(routeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailDomainsDomainnameRoutesRouteId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailDomainsDomainnameRoutesRouteId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="forceDelete"> (optional)</param>
        /// <returns>string</returns>
        public string DeleteQueuesQueueId (string queueId, bool? forceDelete = null)
        {
             ApiResponse<string> localVarResponse = DeleteQueuesQueueIdWithHttpInfo(queueId, forceDelete);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="forceDelete"> (optional)</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteQueuesQueueIdWithHttpInfo (string queueId, bool? forceDelete = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->DeleteQueuesQueueId");

            var localVarPath = "/api/v2/routing/queues/{queueId}";
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
            if (forceDelete != null) localVarQueryParams.Add("forceDelete", Configuration.ApiClient.ParameterToString(forceDelete)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteQueuesQueueId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQueuesQueueId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="forceDelete"> (optional)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteQueuesQueueIdAsync (string queueId, bool? forceDelete = null)
        {
             ApiResponse<string> localVarResponse = await DeleteQueuesQueueIdAsyncWithHttpInfo(queueId, forceDelete);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="forceDelete"> (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteQueuesQueueIdAsyncWithHttpInfo (string queueId, bool? forceDelete = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->DeleteQueuesQueueId");

            var localVarPath = "/api/v2/routing/queues/{queueId}";
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
            if (forceDelete != null) localVarQueryParams.Add("forceDelete", Configuration.ApiClient.ParameterToString(forceDelete)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteQueuesQueueId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQueuesQueueId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// <returns>string</returns>
        public string DeleteQueuesQueueIdUsersMemberId (string queueId, string memberId)
        {
             ApiResponse<string> localVarResponse = DeleteQueuesQueueIdUsersMemberIdWithHttpInfo(queueId, memberId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete queue member 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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

            var localVarPath = "/api/v2/routing/queues/{queueId}/users/{memberId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteQueuesQueueIdUsersMemberId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQueuesQueueIdUsersMemberId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> DeleteQueuesQueueIdUsersMemberIdAsync (string queueId, string memberId)
        {
             ApiResponse<string> localVarResponse = await DeleteQueuesQueueIdUsersMemberIdAsyncWithHttpInfo(queueId, memberId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete queue member 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteQueuesQueueIdUsersMemberIdAsyncWithHttpInfo (string queueId, string memberId)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->DeleteQueuesQueueIdUsersMemberId");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling RoutingApi->DeleteQueuesQueueIdUsersMemberId");

            var localVarPath = "/api/v2/routing/queues/{queueId}/users/{memberId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteQueuesQueueIdUsersMemberId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQueuesQueueIdUsersMemberId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// <returns>string</returns>
        public string DeleteQueuesQueueIdWrapupcodesCodeId (string queueId, string codeId)
        {
             ApiResponse<string> localVarResponse = DeleteQueuesQueueIdWrapupcodesCodeIdWithHttpInfo(queueId, codeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a wrap-up code from a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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

            var localVarPath = "/api/v2/routing/queues/{queueId}/wrapupcodes/{codeId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteQueuesQueueIdWrapupcodesCodeId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQueuesQueueIdWrapupcodesCodeId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> DeleteQueuesQueueIdWrapupcodesCodeIdAsync (string queueId, string codeId)
        {
             ApiResponse<string> localVarResponse = await DeleteQueuesQueueIdWrapupcodesCodeIdAsyncWithHttpInfo(queueId, codeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a wrap-up code from a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteQueuesQueueIdWrapupcodesCodeIdAsyncWithHttpInfo (string queueId, string codeId)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->DeleteQueuesQueueIdWrapupcodesCodeId");
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->DeleteQueuesQueueIdWrapupcodesCodeId");

            var localVarPath = "/api/v2/routing/queues/{queueId}/wrapupcodes/{codeId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteQueuesQueueIdWrapupcodesCodeId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQueuesQueueIdWrapupcodesCodeId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete Routing Skill 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skillId">Skill ID</param>
        /// <returns>string</returns>
        public string DeleteSkillsSkillId (string skillId)
        {
             ApiResponse<string> localVarResponse = DeleteSkillsSkillIdWithHttpInfo(skillId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete Routing Skill 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skillId">Skill ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteSkillsSkillIdWithHttpInfo (string skillId)
        {
            // verify the required parameter 'skillId' is set
            if (skillId == null)
                throw new ApiException(400, "Missing required parameter 'skillId' when calling RoutingApi->DeleteSkillsSkillId");

            var localVarPath = "/api/v2/routing/skills/{skillId}";
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
            if (skillId != null) localVarPathParams.Add("skillId", Configuration.ApiClient.ParameterToString(skillId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSkillsSkillId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSkillsSkillId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete Routing Skill 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skillId">Skill ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteSkillsSkillIdAsync (string skillId)
        {
             ApiResponse<string> localVarResponse = await DeleteSkillsSkillIdAsyncWithHttpInfo(skillId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete Routing Skill 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skillId">Skill ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteSkillsSkillIdAsyncWithHttpInfo (string skillId)
        {
            // verify the required parameter 'skillId' is set
            if (skillId == null)
                throw new ApiException(400, "Missing required parameter 'skillId' when calling RoutingApi->DeleteSkillsSkillId");

            var localVarPath = "/api/v2/routing/skills/{skillId}";
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
            if (skillId != null) localVarPathParams.Add("skillId", Configuration.ApiClient.ParameterToString(skillId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSkillsSkillId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSkillsSkillId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Remove routing skill from user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId"></param>
        /// <returns>string</returns>
        public string DeleteUserIdRoutingskillsSkillId (string userId, string skillId)
        {
             ApiResponse<string> localVarResponse = DeleteUserIdRoutingskillsSkillIdWithHttpInfo(userId, skillId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Remove routing skill from user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId"></param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteUserIdRoutingskillsSkillIdWithHttpInfo (string userId, string skillId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling RoutingApi->DeleteUserIdRoutingskillsSkillId");
            // verify the required parameter 'skillId' is set
            if (skillId == null)
                throw new ApiException(400, "Missing required parameter 'skillId' when calling RoutingApi->DeleteUserIdRoutingskillsSkillId");

            var localVarPath = "/api/v2/users/{userId}/routingskills/{skillId}";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (skillId != null) localVarPathParams.Add("skillId", Configuration.ApiClient.ParameterToString(skillId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserIdRoutingskillsSkillId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserIdRoutingskillsSkillId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Remove routing skill from user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId"></param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteUserIdRoutingskillsSkillIdAsync (string userId, string skillId)
        {
             ApiResponse<string> localVarResponse = await DeleteUserIdRoutingskillsSkillIdAsyncWithHttpInfo(userId, skillId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Remove routing skill from user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteUserIdRoutingskillsSkillIdAsyncWithHttpInfo (string userId, string skillId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling RoutingApi->DeleteUserIdRoutingskillsSkillId");
            // verify the required parameter 'skillId' is set
            if (skillId == null)
                throw new ApiException(400, "Missing required parameter 'skillId' when calling RoutingApi->DeleteUserIdRoutingskillsSkillId");

            var localVarPath = "/api/v2/users/{userId}/routingskills/{skillId}";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (skillId != null) localVarPathParams.Add("skillId", Configuration.ApiClient.ParameterToString(skillId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserIdRoutingskillsSkillId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserIdRoutingskillsSkillId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete utilization settings and revert to system defaults. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>string</returns>
        public string DeleteUtilization ()
        {
             ApiResponse<string> localVarResponse = DeleteUtilizationWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete utilization settings and revert to system defaults. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteUtilizationWithHttpInfo ()
        {

            var localVarPath = "/api/v2/routing/utilization";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteUtilization: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUtilization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete utilization settings and revert to system defaults. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteUtilizationAsync ()
        {
             ApiResponse<string> localVarResponse = await DeleteUtilizationAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete utilization settings and revert to system defaults. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteUtilizationAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/routing/utilization";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteUtilization: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUtilization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>string</returns>
        public string DeleteWrapupcodesCodeId (string codeId)
        {
             ApiResponse<string> localVarResponse = DeleteWrapupcodesCodeIdWithHttpInfo(codeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteWrapupcodesCodeIdWithHttpInfo (string codeId)
        {
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->DeleteWrapupcodesCodeId");

            var localVarPath = "/api/v2/routing/wrapupcodes/{codeId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteWrapupcodesCodeId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWrapupcodesCodeId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> DeleteWrapupcodesCodeIdAsync (string codeId)
        {
             ApiResponse<string> localVarResponse = await DeleteWrapupcodesCodeIdAsyncWithHttpInfo(codeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteWrapupcodesCodeIdAsyncWithHttpInfo (string codeId)
        {
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->DeleteWrapupcodesCodeId");

            var localVarPath = "/api/v2/routing/wrapupcodes/{codeId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteWrapupcodesCodeId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWrapupcodesCodeId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get domains 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InboundDomainEntityListing</returns>
        public InboundDomainEntityListing GetEmailDomains ()
        {
             ApiResponse<InboundDomainEntityListing> localVarResponse = GetEmailDomainsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get domains 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InboundDomainEntityListing</returns>
        public ApiResponse< InboundDomainEntityListing > GetEmailDomainsWithHttpInfo ()
        {

            var localVarPath = "/api/v2/routing/email/domains";
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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailDomains: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailDomains: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundDomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundDomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundDomainEntityListing)));
            
        }

        /// <summary>
        /// Get domains 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InboundDomainEntityListing</returns>
        public async System.Threading.Tasks.Task<InboundDomainEntityListing> GetEmailDomainsAsync ()
        {
             ApiResponse<InboundDomainEntityListing> localVarResponse = await GetEmailDomainsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get domains 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InboundDomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundDomainEntityListing>> GetEmailDomainsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/routing/email/domains";
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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailDomains: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailDomains: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundDomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundDomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundDomainEntityListing)));
            
        }

        /// <summary>
        /// Get routes 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <returns>InboundRouteEntityListing</returns>
        public InboundRouteEntityListing GetEmailDomainsDomainnameRoutes (string domainName)
        {
             ApiResponse<InboundRouteEntityListing> localVarResponse = GetEmailDomainsDomainnameRoutesWithHttpInfo(domainName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get routes 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <returns>ApiResponse of InboundRouteEntityListing</returns>
        public ApiResponse< InboundRouteEntityListing > GetEmailDomainsDomainnameRoutesWithHttpInfo (string domainName)
        {
            // verify the required parameter 'domainName' is set
            if (domainName == null)
                throw new ApiException(400, "Missing required parameter 'domainName' when calling RoutingApi->GetEmailDomainsDomainnameRoutes");

            var localVarPath = "/api/v2/routing/email/domains/{domainName}/routes";
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
            if (domainName != null) localVarPathParams.Add("domainName", Configuration.ApiClient.ParameterToString(domainName)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailDomainsDomainnameRoutes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailDomainsDomainnameRoutes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRouteEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRouteEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRouteEntityListing)));
            
        }

        /// <summary>
        /// Get routes 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <returns>Task of InboundRouteEntityListing</returns>
        public async System.Threading.Tasks.Task<InboundRouteEntityListing> GetEmailDomainsDomainnameRoutesAsync (string domainName)
        {
             ApiResponse<InboundRouteEntityListing> localVarResponse = await GetEmailDomainsDomainnameRoutesAsyncWithHttpInfo(domainName);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get routes 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <returns>Task of ApiResponse (InboundRouteEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundRouteEntityListing>> GetEmailDomainsDomainnameRoutesAsyncWithHttpInfo (string domainName)
        {
            // verify the required parameter 'domainName' is set
            if (domainName == null)
                throw new ApiException(400, "Missing required parameter 'domainName' when calling RoutingApi->GetEmailDomainsDomainnameRoutes");

            var localVarPath = "/api/v2/routing/email/domains/{domainName}/routes";
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
            if (domainName != null) localVarPathParams.Add("domainName", Configuration.ApiClient.ParameterToString(domainName)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailDomainsDomainnameRoutes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailDomainsDomainnameRoutes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRouteEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRouteEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRouteEntityListing)));
            
        }

        /// <summary>
        /// Get a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="routeId">route ID</param>
        /// <returns>InboundRoute</returns>
        public InboundRoute GetEmailDomainsDomainnameRoutesRouteId (string domainName, string routeId)
        {
             ApiResponse<InboundRoute> localVarResponse = GetEmailDomainsDomainnameRoutesRouteIdWithHttpInfo(domainName, routeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="routeId">route ID</param>
        /// <returns>ApiResponse of InboundRoute</returns>
        public ApiResponse< InboundRoute > GetEmailDomainsDomainnameRoutesRouteIdWithHttpInfo (string domainName, string routeId)
        {
            // verify the required parameter 'domainName' is set
            if (domainName == null)
                throw new ApiException(400, "Missing required parameter 'domainName' when calling RoutingApi->GetEmailDomainsDomainnameRoutesRouteId");
            // verify the required parameter 'routeId' is set
            if (routeId == null)
                throw new ApiException(400, "Missing required parameter 'routeId' when calling RoutingApi->GetEmailDomainsDomainnameRoutesRouteId");

            var localVarPath = "/api/v2/routing/email/domains/{domainName}/routes/{routeId}";
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
            if (domainName != null) localVarPathParams.Add("domainName", Configuration.ApiClient.ParameterToString(domainName)); // path parameter
            if (routeId != null) localVarPathParams.Add("routeId", Configuration.ApiClient.ParameterToString(routeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailDomainsDomainnameRoutesRouteId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailDomainsDomainnameRoutesRouteId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRoute)));
            
        }

        /// <summary>
        /// Get a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="routeId">route ID</param>
        /// <returns>Task of InboundRoute</returns>
        public async System.Threading.Tasks.Task<InboundRoute> GetEmailDomainsDomainnameRoutesRouteIdAsync (string domainName, string routeId)
        {
             ApiResponse<InboundRoute> localVarResponse = await GetEmailDomainsDomainnameRoutesRouteIdAsyncWithHttpInfo(domainName, routeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="routeId">route ID</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundRoute>> GetEmailDomainsDomainnameRoutesRouteIdAsyncWithHttpInfo (string domainName, string routeId)
        {
            // verify the required parameter 'domainName' is set
            if (domainName == null)
                throw new ApiException(400, "Missing required parameter 'domainName' when calling RoutingApi->GetEmailDomainsDomainnameRoutesRouteId");
            // verify the required parameter 'routeId' is set
            if (routeId == null)
                throw new ApiException(400, "Missing required parameter 'routeId' when calling RoutingApi->GetEmailDomainsDomainnameRoutesRouteId");

            var localVarPath = "/api/v2/routing/email/domains/{domainName}/routes/{routeId}";
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
            if (domainName != null) localVarPathParams.Add("domainName", Configuration.ApiClient.ParameterToString(domainName)); // path parameter
            if (routeId != null) localVarPathParams.Add("routeId", Configuration.ApiClient.ParameterToString(routeId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailDomainsDomainnameRoutesRouteId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailDomainsDomainnameRoutesRouteId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRoute)));
            
        }

        /// <summary>
        /// Get email setup 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EmailSetup</returns>
        public EmailSetup GetEmailSetup ()
        {
             ApiResponse<EmailSetup> localVarResponse = GetEmailSetupWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get email setup 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EmailSetup</returns>
        public ApiResponse< EmailSetup > GetEmailSetupWithHttpInfo ()
        {

            var localVarPath = "/api/v2/routing/email/setup";
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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailSetup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailSetup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailSetup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailSetup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailSetup)));
            
        }

        /// <summary>
        /// Get email setup 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EmailSetup</returns>
        public async System.Threading.Tasks.Task<EmailSetup> GetEmailSetupAsync ()
        {
             ApiResponse<EmailSetup> localVarResponse = await GetEmailSetupAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get email setup 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EmailSetup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailSetup>> GetEmailSetupAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/routing/email/setup";
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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailSetup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailSetup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailSetup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailSetup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailSetup)));
            
        }

        /// <summary>
        /// Get list of queues. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="active">Active (optional)</param>
        /// <returns>QueueEntityListing</returns>
        public QueueEntityListing GetQueues (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null)
        {
             ApiResponse<QueueEntityListing> localVarResponse = GetQueuesWithHttpInfo(pageSize, pageNumber, sortBy, name, active);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of queues. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="active">Active (optional)</param>
        /// <returns>ApiResponse of QueueEntityListing</returns>
        public ApiResponse< QueueEntityListing > GetQueuesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null)
        {

            var localVarPath = "/api/v2/routing/queues";
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
                throw new ApiException (localVarStatusCode, "Error calling GetQueues: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQueues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueEntityListing)));
            
        }

        /// <summary>
        /// Get list of queues. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="active">Active (optional)</param>
        /// <returns>Task of QueueEntityListing</returns>
        public async System.Threading.Tasks.Task<QueueEntityListing> GetQueuesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null)
        {
             ApiResponse<QueueEntityListing> localVarResponse = await GetQueuesAsyncWithHttpInfo(pageSize, pageNumber, sortBy, name, active);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of queues. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="active">Active (optional)</param>
        /// <returns>Task of ApiResponse (QueueEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueueEntityListing>> GetQueuesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null)
        {

            var localVarPath = "/api/v2/routing/queues";
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
                throw new ApiException (localVarStatusCode, "Error calling GetQueues: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQueues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueEntityListing)));
            
        }

        /// <summary>
        /// Get details about this queue. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Queue</returns>
        public Queue GetQueuesQueueId (string queueId)
        {
             ApiResponse<Queue> localVarResponse = GetQueuesQueueIdWithHttpInfo(queueId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get details about this queue. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>ApiResponse of Queue</returns>
        public ApiResponse< Queue > GetQueuesQueueIdWithHttpInfo (string queueId)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->GetQueuesQueueId");

            var localVarPath = "/api/v2/routing/queues/{queueId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<Queue> GetQueuesQueueIdAsync (string queueId)
        {
             ApiResponse<Queue> localVarResponse = await GetQueuesQueueIdAsyncWithHttpInfo(queueId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get details about this queue. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Queue>> GetQueuesQueueIdAsyncWithHttpInfo (string queueId)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->GetQueuesQueueId");

            var localVarPath = "/api/v2/routing/queues/{queueId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Queue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Queue)));
            
        }

        /// <summary>
        /// Get Estimated Wait Time 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">queueId</param>
        /// <param name="conversationId">conversationId (optional)</param>
        /// <returns>EstimatedWaitTimePredictions</returns>
        public EstimatedWaitTimePredictions GetQueuesQueueIdEstimatedwaittime (string queueId, string conversationId = null)
        {
             ApiResponse<EstimatedWaitTimePredictions> localVarResponse = GetQueuesQueueIdEstimatedwaittimeWithHttpInfo(queueId, conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Estimated Wait Time 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">queueId</param>
        /// <param name="conversationId">conversationId (optional)</param>
        /// <returns>ApiResponse of EstimatedWaitTimePredictions</returns>
        public ApiResponse< EstimatedWaitTimePredictions > GetQueuesQueueIdEstimatedwaittimeWithHttpInfo (string queueId, string conversationId = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->GetQueuesQueueIdEstimatedwaittime");

            var localVarPath = "/api/v2/routing/queues/{queueId}/estimatedwaittime";
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
            if (conversationId != null) localVarQueryParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueIdEstimatedwaittime: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueIdEstimatedwaittime: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EstimatedWaitTimePredictions>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstimatedWaitTimePredictions) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstimatedWaitTimePredictions)));
            
        }

        /// <summary>
        /// Get Estimated Wait Time 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">queueId</param>
        /// <param name="conversationId">conversationId (optional)</param>
        /// <returns>Task of EstimatedWaitTimePredictions</returns>
        public async System.Threading.Tasks.Task<EstimatedWaitTimePredictions> GetQueuesQueueIdEstimatedwaittimeAsync (string queueId, string conversationId = null)
        {
             ApiResponse<EstimatedWaitTimePredictions> localVarResponse = await GetQueuesQueueIdEstimatedwaittimeAsyncWithHttpInfo(queueId, conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Estimated Wait Time 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">queueId</param>
        /// <param name="conversationId">conversationId (optional)</param>
        /// <returns>Task of ApiResponse (EstimatedWaitTimePredictions)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EstimatedWaitTimePredictions>> GetQueuesQueueIdEstimatedwaittimeAsyncWithHttpInfo (string queueId, string conversationId = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->GetQueuesQueueIdEstimatedwaittime");

            var localVarPath = "/api/v2/routing/queues/{queueId}/estimatedwaittime";
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
            if (conversationId != null) localVarQueryParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueIdEstimatedwaittime: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueIdEstimatedwaittime: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EstimatedWaitTimePredictions>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstimatedWaitTimePredictions) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstimatedWaitTimePredictions)));
            
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
        public QueueMember GetQueuesQueueIdUsers (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null)
        {
             ApiResponse<QueueMember> localVarResponse = GetQueuesQueueIdUsersWithHttpInfo(queueId, pageSize, pageNumber, sortBy, expand, directMembers);
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
        public ApiResponse< QueueMember > GetQueuesQueueIdUsersWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->GetQueuesQueueIdUsers");

            var localVarPath = "/api/v2/routing/queues/{queueId}/users";
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
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueIdUsers: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueIdUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<QueueMember> GetQueuesQueueIdUsersAsync (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null)
        {
             ApiResponse<QueueMember> localVarResponse = await GetQueuesQueueIdUsersAsyncWithHttpInfo(queueId, pageSize, pageNumber, sortBy, expand, directMembers);
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
        public async System.Threading.Tasks.Task<ApiResponse<QueueMember>> GetQueuesQueueIdUsersAsyncWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->GetQueuesQueueIdUsers");

            var localVarPath = "/api/v2/routing/queues/{queueId}/users";
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
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueIdUsers: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueIdUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMember)));
            
        }

        /// <summary>
        /// Get the wrap-up codes for a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>WrapupCode</returns>
        public WrapupCode GetQueuesQueueIdWrapupcodes (string queueId, string codeId)
        {
             ApiResponse<WrapupCode> localVarResponse = GetQueuesQueueIdWrapupcodesWithHttpInfo(queueId, codeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the wrap-up codes for a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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

            var localVarPath = "/api/v2/routing/queues/{queueId}/wrapupcodes";
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
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<WrapupCode> GetQueuesQueueIdWrapupcodesAsync (string queueId, string codeId)
        {
             ApiResponse<WrapupCode> localVarResponse = await GetQueuesQueueIdWrapupcodesAsyncWithHttpInfo(queueId, codeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the wrap-up codes for a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetQueuesQueueIdWrapupcodesAsyncWithHttpInfo (string queueId, string codeId)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->GetQueuesQueueIdWrapupcodes");
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->GetQueuesQueueIdWrapupcodes");

            var localVarPath = "/api/v2/routing/queues/{queueId}/wrapupcodes";
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
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        /// <summary>
        /// Get the list of routing skills. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>SkillEntityListing</returns>
        public SkillEntityListing GetSkills (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SkillEntityListing> localVarResponse = GetSkillsWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of routing skills. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of SkillEntityListing</returns>
        public ApiResponse< SkillEntityListing > GetSkillsWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v2/routing/skills";
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
                throw new ApiException (localVarStatusCode, "Error calling GetSkills: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSkills: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SkillEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SkillEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SkillEntityListing)));
            
        }

        /// <summary>
        /// Get the list of routing skills. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of SkillEntityListing</returns>
        public async System.Threading.Tasks.Task<SkillEntityListing> GetSkillsAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SkillEntityListing> localVarResponse = await GetSkillsAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of routing skills. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (SkillEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SkillEntityListing>> GetSkillsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v2/routing/skills";
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
                throw new ApiException (localVarStatusCode, "Error calling GetSkills: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSkills: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SkillEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SkillEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SkillEntityListing)));
            
        }

        /// <summary>
        /// Get Routing Skill 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skillId">Skill ID</param>
        /// <returns>RoutingSkill</returns>
        public RoutingSkill GetSkillsSkillId (string skillId)
        {
             ApiResponse<RoutingSkill> localVarResponse = GetSkillsSkillIdWithHttpInfo(skillId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Routing Skill 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skillId">Skill ID</param>
        /// <returns>ApiResponse of RoutingSkill</returns>
        public ApiResponse< RoutingSkill > GetSkillsSkillIdWithHttpInfo (string skillId)
        {
            // verify the required parameter 'skillId' is set
            if (skillId == null)
                throw new ApiException(400, "Missing required parameter 'skillId' when calling RoutingApi->GetSkillsSkillId");

            var localVarPath = "/api/v2/routing/skills/{skillId}";
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
            if (skillId != null) localVarPathParams.Add("skillId", Configuration.ApiClient.ParameterToString(skillId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetSkillsSkillId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSkillsSkillId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoutingSkill>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoutingSkill) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoutingSkill)));
            
        }

        /// <summary>
        /// Get Routing Skill 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skillId">Skill ID</param>
        /// <returns>Task of RoutingSkill</returns>
        public async System.Threading.Tasks.Task<RoutingSkill> GetSkillsSkillIdAsync (string skillId)
        {
             ApiResponse<RoutingSkill> localVarResponse = await GetSkillsSkillIdAsyncWithHttpInfo(skillId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Routing Skill 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skillId">Skill ID</param>
        /// <returns>Task of ApiResponse (RoutingSkill)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RoutingSkill>> GetSkillsSkillIdAsyncWithHttpInfo (string skillId)
        {
            // verify the required parameter 'skillId' is set
            if (skillId == null)
                throw new ApiException(400, "Missing required parameter 'skillId' when calling RoutingApi->GetSkillsSkillId");

            var localVarPath = "/api/v2/routing/skills/{skillId}";
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
            if (skillId != null) localVarPathParams.Add("skillId", Configuration.ApiClient.ParameterToString(skillId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetSkillsSkillId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSkillsSkillId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoutingSkill>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoutingSkill) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoutingSkill)));
            
        }

        /// <summary>
        /// List routing skills for user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <returns>UserSkillEntityListing</returns>
        public UserSkillEntityListing GetUserIdRoutingskills (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
             ApiResponse<UserSkillEntityListing> localVarResponse = GetUserIdRoutingskillsWithHttpInfo(userId, pageSize, pageNumber, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List routing skills for user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <returns>ApiResponse of UserSkillEntityListing</returns>
        public ApiResponse< UserSkillEntityListing > GetUserIdRoutingskillsWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling RoutingApi->GetUserIdRoutingskills");

            var localVarPath = "/api/v2/users/{userId}/routingskills";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserIdRoutingskills: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserIdRoutingskills: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserSkillEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserSkillEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserSkillEntityListing)));
            
        }

        /// <summary>
        /// List routing skills for user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <returns>Task of UserSkillEntityListing</returns>
        public async System.Threading.Tasks.Task<UserSkillEntityListing> GetUserIdRoutingskillsAsync (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
             ApiResponse<UserSkillEntityListing> localVarResponse = await GetUserIdRoutingskillsAsyncWithHttpInfo(userId, pageSize, pageNumber, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List routing skills for user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <returns>Task of ApiResponse (UserSkillEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserSkillEntityListing>> GetUserIdRoutingskillsAsyncWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling RoutingApi->GetUserIdRoutingskills");

            var localVarPath = "/api/v2/users/{userId}/routingskills";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetUserIdRoutingskills: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserIdRoutingskills: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserSkillEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserSkillEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserSkillEntityListing)));
            
        }

        /// <summary>
        /// Get the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Utilization</returns>
        public Utilization GetUtilization ()
        {
             ApiResponse<Utilization> localVarResponse = GetUtilizationWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Utilization</returns>
        public ApiResponse< Utilization > GetUtilizationWithHttpInfo ()
        {

            var localVarPath = "/api/v2/routing/utilization";
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
                throw new ApiException (localVarStatusCode, "Error calling GetUtilization: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUtilization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Utilization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Utilization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Utilization)));
            
        }

        /// <summary>
        /// Get the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Utilization</returns>
        public async System.Threading.Tasks.Task<Utilization> GetUtilizationAsync ()
        {
             ApiResponse<Utilization> localVarResponse = await GetUtilizationAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Utilization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Utilization>> GetUtilizationAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/routing/utilization";
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
                throw new ApiException (localVarStatusCode, "Error calling GetUtilization: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUtilization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Utilization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Utilization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Utilization)));
            
        }

        /// <summary>
        /// Get list of wrapup codes. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>WrapupCodeEntityListing</returns>
        public WrapupCodeEntityListing GetWrapupcodes (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {
             ApiResponse<WrapupCodeEntityListing> localVarResponse = GetWrapupcodesWithHttpInfo(pageSize, pageNumber, sortBy);
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
        public ApiResponse< WrapupCodeEntityListing > GetWrapupcodesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {

            var localVarPath = "/api/v2/routing/wrapupcodes";
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
                throw new ApiException (localVarStatusCode, "Error calling GetWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<WrapupCodeEntityListing> GetWrapupcodesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {
             ApiResponse<WrapupCodeEntityListing> localVarResponse = await GetWrapupcodesAsyncWithHttpInfo(pageSize, pageNumber, sortBy);
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
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCodeEntityListing>> GetWrapupcodesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {

            var localVarPath = "/api/v2/routing/wrapupcodes";
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
                throw new ApiException (localVarStatusCode, "Error calling GetWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCodeEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCodeEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCodeEntityListing)));
            
        }

        /// <summary>
        /// Get details about this wrap-up code. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>WrapupCode</returns>
        public WrapupCode GetWrapupcodesCodeId (string codeId)
        {
             ApiResponse<WrapupCode> localVarResponse = GetWrapupcodesCodeIdWithHttpInfo(codeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get details about this wrap-up code. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > GetWrapupcodesCodeIdWithHttpInfo (string codeId)
        {
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->GetWrapupcodesCodeId");

            var localVarPath = "/api/v2/routing/wrapupcodes/{codeId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetWrapupcodesCodeId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWrapupcodesCodeId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<WrapupCode> GetWrapupcodesCodeIdAsync (string codeId)
        {
             ApiResponse<WrapupCode> localVarResponse = await GetWrapupcodesCodeIdAsyncWithHttpInfo(codeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get details about this wrap-up code. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetWrapupcodesCodeIdAsyncWithHttpInfo (string codeId)
        {
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->GetWrapupcodesCodeId");

            var localVarPath = "/api/v2/routing/wrapupcodes/{codeId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetWrapupcodesCodeId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWrapupcodesCodeId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        /// <summary>
        /// Join or unjoin a set of users for a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <returns>QueueMember</returns>
        public QueueMember PatchQueuesQueueIdUsers (string queueId, List<QueueMember> body = null)
        {
             ApiResponse<QueueMember> localVarResponse = PatchQueuesQueueIdUsersWithHttpInfo(queueId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Join or unjoin a set of users for a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <returns>ApiResponse of QueueMember</returns>
        public ApiResponse< QueueMember > PatchQueuesQueueIdUsersWithHttpInfo (string queueId, List<QueueMember> body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->PatchQueuesQueueIdUsers");

            var localVarPath = "/api/v2/routing/queues/{queueId}/users";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PatchQueuesQueueIdUsers: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchQueuesQueueIdUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<QueueMember> PatchQueuesQueueIdUsersAsync (string queueId, List<QueueMember> body = null)
        {
             ApiResponse<QueueMember> localVarResponse = await PatchQueuesQueueIdUsersAsyncWithHttpInfo(queueId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Join or unjoin a set of users for a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueueMember>> PatchQueuesQueueIdUsersAsyncWithHttpInfo (string queueId, List<QueueMember> body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->PatchQueuesQueueIdUsers");

            var localVarPath = "/api/v2/routing/queues/{queueId}/users";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PatchQueuesQueueIdUsers: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchQueuesQueueIdUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// <returns>QueueMember</returns>
        public QueueMember PatchQueuesQueueIdUsersMemberId (string queueId, string memberId, QueueMember body = null)
        {
             ApiResponse<QueueMember> localVarResponse = PatchQueuesQueueIdUsersMemberIdWithHttpInfo(queueId, memberId, body);
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
        public ApiResponse< QueueMember > PatchQueuesQueueIdUsersMemberIdWithHttpInfo (string queueId, string memberId, QueueMember body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->PatchQueuesQueueIdUsersMemberId");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling RoutingApi->PatchQueuesQueueIdUsersMemberId");

            var localVarPath = "/api/v2/routing/queues/{queueId}/users/{memberId}";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PatchQueuesQueueIdUsersMemberId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchQueuesQueueIdUsersMemberId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<QueueMember> PatchQueuesQueueIdUsersMemberIdAsync (string queueId, string memberId, QueueMember body = null)
        {
             ApiResponse<QueueMember> localVarResponse = await PatchQueuesQueueIdUsersMemberIdAsyncWithHttpInfo(queueId, memberId, body);
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
        public async System.Threading.Tasks.Task<ApiResponse<QueueMember>> PatchQueuesQueueIdUsersMemberIdAsyncWithHttpInfo (string queueId, string memberId, QueueMember body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->PatchQueuesQueueIdUsersMemberId");
            // verify the required parameter 'memberId' is set
            if (memberId == null)
                throw new ApiException(400, "Missing required parameter 'memberId' when calling RoutingApi->PatchQueuesQueueIdUsersMemberId");

            var localVarPath = "/api/v2/routing/queues/{queueId}/users/{memberId}";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PatchQueuesQueueIdUsersMemberId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchQueuesQueueIdUsersMemberId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMember)));
            
        }

        /// <summary>
        /// Create a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Domain (optional)</param>
        /// <returns>InboundDomain</returns>
        public InboundDomain PostEmailDomains (InboundDomain body = null)
        {
             ApiResponse<InboundDomain> localVarResponse = PostEmailDomainsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Domain (optional)</param>
        /// <returns>ApiResponse of InboundDomain</returns>
        public ApiResponse< InboundDomain > PostEmailDomainsWithHttpInfo (InboundDomain body = null)
        {

            var localVarPath = "/api/v2/routing/email/domains";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostEmailDomains: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEmailDomains: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<InboundDomain> PostEmailDomainsAsync (InboundDomain body = null)
        {
             ApiResponse<InboundDomain> localVarResponse = await PostEmailDomainsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Domain (optional)</param>
        /// <returns>Task of ApiResponse (InboundDomain)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundDomain>> PostEmailDomainsAsyncWithHttpInfo (InboundDomain body = null)
        {

            var localVarPath = "/api/v2/routing/email/domains";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostEmailDomains: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEmailDomains: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundDomain>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundDomain) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundDomain)));
            
        }

        /// <summary>
        /// Create a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>InboundRoute</returns>
        public InboundRoute PostEmailDomainsDomainnameRoutes (string domainName, InboundRoute body = null)
        {
             ApiResponse<InboundRoute> localVarResponse = PostEmailDomainsDomainnameRoutesWithHttpInfo(domainName, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>ApiResponse of InboundRoute</returns>
        public ApiResponse< InboundRoute > PostEmailDomainsDomainnameRoutesWithHttpInfo (string domainName, InboundRoute body = null)
        {
            // verify the required parameter 'domainName' is set
            if (domainName == null)
                throw new ApiException(400, "Missing required parameter 'domainName' when calling RoutingApi->PostEmailDomainsDomainnameRoutes");

            var localVarPath = "/api/v2/routing/email/domains/{domainName}/routes";
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
            if (domainName != null) localVarPathParams.Add("domainName", Configuration.ApiClient.ParameterToString(domainName)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostEmailDomainsDomainnameRoutes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEmailDomainsDomainnameRoutes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRoute)));
            
        }

        /// <summary>
        /// Create a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>Task of InboundRoute</returns>
        public async System.Threading.Tasks.Task<InboundRoute> PostEmailDomainsDomainnameRoutesAsync (string domainName, InboundRoute body = null)
        {
             ApiResponse<InboundRoute> localVarResponse = await PostEmailDomainsDomainnameRoutesAsyncWithHttpInfo(domainName, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundRoute>> PostEmailDomainsDomainnameRoutesAsyncWithHttpInfo (string domainName, InboundRoute body = null)
        {
            // verify the required parameter 'domainName' is set
            if (domainName == null)
                throw new ApiException(400, "Missing required parameter 'domainName' when calling RoutingApi->PostEmailDomainsDomainnameRoutes");

            var localVarPath = "/api/v2/routing/email/domains/{domainName}/routes";
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
            if (domainName != null) localVarPathParams.Add("domainName", Configuration.ApiClient.ParameterToString(domainName)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostEmailDomainsDomainnameRoutes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEmailDomainsDomainnameRoutes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRoute)));
            
        }

        /// <summary>
        /// Create queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Queue</returns>
        public Queue PostQueues (Queue body = null)
        {
             ApiResponse<Queue> localVarResponse = PostQueuesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Queue (optional)</param>
        /// <returns>ApiResponse of Queue</returns>
        public ApiResponse< Queue > PostQueuesWithHttpInfo (Queue body = null)
        {

            var localVarPath = "/api/v2/routing/queues";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostQueues: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQueues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Queue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Queue)));
            
        }

        /// <summary>
        /// Create queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Task of Queue</returns>
        public async System.Threading.Tasks.Task<Queue> PostQueuesAsync (Queue body = null)
        {
             ApiResponse<Queue> localVarResponse = await PostQueuesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Queue>> PostQueuesAsyncWithHttpInfo (Queue body = null)
        {

            var localVarPath = "/api/v2/routing/queues";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostQueues: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQueues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Queue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Queue)));
            
        }

        /// <summary>
        /// Query for queue observations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>ObservationQueryResponse</returns>
        public ObservationQueryResponse PostQueuesObservationsQuery (ObservationQuery body = null)
        {
             ApiResponse<ObservationQueryResponse> localVarResponse = PostQueuesObservationsQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for queue observations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>ApiResponse of ObservationQueryResponse</returns>
        public ApiResponse< ObservationQueryResponse > PostQueuesObservationsQueryWithHttpInfo (ObservationQuery body = null)
        {

            var localVarPath = "/api/v2/analytics/queues/observations/query";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesObservationsQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesObservationsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ObservationQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ObservationQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ObservationQueryResponse)));
            
        }

        /// <summary>
        /// Query for queue observations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>Task of ObservationQueryResponse</returns>
        public async System.Threading.Tasks.Task<ObservationQueryResponse> PostQueuesObservationsQueryAsync (ObservationQuery body = null)
        {
             ApiResponse<ObservationQueryResponse> localVarResponse = await PostQueuesObservationsQueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for queue observations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>Task of ApiResponse (ObservationQueryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ObservationQueryResponse>> PostQueuesObservationsQueryAsyncWithHttpInfo (ObservationQuery body = null)
        {

            var localVarPath = "/api/v2/analytics/queues/observations/query";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesObservationsQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesObservationsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ObservationQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ObservationQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ObservationQueryResponse)));
            
        }

        /// <summary>
        /// Bulk add or delete up to 100 queue members 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <param name="delete">True to delete queue members (optional, default to false)</param>
        /// <returns>QueueMember</returns>
        public QueueMember PostQueuesQueueIdUsers (string queueId, List<QueueMember> body = null, bool? delete = null)
        {
             ApiResponse<QueueMember> localVarResponse = PostQueuesQueueIdUsersWithHttpInfo(queueId, body, delete);
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
        public ApiResponse< QueueMember > PostQueuesQueueIdUsersWithHttpInfo (string queueId, List<QueueMember> body = null, bool? delete = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->PostQueuesQueueIdUsers");

            var localVarPath = "/api/v2/routing/queues/{queueId}/users";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesQueueIdUsers: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesQueueIdUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<QueueMember> PostQueuesQueueIdUsersAsync (string queueId, List<QueueMember> body = null, bool? delete = null)
        {
             ApiResponse<QueueMember> localVarResponse = await PostQueuesQueueIdUsersAsyncWithHttpInfo(queueId, body, delete);
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
        public async System.Threading.Tasks.Task<ApiResponse<QueueMember>> PostQueuesQueueIdUsersAsyncWithHttpInfo (string queueId, List<QueueMember> body = null, bool? delete = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->PostQueuesQueueIdUsers");

            var localVarPath = "/api/v2/routing/queues/{queueId}/users";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesQueueIdUsers: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesQueueIdUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMember)));
            
        }

        /// <summary>
        /// Add up to 100 wrap-up codes to a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>WrapupCode</returns>
        public WrapupCode PostQueuesQueueIdWrapupcodes (string queueId, string codeId, List<WrapupCode> body = null)
        {
             ApiResponse<WrapupCode> localVarResponse = PostQueuesQueueIdWrapupcodesWithHttpInfo(queueId, codeId, body);
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
        public ApiResponse< WrapupCode > PostQueuesQueueIdWrapupcodesWithHttpInfo (string queueId, string codeId, List<WrapupCode> body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->PostQueuesQueueIdWrapupcodes");
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->PostQueuesQueueIdWrapupcodes");

            var localVarPath = "/api/v2/routing/queues/{queueId}/wrapupcodes";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesQueueIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesQueueIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<WrapupCode> PostQueuesQueueIdWrapupcodesAsync (string queueId, string codeId, List<WrapupCode> body = null)
        {
             ApiResponse<WrapupCode> localVarResponse = await PostQueuesQueueIdWrapupcodesAsyncWithHttpInfo(queueId, codeId, body);
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
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> PostQueuesQueueIdWrapupcodesAsyncWithHttpInfo (string queueId, string codeId, List<WrapupCode> body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->PostQueuesQueueIdWrapupcodes");
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->PostQueuesQueueIdWrapupcodes");

            var localVarPath = "/api/v2/routing/queues/{queueId}/wrapupcodes";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesQueueIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesQueueIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        /// <summary>
        /// Create Skill 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Skill (optional)</param>
        /// <returns>RoutingSkill</returns>
        public RoutingSkill PostSkills (RoutingSkill body = null)
        {
             ApiResponse<RoutingSkill> localVarResponse = PostSkillsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Skill 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Skill (optional)</param>
        /// <returns>ApiResponse of RoutingSkill</returns>
        public ApiResponse< RoutingSkill > PostSkillsWithHttpInfo (RoutingSkill body = null)
        {

            var localVarPath = "/api/v2/routing/skills";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostSkills: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSkills: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoutingSkill>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoutingSkill) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoutingSkill)));
            
        }

        /// <summary>
        /// Create Skill 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Skill (optional)</param>
        /// <returns>Task of RoutingSkill</returns>
        public async System.Threading.Tasks.Task<RoutingSkill> PostSkillsAsync (RoutingSkill body = null)
        {
             ApiResponse<RoutingSkill> localVarResponse = await PostSkillsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Skill 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Skill (optional)</param>
        /// <returns>Task of ApiResponse (RoutingSkill)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RoutingSkill>> PostSkillsAsyncWithHttpInfo (RoutingSkill body = null)
        {

            var localVarPath = "/api/v2/routing/skills";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostSkills: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSkills: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoutingSkill>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoutingSkill) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoutingSkill)));
            
        }

        /// <summary>
        /// Add routing skill to user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>UserRoutingSkill</returns>
        public UserRoutingSkill PostUserIdRoutingskills (string userId, UserRoutingSkill body = null)
        {
             ApiResponse<UserRoutingSkill> localVarResponse = PostUserIdRoutingskillsWithHttpInfo(userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add routing skill to user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>ApiResponse of UserRoutingSkill</returns>
        public ApiResponse< UserRoutingSkill > PostUserIdRoutingskillsWithHttpInfo (string userId, UserRoutingSkill body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling RoutingApi->PostUserIdRoutingskills");

            var localVarPath = "/api/v2/users/{userId}/routingskills";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostUserIdRoutingskills: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUserIdRoutingskills: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserRoutingSkill>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserRoutingSkill) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserRoutingSkill)));
            
        }

        /// <summary>
        /// Add routing skill to user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>Task of UserRoutingSkill</returns>
        public async System.Threading.Tasks.Task<UserRoutingSkill> PostUserIdRoutingskillsAsync (string userId, UserRoutingSkill body = null)
        {
             ApiResponse<UserRoutingSkill> localVarResponse = await PostUserIdRoutingskillsAsyncWithHttpInfo(userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add routing skill to user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>Task of ApiResponse (UserRoutingSkill)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserRoutingSkill>> PostUserIdRoutingskillsAsyncWithHttpInfo (string userId, UserRoutingSkill body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling RoutingApi->PostUserIdRoutingskills");

            var localVarPath = "/api/v2/users/{userId}/routingskills";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostUserIdRoutingskills: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUserIdRoutingskills: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserRoutingSkill>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserRoutingSkill) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserRoutingSkill)));
            
        }

        /// <summary>
        /// Create a wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>CallableTimeSet</returns>
        public CallableTimeSet PostWrapupcodes (WrapupCode body = null)
        {
             ApiResponse<CallableTimeSet> localVarResponse = PostWrapupcodesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        public ApiResponse< CallableTimeSet > PostWrapupcodesWithHttpInfo (WrapupCode body = null)
        {

            var localVarPath = "/api/v2/routing/wrapupcodes";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<CallableTimeSet> PostWrapupcodesAsync (WrapupCode body = null)
        {
             ApiResponse<CallableTimeSet> localVarResponse = await PostWrapupcodesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> PostWrapupcodesAsyncWithHttpInfo (WrapupCode body = null)
        {

            var localVarPath = "/api/v2/routing/wrapupcodes";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSet)));
            
        }

        /// <summary>
        /// Update a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="routeId">route ID</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>InboundRoute</returns>
        public InboundRoute PutEmailDomainsDomainnameRoutesRouteId (string domainName, string routeId, InboundRoute body = null)
        {
             ApiResponse<InboundRoute> localVarResponse = PutEmailDomainsDomainnameRoutesRouteIdWithHttpInfo(domainName, routeId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="routeId">route ID</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>ApiResponse of InboundRoute</returns>
        public ApiResponse< InboundRoute > PutEmailDomainsDomainnameRoutesRouteIdWithHttpInfo (string domainName, string routeId, InboundRoute body = null)
        {
            // verify the required parameter 'domainName' is set
            if (domainName == null)
                throw new ApiException(400, "Missing required parameter 'domainName' when calling RoutingApi->PutEmailDomainsDomainnameRoutesRouteId");
            // verify the required parameter 'routeId' is set
            if (routeId == null)
                throw new ApiException(400, "Missing required parameter 'routeId' when calling RoutingApi->PutEmailDomainsDomainnameRoutesRouteId");

            var localVarPath = "/api/v2/routing/email/domains/{domainName}/routes/{routeId}";
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
            if (domainName != null) localVarPathParams.Add("domainName", Configuration.ApiClient.ParameterToString(domainName)); // path parameter
            if (routeId != null) localVarPathParams.Add("routeId", Configuration.ApiClient.ParameterToString(routeId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutEmailDomainsDomainnameRoutesRouteId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutEmailDomainsDomainnameRoutesRouteId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRoute)));
            
        }

        /// <summary>
        /// Update a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="routeId">route ID</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>Task of InboundRoute</returns>
        public async System.Threading.Tasks.Task<InboundRoute> PutEmailDomainsDomainnameRoutesRouteIdAsync (string domainName, string routeId, InboundRoute body = null)
        {
             ApiResponse<InboundRoute> localVarResponse = await PutEmailDomainsDomainnameRoutesRouteIdAsyncWithHttpInfo(domainName, routeId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domainName">email domain</param>
        /// <param name="routeId">route ID</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundRoute>> PutEmailDomainsDomainnameRoutesRouteIdAsyncWithHttpInfo (string domainName, string routeId, InboundRoute body = null)
        {
            // verify the required parameter 'domainName' is set
            if (domainName == null)
                throw new ApiException(400, "Missing required parameter 'domainName' when calling RoutingApi->PutEmailDomainsDomainnameRoutesRouteId");
            // verify the required parameter 'routeId' is set
            if (routeId == null)
                throw new ApiException(400, "Missing required parameter 'routeId' when calling RoutingApi->PutEmailDomainsDomainnameRoutesRouteId");

            var localVarPath = "/api/v2/routing/email/domains/{domainName}/routes/{routeId}";
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
            if (domainName != null) localVarPathParams.Add("domainName", Configuration.ApiClient.ParameterToString(domainName)); // path parameter
            if (routeId != null) localVarPathParams.Add("routeId", Configuration.ApiClient.ParameterToString(routeId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutEmailDomainsDomainnameRoutesRouteId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutEmailDomainsDomainnameRoutesRouteId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRoute)));
            
        }

        /// <summary>
        /// Update a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Queue</returns>
        public Queue PutQueuesQueueId (string queueId, Queue body = null)
        {
             ApiResponse<Queue> localVarResponse = PutQueuesQueueIdWithHttpInfo(queueId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>ApiResponse of Queue</returns>
        public ApiResponse< Queue > PutQueuesQueueIdWithHttpInfo (string queueId, Queue body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->PutQueuesQueueId");

            var localVarPath = "/api/v2/routing/queues/{queueId}";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutQueuesQueueId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutQueuesQueueId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<Queue> PutQueuesQueueIdAsync (string queueId, Queue body = null)
        {
             ApiResponse<Queue> localVarResponse = await PutQueuesQueueIdAsyncWithHttpInfo(queueId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Queue>> PutQueuesQueueIdAsyncWithHttpInfo (string queueId, Queue body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->PutQueuesQueueId");

            var localVarPath = "/api/v2/routing/queues/{queueId}";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutQueuesQueueId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutQueuesQueueId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Queue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Queue)));
            
        }

        /// <summary>
        /// Update routing skill proficiency or state. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId"></param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>UserRoutingSkill</returns>
        public UserRoutingSkill PutUserIdRoutingskillsSkillId (string userId, string skillId, UserRoutingSkill body = null)
        {
             ApiResponse<UserRoutingSkill> localVarResponse = PutUserIdRoutingskillsSkillIdWithHttpInfo(userId, skillId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update routing skill proficiency or state. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId"></param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>ApiResponse of UserRoutingSkill</returns>
        public ApiResponse< UserRoutingSkill > PutUserIdRoutingskillsSkillIdWithHttpInfo (string userId, string skillId, UserRoutingSkill body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling RoutingApi->PutUserIdRoutingskillsSkillId");
            // verify the required parameter 'skillId' is set
            if (skillId == null)
                throw new ApiException(400, "Missing required parameter 'skillId' when calling RoutingApi->PutUserIdRoutingskillsSkillId");

            var localVarPath = "/api/v2/users/{userId}/routingskills/{skillId}";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (skillId != null) localVarPathParams.Add("skillId", Configuration.ApiClient.ParameterToString(skillId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutUserIdRoutingskillsSkillId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUserIdRoutingskillsSkillId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserRoutingSkill>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserRoutingSkill) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserRoutingSkill)));
            
        }

        /// <summary>
        /// Update routing skill proficiency or state. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId"></param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>Task of UserRoutingSkill</returns>
        public async System.Threading.Tasks.Task<UserRoutingSkill> PutUserIdRoutingskillsSkillIdAsync (string userId, string skillId, UserRoutingSkill body = null)
        {
             ApiResponse<UserRoutingSkill> localVarResponse = await PutUserIdRoutingskillsSkillIdAsyncWithHttpInfo(userId, skillId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update routing skill proficiency or state. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="skillId"></param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>Task of ApiResponse (UserRoutingSkill)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserRoutingSkill>> PutUserIdRoutingskillsSkillIdAsyncWithHttpInfo (string userId, string skillId, UserRoutingSkill body = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling RoutingApi->PutUserIdRoutingskillsSkillId");
            // verify the required parameter 'skillId' is set
            if (skillId == null)
                throw new ApiException(400, "Missing required parameter 'skillId' when calling RoutingApi->PutUserIdRoutingskillsSkillId");

            var localVarPath = "/api/v2/users/{userId}/routingskills/{skillId}";
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
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (skillId != null) localVarPathParams.Add("skillId", Configuration.ApiClient.ParameterToString(skillId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutUserIdRoutingskillsSkillId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUserIdRoutingskillsSkillId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserRoutingSkill>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserRoutingSkill) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserRoutingSkill)));
            
        }

        /// <summary>
        /// Update the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">utilization (optional)</param>
        /// <returns>Utilization</returns>
        public Utilization PutUtilization (Utilization body = null)
        {
             ApiResponse<Utilization> localVarResponse = PutUtilizationWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">utilization (optional)</param>
        /// <returns>ApiResponse of Utilization</returns>
        public ApiResponse< Utilization > PutUtilizationWithHttpInfo (Utilization body = null)
        {

            var localVarPath = "/api/v2/routing/utilization";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutUtilization: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUtilization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<Utilization> PutUtilizationAsync (Utilization body = null)
        {
             ApiResponse<Utilization> localVarResponse = await PutUtilizationAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">utilization (optional)</param>
        /// <returns>Task of ApiResponse (Utilization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Utilization>> PutUtilizationAsyncWithHttpInfo (Utilization body = null)
        {

            var localVarPath = "/api/v2/routing/utilization";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutUtilization: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUtilization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Utilization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Utilization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Utilization)));
            
        }

        /// <summary>
        /// Update wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>WrapupCode</returns>
        public WrapupCode PutWrapupcodesCodeId (string codeId, WrapupCode body = null)
        {
             ApiResponse<WrapupCode> localVarResponse = PutWrapupcodesCodeIdWithHttpInfo(codeId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > PutWrapupcodesCodeIdWithHttpInfo (string codeId, WrapupCode body = null)
        {
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->PutWrapupcodesCodeId");

            var localVarPath = "/api/v2/routing/wrapupcodes/{codeId}";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutWrapupcodesCodeId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWrapupcodesCodeId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<WrapupCode> PutWrapupcodesCodeIdAsync (string codeId, WrapupCode body = null)
        {
             ApiResponse<WrapupCode> localVarResponse = await PutWrapupcodesCodeIdAsyncWithHttpInfo(codeId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> PutWrapupcodesCodeIdAsyncWithHttpInfo (string codeId, WrapupCode body = null)
        {
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->PutWrapupcodesCodeId");

            var localVarPath = "/api/v2/routing/wrapupcodes/{codeId}";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutWrapupcodesCodeId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWrapupcodesCodeId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

    }
}