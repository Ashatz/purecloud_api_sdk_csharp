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
    public interface ISocializeApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Get all published expressions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>DomainEntityListing</returns>
        DomainEntityListing SocializeExpressionsPublishedGet (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get all published expressions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        ApiResponse<DomainEntityListing> SocializeExpressionsPublishedGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Create published expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PublishedExpression (optional)</param>
        /// <returns>PublishedExpression</returns>
        PublishedExpression SocializeExpressionsPublishedPost (PublishedExpression body = null);

        /// <summary>
        /// Create published expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PublishedExpression (optional)</param>
        /// <returns>ApiResponse of PublishedExpression</returns>
        ApiResponse<PublishedExpression> SocializeExpressionsPublishedPostWithHttpInfo (PublishedExpression body = null);
        /// <summary>
        /// Delete published expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>string</returns>
        string SocializeExpressionsPublishedPublishedexpressionidDelete (string publishedExpressionId);

        /// <summary>
        /// Delete published expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> SocializeExpressionsPublishedPublishedexpressionidDeleteWithHttpInfo (string publishedExpressionId);
        /// <summary>
        /// Get published expression
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>PublishedExpression</returns>
        PublishedExpression SocializeExpressionsPublishedPublishedexpressionidGet (string publishedExpressionId);

        /// <summary>
        /// Get published expression
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>ApiResponse of PublishedExpression</returns>
        ApiResponse<PublishedExpression> SocializeExpressionsPublishedPublishedexpressionidGetWithHttpInfo (string publishedExpressionId);
        /// <summary>
        /// Update published expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <param name="body">PublishedExpression (optional)</param>
        /// <returns>PublishedExpression</returns>
        PublishedExpression SocializeExpressionsPublishedPublishedexpressionidPut (string publishedExpressionId, PublishedExpression body = null);

        /// <summary>
        /// Update published expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <param name="body">PublishedExpression (optional)</param>
        /// <returns>ApiResponse of PublishedExpression</returns>
        ApiResponse<PublishedExpression> SocializeExpressionsPublishedPublishedexpressionidPutWithHttpInfo (string publishedExpressionId, PublishedExpression body = null);
        /// <summary>
        /// Delete TwitterExpression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>string</returns>
        string SocializeExpressionsTwitterExpressionidDelete (string expressionId);

        /// <summary>
        /// Delete TwitterExpression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> SocializeExpressionsTwitterExpressionidDeleteWithHttpInfo (string expressionId);
        /// <summary>
        /// Get TwitterExpression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>TwitterExpression</returns>
        TwitterExpression SocializeExpressionsTwitterExpressionidGet (string expressionId);

        /// <summary>
        /// Get TwitterExpression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>ApiResponse of TwitterExpression</returns>
        ApiResponse<TwitterExpression> SocializeExpressionsTwitterExpressionidGetWithHttpInfo (string expressionId);
        /// <summary>
        /// Update TwitterExpression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <param name="body">TwitterExpression (optional)</param>
        /// <returns>TwitterExpression</returns>
        TwitterExpression SocializeExpressionsTwitterExpressionidPut (string expressionId, TwitterExpression body = null);

        /// <summary>
        /// Update TwitterExpression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <param name="body">TwitterExpression (optional)</param>
        /// <returns>ApiResponse of TwitterExpression</returns>
        ApiResponse<TwitterExpression> SocializeExpressionsTwitterExpressionidPutWithHttpInfo (string expressionId, TwitterExpression body = null);
        /// <summary>
        /// Get all configured expressions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>DomainEntityListing</returns>
        DomainEntityListing SocializeExpressionsTwitterGet (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get all configured expressions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        ApiResponse<DomainEntityListing> SocializeExpressionsTwitterGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Create twitter expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">TwitterExpression (optional)</param>
        /// <returns>TwitterExpression</returns>
        TwitterExpression SocializeExpressionsTwitterPost (TwitterExpression body = null);

        /// <summary>
        /// Create twitter expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">TwitterExpression (optional)</param>
        /// <returns>ApiResponse of TwitterExpression</returns>
        ApiResponse<TwitterExpression> SocializeExpressionsTwitterPostWithHttpInfo (TwitterExpression body = null);
        /// <summary>
        /// Get all configured gisteners.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="enabled">Enabled Only (optional, default to false)</param>
        /// <returns>DomainEntityListing</returns>
        DomainEntityListing SocializeGistenersGet (int? pageSize = null, int? pageNumber = null, bool? enabled = null);

        /// <summary>
        /// Get all configured gisteners.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="enabled">Enabled Only (optional, default to false)</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        ApiResponse<DomainEntityListing> SocializeGistenersGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, bool? enabled = null);
        /// <summary>
        /// Delete gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>string</returns>
        string SocializeGistenersGisteneridDelete (string gistenerId);

        /// <summary>
        /// Delete gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> SocializeGistenersGisteneridDeleteWithHttpInfo (string gistenerId);
        /// <summary>
        /// Get gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>Gistener</returns>
        Gistener SocializeGistenersGisteneridGet (string gistenerId);

        /// <summary>
        /// Get gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>ApiResponse of Gistener</returns>
        ApiResponse<Gistener> SocializeGistenersGisteneridGetWithHttpInfo (string gistenerId);
        /// <summary>
        /// Update gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gistenerId">Gistener ID</param>
        /// <param name="body">Gistener (optional)</param>
        /// <returns>Gistener</returns>
        Gistener SocializeGistenersGisteneridPut (string gistenerId, Gistener body = null);

        /// <summary>
        /// Update gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gistenerId">Gistener ID</param>
        /// <param name="body">Gistener (optional)</param>
        /// <returns>ApiResponse of Gistener</returns>
        ApiResponse<Gistener> SocializeGistenersGisteneridPutWithHttpInfo (string gistenerId, Gistener body = null);
        /// <summary>
        /// Create gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Gistener (optional)</param>
        /// <param name="preview">Preview Only (optional, default to false)</param>
        /// <returns>Gistener</returns>
        Gistener SocializeGistenersPost (Gistener body = null, bool? preview = null);

        /// <summary>
        /// Create gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Gistener (optional)</param>
        /// <param name="preview">Preview Only (optional, default to false)</param>
        /// <returns>ApiResponse of Gistener</returns>
        ApiResponse<Gistener> SocializeGistenersPostWithHttpInfo (Gistener body = null, bool? preview = null);
        /// <summary>
        /// Get all configured groupTags.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="enabled">Enabled Only (optional, default to false)</param>
        /// <returns>DomainEntityListing</returns>
        DomainEntityListing SocializeGrouptagsGet (int? pageSize = null, int? pageNumber = null, bool? enabled = null);

        /// <summary>
        /// Get all configured groupTags.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="enabled">Enabled Only (optional, default to false)</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        ApiResponse<DomainEntityListing> SocializeGrouptagsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, bool? enabled = null);
        /// <summary>
        /// Delete grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>string</returns>
        string SocializeGrouptagsGrouptagidDelete (string groupTagId);

        /// <summary>
        /// Delete grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> SocializeGrouptagsGrouptagidDeleteWithHttpInfo (string groupTagId);
        /// <summary>
        /// Get grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>GroupTag</returns>
        GroupTag SocializeGrouptagsGrouptagidGet (string groupTagId);

        /// <summary>
        /// Get grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>ApiResponse of GroupTag</returns>
        ApiResponse<GroupTag> SocializeGrouptagsGrouptagidGetWithHttpInfo (string groupTagId);
        /// <summary>
        /// Update grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupTagId">grouptag ID</param>
        /// <param name="body">grouptag (optional)</param>
        /// <returns>Gistener</returns>
        Gistener SocializeGrouptagsGrouptagidPut (string groupTagId, GroupTag body = null);

        /// <summary>
        /// Update grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupTagId">grouptag ID</param>
        /// <param name="body">grouptag (optional)</param>
        /// <returns>ApiResponse of Gistener</returns>
        ApiResponse<Gistener> SocializeGrouptagsGrouptagidPutWithHttpInfo (string groupTagId, GroupTag body = null);
        /// <summary>
        /// Create grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">grouptag (optional)</param>
        /// <returns>GroupTag</returns>
        GroupTag SocializeGrouptagsPost (GroupTag body = null);

        /// <summary>
        /// Create grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">grouptag (optional)</param>
        /// <returns>ApiResponse of GroupTag</returns>
        ApiResponse<GroupTag> SocializeGrouptagsPostWithHttpInfo (GroupTag body = null);
        /// <summary>
        /// Get all configured publications.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>DomainEntityListing</returns>
        DomainEntityListing SocializePublicationsGet (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get all configured publications.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        ApiResponse<DomainEntityListing> SocializePublicationsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Create publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Publication (optional)</param>
        /// <returns>Publication</returns>
        Publication SocializePublicationsPost (Publication body = null);

        /// <summary>
        /// Create publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Publication (optional)</param>
        /// <returns>ApiResponse of Publication</returns>
        ApiResponse<Publication> SocializePublicationsPostWithHttpInfo (Publication body = null);
        /// <summary>
        /// Delete publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>string</returns>
        string SocializePublicationsPublicationidDelete (string publicationId);

        /// <summary>
        /// Delete publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> SocializePublicationsPublicationidDeleteWithHttpInfo (string publicationId);
        /// <summary>
        /// Get publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>Publication</returns>
        Publication SocializePublicationsPublicationidGet (string publicationId);

        /// <summary>
        /// Get publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>ApiResponse of Publication</returns>
        ApiResponse<Publication> SocializePublicationsPublicationidGetWithHttpInfo (string publicationId);
        /// <summary>
        /// Update publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicationId">Publication ID</param>
        /// <param name="body">Publication (optional)</param>
        /// <returns>Gistener</returns>
        Gistener SocializePublicationsPublicationidPut (string publicationId, Publication body = null);

        /// <summary>
        /// Update publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicationId">Publication ID</param>
        /// <param name="body">Publication (optional)</param>
        /// <returns>ApiResponse of Gistener</returns>
        ApiResponse<Gistener> SocializePublicationsPublicationidPutWithHttpInfo (string publicationId, Publication body = null);
        /// <summary>
        /// Get all social accounts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="enabled">Enabled Only (optional, default to false)</param>
        /// <returns>DomainEntityListing</returns>
        DomainEntityListing SocializeSocialaccountsGet (int? pageSize = null, int? pageNumber = null, bool? enabled = null);

        /// <summary>
        /// Get all social accounts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="enabled">Enabled Only (optional, default to false)</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        ApiResponse<DomainEntityListing> SocializeSocialaccountsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, bool? enabled = null);
        /// <summary>
        /// Create social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SocialAccount (optional)</param>
        /// <returns>SocialAccount</returns>
        SocialAccount SocializeSocialaccountsPost (SocialAccount body = null);

        /// <summary>
        /// Create social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SocialAccount (optional)</param>
        /// <returns>ApiResponse of SocialAccount</returns>
        ApiResponse<SocialAccount> SocializeSocialaccountsPostWithHttpInfo (SocialAccount body = null);
        /// <summary>
        /// Delete social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>string</returns>
        string SocializeSocialaccountsSocialaccountidDelete (string socialAccountId, bool? enabled);

        /// <summary>
        /// Delete social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> SocializeSocialaccountsSocialaccountidDeleteWithHttpInfo (string socialAccountId, bool? enabled);
        /// <summary>
        /// Get social account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>SocialAccount</returns>
        SocialAccount SocializeSocialaccountsSocialaccountidGet (string socialAccountId, bool? enabled);

        /// <summary>
        /// Get social account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>ApiResponse of SocialAccount</returns>
        ApiResponse<SocialAccount> SocializeSocialaccountsSocialaccountidGetWithHttpInfo (string socialAccountId, bool? enabled);
        /// <summary>
        /// Enabled/Disable feed for social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>bool?</returns>
        bool? SocializeSocialaccountsSocialaccountidPatch (string socialAccountId, bool? enabled);

        /// <summary>
        /// Enabled/Disable feed for social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>ApiResponse of bool?</returns>
        ApiResponse<bool?> SocializeSocialaccountsSocialaccountidPatchWithHttpInfo (string socialAccountId, bool? enabled);
        /// <summary>
        /// Update social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <param name="body">SocialAccount (optional)</param>
        /// <returns>SocialAccount</returns>
        SocialAccount SocializeSocialaccountsSocialaccountidPut (string socialAccountId, bool? enabled, SocialAccount body = null);

        /// <summary>
        /// Update social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <param name="body">SocialAccount (optional)</param>
        /// <returns>ApiResponse of SocialAccount</returns>
        ApiResponse<SocialAccount> SocializeSocialaccountsSocialaccountidPutWithHttpInfo (string socialAccountId, bool? enabled, SocialAccount body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get all published expressions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of DomainEntityListing</returns>
        System.Threading.Tasks.Task<DomainEntityListing> SocializeExpressionsPublishedGetAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get all published expressions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> SocializeExpressionsPublishedGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Create published expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PublishedExpression (optional)</param>
        /// <returns>Task of PublishedExpression</returns>
        System.Threading.Tasks.Task<PublishedExpression> SocializeExpressionsPublishedPostAsync (PublishedExpression body = null);

        /// <summary>
        /// Create published expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PublishedExpression (optional)</param>
        /// <returns>Task of ApiResponse (PublishedExpression)</returns>
        System.Threading.Tasks.Task<ApiResponse<PublishedExpression>> SocializeExpressionsPublishedPostAsyncWithHttpInfo (PublishedExpression body = null);
        /// <summary>
        /// Delete published expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> SocializeExpressionsPublishedPublishedexpressionidDeleteAsync (string publishedExpressionId);

        /// <summary>
        /// Delete published expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> SocializeExpressionsPublishedPublishedexpressionidDeleteAsyncWithHttpInfo (string publishedExpressionId);
        /// <summary>
        /// Get published expression
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>Task of PublishedExpression</returns>
        System.Threading.Tasks.Task<PublishedExpression> SocializeExpressionsPublishedPublishedexpressionidGetAsync (string publishedExpressionId);

        /// <summary>
        /// Get published expression
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>Task of ApiResponse (PublishedExpression)</returns>
        System.Threading.Tasks.Task<ApiResponse<PublishedExpression>> SocializeExpressionsPublishedPublishedexpressionidGetAsyncWithHttpInfo (string publishedExpressionId);
        /// <summary>
        /// Update published expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <param name="body">PublishedExpression (optional)</param>
        /// <returns>Task of PublishedExpression</returns>
        System.Threading.Tasks.Task<PublishedExpression> SocializeExpressionsPublishedPublishedexpressionidPutAsync (string publishedExpressionId, PublishedExpression body = null);

        /// <summary>
        /// Update published expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <param name="body">PublishedExpression (optional)</param>
        /// <returns>Task of ApiResponse (PublishedExpression)</returns>
        System.Threading.Tasks.Task<ApiResponse<PublishedExpression>> SocializeExpressionsPublishedPublishedexpressionidPutAsyncWithHttpInfo (string publishedExpressionId, PublishedExpression body = null);
        /// <summary>
        /// Delete TwitterExpression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> SocializeExpressionsTwitterExpressionidDeleteAsync (string expressionId);

        /// <summary>
        /// Delete TwitterExpression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> SocializeExpressionsTwitterExpressionidDeleteAsyncWithHttpInfo (string expressionId);
        /// <summary>
        /// Get TwitterExpression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>Task of TwitterExpression</returns>
        System.Threading.Tasks.Task<TwitterExpression> SocializeExpressionsTwitterExpressionidGetAsync (string expressionId);

        /// <summary>
        /// Get TwitterExpression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>Task of ApiResponse (TwitterExpression)</returns>
        System.Threading.Tasks.Task<ApiResponse<TwitterExpression>> SocializeExpressionsTwitterExpressionidGetAsyncWithHttpInfo (string expressionId);
        /// <summary>
        /// Update TwitterExpression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <param name="body">TwitterExpression (optional)</param>
        /// <returns>Task of TwitterExpression</returns>
        System.Threading.Tasks.Task<TwitterExpression> SocializeExpressionsTwitterExpressionidPutAsync (string expressionId, TwitterExpression body = null);

        /// <summary>
        /// Update TwitterExpression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <param name="body">TwitterExpression (optional)</param>
        /// <returns>Task of ApiResponse (TwitterExpression)</returns>
        System.Threading.Tasks.Task<ApiResponse<TwitterExpression>> SocializeExpressionsTwitterExpressionidPutAsyncWithHttpInfo (string expressionId, TwitterExpression body = null);
        /// <summary>
        /// Get all configured expressions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of DomainEntityListing</returns>
        System.Threading.Tasks.Task<DomainEntityListing> SocializeExpressionsTwitterGetAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get all configured expressions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> SocializeExpressionsTwitterGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Create twitter expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">TwitterExpression (optional)</param>
        /// <returns>Task of TwitterExpression</returns>
        System.Threading.Tasks.Task<TwitterExpression> SocializeExpressionsTwitterPostAsync (TwitterExpression body = null);

        /// <summary>
        /// Create twitter expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">TwitterExpression (optional)</param>
        /// <returns>Task of ApiResponse (TwitterExpression)</returns>
        System.Threading.Tasks.Task<ApiResponse<TwitterExpression>> SocializeExpressionsTwitterPostAsyncWithHttpInfo (TwitterExpression body = null);
        /// <summary>
        /// Get all configured gisteners.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="enabled">Enabled Only (optional, default to false)</param>
        /// <returns>Task of DomainEntityListing</returns>
        System.Threading.Tasks.Task<DomainEntityListing> SocializeGistenersGetAsync (int? pageSize = null, int? pageNumber = null, bool? enabled = null);

        /// <summary>
        /// Get all configured gisteners.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="enabled">Enabled Only (optional, default to false)</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> SocializeGistenersGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, bool? enabled = null);
        /// <summary>
        /// Delete gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> SocializeGistenersGisteneridDeleteAsync (string gistenerId);

        /// <summary>
        /// Delete gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> SocializeGistenersGisteneridDeleteAsyncWithHttpInfo (string gistenerId);
        /// <summary>
        /// Get gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>Task of Gistener</returns>
        System.Threading.Tasks.Task<Gistener> SocializeGistenersGisteneridGetAsync (string gistenerId);

        /// <summary>
        /// Get gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>Task of ApiResponse (Gistener)</returns>
        System.Threading.Tasks.Task<ApiResponse<Gistener>> SocializeGistenersGisteneridGetAsyncWithHttpInfo (string gistenerId);
        /// <summary>
        /// Update gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gistenerId">Gistener ID</param>
        /// <param name="body">Gistener (optional)</param>
        /// <returns>Task of Gistener</returns>
        System.Threading.Tasks.Task<Gistener> SocializeGistenersGisteneridPutAsync (string gistenerId, Gistener body = null);

        /// <summary>
        /// Update gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gistenerId">Gistener ID</param>
        /// <param name="body">Gistener (optional)</param>
        /// <returns>Task of ApiResponse (Gistener)</returns>
        System.Threading.Tasks.Task<ApiResponse<Gistener>> SocializeGistenersGisteneridPutAsyncWithHttpInfo (string gistenerId, Gistener body = null);
        /// <summary>
        /// Create gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Gistener (optional)</param>
        /// <param name="preview">Preview Only (optional, default to false)</param>
        /// <returns>Task of Gistener</returns>
        System.Threading.Tasks.Task<Gistener> SocializeGistenersPostAsync (Gistener body = null, bool? preview = null);

        /// <summary>
        /// Create gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Gistener (optional)</param>
        /// <param name="preview">Preview Only (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Gistener)</returns>
        System.Threading.Tasks.Task<ApiResponse<Gistener>> SocializeGistenersPostAsyncWithHttpInfo (Gistener body = null, bool? preview = null);
        /// <summary>
        /// Get all configured groupTags.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="enabled">Enabled Only (optional, default to false)</param>
        /// <returns>Task of DomainEntityListing</returns>
        System.Threading.Tasks.Task<DomainEntityListing> SocializeGrouptagsGetAsync (int? pageSize = null, int? pageNumber = null, bool? enabled = null);

        /// <summary>
        /// Get all configured groupTags.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="enabled">Enabled Only (optional, default to false)</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> SocializeGrouptagsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, bool? enabled = null);
        /// <summary>
        /// Delete grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> SocializeGrouptagsGrouptagidDeleteAsync (string groupTagId);

        /// <summary>
        /// Delete grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> SocializeGrouptagsGrouptagidDeleteAsyncWithHttpInfo (string groupTagId);
        /// <summary>
        /// Get grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>Task of GroupTag</returns>
        System.Threading.Tasks.Task<GroupTag> SocializeGrouptagsGrouptagidGetAsync (string groupTagId);

        /// <summary>
        /// Get grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>Task of ApiResponse (GroupTag)</returns>
        System.Threading.Tasks.Task<ApiResponse<GroupTag>> SocializeGrouptagsGrouptagidGetAsyncWithHttpInfo (string groupTagId);
        /// <summary>
        /// Update grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupTagId">grouptag ID</param>
        /// <param name="body">grouptag (optional)</param>
        /// <returns>Task of Gistener</returns>
        System.Threading.Tasks.Task<Gistener> SocializeGrouptagsGrouptagidPutAsync (string groupTagId, GroupTag body = null);

        /// <summary>
        /// Update grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupTagId">grouptag ID</param>
        /// <param name="body">grouptag (optional)</param>
        /// <returns>Task of ApiResponse (Gistener)</returns>
        System.Threading.Tasks.Task<ApiResponse<Gistener>> SocializeGrouptagsGrouptagidPutAsyncWithHttpInfo (string groupTagId, GroupTag body = null);
        /// <summary>
        /// Create grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">grouptag (optional)</param>
        /// <returns>Task of GroupTag</returns>
        System.Threading.Tasks.Task<GroupTag> SocializeGrouptagsPostAsync (GroupTag body = null);

        /// <summary>
        /// Create grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">grouptag (optional)</param>
        /// <returns>Task of ApiResponse (GroupTag)</returns>
        System.Threading.Tasks.Task<ApiResponse<GroupTag>> SocializeGrouptagsPostAsyncWithHttpInfo (GroupTag body = null);
        /// <summary>
        /// Get all configured publications.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of DomainEntityListing</returns>
        System.Threading.Tasks.Task<DomainEntityListing> SocializePublicationsGetAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get all configured publications.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> SocializePublicationsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Create publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Publication (optional)</param>
        /// <returns>Task of Publication</returns>
        System.Threading.Tasks.Task<Publication> SocializePublicationsPostAsync (Publication body = null);

        /// <summary>
        /// Create publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Publication (optional)</param>
        /// <returns>Task of ApiResponse (Publication)</returns>
        System.Threading.Tasks.Task<ApiResponse<Publication>> SocializePublicationsPostAsyncWithHttpInfo (Publication body = null);
        /// <summary>
        /// Delete publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> SocializePublicationsPublicationidDeleteAsync (string publicationId);

        /// <summary>
        /// Delete publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> SocializePublicationsPublicationidDeleteAsyncWithHttpInfo (string publicationId);
        /// <summary>
        /// Get publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>Task of Publication</returns>
        System.Threading.Tasks.Task<Publication> SocializePublicationsPublicationidGetAsync (string publicationId);

        /// <summary>
        /// Get publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>Task of ApiResponse (Publication)</returns>
        System.Threading.Tasks.Task<ApiResponse<Publication>> SocializePublicationsPublicationidGetAsyncWithHttpInfo (string publicationId);
        /// <summary>
        /// Update publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicationId">Publication ID</param>
        /// <param name="body">Publication (optional)</param>
        /// <returns>Task of Gistener</returns>
        System.Threading.Tasks.Task<Gistener> SocializePublicationsPublicationidPutAsync (string publicationId, Publication body = null);

        /// <summary>
        /// Update publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicationId">Publication ID</param>
        /// <param name="body">Publication (optional)</param>
        /// <returns>Task of ApiResponse (Gistener)</returns>
        System.Threading.Tasks.Task<ApiResponse<Gistener>> SocializePublicationsPublicationidPutAsyncWithHttpInfo (string publicationId, Publication body = null);
        /// <summary>
        /// Get all social accounts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="enabled">Enabled Only (optional, default to false)</param>
        /// <returns>Task of DomainEntityListing</returns>
        System.Threading.Tasks.Task<DomainEntityListing> SocializeSocialaccountsGetAsync (int? pageSize = null, int? pageNumber = null, bool? enabled = null);

        /// <summary>
        /// Get all social accounts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="enabled">Enabled Only (optional, default to false)</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> SocializeSocialaccountsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, bool? enabled = null);
        /// <summary>
        /// Create social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SocialAccount (optional)</param>
        /// <returns>Task of SocialAccount</returns>
        System.Threading.Tasks.Task<SocialAccount> SocializeSocialaccountsPostAsync (SocialAccount body = null);

        /// <summary>
        /// Create social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SocialAccount (optional)</param>
        /// <returns>Task of ApiResponse (SocialAccount)</returns>
        System.Threading.Tasks.Task<ApiResponse<SocialAccount>> SocializeSocialaccountsPostAsyncWithHttpInfo (SocialAccount body = null);
        /// <summary>
        /// Delete social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> SocializeSocialaccountsSocialaccountidDeleteAsync (string socialAccountId, bool? enabled);

        /// <summary>
        /// Delete social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> SocializeSocialaccountsSocialaccountidDeleteAsyncWithHttpInfo (string socialAccountId, bool? enabled);
        /// <summary>
        /// Get social account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>Task of SocialAccount</returns>
        System.Threading.Tasks.Task<SocialAccount> SocializeSocialaccountsSocialaccountidGetAsync (string socialAccountId, bool? enabled);

        /// <summary>
        /// Get social account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>Task of ApiResponse (SocialAccount)</returns>
        System.Threading.Tasks.Task<ApiResponse<SocialAccount>> SocializeSocialaccountsSocialaccountidGetAsyncWithHttpInfo (string socialAccountId, bool? enabled);
        /// <summary>
        /// Enabled/Disable feed for social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>Task of bool?</returns>
        System.Threading.Tasks.Task<bool?> SocializeSocialaccountsSocialaccountidPatchAsync (string socialAccountId, bool? enabled);

        /// <summary>
        /// Enabled/Disable feed for social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>Task of ApiResponse (bool?)</returns>
        System.Threading.Tasks.Task<ApiResponse<bool?>> SocializeSocialaccountsSocialaccountidPatchAsyncWithHttpInfo (string socialAccountId, bool? enabled);
        /// <summary>
        /// Update social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <param name="body">SocialAccount (optional)</param>
        /// <returns>Task of SocialAccount</returns>
        System.Threading.Tasks.Task<SocialAccount> SocializeSocialaccountsSocialaccountidPutAsync (string socialAccountId, bool? enabled, SocialAccount body = null);

        /// <summary>
        /// Update social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <param name="body">SocialAccount (optional)</param>
        /// <returns>Task of ApiResponse (SocialAccount)</returns>
        System.Threading.Tasks.Task<ApiResponse<SocialAccount>> SocializeSocialaccountsSocialaccountidPutAsyncWithHttpInfo (string socialAccountId, bool? enabled, SocialAccount body = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SocializeApi : ISocializeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SocializeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SocializeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SocializeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SocializeApi(Configuration configuration = null)
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
        /// Get all published expressions. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>DomainEntityListing</returns>
        public DomainEntityListing SocializeExpressionsPublishedGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> localVarResponse = SocializeExpressionsPublishedGetWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all published expressions. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        public ApiResponse< DomainEntityListing > SocializeExpressionsPublishedGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/socialize/expressions/published";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsPublishedGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsPublishedGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEntityListing)));
            
        }

        /// <summary>
        /// Get all published expressions. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of DomainEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainEntityListing> SocializeExpressionsPublishedGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> localVarResponse = await SocializeExpressionsPublishedGetAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all published expressions. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> SocializeExpressionsPublishedGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/socialize/expressions/published";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsPublishedGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsPublishedGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEntityListing)));
            
        }

        /// <summary>
        /// Create published expression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PublishedExpression (optional)</param>
        /// <returns>PublishedExpression</returns>
        public PublishedExpression SocializeExpressionsPublishedPost (PublishedExpression body = null)
        {
             ApiResponse<PublishedExpression> localVarResponse = SocializeExpressionsPublishedPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create published expression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PublishedExpression (optional)</param>
        /// <returns>ApiResponse of PublishedExpression</returns>
        public ApiResponse< PublishedExpression > SocializeExpressionsPublishedPostWithHttpInfo (PublishedExpression body = null)
        {

            var localVarPath = "/api/v1/socialize/expressions/published";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsPublishedPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsPublishedPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PublishedExpression>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PublishedExpression) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PublishedExpression)));
            
        }

        /// <summary>
        /// Create published expression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PublishedExpression (optional)</param>
        /// <returns>Task of PublishedExpression</returns>
        public async System.Threading.Tasks.Task<PublishedExpression> SocializeExpressionsPublishedPostAsync (PublishedExpression body = null)
        {
             ApiResponse<PublishedExpression> localVarResponse = await SocializeExpressionsPublishedPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create published expression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PublishedExpression (optional)</param>
        /// <returns>Task of ApiResponse (PublishedExpression)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PublishedExpression>> SocializeExpressionsPublishedPostAsyncWithHttpInfo (PublishedExpression body = null)
        {

            var localVarPath = "/api/v1/socialize/expressions/published";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsPublishedPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsPublishedPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PublishedExpression>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PublishedExpression) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PublishedExpression)));
            
        }

        /// <summary>
        /// Delete published expression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>string</returns>
        public string SocializeExpressionsPublishedPublishedexpressionidDelete (string publishedExpressionId)
        {
             ApiResponse<string> localVarResponse = SocializeExpressionsPublishedPublishedexpressionidDeleteWithHttpInfo(publishedExpressionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete published expression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > SocializeExpressionsPublishedPublishedexpressionidDeleteWithHttpInfo (string publishedExpressionId)
        {
            // verify the required parameter 'publishedExpressionId' is set
            if (publishedExpressionId == null)
                throw new ApiException(400, "Missing required parameter 'publishedExpressionId' when calling SocializeApi->SocializeExpressionsPublishedPublishedexpressionidDelete");

            var localVarPath = "/api/v1/socialize/expressions/published/{publishedExpressionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (publishedExpressionId != null) localVarPathParams.Add("publishedExpressionId", Configuration.ApiClient.ParameterToString(publishedExpressionId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsPublishedPublishedexpressionidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsPublishedPublishedexpressionidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete published expression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> SocializeExpressionsPublishedPublishedexpressionidDeleteAsync (string publishedExpressionId)
        {
             ApiResponse<string> localVarResponse = await SocializeExpressionsPublishedPublishedexpressionidDeleteAsyncWithHttpInfo(publishedExpressionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete published expression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> SocializeExpressionsPublishedPublishedexpressionidDeleteAsyncWithHttpInfo (string publishedExpressionId)
        {
            // verify the required parameter 'publishedExpressionId' is set
            if (publishedExpressionId == null)
                throw new ApiException(400, "Missing required parameter 'publishedExpressionId' when calling SocializeApi->SocializeExpressionsPublishedPublishedexpressionidDelete");

            var localVarPath = "/api/v1/socialize/expressions/published/{publishedExpressionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (publishedExpressionId != null) localVarPathParams.Add("publishedExpressionId", Configuration.ApiClient.ParameterToString(publishedExpressionId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsPublishedPublishedexpressionidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsPublishedPublishedexpressionidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get published expression 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>PublishedExpression</returns>
        public PublishedExpression SocializeExpressionsPublishedPublishedexpressionidGet (string publishedExpressionId)
        {
             ApiResponse<PublishedExpression> localVarResponse = SocializeExpressionsPublishedPublishedexpressionidGetWithHttpInfo(publishedExpressionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get published expression 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>ApiResponse of PublishedExpression</returns>
        public ApiResponse< PublishedExpression > SocializeExpressionsPublishedPublishedexpressionidGetWithHttpInfo (string publishedExpressionId)
        {
            // verify the required parameter 'publishedExpressionId' is set
            if (publishedExpressionId == null)
                throw new ApiException(400, "Missing required parameter 'publishedExpressionId' when calling SocializeApi->SocializeExpressionsPublishedPublishedexpressionidGet");

            var localVarPath = "/api/v1/socialize/expressions/published/{publishedExpressionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (publishedExpressionId != null) localVarPathParams.Add("publishedExpressionId", Configuration.ApiClient.ParameterToString(publishedExpressionId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsPublishedPublishedexpressionidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsPublishedPublishedexpressionidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PublishedExpression>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PublishedExpression) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PublishedExpression)));
            
        }

        /// <summary>
        /// Get published expression 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>Task of PublishedExpression</returns>
        public async System.Threading.Tasks.Task<PublishedExpression> SocializeExpressionsPublishedPublishedexpressionidGetAsync (string publishedExpressionId)
        {
             ApiResponse<PublishedExpression> localVarResponse = await SocializeExpressionsPublishedPublishedexpressionidGetAsyncWithHttpInfo(publishedExpressionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get published expression 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>Task of ApiResponse (PublishedExpression)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PublishedExpression>> SocializeExpressionsPublishedPublishedexpressionidGetAsyncWithHttpInfo (string publishedExpressionId)
        {
            // verify the required parameter 'publishedExpressionId' is set
            if (publishedExpressionId == null)
                throw new ApiException(400, "Missing required parameter 'publishedExpressionId' when calling SocializeApi->SocializeExpressionsPublishedPublishedexpressionidGet");

            var localVarPath = "/api/v1/socialize/expressions/published/{publishedExpressionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (publishedExpressionId != null) localVarPathParams.Add("publishedExpressionId", Configuration.ApiClient.ParameterToString(publishedExpressionId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsPublishedPublishedexpressionidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsPublishedPublishedexpressionidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PublishedExpression>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PublishedExpression) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PublishedExpression)));
            
        }

        /// <summary>
        /// Update published expression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <param name="body">PublishedExpression (optional)</param>
        /// <returns>PublishedExpression</returns>
        public PublishedExpression SocializeExpressionsPublishedPublishedexpressionidPut (string publishedExpressionId, PublishedExpression body = null)
        {
             ApiResponse<PublishedExpression> localVarResponse = SocializeExpressionsPublishedPublishedexpressionidPutWithHttpInfo(publishedExpressionId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update published expression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <param name="body">PublishedExpression (optional)</param>
        /// <returns>ApiResponse of PublishedExpression</returns>
        public ApiResponse< PublishedExpression > SocializeExpressionsPublishedPublishedexpressionidPutWithHttpInfo (string publishedExpressionId, PublishedExpression body = null)
        {
            // verify the required parameter 'publishedExpressionId' is set
            if (publishedExpressionId == null)
                throw new ApiException(400, "Missing required parameter 'publishedExpressionId' when calling SocializeApi->SocializeExpressionsPublishedPublishedexpressionidPut");

            var localVarPath = "/api/v1/socialize/expressions/published/{publishedExpressionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (publishedExpressionId != null) localVarPathParams.Add("publishedExpressionId", Configuration.ApiClient.ParameterToString(publishedExpressionId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsPublishedPublishedexpressionidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsPublishedPublishedexpressionidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PublishedExpression>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PublishedExpression) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PublishedExpression)));
            
        }

        /// <summary>
        /// Update published expression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <param name="body">PublishedExpression (optional)</param>
        /// <returns>Task of PublishedExpression</returns>
        public async System.Threading.Tasks.Task<PublishedExpression> SocializeExpressionsPublishedPublishedexpressionidPutAsync (string publishedExpressionId, PublishedExpression body = null)
        {
             ApiResponse<PublishedExpression> localVarResponse = await SocializeExpressionsPublishedPublishedexpressionidPutAsyncWithHttpInfo(publishedExpressionId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update published expression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <param name="body">PublishedExpression (optional)</param>
        /// <returns>Task of ApiResponse (PublishedExpression)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PublishedExpression>> SocializeExpressionsPublishedPublishedexpressionidPutAsyncWithHttpInfo (string publishedExpressionId, PublishedExpression body = null)
        {
            // verify the required parameter 'publishedExpressionId' is set
            if (publishedExpressionId == null)
                throw new ApiException(400, "Missing required parameter 'publishedExpressionId' when calling SocializeApi->SocializeExpressionsPublishedPublishedexpressionidPut");

            var localVarPath = "/api/v1/socialize/expressions/published/{publishedExpressionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (publishedExpressionId != null) localVarPathParams.Add("publishedExpressionId", Configuration.ApiClient.ParameterToString(publishedExpressionId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsPublishedPublishedexpressionidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsPublishedPublishedexpressionidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PublishedExpression>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PublishedExpression) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PublishedExpression)));
            
        }

        /// <summary>
        /// Delete TwitterExpression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>string</returns>
        public string SocializeExpressionsTwitterExpressionidDelete (string expressionId)
        {
             ApiResponse<string> localVarResponse = SocializeExpressionsTwitterExpressionidDeleteWithHttpInfo(expressionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete TwitterExpression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > SocializeExpressionsTwitterExpressionidDeleteWithHttpInfo (string expressionId)
        {
            // verify the required parameter 'expressionId' is set
            if (expressionId == null)
                throw new ApiException(400, "Missing required parameter 'expressionId' when calling SocializeApi->SocializeExpressionsTwitterExpressionidDelete");

            var localVarPath = "/api/v1/socialize/expressions/twitter/{expressionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (expressionId != null) localVarPathParams.Add("expressionId", Configuration.ApiClient.ParameterToString(expressionId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsTwitterExpressionidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsTwitterExpressionidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete TwitterExpression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> SocializeExpressionsTwitterExpressionidDeleteAsync (string expressionId)
        {
             ApiResponse<string> localVarResponse = await SocializeExpressionsTwitterExpressionidDeleteAsyncWithHttpInfo(expressionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete TwitterExpression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> SocializeExpressionsTwitterExpressionidDeleteAsyncWithHttpInfo (string expressionId)
        {
            // verify the required parameter 'expressionId' is set
            if (expressionId == null)
                throw new ApiException(400, "Missing required parameter 'expressionId' when calling SocializeApi->SocializeExpressionsTwitterExpressionidDelete");

            var localVarPath = "/api/v1/socialize/expressions/twitter/{expressionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (expressionId != null) localVarPathParams.Add("expressionId", Configuration.ApiClient.ParameterToString(expressionId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsTwitterExpressionidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsTwitterExpressionidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get TwitterExpression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>TwitterExpression</returns>
        public TwitterExpression SocializeExpressionsTwitterExpressionidGet (string expressionId)
        {
             ApiResponse<TwitterExpression> localVarResponse = SocializeExpressionsTwitterExpressionidGetWithHttpInfo(expressionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get TwitterExpression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>ApiResponse of TwitterExpression</returns>
        public ApiResponse< TwitterExpression > SocializeExpressionsTwitterExpressionidGetWithHttpInfo (string expressionId)
        {
            // verify the required parameter 'expressionId' is set
            if (expressionId == null)
                throw new ApiException(400, "Missing required parameter 'expressionId' when calling SocializeApi->SocializeExpressionsTwitterExpressionidGet");

            var localVarPath = "/api/v1/socialize/expressions/twitter/{expressionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (expressionId != null) localVarPathParams.Add("expressionId", Configuration.ApiClient.ParameterToString(expressionId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsTwitterExpressionidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsTwitterExpressionidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TwitterExpression>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TwitterExpression) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TwitterExpression)));
            
        }

        /// <summary>
        /// Get TwitterExpression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>Task of TwitterExpression</returns>
        public async System.Threading.Tasks.Task<TwitterExpression> SocializeExpressionsTwitterExpressionidGetAsync (string expressionId)
        {
             ApiResponse<TwitterExpression> localVarResponse = await SocializeExpressionsTwitterExpressionidGetAsyncWithHttpInfo(expressionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get TwitterExpression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>Task of ApiResponse (TwitterExpression)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TwitterExpression>> SocializeExpressionsTwitterExpressionidGetAsyncWithHttpInfo (string expressionId)
        {
            // verify the required parameter 'expressionId' is set
            if (expressionId == null)
                throw new ApiException(400, "Missing required parameter 'expressionId' when calling SocializeApi->SocializeExpressionsTwitterExpressionidGet");

            var localVarPath = "/api/v1/socialize/expressions/twitter/{expressionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (expressionId != null) localVarPathParams.Add("expressionId", Configuration.ApiClient.ParameterToString(expressionId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsTwitterExpressionidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsTwitterExpressionidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TwitterExpression>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TwitterExpression) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TwitterExpression)));
            
        }

        /// <summary>
        /// Update TwitterExpression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <param name="body">TwitterExpression (optional)</param>
        /// <returns>TwitterExpression</returns>
        public TwitterExpression SocializeExpressionsTwitterExpressionidPut (string expressionId, TwitterExpression body = null)
        {
             ApiResponse<TwitterExpression> localVarResponse = SocializeExpressionsTwitterExpressionidPutWithHttpInfo(expressionId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update TwitterExpression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <param name="body">TwitterExpression (optional)</param>
        /// <returns>ApiResponse of TwitterExpression</returns>
        public ApiResponse< TwitterExpression > SocializeExpressionsTwitterExpressionidPutWithHttpInfo (string expressionId, TwitterExpression body = null)
        {
            // verify the required parameter 'expressionId' is set
            if (expressionId == null)
                throw new ApiException(400, "Missing required parameter 'expressionId' when calling SocializeApi->SocializeExpressionsTwitterExpressionidPut");

            var localVarPath = "/api/v1/socialize/expressions/twitter/{expressionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (expressionId != null) localVarPathParams.Add("expressionId", Configuration.ApiClient.ParameterToString(expressionId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsTwitterExpressionidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsTwitterExpressionidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TwitterExpression>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TwitterExpression) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TwitterExpression)));
            
        }

        /// <summary>
        /// Update TwitterExpression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <param name="body">TwitterExpression (optional)</param>
        /// <returns>Task of TwitterExpression</returns>
        public async System.Threading.Tasks.Task<TwitterExpression> SocializeExpressionsTwitterExpressionidPutAsync (string expressionId, TwitterExpression body = null)
        {
             ApiResponse<TwitterExpression> localVarResponse = await SocializeExpressionsTwitterExpressionidPutAsyncWithHttpInfo(expressionId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update TwitterExpression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <param name="body">TwitterExpression (optional)</param>
        /// <returns>Task of ApiResponse (TwitterExpression)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TwitterExpression>> SocializeExpressionsTwitterExpressionidPutAsyncWithHttpInfo (string expressionId, TwitterExpression body = null)
        {
            // verify the required parameter 'expressionId' is set
            if (expressionId == null)
                throw new ApiException(400, "Missing required parameter 'expressionId' when calling SocializeApi->SocializeExpressionsTwitterExpressionidPut");

            var localVarPath = "/api/v1/socialize/expressions/twitter/{expressionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (expressionId != null) localVarPathParams.Add("expressionId", Configuration.ApiClient.ParameterToString(expressionId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsTwitterExpressionidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsTwitterExpressionidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TwitterExpression>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TwitterExpression) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TwitterExpression)));
            
        }

        /// <summary>
        /// Get all configured expressions. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>DomainEntityListing</returns>
        public DomainEntityListing SocializeExpressionsTwitterGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> localVarResponse = SocializeExpressionsTwitterGetWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all configured expressions. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        public ApiResponse< DomainEntityListing > SocializeExpressionsTwitterGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/socialize/expressions/twitter";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsTwitterGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsTwitterGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEntityListing)));
            
        }

        /// <summary>
        /// Get all configured expressions. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of DomainEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainEntityListing> SocializeExpressionsTwitterGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> localVarResponse = await SocializeExpressionsTwitterGetAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all configured expressions. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> SocializeExpressionsTwitterGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/socialize/expressions/twitter";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsTwitterGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsTwitterGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEntityListing)));
            
        }

        /// <summary>
        /// Create twitter expression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">TwitterExpression (optional)</param>
        /// <returns>TwitterExpression</returns>
        public TwitterExpression SocializeExpressionsTwitterPost (TwitterExpression body = null)
        {
             ApiResponse<TwitterExpression> localVarResponse = SocializeExpressionsTwitterPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create twitter expression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">TwitterExpression (optional)</param>
        /// <returns>ApiResponse of TwitterExpression</returns>
        public ApiResponse< TwitterExpression > SocializeExpressionsTwitterPostWithHttpInfo (TwitterExpression body = null)
        {

            var localVarPath = "/api/v1/socialize/expressions/twitter";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsTwitterPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsTwitterPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TwitterExpression>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TwitterExpression) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TwitterExpression)));
            
        }

        /// <summary>
        /// Create twitter expression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">TwitterExpression (optional)</param>
        /// <returns>Task of TwitterExpression</returns>
        public async System.Threading.Tasks.Task<TwitterExpression> SocializeExpressionsTwitterPostAsync (TwitterExpression body = null)
        {
             ApiResponse<TwitterExpression> localVarResponse = await SocializeExpressionsTwitterPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create twitter expression. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">TwitterExpression (optional)</param>
        /// <returns>Task of ApiResponse (TwitterExpression)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TwitterExpression>> SocializeExpressionsTwitterPostAsyncWithHttpInfo (TwitterExpression body = null)
        {

            var localVarPath = "/api/v1/socialize/expressions/twitter";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsTwitterPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeExpressionsTwitterPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TwitterExpression>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TwitterExpression) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TwitterExpression)));
            
        }

        /// <summary>
        /// Get all configured gisteners. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="enabled">Enabled Only (optional, default to false)</param>
        /// <returns>DomainEntityListing</returns>
        public DomainEntityListing SocializeGistenersGet (int? pageSize = null, int? pageNumber = null, bool? enabled = null)
        {
             ApiResponse<DomainEntityListing> localVarResponse = SocializeGistenersGetWithHttpInfo(pageSize, pageNumber, enabled);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all configured gisteners. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="enabled">Enabled Only (optional, default to false)</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        public ApiResponse< DomainEntityListing > SocializeGistenersGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, bool? enabled = null)
        {

            var localVarPath = "/api/v1/socialize/gisteners";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (enabled != null) localVarQueryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeGistenersGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeGistenersGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEntityListing)));
            
        }

        /// <summary>
        /// Get all configured gisteners. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="enabled">Enabled Only (optional, default to false)</param>
        /// <returns>Task of DomainEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainEntityListing> SocializeGistenersGetAsync (int? pageSize = null, int? pageNumber = null, bool? enabled = null)
        {
             ApiResponse<DomainEntityListing> localVarResponse = await SocializeGistenersGetAsyncWithHttpInfo(pageSize, pageNumber, enabled);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all configured gisteners. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="enabled">Enabled Only (optional, default to false)</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> SocializeGistenersGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, bool? enabled = null)
        {

            var localVarPath = "/api/v1/socialize/gisteners";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (enabled != null) localVarQueryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeGistenersGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeGistenersGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEntityListing)));
            
        }

        /// <summary>
        /// Delete gistener. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>string</returns>
        public string SocializeGistenersGisteneridDelete (string gistenerId)
        {
             ApiResponse<string> localVarResponse = SocializeGistenersGisteneridDeleteWithHttpInfo(gistenerId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete gistener. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > SocializeGistenersGisteneridDeleteWithHttpInfo (string gistenerId)
        {
            // verify the required parameter 'gistenerId' is set
            if (gistenerId == null)
                throw new ApiException(400, "Missing required parameter 'gistenerId' when calling SocializeApi->SocializeGistenersGisteneridDelete");

            var localVarPath = "/api/v1/socialize/gisteners/{gistenerId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (gistenerId != null) localVarPathParams.Add("gistenerId", Configuration.ApiClient.ParameterToString(gistenerId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeGistenersGisteneridDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeGistenersGisteneridDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete gistener. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> SocializeGistenersGisteneridDeleteAsync (string gistenerId)
        {
             ApiResponse<string> localVarResponse = await SocializeGistenersGisteneridDeleteAsyncWithHttpInfo(gistenerId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete gistener. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> SocializeGistenersGisteneridDeleteAsyncWithHttpInfo (string gistenerId)
        {
            // verify the required parameter 'gistenerId' is set
            if (gistenerId == null)
                throw new ApiException(400, "Missing required parameter 'gistenerId' when calling SocializeApi->SocializeGistenersGisteneridDelete");

            var localVarPath = "/api/v1/socialize/gisteners/{gistenerId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (gistenerId != null) localVarPathParams.Add("gistenerId", Configuration.ApiClient.ParameterToString(gistenerId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeGistenersGisteneridDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeGistenersGisteneridDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get gistener. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>Gistener</returns>
        public Gistener SocializeGistenersGisteneridGet (string gistenerId)
        {
             ApiResponse<Gistener> localVarResponse = SocializeGistenersGisteneridGetWithHttpInfo(gistenerId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get gistener. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>ApiResponse of Gistener</returns>
        public ApiResponse< Gistener > SocializeGistenersGisteneridGetWithHttpInfo (string gistenerId)
        {
            // verify the required parameter 'gistenerId' is set
            if (gistenerId == null)
                throw new ApiException(400, "Missing required parameter 'gistenerId' when calling SocializeApi->SocializeGistenersGisteneridGet");

            var localVarPath = "/api/v1/socialize/gisteners/{gistenerId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (gistenerId != null) localVarPathParams.Add("gistenerId", Configuration.ApiClient.ParameterToString(gistenerId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeGistenersGisteneridGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeGistenersGisteneridGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Gistener>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Gistener) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Gistener)));
            
        }

        /// <summary>
        /// Get gistener. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>Task of Gistener</returns>
        public async System.Threading.Tasks.Task<Gistener> SocializeGistenersGisteneridGetAsync (string gistenerId)
        {
             ApiResponse<Gistener> localVarResponse = await SocializeGistenersGisteneridGetAsyncWithHttpInfo(gistenerId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get gistener. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>Task of ApiResponse (Gistener)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Gistener>> SocializeGistenersGisteneridGetAsyncWithHttpInfo (string gistenerId)
        {
            // verify the required parameter 'gistenerId' is set
            if (gistenerId == null)
                throw new ApiException(400, "Missing required parameter 'gistenerId' when calling SocializeApi->SocializeGistenersGisteneridGet");

            var localVarPath = "/api/v1/socialize/gisteners/{gistenerId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (gistenerId != null) localVarPathParams.Add("gistenerId", Configuration.ApiClient.ParameterToString(gistenerId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeGistenersGisteneridGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeGistenersGisteneridGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Gistener>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Gistener) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Gistener)));
            
        }

        /// <summary>
        /// Update gistener. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gistenerId">Gistener ID</param>
        /// <param name="body">Gistener (optional)</param>
        /// <returns>Gistener</returns>
        public Gistener SocializeGistenersGisteneridPut (string gistenerId, Gistener body = null)
        {
             ApiResponse<Gistener> localVarResponse = SocializeGistenersGisteneridPutWithHttpInfo(gistenerId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update gistener. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gistenerId">Gistener ID</param>
        /// <param name="body">Gistener (optional)</param>
        /// <returns>ApiResponse of Gistener</returns>
        public ApiResponse< Gistener > SocializeGistenersGisteneridPutWithHttpInfo (string gistenerId, Gistener body = null)
        {
            // verify the required parameter 'gistenerId' is set
            if (gistenerId == null)
                throw new ApiException(400, "Missing required parameter 'gistenerId' when calling SocializeApi->SocializeGistenersGisteneridPut");

            var localVarPath = "/api/v1/socialize/gisteners/{gistenerId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (gistenerId != null) localVarPathParams.Add("gistenerId", Configuration.ApiClient.ParameterToString(gistenerId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling SocializeGistenersGisteneridPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeGistenersGisteneridPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Gistener>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Gistener) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Gistener)));
            
        }

        /// <summary>
        /// Update gistener. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gistenerId">Gistener ID</param>
        /// <param name="body">Gistener (optional)</param>
        /// <returns>Task of Gistener</returns>
        public async System.Threading.Tasks.Task<Gistener> SocializeGistenersGisteneridPutAsync (string gistenerId, Gistener body = null)
        {
             ApiResponse<Gistener> localVarResponse = await SocializeGistenersGisteneridPutAsyncWithHttpInfo(gistenerId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update gistener. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gistenerId">Gistener ID</param>
        /// <param name="body">Gistener (optional)</param>
        /// <returns>Task of ApiResponse (Gistener)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Gistener>> SocializeGistenersGisteneridPutAsyncWithHttpInfo (string gistenerId, Gistener body = null)
        {
            // verify the required parameter 'gistenerId' is set
            if (gistenerId == null)
                throw new ApiException(400, "Missing required parameter 'gistenerId' when calling SocializeApi->SocializeGistenersGisteneridPut");

            var localVarPath = "/api/v1/socialize/gisteners/{gistenerId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (gistenerId != null) localVarPathParams.Add("gistenerId", Configuration.ApiClient.ParameterToString(gistenerId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling SocializeGistenersGisteneridPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeGistenersGisteneridPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Gistener>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Gistener) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Gistener)));
            
        }

        /// <summary>
        /// Create gistener. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Gistener (optional)</param>
        /// <param name="preview">Preview Only (optional, default to false)</param>
        /// <returns>Gistener</returns>
        public Gistener SocializeGistenersPost (Gistener body = null, bool? preview = null)
        {
             ApiResponse<Gistener> localVarResponse = SocializeGistenersPostWithHttpInfo(body, preview);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create gistener. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Gistener (optional)</param>
        /// <param name="preview">Preview Only (optional, default to false)</param>
        /// <returns>ApiResponse of Gistener</returns>
        public ApiResponse< Gistener > SocializeGistenersPostWithHttpInfo (Gistener body = null, bool? preview = null)
        {

            var localVarPath = "/api/v1/socialize/gisteners";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (preview != null) localVarQueryParams.Add("preview", Configuration.ApiClient.ParameterToString(preview)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling SocializeGistenersPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeGistenersPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Gistener>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Gistener) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Gistener)));
            
        }

        /// <summary>
        /// Create gistener. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Gistener (optional)</param>
        /// <param name="preview">Preview Only (optional, default to false)</param>
        /// <returns>Task of Gistener</returns>
        public async System.Threading.Tasks.Task<Gistener> SocializeGistenersPostAsync (Gistener body = null, bool? preview = null)
        {
             ApiResponse<Gistener> localVarResponse = await SocializeGistenersPostAsyncWithHttpInfo(body, preview);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create gistener. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Gistener (optional)</param>
        /// <param name="preview">Preview Only (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Gistener)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Gistener>> SocializeGistenersPostAsyncWithHttpInfo (Gistener body = null, bool? preview = null)
        {

            var localVarPath = "/api/v1/socialize/gisteners";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (preview != null) localVarQueryParams.Add("preview", Configuration.ApiClient.ParameterToString(preview)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling SocializeGistenersPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeGistenersPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Gistener>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Gistener) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Gistener)));
            
        }

        /// <summary>
        /// Get all configured groupTags. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="enabled">Enabled Only (optional, default to false)</param>
        /// <returns>DomainEntityListing</returns>
        public DomainEntityListing SocializeGrouptagsGet (int? pageSize = null, int? pageNumber = null, bool? enabled = null)
        {
             ApiResponse<DomainEntityListing> localVarResponse = SocializeGrouptagsGetWithHttpInfo(pageSize, pageNumber, enabled);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all configured groupTags. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="enabled">Enabled Only (optional, default to false)</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        public ApiResponse< DomainEntityListing > SocializeGrouptagsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, bool? enabled = null)
        {

            var localVarPath = "/api/v1/socialize/grouptags";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (enabled != null) localVarQueryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeGrouptagsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeGrouptagsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEntityListing)));
            
        }

        /// <summary>
        /// Get all configured groupTags. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="enabled">Enabled Only (optional, default to false)</param>
        /// <returns>Task of DomainEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainEntityListing> SocializeGrouptagsGetAsync (int? pageSize = null, int? pageNumber = null, bool? enabled = null)
        {
             ApiResponse<DomainEntityListing> localVarResponse = await SocializeGrouptagsGetAsyncWithHttpInfo(pageSize, pageNumber, enabled);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all configured groupTags. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="enabled">Enabled Only (optional, default to false)</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> SocializeGrouptagsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, bool? enabled = null)
        {

            var localVarPath = "/api/v1/socialize/grouptags";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (enabled != null) localVarQueryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeGrouptagsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeGrouptagsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEntityListing)));
            
        }

        /// <summary>
        /// Delete grouptag. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>string</returns>
        public string SocializeGrouptagsGrouptagidDelete (string groupTagId)
        {
             ApiResponse<string> localVarResponse = SocializeGrouptagsGrouptagidDeleteWithHttpInfo(groupTagId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete grouptag. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > SocializeGrouptagsGrouptagidDeleteWithHttpInfo (string groupTagId)
        {
            // verify the required parameter 'groupTagId' is set
            if (groupTagId == null)
                throw new ApiException(400, "Missing required parameter 'groupTagId' when calling SocializeApi->SocializeGrouptagsGrouptagidDelete");

            var localVarPath = "/api/v1/socialize/grouptags/{groupTagId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (groupTagId != null) localVarPathParams.Add("groupTagId", Configuration.ApiClient.ParameterToString(groupTagId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeGrouptagsGrouptagidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeGrouptagsGrouptagidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete grouptag. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> SocializeGrouptagsGrouptagidDeleteAsync (string groupTagId)
        {
             ApiResponse<string> localVarResponse = await SocializeGrouptagsGrouptagidDeleteAsyncWithHttpInfo(groupTagId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete grouptag. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> SocializeGrouptagsGrouptagidDeleteAsyncWithHttpInfo (string groupTagId)
        {
            // verify the required parameter 'groupTagId' is set
            if (groupTagId == null)
                throw new ApiException(400, "Missing required parameter 'groupTagId' when calling SocializeApi->SocializeGrouptagsGrouptagidDelete");

            var localVarPath = "/api/v1/socialize/grouptags/{groupTagId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (groupTagId != null) localVarPathParams.Add("groupTagId", Configuration.ApiClient.ParameterToString(groupTagId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeGrouptagsGrouptagidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeGrouptagsGrouptagidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get grouptag. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>GroupTag</returns>
        public GroupTag SocializeGrouptagsGrouptagidGet (string groupTagId)
        {
             ApiResponse<GroupTag> localVarResponse = SocializeGrouptagsGrouptagidGetWithHttpInfo(groupTagId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get grouptag. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>ApiResponse of GroupTag</returns>
        public ApiResponse< GroupTag > SocializeGrouptagsGrouptagidGetWithHttpInfo (string groupTagId)
        {
            // verify the required parameter 'groupTagId' is set
            if (groupTagId == null)
                throw new ApiException(400, "Missing required parameter 'groupTagId' when calling SocializeApi->SocializeGrouptagsGrouptagidGet");

            var localVarPath = "/api/v1/socialize/grouptags/{groupTagId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (groupTagId != null) localVarPathParams.Add("groupTagId", Configuration.ApiClient.ParameterToString(groupTagId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeGrouptagsGrouptagidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeGrouptagsGrouptagidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GroupTag>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GroupTag) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GroupTag)));
            
        }

        /// <summary>
        /// Get grouptag. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>Task of GroupTag</returns>
        public async System.Threading.Tasks.Task<GroupTag> SocializeGrouptagsGrouptagidGetAsync (string groupTagId)
        {
             ApiResponse<GroupTag> localVarResponse = await SocializeGrouptagsGrouptagidGetAsyncWithHttpInfo(groupTagId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get grouptag. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>Task of ApiResponse (GroupTag)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GroupTag>> SocializeGrouptagsGrouptagidGetAsyncWithHttpInfo (string groupTagId)
        {
            // verify the required parameter 'groupTagId' is set
            if (groupTagId == null)
                throw new ApiException(400, "Missing required parameter 'groupTagId' when calling SocializeApi->SocializeGrouptagsGrouptagidGet");

            var localVarPath = "/api/v1/socialize/grouptags/{groupTagId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (groupTagId != null) localVarPathParams.Add("groupTagId", Configuration.ApiClient.ParameterToString(groupTagId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeGrouptagsGrouptagidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeGrouptagsGrouptagidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GroupTag>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GroupTag) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GroupTag)));
            
        }

        /// <summary>
        /// Update grouptag. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupTagId">grouptag ID</param>
        /// <param name="body">grouptag (optional)</param>
        /// <returns>Gistener</returns>
        public Gistener SocializeGrouptagsGrouptagidPut (string groupTagId, GroupTag body = null)
        {
             ApiResponse<Gistener> localVarResponse = SocializeGrouptagsGrouptagidPutWithHttpInfo(groupTagId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update grouptag. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupTagId">grouptag ID</param>
        /// <param name="body">grouptag (optional)</param>
        /// <returns>ApiResponse of Gistener</returns>
        public ApiResponse< Gistener > SocializeGrouptagsGrouptagidPutWithHttpInfo (string groupTagId, GroupTag body = null)
        {
            // verify the required parameter 'groupTagId' is set
            if (groupTagId == null)
                throw new ApiException(400, "Missing required parameter 'groupTagId' when calling SocializeApi->SocializeGrouptagsGrouptagidPut");

            var localVarPath = "/api/v1/socialize/grouptags/{groupTagId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (groupTagId != null) localVarPathParams.Add("groupTagId", Configuration.ApiClient.ParameterToString(groupTagId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling SocializeGrouptagsGrouptagidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeGrouptagsGrouptagidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Gistener>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Gistener) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Gistener)));
            
        }

        /// <summary>
        /// Update grouptag. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupTagId">grouptag ID</param>
        /// <param name="body">grouptag (optional)</param>
        /// <returns>Task of Gistener</returns>
        public async System.Threading.Tasks.Task<Gistener> SocializeGrouptagsGrouptagidPutAsync (string groupTagId, GroupTag body = null)
        {
             ApiResponse<Gistener> localVarResponse = await SocializeGrouptagsGrouptagidPutAsyncWithHttpInfo(groupTagId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update grouptag. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupTagId">grouptag ID</param>
        /// <param name="body">grouptag (optional)</param>
        /// <returns>Task of ApiResponse (Gistener)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Gistener>> SocializeGrouptagsGrouptagidPutAsyncWithHttpInfo (string groupTagId, GroupTag body = null)
        {
            // verify the required parameter 'groupTagId' is set
            if (groupTagId == null)
                throw new ApiException(400, "Missing required parameter 'groupTagId' when calling SocializeApi->SocializeGrouptagsGrouptagidPut");

            var localVarPath = "/api/v1/socialize/grouptags/{groupTagId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (groupTagId != null) localVarPathParams.Add("groupTagId", Configuration.ApiClient.ParameterToString(groupTagId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling SocializeGrouptagsGrouptagidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeGrouptagsGrouptagidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Gistener>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Gistener) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Gistener)));
            
        }

        /// <summary>
        /// Create grouptag. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">grouptag (optional)</param>
        /// <returns>GroupTag</returns>
        public GroupTag SocializeGrouptagsPost (GroupTag body = null)
        {
             ApiResponse<GroupTag> localVarResponse = SocializeGrouptagsPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create grouptag. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">grouptag (optional)</param>
        /// <returns>ApiResponse of GroupTag</returns>
        public ApiResponse< GroupTag > SocializeGrouptagsPostWithHttpInfo (GroupTag body = null)
        {

            var localVarPath = "/api/v1/socialize/grouptags";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling SocializeGrouptagsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeGrouptagsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GroupTag>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GroupTag) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GroupTag)));
            
        }

        /// <summary>
        /// Create grouptag. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">grouptag (optional)</param>
        /// <returns>Task of GroupTag</returns>
        public async System.Threading.Tasks.Task<GroupTag> SocializeGrouptagsPostAsync (GroupTag body = null)
        {
             ApiResponse<GroupTag> localVarResponse = await SocializeGrouptagsPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create grouptag. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">grouptag (optional)</param>
        /// <returns>Task of ApiResponse (GroupTag)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GroupTag>> SocializeGrouptagsPostAsyncWithHttpInfo (GroupTag body = null)
        {

            var localVarPath = "/api/v1/socialize/grouptags";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling SocializeGrouptagsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeGrouptagsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GroupTag>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GroupTag) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GroupTag)));
            
        }

        /// <summary>
        /// Get all configured publications. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>DomainEntityListing</returns>
        public DomainEntityListing SocializePublicationsGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> localVarResponse = SocializePublicationsGetWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all configured publications. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        public ApiResponse< DomainEntityListing > SocializePublicationsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/socialize/publications";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling SocializePublicationsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializePublicationsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEntityListing)));
            
        }

        /// <summary>
        /// Get all configured publications. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of DomainEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainEntityListing> SocializePublicationsGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> localVarResponse = await SocializePublicationsGetAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all configured publications. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> SocializePublicationsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v1/socialize/publications";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling SocializePublicationsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializePublicationsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEntityListing)));
            
        }

        /// <summary>
        /// Create publication. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Publication (optional)</param>
        /// <returns>Publication</returns>
        public Publication SocializePublicationsPost (Publication body = null)
        {
             ApiResponse<Publication> localVarResponse = SocializePublicationsPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create publication. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Publication (optional)</param>
        /// <returns>ApiResponse of Publication</returns>
        public ApiResponse< Publication > SocializePublicationsPostWithHttpInfo (Publication body = null)
        {

            var localVarPath = "/api/v1/socialize/publications";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling SocializePublicationsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializePublicationsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Publication>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Publication) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Publication)));
            
        }

        /// <summary>
        /// Create publication. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Publication (optional)</param>
        /// <returns>Task of Publication</returns>
        public async System.Threading.Tasks.Task<Publication> SocializePublicationsPostAsync (Publication body = null)
        {
             ApiResponse<Publication> localVarResponse = await SocializePublicationsPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create publication. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Publication (optional)</param>
        /// <returns>Task of ApiResponse (Publication)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Publication>> SocializePublicationsPostAsyncWithHttpInfo (Publication body = null)
        {

            var localVarPath = "/api/v1/socialize/publications";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling SocializePublicationsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializePublicationsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Publication>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Publication) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Publication)));
            
        }

        /// <summary>
        /// Delete publication. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>string</returns>
        public string SocializePublicationsPublicationidDelete (string publicationId)
        {
             ApiResponse<string> localVarResponse = SocializePublicationsPublicationidDeleteWithHttpInfo(publicationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete publication. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > SocializePublicationsPublicationidDeleteWithHttpInfo (string publicationId)
        {
            // verify the required parameter 'publicationId' is set
            if (publicationId == null)
                throw new ApiException(400, "Missing required parameter 'publicationId' when calling SocializeApi->SocializePublicationsPublicationidDelete");

            var localVarPath = "/api/v1/socialize/publications/{publicationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (publicationId != null) localVarPathParams.Add("publicationId", Configuration.ApiClient.ParameterToString(publicationId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializePublicationsPublicationidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializePublicationsPublicationidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete publication. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> SocializePublicationsPublicationidDeleteAsync (string publicationId)
        {
             ApiResponse<string> localVarResponse = await SocializePublicationsPublicationidDeleteAsyncWithHttpInfo(publicationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete publication. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> SocializePublicationsPublicationidDeleteAsyncWithHttpInfo (string publicationId)
        {
            // verify the required parameter 'publicationId' is set
            if (publicationId == null)
                throw new ApiException(400, "Missing required parameter 'publicationId' when calling SocializeApi->SocializePublicationsPublicationidDelete");

            var localVarPath = "/api/v1/socialize/publications/{publicationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (publicationId != null) localVarPathParams.Add("publicationId", Configuration.ApiClient.ParameterToString(publicationId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializePublicationsPublicationidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializePublicationsPublicationidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get publication. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>Publication</returns>
        public Publication SocializePublicationsPublicationidGet (string publicationId)
        {
             ApiResponse<Publication> localVarResponse = SocializePublicationsPublicationidGetWithHttpInfo(publicationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get publication. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>ApiResponse of Publication</returns>
        public ApiResponse< Publication > SocializePublicationsPublicationidGetWithHttpInfo (string publicationId)
        {
            // verify the required parameter 'publicationId' is set
            if (publicationId == null)
                throw new ApiException(400, "Missing required parameter 'publicationId' when calling SocializeApi->SocializePublicationsPublicationidGet");

            var localVarPath = "/api/v1/socialize/publications/{publicationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (publicationId != null) localVarPathParams.Add("publicationId", Configuration.ApiClient.ParameterToString(publicationId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializePublicationsPublicationidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializePublicationsPublicationidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Publication>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Publication) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Publication)));
            
        }

        /// <summary>
        /// Get publication. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>Task of Publication</returns>
        public async System.Threading.Tasks.Task<Publication> SocializePublicationsPublicationidGetAsync (string publicationId)
        {
             ApiResponse<Publication> localVarResponse = await SocializePublicationsPublicationidGetAsyncWithHttpInfo(publicationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get publication. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>Task of ApiResponse (Publication)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Publication>> SocializePublicationsPublicationidGetAsyncWithHttpInfo (string publicationId)
        {
            // verify the required parameter 'publicationId' is set
            if (publicationId == null)
                throw new ApiException(400, "Missing required parameter 'publicationId' when calling SocializeApi->SocializePublicationsPublicationidGet");

            var localVarPath = "/api/v1/socialize/publications/{publicationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (publicationId != null) localVarPathParams.Add("publicationId", Configuration.ApiClient.ParameterToString(publicationId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializePublicationsPublicationidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializePublicationsPublicationidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Publication>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Publication) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Publication)));
            
        }

        /// <summary>
        /// Update publication. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicationId">Publication ID</param>
        /// <param name="body">Publication (optional)</param>
        /// <returns>Gistener</returns>
        public Gistener SocializePublicationsPublicationidPut (string publicationId, Publication body = null)
        {
             ApiResponse<Gistener> localVarResponse = SocializePublicationsPublicationidPutWithHttpInfo(publicationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update publication. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicationId">Publication ID</param>
        /// <param name="body">Publication (optional)</param>
        /// <returns>ApiResponse of Gistener</returns>
        public ApiResponse< Gistener > SocializePublicationsPublicationidPutWithHttpInfo (string publicationId, Publication body = null)
        {
            // verify the required parameter 'publicationId' is set
            if (publicationId == null)
                throw new ApiException(400, "Missing required parameter 'publicationId' when calling SocializeApi->SocializePublicationsPublicationidPut");

            var localVarPath = "/api/v1/socialize/publications/{publicationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (publicationId != null) localVarPathParams.Add("publicationId", Configuration.ApiClient.ParameterToString(publicationId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling SocializePublicationsPublicationidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializePublicationsPublicationidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Gistener>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Gistener) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Gistener)));
            
        }

        /// <summary>
        /// Update publication. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicationId">Publication ID</param>
        /// <param name="body">Publication (optional)</param>
        /// <returns>Task of Gistener</returns>
        public async System.Threading.Tasks.Task<Gistener> SocializePublicationsPublicationidPutAsync (string publicationId, Publication body = null)
        {
             ApiResponse<Gistener> localVarResponse = await SocializePublicationsPublicationidPutAsyncWithHttpInfo(publicationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update publication. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicationId">Publication ID</param>
        /// <param name="body">Publication (optional)</param>
        /// <returns>Task of ApiResponse (Gistener)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Gistener>> SocializePublicationsPublicationidPutAsyncWithHttpInfo (string publicationId, Publication body = null)
        {
            // verify the required parameter 'publicationId' is set
            if (publicationId == null)
                throw new ApiException(400, "Missing required parameter 'publicationId' when calling SocializeApi->SocializePublicationsPublicationidPut");

            var localVarPath = "/api/v1/socialize/publications/{publicationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (publicationId != null) localVarPathParams.Add("publicationId", Configuration.ApiClient.ParameterToString(publicationId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling SocializePublicationsPublicationidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializePublicationsPublicationidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Gistener>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Gistener) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Gistener)));
            
        }

        /// <summary>
        /// Get all social accounts. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="enabled">Enabled Only (optional, default to false)</param>
        /// <returns>DomainEntityListing</returns>
        public DomainEntityListing SocializeSocialaccountsGet (int? pageSize = null, int? pageNumber = null, bool? enabled = null)
        {
             ApiResponse<DomainEntityListing> localVarResponse = SocializeSocialaccountsGetWithHttpInfo(pageSize, pageNumber, enabled);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all social accounts. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="enabled">Enabled Only (optional, default to false)</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        public ApiResponse< DomainEntityListing > SocializeSocialaccountsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, bool? enabled = null)
        {

            var localVarPath = "/api/v1/socialize/socialaccounts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (enabled != null) localVarQueryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeSocialaccountsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeSocialaccountsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEntityListing)));
            
        }

        /// <summary>
        /// Get all social accounts. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="enabled">Enabled Only (optional, default to false)</param>
        /// <returns>Task of DomainEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainEntityListing> SocializeSocialaccountsGetAsync (int? pageSize = null, int? pageNumber = null, bool? enabled = null)
        {
             ApiResponse<DomainEntityListing> localVarResponse = await SocializeSocialaccountsGetAsyncWithHttpInfo(pageSize, pageNumber, enabled);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all social accounts. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="enabled">Enabled Only (optional, default to false)</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> SocializeSocialaccountsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, bool? enabled = null)
        {

            var localVarPath = "/api/v1/socialize/socialaccounts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (enabled != null) localVarQueryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeSocialaccountsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeSocialaccountsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEntityListing)));
            
        }

        /// <summary>
        /// Create social account. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SocialAccount (optional)</param>
        /// <returns>SocialAccount</returns>
        public SocialAccount SocializeSocialaccountsPost (SocialAccount body = null)
        {
             ApiResponse<SocialAccount> localVarResponse = SocializeSocialaccountsPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create social account. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SocialAccount (optional)</param>
        /// <returns>ApiResponse of SocialAccount</returns>
        public ApiResponse< SocialAccount > SocializeSocialaccountsPostWithHttpInfo (SocialAccount body = null)
        {

            var localVarPath = "/api/v1/socialize/socialaccounts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling SocializeSocialaccountsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeSocialaccountsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SocialAccount>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SocialAccount) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SocialAccount)));
            
        }

        /// <summary>
        /// Create social account. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SocialAccount (optional)</param>
        /// <returns>Task of SocialAccount</returns>
        public async System.Threading.Tasks.Task<SocialAccount> SocializeSocialaccountsPostAsync (SocialAccount body = null)
        {
             ApiResponse<SocialAccount> localVarResponse = await SocializeSocialaccountsPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create social account. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">SocialAccount (optional)</param>
        /// <returns>Task of ApiResponse (SocialAccount)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SocialAccount>> SocializeSocialaccountsPostAsyncWithHttpInfo (SocialAccount body = null)
        {

            var localVarPath = "/api/v1/socialize/socialaccounts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling SocializeSocialaccountsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeSocialaccountsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SocialAccount>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SocialAccount) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SocialAccount)));
            
        }

        /// <summary>
        /// Delete social account. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>string</returns>
        public string SocializeSocialaccountsSocialaccountidDelete (string socialAccountId, bool? enabled)
        {
             ApiResponse<string> localVarResponse = SocializeSocialaccountsSocialaccountidDeleteWithHttpInfo(socialAccountId, enabled);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete social account. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > SocializeSocialaccountsSocialaccountidDeleteWithHttpInfo (string socialAccountId, bool? enabled)
        {
            // verify the required parameter 'socialAccountId' is set
            if (socialAccountId == null)
                throw new ApiException(400, "Missing required parameter 'socialAccountId' when calling SocializeApi->SocializeSocialaccountsSocialaccountidDelete");
            // verify the required parameter 'enabled' is set
            if (enabled == null)
                throw new ApiException(400, "Missing required parameter 'enabled' when calling SocializeApi->SocializeSocialaccountsSocialaccountidDelete");

            var localVarPath = "/api/v1/socialize/socialaccounts/{socialAccountId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (socialAccountId != null) localVarPathParams.Add("socialAccountId", Configuration.ApiClient.ParameterToString(socialAccountId)); // path parameter
            if (enabled != null) localVarQueryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeSocialaccountsSocialaccountidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeSocialaccountsSocialaccountidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete social account. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> SocializeSocialaccountsSocialaccountidDeleteAsync (string socialAccountId, bool? enabled)
        {
             ApiResponse<string> localVarResponse = await SocializeSocialaccountsSocialaccountidDeleteAsyncWithHttpInfo(socialAccountId, enabled);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete social account. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> SocializeSocialaccountsSocialaccountidDeleteAsyncWithHttpInfo (string socialAccountId, bool? enabled)
        {
            // verify the required parameter 'socialAccountId' is set
            if (socialAccountId == null)
                throw new ApiException(400, "Missing required parameter 'socialAccountId' when calling SocializeApi->SocializeSocialaccountsSocialaccountidDelete");
            // verify the required parameter 'enabled' is set
            if (enabled == null)
                throw new ApiException(400, "Missing required parameter 'enabled' when calling SocializeApi->SocializeSocialaccountsSocialaccountidDelete");

            var localVarPath = "/api/v1/socialize/socialaccounts/{socialAccountId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (socialAccountId != null) localVarPathParams.Add("socialAccountId", Configuration.ApiClient.ParameterToString(socialAccountId)); // path parameter
            if (enabled != null) localVarQueryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeSocialaccountsSocialaccountidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeSocialaccountsSocialaccountidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get social account 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>SocialAccount</returns>
        public SocialAccount SocializeSocialaccountsSocialaccountidGet (string socialAccountId, bool? enabled)
        {
             ApiResponse<SocialAccount> localVarResponse = SocializeSocialaccountsSocialaccountidGetWithHttpInfo(socialAccountId, enabled);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get social account 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>ApiResponse of SocialAccount</returns>
        public ApiResponse< SocialAccount > SocializeSocialaccountsSocialaccountidGetWithHttpInfo (string socialAccountId, bool? enabled)
        {
            // verify the required parameter 'socialAccountId' is set
            if (socialAccountId == null)
                throw new ApiException(400, "Missing required parameter 'socialAccountId' when calling SocializeApi->SocializeSocialaccountsSocialaccountidGet");
            // verify the required parameter 'enabled' is set
            if (enabled == null)
                throw new ApiException(400, "Missing required parameter 'enabled' when calling SocializeApi->SocializeSocialaccountsSocialaccountidGet");

            var localVarPath = "/api/v1/socialize/socialaccounts/{socialAccountId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (socialAccountId != null) localVarPathParams.Add("socialAccountId", Configuration.ApiClient.ParameterToString(socialAccountId)); // path parameter
            if (enabled != null) localVarQueryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeSocialaccountsSocialaccountidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeSocialaccountsSocialaccountidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SocialAccount>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SocialAccount) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SocialAccount)));
            
        }

        /// <summary>
        /// Get social account 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>Task of SocialAccount</returns>
        public async System.Threading.Tasks.Task<SocialAccount> SocializeSocialaccountsSocialaccountidGetAsync (string socialAccountId, bool? enabled)
        {
             ApiResponse<SocialAccount> localVarResponse = await SocializeSocialaccountsSocialaccountidGetAsyncWithHttpInfo(socialAccountId, enabled);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get social account 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>Task of ApiResponse (SocialAccount)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SocialAccount>> SocializeSocialaccountsSocialaccountidGetAsyncWithHttpInfo (string socialAccountId, bool? enabled)
        {
            // verify the required parameter 'socialAccountId' is set
            if (socialAccountId == null)
                throw new ApiException(400, "Missing required parameter 'socialAccountId' when calling SocializeApi->SocializeSocialaccountsSocialaccountidGet");
            // verify the required parameter 'enabled' is set
            if (enabled == null)
                throw new ApiException(400, "Missing required parameter 'enabled' when calling SocializeApi->SocializeSocialaccountsSocialaccountidGet");

            var localVarPath = "/api/v1/socialize/socialaccounts/{socialAccountId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (socialAccountId != null) localVarPathParams.Add("socialAccountId", Configuration.ApiClient.ParameterToString(socialAccountId)); // path parameter
            if (enabled != null) localVarQueryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeSocialaccountsSocialaccountidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeSocialaccountsSocialaccountidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SocialAccount>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SocialAccount) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SocialAccount)));
            
        }

        /// <summary>
        /// Enabled/Disable feed for social account. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>bool?</returns>
        public bool? SocializeSocialaccountsSocialaccountidPatch (string socialAccountId, bool? enabled)
        {
             ApiResponse<bool?> localVarResponse = SocializeSocialaccountsSocialaccountidPatchWithHttpInfo(socialAccountId, enabled);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Enabled/Disable feed for social account. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>ApiResponse of bool?</returns>
        public ApiResponse< bool? > SocializeSocialaccountsSocialaccountidPatchWithHttpInfo (string socialAccountId, bool? enabled)
        {
            // verify the required parameter 'socialAccountId' is set
            if (socialAccountId == null)
                throw new ApiException(400, "Missing required parameter 'socialAccountId' when calling SocializeApi->SocializeSocialaccountsSocialaccountidPatch");
            // verify the required parameter 'enabled' is set
            if (enabled == null)
                throw new ApiException(400, "Missing required parameter 'enabled' when calling SocializeApi->SocializeSocialaccountsSocialaccountidPatch");

            var localVarPath = "/api/v1/socialize/socialaccounts/{socialAccountId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (socialAccountId != null) localVarPathParams.Add("socialAccountId", Configuration.ApiClient.ParameterToString(socialAccountId)); // path parameter
            if (enabled != null) localVarQueryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeSocialaccountsSocialaccountidPatch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeSocialaccountsSocialaccountidPatch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<bool?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (bool?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(bool?)));
            
        }

        /// <summary>
        /// Enabled/Disable feed for social account. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>Task of bool?</returns>
        public async System.Threading.Tasks.Task<bool?> SocializeSocialaccountsSocialaccountidPatchAsync (string socialAccountId, bool? enabled)
        {
             ApiResponse<bool?> localVarResponse = await SocializeSocialaccountsSocialaccountidPatchAsyncWithHttpInfo(socialAccountId, enabled);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Enabled/Disable feed for social account. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>Task of ApiResponse (bool?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<bool?>> SocializeSocialaccountsSocialaccountidPatchAsyncWithHttpInfo (string socialAccountId, bool? enabled)
        {
            // verify the required parameter 'socialAccountId' is set
            if (socialAccountId == null)
                throw new ApiException(400, "Missing required parameter 'socialAccountId' when calling SocializeApi->SocializeSocialaccountsSocialaccountidPatch");
            // verify the required parameter 'enabled' is set
            if (enabled == null)
                throw new ApiException(400, "Missing required parameter 'enabled' when calling SocializeApi->SocializeSocialaccountsSocialaccountidPatch");

            var localVarPath = "/api/v1/socialize/socialaccounts/{socialAccountId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (socialAccountId != null) localVarPathParams.Add("socialAccountId", Configuration.ApiClient.ParameterToString(socialAccountId)); // path parameter
            if (enabled != null) localVarQueryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling SocializeSocialaccountsSocialaccountidPatch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeSocialaccountsSocialaccountidPatch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<bool?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (bool?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(bool?)));
            
        }

        /// <summary>
        /// Update social account. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <param name="body">SocialAccount (optional)</param>
        /// <returns>SocialAccount</returns>
        public SocialAccount SocializeSocialaccountsSocialaccountidPut (string socialAccountId, bool? enabled, SocialAccount body = null)
        {
             ApiResponse<SocialAccount> localVarResponse = SocializeSocialaccountsSocialaccountidPutWithHttpInfo(socialAccountId, enabled, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update social account. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <param name="body">SocialAccount (optional)</param>
        /// <returns>ApiResponse of SocialAccount</returns>
        public ApiResponse< SocialAccount > SocializeSocialaccountsSocialaccountidPutWithHttpInfo (string socialAccountId, bool? enabled, SocialAccount body = null)
        {
            // verify the required parameter 'socialAccountId' is set
            if (socialAccountId == null)
                throw new ApiException(400, "Missing required parameter 'socialAccountId' when calling SocializeApi->SocializeSocialaccountsSocialaccountidPut");
            // verify the required parameter 'enabled' is set
            if (enabled == null)
                throw new ApiException(400, "Missing required parameter 'enabled' when calling SocializeApi->SocializeSocialaccountsSocialaccountidPut");

            var localVarPath = "/api/v1/socialize/socialaccounts/{socialAccountId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (socialAccountId != null) localVarPathParams.Add("socialAccountId", Configuration.ApiClient.ParameterToString(socialAccountId)); // path parameter
            if (enabled != null) localVarQueryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling SocializeSocialaccountsSocialaccountidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeSocialaccountsSocialaccountidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SocialAccount>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SocialAccount) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SocialAccount)));
            
        }

        /// <summary>
        /// Update social account. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <param name="body">SocialAccount (optional)</param>
        /// <returns>Task of SocialAccount</returns>
        public async System.Threading.Tasks.Task<SocialAccount> SocializeSocialaccountsSocialaccountidPutAsync (string socialAccountId, bool? enabled, SocialAccount body = null)
        {
             ApiResponse<SocialAccount> localVarResponse = await SocializeSocialaccountsSocialaccountidPutAsyncWithHttpInfo(socialAccountId, enabled, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update social account. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <param name="body">SocialAccount (optional)</param>
        /// <returns>Task of ApiResponse (SocialAccount)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SocialAccount>> SocializeSocialaccountsSocialaccountidPutAsyncWithHttpInfo (string socialAccountId, bool? enabled, SocialAccount body = null)
        {
            // verify the required parameter 'socialAccountId' is set
            if (socialAccountId == null)
                throw new ApiException(400, "Missing required parameter 'socialAccountId' when calling SocializeApi->SocializeSocialaccountsSocialaccountidPut");
            // verify the required parameter 'enabled' is set
            if (enabled == null)
                throw new ApiException(400, "Missing required parameter 'enabled' when calling SocializeApi->SocializeSocialaccountsSocialaccountidPut");

            var localVarPath = "/api/v1/socialize/socialaccounts/{socialAccountId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (socialAccountId != null) localVarPathParams.Add("socialAccountId", Configuration.ApiClient.ParameterToString(socialAccountId)); // path parameter
            if (enabled != null) localVarQueryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling SocializeSocialaccountsSocialaccountidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SocializeSocialaccountsSocialaccountidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SocialAccount>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SocialAccount) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SocialAccount)));
            
        }

    }
}
