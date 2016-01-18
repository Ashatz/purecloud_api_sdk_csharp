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
    public interface ISocializeApi
    {
        
        /// <summary>
        /// Get all published expressions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>DomainEntityListing</returns>
        DomainEntityListing SocializeExpressionsPublishedGet (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get all published expressions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        ApiResponse<DomainEntityListing> SocializeExpressionsPublishedGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get all published expressions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainEntityListing</returns>
        System.Threading.Tasks.Task<DomainEntityListing> SocializeExpressionsPublishedGetAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get all published expressions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> SocializeExpressionsPublishedGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Create published expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">PublishedExpression</param>
        /// <returns>PublishedExpression</returns>
        PublishedExpression SocializeExpressionsPublishedPost (PublishedExpression body = null);
  
        /// <summary>
        /// Create published expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">PublishedExpression</param>
        /// <returns>ApiResponse of PublishedExpression</returns>
        ApiResponse<PublishedExpression> SocializeExpressionsPublishedPostWithHttpInfo (PublishedExpression body = null);

        /// <summary>
        /// Create published expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">PublishedExpression</param>
        /// <returns>Task of PublishedExpression</returns>
        System.Threading.Tasks.Task<PublishedExpression> SocializeExpressionsPublishedPostAsync (PublishedExpression body = null);

        /// <summary>
        /// Create published expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">PublishedExpression</param>
        /// <returns>Task of ApiResponse (PublishedExpression)</returns>
        System.Threading.Tasks.Task<ApiResponse<PublishedExpression>> SocializeExpressionsPublishedPostAsyncWithHttpInfo (PublishedExpression body = null);
        
        /// <summary>
        /// Get published expression
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>PublishedExpression</returns>
        PublishedExpression SocializeExpressionsPublishedPublishedexpressionidGet (string publishedExpressionId);
  
        /// <summary>
        /// Get published expression
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>ApiResponse of PublishedExpression</returns>
        ApiResponse<PublishedExpression> SocializeExpressionsPublishedPublishedexpressionidGetWithHttpInfo (string publishedExpressionId);

        /// <summary>
        /// Get published expression
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>Task of PublishedExpression</returns>
        System.Threading.Tasks.Task<PublishedExpression> SocializeExpressionsPublishedPublishedexpressionidGetAsync (string publishedExpressionId);

        /// <summary>
        /// Get published expression
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>Task of ApiResponse (PublishedExpression)</returns>
        System.Threading.Tasks.Task<ApiResponse<PublishedExpression>> SocializeExpressionsPublishedPublishedexpressionidGetAsyncWithHttpInfo (string publishedExpressionId);
        
        /// <summary>
        /// Update published expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <param name="body">PublishedExpression</param>
        /// <returns>PublishedExpression</returns>
        PublishedExpression SocializeExpressionsPublishedPublishedexpressionidPut (string publishedExpressionId, PublishedExpression body = null);
  
        /// <summary>
        /// Update published expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <param name="body">PublishedExpression</param>
        /// <returns>ApiResponse of PublishedExpression</returns>
        ApiResponse<PublishedExpression> SocializeExpressionsPublishedPublishedexpressionidPutWithHttpInfo (string publishedExpressionId, PublishedExpression body = null);

        /// <summary>
        /// Update published expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <param name="body">PublishedExpression</param>
        /// <returns>Task of PublishedExpression</returns>
        System.Threading.Tasks.Task<PublishedExpression> SocializeExpressionsPublishedPublishedexpressionidPutAsync (string publishedExpressionId, PublishedExpression body = null);

        /// <summary>
        /// Update published expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <param name="body">PublishedExpression</param>
        /// <returns>Task of ApiResponse (PublishedExpression)</returns>
        System.Threading.Tasks.Task<ApiResponse<PublishedExpression>> SocializeExpressionsPublishedPublishedexpressionidPutAsyncWithHttpInfo (string publishedExpressionId, PublishedExpression body = null);
        
        /// <summary>
        /// Delete published expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>string</returns>
        string SocializeExpressionsPublishedPublishedexpressionidDelete (string publishedExpressionId);
  
        /// <summary>
        /// Delete published expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> SocializeExpressionsPublishedPublishedexpressionidDeleteWithHttpInfo (string publishedExpressionId);

        /// <summary>
        /// Delete published expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> SocializeExpressionsPublishedPublishedexpressionidDeleteAsync (string publishedExpressionId);

        /// <summary>
        /// Delete published expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> SocializeExpressionsPublishedPublishedexpressionidDeleteAsyncWithHttpInfo (string publishedExpressionId);
        
        /// <summary>
        /// Get all configured expressions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>DomainEntityListing</returns>
        DomainEntityListing SocializeExpressionsTwitterGet (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get all configured expressions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        ApiResponse<DomainEntityListing> SocializeExpressionsTwitterGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get all configured expressions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainEntityListing</returns>
        System.Threading.Tasks.Task<DomainEntityListing> SocializeExpressionsTwitterGetAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get all configured expressions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> SocializeExpressionsTwitterGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Create twitter expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">TwitterExpression</param>
        /// <returns>TwitterExpression</returns>
        TwitterExpression SocializeExpressionsTwitterPost (TwitterExpression body = null);
  
        /// <summary>
        /// Create twitter expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">TwitterExpression</param>
        /// <returns>ApiResponse of TwitterExpression</returns>
        ApiResponse<TwitterExpression> SocializeExpressionsTwitterPostWithHttpInfo (TwitterExpression body = null);

        /// <summary>
        /// Create twitter expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">TwitterExpression</param>
        /// <returns>Task of TwitterExpression</returns>
        System.Threading.Tasks.Task<TwitterExpression> SocializeExpressionsTwitterPostAsync (TwitterExpression body = null);

        /// <summary>
        /// Create twitter expression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">TwitterExpression</param>
        /// <returns>Task of ApiResponse (TwitterExpression)</returns>
        System.Threading.Tasks.Task<ApiResponse<TwitterExpression>> SocializeExpressionsTwitterPostAsyncWithHttpInfo (TwitterExpression body = null);
        
        /// <summary>
        /// Get TwitterExpression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>TwitterExpression</returns>
        TwitterExpression SocializeExpressionsTwitterExpressionidGet (string expressionId);
  
        /// <summary>
        /// Get TwitterExpression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>ApiResponse of TwitterExpression</returns>
        ApiResponse<TwitterExpression> SocializeExpressionsTwitterExpressionidGetWithHttpInfo (string expressionId);

        /// <summary>
        /// Get TwitterExpression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>Task of TwitterExpression</returns>
        System.Threading.Tasks.Task<TwitterExpression> SocializeExpressionsTwitterExpressionidGetAsync (string expressionId);

        /// <summary>
        /// Get TwitterExpression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>Task of ApiResponse (TwitterExpression)</returns>
        System.Threading.Tasks.Task<ApiResponse<TwitterExpression>> SocializeExpressionsTwitterExpressionidGetAsyncWithHttpInfo (string expressionId);
        
        /// <summary>
        /// Update TwitterExpression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <param name="body">TwitterExpression</param>
        /// <returns>TwitterExpression</returns>
        TwitterExpression SocializeExpressionsTwitterExpressionidPut (string expressionId, TwitterExpression body = null);
  
        /// <summary>
        /// Update TwitterExpression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <param name="body">TwitterExpression</param>
        /// <returns>ApiResponse of TwitterExpression</returns>
        ApiResponse<TwitterExpression> SocializeExpressionsTwitterExpressionidPutWithHttpInfo (string expressionId, TwitterExpression body = null);

        /// <summary>
        /// Update TwitterExpression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <param name="body">TwitterExpression</param>
        /// <returns>Task of TwitterExpression</returns>
        System.Threading.Tasks.Task<TwitterExpression> SocializeExpressionsTwitterExpressionidPutAsync (string expressionId, TwitterExpression body = null);

        /// <summary>
        /// Update TwitterExpression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <param name="body">TwitterExpression</param>
        /// <returns>Task of ApiResponse (TwitterExpression)</returns>
        System.Threading.Tasks.Task<ApiResponse<TwitterExpression>> SocializeExpressionsTwitterExpressionidPutAsyncWithHttpInfo (string expressionId, TwitterExpression body = null);
        
        /// <summary>
        /// Delete TwitterExpression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>string</returns>
        string SocializeExpressionsTwitterExpressionidDelete (string expressionId);
  
        /// <summary>
        /// Delete TwitterExpression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> SocializeExpressionsTwitterExpressionidDeleteWithHttpInfo (string expressionId);

        /// <summary>
        /// Delete TwitterExpression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> SocializeExpressionsTwitterExpressionidDeleteAsync (string expressionId);

        /// <summary>
        /// Delete TwitterExpression.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> SocializeExpressionsTwitterExpressionidDeleteAsyncWithHttpInfo (string expressionId);
        
        /// <summary>
        /// Get all configured gisteners.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="enabled">Enabled Only</param>
        /// <returns>DomainEntityListing</returns>
        DomainEntityListing SocializeGistenersGet (int? pageSize = null, int? pageNumber = null, bool? enabled = null);
  
        /// <summary>
        /// Get all configured gisteners.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="enabled">Enabled Only</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        ApiResponse<DomainEntityListing> SocializeGistenersGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, bool? enabled = null);

        /// <summary>
        /// Get all configured gisteners.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="enabled">Enabled Only</param>
        /// <returns>Task of DomainEntityListing</returns>
        System.Threading.Tasks.Task<DomainEntityListing> SocializeGistenersGetAsync (int? pageSize = null, int? pageNumber = null, bool? enabled = null);

        /// <summary>
        /// Get all configured gisteners.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="enabled">Enabled Only</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> SocializeGistenersGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, bool? enabled = null);
        
        /// <summary>
        /// Create gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Gistener</param>
        /// <param name="preview">Preview Only</param>
        /// <returns>Gistener</returns>
        Gistener SocializeGistenersPost (Gistener body = null, bool? preview = null);
  
        /// <summary>
        /// Create gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Gistener</param>
        /// <param name="preview">Preview Only</param>
        /// <returns>ApiResponse of Gistener</returns>
        ApiResponse<Gistener> SocializeGistenersPostWithHttpInfo (Gistener body = null, bool? preview = null);

        /// <summary>
        /// Create gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Gistener</param>
        /// <param name="preview">Preview Only</param>
        /// <returns>Task of Gistener</returns>
        System.Threading.Tasks.Task<Gistener> SocializeGistenersPostAsync (Gistener body = null, bool? preview = null);

        /// <summary>
        /// Create gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Gistener</param>
        /// <param name="preview">Preview Only</param>
        /// <returns>Task of ApiResponse (Gistener)</returns>
        System.Threading.Tasks.Task<ApiResponse<Gistener>> SocializeGistenersPostAsyncWithHttpInfo (Gistener body = null, bool? preview = null);
        
        /// <summary>
        /// Get gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>Gistener</returns>
        Gistener SocializeGistenersGisteneridGet (string gistenerId);
  
        /// <summary>
        /// Get gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>ApiResponse of Gistener</returns>
        ApiResponse<Gistener> SocializeGistenersGisteneridGetWithHttpInfo (string gistenerId);

        /// <summary>
        /// Get gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>Task of Gistener</returns>
        System.Threading.Tasks.Task<Gistener> SocializeGistenersGisteneridGetAsync (string gistenerId);

        /// <summary>
        /// Get gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>Task of ApiResponse (Gistener)</returns>
        System.Threading.Tasks.Task<ApiResponse<Gistener>> SocializeGistenersGisteneridGetAsyncWithHttpInfo (string gistenerId);
        
        /// <summary>
        /// Update gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="gistenerId">Gistener ID</param>
        /// <param name="body">Gistener</param>
        /// <returns>Gistener</returns>
        Gistener SocializeGistenersGisteneridPut (string gistenerId, Gistener body = null);
  
        /// <summary>
        /// Update gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="gistenerId">Gistener ID</param>
        /// <param name="body">Gistener</param>
        /// <returns>ApiResponse of Gistener</returns>
        ApiResponse<Gistener> SocializeGistenersGisteneridPutWithHttpInfo (string gistenerId, Gistener body = null);

        /// <summary>
        /// Update gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="gistenerId">Gistener ID</param>
        /// <param name="body">Gistener</param>
        /// <returns>Task of Gistener</returns>
        System.Threading.Tasks.Task<Gistener> SocializeGistenersGisteneridPutAsync (string gistenerId, Gistener body = null);

        /// <summary>
        /// Update gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="gistenerId">Gistener ID</param>
        /// <param name="body">Gistener</param>
        /// <returns>Task of ApiResponse (Gistener)</returns>
        System.Threading.Tasks.Task<ApiResponse<Gistener>> SocializeGistenersGisteneridPutAsyncWithHttpInfo (string gistenerId, Gistener body = null);
        
        /// <summary>
        /// Delete gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>string</returns>
        string SocializeGistenersGisteneridDelete (string gistenerId);
  
        /// <summary>
        /// Delete gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> SocializeGistenersGisteneridDeleteWithHttpInfo (string gistenerId);

        /// <summary>
        /// Delete gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> SocializeGistenersGisteneridDeleteAsync (string gistenerId);

        /// <summary>
        /// Delete gistener.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> SocializeGistenersGisteneridDeleteAsyncWithHttpInfo (string gistenerId);
        
        /// <summary>
        /// Get all configured groupTags.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="enabled">Enabled Only</param>
        /// <returns>DomainEntityListing</returns>
        DomainEntityListing SocializeGrouptagsGet (int? pageSize = null, int? pageNumber = null, bool? enabled = null);
  
        /// <summary>
        /// Get all configured groupTags.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="enabled">Enabled Only</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        ApiResponse<DomainEntityListing> SocializeGrouptagsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, bool? enabled = null);

        /// <summary>
        /// Get all configured groupTags.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="enabled">Enabled Only</param>
        /// <returns>Task of DomainEntityListing</returns>
        System.Threading.Tasks.Task<DomainEntityListing> SocializeGrouptagsGetAsync (int? pageSize = null, int? pageNumber = null, bool? enabled = null);

        /// <summary>
        /// Get all configured groupTags.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="enabled">Enabled Only</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> SocializeGrouptagsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, bool? enabled = null);
        
        /// <summary>
        /// Create grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">grouptag</param>
        /// <returns>GroupTag</returns>
        GroupTag SocializeGrouptagsPost (GroupTag body = null);
  
        /// <summary>
        /// Create grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">grouptag</param>
        /// <returns>ApiResponse of GroupTag</returns>
        ApiResponse<GroupTag> SocializeGrouptagsPostWithHttpInfo (GroupTag body = null);

        /// <summary>
        /// Create grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">grouptag</param>
        /// <returns>Task of GroupTag</returns>
        System.Threading.Tasks.Task<GroupTag> SocializeGrouptagsPostAsync (GroupTag body = null);

        /// <summary>
        /// Create grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">grouptag</param>
        /// <returns>Task of ApiResponse (GroupTag)</returns>
        System.Threading.Tasks.Task<ApiResponse<GroupTag>> SocializeGrouptagsPostAsyncWithHttpInfo (GroupTag body = null);
        
        /// <summary>
        /// Get grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>GroupTag</returns>
        GroupTag SocializeGrouptagsGrouptagidGet (string groupTagId);
  
        /// <summary>
        /// Get grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>ApiResponse of GroupTag</returns>
        ApiResponse<GroupTag> SocializeGrouptagsGrouptagidGetWithHttpInfo (string groupTagId);

        /// <summary>
        /// Get grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>Task of GroupTag</returns>
        System.Threading.Tasks.Task<GroupTag> SocializeGrouptagsGrouptagidGetAsync (string groupTagId);

        /// <summary>
        /// Get grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>Task of ApiResponse (GroupTag)</returns>
        System.Threading.Tasks.Task<ApiResponse<GroupTag>> SocializeGrouptagsGrouptagidGetAsyncWithHttpInfo (string groupTagId);
        
        /// <summary>
        /// Update grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="groupTagId">grouptag ID</param>
        /// <param name="body">grouptag</param>
        /// <returns>Gistener</returns>
        Gistener SocializeGrouptagsGrouptagidPut (string groupTagId, GroupTag body = null);
  
        /// <summary>
        /// Update grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="groupTagId">grouptag ID</param>
        /// <param name="body">grouptag</param>
        /// <returns>ApiResponse of Gistener</returns>
        ApiResponse<Gistener> SocializeGrouptagsGrouptagidPutWithHttpInfo (string groupTagId, GroupTag body = null);

        /// <summary>
        /// Update grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="groupTagId">grouptag ID</param>
        /// <param name="body">grouptag</param>
        /// <returns>Task of Gistener</returns>
        System.Threading.Tasks.Task<Gistener> SocializeGrouptagsGrouptagidPutAsync (string groupTagId, GroupTag body = null);

        /// <summary>
        /// Update grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="groupTagId">grouptag ID</param>
        /// <param name="body">grouptag</param>
        /// <returns>Task of ApiResponse (Gistener)</returns>
        System.Threading.Tasks.Task<ApiResponse<Gistener>> SocializeGrouptagsGrouptagidPutAsyncWithHttpInfo (string groupTagId, GroupTag body = null);
        
        /// <summary>
        /// Delete grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>string</returns>
        string SocializeGrouptagsGrouptagidDelete (string groupTagId);
  
        /// <summary>
        /// Delete grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> SocializeGrouptagsGrouptagidDeleteWithHttpInfo (string groupTagId);

        /// <summary>
        /// Delete grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> SocializeGrouptagsGrouptagidDeleteAsync (string groupTagId);

        /// <summary>
        /// Delete grouptag.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> SocializeGrouptagsGrouptagidDeleteAsyncWithHttpInfo (string groupTagId);
        
        /// <summary>
        /// Get all configured publications.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>DomainEntityListing</returns>
        DomainEntityListing SocializePublicationsGet (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get all configured publications.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        ApiResponse<DomainEntityListing> SocializePublicationsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get all configured publications.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainEntityListing</returns>
        System.Threading.Tasks.Task<DomainEntityListing> SocializePublicationsGetAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get all configured publications.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> SocializePublicationsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Create publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Publication</param>
        /// <returns>Publication</returns>
        Publication SocializePublicationsPost (Publication body = null);
  
        /// <summary>
        /// Create publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Publication</param>
        /// <returns>ApiResponse of Publication</returns>
        ApiResponse<Publication> SocializePublicationsPostWithHttpInfo (Publication body = null);

        /// <summary>
        /// Create publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Publication</param>
        /// <returns>Task of Publication</returns>
        System.Threading.Tasks.Task<Publication> SocializePublicationsPostAsync (Publication body = null);

        /// <summary>
        /// Create publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Publication</param>
        /// <returns>Task of ApiResponse (Publication)</returns>
        System.Threading.Tasks.Task<ApiResponse<Publication>> SocializePublicationsPostAsyncWithHttpInfo (Publication body = null);
        
        /// <summary>
        /// Get publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>Publication</returns>
        Publication SocializePublicationsPublicationidGet (string publicationId);
  
        /// <summary>
        /// Get publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>ApiResponse of Publication</returns>
        ApiResponse<Publication> SocializePublicationsPublicationidGetWithHttpInfo (string publicationId);

        /// <summary>
        /// Get publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>Task of Publication</returns>
        System.Threading.Tasks.Task<Publication> SocializePublicationsPublicationidGetAsync (string publicationId);

        /// <summary>
        /// Get publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>Task of ApiResponse (Publication)</returns>
        System.Threading.Tasks.Task<ApiResponse<Publication>> SocializePublicationsPublicationidGetAsyncWithHttpInfo (string publicationId);
        
        /// <summary>
        /// Update publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publicationId">Publication ID</param>
        /// <param name="body">Publication</param>
        /// <returns>Gistener</returns>
        Gistener SocializePublicationsPublicationidPut (string publicationId, Publication body = null);
  
        /// <summary>
        /// Update publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publicationId">Publication ID</param>
        /// <param name="body">Publication</param>
        /// <returns>ApiResponse of Gistener</returns>
        ApiResponse<Gistener> SocializePublicationsPublicationidPutWithHttpInfo (string publicationId, Publication body = null);

        /// <summary>
        /// Update publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publicationId">Publication ID</param>
        /// <param name="body">Publication</param>
        /// <returns>Task of Gistener</returns>
        System.Threading.Tasks.Task<Gistener> SocializePublicationsPublicationidPutAsync (string publicationId, Publication body = null);

        /// <summary>
        /// Update publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publicationId">Publication ID</param>
        /// <param name="body">Publication</param>
        /// <returns>Task of ApiResponse (Gistener)</returns>
        System.Threading.Tasks.Task<ApiResponse<Gistener>> SocializePublicationsPublicationidPutAsyncWithHttpInfo (string publicationId, Publication body = null);
        
        /// <summary>
        /// Delete publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>string</returns>
        string SocializePublicationsPublicationidDelete (string publicationId);
  
        /// <summary>
        /// Delete publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> SocializePublicationsPublicationidDeleteWithHttpInfo (string publicationId);

        /// <summary>
        /// Delete publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> SocializePublicationsPublicationidDeleteAsync (string publicationId);

        /// <summary>
        /// Delete publication.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> SocializePublicationsPublicationidDeleteAsyncWithHttpInfo (string publicationId);
        
        /// <summary>
        /// Get all social accounts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="enabled">Enabled Only</param>
        /// <returns>DomainEntityListing</returns>
        DomainEntityListing SocializeSocialaccountsGet (int? pageSize = null, int? pageNumber = null, bool? enabled = null);
  
        /// <summary>
        /// Get all social accounts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="enabled">Enabled Only</param>
        /// <returns>ApiResponse of DomainEntityListing</returns>
        ApiResponse<DomainEntityListing> SocializeSocialaccountsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, bool? enabled = null);

        /// <summary>
        /// Get all social accounts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="enabled">Enabled Only</param>
        /// <returns>Task of DomainEntityListing</returns>
        System.Threading.Tasks.Task<DomainEntityListing> SocializeSocialaccountsGetAsync (int? pageSize = null, int? pageNumber = null, bool? enabled = null);

        /// <summary>
        /// Get all social accounts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="enabled">Enabled Only</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> SocializeSocialaccountsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, bool? enabled = null);
        
        /// <summary>
        /// Create social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">SocialAccount</param>
        /// <returns>SocialAccount</returns>
        SocialAccount SocializeSocialaccountsPost (SocialAccount body = null);
  
        /// <summary>
        /// Create social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">SocialAccount</param>
        /// <returns>ApiResponse of SocialAccount</returns>
        ApiResponse<SocialAccount> SocializeSocialaccountsPostWithHttpInfo (SocialAccount body = null);

        /// <summary>
        /// Create social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">SocialAccount</param>
        /// <returns>Task of SocialAccount</returns>
        System.Threading.Tasks.Task<SocialAccount> SocializeSocialaccountsPostAsync (SocialAccount body = null);

        /// <summary>
        /// Create social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">SocialAccount</param>
        /// <returns>Task of ApiResponse (SocialAccount)</returns>
        System.Threading.Tasks.Task<ApiResponse<SocialAccount>> SocializeSocialaccountsPostAsyncWithHttpInfo (SocialAccount body = null);
        
        /// <summary>
        /// Get social account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>ApiResponse of SocialAccount</returns>
        ApiResponse<SocialAccount> SocializeSocialaccountsSocialaccountidGetWithHttpInfo (string socialAccountId, bool? enabled);

        /// <summary>
        /// Get social account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>Task of ApiResponse (SocialAccount)</returns>
        System.Threading.Tasks.Task<ApiResponse<SocialAccount>> SocializeSocialaccountsSocialaccountidGetAsyncWithHttpInfo (string socialAccountId, bool? enabled);
        
        /// <summary>
        /// Update social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <param name="body">SocialAccount</param>
        /// <returns>SocialAccount</returns>
        SocialAccount SocializeSocialaccountsSocialaccountidPut (string socialAccountId, bool? enabled, SocialAccount body = null);
  
        /// <summary>
        /// Update social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <param name="body">SocialAccount</param>
        /// <returns>ApiResponse of SocialAccount</returns>
        ApiResponse<SocialAccount> SocializeSocialaccountsSocialaccountidPutWithHttpInfo (string socialAccountId, bool? enabled, SocialAccount body = null);

        /// <summary>
        /// Update social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <param name="body">SocialAccount</param>
        /// <returns>Task of SocialAccount</returns>
        System.Threading.Tasks.Task<SocialAccount> SocializeSocialaccountsSocialaccountidPutAsync (string socialAccountId, bool? enabled, SocialAccount body = null);

        /// <summary>
        /// Update social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <param name="body">SocialAccount</param>
        /// <returns>Task of ApiResponse (SocialAccount)</returns>
        System.Threading.Tasks.Task<ApiResponse<SocialAccount>> SocializeSocialaccountsSocialaccountidPutAsyncWithHttpInfo (string socialAccountId, bool? enabled, SocialAccount body = null);
        
        /// <summary>
        /// Delete social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> SocializeSocialaccountsSocialaccountidDeleteWithHttpInfo (string socialAccountId, bool? enabled);

        /// <summary>
        /// Delete social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> SocializeSocialaccountsSocialaccountidDeleteAsyncWithHttpInfo (string socialAccountId, bool? enabled);
        
        /// <summary>
        /// Enabled/Disable feed for social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>ApiResponse of bool?</returns>
        ApiResponse<bool?> SocializeSocialaccountsSocialaccountidPatchWithHttpInfo (string socialAccountId, bool? enabled);

        /// <summary>
        /// Enabled/Disable feed for social account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>Task of ApiResponse (bool?)</returns>
        System.Threading.Tasks.Task<ApiResponse<bool?>> SocializeSocialaccountsSocialaccountidPatchAsyncWithHttpInfo (string socialAccountId, bool? enabled);
        
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
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>DomainEntityListing</returns>
        public DomainEntityListing SocializeExpressionsPublishedGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> response = SocializeExpressionsPublishedGetWithHttpInfo(pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get all published expressions. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of DomainEntityListing</returns>
        public ApiResponse< DomainEntityListing > SocializeExpressionsPublishedGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/socialize/expressions/published";
    
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
                throw new ApiException (statusCode, "Error calling SocializeExpressionsPublishedGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeExpressionsPublishedGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainEntityListing)));
            
        }
    
        /// <summary>
        /// Get all published expressions. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainEntityListing> SocializeExpressionsPublishedGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> response = await SocializeExpressionsPublishedGetAsyncWithHttpInfo(pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get all published expressions. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> SocializeExpressionsPublishedGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/socialize/expressions/published";
    
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
                throw new ApiException (statusCode, "Error calling SocializeExpressionsPublishedGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeExpressionsPublishedGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainEntityListing)));
            
        }
        
        /// <summary>
        /// Create published expression. 
        /// </summary>
        /// <param name="body">PublishedExpression</param> 
        /// <returns>PublishedExpression</returns>
        public PublishedExpression SocializeExpressionsPublishedPost (PublishedExpression body = null)
        {
             ApiResponse<PublishedExpression> response = SocializeExpressionsPublishedPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create published expression. 
        /// </summary>
        /// <param name="body">PublishedExpression</param> 
        /// <returns>ApiResponse of PublishedExpression</returns>
        public ApiResponse< PublishedExpression > SocializeExpressionsPublishedPostWithHttpInfo (PublishedExpression body = null)
        {
            
    
            var path_ = "/api/v1/socialize/expressions/published";
    
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
                throw new ApiException (statusCode, "Error calling SocializeExpressionsPublishedPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeExpressionsPublishedPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PublishedExpression>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PublishedExpression) Configuration.ApiClient.Deserialize(response, typeof(PublishedExpression)));
            
        }
    
        /// <summary>
        /// Create published expression. 
        /// </summary>
        /// <param name="body">PublishedExpression</param>
        /// <returns>Task of PublishedExpression</returns>
        public async System.Threading.Tasks.Task<PublishedExpression> SocializeExpressionsPublishedPostAsync (PublishedExpression body = null)
        {
             ApiResponse<PublishedExpression> response = await SocializeExpressionsPublishedPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create published expression. 
        /// </summary>
        /// <param name="body">PublishedExpression</param>
        /// <returns>Task of ApiResponse (PublishedExpression)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PublishedExpression>> SocializeExpressionsPublishedPostAsyncWithHttpInfo (PublishedExpression body = null)
        {
            
    
            var path_ = "/api/v1/socialize/expressions/published";
    
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
                throw new ApiException (statusCode, "Error calling SocializeExpressionsPublishedPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeExpressionsPublishedPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PublishedExpression>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PublishedExpression) Configuration.ApiClient.Deserialize(response, typeof(PublishedExpression)));
            
        }
        
        /// <summary>
        /// Get published expression 
        /// </summary>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param> 
        /// <returns>PublishedExpression</returns>
        public PublishedExpression SocializeExpressionsPublishedPublishedexpressionidGet (string publishedExpressionId)
        {
             ApiResponse<PublishedExpression> response = SocializeExpressionsPublishedPublishedexpressionidGetWithHttpInfo(publishedExpressionId);
             return response.Data;
        }

        /// <summary>
        /// Get published expression 
        /// </summary>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param> 
        /// <returns>ApiResponse of PublishedExpression</returns>
        public ApiResponse< PublishedExpression > SocializeExpressionsPublishedPublishedexpressionidGetWithHttpInfo (string publishedExpressionId)
        {
            
            // verify the required parameter 'publishedExpressionId' is set
            if (publishedExpressionId == null) throw new ApiException(400, "Missing required parameter 'publishedExpressionId' when calling SocializeExpressionsPublishedPublishedexpressionidGet");
            
    
            var path_ = "/api/v1/socialize/expressions/published/{publishedExpressionId}";
    
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
            if (publishedExpressionId != null) pathParams.Add("publishedExpressionId", Configuration.ApiClient.ParameterToString(publishedExpressionId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeExpressionsPublishedPublishedexpressionidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeExpressionsPublishedPublishedexpressionidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PublishedExpression>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PublishedExpression) Configuration.ApiClient.Deserialize(response, typeof(PublishedExpression)));
            
        }
    
        /// <summary>
        /// Get published expression 
        /// </summary>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>Task of PublishedExpression</returns>
        public async System.Threading.Tasks.Task<PublishedExpression> SocializeExpressionsPublishedPublishedexpressionidGetAsync (string publishedExpressionId)
        {
             ApiResponse<PublishedExpression> response = await SocializeExpressionsPublishedPublishedexpressionidGetAsyncWithHttpInfo(publishedExpressionId);
             return response.Data;

        }

        /// <summary>
        /// Get published expression 
        /// </summary>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>Task of ApiResponse (PublishedExpression)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PublishedExpression>> SocializeExpressionsPublishedPublishedexpressionidGetAsyncWithHttpInfo (string publishedExpressionId)
        {
            // verify the required parameter 'publishedExpressionId' is set
            if (publishedExpressionId == null) throw new ApiException(400, "Missing required parameter 'publishedExpressionId' when calling SocializeExpressionsPublishedPublishedexpressionidGet");
            
    
            var path_ = "/api/v1/socialize/expressions/published/{publishedExpressionId}";
    
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
            if (publishedExpressionId != null) pathParams.Add("publishedExpressionId", Configuration.ApiClient.ParameterToString(publishedExpressionId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeExpressionsPublishedPublishedexpressionidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeExpressionsPublishedPublishedexpressionidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PublishedExpression>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PublishedExpression) Configuration.ApiClient.Deserialize(response, typeof(PublishedExpression)));
            
        }
        
        /// <summary>
        /// Update published expression. 
        /// </summary>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param> 
        /// <param name="body">PublishedExpression</param> 
        /// <returns>PublishedExpression</returns>
        public PublishedExpression SocializeExpressionsPublishedPublishedexpressionidPut (string publishedExpressionId, PublishedExpression body = null)
        {
             ApiResponse<PublishedExpression> response = SocializeExpressionsPublishedPublishedexpressionidPutWithHttpInfo(publishedExpressionId, body);
             return response.Data;
        }

        /// <summary>
        /// Update published expression. 
        /// </summary>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param> 
        /// <param name="body">PublishedExpression</param> 
        /// <returns>ApiResponse of PublishedExpression</returns>
        public ApiResponse< PublishedExpression > SocializeExpressionsPublishedPublishedexpressionidPutWithHttpInfo (string publishedExpressionId, PublishedExpression body = null)
        {
            
            // verify the required parameter 'publishedExpressionId' is set
            if (publishedExpressionId == null) throw new ApiException(400, "Missing required parameter 'publishedExpressionId' when calling SocializeExpressionsPublishedPublishedexpressionidPut");
            
    
            var path_ = "/api/v1/socialize/expressions/published/{publishedExpressionId}";
    
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
            if (publishedExpressionId != null) pathParams.Add("publishedExpressionId", Configuration.ApiClient.ParameterToString(publishedExpressionId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling SocializeExpressionsPublishedPublishedexpressionidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeExpressionsPublishedPublishedexpressionidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PublishedExpression>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PublishedExpression) Configuration.ApiClient.Deserialize(response, typeof(PublishedExpression)));
            
        }
    
        /// <summary>
        /// Update published expression. 
        /// </summary>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <param name="body">PublishedExpression</param>
        /// <returns>Task of PublishedExpression</returns>
        public async System.Threading.Tasks.Task<PublishedExpression> SocializeExpressionsPublishedPublishedexpressionidPutAsync (string publishedExpressionId, PublishedExpression body = null)
        {
             ApiResponse<PublishedExpression> response = await SocializeExpressionsPublishedPublishedexpressionidPutAsyncWithHttpInfo(publishedExpressionId, body);
             return response.Data;

        }

        /// <summary>
        /// Update published expression. 
        /// </summary>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <param name="body">PublishedExpression</param>
        /// <returns>Task of ApiResponse (PublishedExpression)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PublishedExpression>> SocializeExpressionsPublishedPublishedexpressionidPutAsyncWithHttpInfo (string publishedExpressionId, PublishedExpression body = null)
        {
            // verify the required parameter 'publishedExpressionId' is set
            if (publishedExpressionId == null) throw new ApiException(400, "Missing required parameter 'publishedExpressionId' when calling SocializeExpressionsPublishedPublishedexpressionidPut");
            
    
            var path_ = "/api/v1/socialize/expressions/published/{publishedExpressionId}";
    
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
            if (publishedExpressionId != null) pathParams.Add("publishedExpressionId", Configuration.ApiClient.ParameterToString(publishedExpressionId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling SocializeExpressionsPublishedPublishedexpressionidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeExpressionsPublishedPublishedexpressionidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PublishedExpression>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PublishedExpression) Configuration.ApiClient.Deserialize(response, typeof(PublishedExpression)));
            
        }
        
        /// <summary>
        /// Delete published expression. 
        /// </summary>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param> 
        /// <returns>string</returns>
        public string SocializeExpressionsPublishedPublishedexpressionidDelete (string publishedExpressionId)
        {
             ApiResponse<string> response = SocializeExpressionsPublishedPublishedexpressionidDeleteWithHttpInfo(publishedExpressionId);
             return response.Data;
        }

        /// <summary>
        /// Delete published expression. 
        /// </summary>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > SocializeExpressionsPublishedPublishedexpressionidDeleteWithHttpInfo (string publishedExpressionId)
        {
            
            // verify the required parameter 'publishedExpressionId' is set
            if (publishedExpressionId == null) throw new ApiException(400, "Missing required parameter 'publishedExpressionId' when calling SocializeExpressionsPublishedPublishedexpressionidDelete");
            
    
            var path_ = "/api/v1/socialize/expressions/published/{publishedExpressionId}";
    
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
            if (publishedExpressionId != null) pathParams.Add("publishedExpressionId", Configuration.ApiClient.ParameterToString(publishedExpressionId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeExpressionsPublishedPublishedexpressionidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeExpressionsPublishedPublishedexpressionidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete published expression. 
        /// </summary>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> SocializeExpressionsPublishedPublishedexpressionidDeleteAsync (string publishedExpressionId)
        {
             ApiResponse<string> response = await SocializeExpressionsPublishedPublishedexpressionidDeleteAsyncWithHttpInfo(publishedExpressionId);
             return response.Data;

        }

        /// <summary>
        /// Delete published expression. 
        /// </summary>
        /// <param name="publishedExpressionId">Published TwitterExpression ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> SocializeExpressionsPublishedPublishedexpressionidDeleteAsyncWithHttpInfo (string publishedExpressionId)
        {
            // verify the required parameter 'publishedExpressionId' is set
            if (publishedExpressionId == null) throw new ApiException(400, "Missing required parameter 'publishedExpressionId' when calling SocializeExpressionsPublishedPublishedexpressionidDelete");
            
    
            var path_ = "/api/v1/socialize/expressions/published/{publishedExpressionId}";
    
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
            if (publishedExpressionId != null) pathParams.Add("publishedExpressionId", Configuration.ApiClient.ParameterToString(publishedExpressionId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeExpressionsPublishedPublishedexpressionidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeExpressionsPublishedPublishedexpressionidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get all configured expressions. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>DomainEntityListing</returns>
        public DomainEntityListing SocializeExpressionsTwitterGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> response = SocializeExpressionsTwitterGetWithHttpInfo(pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get all configured expressions. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of DomainEntityListing</returns>
        public ApiResponse< DomainEntityListing > SocializeExpressionsTwitterGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/socialize/expressions/twitter";
    
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
                throw new ApiException (statusCode, "Error calling SocializeExpressionsTwitterGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeExpressionsTwitterGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainEntityListing)));
            
        }
    
        /// <summary>
        /// Get all configured expressions. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainEntityListing> SocializeExpressionsTwitterGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> response = await SocializeExpressionsTwitterGetAsyncWithHttpInfo(pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get all configured expressions. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> SocializeExpressionsTwitterGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/socialize/expressions/twitter";
    
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
                throw new ApiException (statusCode, "Error calling SocializeExpressionsTwitterGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeExpressionsTwitterGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainEntityListing)));
            
        }
        
        /// <summary>
        /// Create twitter expression. 
        /// </summary>
        /// <param name="body">TwitterExpression</param> 
        /// <returns>TwitterExpression</returns>
        public TwitterExpression SocializeExpressionsTwitterPost (TwitterExpression body = null)
        {
             ApiResponse<TwitterExpression> response = SocializeExpressionsTwitterPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create twitter expression. 
        /// </summary>
        /// <param name="body">TwitterExpression</param> 
        /// <returns>ApiResponse of TwitterExpression</returns>
        public ApiResponse< TwitterExpression > SocializeExpressionsTwitterPostWithHttpInfo (TwitterExpression body = null)
        {
            
    
            var path_ = "/api/v1/socialize/expressions/twitter";
    
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
                throw new ApiException (statusCode, "Error calling SocializeExpressionsTwitterPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeExpressionsTwitterPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TwitterExpression>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TwitterExpression) Configuration.ApiClient.Deserialize(response, typeof(TwitterExpression)));
            
        }
    
        /// <summary>
        /// Create twitter expression. 
        /// </summary>
        /// <param name="body">TwitterExpression</param>
        /// <returns>Task of TwitterExpression</returns>
        public async System.Threading.Tasks.Task<TwitterExpression> SocializeExpressionsTwitterPostAsync (TwitterExpression body = null)
        {
             ApiResponse<TwitterExpression> response = await SocializeExpressionsTwitterPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create twitter expression. 
        /// </summary>
        /// <param name="body">TwitterExpression</param>
        /// <returns>Task of ApiResponse (TwitterExpression)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TwitterExpression>> SocializeExpressionsTwitterPostAsyncWithHttpInfo (TwitterExpression body = null)
        {
            
    
            var path_ = "/api/v1/socialize/expressions/twitter";
    
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
                throw new ApiException (statusCode, "Error calling SocializeExpressionsTwitterPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeExpressionsTwitterPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TwitterExpression>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TwitterExpression) Configuration.ApiClient.Deserialize(response, typeof(TwitterExpression)));
            
        }
        
        /// <summary>
        /// Get TwitterExpression. 
        /// </summary>
        /// <param name="expressionId">TwitterExpression ID</param> 
        /// <returns>TwitterExpression</returns>
        public TwitterExpression SocializeExpressionsTwitterExpressionidGet (string expressionId)
        {
             ApiResponse<TwitterExpression> response = SocializeExpressionsTwitterExpressionidGetWithHttpInfo(expressionId);
             return response.Data;
        }

        /// <summary>
        /// Get TwitterExpression. 
        /// </summary>
        /// <param name="expressionId">TwitterExpression ID</param> 
        /// <returns>ApiResponse of TwitterExpression</returns>
        public ApiResponse< TwitterExpression > SocializeExpressionsTwitterExpressionidGetWithHttpInfo (string expressionId)
        {
            
            // verify the required parameter 'expressionId' is set
            if (expressionId == null) throw new ApiException(400, "Missing required parameter 'expressionId' when calling SocializeExpressionsTwitterExpressionidGet");
            
    
            var path_ = "/api/v1/socialize/expressions/twitter/{expressionId}";
    
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
            if (expressionId != null) pathParams.Add("expressionId", Configuration.ApiClient.ParameterToString(expressionId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeExpressionsTwitterExpressionidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeExpressionsTwitterExpressionidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TwitterExpression>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TwitterExpression) Configuration.ApiClient.Deserialize(response, typeof(TwitterExpression)));
            
        }
    
        /// <summary>
        /// Get TwitterExpression. 
        /// </summary>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>Task of TwitterExpression</returns>
        public async System.Threading.Tasks.Task<TwitterExpression> SocializeExpressionsTwitterExpressionidGetAsync (string expressionId)
        {
             ApiResponse<TwitterExpression> response = await SocializeExpressionsTwitterExpressionidGetAsyncWithHttpInfo(expressionId);
             return response.Data;

        }

        /// <summary>
        /// Get TwitterExpression. 
        /// </summary>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>Task of ApiResponse (TwitterExpression)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TwitterExpression>> SocializeExpressionsTwitterExpressionidGetAsyncWithHttpInfo (string expressionId)
        {
            // verify the required parameter 'expressionId' is set
            if (expressionId == null) throw new ApiException(400, "Missing required parameter 'expressionId' when calling SocializeExpressionsTwitterExpressionidGet");
            
    
            var path_ = "/api/v1/socialize/expressions/twitter/{expressionId}";
    
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
            if (expressionId != null) pathParams.Add("expressionId", Configuration.ApiClient.ParameterToString(expressionId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeExpressionsTwitterExpressionidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeExpressionsTwitterExpressionidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TwitterExpression>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TwitterExpression) Configuration.ApiClient.Deserialize(response, typeof(TwitterExpression)));
            
        }
        
        /// <summary>
        /// Update TwitterExpression. 
        /// </summary>
        /// <param name="expressionId">TwitterExpression ID</param> 
        /// <param name="body">TwitterExpression</param> 
        /// <returns>TwitterExpression</returns>
        public TwitterExpression SocializeExpressionsTwitterExpressionidPut (string expressionId, TwitterExpression body = null)
        {
             ApiResponse<TwitterExpression> response = SocializeExpressionsTwitterExpressionidPutWithHttpInfo(expressionId, body);
             return response.Data;
        }

        /// <summary>
        /// Update TwitterExpression. 
        /// </summary>
        /// <param name="expressionId">TwitterExpression ID</param> 
        /// <param name="body">TwitterExpression</param> 
        /// <returns>ApiResponse of TwitterExpression</returns>
        public ApiResponse< TwitterExpression > SocializeExpressionsTwitterExpressionidPutWithHttpInfo (string expressionId, TwitterExpression body = null)
        {
            
            // verify the required parameter 'expressionId' is set
            if (expressionId == null) throw new ApiException(400, "Missing required parameter 'expressionId' when calling SocializeExpressionsTwitterExpressionidPut");
            
    
            var path_ = "/api/v1/socialize/expressions/twitter/{expressionId}";
    
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
            if (expressionId != null) pathParams.Add("expressionId", Configuration.ApiClient.ParameterToString(expressionId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling SocializeExpressionsTwitterExpressionidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeExpressionsTwitterExpressionidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TwitterExpression>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TwitterExpression) Configuration.ApiClient.Deserialize(response, typeof(TwitterExpression)));
            
        }
    
        /// <summary>
        /// Update TwitterExpression. 
        /// </summary>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <param name="body">TwitterExpression</param>
        /// <returns>Task of TwitterExpression</returns>
        public async System.Threading.Tasks.Task<TwitterExpression> SocializeExpressionsTwitterExpressionidPutAsync (string expressionId, TwitterExpression body = null)
        {
             ApiResponse<TwitterExpression> response = await SocializeExpressionsTwitterExpressionidPutAsyncWithHttpInfo(expressionId, body);
             return response.Data;

        }

        /// <summary>
        /// Update TwitterExpression. 
        /// </summary>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <param name="body">TwitterExpression</param>
        /// <returns>Task of ApiResponse (TwitterExpression)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TwitterExpression>> SocializeExpressionsTwitterExpressionidPutAsyncWithHttpInfo (string expressionId, TwitterExpression body = null)
        {
            // verify the required parameter 'expressionId' is set
            if (expressionId == null) throw new ApiException(400, "Missing required parameter 'expressionId' when calling SocializeExpressionsTwitterExpressionidPut");
            
    
            var path_ = "/api/v1/socialize/expressions/twitter/{expressionId}";
    
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
            if (expressionId != null) pathParams.Add("expressionId", Configuration.ApiClient.ParameterToString(expressionId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling SocializeExpressionsTwitterExpressionidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeExpressionsTwitterExpressionidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TwitterExpression>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TwitterExpression) Configuration.ApiClient.Deserialize(response, typeof(TwitterExpression)));
            
        }
        
        /// <summary>
        /// Delete TwitterExpression. 
        /// </summary>
        /// <param name="expressionId">TwitterExpression ID</param> 
        /// <returns>string</returns>
        public string SocializeExpressionsTwitterExpressionidDelete (string expressionId)
        {
             ApiResponse<string> response = SocializeExpressionsTwitterExpressionidDeleteWithHttpInfo(expressionId);
             return response.Data;
        }

        /// <summary>
        /// Delete TwitterExpression. 
        /// </summary>
        /// <param name="expressionId">TwitterExpression ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > SocializeExpressionsTwitterExpressionidDeleteWithHttpInfo (string expressionId)
        {
            
            // verify the required parameter 'expressionId' is set
            if (expressionId == null) throw new ApiException(400, "Missing required parameter 'expressionId' when calling SocializeExpressionsTwitterExpressionidDelete");
            
    
            var path_ = "/api/v1/socialize/expressions/twitter/{expressionId}";
    
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
            if (expressionId != null) pathParams.Add("expressionId", Configuration.ApiClient.ParameterToString(expressionId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeExpressionsTwitterExpressionidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeExpressionsTwitterExpressionidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete TwitterExpression. 
        /// </summary>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> SocializeExpressionsTwitterExpressionidDeleteAsync (string expressionId)
        {
             ApiResponse<string> response = await SocializeExpressionsTwitterExpressionidDeleteAsyncWithHttpInfo(expressionId);
             return response.Data;

        }

        /// <summary>
        /// Delete TwitterExpression. 
        /// </summary>
        /// <param name="expressionId">TwitterExpression ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> SocializeExpressionsTwitterExpressionidDeleteAsyncWithHttpInfo (string expressionId)
        {
            // verify the required parameter 'expressionId' is set
            if (expressionId == null) throw new ApiException(400, "Missing required parameter 'expressionId' when calling SocializeExpressionsTwitterExpressionidDelete");
            
    
            var path_ = "/api/v1/socialize/expressions/twitter/{expressionId}";
    
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
            if (expressionId != null) pathParams.Add("expressionId", Configuration.ApiClient.ParameterToString(expressionId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeExpressionsTwitterExpressionidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeExpressionsTwitterExpressionidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get all configured gisteners. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="enabled">Enabled Only</param> 
        /// <returns>DomainEntityListing</returns>
        public DomainEntityListing SocializeGistenersGet (int? pageSize = null, int? pageNumber = null, bool? enabled = null)
        {
             ApiResponse<DomainEntityListing> response = SocializeGistenersGetWithHttpInfo(pageSize, pageNumber, enabled);
             return response.Data;
        }

        /// <summary>
        /// Get all configured gisteners. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="enabled">Enabled Only</param> 
        /// <returns>ApiResponse of DomainEntityListing</returns>
        public ApiResponse< DomainEntityListing > SocializeGistenersGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, bool? enabled = null)
        {
            
    
            var path_ = "/api/v1/socialize/gisteners";
    
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
            if (enabled != null) queryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeGistenersGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeGistenersGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainEntityListing)));
            
        }
    
        /// <summary>
        /// Get all configured gisteners. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="enabled">Enabled Only</param>
        /// <returns>Task of DomainEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainEntityListing> SocializeGistenersGetAsync (int? pageSize = null, int? pageNumber = null, bool? enabled = null)
        {
             ApiResponse<DomainEntityListing> response = await SocializeGistenersGetAsyncWithHttpInfo(pageSize, pageNumber, enabled);
             return response.Data;

        }

        /// <summary>
        /// Get all configured gisteners. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="enabled">Enabled Only</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> SocializeGistenersGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, bool? enabled = null)
        {
            
    
            var path_ = "/api/v1/socialize/gisteners";
    
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
            if (enabled != null) queryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeGistenersGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeGistenersGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainEntityListing)));
            
        }
        
        /// <summary>
        /// Create gistener. 
        /// </summary>
        /// <param name="body">Gistener</param> 
        /// <param name="preview">Preview Only</param> 
        /// <returns>Gistener</returns>
        public Gistener SocializeGistenersPost (Gistener body = null, bool? preview = null)
        {
             ApiResponse<Gistener> response = SocializeGistenersPostWithHttpInfo(body, preview);
             return response.Data;
        }

        /// <summary>
        /// Create gistener. 
        /// </summary>
        /// <param name="body">Gistener</param> 
        /// <param name="preview">Preview Only</param> 
        /// <returns>ApiResponse of Gistener</returns>
        public ApiResponse< Gistener > SocializeGistenersPostWithHttpInfo (Gistener body = null, bool? preview = null)
        {
            
    
            var path_ = "/api/v1/socialize/gisteners";
    
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
            
            if (preview != null) queryParams.Add("preview", Configuration.ApiClient.ParameterToString(preview)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling SocializeGistenersPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeGistenersPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Gistener>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Gistener) Configuration.ApiClient.Deserialize(response, typeof(Gistener)));
            
        }
    
        /// <summary>
        /// Create gistener. 
        /// </summary>
        /// <param name="body">Gistener</param>
        /// <param name="preview">Preview Only</param>
        /// <returns>Task of Gistener</returns>
        public async System.Threading.Tasks.Task<Gistener> SocializeGistenersPostAsync (Gistener body = null, bool? preview = null)
        {
             ApiResponse<Gistener> response = await SocializeGistenersPostAsyncWithHttpInfo(body, preview);
             return response.Data;

        }

        /// <summary>
        /// Create gistener. 
        /// </summary>
        /// <param name="body">Gistener</param>
        /// <param name="preview">Preview Only</param>
        /// <returns>Task of ApiResponse (Gistener)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Gistener>> SocializeGistenersPostAsyncWithHttpInfo (Gistener body = null, bool? preview = null)
        {
            
    
            var path_ = "/api/v1/socialize/gisteners";
    
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
            
            if (preview != null) queryParams.Add("preview", Configuration.ApiClient.ParameterToString(preview)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling SocializeGistenersPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeGistenersPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Gistener>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Gistener) Configuration.ApiClient.Deserialize(response, typeof(Gistener)));
            
        }
        
        /// <summary>
        /// Get gistener. 
        /// </summary>
        /// <param name="gistenerId">Gistener ID</param> 
        /// <returns>Gistener</returns>
        public Gistener SocializeGistenersGisteneridGet (string gistenerId)
        {
             ApiResponse<Gistener> response = SocializeGistenersGisteneridGetWithHttpInfo(gistenerId);
             return response.Data;
        }

        /// <summary>
        /// Get gistener. 
        /// </summary>
        /// <param name="gistenerId">Gistener ID</param> 
        /// <returns>ApiResponse of Gistener</returns>
        public ApiResponse< Gistener > SocializeGistenersGisteneridGetWithHttpInfo (string gistenerId)
        {
            
            // verify the required parameter 'gistenerId' is set
            if (gistenerId == null) throw new ApiException(400, "Missing required parameter 'gistenerId' when calling SocializeGistenersGisteneridGet");
            
    
            var path_ = "/api/v1/socialize/gisteners/{gistenerId}";
    
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
            if (gistenerId != null) pathParams.Add("gistenerId", Configuration.ApiClient.ParameterToString(gistenerId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeGistenersGisteneridGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeGistenersGisteneridGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Gistener>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Gistener) Configuration.ApiClient.Deserialize(response, typeof(Gistener)));
            
        }
    
        /// <summary>
        /// Get gistener. 
        /// </summary>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>Task of Gistener</returns>
        public async System.Threading.Tasks.Task<Gistener> SocializeGistenersGisteneridGetAsync (string gistenerId)
        {
             ApiResponse<Gistener> response = await SocializeGistenersGisteneridGetAsyncWithHttpInfo(gistenerId);
             return response.Data;

        }

        /// <summary>
        /// Get gistener. 
        /// </summary>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>Task of ApiResponse (Gistener)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Gistener>> SocializeGistenersGisteneridGetAsyncWithHttpInfo (string gistenerId)
        {
            // verify the required parameter 'gistenerId' is set
            if (gistenerId == null) throw new ApiException(400, "Missing required parameter 'gistenerId' when calling SocializeGistenersGisteneridGet");
            
    
            var path_ = "/api/v1/socialize/gisteners/{gistenerId}";
    
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
            if (gistenerId != null) pathParams.Add("gistenerId", Configuration.ApiClient.ParameterToString(gistenerId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeGistenersGisteneridGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeGistenersGisteneridGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Gistener>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Gistener) Configuration.ApiClient.Deserialize(response, typeof(Gistener)));
            
        }
        
        /// <summary>
        /// Update gistener. 
        /// </summary>
        /// <param name="gistenerId">Gistener ID</param> 
        /// <param name="body">Gistener</param> 
        /// <returns>Gistener</returns>
        public Gistener SocializeGistenersGisteneridPut (string gistenerId, Gistener body = null)
        {
             ApiResponse<Gistener> response = SocializeGistenersGisteneridPutWithHttpInfo(gistenerId, body);
             return response.Data;
        }

        /// <summary>
        /// Update gistener. 
        /// </summary>
        /// <param name="gistenerId">Gistener ID</param> 
        /// <param name="body">Gistener</param> 
        /// <returns>ApiResponse of Gistener</returns>
        public ApiResponse< Gistener > SocializeGistenersGisteneridPutWithHttpInfo (string gistenerId, Gistener body = null)
        {
            
            // verify the required parameter 'gistenerId' is set
            if (gistenerId == null) throw new ApiException(400, "Missing required parameter 'gistenerId' when calling SocializeGistenersGisteneridPut");
            
    
            var path_ = "/api/v1/socialize/gisteners/{gistenerId}";
    
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
            if (gistenerId != null) pathParams.Add("gistenerId", Configuration.ApiClient.ParameterToString(gistenerId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling SocializeGistenersGisteneridPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeGistenersGisteneridPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Gistener>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Gistener) Configuration.ApiClient.Deserialize(response, typeof(Gistener)));
            
        }
    
        /// <summary>
        /// Update gistener. 
        /// </summary>
        /// <param name="gistenerId">Gistener ID</param>
        /// <param name="body">Gistener</param>
        /// <returns>Task of Gistener</returns>
        public async System.Threading.Tasks.Task<Gistener> SocializeGistenersGisteneridPutAsync (string gistenerId, Gistener body = null)
        {
             ApiResponse<Gistener> response = await SocializeGistenersGisteneridPutAsyncWithHttpInfo(gistenerId, body);
             return response.Data;

        }

        /// <summary>
        /// Update gistener. 
        /// </summary>
        /// <param name="gistenerId">Gistener ID</param>
        /// <param name="body">Gistener</param>
        /// <returns>Task of ApiResponse (Gistener)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Gistener>> SocializeGistenersGisteneridPutAsyncWithHttpInfo (string gistenerId, Gistener body = null)
        {
            // verify the required parameter 'gistenerId' is set
            if (gistenerId == null) throw new ApiException(400, "Missing required parameter 'gistenerId' when calling SocializeGistenersGisteneridPut");
            
    
            var path_ = "/api/v1/socialize/gisteners/{gistenerId}";
    
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
            if (gistenerId != null) pathParams.Add("gistenerId", Configuration.ApiClient.ParameterToString(gistenerId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling SocializeGistenersGisteneridPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeGistenersGisteneridPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Gistener>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Gistener) Configuration.ApiClient.Deserialize(response, typeof(Gistener)));
            
        }
        
        /// <summary>
        /// Delete gistener. 
        /// </summary>
        /// <param name="gistenerId">Gistener ID</param> 
        /// <returns>string</returns>
        public string SocializeGistenersGisteneridDelete (string gistenerId)
        {
             ApiResponse<string> response = SocializeGistenersGisteneridDeleteWithHttpInfo(gistenerId);
             return response.Data;
        }

        /// <summary>
        /// Delete gistener. 
        /// </summary>
        /// <param name="gistenerId">Gistener ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > SocializeGistenersGisteneridDeleteWithHttpInfo (string gistenerId)
        {
            
            // verify the required parameter 'gistenerId' is set
            if (gistenerId == null) throw new ApiException(400, "Missing required parameter 'gistenerId' when calling SocializeGistenersGisteneridDelete");
            
    
            var path_ = "/api/v1/socialize/gisteners/{gistenerId}";
    
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
            if (gistenerId != null) pathParams.Add("gistenerId", Configuration.ApiClient.ParameterToString(gistenerId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeGistenersGisteneridDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeGistenersGisteneridDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete gistener. 
        /// </summary>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> SocializeGistenersGisteneridDeleteAsync (string gistenerId)
        {
             ApiResponse<string> response = await SocializeGistenersGisteneridDeleteAsyncWithHttpInfo(gistenerId);
             return response.Data;

        }

        /// <summary>
        /// Delete gistener. 
        /// </summary>
        /// <param name="gistenerId">Gistener ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> SocializeGistenersGisteneridDeleteAsyncWithHttpInfo (string gistenerId)
        {
            // verify the required parameter 'gistenerId' is set
            if (gistenerId == null) throw new ApiException(400, "Missing required parameter 'gistenerId' when calling SocializeGistenersGisteneridDelete");
            
    
            var path_ = "/api/v1/socialize/gisteners/{gistenerId}";
    
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
            if (gistenerId != null) pathParams.Add("gistenerId", Configuration.ApiClient.ParameterToString(gistenerId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeGistenersGisteneridDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeGistenersGisteneridDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get all configured groupTags. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="enabled">Enabled Only</param> 
        /// <returns>DomainEntityListing</returns>
        public DomainEntityListing SocializeGrouptagsGet (int? pageSize = null, int? pageNumber = null, bool? enabled = null)
        {
             ApiResponse<DomainEntityListing> response = SocializeGrouptagsGetWithHttpInfo(pageSize, pageNumber, enabled);
             return response.Data;
        }

        /// <summary>
        /// Get all configured groupTags. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="enabled">Enabled Only</param> 
        /// <returns>ApiResponse of DomainEntityListing</returns>
        public ApiResponse< DomainEntityListing > SocializeGrouptagsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, bool? enabled = null)
        {
            
    
            var path_ = "/api/v1/socialize/grouptags";
    
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
            if (enabled != null) queryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeGrouptagsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeGrouptagsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainEntityListing)));
            
        }
    
        /// <summary>
        /// Get all configured groupTags. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="enabled">Enabled Only</param>
        /// <returns>Task of DomainEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainEntityListing> SocializeGrouptagsGetAsync (int? pageSize = null, int? pageNumber = null, bool? enabled = null)
        {
             ApiResponse<DomainEntityListing> response = await SocializeGrouptagsGetAsyncWithHttpInfo(pageSize, pageNumber, enabled);
             return response.Data;

        }

        /// <summary>
        /// Get all configured groupTags. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="enabled">Enabled Only</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> SocializeGrouptagsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, bool? enabled = null)
        {
            
    
            var path_ = "/api/v1/socialize/grouptags";
    
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
            if (enabled != null) queryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeGrouptagsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeGrouptagsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainEntityListing)));
            
        }
        
        /// <summary>
        /// Create grouptag. 
        /// </summary>
        /// <param name="body">grouptag</param> 
        /// <returns>GroupTag</returns>
        public GroupTag SocializeGrouptagsPost (GroupTag body = null)
        {
             ApiResponse<GroupTag> response = SocializeGrouptagsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create grouptag. 
        /// </summary>
        /// <param name="body">grouptag</param> 
        /// <returns>ApiResponse of GroupTag</returns>
        public ApiResponse< GroupTag > SocializeGrouptagsPostWithHttpInfo (GroupTag body = null)
        {
            
    
            var path_ = "/api/v1/socialize/grouptags";
    
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
                throw new ApiException (statusCode, "Error calling SocializeGrouptagsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeGrouptagsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<GroupTag>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GroupTag) Configuration.ApiClient.Deserialize(response, typeof(GroupTag)));
            
        }
    
        /// <summary>
        /// Create grouptag. 
        /// </summary>
        /// <param name="body">grouptag</param>
        /// <returns>Task of GroupTag</returns>
        public async System.Threading.Tasks.Task<GroupTag> SocializeGrouptagsPostAsync (GroupTag body = null)
        {
             ApiResponse<GroupTag> response = await SocializeGrouptagsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create grouptag. 
        /// </summary>
        /// <param name="body">grouptag</param>
        /// <returns>Task of ApiResponse (GroupTag)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GroupTag>> SocializeGrouptagsPostAsyncWithHttpInfo (GroupTag body = null)
        {
            
    
            var path_ = "/api/v1/socialize/grouptags";
    
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
                throw new ApiException (statusCode, "Error calling SocializeGrouptagsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeGrouptagsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<GroupTag>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GroupTag) Configuration.ApiClient.Deserialize(response, typeof(GroupTag)));
            
        }
        
        /// <summary>
        /// Get grouptag. 
        /// </summary>
        /// <param name="groupTagId">grouptag ID</param> 
        /// <returns>GroupTag</returns>
        public GroupTag SocializeGrouptagsGrouptagidGet (string groupTagId)
        {
             ApiResponse<GroupTag> response = SocializeGrouptagsGrouptagidGetWithHttpInfo(groupTagId);
             return response.Data;
        }

        /// <summary>
        /// Get grouptag. 
        /// </summary>
        /// <param name="groupTagId">grouptag ID</param> 
        /// <returns>ApiResponse of GroupTag</returns>
        public ApiResponse< GroupTag > SocializeGrouptagsGrouptagidGetWithHttpInfo (string groupTagId)
        {
            
            // verify the required parameter 'groupTagId' is set
            if (groupTagId == null) throw new ApiException(400, "Missing required parameter 'groupTagId' when calling SocializeGrouptagsGrouptagidGet");
            
    
            var path_ = "/api/v1/socialize/grouptags/{groupTagId}";
    
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
            if (groupTagId != null) pathParams.Add("groupTagId", Configuration.ApiClient.ParameterToString(groupTagId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeGrouptagsGrouptagidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeGrouptagsGrouptagidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<GroupTag>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GroupTag) Configuration.ApiClient.Deserialize(response, typeof(GroupTag)));
            
        }
    
        /// <summary>
        /// Get grouptag. 
        /// </summary>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>Task of GroupTag</returns>
        public async System.Threading.Tasks.Task<GroupTag> SocializeGrouptagsGrouptagidGetAsync (string groupTagId)
        {
             ApiResponse<GroupTag> response = await SocializeGrouptagsGrouptagidGetAsyncWithHttpInfo(groupTagId);
             return response.Data;

        }

        /// <summary>
        /// Get grouptag. 
        /// </summary>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>Task of ApiResponse (GroupTag)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GroupTag>> SocializeGrouptagsGrouptagidGetAsyncWithHttpInfo (string groupTagId)
        {
            // verify the required parameter 'groupTagId' is set
            if (groupTagId == null) throw new ApiException(400, "Missing required parameter 'groupTagId' when calling SocializeGrouptagsGrouptagidGet");
            
    
            var path_ = "/api/v1/socialize/grouptags/{groupTagId}";
    
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
            if (groupTagId != null) pathParams.Add("groupTagId", Configuration.ApiClient.ParameterToString(groupTagId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeGrouptagsGrouptagidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeGrouptagsGrouptagidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<GroupTag>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GroupTag) Configuration.ApiClient.Deserialize(response, typeof(GroupTag)));
            
        }
        
        /// <summary>
        /// Update grouptag. 
        /// </summary>
        /// <param name="groupTagId">grouptag ID</param> 
        /// <param name="body">grouptag</param> 
        /// <returns>Gistener</returns>
        public Gistener SocializeGrouptagsGrouptagidPut (string groupTagId, GroupTag body = null)
        {
             ApiResponse<Gistener> response = SocializeGrouptagsGrouptagidPutWithHttpInfo(groupTagId, body);
             return response.Data;
        }

        /// <summary>
        /// Update grouptag. 
        /// </summary>
        /// <param name="groupTagId">grouptag ID</param> 
        /// <param name="body">grouptag</param> 
        /// <returns>ApiResponse of Gistener</returns>
        public ApiResponse< Gistener > SocializeGrouptagsGrouptagidPutWithHttpInfo (string groupTagId, GroupTag body = null)
        {
            
            // verify the required parameter 'groupTagId' is set
            if (groupTagId == null) throw new ApiException(400, "Missing required parameter 'groupTagId' when calling SocializeGrouptagsGrouptagidPut");
            
    
            var path_ = "/api/v1/socialize/grouptags/{groupTagId}";
    
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
            if (groupTagId != null) pathParams.Add("groupTagId", Configuration.ApiClient.ParameterToString(groupTagId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling SocializeGrouptagsGrouptagidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeGrouptagsGrouptagidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Gistener>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Gistener) Configuration.ApiClient.Deserialize(response, typeof(Gistener)));
            
        }
    
        /// <summary>
        /// Update grouptag. 
        /// </summary>
        /// <param name="groupTagId">grouptag ID</param>
        /// <param name="body">grouptag</param>
        /// <returns>Task of Gistener</returns>
        public async System.Threading.Tasks.Task<Gistener> SocializeGrouptagsGrouptagidPutAsync (string groupTagId, GroupTag body = null)
        {
             ApiResponse<Gistener> response = await SocializeGrouptagsGrouptagidPutAsyncWithHttpInfo(groupTagId, body);
             return response.Data;

        }

        /// <summary>
        /// Update grouptag. 
        /// </summary>
        /// <param name="groupTagId">grouptag ID</param>
        /// <param name="body">grouptag</param>
        /// <returns>Task of ApiResponse (Gistener)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Gistener>> SocializeGrouptagsGrouptagidPutAsyncWithHttpInfo (string groupTagId, GroupTag body = null)
        {
            // verify the required parameter 'groupTagId' is set
            if (groupTagId == null) throw new ApiException(400, "Missing required parameter 'groupTagId' when calling SocializeGrouptagsGrouptagidPut");
            
    
            var path_ = "/api/v1/socialize/grouptags/{groupTagId}";
    
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
            if (groupTagId != null) pathParams.Add("groupTagId", Configuration.ApiClient.ParameterToString(groupTagId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling SocializeGrouptagsGrouptagidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeGrouptagsGrouptagidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Gistener>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Gistener) Configuration.ApiClient.Deserialize(response, typeof(Gistener)));
            
        }
        
        /// <summary>
        /// Delete grouptag. 
        /// </summary>
        /// <param name="groupTagId">grouptag ID</param> 
        /// <returns>string</returns>
        public string SocializeGrouptagsGrouptagidDelete (string groupTagId)
        {
             ApiResponse<string> response = SocializeGrouptagsGrouptagidDeleteWithHttpInfo(groupTagId);
             return response.Data;
        }

        /// <summary>
        /// Delete grouptag. 
        /// </summary>
        /// <param name="groupTagId">grouptag ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > SocializeGrouptagsGrouptagidDeleteWithHttpInfo (string groupTagId)
        {
            
            // verify the required parameter 'groupTagId' is set
            if (groupTagId == null) throw new ApiException(400, "Missing required parameter 'groupTagId' when calling SocializeGrouptagsGrouptagidDelete");
            
    
            var path_ = "/api/v1/socialize/grouptags/{groupTagId}";
    
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
            if (groupTagId != null) pathParams.Add("groupTagId", Configuration.ApiClient.ParameterToString(groupTagId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeGrouptagsGrouptagidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeGrouptagsGrouptagidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete grouptag. 
        /// </summary>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> SocializeGrouptagsGrouptagidDeleteAsync (string groupTagId)
        {
             ApiResponse<string> response = await SocializeGrouptagsGrouptagidDeleteAsyncWithHttpInfo(groupTagId);
             return response.Data;

        }

        /// <summary>
        /// Delete grouptag. 
        /// </summary>
        /// <param name="groupTagId">grouptag ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> SocializeGrouptagsGrouptagidDeleteAsyncWithHttpInfo (string groupTagId)
        {
            // verify the required parameter 'groupTagId' is set
            if (groupTagId == null) throw new ApiException(400, "Missing required parameter 'groupTagId' when calling SocializeGrouptagsGrouptagidDelete");
            
    
            var path_ = "/api/v1/socialize/grouptags/{groupTagId}";
    
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
            if (groupTagId != null) pathParams.Add("groupTagId", Configuration.ApiClient.ParameterToString(groupTagId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeGrouptagsGrouptagidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeGrouptagsGrouptagidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get all configured publications. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>DomainEntityListing</returns>
        public DomainEntityListing SocializePublicationsGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> response = SocializePublicationsGetWithHttpInfo(pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get all configured publications. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of DomainEntityListing</returns>
        public ApiResponse< DomainEntityListing > SocializePublicationsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/socialize/publications";
    
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
                throw new ApiException (statusCode, "Error calling SocializePublicationsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializePublicationsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainEntityListing)));
            
        }
    
        /// <summary>
        /// Get all configured publications. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainEntityListing> SocializePublicationsGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainEntityListing> response = await SocializePublicationsGetAsyncWithHttpInfo(pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get all configured publications. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> SocializePublicationsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/socialize/publications";
    
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
                throw new ApiException (statusCode, "Error calling SocializePublicationsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializePublicationsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainEntityListing)));
            
        }
        
        /// <summary>
        /// Create publication. 
        /// </summary>
        /// <param name="body">Publication</param> 
        /// <returns>Publication</returns>
        public Publication SocializePublicationsPost (Publication body = null)
        {
             ApiResponse<Publication> response = SocializePublicationsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create publication. 
        /// </summary>
        /// <param name="body">Publication</param> 
        /// <returns>ApiResponse of Publication</returns>
        public ApiResponse< Publication > SocializePublicationsPostWithHttpInfo (Publication body = null)
        {
            
    
            var path_ = "/api/v1/socialize/publications";
    
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
                throw new ApiException (statusCode, "Error calling SocializePublicationsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializePublicationsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Publication>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Publication) Configuration.ApiClient.Deserialize(response, typeof(Publication)));
            
        }
    
        /// <summary>
        /// Create publication. 
        /// </summary>
        /// <param name="body">Publication</param>
        /// <returns>Task of Publication</returns>
        public async System.Threading.Tasks.Task<Publication> SocializePublicationsPostAsync (Publication body = null)
        {
             ApiResponse<Publication> response = await SocializePublicationsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create publication. 
        /// </summary>
        /// <param name="body">Publication</param>
        /// <returns>Task of ApiResponse (Publication)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Publication>> SocializePublicationsPostAsyncWithHttpInfo (Publication body = null)
        {
            
    
            var path_ = "/api/v1/socialize/publications";
    
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
                throw new ApiException (statusCode, "Error calling SocializePublicationsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializePublicationsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Publication>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Publication) Configuration.ApiClient.Deserialize(response, typeof(Publication)));
            
        }
        
        /// <summary>
        /// Get publication. 
        /// </summary>
        /// <param name="publicationId">Publication ID</param> 
        /// <returns>Publication</returns>
        public Publication SocializePublicationsPublicationidGet (string publicationId)
        {
             ApiResponse<Publication> response = SocializePublicationsPublicationidGetWithHttpInfo(publicationId);
             return response.Data;
        }

        /// <summary>
        /// Get publication. 
        /// </summary>
        /// <param name="publicationId">Publication ID</param> 
        /// <returns>ApiResponse of Publication</returns>
        public ApiResponse< Publication > SocializePublicationsPublicationidGetWithHttpInfo (string publicationId)
        {
            
            // verify the required parameter 'publicationId' is set
            if (publicationId == null) throw new ApiException(400, "Missing required parameter 'publicationId' when calling SocializePublicationsPublicationidGet");
            
    
            var path_ = "/api/v1/socialize/publications/{publicationId}";
    
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
            if (publicationId != null) pathParams.Add("publicationId", Configuration.ApiClient.ParameterToString(publicationId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializePublicationsPublicationidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializePublicationsPublicationidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Publication>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Publication) Configuration.ApiClient.Deserialize(response, typeof(Publication)));
            
        }
    
        /// <summary>
        /// Get publication. 
        /// </summary>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>Task of Publication</returns>
        public async System.Threading.Tasks.Task<Publication> SocializePublicationsPublicationidGetAsync (string publicationId)
        {
             ApiResponse<Publication> response = await SocializePublicationsPublicationidGetAsyncWithHttpInfo(publicationId);
             return response.Data;

        }

        /// <summary>
        /// Get publication. 
        /// </summary>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>Task of ApiResponse (Publication)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Publication>> SocializePublicationsPublicationidGetAsyncWithHttpInfo (string publicationId)
        {
            // verify the required parameter 'publicationId' is set
            if (publicationId == null) throw new ApiException(400, "Missing required parameter 'publicationId' when calling SocializePublicationsPublicationidGet");
            
    
            var path_ = "/api/v1/socialize/publications/{publicationId}";
    
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
            if (publicationId != null) pathParams.Add("publicationId", Configuration.ApiClient.ParameterToString(publicationId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializePublicationsPublicationidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializePublicationsPublicationidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Publication>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Publication) Configuration.ApiClient.Deserialize(response, typeof(Publication)));
            
        }
        
        /// <summary>
        /// Update publication. 
        /// </summary>
        /// <param name="publicationId">Publication ID</param> 
        /// <param name="body">Publication</param> 
        /// <returns>Gistener</returns>
        public Gistener SocializePublicationsPublicationidPut (string publicationId, Publication body = null)
        {
             ApiResponse<Gistener> response = SocializePublicationsPublicationidPutWithHttpInfo(publicationId, body);
             return response.Data;
        }

        /// <summary>
        /// Update publication. 
        /// </summary>
        /// <param name="publicationId">Publication ID</param> 
        /// <param name="body">Publication</param> 
        /// <returns>ApiResponse of Gistener</returns>
        public ApiResponse< Gistener > SocializePublicationsPublicationidPutWithHttpInfo (string publicationId, Publication body = null)
        {
            
            // verify the required parameter 'publicationId' is set
            if (publicationId == null) throw new ApiException(400, "Missing required parameter 'publicationId' when calling SocializePublicationsPublicationidPut");
            
    
            var path_ = "/api/v1/socialize/publications/{publicationId}";
    
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
            if (publicationId != null) pathParams.Add("publicationId", Configuration.ApiClient.ParameterToString(publicationId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling SocializePublicationsPublicationidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializePublicationsPublicationidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Gistener>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Gistener) Configuration.ApiClient.Deserialize(response, typeof(Gistener)));
            
        }
    
        /// <summary>
        /// Update publication. 
        /// </summary>
        /// <param name="publicationId">Publication ID</param>
        /// <param name="body">Publication</param>
        /// <returns>Task of Gistener</returns>
        public async System.Threading.Tasks.Task<Gistener> SocializePublicationsPublicationidPutAsync (string publicationId, Publication body = null)
        {
             ApiResponse<Gistener> response = await SocializePublicationsPublicationidPutAsyncWithHttpInfo(publicationId, body);
             return response.Data;

        }

        /// <summary>
        /// Update publication. 
        /// </summary>
        /// <param name="publicationId">Publication ID</param>
        /// <param name="body">Publication</param>
        /// <returns>Task of ApiResponse (Gistener)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Gistener>> SocializePublicationsPublicationidPutAsyncWithHttpInfo (string publicationId, Publication body = null)
        {
            // verify the required parameter 'publicationId' is set
            if (publicationId == null) throw new ApiException(400, "Missing required parameter 'publicationId' when calling SocializePublicationsPublicationidPut");
            
    
            var path_ = "/api/v1/socialize/publications/{publicationId}";
    
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
            if (publicationId != null) pathParams.Add("publicationId", Configuration.ApiClient.ParameterToString(publicationId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling SocializePublicationsPublicationidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializePublicationsPublicationidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Gistener>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Gistener) Configuration.ApiClient.Deserialize(response, typeof(Gistener)));
            
        }
        
        /// <summary>
        /// Delete publication. 
        /// </summary>
        /// <param name="publicationId">Publication ID</param> 
        /// <returns>string</returns>
        public string SocializePublicationsPublicationidDelete (string publicationId)
        {
             ApiResponse<string> response = SocializePublicationsPublicationidDeleteWithHttpInfo(publicationId);
             return response.Data;
        }

        /// <summary>
        /// Delete publication. 
        /// </summary>
        /// <param name="publicationId">Publication ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > SocializePublicationsPublicationidDeleteWithHttpInfo (string publicationId)
        {
            
            // verify the required parameter 'publicationId' is set
            if (publicationId == null) throw new ApiException(400, "Missing required parameter 'publicationId' when calling SocializePublicationsPublicationidDelete");
            
    
            var path_ = "/api/v1/socialize/publications/{publicationId}";
    
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
            if (publicationId != null) pathParams.Add("publicationId", Configuration.ApiClient.ParameterToString(publicationId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializePublicationsPublicationidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializePublicationsPublicationidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete publication. 
        /// </summary>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> SocializePublicationsPublicationidDeleteAsync (string publicationId)
        {
             ApiResponse<string> response = await SocializePublicationsPublicationidDeleteAsyncWithHttpInfo(publicationId);
             return response.Data;

        }

        /// <summary>
        /// Delete publication. 
        /// </summary>
        /// <param name="publicationId">Publication ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> SocializePublicationsPublicationidDeleteAsyncWithHttpInfo (string publicationId)
        {
            // verify the required parameter 'publicationId' is set
            if (publicationId == null) throw new ApiException(400, "Missing required parameter 'publicationId' when calling SocializePublicationsPublicationidDelete");
            
    
            var path_ = "/api/v1/socialize/publications/{publicationId}";
    
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
            if (publicationId != null) pathParams.Add("publicationId", Configuration.ApiClient.ParameterToString(publicationId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializePublicationsPublicationidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializePublicationsPublicationidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get all social accounts. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="enabled">Enabled Only</param> 
        /// <returns>DomainEntityListing</returns>
        public DomainEntityListing SocializeSocialaccountsGet (int? pageSize = null, int? pageNumber = null, bool? enabled = null)
        {
             ApiResponse<DomainEntityListing> response = SocializeSocialaccountsGetWithHttpInfo(pageSize, pageNumber, enabled);
             return response.Data;
        }

        /// <summary>
        /// Get all social accounts. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="enabled">Enabled Only</param> 
        /// <returns>ApiResponse of DomainEntityListing</returns>
        public ApiResponse< DomainEntityListing > SocializeSocialaccountsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, bool? enabled = null)
        {
            
    
            var path_ = "/api/v1/socialize/socialaccounts";
    
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
            if (enabled != null) queryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeSocialaccountsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeSocialaccountsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainEntityListing)));
            
        }
    
        /// <summary>
        /// Get all social accounts. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="enabled">Enabled Only</param>
        /// <returns>Task of DomainEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainEntityListing> SocializeSocialaccountsGetAsync (int? pageSize = null, int? pageNumber = null, bool? enabled = null)
        {
             ApiResponse<DomainEntityListing> response = await SocializeSocialaccountsGetAsyncWithHttpInfo(pageSize, pageNumber, enabled);
             return response.Data;

        }

        /// <summary>
        /// Get all social accounts. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="enabled">Enabled Only</param>
        /// <returns>Task of ApiResponse (DomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEntityListing>> SocializeSocialaccountsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, bool? enabled = null)
        {
            
    
            var path_ = "/api/v1/socialize/socialaccounts";
    
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
            if (enabled != null) queryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeSocialaccountsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeSocialaccountsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainEntityListing)));
            
        }
        
        /// <summary>
        /// Create social account. 
        /// </summary>
        /// <param name="body">SocialAccount</param> 
        /// <returns>SocialAccount</returns>
        public SocialAccount SocializeSocialaccountsPost (SocialAccount body = null)
        {
             ApiResponse<SocialAccount> response = SocializeSocialaccountsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create social account. 
        /// </summary>
        /// <param name="body">SocialAccount</param> 
        /// <returns>ApiResponse of SocialAccount</returns>
        public ApiResponse< SocialAccount > SocializeSocialaccountsPostWithHttpInfo (SocialAccount body = null)
        {
            
    
            var path_ = "/api/v1/socialize/socialaccounts";
    
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
                throw new ApiException (statusCode, "Error calling SocializeSocialaccountsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeSocialaccountsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SocialAccount>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SocialAccount) Configuration.ApiClient.Deserialize(response, typeof(SocialAccount)));
            
        }
    
        /// <summary>
        /// Create social account. 
        /// </summary>
        /// <param name="body">SocialAccount</param>
        /// <returns>Task of SocialAccount</returns>
        public async System.Threading.Tasks.Task<SocialAccount> SocializeSocialaccountsPostAsync (SocialAccount body = null)
        {
             ApiResponse<SocialAccount> response = await SocializeSocialaccountsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create social account. 
        /// </summary>
        /// <param name="body">SocialAccount</param>
        /// <returns>Task of ApiResponse (SocialAccount)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SocialAccount>> SocializeSocialaccountsPostAsyncWithHttpInfo (SocialAccount body = null)
        {
            
    
            var path_ = "/api/v1/socialize/socialaccounts";
    
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
                throw new ApiException (statusCode, "Error calling SocializeSocialaccountsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeSocialaccountsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SocialAccount>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SocialAccount) Configuration.ApiClient.Deserialize(response, typeof(SocialAccount)));
            
        }
        
        /// <summary>
        /// Get social account 
        /// </summary>
        /// <param name="socialAccountId">Social Account ID</param> 
        /// <param name="enabled">Streaming Enabled</param> 
        /// <returns>SocialAccount</returns>
        public SocialAccount SocializeSocialaccountsSocialaccountidGet (string socialAccountId, bool? enabled)
        {
             ApiResponse<SocialAccount> response = SocializeSocialaccountsSocialaccountidGetWithHttpInfo(socialAccountId, enabled);
             return response.Data;
        }

        /// <summary>
        /// Get social account 
        /// </summary>
        /// <param name="socialAccountId">Social Account ID</param> 
        /// <param name="enabled">Streaming Enabled</param> 
        /// <returns>ApiResponse of SocialAccount</returns>
        public ApiResponse< SocialAccount > SocializeSocialaccountsSocialaccountidGetWithHttpInfo (string socialAccountId, bool? enabled)
        {
            
            // verify the required parameter 'socialAccountId' is set
            if (socialAccountId == null) throw new ApiException(400, "Missing required parameter 'socialAccountId' when calling SocializeSocialaccountsSocialaccountidGet");
            
            // verify the required parameter 'enabled' is set
            if (enabled == null) throw new ApiException(400, "Missing required parameter 'enabled' when calling SocializeSocialaccountsSocialaccountidGet");
            
    
            var path_ = "/api/v1/socialize/socialaccounts/{socialAccountId}";
    
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
            if (socialAccountId != null) pathParams.Add("socialAccountId", Configuration.ApiClient.ParameterToString(socialAccountId)); // path parameter
            
            if (enabled != null) queryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeSocialaccountsSocialaccountidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeSocialaccountsSocialaccountidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SocialAccount>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SocialAccount) Configuration.ApiClient.Deserialize(response, typeof(SocialAccount)));
            
        }
    
        /// <summary>
        /// Get social account 
        /// </summary>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>Task of SocialAccount</returns>
        public async System.Threading.Tasks.Task<SocialAccount> SocializeSocialaccountsSocialaccountidGetAsync (string socialAccountId, bool? enabled)
        {
             ApiResponse<SocialAccount> response = await SocializeSocialaccountsSocialaccountidGetAsyncWithHttpInfo(socialAccountId, enabled);
             return response.Data;

        }

        /// <summary>
        /// Get social account 
        /// </summary>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>Task of ApiResponse (SocialAccount)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SocialAccount>> SocializeSocialaccountsSocialaccountidGetAsyncWithHttpInfo (string socialAccountId, bool? enabled)
        {
            // verify the required parameter 'socialAccountId' is set
            if (socialAccountId == null) throw new ApiException(400, "Missing required parameter 'socialAccountId' when calling SocializeSocialaccountsSocialaccountidGet");
            // verify the required parameter 'enabled' is set
            if (enabled == null) throw new ApiException(400, "Missing required parameter 'enabled' when calling SocializeSocialaccountsSocialaccountidGet");
            
    
            var path_ = "/api/v1/socialize/socialaccounts/{socialAccountId}";
    
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
            if (socialAccountId != null) pathParams.Add("socialAccountId", Configuration.ApiClient.ParameterToString(socialAccountId)); // path parameter
            
            if (enabled != null) queryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeSocialaccountsSocialaccountidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeSocialaccountsSocialaccountidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SocialAccount>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SocialAccount) Configuration.ApiClient.Deserialize(response, typeof(SocialAccount)));
            
        }
        
        /// <summary>
        /// Update social account. 
        /// </summary>
        /// <param name="socialAccountId">Social Account ID</param> 
        /// <param name="enabled">Streaming Enabled</param> 
        /// <param name="body">SocialAccount</param> 
        /// <returns>SocialAccount</returns>
        public SocialAccount SocializeSocialaccountsSocialaccountidPut (string socialAccountId, bool? enabled, SocialAccount body = null)
        {
             ApiResponse<SocialAccount> response = SocializeSocialaccountsSocialaccountidPutWithHttpInfo(socialAccountId, enabled, body);
             return response.Data;
        }

        /// <summary>
        /// Update social account. 
        /// </summary>
        /// <param name="socialAccountId">Social Account ID</param> 
        /// <param name="enabled">Streaming Enabled</param> 
        /// <param name="body">SocialAccount</param> 
        /// <returns>ApiResponse of SocialAccount</returns>
        public ApiResponse< SocialAccount > SocializeSocialaccountsSocialaccountidPutWithHttpInfo (string socialAccountId, bool? enabled, SocialAccount body = null)
        {
            
            // verify the required parameter 'socialAccountId' is set
            if (socialAccountId == null) throw new ApiException(400, "Missing required parameter 'socialAccountId' when calling SocializeSocialaccountsSocialaccountidPut");
            
            // verify the required parameter 'enabled' is set
            if (enabled == null) throw new ApiException(400, "Missing required parameter 'enabled' when calling SocializeSocialaccountsSocialaccountidPut");
            
    
            var path_ = "/api/v1/socialize/socialaccounts/{socialAccountId}";
    
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
            if (socialAccountId != null) pathParams.Add("socialAccountId", Configuration.ApiClient.ParameterToString(socialAccountId)); // path parameter
            
            if (enabled != null) queryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling SocializeSocialaccountsSocialaccountidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeSocialaccountsSocialaccountidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SocialAccount>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SocialAccount) Configuration.ApiClient.Deserialize(response, typeof(SocialAccount)));
            
        }
    
        /// <summary>
        /// Update social account. 
        /// </summary>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <param name="body">SocialAccount</param>
        /// <returns>Task of SocialAccount</returns>
        public async System.Threading.Tasks.Task<SocialAccount> SocializeSocialaccountsSocialaccountidPutAsync (string socialAccountId, bool? enabled, SocialAccount body = null)
        {
             ApiResponse<SocialAccount> response = await SocializeSocialaccountsSocialaccountidPutAsyncWithHttpInfo(socialAccountId, enabled, body);
             return response.Data;

        }

        /// <summary>
        /// Update social account. 
        /// </summary>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <param name="body">SocialAccount</param>
        /// <returns>Task of ApiResponse (SocialAccount)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SocialAccount>> SocializeSocialaccountsSocialaccountidPutAsyncWithHttpInfo (string socialAccountId, bool? enabled, SocialAccount body = null)
        {
            // verify the required parameter 'socialAccountId' is set
            if (socialAccountId == null) throw new ApiException(400, "Missing required parameter 'socialAccountId' when calling SocializeSocialaccountsSocialaccountidPut");
            // verify the required parameter 'enabled' is set
            if (enabled == null) throw new ApiException(400, "Missing required parameter 'enabled' when calling SocializeSocialaccountsSocialaccountidPut");
            
    
            var path_ = "/api/v1/socialize/socialaccounts/{socialAccountId}";
    
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
            if (socialAccountId != null) pathParams.Add("socialAccountId", Configuration.ApiClient.ParameterToString(socialAccountId)); // path parameter
            
            if (enabled != null) queryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling SocializeSocialaccountsSocialaccountidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeSocialaccountsSocialaccountidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SocialAccount>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SocialAccount) Configuration.ApiClient.Deserialize(response, typeof(SocialAccount)));
            
        }
        
        /// <summary>
        /// Delete social account. 
        /// </summary>
        /// <param name="socialAccountId">Social Account ID</param> 
        /// <param name="enabled">Streaming Enabled</param> 
        /// <returns>string</returns>
        public string SocializeSocialaccountsSocialaccountidDelete (string socialAccountId, bool? enabled)
        {
             ApiResponse<string> response = SocializeSocialaccountsSocialaccountidDeleteWithHttpInfo(socialAccountId, enabled);
             return response.Data;
        }

        /// <summary>
        /// Delete social account. 
        /// </summary>
        /// <param name="socialAccountId">Social Account ID</param> 
        /// <param name="enabled">Streaming Enabled</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > SocializeSocialaccountsSocialaccountidDeleteWithHttpInfo (string socialAccountId, bool? enabled)
        {
            
            // verify the required parameter 'socialAccountId' is set
            if (socialAccountId == null) throw new ApiException(400, "Missing required parameter 'socialAccountId' when calling SocializeSocialaccountsSocialaccountidDelete");
            
            // verify the required parameter 'enabled' is set
            if (enabled == null) throw new ApiException(400, "Missing required parameter 'enabled' when calling SocializeSocialaccountsSocialaccountidDelete");
            
    
            var path_ = "/api/v1/socialize/socialaccounts/{socialAccountId}";
    
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
            if (socialAccountId != null) pathParams.Add("socialAccountId", Configuration.ApiClient.ParameterToString(socialAccountId)); // path parameter
            
            if (enabled != null) queryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeSocialaccountsSocialaccountidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeSocialaccountsSocialaccountidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete social account. 
        /// </summary>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> SocializeSocialaccountsSocialaccountidDeleteAsync (string socialAccountId, bool? enabled)
        {
             ApiResponse<string> response = await SocializeSocialaccountsSocialaccountidDeleteAsyncWithHttpInfo(socialAccountId, enabled);
             return response.Data;

        }

        /// <summary>
        /// Delete social account. 
        /// </summary>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> SocializeSocialaccountsSocialaccountidDeleteAsyncWithHttpInfo (string socialAccountId, bool? enabled)
        {
            // verify the required parameter 'socialAccountId' is set
            if (socialAccountId == null) throw new ApiException(400, "Missing required parameter 'socialAccountId' when calling SocializeSocialaccountsSocialaccountidDelete");
            // verify the required parameter 'enabled' is set
            if (enabled == null) throw new ApiException(400, "Missing required parameter 'enabled' when calling SocializeSocialaccountsSocialaccountidDelete");
            
    
            var path_ = "/api/v1/socialize/socialaccounts/{socialAccountId}";
    
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
            if (socialAccountId != null) pathParams.Add("socialAccountId", Configuration.ApiClient.ParameterToString(socialAccountId)); // path parameter
            
            if (enabled != null) queryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeSocialaccountsSocialaccountidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeSocialaccountsSocialaccountidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Enabled/Disable feed for social account. 
        /// </summary>
        /// <param name="socialAccountId">Social Account ID</param> 
        /// <param name="enabled">Streaming Enabled</param> 
        /// <returns>bool?</returns>
        public bool? SocializeSocialaccountsSocialaccountidPatch (string socialAccountId, bool? enabled)
        {
             ApiResponse<bool?> response = SocializeSocialaccountsSocialaccountidPatchWithHttpInfo(socialAccountId, enabled);
             return response.Data;
        }

        /// <summary>
        /// Enabled/Disable feed for social account. 
        /// </summary>
        /// <param name="socialAccountId">Social Account ID</param> 
        /// <param name="enabled">Streaming Enabled</param> 
        /// <returns>ApiResponse of bool?</returns>
        public ApiResponse< bool? > SocializeSocialaccountsSocialaccountidPatchWithHttpInfo (string socialAccountId, bool? enabled)
        {
            
            // verify the required parameter 'socialAccountId' is set
            if (socialAccountId == null) throw new ApiException(400, "Missing required parameter 'socialAccountId' when calling SocializeSocialaccountsSocialaccountidPatch");
            
            // verify the required parameter 'enabled' is set
            if (enabled == null) throw new ApiException(400, "Missing required parameter 'enabled' when calling SocializeSocialaccountsSocialaccountidPatch");
            
    
            var path_ = "/api/v1/socialize/socialaccounts/{socialAccountId}";
    
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
            if (socialAccountId != null) pathParams.Add("socialAccountId", Configuration.ApiClient.ParameterToString(socialAccountId)); // path parameter
            
            if (enabled != null) queryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeSocialaccountsSocialaccountidPatch: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeSocialaccountsSocialaccountidPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<bool?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (bool?) Configuration.ApiClient.Deserialize(response, typeof(bool?)));
            
        }
    
        /// <summary>
        /// Enabled/Disable feed for social account. 
        /// </summary>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>Task of bool?</returns>
        public async System.Threading.Tasks.Task<bool?> SocializeSocialaccountsSocialaccountidPatchAsync (string socialAccountId, bool? enabled)
        {
             ApiResponse<bool?> response = await SocializeSocialaccountsSocialaccountidPatchAsyncWithHttpInfo(socialAccountId, enabled);
             return response.Data;

        }

        /// <summary>
        /// Enabled/Disable feed for social account. 
        /// </summary>
        /// <param name="socialAccountId">Social Account ID</param>
        /// <param name="enabled">Streaming Enabled</param>
        /// <returns>Task of ApiResponse (bool?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<bool?>> SocializeSocialaccountsSocialaccountidPatchAsyncWithHttpInfo (string socialAccountId, bool? enabled)
        {
            // verify the required parameter 'socialAccountId' is set
            if (socialAccountId == null) throw new ApiException(400, "Missing required parameter 'socialAccountId' when calling SocializeSocialaccountsSocialaccountidPatch");
            // verify the required parameter 'enabled' is set
            if (enabled == null) throw new ApiException(400, "Missing required parameter 'enabled' when calling SocializeSocialaccountsSocialaccountidPatch");
            
    
            var path_ = "/api/v1/socialize/socialaccounts/{socialAccountId}";
    
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
            if (socialAccountId != null) pathParams.Add("socialAccountId", Configuration.ApiClient.ParameterToString(socialAccountId)); // path parameter
            
            if (enabled != null) queryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling SocializeSocialaccountsSocialaccountidPatch: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling SocializeSocialaccountsSocialaccountidPatch: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<bool?>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (bool?) Configuration.ApiClient.Deserialize(response, typeof(bool?)));
            
        }
        
    }
    
}
