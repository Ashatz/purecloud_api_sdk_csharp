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
<<<<<<< HEAD
=======
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
        string DeleteEmailDomainsDomainRoutesId (string domain, string id);

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
        ApiResponse<string> DeleteEmailDomainsDomainRoutesIdWithHttpInfo (string domain, string id);
        /// <summary>
        /// Delete a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">domain ID</param>
        /// <returns>string</returns>
        string DeleteEmailDomainsId (string id);

        /// <summary>
        /// Delete a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">domain ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteEmailDomainsIdWithHttpInfo (string id);
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Delete a wrap-up code from a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="domain">email domain</param>
        /// <returns>InboundRouteEntityListing</returns>
        InboundRouteEntityListing RoutingEmailDomainsDomainRoutesGet (string domain);
=======
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>string</returns>
        string DeleteQueuesQueueIdWrapupcodesCodeId (string queueId, string codeId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Delete a wrap-up code from a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="domain">email domain</param>
        /// <returns>ApiResponse of InboundRouteEntityListing</returns>
        ApiResponse<InboundRouteEntityListing> RoutingEmailDomainsDomainRoutesGetWithHttpInfo (string domain);
        /// <summary>
        /// Delete a route
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>string</returns>
        string RoutingEmailDomainsDomainRoutesIdDelete (string domain, string id);

        /// <summary>
        /// Delete a route
=======
        /// <returns>string</returns>
        string DeleteUtilization ();

        /// <summary>
        /// Delete utilization settings and revert to system defaults.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RoutingEmailDomainsDomainRoutesIdDeleteWithHttpInfo (string domain, string id);
=======
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteUtilizationWithHttpInfo ();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Delete wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>InboundRoute</returns>
        InboundRoute RoutingEmailDomainsDomainRoutesIdGet (string domain, string id);
=======
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>string</returns>
        string DeleteWrapupcodesCodeId (string codeId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Delete wrap-up code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>ApiResponse of InboundRoute</returns>
        ApiResponse<InboundRoute> RoutingEmailDomainsDomainRoutesIdGetWithHttpInfo (string domain, string id);
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
<<<<<<< HEAD
        /// <param name="id">route ID</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>InboundRoute</returns>
        InboundRoute RoutingEmailDomainsDomainRoutesIdPut (string domain, string id, InboundRoute body = null);
=======
        /// <returns>InboundRouteEntityListing</returns>
        InboundRouteEntityListing GetEmailDomainsDomainRoutes (string domain);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get routes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
<<<<<<< HEAD
        /// <param name="id">route ID</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>ApiResponse of InboundRoute</returns>
        ApiResponse<InboundRoute> RoutingEmailDomainsDomainRoutesIdPutWithHttpInfo (string domain, string id, InboundRoute body = null);
        /// <summary>
        /// Create a route
=======
        /// <returns>ApiResponse of InboundRouteEntityListing</returns>
        ApiResponse<InboundRouteEntityListing> GetEmailDomainsDomainRoutesWithHttpInfo (string domain);
        /// <summary>
        /// Get a route
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
<<<<<<< HEAD
        /// <param name="body">Route (optional)</param>
        /// <returns>InboundRoute</returns>
        InboundRoute RoutingEmailDomainsDomainRoutesPost (string domain, InboundRoute body = null);

        /// <summary>
        /// Create a route
=======
        /// <param name="id">route ID</param>
        /// <returns>InboundRoute</returns>
        InboundRoute GetEmailDomainsDomainRoutesId (string domain, string id);

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
        ApiResponse<InboundRoute> GetEmailDomainsDomainRoutesIdWithHttpInfo (string domain, string id);
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="domain">email domain</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>ApiResponse of InboundRoute</returns>
        ApiResponse<InboundRoute> RoutingEmailDomainsDomainRoutesPostWithHttpInfo (string domain, InboundRoute body = null);
        /// <summary>
        /// Get domains
=======
        /// <returns>ApiResponse of EmailSetup</returns>
        ApiResponse<EmailSetup> GetEmailSetupWithHttpInfo ();
        /// <summary>
        /// Get list of queues.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>InboundDomainEntityListing</returns>
        InboundDomainEntityListing RoutingEmailDomainsGet ();

        /// <summary>
        /// Get domains
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="active">Active (optional)</param>
        /// <returns>QueueEntityListing</returns>
        QueueEntityListing GetQueues (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null);

        /// <summary>
        /// Get list of queues.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>ApiResponse of InboundDomainEntityListing</returns>
        ApiResponse<InboundDomainEntityListing> RoutingEmailDomainsGetWithHttpInfo ();
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="active">Active (optional)</param>
        /// <returns>ApiResponse of QueueEntityListing</returns>
        ApiResponse<QueueEntityListing> GetQueuesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get details about this queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="id">domain ID</param>
        /// <returns>string</returns>
        string RoutingEmailDomainsIdDelete (string id);
=======
        /// <param name="queueId">Queue ID</param>
        /// <returns>Queue</returns>
        Queue GetQueuesQueueId (string queueId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get details about this queue.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="id">domain ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RoutingEmailDomainsIdDeleteWithHttpInfo (string id);
        /// <summary>
        /// Create a domain
=======
        /// <param name="queueId">Queue ID</param>
        /// <returns>ApiResponse of Queue</returns>
        ApiResponse<Queue> GetQueuesQueueIdWithHttpInfo (string queueId);
        /// <summary>
        /// Get Estimated Wait Time
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Domain (optional)</param>
        /// <returns>InboundDomain</returns>
        InboundDomain RoutingEmailDomainsPost (InboundDomain body = null);

        /// <summary>
        /// Create a domain
=======
        /// <param name="queueId">queueId</param>
        /// <param name="conversationId">conversationId (optional)</param>
        /// <returns>EstimatedWaitTimePredictions</returns>
        EstimatedWaitTimePredictions GetQueuesQueueIdEstimatedwaittime (string queueId, string conversationId = null);

        /// <summary>
        /// Get Estimated Wait Time
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Domain (optional)</param>
        /// <returns>ApiResponse of InboundDomain</returns>
        ApiResponse<InboundDomain> RoutingEmailDomainsPostWithHttpInfo (InboundDomain body = null);
=======
        /// <param name="queueId">queueId</param>
        /// <param name="conversationId">conversationId (optional)</param>
        /// <returns>ApiResponse of EstimatedWaitTimePredictions</returns>
        ApiResponse<EstimatedWaitTimePredictions> GetQueuesQueueIdEstimatedwaittimeWithHttpInfo (string queueId, string conversationId = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get the members of this queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>EmailSetup</returns>
        EmailSetup RoutingEmailSetupGet ();
=======
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="directMembers">Only get users that are direct members of the queue (optional, default to false)</param>
        /// <returns>QueueMember</returns>
        QueueMember GetQueuesQueueIdUsers (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get the members of this queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>ApiResponse of EmailSetup</returns>
        ApiResponse<EmailSetup> RoutingEmailSetupGetWithHttpInfo ();
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get the list of routing skills.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="active">Active (optional)</param>
        /// <returns>QueueEntityListing</returns>
        QueueEntityListing RoutingQueuesGet (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null);
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>SkillEntityListing</returns>
        SkillEntityListing GetSkills (int? pageSize = null, int? pageNumber = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get the list of routing skills.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of SkillEntityListing</returns>
        ApiResponse<SkillEntityListing> GetSkillsWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get Routing Skill
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Queue</returns>
        Queue RoutingQueuesPost (string queueId, Queue body = null);

        /// <summary>
        /// Create queue
=======
        /// <param name="skillId">Skill ID</param>
        /// <returns>RoutingSkill</returns>
        RoutingSkill GetSkillsSkillId (string skillId);

        /// <summary>
        /// Get Routing Skill
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>ApiResponse of Queue</returns>
        ApiResponse<Queue> RoutingQueuesPostWithHttpInfo (string queueId, Queue body = null);
        /// <summary>
        /// Delete a queue
=======
        /// <param name="skillId">Skill ID</param>
        /// <returns>ApiResponse of RoutingSkill</returns>
        ApiResponse<RoutingSkill> GetSkillsSkillIdWithHttpInfo (string skillId);
        /// <summary>
        /// List routing skills for user
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <returns>string</returns>
        string RoutingQueuesQueueidDelete (string queueId);

        /// <summary>
        /// Delete a queue
=======
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <returns>UserSkillEntityListing</returns>
        UserSkillEntityListing GetUserIdRoutingskills (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);

        /// <summary>
        /// List routing skills for user
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RoutingQueuesQueueidDeleteWithHttpInfo (string queueId);
        /// <summary>
        /// Get details about this queue.
=======
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <returns>ApiResponse of UserSkillEntityListing</returns>
        ApiResponse<UserSkillEntityListing> GetUserIdRoutingskillsWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);
        /// <summary>
        /// Get the utilization settings.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <returns>Queue</returns>
        Queue RoutingQueuesQueueidGet (string queueId);

        /// <summary>
        /// Get details about this queue.
=======
        /// <returns>Utilization</returns>
        Utilization GetUtilization ();

        /// <summary>
        /// Get the utilization settings.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <returns>ApiResponse of Queue</returns>
        ApiResponse<Queue> RoutingQueuesQueueidGetWithHttpInfo (string queueId);
        /// <summary>
        /// Get members in a queue
=======
        /// <returns>ApiResponse of Utilization</returns>
        ApiResponse<Utilization> GetUtilizationWithHttpInfo ();
        /// <summary>
        /// Get list of wrapup codes.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Get the list of members of a queue
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>WrapupCodeEntityListing</returns>
        WrapupCodeEntityListing GetWrapupcodes (int? pageSize = null, int? pageNumber = null, string sortBy = null);

        /// <summary>
        /// Get list of wrapup codes.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Get the list of members of a queue
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>ApiResponse of WrapupCodeEntityListing</returns>
        ApiResponse<WrapupCodeEntityListing> GetWrapupcodesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null);
        /// <summary>
        /// Get details about this wrap-up code.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member/User ID</param>
        /// <param name="body">To join queue ~ \&quot;joined\&quot;:true (optional)</param>
        /// <returns>QueueMember</returns>
        QueueMember RoutingQueuesQueueidMembersMemberidPut (string queueId, string memberId, QueueMember body = null);

        /// <summary>
        /// Join or unjoin a user to the queue.
=======
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>WrapupCode</returns>
        WrapupCode GetWrapupcodesCodeId (string codeId);

        /// <summary>
        /// Get details about this wrap-up code.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member/User ID</param>
        /// <param name="body">To join queue ~ \&quot;joined\&quot;:true (optional)</param>
        /// <returns>ApiResponse of QueueMember</returns>
        ApiResponse<QueueMember> RoutingQueuesQueueidMembersMemberidPutWithHttpInfo (string queueId, string memberId, QueueMember body = null);
=======
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> GetWrapupcodesCodeIdWithHttpInfo (string codeId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Join or unjoin a set of users for a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
<<<<<<< HEAD
        /// <param name="body">Queue (optional)</param>
        /// <returns>Queue</returns>
        Queue RoutingQueuesQueueidPut (string queueId, Queue body = null);
=======
        /// <param name="body">Queue Members (optional)</param>
        /// <returns>QueueMember</returns>
        QueueMember PatchQueuesQueueIdUsers (string queueId, List<QueueMember> body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Join or unjoin a set of users for a queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
<<<<<<< HEAD
        /// <param name="body">Queue (optional)</param>
        /// <returns>ApiResponse of Queue</returns>
        ApiResponse<Queue> RoutingQueuesQueueidPutWithHttpInfo (string queueId, Queue body = null);
        /// <summary>
        /// Get the members of this queue
=======
        /// <param name="body">Queue Members (optional)</param>
        /// <returns>ApiResponse of QueueMember</returns>
        ApiResponse<QueueMember> PatchQueuesQueueIdUsersWithHttpInfo (string queueId, List<QueueMember> body = null);
        /// <summary>
        /// Update the ring number of joined status for a User in a Queue
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
<<<<<<< HEAD
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="directMembers">Only get users that are direct members of the queue (optional, default to false)</param>
        /// <returns>QueueMember</returns>
        QueueMember RoutingQueuesQueueidUsersGet (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null);

        /// <summary>
        /// Get the members of this queue
=======
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Queue Member (optional)</param>
        /// <returns>QueueMember</returns>
        QueueMember PatchQueuesQueueIdUsersMemberId (string queueId, string memberId, QueueMember body = null);

        /// <summary>
        /// Update the ring number of joined status for a User in a Queue
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
<<<<<<< HEAD
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="expand">expand (optional)</param>
        /// <param name="directMembers">Only get users that are direct members of the queue (optional, default to false)</param>
        /// <returns>ApiResponse of QueueMember</returns>
        ApiResponse<QueueMember> RoutingQueuesQueueidUsersGetWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null);
        /// <summary>
        /// Delete queue member
=======
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Queue Member (optional)</param>
        /// <returns>ApiResponse of QueueMember</returns>
        ApiResponse<QueueMember> PatchQueuesQueueIdUsersMemberIdWithHttpInfo (string queueId, string memberId, QueueMember body = null);
        /// <summary>
        /// Create a domain
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>string</returns>
        string RoutingQueuesQueueidUsersMemberidDelete (string queueId, string memberId);

        /// <summary>
        /// Delete queue member
=======
        /// <param name="body">Domain (optional)</param>
        /// <returns>InboundDomain</returns>
        InboundDomain PostEmailDomains (InboundDomain body = null);

        /// <summary>
        /// Create a domain
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RoutingQueuesQueueidUsersMemberidDeleteWithHttpInfo (string queueId, string memberId);
        /// <summary>
        /// Update the ring number of joined status for a User in a Queue
=======
        /// <param name="body">Domain (optional)</param>
        /// <returns>ApiResponse of InboundDomain</returns>
        ApiResponse<InboundDomain> PostEmailDomainsWithHttpInfo (InboundDomain body = null);
        /// <summary>
        /// Create a route
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Queue Member (optional)</param>
        /// <returns>QueueMember</returns>
        QueueMember RoutingQueuesQueueidUsersMemberidPatch (string queueId, string memberId, QueueMember body = null);

        /// <summary>
        /// Update the ring number of joined status for a User in a Queue
=======
        /// <param name="domain">email domain</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>InboundRoute</returns>
        InboundRoute PostEmailDomainsDomainRoutes (string domain, InboundRoute body = null);

        /// <summary>
        /// Create a route
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Queue Member (optional)</param>
        /// <returns>ApiResponse of QueueMember</returns>
        ApiResponse<QueueMember> RoutingQueuesQueueidUsersMemberidPatchWithHttpInfo (string queueId, string memberId, QueueMember body = null);
        /// <summary>
        /// Join or unjoin a set of users for a queue
=======
        /// <param name="domain">email domain</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>ApiResponse of InboundRoute</returns>
        ApiResponse<InboundRoute> PostEmailDomainsDomainRoutesWithHttpInfo (string domain, InboundRoute body = null);
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <returns>QueueMember</returns>
        QueueMember RoutingQueuesQueueidUsersPatch (string queueId, List<QueueMember> body = null);

        /// <summary>
        /// Join or unjoin a set of users for a queue
=======
        /// <param name="body">query (optional)</param>
        /// <returns>ObservationQueryResponse</returns>
        ObservationQueryResponse PostQueuesObservationsQuery (ObservationQuery body = null);

        /// <summary>
        /// Query for queue observations
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <returns>ApiResponse of QueueMember</returns>
        ApiResponse<QueueMember> RoutingQueuesQueueidUsersPatchWithHttpInfo (string queueId, List<QueueMember> body = null);
=======
        /// <param name="body">query (optional)</param>
        /// <returns>ApiResponse of ObservationQueryResponse</returns>
        ApiResponse<ObservationQueryResponse> PostQueuesObservationsQueryWithHttpInfo (ObservationQuery body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
        QueueMember RoutingQueuesQueueidUsersPost (string queueId, List<QueueMember> body = null, bool? delete = null);
=======
        QueueMember PostQueuesQueueIdUsers (string queueId, List<QueueMember> body = null, bool? delete = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
        ApiResponse<QueueMember> RoutingQueuesQueueidUsersPostWithHttpInfo (string queueId, List<QueueMember> body = null, bool? delete = null);
        /// <summary>
        /// Delete a wrap-up code from a queue
=======
        ApiResponse<QueueMember> PostQueuesQueueIdUsersWithHttpInfo (string queueId, List<QueueMember> body = null, bool? delete = null);
        /// <summary>
        /// Add up to 100 wrap-up codes to a queue
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
<<<<<<< HEAD
        /// <returns>string</returns>
        string RoutingQueuesQueueidWrapupcodesCodeidDelete (string queueId, string codeId);

        /// <summary>
        /// Delete a wrap-up code from a queue
=======
        /// <param name="body"> (optional)</param>
        /// <returns>WrapupCode</returns>
        WrapupCode PostQueuesQueueIdWrapupcodes (string queueId, string codeId, List<WrapupCode> body = null);

        /// <summary>
        /// Add up to 100 wrap-up codes to a queue
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
<<<<<<< HEAD
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RoutingQueuesQueueidWrapupcodesCodeidDeleteWithHttpInfo (string queueId, string codeId);
        /// <summary>
        /// Get the wrap-up codes for a queue
=======
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> PostQueuesQueueIdWrapupcodesWithHttpInfo (string queueId, string codeId, List<WrapupCode> body = null);
        /// <summary>
        /// Create Skill
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>WrapupCode</returns>
        WrapupCode RoutingQueuesQueueidWrapupcodesGet (string queueId, string codeId);

        /// <summary>
        /// Get the wrap-up codes for a queue
=======
        /// <param name="body">Skill (optional)</param>
        /// <returns>RoutingSkill</returns>
        RoutingSkill PostSkills (RoutingSkill body = null);

        /// <summary>
        /// Create Skill
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> RoutingQueuesQueueidWrapupcodesGetWithHttpInfo (string queueId, string codeId);
        /// <summary>
        /// Add up to 100 wrap-up codes to a queue
=======
        /// <param name="body">Skill (optional)</param>
        /// <returns>ApiResponse of RoutingSkill</returns>
        ApiResponse<RoutingSkill> PostSkillsWithHttpInfo (RoutingSkill body = null);
        /// <summary>
        /// Add routing skill to user
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>WrapupCode</returns>
        WrapupCode RoutingQueuesQueueidWrapupcodesPost (string queueId, string codeId, List<WrapupCode> body = null);

        /// <summary>
        /// Add up to 100 wrap-up codes to a queue
=======
        /// <param name="userId">User ID</param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>UserRoutingSkill</returns>
        UserRoutingSkill PostUserIdRoutingskills (string userId, UserRoutingSkill body = null);

        /// <summary>
        /// Add routing skill to user
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> RoutingQueuesQueueidWrapupcodesPostWithHttpInfo (string queueId, string codeId, List<WrapupCode> body = null);
        /// <summary>
        /// Get the list of skills.
=======
        /// <param name="userId">User ID</param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>ApiResponse of UserRoutingSkill</returns>
        ApiResponse<UserRoutingSkill> PostUserIdRoutingskillsWithHttpInfo (string userId, UserRoutingSkill body = null);
        /// <summary>
        /// Create a wrap-up code
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>SkillEntityListing</returns>
        SkillEntityListing RoutingSkillsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null);

        /// <summary>
        /// Get the list of skills.
=======
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>CallableTimeSet</returns>
        CallableTimeSet PostWrapupcodes (WrapupCode body = null);

        /// <summary>
        /// Create a wrap-up code
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>ApiResponse of SkillEntityListing</returns>
        ApiResponse<SkillEntityListing> RoutingSkillsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null);
        /// <summary>
        /// Delete utilization settings and revert to system defaults.
=======
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        ApiResponse<CallableTimeSet> PostWrapupcodesWithHttpInfo (WrapupCode body = null);
        /// <summary>
        /// Update a route
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>string</returns>
        string RoutingUtilizationDelete ();

        /// <summary>
        /// Delete utilization settings and revert to system defaults.
=======
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>InboundRoute</returns>
        InboundRoute PutEmailDomainsDomainRoutesId (string domain, string id, InboundRoute body = null);

        /// <summary>
        /// Update a route
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RoutingUtilizationDeleteWithHttpInfo ();
        /// <summary>
        /// Get the utilization settings.
=======
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>ApiResponse of InboundRoute</returns>
        ApiResponse<InboundRoute> PutEmailDomainsDomainRoutesIdWithHttpInfo (string domain, string id, InboundRoute body = null);
        /// <summary>
        /// Update a queue
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Utilization</returns>
        Utilization RoutingUtilizationGet ();

        /// <summary>
        /// Get the utilization settings.
=======
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Queue</returns>
        Queue PutQueuesQueueId (string queueId, Queue body = null);

        /// <summary>
        /// Update a queue
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>ApiResponse of Utilization</returns>
        ApiResponse<Utilization> RoutingUtilizationGetWithHttpInfo ();
        /// <summary>
        /// Update the utilization settings.
=======
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>ApiResponse of Queue</returns>
        ApiResponse<Queue> PutQueuesQueueIdWithHttpInfo (string queueId, Queue body = null);
        /// <summary>
        /// Update Routing Skill
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">utilization (optional)</param>
        /// <returns>Utilization</returns>
        Utilization RoutingUtilizationPut (Utilization body = null);

        /// <summary>
        /// Update the utilization settings.
=======
        /// <param name="skillId">Skill ID</param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>RoutingSkill</returns>
        RoutingSkill PutSkillsSkillId (string skillId, RoutingSkill body = null);

        /// <summary>
        /// Update Routing Skill
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">utilization (optional)</param>
        /// <returns>ApiResponse of Utilization</returns>
        ApiResponse<Utilization> RoutingUtilizationPutWithHttpInfo (Utilization body = null);
        /// <summary>
        /// Delete wrap-up code
=======
        /// <param name="skillId">Skill ID</param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>ApiResponse of RoutingSkill</returns>
        ApiResponse<RoutingSkill> PutSkillsSkillIdWithHttpInfo (string skillId, RoutingSkill body = null);
        /// <summary>
        /// Update the utilization settings.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>string</returns>
        string RoutingWrapupcodesCodeidDelete (string codeId);

        /// <summary>
        /// Delete wrap-up code
=======
        /// <param name="body">utilization (optional)</param>
        /// <returns>Utilization</returns>
        Utilization PutUtilization (Utilization body = null);

        /// <summary>
        /// Update the utilization settings.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="body">utilization (optional)</param>
        /// <returns>ApiResponse of Utilization</returns>
        ApiResponse<Utilization> PutUtilizationWithHttpInfo (Utilization body = null);
        /// <summary>
        /// Update wrap-up code
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
<<<<<<< HEAD
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
=======
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>WrapupCode</returns>
        WrapupCode PutWrapupcodesCodeId (string codeId, WrapupCode body = null);

        /// <summary>
        /// Update wrap-up code
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> RoutingEmailDomainsDomainRoutesIdDeleteAsyncWithHttpInfo (string domain, string id);
        /// <summary>
        /// Get a route
=======
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> PutWrapupcodesCodeIdWithHttpInfo (string codeId, WrapupCode body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete a route
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
<<<<<<< HEAD
        /// <returns>Task of InboundRoute</returns>
        System.Threading.Tasks.Task<InboundRoute> RoutingEmailDomainsDomainRoutesIdGetAsync (string domain, string id);

        /// <summary>
        /// Get a route
=======
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteEmailDomainsDomainRoutesIdAsync (string domain, string id);

        /// <summary>
        /// Delete a route
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
<<<<<<< HEAD
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
=======
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteEmailDomainsDomainRoutesIdAsyncWithHttpInfo (string domain, string id);
        /// <summary>
        /// Delete a domain
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="id">domain ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteEmailDomainsIdAsync (string id);

        /// <summary>
        /// Delete a domain
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="domain">email domain</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundRoute>> RoutingEmailDomainsDomainRoutesPostAsyncWithHttpInfo (string domain, InboundRoute body = null);
        /// <summary>
        /// Get domains
=======
        /// <param name="id">domain ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteEmailDomainsIdAsyncWithHttpInfo (string id);
        /// <summary>
        /// Delete a queue
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of InboundDomainEntityListing</returns>
        System.Threading.Tasks.Task<InboundDomainEntityListing> RoutingEmailDomainsGetAsync ();

        /// <summary>
        /// Get domains
=======
        /// <param name="queueId">Queue ID</param>
        /// <param name="forceDelete"> (optional)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteQueuesQueueIdAsync (string queueId, bool? forceDelete = null);

        /// <summary>
        /// Delete a queue
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="queueId">Queue ID</param>
        /// <param name="forceDelete"> (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteQueuesQueueIdAsyncWithHttpInfo (string queueId, bool? forceDelete = null);
        /// <summary>
        /// Delete queue member
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteQueuesQueueIdUsersMemberIdAsync (string queueId, string memberId);

        /// <summary>
        /// Delete queue member
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteQueuesQueueIdUsersMemberIdAsyncWithHttpInfo (string queueId, string memberId);
        /// <summary>
        /// Delete a wrap-up code from a queue
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
<<<<<<< HEAD
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="active">Active (optional)</param>
        /// <returns>Task of ApiResponse (QueueEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueEntityListing>> RoutingQueuesGetAsyncWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null);
        /// <summary>
        /// Create queue
=======
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteQueuesQueueIdWrapupcodesCodeIdAsync (string queueId, string codeId);

        /// <summary>
        /// Delete a wrap-up code from a queue
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
<<<<<<< HEAD
        /// <param name="body">Queue (optional)</param>
        /// <returns>Task of Queue</returns>
        System.Threading.Tasks.Task<Queue> RoutingQueuesPostAsync (string queueId, Queue body = null);

        /// <summary>
        /// Create queue
=======
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteQueuesQueueIdWrapupcodesCodeIdAsyncWithHttpInfo (string queueId, string codeId);
        /// <summary>
        /// Delete Routing Skill
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="skillId">Skill ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteSkillsSkillIdAsync (string skillId);

        /// <summary>
        /// Delete Routing Skill
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> RoutingQueuesQueueidDeleteAsyncWithHttpInfo (string queueId);
        /// <summary>
        /// Get details about this queue.
=======
        /// <param name="skillId">Skill ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteSkillsSkillIdAsyncWithHttpInfo (string skillId);
        /// <summary>
        /// Remove routing skill from user
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of Queue</returns>
        System.Threading.Tasks.Task<Queue> RoutingQueuesQueueidGetAsync (string queueId);

        /// <summary>
        /// Get details about this queue.
=======
        /// <param name="userId">User ID</param>
        /// <param name="skillId"></param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteUserIdRoutingskillsSkillIdAsync (string userId, string skillId);

        /// <summary>
        /// Remove routing skill from user
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="userId">User ID</param>
        /// <param name="skillId"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteUserIdRoutingskillsSkillIdAsyncWithHttpInfo (string userId, string skillId);
        /// <summary>
        /// Delete utilization settings and revert to system defaults.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member/User ID</param>
        /// <param name="body">To join queue ~ \&quot;joined\&quot;:true (optional)</param>
        /// <returns>Task of QueueMember</returns>
        System.Threading.Tasks.Task<QueueMember> RoutingQueuesQueueidMembersMemberidPutAsync (string queueId, string memberId, QueueMember body = null);

        /// <summary>
        /// Join or unjoin a user to the queue.
=======
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteUtilizationAsync ();

        /// <summary>
        /// Delete utilization settings and revert to system defaults.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member/User ID</param>
        /// <param name="body">To join queue ~ \&quot;joined\&quot;:true (optional)</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueMember>> RoutingQueuesQueueidMembersMemberidPutAsyncWithHttpInfo (string queueId, string memberId, QueueMember body = null);
        /// <summary>
        /// Update a queue
=======
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteUtilizationAsyncWithHttpInfo ();
        /// <summary>
        /// Delete wrap-up code
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Task of Queue</returns>
        System.Threading.Tasks.Task<Queue> RoutingQueuesQueueidPutAsync (string queueId, Queue body = null);

        /// <summary>
        /// Update a queue
=======
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteWrapupcodesCodeIdAsync (string codeId);

        /// <summary>
        /// Delete wrap-up code
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteWrapupcodesCodeIdAsyncWithHttpInfo (string codeId);
        /// <summary>
        /// Get domains
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <returns>Task of InboundDomainEntityListing</returns>
        System.Threading.Tasks.Task<InboundDomainEntityListing> GetEmailDomainsAsync ();

        /// <summary>
        /// Get domains
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> RoutingQueuesQueueidUsersMemberidDeleteAsyncWithHttpInfo (string queueId, string memberId);
        /// <summary>
        /// Update the ring number of joined status for a User in a Queue
=======
        /// <returns>Task of ApiResponse (InboundDomainEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundDomainEntityListing>> GetEmailDomainsAsyncWithHttpInfo ();
        /// <summary>
        /// Get routes
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Queue Member (optional)</param>
        /// <returns>Task of QueueMember</returns>
        System.Threading.Tasks.Task<QueueMember> RoutingQueuesQueueidUsersMemberidPatchAsync (string queueId, string memberId, QueueMember body = null);

        /// <summary>
        /// Update the ring number of joined status for a User in a Queue
=======
        /// <param name="domain">email domain</param>
        /// <returns>Task of InboundRouteEntityListing</returns>
        System.Threading.Tasks.Task<InboundRouteEntityListing> GetEmailDomainsDomainRoutesAsync (string domain);

        /// <summary>
        /// Get routes
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Queue Member (optional)</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueMember>> RoutingQueuesQueueidUsersMemberidPatchAsyncWithHttpInfo (string queueId, string memberId, QueueMember body = null);
        /// <summary>
        /// Join or unjoin a set of users for a queue
=======
        /// <param name="domain">email domain</param>
        /// <returns>Task of ApiResponse (InboundRouteEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundRouteEntityListing>> GetEmailDomainsDomainRoutesAsyncWithHttpInfo (string domain);
        /// <summary>
        /// Get a route
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <returns>Task of QueueMember</returns>
        System.Threading.Tasks.Task<QueueMember> RoutingQueuesQueueidUsersPatchAsync (string queueId, List<QueueMember> body = null);

        /// <summary>
        /// Join or unjoin a set of users for a queue
=======
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>Task of InboundRoute</returns>
        System.Threading.Tasks.Task<InboundRoute> GetEmailDomainsDomainRoutesIdAsync (string domain, string id);

        /// <summary>
        /// Get a route
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueMember>> RoutingQueuesQueueidUsersPatchAsyncWithHttpInfo (string queueId, List<QueueMember> body = null);
        /// <summary>
        /// Bulk add or delete up to 100 queue members
=======
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundRoute>> GetEmailDomainsDomainRoutesIdAsyncWithHttpInfo (string domain, string id);
        /// <summary>
        /// Get email setup
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <param name="delete">True to delete queue members (optional, default to false)</param>
        /// <returns>Task of QueueMember</returns>
        System.Threading.Tasks.Task<QueueMember> RoutingQueuesQueueidUsersPostAsync (string queueId, List<QueueMember> body = null, bool? delete = null);

        /// <summary>
        /// Bulk add or delete up to 100 queue members
=======
        /// <returns>Task of EmailSetup</returns>
        System.Threading.Tasks.Task<EmailSetup> GetEmailSetupAsync ();

        /// <summary>
        /// Get email setup
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <param name="delete">True to delete queue members (optional, default to false)</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueMember>> RoutingQueuesQueueidUsersPostAsyncWithHttpInfo (string queueId, List<QueueMember> body = null, bool? delete = null);
        /// <summary>
        /// Delete a wrap-up code from a queue
=======
        /// <returns>Task of ApiResponse (EmailSetup)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailSetup>> GetEmailSetupAsyncWithHttpInfo ();
        /// <summary>
        /// Get list of queues.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> RoutingQueuesQueueidWrapupcodesCodeidDeleteAsync (string queueId, string codeId);

        /// <summary>
        /// Delete a wrap-up code from a queue
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="active">Active (optional)</param>
        /// <returns>Task of QueueEntityListing</returns>
        System.Threading.Tasks.Task<QueueEntityListing> GetQueuesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null);

        /// <summary>
        /// Get list of queues.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> RoutingQueuesQueueidWrapupcodesCodeidDeleteAsyncWithHttpInfo (string queueId, string codeId);
        /// <summary>
        /// Get the wrap-up codes for a queue
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="active">Active (optional)</param>
        /// <returns>Task of ApiResponse (QueueEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueEntityListing>> GetQueuesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null);
        /// <summary>
        /// Get details about this queue.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
<<<<<<< HEAD
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> RoutingQueuesQueueidWrapupcodesGetAsync (string queueId, string codeId);

        /// <summary>
        /// Get the wrap-up codes for a queue
=======
        /// <returns>Task of Queue</returns>
        System.Threading.Tasks.Task<Queue> GetQueuesQueueIdAsync (string queueId);

        /// <summary>
        /// Get details about this queue.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
<<<<<<< HEAD
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> RoutingQueuesQueueidWrapupcodesGetAsyncWithHttpInfo (string queueId, string codeId);
        /// <summary>
        /// Add up to 100 wrap-up codes to a queue
=======
        /// <returns>Task of ApiResponse (Queue)</returns>
        System.Threading.Tasks.Task<ApiResponse<Queue>> GetQueuesQueueIdAsyncWithHttpInfo (string queueId);
        /// <summary>
        /// Get Estimated Wait Time
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> RoutingQueuesQueueidWrapupcodesPostAsync (string queueId, string codeId, List<WrapupCode> body = null);

        /// <summary>
        /// Add up to 100 wrap-up codes to a queue
=======
        /// <param name="queueId">queueId</param>
        /// <param name="conversationId">conversationId (optional)</param>
        /// <returns>Task of EstimatedWaitTimePredictions</returns>
        System.Threading.Tasks.Task<EstimatedWaitTimePredictions> GetQueuesQueueIdEstimatedwaittimeAsync (string queueId, string conversationId = null);

        /// <summary>
        /// Get Estimated Wait Time
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> RoutingQueuesQueueidWrapupcodesPostAsyncWithHttpInfo (string queueId, string codeId, List<WrapupCode> body = null);
        /// <summary>
        /// Get the list of skills.
=======
        /// <param name="queueId">queueId</param>
        /// <param name="conversationId">conversationId (optional)</param>
        /// <returns>Task of ApiResponse (EstimatedWaitTimePredictions)</returns>
        System.Threading.Tasks.Task<ApiResponse<EstimatedWaitTimePredictions>> GetQueuesQueueIdEstimatedwaittimeAsyncWithHttpInfo (string queueId, string conversationId = null);
        /// <summary>
        /// Get the members of this queue
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of SkillEntityListing</returns>
        System.Threading.Tasks.Task<SkillEntityListing> RoutingSkillsGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null);

        /// <summary>
        /// Get the list of skills.
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of ApiResponse (SkillEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SkillEntityListing>> RoutingSkillsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null);
        /// <summary>
        /// Delete utilization settings and revert to system defaults.
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> RoutingUtilizationDeleteAsync ();

        /// <summary>
        /// Delete utilization settings and revert to system defaults.
=======
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> GetQueuesQueueIdWrapupcodesAsync (string queueId, string codeId);

        /// <summary>
        /// Get the wrap-up codes for a queue
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> RoutingUtilizationDeleteAsyncWithHttpInfo ();
        /// <summary>
        /// Get the utilization settings.
=======
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetQueuesQueueIdWrapupcodesAsyncWithHttpInfo (string queueId, string codeId);
        /// <summary>
        /// Get the list of routing skills.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of Utilization</returns>
        System.Threading.Tasks.Task<Utilization> RoutingUtilizationGetAsync ();

        /// <summary>
        /// Get the utilization settings.
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of SkillEntityListing</returns>
        System.Threading.Tasks.Task<SkillEntityListing> GetSkillsAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get the list of routing skills.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of ApiResponse (Utilization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Utilization>> RoutingUtilizationGetAsyncWithHttpInfo ();
        /// <summary>
        /// Update the utilization settings.
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (SkillEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SkillEntityListing>> GetSkillsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get Routing Skill
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">utilization (optional)</param>
        /// <returns>Task of Utilization</returns>
        System.Threading.Tasks.Task<Utilization> RoutingUtilizationPutAsync (Utilization body = null);

        /// <summary>
        /// Update the utilization settings.
=======
        /// <param name="skillId">Skill ID</param>
        /// <returns>Task of RoutingSkill</returns>
        System.Threading.Tasks.Task<RoutingSkill> GetSkillsSkillIdAsync (string skillId);

        /// <summary>
        /// Get Routing Skill
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">utilization (optional)</param>
        /// <returns>Task of ApiResponse (Utilization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Utilization>> RoutingUtilizationPutAsyncWithHttpInfo (Utilization body = null);
        /// <summary>
        /// Delete wrap-up code
=======
        /// <param name="skillId">Skill ID</param>
        /// <returns>Task of ApiResponse (RoutingSkill)</returns>
        System.Threading.Tasks.Task<ApiResponse<RoutingSkill>> GetSkillsSkillIdAsyncWithHttpInfo (string skillId);
        /// <summary>
        /// List routing skills for user
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> RoutingWrapupcodesCodeidDeleteAsync (string codeId);

        /// <summary>
        /// Delete wrap-up code
=======
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <returns>Task of UserSkillEntityListing</returns>
        System.Threading.Tasks.Task<UserSkillEntityListing> GetUserIdRoutingskillsAsync (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);

        /// <summary>
        /// List routing skills for user
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> RoutingWrapupcodesCodeidDeleteAsyncWithHttpInfo (string codeId);
=======
        /// <param name="userId">User ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Ascending or descending sort order (optional, default to ASC)</param>
        /// <returns>Task of ApiResponse (UserSkillEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserSkillEntityListing>> GetUserIdRoutingskillsAsyncWithHttpInfo (string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> RoutingWrapupcodesCodeidGetAsync (string codeId);
=======
        /// <returns>Task of Utilization</returns>
        System.Threading.Tasks.Task<Utilization> GetUtilizationAsync ();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get the utilization settings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> RoutingWrapupcodesCodeidGetAsyncWithHttpInfo (string codeId);
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get details about this wrap-up code.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
<<<<<<< HEAD
        /// <param name="body">WrapupCode (optional)</param>
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> RoutingWrapupcodesCodeidPutAsyncWithHttpInfo (string codeId, WrapupCode body = null);
        /// <summary>
        /// Get list of wrapup codes.
=======
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetWrapupcodesCodeIdAsyncWithHttpInfo (string codeId);
        /// <summary>
        /// Join or unjoin a set of users for a queue
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>Task of WrapupCodeEntityListing</returns>
        System.Threading.Tasks.Task<WrapupCodeEntityListing> RoutingWrapupcodesGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null);

        /// <summary>
        /// Get list of wrapup codes.
=======
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <returns>Task of QueueMember</returns>
        System.Threading.Tasks.Task<QueueMember> PatchQueuesQueueIdUsersAsync (string queueId, List<QueueMember> body = null);

        /// <summary>
        /// Join or unjoin a set of users for a queue
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>Task of ApiResponse (WrapupCodeEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCodeEntityListing>> RoutingWrapupcodesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null);
        /// <summary>
        /// Create a wrap-up code
=======
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueMember>> PatchQueuesQueueIdUsersAsyncWithHttpInfo (string queueId, List<QueueMember> body = null);
        /// <summary>
        /// Update the ring number of joined status for a User in a Queue
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>Task of CallableTimeSet</returns>
        System.Threading.Tasks.Task<CallableTimeSet> RoutingWrapupcodesPostAsync (WrapupCode body = null);

        /// <summary>
        /// Create a wrap-up code
=======
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Queue Member (optional)</param>
        /// <returns>Task of QueueMember</returns>
        System.Threading.Tasks.Task<QueueMember> PatchQueuesQueueIdUsersMemberIdAsync (string queueId, string memberId, QueueMember body = null);

        /// <summary>
        /// Update the ring number of joined status for a User in a Queue
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Queue Member (optional)</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueueMember>> PatchQueuesQueueIdUsersMemberIdAsyncWithHttpInfo (string queueId, string memberId, QueueMember body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Create a domain
        /// </summary>
<<<<<<< HEAD
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
=======
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Domain (optional)</param>
        /// <returns>Task of InboundDomain</returns>
        System.Threading.Tasks.Task<InboundDomain> PostEmailDomainsAsync (InboundDomain body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Create a domain
        /// </summary>
<<<<<<< HEAD
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

=======
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Domain (optional)</param>
        /// <returns>Task of ApiResponse (InboundDomain)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundDomain>> PostEmailDomainsAsyncWithHttpInfo (InboundDomain body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
        System.Threading.Tasks.Task<InboundRoute> PostEmailDomainsDomainRoutesAsync (string domain, InboundRoute body = null);

        /// <summary>
        /// Create a route
        /// </summary>
<<<<<<< HEAD
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

=======
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        System.Threading.Tasks.Task<ApiResponse<InboundRoute>> PostEmailDomainsDomainRoutesAsyncWithHttpInfo (string domain, InboundRoute body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>Task of InboundRoute</returns>
        System.Threading.Tasks.Task<InboundRoute> PutEmailDomainsDomainRoutesIdAsync (string domain, string id, InboundRoute body = null);

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
        System.Threading.Tasks.Task<ApiResponse<InboundRoute>> PutEmailDomainsDomainRoutesIdAsyncWithHttpInfo (string domain, string id, InboundRoute body = null);
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
        /// Update Routing Skill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skillId">Skill ID</param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>Task of RoutingSkill</returns>
        System.Threading.Tasks.Task<RoutingSkill> PutSkillsSkillIdAsync (string skillId, RoutingSkill body = null);

        /// <summary>
        /// Update Routing Skill
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skillId">Skill ID</param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>Task of ApiResponse (RoutingSkill)</returns>
        System.Threading.Tasks.Task<ApiResponse<RoutingSkill>> PutSkillsSkillIdAsyncWithHttpInfo (string skillId, RoutingSkill body = null);
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
        /// Delete a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>string</returns>
        public string DeleteEmailDomainsDomainRoutesId (string domain, string id)
        {
             ApiResponse<string> localVarResponse = DeleteEmailDomainsDomainRoutesIdWithHttpInfo(domain, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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

            var localVarPath = "/api/v2/routing/email/domains/{domain}/routes/{id}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailDomainsDomainRoutesId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailDomainsDomainRoutesId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> DeleteEmailDomainsDomainRoutesIdAsync (string domain, string id)
        {
             ApiResponse<string> localVarResponse = await DeleteEmailDomainsDomainRoutesIdAsyncWithHttpInfo(domain, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteEmailDomainsDomainRoutesIdAsyncWithHttpInfo (string domain, string id)
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingApi->DeleteEmailDomainsDomainRoutesId");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoutingApi->DeleteEmailDomainsDomainRoutesId");

            var localVarPath = "/api/v2/routing/email/domains/{domain}/routes/{id}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailDomainsDomainRoutesId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailDomainsDomainRoutesId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">domain ID</param>
        /// <returns>string</returns>
        public string DeleteEmailDomainsId (string id)
        {
             ApiResponse<string> localVarResponse = DeleteEmailDomainsIdWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">domain ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteEmailDomainsIdWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoutingApi->DeleteEmailDomainsId");

            var localVarPath = "/api/v2/routing/email/domains/{id}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailDomainsId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailDomainsId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> DeleteEmailDomainsIdAsync (string id)
        {
             ApiResponse<string> localVarResponse = await DeleteEmailDomainsIdAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">domain ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteEmailDomainsIdAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoutingApi->DeleteEmailDomainsId");

            var localVarPath = "/api/v2/routing/email/domains/{id}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailDomainsId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailDomainsId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (domain != null) localVarPathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
=======
            if (skillId != null) localVarPathParams.Add("skillId", Configuration.ApiClient.ParameterToString(skillId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRouteEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRouteEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRouteEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteSkillsSkillId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSkillsSkillId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get routes 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <returns>Task of InboundRouteEntityListing</returns>
        public async System.Threading.Tasks.Task<InboundRouteEntityListing> RoutingEmailDomainsDomainRoutesGetAsync (string domain)
        {
             ApiResponse<InboundRouteEntityListing> localVarResponse = await RoutingEmailDomainsDomainRoutesGetAsyncWithHttpInfo(domain);
=======
        /// Delete Routing Skill 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skillId">Skill ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteSkillsSkillIdAsync (string skillId)
        {
             ApiResponse<string> localVarResponse = await DeleteSkillsSkillIdAsyncWithHttpInfo(skillId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (domain != null) localVarPathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter

            // authentication (PureCloud Auth) required
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
<<<<<<< HEAD

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======

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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRouteEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRouteEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRouteEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserIdRoutingskillsSkillId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUserIdRoutingskillsSkillId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>string</returns>
        public string RoutingEmailDomainsDomainRoutesIdDelete (string domain, string id)
        {
             ApiResponse<string> localVarResponse = RoutingEmailDomainsDomainRoutesIdDeleteWithHttpInfo(domain, id);
=======
        /// Delete utilization settings and revert to system defaults. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>string</returns>
        public string DeleteUtilization ()
        {
             ApiResponse<string> localVarResponse = DeleteUtilizationWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Delete utilization settings and revert to system defaults. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteUtilizationWithHttpInfo ()
        {

            var localVarPath = "/api/v2/routing/utilization";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (domain != null) localVarPathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesIdDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesIdDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteUtilization: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteUtilization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RoutingEmailDomainsDomainRoutesIdDeleteAsync (string domain, string id)
        {
             ApiResponse<string> localVarResponse = await RoutingEmailDomainsDomainRoutesIdDeleteAsyncWithHttpInfo(domain, id);
=======
        /// Delete utilization settings and revert to system defaults. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteUtilizationAsync ()
        {
             ApiResponse<string> localVarResponse = await DeleteUtilizationAsyncWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Delete utilization settings and revert to system defaults. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteUtilizationAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/routing/utilization";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (domain != null) localVarPathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
=======

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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesIdDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesIdDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteWrapupcodesCodeId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWrapupcodesCodeId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>InboundRoute</returns>
        public InboundRoute RoutingEmailDomainsDomainRoutesIdGet (string domain, string id)
        {
             ApiResponse<InboundRoute> localVarResponse = RoutingEmailDomainsDomainRoutesIdGetWithHttpInfo(domain, id);
=======
        /// Get domains 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InboundDomainEntityListing</returns>
        public InboundDomainEntityListing GetEmailDomains ()
        {
             ApiResponse<InboundDomainEntityListing> localVarResponse = GetEmailDomainsWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Get domains 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InboundDomainEntityListing</returns>
        public ApiResponse< InboundDomainEntityListing > GetEmailDomainsWithHttpInfo ()
        {

            var localVarPath = "/api/v2/routing/email/domains";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (domain != null) localVarPathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRoute)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetEmailDomains: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailDomains: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundDomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundDomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundDomainEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <returns>Task of InboundRoute</returns>
        public async System.Threading.Tasks.Task<InboundRoute> RoutingEmailDomainsDomainRoutesIdGetAsync (string domain, string id)
        {
             ApiResponse<InboundRoute> localVarResponse = await RoutingEmailDomainsDomainRoutesIdGetAsyncWithHttpInfo(domain, id);
=======
        /// Get domains 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InboundDomainEntityListing</returns>
        public async System.Threading.Tasks.Task<InboundDomainEntityListing> GetEmailDomainsAsync ()
        {
             ApiResponse<InboundDomainEntityListing> localVarResponse = await GetEmailDomainsAsyncWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Get domains 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InboundDomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundDomainEntityListing>> GetEmailDomainsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/routing/email/domains";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (domain != null) localVarPathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRoute)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetEmailDomains: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailDomains: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundDomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundDomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundDomainEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Get routes 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <returns>InboundRouteEntityListing</returns>
        public InboundRouteEntityListing GetEmailDomainsDomainRoutes (string domain)
        {
             ApiResponse<InboundRouteEntityListing> localVarResponse = GetEmailDomainsDomainRoutesWithHttpInfo(domain);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Get routes 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <returns>ApiResponse of InboundRouteEntityListing</returns>
        public ApiResponse< InboundRouteEntityListing > GetEmailDomainsDomainRoutesWithHttpInfo (string domain)
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingApi->GetEmailDomainsDomainRoutes");

            var localVarPath = "/api/v2/routing/email/domains/{domain}/routes";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesIdPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesIdPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRoute)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetEmailDomainsDomainRoutes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailDomainsDomainRoutes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRouteEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRouteEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRouteEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Get routes 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <returns>Task of InboundRouteEntityListing</returns>
        public async System.Threading.Tasks.Task<InboundRouteEntityListing> GetEmailDomainsDomainRoutesAsync (string domain)
        {
             ApiResponse<InboundRouteEntityListing> localVarResponse = await GetEmailDomainsDomainRoutesAsyncWithHttpInfo(domain);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Get routes 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <returns>Task of ApiResponse (InboundRouteEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundRouteEntityListing>> GetEmailDomainsDomainRoutesAsyncWithHttpInfo (string domain)
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingApi->GetEmailDomainsDomainRoutes");

            var localVarPath = "/api/v2/routing/email/domains/{domain}/routes";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesIdPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesIdPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRoute)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetEmailDomainsDomainRoutes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailDomainsDomainRoutes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRouteEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRouteEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRouteEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Create a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
<<<<<<< HEAD
        /// <param name="body">Route (optional)</param>
        /// <returns>InboundRoute</returns>
        public InboundRoute RoutingEmailDomainsDomainRoutesPost (string domain, InboundRoute body = null)
        {
             ApiResponse<InboundRoute> localVarResponse = RoutingEmailDomainsDomainRoutesPostWithHttpInfo(domain, body);
=======
        /// <param name="id">route ID</param>
        /// <returns>InboundRoute</returns>
        public InboundRoute GetEmailDomainsDomainRoutesId (string domain, string id)
        {
             ApiResponse<InboundRoute> localVarResponse = GetEmailDomainsDomainRoutesIdWithHttpInfo(domain, id);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
<<<<<<< HEAD
        /// <param name="body">Route (optional)</param>
        /// <returns>ApiResponse of InboundRoute</returns>
        public ApiResponse< InboundRoute > RoutingEmailDomainsDomainRoutesPostWithHttpInfo (string domain, InboundRoute body = null)
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingApi->RoutingEmailDomainsDomainRoutesPost");

            var localVarPath = "/api/v1/routing/email/domains/{domain}/routes";
=======
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

            var localVarPath = "/api/v2/routing/email/domains/{domain}/routes/{id}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling GetEmailDomainsDomainRoutesId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailDomainsDomainRoutesId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
        public async System.Threading.Tasks.Task<InboundRoute> RoutingEmailDomainsDomainRoutesPostAsync (string domain, InboundRoute body = null)
        {
             ApiResponse<InboundRoute> localVarResponse = await RoutingEmailDomainsDomainRoutesPostAsyncWithHttpInfo(domain, body);
=======
        public async System.Threading.Tasks.Task<InboundRoute> GetEmailDomainsDomainRoutesIdAsync (string domain, string id)
        {
             ApiResponse<InboundRoute> localVarResponse = await GetEmailDomainsDomainRoutesIdAsyncWithHttpInfo(domain, id);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
<<<<<<< HEAD
        public async System.Threading.Tasks.Task<ApiResponse<InboundRoute>> RoutingEmailDomainsDomainRoutesPostAsyncWithHttpInfo (string domain, InboundRoute body = null)
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingApi->RoutingEmailDomainsDomainRoutesPost");

            var localVarPath = "/api/v1/routing/email/domains/{domain}/routes";
=======
        public async System.Threading.Tasks.Task<ApiResponse<InboundRoute>> GetEmailDomainsDomainRoutesIdAsyncWithHttpInfo (string domain, string id)
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingApi->GetEmailDomainsDomainRoutesId");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoutingApi->GetEmailDomainsDomainRoutesId");

            var localVarPath = "/api/v2/routing/email/domains/{domain}/routes/{id}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsDomainRoutesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling GetEmailDomainsDomainRoutesId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailDomainsDomainRoutesId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            return new ApiResponse<InboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRoute)));
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get domains 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InboundDomainEntityListing</returns>
        public InboundDomainEntityListing RoutingEmailDomainsGet ()
        {
             ApiResponse<InboundDomainEntityListing> localVarResponse = RoutingEmailDomainsGetWithHttpInfo();
=======
        /// Get email setup 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EmailSetup</returns>
        public EmailSetup GetEmailSetup ()
        {
             ApiResponse<EmailSetup> localVarResponse = GetEmailSetupWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Get domains 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InboundDomainEntityListing</returns>
        public ApiResponse< InboundDomainEntityListing > RoutingEmailDomainsGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/routing/email/domains";
=======
        /// Get email setup 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EmailSetup</returns>
        public ApiResponse< EmailSetup > GetEmailSetupWithHttpInfo ()
        {

            var localVarPath = "/api/v2/routing/email/setup";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundDomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundDomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundDomainEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetEmailSetup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailSetup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailSetup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailSetup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailSetup)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get domains 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InboundDomainEntityListing</returns>
        public async System.Threading.Tasks.Task<InboundDomainEntityListing> RoutingEmailDomainsGetAsync ()
        {
             ApiResponse<InboundDomainEntityListing> localVarResponse = await RoutingEmailDomainsGetAsyncWithHttpInfo();
=======
        /// Get email setup 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EmailSetup</returns>
        public async System.Threading.Tasks.Task<EmailSetup> GetEmailSetupAsync ()
        {
             ApiResponse<EmailSetup> localVarResponse = await GetEmailSetupAsyncWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Get domains 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InboundDomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundDomainEntityListing>> RoutingEmailDomainsGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/routing/email/domains";
=======
        /// Get email setup 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EmailSetup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailSetup>> GetEmailSetupAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/routing/email/setup";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundDomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundDomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundDomainEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetEmailSetup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailSetup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailSetup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailSetup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailSetup)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">domain ID</param>
        /// <returns>string</returns>
        public string RoutingEmailDomainsIdDelete (string id)
        {
             ApiResponse<string> localVarResponse = RoutingEmailDomainsIdDeleteWithHttpInfo(id);
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
=======
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (active != null) localVarQueryParams.Add("active", Configuration.ApiClient.ParameterToString(active)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsIdDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsIdDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetQueues: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQueues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">domain ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RoutingEmailDomainsIdDeleteAsync (string id)
        {
             ApiResponse<string> localVarResponse = await RoutingEmailDomainsIdDeleteAsyncWithHttpInfo(id);
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
=======
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (active != null) localVarQueryParams.Add("active", Configuration.ApiClient.ParameterToString(active)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsIdDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsIdDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetQueues: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQueues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Create a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Domain (optional)</param>
        /// <returns>InboundDomain</returns>
        public InboundDomain RoutingEmailDomainsPost (InboundDomain body = null)
        {
             ApiResponse<InboundDomain> localVarResponse = RoutingEmailDomainsPostWithHttpInfo(body);
=======
        /// Get details about this queue. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Queue</returns>
        public Queue GetQueuesQueueId (string queueId)
        {
             ApiResponse<Queue> localVarResponse = GetQueuesQueueIdWithHttpInfo(queueId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Create a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Domain (optional)</param>
        /// <returns>ApiResponse of InboundDomain</returns>
        public ApiResponse< InboundDomain > RoutingEmailDomainsPostWithHttpInfo (InboundDomain body = null)
        {

            var localVarPath = "/api/v1/routing/email/domains";
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundDomain>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundDomain) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundDomain)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Queue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Queue)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Create a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Domain (optional)</param>
        /// <returns>Task of InboundDomain</returns>
        public async System.Threading.Tasks.Task<InboundDomain> RoutingEmailDomainsPostAsync (InboundDomain body = null)
        {
             ApiResponse<InboundDomain> localVarResponse = await RoutingEmailDomainsPostAsyncWithHttpInfo(body);
=======
        /// Get details about this queue. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of Queue</returns>
        public async System.Threading.Tasks.Task<Queue> GetQueuesQueueIdAsync (string queueId)
        {
             ApiResponse<Queue> localVarResponse = await GetQueuesQueueIdAsyncWithHttpInfo(queueId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Create a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Domain (optional)</param>
        /// <returns>Task of ApiResponse (InboundDomain)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundDomain>> RoutingEmailDomainsPostAsyncWithHttpInfo (InboundDomain body = null)
        {

            var localVarPath = "/api/v1/routing/email/domains";
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailDomainsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundDomain>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundDomain) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundDomain)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Queue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Queue)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get Estimated Wait Time 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>EmailSetup</returns>
        public EmailSetup RoutingEmailSetupGet ()
        {
             ApiResponse<EmailSetup> localVarResponse = RoutingEmailSetupGetWithHttpInfo();
=======
        /// <param name="queueId">queueId</param>
        /// <param name="conversationId">conversationId (optional)</param>
        /// <returns>EstimatedWaitTimePredictions</returns>
        public EstimatedWaitTimePredictions GetQueuesQueueIdEstimatedwaittime (string queueId, string conversationId = null)
        {
             ApiResponse<EstimatedWaitTimePredictions> localVarResponse = GetQueuesQueueIdEstimatedwaittimeWithHttpInfo(queueId, conversationId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Estimated Wait Time 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailSetupGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailSetupGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailSetup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailSetup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailSetup)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueIdEstimatedwaittime: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueIdEstimatedwaittime: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EstimatedWaitTimePredictions>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstimatedWaitTimePredictions) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstimatedWaitTimePredictions)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get Estimated Wait Time 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of EmailSetup</returns>
        public async System.Threading.Tasks.Task<EmailSetup> RoutingEmailSetupGetAsync ()
        {
             ApiResponse<EmailSetup> localVarResponse = await RoutingEmailSetupGetAsyncWithHttpInfo();
=======
        /// <param name="queueId">queueId</param>
        /// <param name="conversationId">conversationId (optional)</param>
        /// <returns>Task of EstimatedWaitTimePredictions</returns>
        public async System.Threading.Tasks.Task<EstimatedWaitTimePredictions> GetQueuesQueueIdEstimatedwaittimeAsync (string queueId, string conversationId = null)
        {
             ApiResponse<EstimatedWaitTimePredictions> localVarResponse = await GetQueuesQueueIdEstimatedwaittimeAsyncWithHttpInfo(queueId, conversationId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Estimated Wait Time 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of ApiResponse (EmailSetup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailSetup>> RoutingEmailSetupGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/routing/email/setup";
=======
        /// <param name="queueId">queueId</param>
        /// <param name="conversationId">conversationId (optional)</param>
        /// <returns>Task of ApiResponse (EstimatedWaitTimePredictions)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EstimatedWaitTimePredictions>> GetQueuesQueueIdEstimatedwaittimeAsyncWithHttpInfo (string queueId, string conversationId = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->GetQueuesQueueIdEstimatedwaittime");

            var localVarPath = "/api/v2/routing/queues/{queueId}/estimatedwaittime";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
=======
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (conversationId != null) localVarQueryParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailSetupGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingEmailSetupGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailSetup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailSetup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailSetup)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueIdEstimatedwaittime: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueIdEstimatedwaittime: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EstimatedWaitTimePredictions>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstimatedWaitTimePredictions) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstimatedWaitTimePredictions)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get the members of this queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
<<<<<<< HEAD
        /// <param name="name">Name (optional)</param>
        /// <param name="active">Active (optional)</param>
        /// <returns>QueueEntityListing</returns>
        public QueueEntityListing RoutingQueuesGet (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null)
        {
             ApiResponse<QueueEntityListing> localVarResponse = RoutingQueuesGetWithHttpInfo(queueId, pageSize, pageNumber, sortBy, name, active);
=======
        /// <param name="expand">expand (optional)</param>
        /// <param name="directMembers">Only get users that are direct members of the queue (optional, default to false)</param>
        /// <returns>QueueMember</returns>
        public QueueMember GetQueuesQueueIdUsers (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null)
        {
             ApiResponse<QueueMember> localVarResponse = GetQueuesQueueIdUsersWithHttpInfo(queueId, pageSize, pageNumber, sortBy, expand, directMembers);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
        /// <param name="name">Name (optional)</param>
        /// <param name="active">Active (optional)</param>
        /// <returns>ApiResponse of QueueEntityListing</returns>
        public ApiResponse< QueueEntityListing > RoutingQueuesGetWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesGet");

            var localVarPath = "/api/v1/routing/queues";
=======
        /// <param name="expand">expand (optional)</param>
        /// <param name="directMembers">Only get users that are direct members of the queue (optional, default to false)</param>
        /// <returns>ApiResponse of QueueMember</returns>
        public ApiResponse< QueueMember > GetQueuesQueueIdUsersWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->GetQueuesQueueIdUsers");

            var localVarPath = "/api/v2/routing/queues/{queueId}/users";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (queueId != null) localVarPathParams.Add("QueueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (active != null) localVarQueryParams.Add("active", Configuration.ApiClient.ParameterToString(active)); // query parameter
=======
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (directMembers != null) localVarQueryParams.Add("directMembers", Configuration.ApiClient.ParameterToString(directMembers)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueIdUsers: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueIdUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMember)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get the members of this queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
<<<<<<< HEAD
        /// <param name="name">Name (optional)</param>
        /// <param name="active">Active (optional)</param>
        /// <returns>Task of QueueEntityListing</returns>
        public async System.Threading.Tasks.Task<QueueEntityListing> RoutingQueuesGetAsync (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null)
        {
             ApiResponse<QueueEntityListing> localVarResponse = await RoutingQueuesGetAsyncWithHttpInfo(queueId, pageSize, pageNumber, sortBy, name, active);
=======
        /// <param name="expand">expand (optional)</param>
        /// <param name="directMembers">Only get users that are direct members of the queue (optional, default to false)</param>
        /// <returns>Task of QueueMember</returns>
        public async System.Threading.Tasks.Task<QueueMember> GetQueuesQueueIdUsersAsync (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null)
        {
             ApiResponse<QueueMember> localVarResponse = await GetQueuesQueueIdUsersAsyncWithHttpInfo(queueId, pageSize, pageNumber, sortBy, expand, directMembers);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
        /// <param name="name">Name (optional)</param>
        /// <param name="active">Active (optional)</param>
        /// <returns>Task of ApiResponse (QueueEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueueEntityListing>> RoutingQueuesGetAsyncWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, bool? active = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesGet");

            var localVarPath = "/api/v1/routing/queues";
=======
        /// <param name="expand">expand (optional)</param>
        /// <param name="directMembers">Only get users that are direct members of the queue (optional, default to false)</param>
        /// <returns>Task of ApiResponse (QueueMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueueMember>> GetQueuesQueueIdUsersAsyncWithHttpInfo (string queueId, int? pageSize = null, int? pageNumber = null, string sortBy = null, string expand = null, bool? directMembers = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->GetQueuesQueueIdUsers");

            var localVarPath = "/api/v2/routing/queues/{queueId}/users";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (queueId != null) localVarPathParams.Add("QueueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (active != null) localVarQueryParams.Add("active", Configuration.ApiClient.ParameterToString(active)); // query parameter
=======
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (directMembers != null) localVarQueryParams.Add("directMembers", Configuration.ApiClient.ParameterToString(directMembers)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueIdUsers: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueIdUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMember)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get the wrap-up codes for a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
<<<<<<< HEAD
        /// <param name="body">Queue (optional)</param>
        /// <returns>Queue</returns>
        public Queue RoutingQueuesPost (string queueId, Queue body = null)
        {
             ApiResponse<Queue> localVarResponse = RoutingQueuesPostWithHttpInfo(queueId, body);
=======
        /// <param name="codeId">Code ID</param>
        /// <returns>WrapupCode</returns>
        public WrapupCode GetQueuesQueueIdWrapupcodes (string queueId, string codeId)
        {
             ApiResponse<WrapupCode> localVarResponse = GetQueuesQueueIdWrapupcodesWithHttpInfo(queueId, codeId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the wrap-up codes for a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
<<<<<<< HEAD
        /// <param name="body">Queue (optional)</param>
        /// <returns>ApiResponse of Queue</returns>
        public ApiResponse< Queue > RoutingQueuesPostWithHttpInfo (string queueId, Queue body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesPost");

            var localVarPath = "/api/v1/routing/queues";
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (queueId != null) localVarPathParams.Add("QueueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (codeId != null) localVarPathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Queue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Queue)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQueuesQueueIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get the wrap-up codes for a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
<<<<<<< HEAD
        /// <param name="body">Queue (optional)</param>
        /// <returns>Task of Queue</returns>
        public async System.Threading.Tasks.Task<Queue> RoutingQueuesPostAsync (string queueId, Queue body = null)
        {
             ApiResponse<Queue> localVarResponse = await RoutingQueuesPostAsyncWithHttpInfo(queueId, body);
=======
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> GetQueuesQueueIdWrapupcodesAsync (string queueId, string codeId)
        {
             ApiResponse<WrapupCode> localVarResponse = await GetQueuesQueueIdWrapupcodesAsyncWithHttpInfo(queueId, codeId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the wrap-up codes for a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
<<<<<<< HEAD
        /// <param name="body">Queue (optional)</param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Queue>> RoutingQueuesPostAsyncWithHttpInfo (string queueId, Queue body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesPost");

            var localVarPath = "/api/v1/routing/queues";
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (queueId != null) localVarPathParams.Add("QueueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (codeId != null) localVarPathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
=======
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RoutingQueuesQueueidDeleteAsync (string queueId)
        {
             ApiResponse<string> localVarResponse = await RoutingQueuesQueueidDeleteAsyncWithHttpInfo(queueId);
=======
        /// Get Routing Skill 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skillId">Skill ID</param>
        /// <returns>Task of RoutingSkill</returns>
        public async System.Threading.Tasks.Task<RoutingSkill> GetSkillsSkillIdAsync (string skillId)
        {
             ApiResponse<RoutingSkill> localVarResponse = await GetSkillsSkillIdAsyncWithHttpInfo(skillId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
=======
            if (skillId != null) localVarPathParams.Add("skillId", Configuration.ApiClient.ParameterToString(skillId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetSkillsSkillId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSkillsSkillId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoutingSkill>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoutingSkill) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoutingSkill)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get details about this queue. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Queue</returns>
        public Queue RoutingQueuesQueueidGet (string queueId)
        {
             ApiResponse<Queue> localVarResponse = RoutingQueuesQueueidGetWithHttpInfo(queueId);
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
=======
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Queue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Queue)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetUserIdRoutingskills: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserIdRoutingskills: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserSkillEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserSkillEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserSkillEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get details about this queue. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <returns>Task of Queue</returns>
        public async System.Threading.Tasks.Task<Queue> RoutingQueuesQueueidGetAsync (string queueId)
        {
             ApiResponse<Queue> localVarResponse = await RoutingQueuesQueueidGetAsyncWithHttpInfo(queueId);
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
=======
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Queue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Queue)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetUserIdRoutingskills: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserIdRoutingskills: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserSkillEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserSkillEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserSkillEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <returns>Utilization</returns>
        public Utilization GetUtilization ()
        {
             ApiResponse<Utilization> localVarResponse = GetUtilizationWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <returns>ApiResponse of Utilization</returns>
        public ApiResponse< Utilization > GetUtilizationWithHttpInfo ()
        {

            var localVarPath = "/api/v2/routing/utilization";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (userId != null) localVarQueryParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (statusId != null) localVarQueryParams.Add("statusId", Configuration.ApiClient.ParameterToString(statusId)); // query parameter
            if (joined != null) localVarQueryParams.Add("joined", Configuration.ApiClient.ParameterToString(joined)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidMembersGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidMembersGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMemberEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMemberEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMemberEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetUtilization: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUtilization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Utilization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Utilization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Utilization)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <returns>Task of Utilization</returns>
        public async System.Threading.Tasks.Task<Utilization> GetUtilizationAsync ()
        {
             ApiResponse<Utilization> localVarResponse = await GetUtilizationAsyncWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <returns>Task of ApiResponse (Utilization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Utilization>> GetUtilizationAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/routing/utilization";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (userId != null) localVarQueryParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (statusId != null) localVarQueryParams.Add("statusId", Configuration.ApiClient.ParameterToString(statusId)); // query parameter
            if (joined != null) localVarQueryParams.Add("joined", Configuration.ApiClient.ParameterToString(joined)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidMembersGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidMembersGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMemberEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMemberEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMemberEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetUtilization: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUtilization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Utilization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Utilization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Utilization)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get list of wrapup codes. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member/User ID</param>
        /// <param name="body">To join queue ~ \&quot;joined\&quot;:true (optional)</param>
        /// <returns>QueueMember</returns>
        public QueueMember RoutingQueuesQueueidMembersMemberidPut (string queueId, string memberId, QueueMember body = null)
        {
             ApiResponse<QueueMember> localVarResponse = RoutingQueuesQueueidMembersMemberidPutWithHttpInfo(queueId, memberId, body);
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>WrapupCodeEntityListing</returns>
        public WrapupCodeEntityListing GetWrapupcodes (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {
             ApiResponse<WrapupCodeEntityListing> localVarResponse = GetWrapupcodesWithHttpInfo(pageSize, pageNumber, sortBy);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of wrapup codes. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>ApiResponse of WrapupCodeEntityListing</returns>
        public ApiResponse< WrapupCodeEntityListing > GetWrapupcodesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {

            var localVarPath = "/api/v2/routing/wrapupcodes";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
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
=======
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidMembersMemberidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidMembersMemberidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMember)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCodeEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCodeEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCodeEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get list of wrapup codes. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member/User ID</param>
        /// <param name="body">To join queue ~ \&quot;joined\&quot;:true (optional)</param>
        /// <returns>Task of QueueMember</returns>
        public async System.Threading.Tasks.Task<QueueMember> RoutingQueuesQueueidMembersMemberidPutAsync (string queueId, string memberId, QueueMember body = null)
        {
             ApiResponse<QueueMember> localVarResponse = await RoutingQueuesQueueidMembersMemberidPutAsyncWithHttpInfo(queueId, memberId, body);
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>Task of WrapupCodeEntityListing</returns>
        public async System.Threading.Tasks.Task<WrapupCodeEntityListing> GetWrapupcodesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {
             ApiResponse<WrapupCodeEntityListing> localVarResponse = await GetWrapupcodesAsyncWithHttpInfo(pageSize, pageNumber, sortBy);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of wrapup codes. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <returns>Task of ApiResponse (WrapupCodeEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCodeEntityListing>> GetWrapupcodesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {

            var localVarPath = "/api/v2/routing/wrapupcodes";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
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
=======
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (codeId != null) localVarPathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
<<<<<<< HEAD
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
=======
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
                throw new ApiException (localVarStatusCode, "Error calling PatchQueuesQueueIdUsers: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchQueuesQueueIdUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMember)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Update a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Task of Queue</returns>
        public async System.Threading.Tasks.Task<Queue> RoutingQueuesQueueidPutAsync (string queueId, Queue body = null)
        {
             ApiResponse<Queue> localVarResponse = await RoutingQueuesQueueidPutAsyncWithHttpInfo(queueId, body);
=======
        /// Join or unjoin a set of users for a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <returns>Task of QueueMember</returns>
        public async System.Threading.Tasks.Task<QueueMember> PatchQueuesQueueIdUsersAsync (string queueId, List<QueueMember> body = null)
        {
             ApiResponse<QueueMember> localVarResponse = await PatchQueuesQueueIdUsersAsyncWithHttpInfo(queueId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Queue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Queue)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PatchQueuesQueueIdUsers: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchQueuesQueueIdUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMember)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (directMembers != null) localVarQueryParams.Add("directMembers", Configuration.ApiClient.ParameterToString(directMembers)); // query parameter
=======
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling PatchQueuesQueueIdUsersMemberId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchQueuesQueueIdUsersMemberId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            return new ApiResponse<QueueMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMember)));
            
        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (directMembers != null) localVarQueryParams.Add("directMembers", Configuration.ApiClient.ParameterToString(directMembers)); // query parameter
=======
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling PatchQueuesQueueIdUsersMemberId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchQueuesQueueIdUsersMemberId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            return new ApiResponse<QueueMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMember)));
            
        }

        /// <summary>
        /// Create a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>string</returns>
        public string RoutingQueuesQueueidUsersMemberidDelete (string queueId, string memberId)
        {
             ApiResponse<string> localVarResponse = RoutingQueuesQueueidUsersMemberidDeleteWithHttpInfo(queueId, memberId);
=======
        /// <param name="body">Domain (optional)</param>
        /// <returns>InboundDomain</returns>
        public InboundDomain PostEmailDomains (InboundDomain body = null)
        {
             ApiResponse<InboundDomain> localVarResponse = PostEmailDomainsWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="body">Domain (optional)</param>
        /// <returns>ApiResponse of InboundDomain</returns>
        public ApiResponse< InboundDomain > PostEmailDomainsWithHttpInfo (InboundDomain body = null)
        {

            var localVarPath = "/api/v2/routing/email/domains";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersMemberidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersMemberidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostEmailDomains: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEmailDomains: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundDomain>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundDomain) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundDomain)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Create a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RoutingQueuesQueueidUsersMemberidDeleteAsync (string queueId, string memberId)
        {
             ApiResponse<string> localVarResponse = await RoutingQueuesQueueidUsersMemberidDeleteAsyncWithHttpInfo(queueId, memberId);
=======
        /// <param name="body">Domain (optional)</param>
        /// <returns>Task of InboundDomain</returns>
        public async System.Threading.Tasks.Task<InboundDomain> PostEmailDomainsAsync (InboundDomain body = null)
        {
             ApiResponse<InboundDomain> localVarResponse = await PostEmailDomainsAsyncWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a domain 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="body">Domain (optional)</param>
        /// <returns>Task of ApiResponse (InboundDomain)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundDomain>> PostEmailDomainsAsyncWithHttpInfo (InboundDomain body = null)
        {

            var localVarPath = "/api/v2/routing/email/domains";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersMemberidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersMemberidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostEmailDomains: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEmailDomains: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundDomain>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundDomain) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundDomain)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Create a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Queue Member (optional)</param>
        /// <returns>QueueMember</returns>
        public QueueMember RoutingQueuesQueueidUsersMemberidPatch (string queueId, string memberId, QueueMember body = null)
        {
             ApiResponse<QueueMember> localVarResponse = RoutingQueuesQueueidUsersMemberidPatchWithHttpInfo(queueId, memberId, body);
=======
        /// <param name="domain">email domain</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>InboundRoute</returns>
        public InboundRoute PostEmailDomainsDomainRoutes (string domain, InboundRoute body = null)
        {
             ApiResponse<InboundRoute> localVarResponse = PostEmailDomainsDomainRoutesWithHttpInfo(domain, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="domain">email domain</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>ApiResponse of InboundRoute</returns>
        public ApiResponse< InboundRoute > PostEmailDomainsDomainRoutesWithHttpInfo (string domain, InboundRoute body = null)
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingApi->PostEmailDomainsDomainRoutes");

            var localVarPath = "/api/v2/routing/email/domains/{domain}/routes";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
=======
            if (domain != null) localVarPathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersMemberidPatch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersMemberidPatch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMember)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostEmailDomainsDomainRoutes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEmailDomainsDomainRoutes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRoute)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Create a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="queueId">Queue ID</param>
        /// <param name="memberId">Member ID</param>
        /// <param name="body">Queue Member (optional)</param>
        /// <returns>Task of QueueMember</returns>
        public async System.Threading.Tasks.Task<QueueMember> RoutingQueuesQueueidUsersMemberidPatchAsync (string queueId, string memberId, QueueMember body = null)
        {
             ApiResponse<QueueMember> localVarResponse = await RoutingQueuesQueueidUsersMemberidPatchAsyncWithHttpInfo(queueId, memberId, body);
=======
        /// <param name="domain">email domain</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>Task of InboundRoute</returns>
        public async System.Threading.Tasks.Task<InboundRoute> PostEmailDomainsDomainRoutesAsync (string domain, InboundRoute body = null)
        {
             ApiResponse<InboundRoute> localVarResponse = await PostEmailDomainsDomainRoutesAsyncWithHttpInfo(domain, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
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
=======
        /// <param name="domain">email domain</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundRoute>> PostEmailDomainsDomainRoutesAsyncWithHttpInfo (string domain, InboundRoute body = null)
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingApi->PostEmailDomainsDomainRoutes");

            var localVarPath = "/api/v2/routing/email/domains/{domain}/routes";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (memberId != null) localVarPathParams.Add("memberId", Configuration.ApiClient.ParameterToString(memberId)); // path parameter
=======
            if (domain != null) localVarPathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersMemberidPatch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersMemberidPatch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMember)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostEmailDomainsDomainRoutes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEmailDomainsDomainRoutes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRoute)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Join or unjoin a set of users for a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue Members (optional)</param>
        /// <returns>QueueMember</returns>
        public QueueMember RoutingQueuesQueueidUsersPatch (string queueId, List<QueueMember> body = null)
        {
             ApiResponse<QueueMember> localVarResponse = RoutingQueuesQueueidUsersPatchWithHttpInfo(queueId, body);
=======
        /// Create queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Queue</returns>
        public Queue PostQueues (Queue body = null)
        {
             ApiResponse<Queue> localVarResponse = PostQueuesWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Create queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Queue (optional)</param>
        /// <returns>ApiResponse of Queue</returns>
        public ApiResponse< Queue > PostQueuesWithHttpInfo (Queue body = null)
        {

            var localVarPath = "/api/v2/routing/queues";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
<<<<<<< HEAD
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
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

<<<<<<< HEAD
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

=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMember)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostQueues: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQueues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Queue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Queue)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Create queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Task of Queue</returns>
        public async System.Threading.Tasks.Task<Queue> PostQueuesAsync (Queue body = null)
        {
             ApiResponse<Queue> localVarResponse = await PostQueuesAsyncWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Create queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Task of ApiResponse (Queue)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Queue>> PostQueuesAsyncWithHttpInfo (Queue body = null)
        {

            var localVarPath = "/api/v2/routing/queues";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (delete != null) localVarQueryParams.Add("delete", Configuration.ApiClient.ParameterToString(delete)); // query parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidUsersPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMember)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostQueues: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQueues: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Queue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Queue)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete a wrap-up code from a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>string</returns>
        public string RoutingQueuesQueueidWrapupcodesCodeidDelete (string queueId, string codeId)
        {
             ApiResponse<string> localVarResponse = RoutingQueuesQueueidWrapupcodesCodeidDeleteWithHttpInfo(queueId, codeId);
=======
        /// Query for queue observations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>ObservationQueryResponse</returns>
        public ObservationQueryResponse PostQueuesObservationsQuery (ObservationQuery body = null)
        {
             ApiResponse<ObservationQueryResponse> localVarResponse = PostQueuesObservationsQueryWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Query for queue observations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>ApiResponse of ObservationQueryResponse</returns>
        public ApiResponse< ObservationQueryResponse > PostQueuesObservationsQueryWithHttpInfo (ObservationQuery body = null)
        {

            var localVarPath = "/api/v2/analytics/queues/observations/query";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (codeId != null) localVarPathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidWrapupcodesCodeidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidWrapupcodesCodeidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesObservationsQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesObservationsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ObservationQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ObservationQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ObservationQueryResponse)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete a wrap-up code from a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RoutingQueuesQueueidWrapupcodesCodeidDeleteAsync (string queueId, string codeId)
        {
             ApiResponse<string> localVarResponse = await RoutingQueuesQueueidWrapupcodesCodeidDeleteAsyncWithHttpInfo(queueId, codeId);
=======
        /// Query for queue observations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>Task of ObservationQueryResponse</returns>
        public async System.Threading.Tasks.Task<ObservationQueryResponse> PostQueuesObservationsQueryAsync (ObservationQuery body = null)
        {
             ApiResponse<ObservationQueryResponse> localVarResponse = await PostQueuesObservationsQueryAsyncWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Query for queue observations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>Task of ApiResponse (ObservationQueryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ObservationQueryResponse>> PostQueuesObservationsQueryAsyncWithHttpInfo (ObservationQuery body = null)
        {

            var localVarPath = "/api/v2/analytics/queues/observations/query";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (codeId != null) localVarPathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidWrapupcodesCodeidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidWrapupcodesCodeidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesObservationsQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesObservationsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ObservationQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ObservationQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ObservationQueryResponse)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get the wrap-up codes for a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>WrapupCode</returns>
        public WrapupCode RoutingQueuesQueueidWrapupcodesGet (string queueId, string codeId)
        {
             ApiResponse<WrapupCode> localVarResponse = RoutingQueuesQueueidWrapupcodesGetWithHttpInfo(queueId, codeId);
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (codeId != null) localVarPathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
=======
            if (delete != null) localVarQueryParams.Add("delete", Configuration.ApiClient.ParameterToString(delete)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidWrapupcodesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidWrapupcodesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesQueueIdUsers: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesQueueIdUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMember)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get the wrap-up codes for a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> RoutingQueuesQueueidWrapupcodesGetAsync (string queueId, string codeId)
        {
             ApiResponse<WrapupCode> localVarResponse = await RoutingQueuesQueueidWrapupcodesGetAsyncWithHttpInfo(queueId, codeId);
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (codeId != null) localVarPathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
=======
            if (delete != null) localVarQueryParams.Add("delete", Configuration.ApiClient.ParameterToString(delete)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidWrapupcodesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidWrapupcodesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesQueueIdUsers: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesQueueIdUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueueMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueueMember) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueueMember)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Add up to 100 wrap-up codes to a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="codeId">Code ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>WrapupCode</returns>
<<<<<<< HEAD
        public WrapupCode RoutingQueuesQueueidWrapupcodesPost (string queueId, string codeId, List<WrapupCode> body = null)
        {
             ApiResponse<WrapupCode> localVarResponse = RoutingQueuesQueueidWrapupcodesPostWithHttpInfo(queueId, codeId, body);
=======
        public WrapupCode PostQueuesQueueIdWrapupcodes (string queueId, string codeId, List<WrapupCode> body = null)
        {
             ApiResponse<WrapupCode> localVarResponse = PostQueuesQueueIdWrapupcodesWithHttpInfo(queueId, codeId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
        public ApiResponse< WrapupCode > RoutingQueuesQueueidWrapupcodesPostWithHttpInfo (string queueId, string codeId, List<WrapupCode> body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidWrapupcodesPost");
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->RoutingQueuesQueueidWrapupcodesPost");

            var localVarPath = "/api/v1/routing/queues/{queueId}/wrapupcodes";
=======
        public ApiResponse< WrapupCode > PostQueuesQueueIdWrapupcodesWithHttpInfo (string queueId, string codeId, List<WrapupCode> body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->PostQueuesQueueIdWrapupcodes");
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->PostQueuesQueueIdWrapupcodes");

            var localVarPath = "/api/v2/routing/queues/{queueId}/wrapupcodes";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidWrapupcodesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidWrapupcodesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesQueueIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesQueueIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
        public async System.Threading.Tasks.Task<WrapupCode> RoutingQueuesQueueidWrapupcodesPostAsync (string queueId, string codeId, List<WrapupCode> body = null)
        {
             ApiResponse<WrapupCode> localVarResponse = await RoutingQueuesQueueidWrapupcodesPostAsyncWithHttpInfo(queueId, codeId, body);
=======
        public async System.Threading.Tasks.Task<WrapupCode> PostQueuesQueueIdWrapupcodesAsync (string queueId, string codeId, List<WrapupCode> body = null)
        {
             ApiResponse<WrapupCode> localVarResponse = await PostQueuesQueueIdWrapupcodesAsyncWithHttpInfo(queueId, codeId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> RoutingQueuesQueueidWrapupcodesPostAsyncWithHttpInfo (string queueId, string codeId, List<WrapupCode> body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->RoutingQueuesQueueidWrapupcodesPost");
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->RoutingQueuesQueueidWrapupcodesPost");

            var localVarPath = "/api/v1/routing/queues/{queueId}/wrapupcodes";
=======
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> PostQueuesQueueIdWrapupcodesAsyncWithHttpInfo (string queueId, string codeId, List<WrapupCode> body = null)
        {
            // verify the required parameter 'queueId' is set
            if (queueId == null)
                throw new ApiException(400, "Missing required parameter 'queueId' when calling RoutingApi->PostQueuesQueueIdWrapupcodes");
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->PostQueuesQueueIdWrapupcodes");

            var localVarPath = "/api/v2/routing/queues/{queueId}/wrapupcodes";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidWrapupcodesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingQueuesQueueidWrapupcodesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesQueueIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostQueuesQueueIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Create Skill 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Skill (optional)</param>
        /// <returns>RoutingSkill</returns>
        public RoutingSkill PostSkills (RoutingSkill body = null)
        {
             ApiResponse<RoutingSkill> localVarResponse = PostSkillsWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Create Skill 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Skill (optional)</param>
        /// <returns>ApiResponse of RoutingSkill</returns>
        public ApiResponse< RoutingSkill > PostSkillsWithHttpInfo (RoutingSkill body = null)
        {

            var localVarPath = "/api/v2/routing/skills";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingSkillsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingSkillsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SkillEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SkillEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SkillEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostSkills: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSkills: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoutingSkill>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoutingSkill) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoutingSkill)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Create Skill 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Skill (optional)</param>
        /// <returns>Task of RoutingSkill</returns>
        public async System.Threading.Tasks.Task<RoutingSkill> PostSkillsAsync (RoutingSkill body = null)
        {
             ApiResponse<RoutingSkill> localVarResponse = await PostSkillsAsyncWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Create Skill 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Skill (optional)</param>
        /// <returns>Task of ApiResponse (RoutingSkill)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RoutingSkill>> PostSkillsAsyncWithHttpInfo (RoutingSkill body = null)
        {

            var localVarPath = "/api/v2/routing/skills";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingSkillsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingSkillsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SkillEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SkillEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SkillEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostSkills: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSkills: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoutingSkill>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoutingSkill) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoutingSkill)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete utilization settings and revert to system defaults. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>string</returns>
        public string RoutingUtilizationDelete ()
        {
             ApiResponse<string> localVarResponse = RoutingUtilizationDeleteWithHttpInfo();
=======
        /// Add routing skill to user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>UserRoutingSkill</returns>
        public UserRoutingSkill PostUserIdRoutingskills (string userId, UserRoutingSkill body = null)
        {
             ApiResponse<UserRoutingSkill> localVarResponse = PostUserIdRoutingskillsWithHttpInfo(userId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete utilization settings and revert to system defaults. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > RoutingUtilizationDeleteWithHttpInfo ()
        {

            var localVarPath = "/api/v1/routing/utilization";
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
=======
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingUtilizationDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingUtilizationDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostUserIdRoutingskills: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUserIdRoutingskills: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserRoutingSkill>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserRoutingSkill) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserRoutingSkill)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete utilization settings and revert to system defaults. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RoutingUtilizationDeleteAsync ()
        {
             ApiResponse<string> localVarResponse = await RoutingUtilizationDeleteAsyncWithHttpInfo();
=======
        /// Add routing skill to user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>Task of UserRoutingSkill</returns>
        public async System.Threading.Tasks.Task<UserRoutingSkill> PostUserIdRoutingskillsAsync (string userId, UserRoutingSkill body = null)
        {
             ApiResponse<UserRoutingSkill> localVarResponse = await PostUserIdRoutingskillsAsyncWithHttpInfo(userId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Delete utilization settings and revert to system defaults. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> RoutingUtilizationDeleteAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/routing/utilization";
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
=======
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingUtilizationDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingUtilizationDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostUserIdRoutingskills: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostUserIdRoutingskills: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserRoutingSkill>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserRoutingSkill) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserRoutingSkill)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Utilization</returns>
        public Utilization RoutingUtilizationGet ()
        {
             ApiResponse<Utilization> localVarResponse = RoutingUtilizationGetWithHttpInfo();
=======
        /// Create a wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>CallableTimeSet</returns>
        public CallableTimeSet PostWrapupcodes (WrapupCode body = null)
        {
             ApiResponse<CallableTimeSet> localVarResponse = PostWrapupcodesWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Get the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Utilization</returns>
        public ApiResponse< Utilization > RoutingUtilizationGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/routing/utilization";
=======
        /// Create a wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        public ApiResponse< CallableTimeSet > PostWrapupcodesWithHttpInfo (WrapupCode body = null)
        {

            var localVarPath = "/api/v2/routing/wrapupcodes";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingUtilizationGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingUtilizationGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Utilization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Utilization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Utilization)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSet)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Utilization</returns>
        public async System.Threading.Tasks.Task<Utilization> RoutingUtilizationGetAsync ()
        {
             ApiResponse<Utilization> localVarResponse = await RoutingUtilizationGetAsyncWithHttpInfo();
=======
        /// Create a wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>Task of CallableTimeSet</returns>
        public async System.Threading.Tasks.Task<CallableTimeSet> PostWrapupcodesAsync (WrapupCode body = null)
        {
             ApiResponse<CallableTimeSet> localVarResponse = await PostWrapupcodesAsyncWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Get the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Utilization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Utilization>> RoutingUtilizationGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/routing/utilization";
=======
        /// Create a wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> PostWrapupcodesAsyncWithHttpInfo (WrapupCode body = null)
        {

            var localVarPath = "/api/v2/routing/wrapupcodes";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingUtilizationGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingUtilizationGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Utilization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Utilization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Utilization)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSet)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Update the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">utilization (optional)</param>
        /// <returns>Utilization</returns>
        public Utilization RoutingUtilizationPut (Utilization body = null)
        {
             ApiResponse<Utilization> localVarResponse = RoutingUtilizationPutWithHttpInfo(body);
=======
        /// Update a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>InboundRoute</returns>
        public InboundRoute PutEmailDomainsDomainRoutesId (string domain, string id, InboundRoute body = null)
        {
             ApiResponse<InboundRoute> localVarResponse = PutEmailDomainsDomainRoutesIdWithHttpInfo(domain, id, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Update the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">utilization (optional)</param>
        /// <returns>ApiResponse of Utilization</returns>
        public ApiResponse< Utilization > RoutingUtilizationPutWithHttpInfo (Utilization body = null)
        {

            var localVarPath = "/api/v1/routing/utilization";
=======
        /// Update a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>ApiResponse of InboundRoute</returns>
        public ApiResponse< InboundRoute > PutEmailDomainsDomainRoutesIdWithHttpInfo (string domain, string id, InboundRoute body = null)
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingApi->PutEmailDomainsDomainRoutesId");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoutingApi->PutEmailDomainsDomainRoutesId");

            var localVarPath = "/api/v2/routing/email/domains/{domain}/routes/{id}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
=======
            if (domain != null) localVarPathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingUtilizationPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingUtilizationPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Utilization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Utilization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Utilization)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutEmailDomainsDomainRoutesId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutEmailDomainsDomainRoutesId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRoute)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Update the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">utilization (optional)</param>
        /// <returns>Task of Utilization</returns>
        public async System.Threading.Tasks.Task<Utilization> RoutingUtilizationPutAsync (Utilization body = null)
        {
             ApiResponse<Utilization> localVarResponse = await RoutingUtilizationPutAsyncWithHttpInfo(body);
=======
        /// Update a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>Task of InboundRoute</returns>
        public async System.Threading.Tasks.Task<InboundRoute> PutEmailDomainsDomainRoutesIdAsync (string domain, string id, InboundRoute body = null)
        {
             ApiResponse<InboundRoute> localVarResponse = await PutEmailDomainsDomainRoutesIdAsyncWithHttpInfo(domain, id, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Update the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">utilization (optional)</param>
        /// <returns>Task of ApiResponse (Utilization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Utilization>> RoutingUtilizationPutAsyncWithHttpInfo (Utilization body = null)
        {

            var localVarPath = "/api/v1/routing/utilization";
=======
        /// Update a route 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">email domain</param>
        /// <param name="id">route ID</param>
        /// <param name="body">Route (optional)</param>
        /// <returns>Task of ApiResponse (InboundRoute)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InboundRoute>> PutEmailDomainsDomainRoutesIdAsyncWithHttpInfo (string domain, string id, InboundRoute body = null)
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling RoutingApi->PutEmailDomainsDomainRoutesId");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoutingApi->PutEmailDomainsDomainRoutesId");

            var localVarPath = "/api/v2/routing/email/domains/{domain}/routes/{id}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
=======
            if (domain != null) localVarPathParams.Add("domain", Configuration.ApiClient.ParameterToString(domain)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingUtilizationPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingUtilizationPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Utilization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Utilization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Utilization)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutEmailDomainsDomainRoutesId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutEmailDomainsDomainRoutesId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InboundRoute>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InboundRoute) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InboundRoute)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>string</returns>
        public string RoutingWrapupcodesCodeidDelete (string codeId)
        {
             ApiResponse<string> localVarResponse = RoutingWrapupcodesCodeidDeleteWithHttpInfo(codeId);
=======
        /// Update a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Queue</returns>
        public Queue PutQueuesQueueId (string queueId, Queue body = null)
        {
             ApiResponse<Queue> localVarResponse = PutQueuesQueueIdWithHttpInfo(queueId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (codeId != null) localVarPathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
=======
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesCodeidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesCodeidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutQueuesQueueId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutQueuesQueueId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Queue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Queue)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RoutingWrapupcodesCodeidDeleteAsync (string codeId)
        {
             ApiResponse<string> localVarResponse = await RoutingWrapupcodesCodeidDeleteAsyncWithHttpInfo(codeId);
=======
        /// Update a queue 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queueId">Queue ID</param>
        /// <param name="body">Queue (optional)</param>
        /// <returns>Task of Queue</returns>
        public async System.Threading.Tasks.Task<Queue> PutQueuesQueueIdAsync (string queueId, Queue body = null)
        {
             ApiResponse<Queue> localVarResponse = await PutQueuesQueueIdAsyncWithHttpInfo(queueId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (codeId != null) localVarPathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
=======
            if (queueId != null) localVarPathParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesCodeidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesCodeidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutQueuesQueueId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutQueuesQueueId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Queue>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Queue) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Queue)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Update Routing Skill 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>WrapupCode</returns>
        public WrapupCode RoutingWrapupcodesCodeidGet (string codeId)
        {
             ApiResponse<WrapupCode> localVarResponse = RoutingWrapupcodesCodeidGetWithHttpInfo(codeId);
=======
        /// <param name="skillId">Skill ID</param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>RoutingSkill</returns>
        public RoutingSkill PutSkillsSkillId (string skillId, RoutingSkill body = null)
        {
             ApiResponse<RoutingSkill> localVarResponse = PutSkillsSkillIdWithHttpInfo(skillId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Routing Skill 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > RoutingWrapupcodesCodeidGetWithHttpInfo (string codeId)
        {
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->RoutingWrapupcodesCodeidGet");

            var localVarPath = "/api/v1/routing/wrapupcodes/{codeId}";
=======
        /// <param name="skillId">Skill ID</param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>ApiResponse of RoutingSkill</returns>
        public ApiResponse< RoutingSkill > PutSkillsSkillIdWithHttpInfo (string skillId, RoutingSkill body = null)
        {
            // verify the required parameter 'skillId' is set
            if (skillId == null)
                throw new ApiException(400, "Missing required parameter 'skillId' when calling RoutingApi->PutSkillsSkillId");

            var localVarPath = "/api/v2/routing/skills/{skillId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (codeId != null) localVarPathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
=======
            if (skillId != null) localVarPathParams.Add("skillId", Configuration.ApiClient.ParameterToString(skillId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesCodeidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesCodeidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutSkillsSkillId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSkillsSkillId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoutingSkill>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoutingSkill) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoutingSkill)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Update Routing Skill 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> RoutingWrapupcodesCodeidGetAsync (string codeId)
        {
             ApiResponse<WrapupCode> localVarResponse = await RoutingWrapupcodesCodeidGetAsyncWithHttpInfo(codeId);
=======
        /// <param name="skillId">Skill ID</param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>Task of RoutingSkill</returns>
        public async System.Threading.Tasks.Task<RoutingSkill> PutSkillsSkillIdAsync (string skillId, RoutingSkill body = null)
        {
             ApiResponse<RoutingSkill> localVarResponse = await PutSkillsSkillIdAsyncWithHttpInfo(skillId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Routing Skill 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="codeId">Wrapup Code ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> RoutingWrapupcodesCodeidGetAsyncWithHttpInfo (string codeId)
        {
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->RoutingWrapupcodesCodeidGet");

            var localVarPath = "/api/v1/routing/wrapupcodes/{codeId}";
=======
        /// <param name="skillId">Skill ID</param>
        /// <param name="body">Skill (optional)</param>
        /// <returns>Task of ApiResponse (RoutingSkill)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RoutingSkill>> PutSkillsSkillIdAsyncWithHttpInfo (string skillId, RoutingSkill body = null)
        {
            // verify the required parameter 'skillId' is set
            if (skillId == null)
                throw new ApiException(400, "Missing required parameter 'skillId' when calling RoutingApi->PutSkillsSkillId");

            var localVarPath = "/api/v2/routing/skills/{skillId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (codeId != null) localVarPathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
=======
            if (skillId != null) localVarPathParams.Add("skillId", Configuration.ApiClient.ParameterToString(skillId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesCodeidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesCodeidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutSkillsSkillId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSkillsSkillId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RoutingSkill>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RoutingSkill) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoutingSkill)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Update the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>WrapupCode</returns>
        public WrapupCode RoutingWrapupcodesCodeidPut (string codeId, WrapupCode body = null)
        {
             ApiResponse<WrapupCode> localVarResponse = RoutingWrapupcodesCodeidPutWithHttpInfo(codeId, body);
=======
        /// <param name="body">utilization (optional)</param>
        /// <returns>Utilization</returns>
        public Utilization PutUtilization (Utilization body = null)
        {
             ApiResponse<Utilization> localVarResponse = PutUtilizationWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > RoutingWrapupcodesCodeidPutWithHttpInfo (string codeId, WrapupCode body = null)
        {
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->RoutingWrapupcodesCodeidPut");

            var localVarPath = "/api/v1/routing/wrapupcodes/{codeId}";
=======
        /// <param name="body">utilization (optional)</param>
        /// <returns>ApiResponse of Utilization</returns>
        public ApiResponse< Utilization > PutUtilizationWithHttpInfo (Utilization body = null)
        {

            var localVarPath = "/api/v2/routing/utilization";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (codeId != null) localVarPathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesCodeidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesCodeidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutUtilization: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUtilization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Utilization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Utilization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Utilization)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Update the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> RoutingWrapupcodesCodeidPutAsync (string codeId, WrapupCode body = null)
        {
             ApiResponse<WrapupCode> localVarResponse = await RoutingWrapupcodesCodeidPutAsyncWithHttpInfo(codeId, body);
=======
        /// <param name="body">utilization (optional)</param>
        /// <returns>Task of Utilization</returns>
        public async System.Threading.Tasks.Task<Utilization> PutUtilizationAsync (Utilization body = null)
        {
             ApiResponse<Utilization> localVarResponse = await PutUtilizationAsyncWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the utilization settings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> RoutingWrapupcodesCodeidPutAsyncWithHttpInfo (string codeId, WrapupCode body = null)
        {
            // verify the required parameter 'codeId' is set
            if (codeId == null)
                throw new ApiException(400, "Missing required parameter 'codeId' when calling RoutingApi->RoutingWrapupcodesCodeidPut");

            var localVarPath = "/api/v1/routing/wrapupcodes/{codeId}";
=======
        /// <param name="body">utilization (optional)</param>
        /// <returns>Task of ApiResponse (Utilization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Utilization>> PutUtilizationAsyncWithHttpInfo (Utilization body = null)
        {

            var localVarPath = "/api/v2/routing/utilization";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (codeId != null) localVarPathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesCodeidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesCodeidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutUtilization: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutUtilization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Utilization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Utilization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Utilization)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Update wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>WrapupCode</returns>
        public WrapupCode PutWrapupcodesCodeId (string codeId, WrapupCode body = null)
        {
             ApiResponse<WrapupCode> localVarResponse = PutWrapupcodesCodeIdWithHttpInfo(codeId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
=======
            if (codeId != null) localVarPathParams.Add("codeId", Configuration.ApiClient.ParameterToString(codeId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCodeEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCodeEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCodeEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutWrapupcodesCodeId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWrapupcodesCodeId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Update wrap-up code 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codeId">Wrapup Code ID</param>
        /// <param name="body">WrapupCode (optional)</param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> PutWrapupcodesCodeIdAsync (string codeId, WrapupCode body = null)
        {
             ApiResponse<WrapupCode> localVarResponse = await PutWrapupcodesCodeIdAsyncWithHttpInfo(codeId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
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
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
<<<<<<< HEAD

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
=======

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RoutingWrapupcodesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSet)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutWrapupcodesCodeId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWrapupcodesCodeId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

    }
}
