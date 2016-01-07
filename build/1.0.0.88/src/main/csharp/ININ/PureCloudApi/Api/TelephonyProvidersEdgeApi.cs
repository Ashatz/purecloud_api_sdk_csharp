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
    public interface ITelephonyProvidersEdgeApi
    {
        
        /// <summary>
        /// Get a listing of line base settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>LineBaseEntityListing</returns>
        LineBaseEntityListing TelephonyProvidersEdgeLinebasesettingsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
  
        /// <summary>
        /// Get a listing of line base settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of LineBaseEntityListing</returns>
        ApiResponse<LineBaseEntityListing> TelephonyProvidersEdgeLinebasesettingsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a listing of line base settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of LineBaseEntityListing</returns>
        System.Threading.Tasks.Task<LineBaseEntityListing> TelephonyProvidersEdgeLinebasesettingsGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a listing of line base settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (LineBaseEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<LineBaseEntityListing>> TelephonyProvidersEdgeLinebasesettingsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Get a line base settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>LineBase</returns>
        LineBase TelephonyProvidersEdgeLinebasesettingsLinebaseidGet (string lineBaseId);
  
        /// <summary>
        /// Get a line base settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>ApiResponse of LineBase</returns>
        ApiResponse<LineBase> TelephonyProvidersEdgeLinebasesettingsLinebaseidGetWithHttpInfo (string lineBaseId);

        /// <summary>
        /// Get a line base settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>Task of LineBase</returns>
        System.Threading.Tasks.Task<LineBase> TelephonyProvidersEdgeLinebasesettingsLinebaseidGetAsync (string lineBaseId);

        /// <summary>
        /// Get a line base settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>Task of ApiResponse (LineBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<LineBase>> TelephonyProvidersEdgeLinebasesettingsLinebaseidGetAsyncWithHttpInfo (string lineBaseId);
        
        /// <summary>
        /// Get a list of Lines
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <returns>LineEntityListing</returns>
        LineEntityListing TelephonyProvidersEdgeLinesGet (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null);
  
        /// <summary>
        /// Get a list of Lines
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <returns>ApiResponse of LineEntityListing</returns>
        ApiResponse<LineEntityListing> TelephonyProvidersEdgeLinesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null);

        /// <summary>
        /// Get a list of Lines
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <returns>Task of LineEntityListing</returns>
        System.Threading.Tasks.Task<LineEntityListing> TelephonyProvidersEdgeLinesGetAsync (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null);

        /// <summary>
        /// Get a list of Lines
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <returns>Task of ApiResponse (LineEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<LineEntityListing>> TelephonyProvidersEdgeLinesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null);
        
        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>Line</returns>
        Line TelephonyProvidersEdgeLinesTemplateGet (string lineBaseSettingsId);
  
        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>ApiResponse of Line</returns>
        ApiResponse<Line> TelephonyProvidersEdgeLinesTemplateGetWithHttpInfo (string lineBaseSettingsId);

        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>Task of Line</returns>
        System.Threading.Tasks.Task<Line> TelephonyProvidersEdgeLinesTemplateGetAsync (string lineBaseSettingsId);

        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>Task of ApiResponse (Line)</returns>
        System.Threading.Tasks.Task<ApiResponse<Line>> TelephonyProvidersEdgeLinesTemplateGetAsyncWithHttpInfo (string lineBaseSettingsId);
        
        /// <summary>
        /// Get a Line by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineId">Line ID</param>
        /// <returns>Line</returns>
        Line TelephonyProvidersEdgeLinesLineidGet (string lineId);
  
        /// <summary>
        /// Get a Line by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineId">Line ID</param>
        /// <returns>ApiResponse of Line</returns>
        ApiResponse<Line> TelephonyProvidersEdgeLinesLineidGetWithHttpInfo (string lineId);

        /// <summary>
        /// Get a Line by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of Line</returns>
        System.Threading.Tasks.Task<Line> TelephonyProvidersEdgeLinesLineidGetAsync (string lineId);

        /// <summary>
        /// Get a Line by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of ApiResponse (Line)</returns>
        System.Threading.Tasks.Task<ApiResponse<Line>> TelephonyProvidersEdgeLinesLineidGetAsyncWithHttpInfo (string lineId);
        
        /// <summary>
        /// Get a list of Phone Base Settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>PhoneBaseEntityListing</returns>
        PhoneBaseEntityListing TelephonyProvidersEdgePhonebasesettingsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
  
        /// <summary>
        /// Get a list of Phone Base Settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of PhoneBaseEntityListing</returns>
        ApiResponse<PhoneBaseEntityListing> TelephonyProvidersEdgePhonebasesettingsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of Phone Base Settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of PhoneBaseEntityListing</returns>
        System.Threading.Tasks.Task<PhoneBaseEntityListing> TelephonyProvidersEdgePhonebasesettingsGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of Phone Base Settings objects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (PhoneBaseEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBaseEntityListing>> TelephonyProvidersEdgePhonebasesettingsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create a new Phone Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>PhoneBase</returns>
        PhoneBase TelephonyProvidersEdgePhonebasesettingsPost (PhoneBase body = null);
  
        /// <summary>
        /// Create a new Phone Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of PhoneBase</returns>
        ApiResponse<PhoneBase> TelephonyProvidersEdgePhonebasesettingsPostWithHttpInfo (PhoneBase body = null);

        /// <summary>
        /// Create a new Phone Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of PhoneBase</returns>
        System.Threading.Tasks.Task<PhoneBase> TelephonyProvidersEdgePhonebasesettingsPostAsync (PhoneBase body = null);

        /// <summary>
        /// Create a new Phone Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBase>> TelephonyProvidersEdgePhonebasesettingsPostAsyncWithHttpInfo (PhoneBase body = null);
        
        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>PhoneMetaBaseEntityListing</returns>
        PhoneMetaBaseEntityListing TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGet (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of PhoneMetaBaseEntityListing</returns>
        ApiResponse<PhoneMetaBaseEntityListing> TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of PhoneMetaBaseEntityListing</returns>
        System.Threading.Tasks.Task<PhoneMetaBaseEntityListing> TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGetAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (PhoneMetaBaseEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneMetaBaseEntityListing>> TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>PhoneBase</returns>
        PhoneBase TelephonyProvidersEdgePhonebasesettingsTemplateGet (string phoneMetabaseId);
  
        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>ApiResponse of PhoneBase</returns>
        ApiResponse<PhoneBase> TelephonyProvidersEdgePhonebasesettingsTemplateGetWithHttpInfo (string phoneMetabaseId);

        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>Task of PhoneBase</returns>
        System.Threading.Tasks.Task<PhoneBase> TelephonyProvidersEdgePhonebasesettingsTemplateGetAsync (string phoneMetabaseId);

        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBase>> TelephonyProvidersEdgePhonebasesettingsTemplateGetAsyncWithHttpInfo (string phoneMetabaseId);
        
        /// <summary>
        /// Get a Phone Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>PhoneBase</returns>
        PhoneBase TelephonyProvidersEdgePhonebasesettingsPhonebaseidGet (string phoneBaseId);
  
        /// <summary>
        /// Get a Phone Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>ApiResponse of PhoneBase</returns>
        ApiResponse<PhoneBase> TelephonyProvidersEdgePhonebasesettingsPhonebaseidGetWithHttpInfo (string phoneBaseId);

        /// <summary>
        /// Get a Phone Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of PhoneBase</returns>
        System.Threading.Tasks.Task<PhoneBase> TelephonyProvidersEdgePhonebasesettingsPhonebaseidGetAsync (string phoneBaseId);

        /// <summary>
        /// Get a Phone Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBase>> TelephonyProvidersEdgePhonebasesettingsPhonebaseidGetAsyncWithHttpInfo (string phoneBaseId);
        
        /// <summary>
        /// Update a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"></param>
        /// <returns>PhoneBase</returns>
        PhoneBase TelephonyProvidersEdgePhonebasesettingsPhonebaseidPut (string phoneBaseId, PhoneBase body = null);
  
        /// <summary>
        /// Update a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of PhoneBase</returns>
        ApiResponse<PhoneBase> TelephonyProvidersEdgePhonebasesettingsPhonebaseidPutWithHttpInfo (string phoneBaseId, PhoneBase body = null);

        /// <summary>
        /// Update a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of PhoneBase</returns>
        System.Threading.Tasks.Task<PhoneBase> TelephonyProvidersEdgePhonebasesettingsPhonebaseidPutAsync (string phoneBaseId, PhoneBase body = null);

        /// <summary>
        /// Update a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneBase>> TelephonyProvidersEdgePhonebasesettingsPhonebaseidPutAsyncWithHttpInfo (string phoneBaseId, PhoneBase body = null);
        
        /// <summary>
        /// Delete a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>string</returns>
        string TelephonyProvidersEdgePhonebasesettingsPhonebaseidDelete (string phoneBaseId);
  
        /// <summary>
        /// Delete a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> TelephonyProvidersEdgePhonebasesettingsPhonebaseidDeleteWithHttpInfo (string phoneBaseId);

        /// <summary>
        /// Delete a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> TelephonyProvidersEdgePhonebasesettingsPhonebaseidDeleteAsync (string phoneBaseId);

        /// <summary>
        /// Delete a Phone Base Settings by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> TelephonyProvidersEdgePhonebasesettingsPhonebaseidDeleteAsyncWithHttpInfo (string phoneBaseId);
        
        /// <summary>
        /// Get a list of Phone Instances
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="phoneBaseSettingsId">Filter by phoneBaseSettings.id</param>
        /// <param name="phoneHardwareId">Filter by phone_hardwareId</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <param name="fields">Fields under properties to get, comma-separated</param>
        /// <returns>PhoneEntityListing</returns>
        PhoneEntityListing TelephonyProvidersEdgePhonesGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null);
  
        /// <summary>
        /// Get a list of Phone Instances
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="phoneBaseSettingsId">Filter by phoneBaseSettings.id</param>
        /// <param name="phoneHardwareId">Filter by phone_hardwareId</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <param name="fields">Fields under properties to get, comma-separated</param>
        /// <returns>ApiResponse of PhoneEntityListing</returns>
        ApiResponse<PhoneEntityListing> TelephonyProvidersEdgePhonesGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null);

        /// <summary>
        /// Get a list of Phone Instances
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="phoneBaseSettingsId">Filter by phoneBaseSettings.id</param>
        /// <param name="phoneHardwareId">Filter by phone_hardwareId</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <param name="fields">Fields under properties to get, comma-separated</param>
        /// <returns>Task of PhoneEntityListing</returns>
        System.Threading.Tasks.Task<PhoneEntityListing> TelephonyProvidersEdgePhonesGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null);

        /// <summary>
        /// Get a list of Phone Instances
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="phoneBaseSettingsId">Filter by phoneBaseSettings.id</param>
        /// <param name="phoneHardwareId">Filter by phone_hardwareId</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <param name="fields">Fields under properties to get, comma-separated</param>
        /// <returns>Task of ApiResponse (PhoneEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneEntityListing>> TelephonyProvidersEdgePhonesGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null);
        
        /// <summary>
        /// Create a new Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Phone</returns>
        Phone TelephonyProvidersEdgePhonesPost (Phone body = null);
  
        /// <summary>
        /// Create a new Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Phone</returns>
        ApiResponse<Phone> TelephonyProvidersEdgePhonesPostWithHttpInfo (Phone body = null);

        /// <summary>
        /// Create a new Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of Phone</returns>
        System.Threading.Tasks.Task<Phone> TelephonyProvidersEdgePhonesPostAsync (Phone body = null);

        /// <summary>
        /// Create a new Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Phone>> TelephonyProvidersEdgePhonesPostAsyncWithHttpInfo (Phone body = null);
        
        /// <summary>
        /// Reboot Multiple Phones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">body</param>
        /// <returns></returns>
        void TelephonyProvidersEdgePhonesRebootPost (PhonesReboot body = null);
  
        /// <summary>
        /// Reboot Multiple Phones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">body</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TelephonyProvidersEdgePhonesRebootPostWithHttpInfo (PhonesReboot body = null);

        /// <summary>
        /// Reboot Multiple Phones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">body</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task TelephonyProvidersEdgePhonesRebootPostAsync (PhonesReboot body = null);

        /// <summary>
        /// Reboot Multiple Phones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">body</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TelephonyProvidersEdgePhonesRebootPostAsyncWithHttpInfo (PhonesReboot body = null);
        
        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>Phone</returns>
        Phone TelephonyProvidersEdgePhonesTemplateGet (string phoneBaseSettingsId);
  
        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>ApiResponse of Phone</returns>
        ApiResponse<Phone> TelephonyProvidersEdgePhonesTemplateGetWithHttpInfo (string phoneBaseSettingsId);

        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>Task of Phone</returns>
        System.Threading.Tasks.Task<Phone> TelephonyProvidersEdgePhonesTemplateGetAsync (string phoneBaseSettingsId);

        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Phone>> TelephonyProvidersEdgePhonesTemplateGetAsyncWithHttpInfo (string phoneBaseSettingsId);
        
        /// <summary>
        /// Get a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Phone</returns>
        Phone TelephonyProvidersEdgePhonesPhoneidGet (string phoneId);
  
        /// <summary>
        /// Get a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>ApiResponse of Phone</returns>
        ApiResponse<Phone> TelephonyProvidersEdgePhonesPhoneidGetWithHttpInfo (string phoneId);

        /// <summary>
        /// Get a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of Phone</returns>
        System.Threading.Tasks.Task<Phone> TelephonyProvidersEdgePhonesPhoneidGetAsync (string phoneId);

        /// <summary>
        /// Get a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Phone>> TelephonyProvidersEdgePhonesPhoneidGetAsyncWithHttpInfo (string phoneId);
        
        /// <summary>
        /// Update a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"></param>
        /// <returns>Phone</returns>
        Phone TelephonyProvidersEdgePhonesPhoneidPut (string phoneId, Phone body = null);
  
        /// <summary>
        /// Update a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Phone</returns>
        ApiResponse<Phone> TelephonyProvidersEdgePhonesPhoneidPutWithHttpInfo (string phoneId, Phone body = null);

        /// <summary>
        /// Update a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Phone</returns>
        System.Threading.Tasks.Task<Phone> TelephonyProvidersEdgePhonesPhoneidPutAsync (string phoneId, Phone body = null);

        /// <summary>
        /// Update a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Phone>> TelephonyProvidersEdgePhonesPhoneidPutAsyncWithHttpInfo (string phoneId, Phone body = null);
        
        /// <summary>
        /// Delete a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>string</returns>
        string TelephonyProvidersEdgePhonesPhoneidDelete (string phoneId);
  
        /// <summary>
        /// Delete a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> TelephonyProvidersEdgePhonesPhoneidDeleteWithHttpInfo (string phoneId);

        /// <summary>
        /// Delete a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> TelephonyProvidersEdgePhonesPhoneidDeleteAsync (string phoneId);

        /// <summary>
        /// Delete a Phone by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> TelephonyProvidersEdgePhonesPhoneidDeleteAsyncWithHttpInfo (string phoneId);
        
        /// <summary>
        /// Reboot a Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone Id</param>
        /// <returns></returns>
        void TelephonyProvidersEdgePhonesPhoneidRebootPost (string phoneId);
  
        /// <summary>
        /// Reboot a Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TelephonyProvidersEdgePhonesPhoneidRebootPostWithHttpInfo (string phoneId);

        /// <summary>
        /// Reboot a Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task TelephonyProvidersEdgePhonesPhoneidRebootPostAsync (string phoneId);

        /// <summary>
        /// Reboot a Phone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TelephonyProvidersEdgePhonesPhoneidRebootPostAsyncWithHttpInfo (string phoneId);
        
        /// <summary>
        /// Get a list of Edge-compatible time zones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>TimeZoneEntityListing</returns>
        TimeZoneEntityListing TelephonyProvidersEdgeTimezonesGet (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get a list of Edge-compatible time zones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of TimeZoneEntityListing</returns>
        ApiResponse<TimeZoneEntityListing> TelephonyProvidersEdgeTimezonesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of Edge-compatible time zones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of TimeZoneEntityListing</returns>
        System.Threading.Tasks.Task<TimeZoneEntityListing> TelephonyProvidersEdgeTimezonesGetAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of Edge-compatible time zones
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (TimeZoneEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeZoneEntityListing>> TelephonyProvidersEdgeTimezonesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get Trunk Base Settings listing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>TrunkBase</returns>
        TrunkBase TelephonyProvidersEdgeTrunkbasesettingsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
  
        /// <summary>
        /// Get Trunk Base Settings listing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get Trunk Base Settings listing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of TrunkBase</returns>
        System.Threading.Tasks.Task<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get Trunk Base Settings listing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> TelephonyProvidersEdgeTrunkbasesettingsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create a Trunk Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>TrunkBase</returns>
        TrunkBase TelephonyProvidersEdgeTrunkbasesettingsPost (TrunkBase body = null);
  
        /// <summary>
        /// Create a Trunk Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsPostWithHttpInfo (TrunkBase body = null);

        /// <summary>
        /// Create a Trunk Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of TrunkBase</returns>
        System.Threading.Tasks.Task<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsPostAsync (TrunkBase body = null);

        /// <summary>
        /// Create a Trunk Base Settings object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> TelephonyProvidersEdgeTrunkbasesettingsPostAsyncWithHttpInfo (TrunkBase body = null);
        
        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="type"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns>TrunkMetabaseEntityListing</returns>
        TrunkMetabaseEntityListing TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGet (string type = null, int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="type"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns>ApiResponse of TrunkMetabaseEntityListing</returns>
        ApiResponse<TrunkMetabaseEntityListing> TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGetWithHttpInfo (string type = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="type"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns>Task of TrunkMetabaseEntityListing</returns>
        System.Threading.Tasks.Task<TrunkMetabaseEntityListing> TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGetAsync (string type = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="type"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns>Task of ApiResponse (TrunkMetabaseEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkMetabaseEntityListing>> TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGetAsyncWithHttpInfo (string type = null, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>TrunkBase</returns>
        TrunkBase TelephonyProvidersEdgeTrunkbasesettingsTemplateGet (string trunkMetabaseId);
  
        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsTemplateGetWithHttpInfo (string trunkMetabaseId);

        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>Task of TrunkBase</returns>
        System.Threading.Tasks.Task<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsTemplateGetAsync (string trunkMetabaseId);

        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> TelephonyProvidersEdgeTrunkbasesettingsTemplateGetAsyncWithHttpInfo (string trunkMetabaseId);
        
        /// <summary>
        /// Get a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>TrunkBase</returns>
        TrunkBase TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGet (string trunkBaseSettingsId);
  
        /// <summary>
        /// Get a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGetWithHttpInfo (string trunkBaseSettingsId);

        /// <summary>
        /// Get a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of TrunkBase</returns>
        System.Threading.Tasks.Task<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGetAsync (string trunkBaseSettingsId);

        /// <summary>
        /// Get a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGetAsyncWithHttpInfo (string trunkBaseSettingsId);
        
        /// <summary>
        /// Update a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"></param>
        /// <returns>TrunkBase</returns>
        TrunkBase TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPut (string trunkBaseSettingsId, TrunkBase body = null);
  
        /// <summary>
        /// Update a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of TrunkBase</returns>
        ApiResponse<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPutWithHttpInfo (string trunkBaseSettingsId, TrunkBase body = null);

        /// <summary>
        /// Update a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of TrunkBase</returns>
        System.Threading.Tasks.Task<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPutAsync (string trunkBaseSettingsId, TrunkBase body = null);

        /// <summary>
        /// Update a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrunkBase>> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPutAsyncWithHttpInfo (string trunkBaseSettingsId, TrunkBase body = null);
        
        /// <summary>
        /// Delete a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>string</returns>
        string TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDelete (string trunkBaseSettingsId);
  
        /// <summary>
        /// Delete a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDeleteWithHttpInfo (string trunkBaseSettingsId);

        /// <summary>
        /// Delete a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDeleteAsync (string trunkBaseSettingsId);

        /// <summary>
        /// Delete a Trunk Base Settings object by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDeleteAsyncWithHttpInfo (string trunkBaseSettingsId);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TelephonyProvidersEdgeApi : ITelephonyProvidersEdgeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TelephonyProvidersEdgeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TelephonyProvidersEdgeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TelephonyProvidersEdgeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TelephonyProvidersEdgeApi(Configuration configuration = null)
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
        /// Get a listing of line base settings objects 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>LineBaseEntityListing</returns>
        public LineBaseEntityListing TelephonyProvidersEdgeLinebasesettingsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<LineBaseEntityListing> response = TelephonyProvidersEdgeLinebasesettingsGetWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Get a listing of line base settings objects 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of LineBaseEntityListing</returns>
        public ApiResponse< LineBaseEntityListing > TelephonyProvidersEdgeLinebasesettingsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/linebasesettings";
    
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeLinebasesettingsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeLinebasesettingsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<LineBaseEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineBaseEntityListing) Configuration.ApiClient.Deserialize(response, typeof(LineBaseEntityListing)));
            
        }
    
        /// <summary>
        /// Get a listing of line base settings objects 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of LineBaseEntityListing</returns>
        public async System.Threading.Tasks.Task<LineBaseEntityListing> TelephonyProvidersEdgeLinebasesettingsGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<LineBaseEntityListing> response = await TelephonyProvidersEdgeLinebasesettingsGetAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Get a listing of line base settings objects 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (LineBaseEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LineBaseEntityListing>> TelephonyProvidersEdgeLinebasesettingsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/linebasesettings";
    
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeLinebasesettingsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeLinebasesettingsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<LineBaseEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineBaseEntityListing) Configuration.ApiClient.Deserialize(response, typeof(LineBaseEntityListing)));
            
        }
        
        /// <summary>
        /// Get a line base settings object by ID 
        /// </summary>
        /// <param name="lineBaseId">Line base ID</param> 
        /// <returns>LineBase</returns>
        public LineBase TelephonyProvidersEdgeLinebasesettingsLinebaseidGet (string lineBaseId)
        {
             ApiResponse<LineBase> response = TelephonyProvidersEdgeLinebasesettingsLinebaseidGetWithHttpInfo(lineBaseId);
             return response.Data;
        }

        /// <summary>
        /// Get a line base settings object by ID 
        /// </summary>
        /// <param name="lineBaseId">Line base ID</param> 
        /// <returns>ApiResponse of LineBase</returns>
        public ApiResponse< LineBase > TelephonyProvidersEdgeLinebasesettingsLinebaseidGetWithHttpInfo (string lineBaseId)
        {
            
            // verify the required parameter 'lineBaseId' is set
            if (lineBaseId == null) throw new ApiException(400, "Missing required parameter 'lineBaseId' when calling TelephonyProvidersEdgeLinebasesettingsLinebaseidGet");
            
    
            var path_ = "/api/v1/telephony/providers/edge/linebasesettings/{lineBaseId}";
    
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
            if (lineBaseId != null) pathParams.Add("lineBaseId", Configuration.ApiClient.ParameterToString(lineBaseId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeLinebasesettingsLinebaseidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeLinebasesettingsLinebaseidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<LineBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineBase) Configuration.ApiClient.Deserialize(response, typeof(LineBase)));
            
        }
    
        /// <summary>
        /// Get a line base settings object by ID 
        /// </summary>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>Task of LineBase</returns>
        public async System.Threading.Tasks.Task<LineBase> TelephonyProvidersEdgeLinebasesettingsLinebaseidGetAsync (string lineBaseId)
        {
             ApiResponse<LineBase> response = await TelephonyProvidersEdgeLinebasesettingsLinebaseidGetAsyncWithHttpInfo(lineBaseId);
             return response.Data;

        }

        /// <summary>
        /// Get a line base settings object by ID 
        /// </summary>
        /// <param name="lineBaseId">Line base ID</param>
        /// <returns>Task of ApiResponse (LineBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LineBase>> TelephonyProvidersEdgeLinebasesettingsLinebaseidGetAsyncWithHttpInfo (string lineBaseId)
        {
            // verify the required parameter 'lineBaseId' is set
            if (lineBaseId == null) throw new ApiException(400, "Missing required parameter 'lineBaseId' when calling TelephonyProvidersEdgeLinebasesettingsLinebaseidGet");
            
    
            var path_ = "/api/v1/telephony/providers/edge/linebasesettings/{lineBaseId}";
    
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
            if (lineBaseId != null) pathParams.Add("lineBaseId", Configuration.ApiClient.ParameterToString(lineBaseId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeLinebasesettingsLinebaseidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeLinebasesettingsLinebaseidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<LineBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineBase) Configuration.ApiClient.Deserialize(response, typeof(LineBase)));
            
        }
        
        /// <summary>
        /// Get a list of Lines 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="expand">Fields to expand in the response, comma-separated</param> 
        /// <returns>LineEntityListing</returns>
        public LineEntityListing TelephonyProvidersEdgeLinesGet (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null)
        {
             ApiResponse<LineEntityListing> response = TelephonyProvidersEdgeLinesGetWithHttpInfo(pageSize, pageNumber, name, sortBy, expand);
             return response.Data;
        }

        /// <summary>
        /// Get a list of Lines 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="expand">Fields to expand in the response, comma-separated</param> 
        /// <returns>ApiResponse of LineEntityListing</returns>
        public ApiResponse< LineEntityListing > TelephonyProvidersEdgeLinesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/lines";
    
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
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeLinesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeLinesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<LineEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineEntityListing) Configuration.ApiClient.Deserialize(response, typeof(LineEntityListing)));
            
        }
    
        /// <summary>
        /// Get a list of Lines 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <returns>Task of LineEntityListing</returns>
        public async System.Threading.Tasks.Task<LineEntityListing> TelephonyProvidersEdgeLinesGetAsync (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null)
        {
             ApiResponse<LineEntityListing> response = await TelephonyProvidersEdgeLinesGetAsyncWithHttpInfo(pageSize, pageNumber, name, sortBy, expand);
             return response.Data;

        }

        /// <summary>
        /// Get a list of Lines 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <returns>Task of ApiResponse (LineEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LineEntityListing>> TelephonyProvidersEdgeLinesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/lines";
    
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
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeLinesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeLinesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<LineEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineEntityListing) Configuration.ApiClient.Deserialize(response, typeof(LineEntityListing)));
            
        }
        
        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance 
        /// </summary>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param> 
        /// <returns>Line</returns>
        public Line TelephonyProvidersEdgeLinesTemplateGet (string lineBaseSettingsId)
        {
             ApiResponse<Line> response = TelephonyProvidersEdgeLinesTemplateGetWithHttpInfo(lineBaseSettingsId);
             return response.Data;
        }

        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance 
        /// </summary>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param> 
        /// <returns>ApiResponse of Line</returns>
        public ApiResponse< Line > TelephonyProvidersEdgeLinesTemplateGetWithHttpInfo (string lineBaseSettingsId)
        {
            
            // verify the required parameter 'lineBaseSettingsId' is set
            if (lineBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'lineBaseSettingsId' when calling TelephonyProvidersEdgeLinesTemplateGet");
            
    
            var path_ = "/api/v1/telephony/providers/edge/lines/template";
    
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
            
            if (lineBaseSettingsId != null) queryParams.Add("lineBaseSettingsId", Configuration.ApiClient.ParameterToString(lineBaseSettingsId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeLinesTemplateGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeLinesTemplateGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Line>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Line) Configuration.ApiClient.Deserialize(response, typeof(Line)));
            
        }
    
        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance 
        /// </summary>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>Task of Line</returns>
        public async System.Threading.Tasks.Task<Line> TelephonyProvidersEdgeLinesTemplateGetAsync (string lineBaseSettingsId)
        {
             ApiResponse<Line> response = await TelephonyProvidersEdgeLinesTemplateGetAsyncWithHttpInfo(lineBaseSettingsId);
             return response.Data;

        }

        /// <summary>
        /// Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance 
        /// </summary>
        /// <param name="lineBaseSettingsId">The id of a Line Base Settings object upon which to base this Line</param>
        /// <returns>Task of ApiResponse (Line)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Line>> TelephonyProvidersEdgeLinesTemplateGetAsyncWithHttpInfo (string lineBaseSettingsId)
        {
            // verify the required parameter 'lineBaseSettingsId' is set
            if (lineBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'lineBaseSettingsId' when calling TelephonyProvidersEdgeLinesTemplateGet");
            
    
            var path_ = "/api/v1/telephony/providers/edge/lines/template";
    
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
            
            if (lineBaseSettingsId != null) queryParams.Add("lineBaseSettingsId", Configuration.ApiClient.ParameterToString(lineBaseSettingsId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeLinesTemplateGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeLinesTemplateGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Line>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Line) Configuration.ApiClient.Deserialize(response, typeof(Line)));
            
        }
        
        /// <summary>
        /// Get a Line by ID 
        /// </summary>
        /// <param name="lineId">Line ID</param> 
        /// <returns>Line</returns>
        public Line TelephonyProvidersEdgeLinesLineidGet (string lineId)
        {
             ApiResponse<Line> response = TelephonyProvidersEdgeLinesLineidGetWithHttpInfo(lineId);
             return response.Data;
        }

        /// <summary>
        /// Get a Line by ID 
        /// </summary>
        /// <param name="lineId">Line ID</param> 
        /// <returns>ApiResponse of Line</returns>
        public ApiResponse< Line > TelephonyProvidersEdgeLinesLineidGetWithHttpInfo (string lineId)
        {
            
            // verify the required parameter 'lineId' is set
            if (lineId == null) throw new ApiException(400, "Missing required parameter 'lineId' when calling TelephonyProvidersEdgeLinesLineidGet");
            
    
            var path_ = "/api/v1/telephony/providers/edge/lines/{lineId}";
    
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
            if (lineId != null) pathParams.Add("lineId", Configuration.ApiClient.ParameterToString(lineId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeLinesLineidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeLinesLineidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Line>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Line) Configuration.ApiClient.Deserialize(response, typeof(Line)));
            
        }
    
        /// <summary>
        /// Get a Line by ID 
        /// </summary>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of Line</returns>
        public async System.Threading.Tasks.Task<Line> TelephonyProvidersEdgeLinesLineidGetAsync (string lineId)
        {
             ApiResponse<Line> response = await TelephonyProvidersEdgeLinesLineidGetAsyncWithHttpInfo(lineId);
             return response.Data;

        }

        /// <summary>
        /// Get a Line by ID 
        /// </summary>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of ApiResponse (Line)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Line>> TelephonyProvidersEdgeLinesLineidGetAsyncWithHttpInfo (string lineId)
        {
            // verify the required parameter 'lineId' is set
            if (lineId == null) throw new ApiException(400, "Missing required parameter 'lineId' when calling TelephonyProvidersEdgeLinesLineidGet");
            
    
            var path_ = "/api/v1/telephony/providers/edge/lines/{lineId}";
    
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
            if (lineId != null) pathParams.Add("lineId", Configuration.ApiClient.ParameterToString(lineId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeLinesLineidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeLinesLineidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Line>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Line) Configuration.ApiClient.Deserialize(response, typeof(Line)));
            
        }
        
        /// <summary>
        /// Get a list of Phone Base Settings objects 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>PhoneBaseEntityListing</returns>
        public PhoneBaseEntityListing TelephonyProvidersEdgePhonebasesettingsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<PhoneBaseEntityListing> response = TelephonyProvidersEdgePhonebasesettingsGetWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Get a list of Phone Base Settings objects 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of PhoneBaseEntityListing</returns>
        public ApiResponse< PhoneBaseEntityListing > TelephonyProvidersEdgePhonebasesettingsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings";
    
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PhoneBaseEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBaseEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PhoneBaseEntityListing)));
            
        }
    
        /// <summary>
        /// Get a list of Phone Base Settings objects 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of PhoneBaseEntityListing</returns>
        public async System.Threading.Tasks.Task<PhoneBaseEntityListing> TelephonyProvidersEdgePhonebasesettingsGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<PhoneBaseEntityListing> response = await TelephonyProvidersEdgePhonebasesettingsGetAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Get a list of Phone Base Settings objects 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (PhoneBaseEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBaseEntityListing>> TelephonyProvidersEdgePhonebasesettingsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings";
    
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PhoneBaseEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBaseEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PhoneBaseEntityListing)));
            
        }
        
        /// <summary>
        /// Create a new Phone Base Settings object 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>PhoneBase</returns>
        public PhoneBase TelephonyProvidersEdgePhonebasesettingsPost (PhoneBase body = null)
        {
             ApiResponse<PhoneBase> response = TelephonyProvidersEdgePhonebasesettingsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a new Phone Base Settings object 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of PhoneBase</returns>
        public ApiResponse< PhoneBase > TelephonyProvidersEdgePhonebasesettingsPostWithHttpInfo (PhoneBase body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings";
    
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PhoneBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(response, typeof(PhoneBase)));
            
        }
    
        /// <summary>
        /// Create a new Phone Base Settings object 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of PhoneBase</returns>
        public async System.Threading.Tasks.Task<PhoneBase> TelephonyProvidersEdgePhonebasesettingsPostAsync (PhoneBase body = null)
        {
             ApiResponse<PhoneBase> response = await TelephonyProvidersEdgePhonebasesettingsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a new Phone Base Settings object 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBase>> TelephonyProvidersEdgePhonebasesettingsPostAsyncWithHttpInfo (PhoneBase body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings";
    
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PhoneBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(response, typeof(PhoneBase)));
            
        }
        
        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>PhoneMetaBaseEntityListing</returns>
        public PhoneMetaBaseEntityListing TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<PhoneMetaBaseEntityListing> response = TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGetWithHttpInfo(pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of PhoneMetaBaseEntityListing</returns>
        public ApiResponse< PhoneMetaBaseEntityListing > TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/availablemetabases";
    
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PhoneMetaBaseEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneMetaBaseEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PhoneMetaBaseEntityListing)));
            
        }
    
        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of PhoneMetaBaseEntityListing</returns>
        public async System.Threading.Tasks.Task<PhoneMetaBaseEntityListing> TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<PhoneMetaBaseEntityListing> response = await TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGetAsyncWithHttpInfo(pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get a list of available makes and models to create a new Phone Base Settings 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (PhoneMetaBaseEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneMetaBaseEntityListing>> TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/availablemetabases";
    
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PhoneMetaBaseEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneMetaBaseEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PhoneMetaBaseEntityListing)));
            
        }
        
        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance 
        /// </summary>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param> 
        /// <returns>PhoneBase</returns>
        public PhoneBase TelephonyProvidersEdgePhonebasesettingsTemplateGet (string phoneMetabaseId)
        {
             ApiResponse<PhoneBase> response = TelephonyProvidersEdgePhonebasesettingsTemplateGetWithHttpInfo(phoneMetabaseId);
             return response.Data;
        }

        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance 
        /// </summary>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param> 
        /// <returns>ApiResponse of PhoneBase</returns>
        public ApiResponse< PhoneBase > TelephonyProvidersEdgePhonebasesettingsTemplateGetWithHttpInfo (string phoneMetabaseId)
        {
            
            // verify the required parameter 'phoneMetabaseId' is set
            if (phoneMetabaseId == null) throw new ApiException(400, "Missing required parameter 'phoneMetabaseId' when calling TelephonyProvidersEdgePhonebasesettingsTemplateGet");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/template";
    
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
            
            if (phoneMetabaseId != null) queryParams.Add("phoneMetabaseId", Configuration.ApiClient.ParameterToString(phoneMetabaseId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsTemplateGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsTemplateGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PhoneBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(response, typeof(PhoneBase)));
            
        }
    
        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance 
        /// </summary>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>Task of PhoneBase</returns>
        public async System.Threading.Tasks.Task<PhoneBase> TelephonyProvidersEdgePhonebasesettingsTemplateGetAsync (string phoneMetabaseId)
        {
             ApiResponse<PhoneBase> response = await TelephonyProvidersEdgePhonebasesettingsTemplateGetAsyncWithHttpInfo(phoneMetabaseId);
             return response.Data;

        }

        /// <summary>
        /// Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance 
        /// </summary>
        /// <param name="phoneMetabaseId">The id of a metabase object upon which to base this Phone Base Settings</param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBase>> TelephonyProvidersEdgePhonebasesettingsTemplateGetAsyncWithHttpInfo (string phoneMetabaseId)
        {
            // verify the required parameter 'phoneMetabaseId' is set
            if (phoneMetabaseId == null) throw new ApiException(400, "Missing required parameter 'phoneMetabaseId' when calling TelephonyProvidersEdgePhonebasesettingsTemplateGet");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/template";
    
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
            
            if (phoneMetabaseId != null) queryParams.Add("phoneMetabaseId", Configuration.ApiClient.ParameterToString(phoneMetabaseId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsTemplateGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsTemplateGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PhoneBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(response, typeof(PhoneBase)));
            
        }
        
        /// <summary>
        /// Get a Phone Base Settings object by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <returns>PhoneBase</returns>
        public PhoneBase TelephonyProvidersEdgePhonebasesettingsPhonebaseidGet (string phoneBaseId)
        {
             ApiResponse<PhoneBase> response = TelephonyProvidersEdgePhonebasesettingsPhonebaseidGetWithHttpInfo(phoneBaseId);
             return response.Data;
        }

        /// <summary>
        /// Get a Phone Base Settings object by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <returns>ApiResponse of PhoneBase</returns>
        public ApiResponse< PhoneBase > TelephonyProvidersEdgePhonebasesettingsPhonebaseidGetWithHttpInfo (string phoneBaseId)
        {
            
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidGet");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId}";
    
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
            if (phoneBaseId != null) pathParams.Add("phoneBaseId", Configuration.ApiClient.ParameterToString(phoneBaseId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PhoneBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(response, typeof(PhoneBase)));
            
        }
    
        /// <summary>
        /// Get a Phone Base Settings object by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of PhoneBase</returns>
        public async System.Threading.Tasks.Task<PhoneBase> TelephonyProvidersEdgePhonebasesettingsPhonebaseidGetAsync (string phoneBaseId)
        {
             ApiResponse<PhoneBase> response = await TelephonyProvidersEdgePhonebasesettingsPhonebaseidGetAsyncWithHttpInfo(phoneBaseId);
             return response.Data;

        }

        /// <summary>
        /// Get a Phone Base Settings object by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBase>> TelephonyProvidersEdgePhonebasesettingsPhonebaseidGetAsyncWithHttpInfo (string phoneBaseId)
        {
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidGet");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId}";
    
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
            if (phoneBaseId != null) pathParams.Add("phoneBaseId", Configuration.ApiClient.ParameterToString(phoneBaseId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PhoneBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(response, typeof(PhoneBase)));
            
        }
        
        /// <summary>
        /// Update a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <param name="body"></param> 
        /// <returns>PhoneBase</returns>
        public PhoneBase TelephonyProvidersEdgePhonebasesettingsPhonebaseidPut (string phoneBaseId, PhoneBase body = null)
        {
             ApiResponse<PhoneBase> response = TelephonyProvidersEdgePhonebasesettingsPhonebaseidPutWithHttpInfo(phoneBaseId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of PhoneBase</returns>
        public ApiResponse< PhoneBase > TelephonyProvidersEdgePhonebasesettingsPhonebaseidPutWithHttpInfo (string phoneBaseId, PhoneBase body = null)
        {
            
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidPut");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId}";
    
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
            if (phoneBaseId != null) pathParams.Add("phoneBaseId", Configuration.ApiClient.ParameterToString(phoneBaseId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PhoneBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(response, typeof(PhoneBase)));
            
        }
    
        /// <summary>
        /// Update a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of PhoneBase</returns>
        public async System.Threading.Tasks.Task<PhoneBase> TelephonyProvidersEdgePhonebasesettingsPhonebaseidPutAsync (string phoneBaseId, PhoneBase body = null)
        {
             ApiResponse<PhoneBase> response = await TelephonyProvidersEdgePhonebasesettingsPhonebaseidPutAsyncWithHttpInfo(phoneBaseId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PhoneBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneBase>> TelephonyProvidersEdgePhonebasesettingsPhonebaseidPutAsyncWithHttpInfo (string phoneBaseId, PhoneBase body = null)
        {
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidPut");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId}";
    
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
            if (phoneBaseId != null) pathParams.Add("phoneBaseId", Configuration.ApiClient.ParameterToString(phoneBaseId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PhoneBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneBase) Configuration.ApiClient.Deserialize(response, typeof(PhoneBase)));
            
        }
        
        /// <summary>
        /// Delete a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <returns>string</returns>
        public string TelephonyProvidersEdgePhonebasesettingsPhonebaseidDelete (string phoneBaseId)
        {
             ApiResponse<string> response = TelephonyProvidersEdgePhonebasesettingsPhonebaseidDeleteWithHttpInfo(phoneBaseId);
             return response.Data;
        }

        /// <summary>
        /// Delete a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > TelephonyProvidersEdgePhonebasesettingsPhonebaseidDeleteWithHttpInfo (string phoneBaseId)
        {
            
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidDelete");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId}";
    
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
            if (phoneBaseId != null) pathParams.Add("phoneBaseId", Configuration.ApiClient.ParameterToString(phoneBaseId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> TelephonyProvidersEdgePhonebasesettingsPhonebaseidDeleteAsync (string phoneBaseId)
        {
             ApiResponse<string> response = await TelephonyProvidersEdgePhonebasesettingsPhonebaseidDeleteAsyncWithHttpInfo(phoneBaseId);
             return response.Data;

        }

        /// <summary>
        /// Delete a Phone Base Settings by ID 
        /// </summary>
        /// <param name="phoneBaseId">Phone base ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> TelephonyProvidersEdgePhonebasesettingsPhonebaseidDeleteAsyncWithHttpInfo (string phoneBaseId)
        {
            // verify the required parameter 'phoneBaseId' is set
            if (phoneBaseId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseId' when calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidDelete");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId}";
    
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
            if (phoneBaseId != null) pathParams.Add("phoneBaseId", Configuration.ApiClient.ParameterToString(phoneBaseId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonebasesettingsPhonebaseidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get a list of Phone Instances 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <param name="siteId">Filter by site.id</param> 
        /// <param name="phoneBaseSettingsId">Filter by phoneBaseSettings.id</param> 
        /// <param name="phoneHardwareId">Filter by phone_hardwareId</param> 
        /// <param name="expand">Fields to expand in the response, comma-separated</param> 
        /// <param name="fields">Fields under properties to get, comma-separated</param> 
        /// <returns>PhoneEntityListing</returns>
        public PhoneEntityListing TelephonyProvidersEdgePhonesGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null)
        {
             ApiResponse<PhoneEntityListing> response = TelephonyProvidersEdgePhonesGetWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder, siteId, phoneBaseSettingsId, phoneHardwareId, expand, fields);
             return response.Data;
        }

        /// <summary>
        /// Get a list of Phone Instances 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <param name="siteId">Filter by site.id</param> 
        /// <param name="phoneBaseSettingsId">Filter by phoneBaseSettings.id</param> 
        /// <param name="phoneHardwareId">Filter by phone_hardwareId</param> 
        /// <param name="expand">Fields to expand in the response, comma-separated</param> 
        /// <param name="fields">Fields under properties to get, comma-separated</param> 
        /// <returns>ApiResponse of PhoneEntityListing</returns>
        public ApiResponse< PhoneEntityListing > TelephonyProvidersEdgePhonesGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones";
    
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
            if (siteId != null) queryParams.Add("site.id", Configuration.ApiClient.ParameterToString(siteId)); // query parameter
            if (phoneBaseSettingsId != null) queryParams.Add("phoneBaseSettings.id", Configuration.ApiClient.ParameterToString(phoneBaseSettingsId)); // query parameter
            if (phoneHardwareId != null) queryParams.Add("phone_hardwareId", Configuration.ApiClient.ParameterToString(phoneHardwareId)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (fields != null) queryParams.Add("fields", Configuration.ApiClient.ParameterToString(fields)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PhoneEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PhoneEntityListing)));
            
        }
    
        /// <summary>
        /// Get a list of Phone Instances 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="phoneBaseSettingsId">Filter by phoneBaseSettings.id</param>
        /// <param name="phoneHardwareId">Filter by phone_hardwareId</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <param name="fields">Fields under properties to get, comma-separated</param>
        /// <returns>Task of PhoneEntityListing</returns>
        public async System.Threading.Tasks.Task<PhoneEntityListing> TelephonyProvidersEdgePhonesGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null)
        {
             ApiResponse<PhoneEntityListing> response = await TelephonyProvidersEdgePhonesGetAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder, siteId, phoneBaseSettingsId, phoneHardwareId, expand, fields);
             return response.Data;

        }

        /// <summary>
        /// Get a list of Phone Instances 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="phoneBaseSettingsId">Filter by phoneBaseSettings.id</param>
        /// <param name="phoneHardwareId">Filter by phone_hardwareId</param>
        /// <param name="expand">Fields to expand in the response, comma-separated</param>
        /// <param name="fields">Fields under properties to get, comma-separated</param>
        /// <returns>Task of ApiResponse (PhoneEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneEntityListing>> TelephonyProvidersEdgePhonesGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones";
    
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
            if (siteId != null) queryParams.Add("site.id", Configuration.ApiClient.ParameterToString(siteId)); // query parameter
            if (phoneBaseSettingsId != null) queryParams.Add("phoneBaseSettings.id", Configuration.ApiClient.ParameterToString(phoneBaseSettingsId)); // query parameter
            if (phoneHardwareId != null) queryParams.Add("phone_hardwareId", Configuration.ApiClient.ParameterToString(phoneHardwareId)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (fields != null) queryParams.Add("fields", Configuration.ApiClient.ParameterToString(fields)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PhoneEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PhoneEntityListing)));
            
        }
        
        /// <summary>
        /// Create a new Phone 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Phone</returns>
        public Phone TelephonyProvidersEdgePhonesPost (Phone body = null)
        {
             ApiResponse<Phone> response = TelephonyProvidersEdgePhonesPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a new Phone 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Phone</returns>
        public ApiResponse< Phone > TelephonyProvidersEdgePhonesPostWithHttpInfo (Phone body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones";
    
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Phone>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(response, typeof(Phone)));
            
        }
    
        /// <summary>
        /// Create a new Phone 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of Phone</returns>
        public async System.Threading.Tasks.Task<Phone> TelephonyProvidersEdgePhonesPostAsync (Phone body = null)
        {
             ApiResponse<Phone> response = await TelephonyProvidersEdgePhonesPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a new Phone 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Phone>> TelephonyProvidersEdgePhonesPostAsyncWithHttpInfo (Phone body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones";
    
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Phone>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(response, typeof(Phone)));
            
        }
        
        /// <summary>
        /// Reboot Multiple Phones 
        /// </summary>
        /// <param name="body">body</param> 
        /// <returns></returns>
        public void TelephonyProvidersEdgePhonesRebootPost (PhonesReboot body = null)
        {
             TelephonyProvidersEdgePhonesRebootPostWithHttpInfo(body);
        }

        /// <summary>
        /// Reboot Multiple Phones 
        /// </summary>
        /// <param name="body">body</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TelephonyProvidersEdgePhonesRebootPostWithHttpInfo (PhonesReboot body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/reboot";
    
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesRebootPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesRebootPost: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Reboot Multiple Phones 
        /// </summary>
        /// <param name="body">body</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task TelephonyProvidersEdgePhonesRebootPostAsync (PhonesReboot body = null)
        {
             await TelephonyProvidersEdgePhonesRebootPostAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Reboot Multiple Phones 
        /// </summary>
        /// <param name="body">body</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> TelephonyProvidersEdgePhonesRebootPostAsyncWithHttpInfo (PhonesReboot body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/reboot";
    
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesRebootPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesRebootPost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance 
        /// </summary>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param> 
        /// <returns>Phone</returns>
        public Phone TelephonyProvidersEdgePhonesTemplateGet (string phoneBaseSettingsId)
        {
             ApiResponse<Phone> response = TelephonyProvidersEdgePhonesTemplateGetWithHttpInfo(phoneBaseSettingsId);
             return response.Data;
        }

        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance 
        /// </summary>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param> 
        /// <returns>ApiResponse of Phone</returns>
        public ApiResponse< Phone > TelephonyProvidersEdgePhonesTemplateGetWithHttpInfo (string phoneBaseSettingsId)
        {
            
            // verify the required parameter 'phoneBaseSettingsId' is set
            if (phoneBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseSettingsId' when calling TelephonyProvidersEdgePhonesTemplateGet");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/template";
    
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
            
            if (phoneBaseSettingsId != null) queryParams.Add("phoneBaseSettingsId", Configuration.ApiClient.ParameterToString(phoneBaseSettingsId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesTemplateGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesTemplateGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Phone>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(response, typeof(Phone)));
            
        }
    
        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance 
        /// </summary>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>Task of Phone</returns>
        public async System.Threading.Tasks.Task<Phone> TelephonyProvidersEdgePhonesTemplateGetAsync (string phoneBaseSettingsId)
        {
             ApiResponse<Phone> response = await TelephonyProvidersEdgePhonesTemplateGetAsyncWithHttpInfo(phoneBaseSettingsId);
             return response.Data;

        }

        /// <summary>
        /// Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance 
        /// </summary>
        /// <param name="phoneBaseSettingsId">The id of a Phone Base Settings object upon which to base this Phone</param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Phone>> TelephonyProvidersEdgePhonesTemplateGetAsyncWithHttpInfo (string phoneBaseSettingsId)
        {
            // verify the required parameter 'phoneBaseSettingsId' is set
            if (phoneBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'phoneBaseSettingsId' when calling TelephonyProvidersEdgePhonesTemplateGet");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/template";
    
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
            
            if (phoneBaseSettingsId != null) queryParams.Add("phoneBaseSettingsId", Configuration.ApiClient.ParameterToString(phoneBaseSettingsId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesTemplateGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesTemplateGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Phone>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(response, typeof(Phone)));
            
        }
        
        /// <summary>
        /// Get a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param> 
        /// <returns>Phone</returns>
        public Phone TelephonyProvidersEdgePhonesPhoneidGet (string phoneId)
        {
             ApiResponse<Phone> response = TelephonyProvidersEdgePhonesPhoneidGetWithHttpInfo(phoneId);
             return response.Data;
        }

        /// <summary>
        /// Get a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param> 
        /// <returns>ApiResponse of Phone</returns>
        public ApiResponse< Phone > TelephonyProvidersEdgePhonesPhoneidGetWithHttpInfo (string phoneId)
        {
            
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgePhonesPhoneidGet");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/{phoneId}";
    
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
            if (phoneId != null) pathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Phone>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(response, typeof(Phone)));
            
        }
    
        /// <summary>
        /// Get a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of Phone</returns>
        public async System.Threading.Tasks.Task<Phone> TelephonyProvidersEdgePhonesPhoneidGetAsync (string phoneId)
        {
             ApiResponse<Phone> response = await TelephonyProvidersEdgePhonesPhoneidGetAsyncWithHttpInfo(phoneId);
             return response.Data;

        }

        /// <summary>
        /// Get a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Phone>> TelephonyProvidersEdgePhonesPhoneidGetAsyncWithHttpInfo (string phoneId)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgePhonesPhoneidGet");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/{phoneId}";
    
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
            if (phoneId != null) pathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Phone>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(response, typeof(Phone)));
            
        }
        
        /// <summary>
        /// Update a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param> 
        /// <param name="body"></param> 
        /// <returns>Phone</returns>
        public Phone TelephonyProvidersEdgePhonesPhoneidPut (string phoneId, Phone body = null)
        {
             ApiResponse<Phone> response = TelephonyProvidersEdgePhonesPhoneidPutWithHttpInfo(phoneId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Phone</returns>
        public ApiResponse< Phone > TelephonyProvidersEdgePhonesPhoneidPutWithHttpInfo (string phoneId, Phone body = null)
        {
            
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgePhonesPhoneidPut");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/{phoneId}";
    
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
            if (phoneId != null) pathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Phone>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(response, typeof(Phone)));
            
        }
    
        /// <summary>
        /// Update a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Phone</returns>
        public async System.Threading.Tasks.Task<Phone> TelephonyProvidersEdgePhonesPhoneidPutAsync (string phoneId, Phone body = null)
        {
             ApiResponse<Phone> response = await TelephonyProvidersEdgePhonesPhoneidPutAsyncWithHttpInfo(phoneId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Phone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Phone>> TelephonyProvidersEdgePhonesPhoneidPutAsyncWithHttpInfo (string phoneId, Phone body = null)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgePhonesPhoneidPut");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/{phoneId}";
    
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
            if (phoneId != null) pathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Phone>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Phone) Configuration.ApiClient.Deserialize(response, typeof(Phone)));
            
        }
        
        /// <summary>
        /// Delete a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param> 
        /// <returns>string</returns>
        public string TelephonyProvidersEdgePhonesPhoneidDelete (string phoneId)
        {
             ApiResponse<string> response = TelephonyProvidersEdgePhonesPhoneidDeleteWithHttpInfo(phoneId);
             return response.Data;
        }

        /// <summary>
        /// Delete a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > TelephonyProvidersEdgePhonesPhoneidDeleteWithHttpInfo (string phoneId)
        {
            
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgePhonesPhoneidDelete");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/{phoneId}";
    
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
            if (phoneId != null) pathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> TelephonyProvidersEdgePhonesPhoneidDeleteAsync (string phoneId)
        {
             ApiResponse<string> response = await TelephonyProvidersEdgePhonesPhoneidDeleteAsyncWithHttpInfo(phoneId);
             return response.Data;

        }

        /// <summary>
        /// Delete a Phone by ID 
        /// </summary>
        /// <param name="phoneId">Phone ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> TelephonyProvidersEdgePhonesPhoneidDeleteAsyncWithHttpInfo (string phoneId)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgePhonesPhoneidDelete");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/{phoneId}";
    
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
            if (phoneId != null) pathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Reboot a Phone 
        /// </summary>
        /// <param name="phoneId">Phone Id</param> 
        /// <returns></returns>
        public void TelephonyProvidersEdgePhonesPhoneidRebootPost (string phoneId)
        {
             TelephonyProvidersEdgePhonesPhoneidRebootPostWithHttpInfo(phoneId);
        }

        /// <summary>
        /// Reboot a Phone 
        /// </summary>
        /// <param name="phoneId">Phone Id</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TelephonyProvidersEdgePhonesPhoneidRebootPostWithHttpInfo (string phoneId)
        {
            
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgePhonesPhoneidRebootPost");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/{phoneId}/reboot";
    
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
            if (phoneId != null) pathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidRebootPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidRebootPost: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Reboot a Phone 
        /// </summary>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task TelephonyProvidersEdgePhonesPhoneidRebootPostAsync (string phoneId)
        {
             await TelephonyProvidersEdgePhonesPhoneidRebootPostAsyncWithHttpInfo(phoneId);

        }

        /// <summary>
        /// Reboot a Phone 
        /// </summary>
        /// <param name="phoneId">Phone Id</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> TelephonyProvidersEdgePhonesPhoneidRebootPostAsyncWithHttpInfo (string phoneId)
        {
            // verify the required parameter 'phoneId' is set
            if (phoneId == null) throw new ApiException(400, "Missing required parameter 'phoneId' when calling TelephonyProvidersEdgePhonesPhoneidRebootPost");
            
    
            var path_ = "/api/v1/telephony/providers/edge/phones/{phoneId}/reboot";
    
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
            if (phoneId != null) pathParams.Add("phoneId", Configuration.ApiClient.ParameterToString(phoneId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidRebootPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgePhonesPhoneidRebootPost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a list of Edge-compatible time zones 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>TimeZoneEntityListing</returns>
        public TimeZoneEntityListing TelephonyProvidersEdgeTimezonesGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TimeZoneEntityListing> response = TelephonyProvidersEdgeTimezonesGetWithHttpInfo(pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get a list of Edge-compatible time zones 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of TimeZoneEntityListing</returns>
        public ApiResponse< TimeZoneEntityListing > TelephonyProvidersEdgeTimezonesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/timezones";
    
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTimezonesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTimezonesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TimeZoneEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TimeZoneEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TimeZoneEntityListing)));
            
        }
    
        /// <summary>
        /// Get a list of Edge-compatible time zones 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of TimeZoneEntityListing</returns>
        public async System.Threading.Tasks.Task<TimeZoneEntityListing> TelephonyProvidersEdgeTimezonesGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TimeZoneEntityListing> response = await TelephonyProvidersEdgeTimezonesGetAsyncWithHttpInfo(pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get a list of Edge-compatible time zones 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (TimeZoneEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimeZoneEntityListing>> TelephonyProvidersEdgeTimezonesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/timezones";
    
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTimezonesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTimezonesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TimeZoneEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TimeZoneEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TimeZoneEntityListing)));
            
        }
        
        /// <summary>
        /// Get Trunk Base Settings listing 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>TrunkBase</returns>
        public TrunkBase TelephonyProvidersEdgeTrunkbasesettingsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<TrunkBase> response = TelephonyProvidersEdgeTrunkbasesettingsGetWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Get Trunk Base Settings listing 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Value by which to sort</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > TelephonyProvidersEdgeTrunkbasesettingsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings";
    
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
    
        /// <summary>
        /// Get Trunk Base Settings listing 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of TrunkBase</returns>
        public async System.Threading.Tasks.Task<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<TrunkBase> response = await TelephonyProvidersEdgeTrunkbasesettingsGetAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Get Trunk Base Settings listing 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Value by which to sort</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> TelephonyProvidersEdgeTrunkbasesettingsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings";
    
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
        
        /// <summary>
        /// Create a Trunk Base Settings object 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>TrunkBase</returns>
        public TrunkBase TelephonyProvidersEdgeTrunkbasesettingsPost (TrunkBase body = null)
        {
             ApiResponse<TrunkBase> response = TelephonyProvidersEdgeTrunkbasesettingsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a Trunk Base Settings object 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > TelephonyProvidersEdgeTrunkbasesettingsPostWithHttpInfo (TrunkBase body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings";
    
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
    
        /// <summary>
        /// Create a Trunk Base Settings object 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of TrunkBase</returns>
        public async System.Threading.Tasks.Task<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsPostAsync (TrunkBase body = null)
        {
             ApiResponse<TrunkBase> response = await TelephonyProvidersEdgeTrunkbasesettingsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a Trunk Base Settings object 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> TelephonyProvidersEdgeTrunkbasesettingsPostAsyncWithHttpInfo (TrunkBase body = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings";
    
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
        
        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings 
        /// </summary>
        /// <param name="type"></param> 
        /// <param name="pageSize"></param> 
        /// <param name="pageNumber"></param> 
        /// <returns>TrunkMetabaseEntityListing</returns>
        public TrunkMetabaseEntityListing TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGet (string type = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TrunkMetabaseEntityListing> response = TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGetWithHttpInfo(type, pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings 
        /// </summary>
        /// <param name="type"></param> 
        /// <param name="pageSize"></param> 
        /// <param name="pageNumber"></param> 
        /// <returns>ApiResponse of TrunkMetabaseEntityListing</returns>
        public ApiResponse< TrunkMetabaseEntityListing > TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGetWithHttpInfo (string type = null, int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/availablemetabases";
    
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TrunkMetabaseEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkMetabaseEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TrunkMetabaseEntityListing)));
            
        }
    
        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns>Task of TrunkMetabaseEntityListing</returns>
        public async System.Threading.Tasks.Task<TrunkMetabaseEntityListing> TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGetAsync (string type = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<TrunkMetabaseEntityListing> response = await TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGetAsyncWithHttpInfo(type, pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get a list of available makes and models to create a new Trunk Base Settings 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns>Task of ApiResponse (TrunkMetabaseEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkMetabaseEntityListing>> TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGetAsyncWithHttpInfo (string type = null, int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/availablemetabases";
    
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TrunkMetabaseEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkMetabaseEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TrunkMetabaseEntityListing)));
            
        }
        
        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance 
        /// </summary>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param> 
        /// <returns>TrunkBase</returns>
        public TrunkBase TelephonyProvidersEdgeTrunkbasesettingsTemplateGet (string trunkMetabaseId)
        {
             ApiResponse<TrunkBase> response = TelephonyProvidersEdgeTrunkbasesettingsTemplateGetWithHttpInfo(trunkMetabaseId);
             return response.Data;
        }

        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance 
        /// </summary>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param> 
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > TelephonyProvidersEdgeTrunkbasesettingsTemplateGetWithHttpInfo (string trunkMetabaseId)
        {
            
            // verify the required parameter 'trunkMetabaseId' is set
            if (trunkMetabaseId == null) throw new ApiException(400, "Missing required parameter 'trunkMetabaseId' when calling TelephonyProvidersEdgeTrunkbasesettingsTemplateGet");
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/template";
    
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
            
            if (trunkMetabaseId != null) queryParams.Add("trunkMetabaseId", Configuration.ApiClient.ParameterToString(trunkMetabaseId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTemplateGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTemplateGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
    
        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance 
        /// </summary>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>Task of TrunkBase</returns>
        public async System.Threading.Tasks.Task<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsTemplateGetAsync (string trunkMetabaseId)
        {
             ApiResponse<TrunkBase> response = await TelephonyProvidersEdgeTrunkbasesettingsTemplateGetAsyncWithHttpInfo(trunkMetabaseId);
             return response.Data;

        }

        /// <summary>
        /// Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance 
        /// </summary>
        /// <param name="trunkMetabaseId">The id of a metabase object upon which to base this Trunk Base Settings</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> TelephonyProvidersEdgeTrunkbasesettingsTemplateGetAsyncWithHttpInfo (string trunkMetabaseId)
        {
            // verify the required parameter 'trunkMetabaseId' is set
            if (trunkMetabaseId == null) throw new ApiException(400, "Missing required parameter 'trunkMetabaseId' when calling TelephonyProvidersEdgeTrunkbasesettingsTemplateGet");
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/template";
    
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
            
            if (trunkMetabaseId != null) queryParams.Add("trunkMetabaseId", Configuration.ApiClient.ParameterToString(trunkMetabaseId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTemplateGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTemplateGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
        
        /// <summary>
        /// Get a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <returns>TrunkBase</returns>
        public TrunkBase TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGet (string trunkBaseSettingsId)
        {
             ApiResponse<TrunkBase> response = TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGetWithHttpInfo(trunkBaseSettingsId);
             return response.Data;
        }

        /// <summary>
        /// Get a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGetWithHttpInfo (string trunkBaseSettingsId)
        {
            
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGet");
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId}";
    
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
            if (trunkBaseSettingsId != null) pathParams.Add("trunkBaseSettingsId", Configuration.ApiClient.ParameterToString(trunkBaseSettingsId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
    
        /// <summary>
        /// Get a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of TrunkBase</returns>
        public async System.Threading.Tasks.Task<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGetAsync (string trunkBaseSettingsId)
        {
             ApiResponse<TrunkBase> response = await TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGetAsyncWithHttpInfo(trunkBaseSettingsId);
             return response.Data;

        }

        /// <summary>
        /// Get a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGetAsyncWithHttpInfo (string trunkBaseSettingsId)
        {
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGet");
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId}";
    
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
            if (trunkBaseSettingsId != null) pathParams.Add("trunkBaseSettingsId", Configuration.ApiClient.ParameterToString(trunkBaseSettingsId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
        
        /// <summary>
        /// Update a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <param name="body"></param> 
        /// <returns>TrunkBase</returns>
        public TrunkBase TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPut (string trunkBaseSettingsId, TrunkBase body = null)
        {
             ApiResponse<TrunkBase> response = TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPutWithHttpInfo(trunkBaseSettingsId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of TrunkBase</returns>
        public ApiResponse< TrunkBase > TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPutWithHttpInfo (string trunkBaseSettingsId, TrunkBase body = null)
        {
            
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPut");
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId}";
    
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
            if (trunkBaseSettingsId != null) pathParams.Add("trunkBaseSettingsId", Configuration.ApiClient.ParameterToString(trunkBaseSettingsId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
    
        /// <summary>
        /// Update a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of TrunkBase</returns>
        public async System.Threading.Tasks.Task<TrunkBase> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPutAsync (string trunkBaseSettingsId, TrunkBase body = null)
        {
             ApiResponse<TrunkBase> response = await TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPutAsyncWithHttpInfo(trunkBaseSettingsId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TrunkBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TrunkBase>> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPutAsyncWithHttpInfo (string trunkBaseSettingsId, TrunkBase body = null)
        {
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPut");
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId}";
    
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
            if (trunkBaseSettingsId != null) pathParams.Add("trunkBaseSettingsId", Configuration.ApiClient.ParameterToString(trunkBaseSettingsId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TrunkBase>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TrunkBase) Configuration.ApiClient.Deserialize(response, typeof(TrunkBase)));
            
        }
        
        /// <summary>
        /// Delete a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <returns>string</returns>
        public string TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDelete (string trunkBaseSettingsId)
        {
             ApiResponse<string> response = TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDeleteWithHttpInfo(trunkBaseSettingsId);
             return response.Data;
        }

        /// <summary>
        /// Delete a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDeleteWithHttpInfo (string trunkBaseSettingsId)
        {
            
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDelete");
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId}";
    
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
            if (trunkBaseSettingsId != null) pathParams.Add("trunkBaseSettingsId", Configuration.ApiClient.ParameterToString(trunkBaseSettingsId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDeleteAsync (string trunkBaseSettingsId)
        {
             ApiResponse<string> response = await TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDeleteAsyncWithHttpInfo(trunkBaseSettingsId);
             return response.Data;

        }

        /// <summary>
        /// Delete a Trunk Base Settings object by ID 
        /// </summary>
        /// <param name="trunkBaseSettingsId">Trunk Base ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDeleteAsyncWithHttpInfo (string trunkBaseSettingsId)
        {
            // verify the required parameter 'trunkBaseSettingsId' is set
            if (trunkBaseSettingsId == null) throw new ApiException(400, "Missing required parameter 'trunkBaseSettingsId' when calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDelete");
            
    
            var path_ = "/api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId}";
    
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
            if (trunkBaseSettingsId != null) pathParams.Add("trunkBaseSettingsId", Configuration.ApiClient.ParameterToString(trunkBaseSettingsId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
    }
    
}
