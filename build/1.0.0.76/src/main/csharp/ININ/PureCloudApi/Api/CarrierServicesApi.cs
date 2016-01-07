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
    public interface ICarrierServicesApi
    {
        
        /// <summary>
        /// Get the list of carriers
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>CarrierEntityListing</returns>
        CarrierEntityListing CarrierservicesCarriersGet ();
  
        /// <summary>
        /// Get the list of carriers
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of CarrierEntityListing</returns>
        ApiResponse<CarrierEntityListing> CarrierservicesCarriersGetWithHttpInfo ();

        /// <summary>
        /// Get the list of carriers
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of CarrierEntityListing</returns>
        System.Threading.Tasks.Task<CarrierEntityListing> CarrierservicesCarriersGetAsync ();

        /// <summary>
        /// Get the list of carriers
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (CarrierEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CarrierEntityListing>> CarrierservicesCarriersGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Create a carrier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Carrier data</param>
        /// <returns>CarrierEntityListing</returns>
        CarrierEntityListing CarrierservicesCarriersPost (List<Carrier> body = null);
  
        /// <summary>
        /// Create a carrier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Carrier data</param>
        /// <returns>ApiResponse of CarrierEntityListing</returns>
        ApiResponse<CarrierEntityListing> CarrierservicesCarriersPostWithHttpInfo (List<Carrier> body = null);

        /// <summary>
        /// Create a carrier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Carrier data</param>
        /// <returns>Task of CarrierEntityListing</returns>
        System.Threading.Tasks.Task<CarrierEntityListing> CarrierservicesCarriersPostAsync (List<Carrier> body = null);

        /// <summary>
        /// Create a carrier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Carrier data</param>
        /// <returns>Task of ApiResponse (CarrierEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CarrierEntityListing>> CarrierservicesCarriersPostAsyncWithHttpInfo (List<Carrier> body = null);
        
        /// <summary>
        /// Get specified carrier by its carrier id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <returns>Carrier</returns>
        Carrier CarrierservicesCarriersCarrieridGet (string carrierId);
  
        /// <summary>
        /// Get specified carrier by its carrier id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <returns>ApiResponse of Carrier</returns>
        ApiResponse<Carrier> CarrierservicesCarriersCarrieridGetWithHttpInfo (string carrierId);

        /// <summary>
        /// Get specified carrier by its carrier id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <returns>Task of Carrier</returns>
        System.Threading.Tasks.Task<Carrier> CarrierservicesCarriersCarrieridGetAsync (string carrierId);

        /// <summary>
        /// Get specified carrier by its carrier id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <returns>Task of ApiResponse (Carrier)</returns>
        System.Threading.Tasks.Task<ApiResponse<Carrier>> CarrierservicesCarriersCarrieridGetAsyncWithHttpInfo (string carrierId);
        
        /// <summary>
        /// Update a carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="body">Carrier data</param>
        /// <returns>Carrier</returns>
        Carrier CarrierservicesCarriersCarrieridPut (string carrierId, Carrier body = null);
  
        /// <summary>
        /// Update a carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="body">Carrier data</param>
        /// <returns>ApiResponse of Carrier</returns>
        ApiResponse<Carrier> CarrierservicesCarriersCarrieridPutWithHttpInfo (string carrierId, Carrier body = null);

        /// <summary>
        /// Update a carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="body">Carrier data</param>
        /// <returns>Task of Carrier</returns>
        System.Threading.Tasks.Task<Carrier> CarrierservicesCarriersCarrieridPutAsync (string carrierId, Carrier body = null);

        /// <summary>
        /// Update a carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="body">Carrier data</param>
        /// <returns>Task of ApiResponse (Carrier)</returns>
        System.Threading.Tasks.Task<ApiResponse<Carrier>> CarrierservicesCarriersCarrieridPutAsyncWithHttpInfo (string carrierId, Carrier body = null);
        
        /// <summary>
        /// Retrieves all services for a given carrier (i.e. OUTBOUND, INBOUND...)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="fields">Fields</param>
        /// <param name="filter">Filter</param>
        /// <returns>ServiceEntityListing</returns>
        ServiceEntityListing CarrierservicesCarriersCarrieridServicesGet (string carrierId, List<string> fields = null, string filter = null);
  
        /// <summary>
        /// Retrieves all services for a given carrier (i.e. OUTBOUND, INBOUND...)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="fields">Fields</param>
        /// <param name="filter">Filter</param>
        /// <returns>ApiResponse of ServiceEntityListing</returns>
        ApiResponse<ServiceEntityListing> CarrierservicesCarriersCarrieridServicesGetWithHttpInfo (string carrierId, List<string> fields = null, string filter = null);

        /// <summary>
        /// Retrieves all services for a given carrier (i.e. OUTBOUND, INBOUND...)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="fields">Fields</param>
        /// <param name="filter">Filter</param>
        /// <returns>Task of ServiceEntityListing</returns>
        System.Threading.Tasks.Task<ServiceEntityListing> CarrierservicesCarriersCarrieridServicesGetAsync (string carrierId, List<string> fields = null, string filter = null);

        /// <summary>
        /// Retrieves all services for a given carrier (i.e. OUTBOUND, INBOUND...)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="fields">Fields</param>
        /// <param name="filter">Filter</param>
        /// <returns>Task of ApiResponse (ServiceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServiceEntityListing>> CarrierservicesCarriersCarrieridServicesGetAsyncWithHttpInfo (string carrierId, List<string> fields = null, string filter = null);
        
        /// <summary>
        /// Creates a carrier service of a specified type (i.e. OUTBOUND, INBOUND...)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="body"></param>
        /// <returns>Service</returns>
        Service CarrierservicesCarriersCarrieridServicesPost (string carrierId, Service body = null);
  
        /// <summary>
        /// Creates a carrier service of a specified type (i.e. OUTBOUND, INBOUND...)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Service</returns>
        ApiResponse<Service> CarrierservicesCarriersCarrieridServicesPostWithHttpInfo (string carrierId, Service body = null);

        /// <summary>
        /// Creates a carrier service of a specified type (i.e. OUTBOUND, INBOUND...)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Service</returns>
        System.Threading.Tasks.Task<Service> CarrierservicesCarriersCarrieridServicesPostAsync (string carrierId, Service body = null);

        /// <summary>
        /// Creates a carrier service of a specified type (i.e. OUTBOUND, INBOUND...)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Service)</returns>
        System.Threading.Tasks.Task<ApiResponse<Service>> CarrierservicesCarriersCarrieridServicesPostAsyncWithHttpInfo (string carrierId, Service body = null);
        
        /// <summary>
        /// Retrieves a specific service for a given carrier (i.e. OUTBOUND, INBOUND...)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="serviceId">Service ID</param>
        /// <param name="fields">Fields</param>
        /// <returns>Service</returns>
        Service CarrierservicesCarriersCarrieridServicesServiceidGet (string carrierId, string serviceId, List<string> fields = null);
  
        /// <summary>
        /// Retrieves a specific service for a given carrier (i.e. OUTBOUND, INBOUND...)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="serviceId">Service ID</param>
        /// <param name="fields">Fields</param>
        /// <returns>ApiResponse of Service</returns>
        ApiResponse<Service> CarrierservicesCarriersCarrieridServicesServiceidGetWithHttpInfo (string carrierId, string serviceId, List<string> fields = null);

        /// <summary>
        /// Retrieves a specific service for a given carrier (i.e. OUTBOUND, INBOUND...)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="serviceId">Service ID</param>
        /// <param name="fields">Fields</param>
        /// <returns>Task of Service</returns>
        System.Threading.Tasks.Task<Service> CarrierservicesCarriersCarrieridServicesServiceidGetAsync (string carrierId, string serviceId, List<string> fields = null);

        /// <summary>
        /// Retrieves a specific service for a given carrier (i.e. OUTBOUND, INBOUND...)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="serviceId">Service ID</param>
        /// <param name="fields">Fields</param>
        /// <returns>Task of ApiResponse (Service)</returns>
        System.Threading.Tasks.Task<ApiResponse<Service>> CarrierservicesCarriersCarrieridServicesServiceidGetAsyncWithHttpInfo (string carrierId, string serviceId, List<string> fields = null);
        
        /// <summary>
        /// Updates a specific service for a given carrier (i.e. OUTBOUND, INBOUND...)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="serviceId">Service ID</param>
        /// <param name="body"></param>
        /// <returns>Service</returns>
        Service CarrierservicesCarriersCarrieridServicesServiceidPut (string carrierId, string serviceId, Service body = null);
  
        /// <summary>
        /// Updates a specific service for a given carrier (i.e. OUTBOUND, INBOUND...)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="serviceId">Service ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Service</returns>
        ApiResponse<Service> CarrierservicesCarriersCarrieridServicesServiceidPutWithHttpInfo (string carrierId, string serviceId, Service body = null);

        /// <summary>
        /// Updates a specific service for a given carrier (i.e. OUTBOUND, INBOUND...)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="serviceId">Service ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Service</returns>
        System.Threading.Tasks.Task<Service> CarrierservicesCarriersCarrieridServicesServiceidPutAsync (string carrierId, string serviceId, Service body = null);

        /// <summary>
        /// Updates a specific service for a given carrier (i.e. OUTBOUND, INBOUND...)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="serviceId">Service ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Service)</returns>
        System.Threading.Tasks.Task<ApiResponse<Service>> CarrierservicesCarriersCarrieridServicesServiceidPutAsyncWithHttpInfo (string carrierId, string serviceId, Service body = null);
        
        /// <summary>
        /// Deletes a specific service for a given carrier (i.e. OUTBOUND, INBOUND...)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="serviceId">Service ID</param>
        /// <returns>Service</returns>
        Service CarrierservicesCarriersCarrieridServicesServiceidDelete (string carrierId, string serviceId);
  
        /// <summary>
        /// Deletes a specific service for a given carrier (i.e. OUTBOUND, INBOUND...)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="serviceId">Service ID</param>
        /// <returns>ApiResponse of Service</returns>
        ApiResponse<Service> CarrierservicesCarriersCarrieridServicesServiceidDeleteWithHttpInfo (string carrierId, string serviceId);

        /// <summary>
        /// Deletes a specific service for a given carrier (i.e. OUTBOUND, INBOUND...)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="serviceId">Service ID</param>
        /// <returns>Task of Service</returns>
        System.Threading.Tasks.Task<Service> CarrierservicesCarriersCarrieridServicesServiceidDeleteAsync (string carrierId, string serviceId);

        /// <summary>
        /// Deletes a specific service for a given carrier (i.e. OUTBOUND, INBOUND...)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="serviceId">Service ID</param>
        /// <returns>Task of ApiResponse (Service)</returns>
        System.Threading.Tasks.Task<ApiResponse<Service>> CarrierservicesCarriersCarrieridServicesServiceidDeleteAsyncWithHttpInfo (string carrierId, string serviceId);
        
        /// <summary>
        /// Get all CSV schemas available.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>CsvSchema</returns>
        CsvSchema CarrierservicesCsvschemasGet ();
  
        /// <summary>
        /// Get all CSV schemas available.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of CsvSchema</returns>
        ApiResponse<CsvSchema> CarrierservicesCsvschemasGetWithHttpInfo ();

        /// <summary>
        /// Get all CSV schemas available.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of CsvSchema</returns>
        System.Threading.Tasks.Task<CsvSchema> CarrierservicesCsvschemasGetAsync ();

        /// <summary>
        /// Get all CSV schemas available.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (CsvSchema)</returns>
        System.Threading.Tasks.Task<ApiResponse<CsvSchema>> CarrierservicesCsvschemasGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get all CSV schemas for a given carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <returns>CsvSchema</returns>
        CsvSchema CarrierservicesCsvschemasCarrieridGet (string carrierId);
  
        /// <summary>
        /// Get all CSV schemas for a given carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <returns>ApiResponse of CsvSchema</returns>
        ApiResponse<CsvSchema> CarrierservicesCsvschemasCarrieridGetWithHttpInfo (string carrierId);

        /// <summary>
        /// Get all CSV schemas for a given carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <returns>Task of CsvSchema</returns>
        System.Threading.Tasks.Task<CsvSchema> CarrierservicesCsvschemasCarrieridGetAsync (string carrierId);

        /// <summary>
        /// Get all CSV schemas for a given carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <returns>Task of ApiResponse (CsvSchema)</returns>
        System.Threading.Tasks.Task<ApiResponse<CsvSchema>> CarrierservicesCsvschemasCarrieridGetAsyncWithHttpInfo (string carrierId);
        
        /// <summary>
        /// Updates or creates a CSV schema for a carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="body">Schema data</param>
        /// <returns>CsvSchema</returns>
        CsvSchema CarrierservicesCsvschemasCarrieridPut (string carrierId, CsvSchema body = null);
  
        /// <summary>
        /// Updates or creates a CSV schema for a carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="body">Schema data</param>
        /// <returns>ApiResponse of CsvSchema</returns>
        ApiResponse<CsvSchema> CarrierservicesCsvschemasCarrieridPutWithHttpInfo (string carrierId, CsvSchema body = null);

        /// <summary>
        /// Updates or creates a CSV schema for a carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="body">Schema data</param>
        /// <returns>Task of CsvSchema</returns>
        System.Threading.Tasks.Task<CsvSchema> CarrierservicesCsvschemasCarrieridPutAsync (string carrierId, CsvSchema body = null);

        /// <summary>
        /// Updates or creates a CSV schema for a carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="body">Schema data</param>
        /// <returns>Task of ApiResponse (CsvSchema)</returns>
        System.Threading.Tasks.Task<ApiResponse<CsvSchema>> CarrierservicesCsvschemasCarrieridPutAsyncWithHttpInfo (string carrierId, CsvSchema body = null);
        
        /// <summary>
        /// Get all CSV schemas for a given carrier and name.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="name">Schema name</param>
        /// <returns>CsvSchema</returns>
        CsvSchema CarrierservicesCsvschemasCarrieridNameNameGet (string carrierId, string name);
  
        /// <summary>
        /// Get all CSV schemas for a given carrier and name.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="name">Schema name</param>
        /// <returns>ApiResponse of CsvSchema</returns>
        ApiResponse<CsvSchema> CarrierservicesCsvschemasCarrieridNameNameGetWithHttpInfo (string carrierId, string name);

        /// <summary>
        /// Get all CSV schemas for a given carrier and name.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="name">Schema name</param>
        /// <returns>Task of CsvSchema</returns>
        System.Threading.Tasks.Task<CsvSchema> CarrierservicesCsvschemasCarrieridNameNameGetAsync (string carrierId, string name);

        /// <summary>
        /// Get all CSV schemas for a given carrier and name.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="name">Schema name</param>
        /// <returns>Task of ApiResponse (CsvSchema)</returns>
        System.Threading.Tasks.Task<ApiResponse<CsvSchema>> CarrierservicesCsvschemasCarrieridNameNameGetAsyncWithHttpInfo (string carrierId, string name);
        
        /// <summary>
        /// Deletes a CSV schema for a carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="name">Schema name</param>
        /// <returns>CsvSchema</returns>
        CsvSchema CarrierservicesCsvschemasCarrieridNameNameDelete (string carrierId, string name);
  
        /// <summary>
        /// Deletes a CSV schema for a carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="name">Schema name</param>
        /// <returns>ApiResponse of CsvSchema</returns>
        ApiResponse<CsvSchema> CarrierservicesCsvschemasCarrieridNameNameDeleteWithHttpInfo (string carrierId, string name);

        /// <summary>
        /// Deletes a CSV schema for a carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="name">Schema name</param>
        /// <returns>Task of CsvSchema</returns>
        System.Threading.Tasks.Task<CsvSchema> CarrierservicesCsvschemasCarrieridNameNameDeleteAsync (string carrierId, string name);

        /// <summary>
        /// Deletes a CSV schema for a carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="name">Schema name</param>
        /// <returns>Task of ApiResponse (CsvSchema)</returns>
        System.Threading.Tasks.Task<ApiResponse<CsvSchema>> CarrierservicesCsvschemasCarrieridNameNameDeleteAsyncWithHttpInfo (string carrierId, string name);
        
        /// <summary>
        /// Search for available numbers.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="npa">The allowed number ranges for local numbers are [2-9] for the first digit and [0-9] for both the second and third digits. The allowed numbers for toll-free are 800, 888, etc.</param>
        /// <param name="state">The two-letter abbreviation of the state the RateCenter is in.</param>
        /// <param name="city">The name of the city.</param>
        /// <param name="zip">A five-digit (XXXXX) or nine-digit (XXXXX-XXXX) zip-code value.</param>
        /// <param name="lata">A maximum five digit (XXXXX) numeric format.</param>
        /// <param name="rateCenter">The abbreviation for the Rate Center</param>
        /// <param name="vanity">Requested vanity number. Valid range is from 4 to 7 alphanumeric characters.</param>
        /// <param name="prefix">Prefix of the number, must be 6 or 7 digits.</param>
        /// <param name="quantity">The desired quantity of requested numbers. Values range from 1-5000. If no quantity is specified, the default of 5000 is returned.</param>
        /// <param name="orderBy">The field by which the returned numbers will be sorted. Only supported if at least one of the following search criteria is specified: prefix, city, zip. Allowed values are fullNumber, npaNxxx, npaNxx, and areaCode&gt;</param>
        /// <param name="enableTNDetail">If set to true, a list of details associated with the telephone number (rate center abbreviation, rate center host city, state, and LATA) will be displayed along with the telephone number. This value is set to false by default.</param>
        /// <param name="type">The type of phone number (eg us-domestic, toll-free, etc), to determine which third-party api(s) to use for the search.</param>
        /// <returns></returns>
        void CarrierservicesNumberpurchaseAvailableGet (string npa = null, string state = null, string city = null, string zip = null, string lata = null, string rateCenter = null, string vanity = null, string prefix = null, int? quantity = null, string orderBy = null, bool? enableTNDetail = null, string type = null);
  
        /// <summary>
        /// Search for available numbers.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="npa">The allowed number ranges for local numbers are [2-9] for the first digit and [0-9] for both the second and third digits. The allowed numbers for toll-free are 800, 888, etc.</param>
        /// <param name="state">The two-letter abbreviation of the state the RateCenter is in.</param>
        /// <param name="city">The name of the city.</param>
        /// <param name="zip">A five-digit (XXXXX) or nine-digit (XXXXX-XXXX) zip-code value.</param>
        /// <param name="lata">A maximum five digit (XXXXX) numeric format.</param>
        /// <param name="rateCenter">The abbreviation for the Rate Center</param>
        /// <param name="vanity">Requested vanity number. Valid range is from 4 to 7 alphanumeric characters.</param>
        /// <param name="prefix">Prefix of the number, must be 6 or 7 digits.</param>
        /// <param name="quantity">The desired quantity of requested numbers. Values range from 1-5000. If no quantity is specified, the default of 5000 is returned.</param>
        /// <param name="orderBy">The field by which the returned numbers will be sorted. Only supported if at least one of the following search criteria is specified: prefix, city, zip. Allowed values are fullNumber, npaNxxx, npaNxx, and areaCode&gt;</param>
        /// <param name="enableTNDetail">If set to true, a list of details associated with the telephone number (rate center abbreviation, rate center host city, state, and LATA) will be displayed along with the telephone number. This value is set to false by default.</param>
        /// <param name="type">The type of phone number (eg us-domestic, toll-free, etc), to determine which third-party api(s) to use for the search.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CarrierservicesNumberpurchaseAvailableGetWithHttpInfo (string npa = null, string state = null, string city = null, string zip = null, string lata = null, string rateCenter = null, string vanity = null, string prefix = null, int? quantity = null, string orderBy = null, bool? enableTNDetail = null, string type = null);

        /// <summary>
        /// Search for available numbers.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="npa">The allowed number ranges for local numbers are [2-9] for the first digit and [0-9] for both the second and third digits. The allowed numbers for toll-free are 800, 888, etc.</param>
        /// <param name="state">The two-letter abbreviation of the state the RateCenter is in.</param>
        /// <param name="city">The name of the city.</param>
        /// <param name="zip">A five-digit (XXXXX) or nine-digit (XXXXX-XXXX) zip-code value.</param>
        /// <param name="lata">A maximum five digit (XXXXX) numeric format.</param>
        /// <param name="rateCenter">The abbreviation for the Rate Center</param>
        /// <param name="vanity">Requested vanity number. Valid range is from 4 to 7 alphanumeric characters.</param>
        /// <param name="prefix">Prefix of the number, must be 6 or 7 digits.</param>
        /// <param name="quantity">The desired quantity of requested numbers. Values range from 1-5000. If no quantity is specified, the default of 5000 is returned.</param>
        /// <param name="orderBy">The field by which the returned numbers will be sorted. Only supported if at least one of the following search criteria is specified: prefix, city, zip. Allowed values are fullNumber, npaNxxx, npaNxx, and areaCode&gt;</param>
        /// <param name="enableTNDetail">If set to true, a list of details associated with the telephone number (rate center abbreviation, rate center host city, state, and LATA) will be displayed along with the telephone number. This value is set to false by default.</param>
        /// <param name="type">The type of phone number (eg us-domestic, toll-free, etc), to determine which third-party api(s) to use for the search.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CarrierservicesNumberpurchaseAvailableGetAsync (string npa = null, string state = null, string city = null, string zip = null, string lata = null, string rateCenter = null, string vanity = null, string prefix = null, int? quantity = null, string orderBy = null, bool? enableTNDetail = null, string type = null);

        /// <summary>
        /// Search for available numbers.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="npa">The allowed number ranges for local numbers are [2-9] for the first digit and [0-9] for both the second and third digits. The allowed numbers for toll-free are 800, 888, etc.</param>
        /// <param name="state">The two-letter abbreviation of the state the RateCenter is in.</param>
        /// <param name="city">The name of the city.</param>
        /// <param name="zip">A five-digit (XXXXX) or nine-digit (XXXXX-XXXX) zip-code value.</param>
        /// <param name="lata">A maximum five digit (XXXXX) numeric format.</param>
        /// <param name="rateCenter">The abbreviation for the Rate Center</param>
        /// <param name="vanity">Requested vanity number. Valid range is from 4 to 7 alphanumeric characters.</param>
        /// <param name="prefix">Prefix of the number, must be 6 or 7 digits.</param>
        /// <param name="quantity">The desired quantity of requested numbers. Values range from 1-5000. If no quantity is specified, the default of 5000 is returned.</param>
        /// <param name="orderBy">The field by which the returned numbers will be sorted. Only supported if at least one of the following search criteria is specified: prefix, city, zip. Allowed values are fullNumber, npaNxxx, npaNxx, and areaCode&gt;</param>
        /// <param name="enableTNDetail">If set to true, a list of details associated with the telephone number (rate center abbreviation, rate center host city, state, and LATA) will be displayed along with the telephone number. This value is set to false by default.</param>
        /// <param name="type">The type of phone number (eg us-domestic, toll-free, etc), to determine which third-party api(s) to use for the search.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CarrierservicesNumberpurchaseAvailableGetAsyncWithHttpInfo (string npa = null, string state = null, string city = null, string zip = null, string lata = null, string rateCenter = null, string vanity = null, string prefix = null, int? quantity = null, string orderBy = null, bool? enableTNDetail = null, string type = null);
        
        /// <summary>
        /// View all number orders for the organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneNumberType">Phone Number Type</param>
        /// <returns></returns>
        void CarrierservicesNumberpurchaseOrdersGet (string phoneNumberType = null);
  
        /// <summary>
        /// View all number orders for the organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneNumberType">Phone Number Type</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CarrierservicesNumberpurchaseOrdersGetWithHttpInfo (string phoneNumberType = null);

        /// <summary>
        /// View all number orders for the organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneNumberType">Phone Number Type</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CarrierservicesNumberpurchaseOrdersGetAsync (string phoneNumberType = null);

        /// <summary>
        /// View all number orders for the organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneNumberType">Phone Number Type</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CarrierservicesNumberpurchaseOrdersGetAsyncWithHttpInfo (string phoneNumberType = null);
        
        /// <summary>
        /// Purchase numbers.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneNumberType">Phone Number Type</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void CarrierservicesNumberpurchaseOrdersPost (string phoneNumberType = null, NumberOrderRequest body = null);
  
        /// <summary>
        /// Purchase numbers.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneNumberType">Phone Number Type</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CarrierservicesNumberpurchaseOrdersPostWithHttpInfo (string phoneNumberType = null, NumberOrderRequest body = null);

        /// <summary>
        /// Purchase numbers.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneNumberType">Phone Number Type</param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CarrierservicesNumberpurchaseOrdersPostAsync (string phoneNumberType = null, NumberOrderRequest body = null);

        /// <summary>
        /// Purchase numbers.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="phoneNumberType">Phone Number Type</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CarrierservicesNumberpurchaseOrdersPostAsyncWithHttpInfo (string phoneNumberType = null, NumberOrderRequest body = null);
        
        /// <summary>
        /// View all a number order record.  Some vender apis have side effects when viewing records with pending operations.  This method also manages the side effects and updates ININ-side data stores to reflect any changes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orderId">Phone Number Order ID</param>
        /// <returns></returns>
        void CarrierservicesNumberpurchaseOrdersOrderidGet (string orderId);
  
        /// <summary>
        /// View all a number order record.  Some vender apis have side effects when viewing records with pending operations.  This method also manages the side effects and updates ININ-side data stores to reflect any changes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orderId">Phone Number Order ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CarrierservicesNumberpurchaseOrdersOrderidGetWithHttpInfo (string orderId);

        /// <summary>
        /// View all a number order record.  Some vender apis have side effects when viewing records with pending operations.  This method also manages the side effects and updates ININ-side data stores to reflect any changes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orderId">Phone Number Order ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CarrierservicesNumberpurchaseOrdersOrderidGetAsync (string orderId);

        /// <summary>
        /// View all a number order record.  Some vender apis have side effects when viewing records with pending operations.  This method also manages the side effects and updates ININ-side data stores to reflect any changes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orderId">Phone Number Order ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CarrierservicesNumberpurchaseOrdersOrderidGetAsyncWithHttpInfo (string orderId);
        
        /// <summary>
        /// Disconnect the number purchased in a particlar order.  The order record remains (in the deleted state) for record keeping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orderId">Phone Number Order ID</param>
        /// <returns></returns>
        void CarrierservicesNumberpurchaseOrdersOrderidDelete (string orderId);
  
        /// <summary>
        /// Disconnect the number purchased in a particlar order.  The order record remains (in the deleted state) for record keeping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orderId">Phone Number Order ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CarrierservicesNumberpurchaseOrdersOrderidDeleteWithHttpInfo (string orderId);

        /// <summary>
        /// Disconnect the number purchased in a particlar order.  The order record remains (in the deleted state) for record keeping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orderId">Phone Number Order ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CarrierservicesNumberpurchaseOrdersOrderidDeleteAsync (string orderId);

        /// <summary>
        /// Disconnect the number purchased in a particlar order.  The order record remains (in the deleted state) for record keeping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orderId">Phone Number Order ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CarrierservicesNumberpurchaseOrdersOrderidDeleteAsyncWithHttpInfo (string orderId);
        
        /// <summary>
        /// Reserve available numbers, making them ready for purchase and preventing other users from accessing them.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns></returns>
        void CarrierservicesNumberpurchaseReservedPost (List<Reservation> body = null);
  
        /// <summary>
        /// Reserve available numbers, making them ready for purchase and preventing other users from accessing them.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CarrierservicesNumberpurchaseReservedPostWithHttpInfo (List<Reservation> body = null);

        /// <summary>
        /// Reserve available numbers, making them ready for purchase and preventing other users from accessing them.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CarrierservicesNumberpurchaseReservedPostAsync (List<Reservation> body = null);

        /// <summary>
        /// Reserve available numbers, making them ready for purchase and preventing other users from accessing them.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CarrierservicesNumberpurchaseReservedPostAsyncWithHttpInfo (List<Reservation> body = null);
        
        /// <summary>
        /// View a specific reservation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="reservationId">Phone Number Reservation ID</param>
        /// <param name="phoneNumberType">Phone Number Type</param>
        /// <returns></returns>
        void CarrierservicesNumberpurchaseReservedReservationidGet (string reservationId, string phoneNumberType = null);
  
        /// <summary>
        /// View a specific reservation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="reservationId">Phone Number Reservation ID</param>
        /// <param name="phoneNumberType">Phone Number Type</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CarrierservicesNumberpurchaseReservedReservationidGetWithHttpInfo (string reservationId, string phoneNumberType = null);

        /// <summary>
        /// View a specific reservation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="reservationId">Phone Number Reservation ID</param>
        /// <param name="phoneNumberType">Phone Number Type</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CarrierservicesNumberpurchaseReservedReservationidGetAsync (string reservationId, string phoneNumberType = null);

        /// <summary>
        /// View a specific reservation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="reservationId">Phone Number Reservation ID</param>
        /// <param name="phoneNumberType">Phone Number Type</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CarrierservicesNumberpurchaseReservedReservationidGetAsyncWithHttpInfo (string reservationId, string phoneNumberType = null);
        
        /// <summary>
        /// Cancel a specific reservation, making the number available for other users, again.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="reservationId">Phone Number Reservation ID</param>
        /// <param name="phoneNumberType">Phone Number Type</param>
        /// <returns></returns>
        void CarrierservicesNumberpurchaseReservedReservationidDelete (string reservationId, string phoneNumberType = null);
  
        /// <summary>
        /// Cancel a specific reservation, making the number available for other users, again.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="reservationId">Phone Number Reservation ID</param>
        /// <param name="phoneNumberType">Phone Number Type</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CarrierservicesNumberpurchaseReservedReservationidDeleteWithHttpInfo (string reservationId, string phoneNumberType = null);

        /// <summary>
        /// Cancel a specific reservation, making the number available for other users, again.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="reservationId">Phone Number Reservation ID</param>
        /// <param name="phoneNumberType">Phone Number Type</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CarrierservicesNumberpurchaseReservedReservationidDeleteAsync (string reservationId, string phoneNumberType = null);

        /// <summary>
        /// Cancel a specific reservation, making the number available for other users, again.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="reservationId">Phone Number Reservation ID</param>
        /// <param name="phoneNumberType">Phone Number Type</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CarrierservicesNumberpurchaseReservedReservationidDeleteAsyncWithHttpInfo (string reservationId, string phoneNumberType = null);
        
        /// <summary>
        /// Get ratesheet upload progress for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>UploadProgress</returns>
        UploadProgress CarrierservicesProgressGet ();
  
        /// <summary>
        /// Get ratesheet upload progress for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of UploadProgress</returns>
        ApiResponse<UploadProgress> CarrierservicesProgressGetWithHttpInfo ();

        /// <summary>
        /// Get ratesheet upload progress for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of UploadProgress</returns>
        System.Threading.Tasks.Task<UploadProgress> CarrierservicesProgressGetAsync ();

        /// <summary>
        /// Get ratesheet upload progress for a user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (UploadProgress)</returns>
        System.Threading.Tasks.Task<ApiResponse<UploadProgress>> CarrierservicesProgressGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get LCR report.
        /// </summary>
        /// <remarks>
        /// This method queries Druid for a Phone Number Purchase Stats database report.  Some Druid terminology is required to use it.  Each query parameter besides dimensions, _pgn, and _pgs, is a Druid dimension.  From the Druid documentation: Dimensions: Aspects or categories of data, such as languages or locations. For example, with language and country as the type of dimension, values could be \&quot;English\&quot; or \&quot;Mandarin\&quot; for language, or \&quot;USA\&quot; or \&quot;China\&quot; for country. In Druid, dimensions can serve as filters for narrowing down hits (for example, language = \&quot;English\&quot; or country = \&quot;China\&quot;).  When using a dimension query parameter with a value the report will return events with granularity of that dimension where the dimension value is equal to the value you specified.  If you want to receive events with dimension based granularity with no filter, opt to use the dimensions query parameters, which is a comma  separated list of values that use the other query parameters as dimension names.  Each  parameter needs to be in the screaming snake case format, or words capitalized with underscores between words (i.e. CUSTOMER_ID).
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="granularity">The granularity field determines how data gets bucketed across the time dimension, or how it gets aggregated by hour, day, minute, etc. all buckets everything into a single bucket. none does not bucket data (it actually uses the granularity of the index - minimum here is none which means millisecond granularity).</param>
        /// <param name="dimensions">Dimensions are really any other parameter specified, excluding granularity.  To specify multiple dimensions use comma separated values.</param>
        /// <param name="startDate">Start dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over.  If not set will always default to now minus 15 days.</param>
        /// <param name="endDate">End dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over. If not set will always default to startDate plus 30 days.</param>
        /// <param name="regexFilterEnabled">Specifies if all dimension filters should be implemented as regexps.</param>
        /// <param name="effectiveStartDate">Effective date number service starts</param>
        /// <param name="effectiveEndDate">Effective date number service ends</param>
        /// <param name="did">Number purchased (Can use with regex for npa, etc.)</param>
        /// <param name="phoneNumberType">Type of number purchased (ie. us-domestic, tollfree...)</param>
        /// <param name="startAuthUserId">User id for the number purchase</param>
        /// <param name="endAuthUserId">User id for the number disconnect order</param>
        /// <param name="status">Status of the number purchase</param>
        /// <param name="orgId">Organization id for the number purchase</param>
        /// <returns></returns>
        void CarrierservicesReportPurchasesGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string granularity = null, string dimensions = null, DateTime? startDate = null, DateTime? endDate = null, bool? regexFilterEnabled = null, DateTime? effectiveStartDate = null, DateTime? effectiveEndDate = null, string did = null, string phoneNumberType = null, string startAuthUserId = null, string endAuthUserId = null, string status = null, string orgId = null);
  
        /// <summary>
        /// Get LCR report.
        /// </summary>
        /// <remarks>
        /// This method queries Druid for a Phone Number Purchase Stats database report.  Some Druid terminology is required to use it.  Each query parameter besides dimensions, _pgn, and _pgs, is a Druid dimension.  From the Druid documentation: Dimensions: Aspects or categories of data, such as languages or locations. For example, with language and country as the type of dimension, values could be \&quot;English\&quot; or \&quot;Mandarin\&quot; for language, or \&quot;USA\&quot; or \&quot;China\&quot; for country. In Druid, dimensions can serve as filters for narrowing down hits (for example, language = \&quot;English\&quot; or country = \&quot;China\&quot;).  When using a dimension query parameter with a value the report will return events with granularity of that dimension where the dimension value is equal to the value you specified.  If you want to receive events with dimension based granularity with no filter, opt to use the dimensions query parameters, which is a comma  separated list of values that use the other query parameters as dimension names.  Each  parameter needs to be in the screaming snake case format, or words capitalized with underscores between words (i.e. CUSTOMER_ID).
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="granularity">The granularity field determines how data gets bucketed across the time dimension, or how it gets aggregated by hour, day, minute, etc. all buckets everything into a single bucket. none does not bucket data (it actually uses the granularity of the index - minimum here is none which means millisecond granularity).</param>
        /// <param name="dimensions">Dimensions are really any other parameter specified, excluding granularity.  To specify multiple dimensions use comma separated values.</param>
        /// <param name="startDate">Start dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over.  If not set will always default to now minus 15 days.</param>
        /// <param name="endDate">End dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over. If not set will always default to startDate plus 30 days.</param>
        /// <param name="regexFilterEnabled">Specifies if all dimension filters should be implemented as regexps.</param>
        /// <param name="effectiveStartDate">Effective date number service starts</param>
        /// <param name="effectiveEndDate">Effective date number service ends</param>
        /// <param name="did">Number purchased (Can use with regex for npa, etc.)</param>
        /// <param name="phoneNumberType">Type of number purchased (ie. us-domestic, tollfree...)</param>
        /// <param name="startAuthUserId">User id for the number purchase</param>
        /// <param name="endAuthUserId">User id for the number disconnect order</param>
        /// <param name="status">Status of the number purchase</param>
        /// <param name="orgId">Organization id for the number purchase</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CarrierservicesReportPurchasesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string granularity = null, string dimensions = null, DateTime? startDate = null, DateTime? endDate = null, bool? regexFilterEnabled = null, DateTime? effectiveStartDate = null, DateTime? effectiveEndDate = null, string did = null, string phoneNumberType = null, string startAuthUserId = null, string endAuthUserId = null, string status = null, string orgId = null);

        /// <summary>
        /// Get LCR report.
        /// </summary>
        /// <remarks>
        /// This method queries Druid for a Phone Number Purchase Stats database report.  Some Druid terminology is required to use it.  Each query parameter besides dimensions, _pgn, and _pgs, is a Druid dimension.  From the Druid documentation: Dimensions: Aspects or categories of data, such as languages or locations. For example, with language and country as the type of dimension, values could be \&quot;English\&quot; or \&quot;Mandarin\&quot; for language, or \&quot;USA\&quot; or \&quot;China\&quot; for country. In Druid, dimensions can serve as filters for narrowing down hits (for example, language = \&quot;English\&quot; or country = \&quot;China\&quot;).  When using a dimension query parameter with a value the report will return events with granularity of that dimension where the dimension value is equal to the value you specified.  If you want to receive events with dimension based granularity with no filter, opt to use the dimensions query parameters, which is a comma  separated list of values that use the other query parameters as dimension names.  Each  parameter needs to be in the screaming snake case format, or words capitalized with underscores between words (i.e. CUSTOMER_ID).
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="granularity">The granularity field determines how data gets bucketed across the time dimension, or how it gets aggregated by hour, day, minute, etc. all buckets everything into a single bucket. none does not bucket data (it actually uses the granularity of the index - minimum here is none which means millisecond granularity).</param>
        /// <param name="dimensions">Dimensions are really any other parameter specified, excluding granularity.  To specify multiple dimensions use comma separated values.</param>
        /// <param name="startDate">Start dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over.  If not set will always default to now minus 15 days.</param>
        /// <param name="endDate">End dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over. If not set will always default to startDate plus 30 days.</param>
        /// <param name="regexFilterEnabled">Specifies if all dimension filters should be implemented as regexps.</param>
        /// <param name="effectiveStartDate">Effective date number service starts</param>
        /// <param name="effectiveEndDate">Effective date number service ends</param>
        /// <param name="did">Number purchased (Can use with regex for npa, etc.)</param>
        /// <param name="phoneNumberType">Type of number purchased (ie. us-domestic, tollfree...)</param>
        /// <param name="startAuthUserId">User id for the number purchase</param>
        /// <param name="endAuthUserId">User id for the number disconnect order</param>
        /// <param name="status">Status of the number purchase</param>
        /// <param name="orgId">Organization id for the number purchase</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CarrierservicesReportPurchasesGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string granularity = null, string dimensions = null, DateTime? startDate = null, DateTime? endDate = null, bool? regexFilterEnabled = null, DateTime? effectiveStartDate = null, DateTime? effectiveEndDate = null, string did = null, string phoneNumberType = null, string startAuthUserId = null, string endAuthUserId = null, string status = null, string orgId = null);

        /// <summary>
        /// Get LCR report.
        /// </summary>
        /// <remarks>
        /// This method queries Druid for a Phone Number Purchase Stats database report.  Some Druid terminology is required to use it.  Each query parameter besides dimensions, _pgn, and _pgs, is a Druid dimension.  From the Druid documentation: Dimensions: Aspects or categories of data, such as languages or locations. For example, with language and country as the type of dimension, values could be \&quot;English\&quot; or \&quot;Mandarin\&quot; for language, or \&quot;USA\&quot; or \&quot;China\&quot; for country. In Druid, dimensions can serve as filters for narrowing down hits (for example, language = \&quot;English\&quot; or country = \&quot;China\&quot;).  When using a dimension query parameter with a value the report will return events with granularity of that dimension where the dimension value is equal to the value you specified.  If you want to receive events with dimension based granularity with no filter, opt to use the dimensions query parameters, which is a comma  separated list of values that use the other query parameters as dimension names.  Each  parameter needs to be in the screaming snake case format, or words capitalized with underscores between words (i.e. CUSTOMER_ID).
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="granularity">The granularity field determines how data gets bucketed across the time dimension, or how it gets aggregated by hour, day, minute, etc. all buckets everything into a single bucket. none does not bucket data (it actually uses the granularity of the index - minimum here is none which means millisecond granularity).</param>
        /// <param name="dimensions">Dimensions are really any other parameter specified, excluding granularity.  To specify multiple dimensions use comma separated values.</param>
        /// <param name="startDate">Start dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over.  If not set will always default to now minus 15 days.</param>
        /// <param name="endDate">End dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over. If not set will always default to startDate plus 30 days.</param>
        /// <param name="regexFilterEnabled">Specifies if all dimension filters should be implemented as regexps.</param>
        /// <param name="effectiveStartDate">Effective date number service starts</param>
        /// <param name="effectiveEndDate">Effective date number service ends</param>
        /// <param name="did">Number purchased (Can use with regex for npa, etc.)</param>
        /// <param name="phoneNumberType">Type of number purchased (ie. us-domestic, tollfree...)</param>
        /// <param name="startAuthUserId">User id for the number purchase</param>
        /// <param name="endAuthUserId">User id for the number disconnect order</param>
        /// <param name="status">Status of the number purchase</param>
        /// <param name="orgId">Organization id for the number purchase</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CarrierservicesReportPurchasesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string granularity = null, string dimensions = null, DateTime? startDate = null, DateTime? endDate = null, bool? regexFilterEnabled = null, DateTime? effectiveStartDate = null, DateTime? effectiveEndDate = null, string did = null, string phoneNumberType = null, string startAuthUserId = null, string endAuthUserId = null, string status = null, string orgId = null);
        
        /// <summary>
        /// Get LCR report.
        /// </summary>
        /// <remarks>
        /// This method queries Druid for a Call Stats database report.  Some Druid terminology is required to use it.  Each query parameter besides dimensions, _pgn, and _pgs, is a Druid dimension.  From the Druid documentation: Dimensions: Aspects or categories of data, such as languages or locations. For example, with language and country as the type of dimension, values could be \&quot;English\&quot; or \&quot;Mandarin\&quot; for language, or \&quot;USA\&quot; or \&quot;China\&quot; for country. In Druid, dimensions can serve as filters for narrowing down hits (for example, language = \&quot;English\&quot; or country = \&quot;China\&quot;).  When using a dimension query parameter with a value the report will return events with granularity of that dimension where the dimension value is equal to the value you specified.  If you want to receive events with dimension based granularity with no filter, opt to use the dimensions query parameters, which is a comma  separated list of values that use the other query parameters as dimension names.  Each  parameter needs to be in the screaming snake case format, or words capitalized with underscores between words (i.e. CUSTOMER_ID).
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="granularity">The granularity field determines how data gets bucketed across the time dimension, or how it gets aggregated by hour, day, minute, etc. all buckets everything into a single bucket. none does not bucket data (it actually uses the granularity of the index - minimum here is none which means millisecond granularity).</param>
        /// <param name="dimensions">Dimensions are really any other parameter specified, excluding granularity.  To specify multiple dimensions use comma separated values.</param>
        /// <param name="startDate">Start dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over.  If not set will always default to now minus 15 days.</param>
        /// <param name="endDate">End dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over. If not set will always default to startDate plus 30 days.</param>
        /// <param name="regexFilterEnabled">Specifies if all dimension filters should be implemented as regexps.</param>
        /// <param name="sipCallId">SIP call id</param>
        /// <param name="sipReason">SIP human readable status reason</param>
        /// <param name="lrn"></param>
        /// <param name="sipStatus">SIP status code</param>
        /// <param name="dialogId"></param>
        /// <param name="orgId">Organization id for the placed call</param>
        /// <param name="cnam"></param>
        /// <param name="from">From prefix of the number</param>
        /// <param name="to">To prefix of the number</param>
        /// <param name="gatewayId"></param>
        /// <param name="direction">Direction of the call (e.g. incoming/outgoing)</param>
        /// <param name="serviceId">Purevoice service id</param>
        /// <param name="sendTime"></param>
        /// <param name="answerTime">Time in which the call was connected end to end</param>
        /// <param name="receiveTime">Time in which the call was retrieved by Purevoice</param>
        /// <param name="failTime"></param>
        /// <param name="disconnectTime"></param>
        /// <param name="endTime">Time of success call ending</param>
        /// <param name="cnamTime"></param>
        /// <param name="lnpTime"></param>
        /// <param name="rejectTime"></param>
        /// <returns></returns>
        void CarrierservicesReportUsageGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string granularity = null, string dimensions = null, DateTime? startDate = null, DateTime? endDate = null, bool? regexFilterEnabled = null, string sipCallId = null, string sipReason = null, string lrn = null, string sipStatus = null, string dialogId = null, string orgId = null, string cnam = null, string from = null, string to = null, string gatewayId = null, string direction = null, string serviceId = null, DateTime? sendTime = null, DateTime? answerTime = null, DateTime? receiveTime = null, DateTime? failTime = null, DateTime? disconnectTime = null, DateTime? endTime = null, DateTime? cnamTime = null, DateTime? lnpTime = null, DateTime? rejectTime = null);
  
        /// <summary>
        /// Get LCR report.
        /// </summary>
        /// <remarks>
        /// This method queries Druid for a Call Stats database report.  Some Druid terminology is required to use it.  Each query parameter besides dimensions, _pgn, and _pgs, is a Druid dimension.  From the Druid documentation: Dimensions: Aspects or categories of data, such as languages or locations. For example, with language and country as the type of dimension, values could be \&quot;English\&quot; or \&quot;Mandarin\&quot; for language, or \&quot;USA\&quot; or \&quot;China\&quot; for country. In Druid, dimensions can serve as filters for narrowing down hits (for example, language = \&quot;English\&quot; or country = \&quot;China\&quot;).  When using a dimension query parameter with a value the report will return events with granularity of that dimension where the dimension value is equal to the value you specified.  If you want to receive events with dimension based granularity with no filter, opt to use the dimensions query parameters, which is a comma  separated list of values that use the other query parameters as dimension names.  Each  parameter needs to be in the screaming snake case format, or words capitalized with underscores between words (i.e. CUSTOMER_ID).
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="granularity">The granularity field determines how data gets bucketed across the time dimension, or how it gets aggregated by hour, day, minute, etc. all buckets everything into a single bucket. none does not bucket data (it actually uses the granularity of the index - minimum here is none which means millisecond granularity).</param>
        /// <param name="dimensions">Dimensions are really any other parameter specified, excluding granularity.  To specify multiple dimensions use comma separated values.</param>
        /// <param name="startDate">Start dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over.  If not set will always default to now minus 15 days.</param>
        /// <param name="endDate">End dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over. If not set will always default to startDate plus 30 days.</param>
        /// <param name="regexFilterEnabled">Specifies if all dimension filters should be implemented as regexps.</param>
        /// <param name="sipCallId">SIP call id</param>
        /// <param name="sipReason">SIP human readable status reason</param>
        /// <param name="lrn"></param>
        /// <param name="sipStatus">SIP status code</param>
        /// <param name="dialogId"></param>
        /// <param name="orgId">Organization id for the placed call</param>
        /// <param name="cnam"></param>
        /// <param name="from">From prefix of the number</param>
        /// <param name="to">To prefix of the number</param>
        /// <param name="gatewayId"></param>
        /// <param name="direction">Direction of the call (e.g. incoming/outgoing)</param>
        /// <param name="serviceId">Purevoice service id</param>
        /// <param name="sendTime"></param>
        /// <param name="answerTime">Time in which the call was connected end to end</param>
        /// <param name="receiveTime">Time in which the call was retrieved by Purevoice</param>
        /// <param name="failTime"></param>
        /// <param name="disconnectTime"></param>
        /// <param name="endTime">Time of success call ending</param>
        /// <param name="cnamTime"></param>
        /// <param name="lnpTime"></param>
        /// <param name="rejectTime"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CarrierservicesReportUsageGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string granularity = null, string dimensions = null, DateTime? startDate = null, DateTime? endDate = null, bool? regexFilterEnabled = null, string sipCallId = null, string sipReason = null, string lrn = null, string sipStatus = null, string dialogId = null, string orgId = null, string cnam = null, string from = null, string to = null, string gatewayId = null, string direction = null, string serviceId = null, DateTime? sendTime = null, DateTime? answerTime = null, DateTime? receiveTime = null, DateTime? failTime = null, DateTime? disconnectTime = null, DateTime? endTime = null, DateTime? cnamTime = null, DateTime? lnpTime = null, DateTime? rejectTime = null);

        /// <summary>
        /// Get LCR report.
        /// </summary>
        /// <remarks>
        /// This method queries Druid for a Call Stats database report.  Some Druid terminology is required to use it.  Each query parameter besides dimensions, _pgn, and _pgs, is a Druid dimension.  From the Druid documentation: Dimensions: Aspects or categories of data, such as languages or locations. For example, with language and country as the type of dimension, values could be \&quot;English\&quot; or \&quot;Mandarin\&quot; for language, or \&quot;USA\&quot; or \&quot;China\&quot; for country. In Druid, dimensions can serve as filters for narrowing down hits (for example, language = \&quot;English\&quot; or country = \&quot;China\&quot;).  When using a dimension query parameter with a value the report will return events with granularity of that dimension where the dimension value is equal to the value you specified.  If you want to receive events with dimension based granularity with no filter, opt to use the dimensions query parameters, which is a comma  separated list of values that use the other query parameters as dimension names.  Each  parameter needs to be in the screaming snake case format, or words capitalized with underscores between words (i.e. CUSTOMER_ID).
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="granularity">The granularity field determines how data gets bucketed across the time dimension, or how it gets aggregated by hour, day, minute, etc. all buckets everything into a single bucket. none does not bucket data (it actually uses the granularity of the index - minimum here is none which means millisecond granularity).</param>
        /// <param name="dimensions">Dimensions are really any other parameter specified, excluding granularity.  To specify multiple dimensions use comma separated values.</param>
        /// <param name="startDate">Start dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over.  If not set will always default to now minus 15 days.</param>
        /// <param name="endDate">End dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over. If not set will always default to startDate plus 30 days.</param>
        /// <param name="regexFilterEnabled">Specifies if all dimension filters should be implemented as regexps.</param>
        /// <param name="sipCallId">SIP call id</param>
        /// <param name="sipReason">SIP human readable status reason</param>
        /// <param name="lrn"></param>
        /// <param name="sipStatus">SIP status code</param>
        /// <param name="dialogId"></param>
        /// <param name="orgId">Organization id for the placed call</param>
        /// <param name="cnam"></param>
        /// <param name="from">From prefix of the number</param>
        /// <param name="to">To prefix of the number</param>
        /// <param name="gatewayId"></param>
        /// <param name="direction">Direction of the call (e.g. incoming/outgoing)</param>
        /// <param name="serviceId">Purevoice service id</param>
        /// <param name="sendTime"></param>
        /// <param name="answerTime">Time in which the call was connected end to end</param>
        /// <param name="receiveTime">Time in which the call was retrieved by Purevoice</param>
        /// <param name="failTime"></param>
        /// <param name="disconnectTime"></param>
        /// <param name="endTime">Time of success call ending</param>
        /// <param name="cnamTime"></param>
        /// <param name="lnpTime"></param>
        /// <param name="rejectTime"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CarrierservicesReportUsageGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string granularity = null, string dimensions = null, DateTime? startDate = null, DateTime? endDate = null, bool? regexFilterEnabled = null, string sipCallId = null, string sipReason = null, string lrn = null, string sipStatus = null, string dialogId = null, string orgId = null, string cnam = null, string from = null, string to = null, string gatewayId = null, string direction = null, string serviceId = null, DateTime? sendTime = null, DateTime? answerTime = null, DateTime? receiveTime = null, DateTime? failTime = null, DateTime? disconnectTime = null, DateTime? endTime = null, DateTime? cnamTime = null, DateTime? lnpTime = null, DateTime? rejectTime = null);

        /// <summary>
        /// Get LCR report.
        /// </summary>
        /// <remarks>
        /// This method queries Druid for a Call Stats database report.  Some Druid terminology is required to use it.  Each query parameter besides dimensions, _pgn, and _pgs, is a Druid dimension.  From the Druid documentation: Dimensions: Aspects or categories of data, such as languages or locations. For example, with language and country as the type of dimension, values could be \&quot;English\&quot; or \&quot;Mandarin\&quot; for language, or \&quot;USA\&quot; or \&quot;China\&quot; for country. In Druid, dimensions can serve as filters for narrowing down hits (for example, language = \&quot;English\&quot; or country = \&quot;China\&quot;).  When using a dimension query parameter with a value the report will return events with granularity of that dimension where the dimension value is equal to the value you specified.  If you want to receive events with dimension based granularity with no filter, opt to use the dimensions query parameters, which is a comma  separated list of values that use the other query parameters as dimension names.  Each  parameter needs to be in the screaming snake case format, or words capitalized with underscores between words (i.e. CUSTOMER_ID).
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="granularity">The granularity field determines how data gets bucketed across the time dimension, or how it gets aggregated by hour, day, minute, etc. all buckets everything into a single bucket. none does not bucket data (it actually uses the granularity of the index - minimum here is none which means millisecond granularity).</param>
        /// <param name="dimensions">Dimensions are really any other parameter specified, excluding granularity.  To specify multiple dimensions use comma separated values.</param>
        /// <param name="startDate">Start dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over.  If not set will always default to now minus 15 days.</param>
        /// <param name="endDate">End dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over. If not set will always default to startDate plus 30 days.</param>
        /// <param name="regexFilterEnabled">Specifies if all dimension filters should be implemented as regexps.</param>
        /// <param name="sipCallId">SIP call id</param>
        /// <param name="sipReason">SIP human readable status reason</param>
        /// <param name="lrn"></param>
        /// <param name="sipStatus">SIP status code</param>
        /// <param name="dialogId"></param>
        /// <param name="orgId">Organization id for the placed call</param>
        /// <param name="cnam"></param>
        /// <param name="from">From prefix of the number</param>
        /// <param name="to">To prefix of the number</param>
        /// <param name="gatewayId"></param>
        /// <param name="direction">Direction of the call (e.g. incoming/outgoing)</param>
        /// <param name="serviceId">Purevoice service id</param>
        /// <param name="sendTime"></param>
        /// <param name="answerTime">Time in which the call was connected end to end</param>
        /// <param name="receiveTime">Time in which the call was retrieved by Purevoice</param>
        /// <param name="failTime"></param>
        /// <param name="disconnectTime"></param>
        /// <param name="endTime">Time of success call ending</param>
        /// <param name="cnamTime"></param>
        /// <param name="lnpTime"></param>
        /// <param name="rejectTime"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CarrierservicesReportUsageGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string granularity = null, string dimensions = null, DateTime? startDate = null, DateTime? endDate = null, bool? regexFilterEnabled = null, string sipCallId = null, string sipReason = null, string lrn = null, string sipStatus = null, string dialogId = null, string orgId = null, string cnam = null, string from = null, string to = null, string gatewayId = null, string direction = null, string serviceId = null, DateTime? sendTime = null, DateTime? answerTime = null, DateTime? receiveTime = null, DateTime? failTime = null, DateTime? disconnectTime = null, DateTime? endTime = null, DateTime? cnamTime = null, DateTime? lnpTime = null, DateTime? rejectTime = null);
        
        /// <summary>
        /// Get View Url
        /// </summary>
        /// <remarks>
        /// Provides url of a hosted DocuSign view/document, allowing user to sign document electronically
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>EmbeddedSignatureView</returns>
        EmbeddedSignatureView CarrierservicesSignaturePost (SignatureDocumentInfo body = null);
  
        /// <summary>
        /// Get View Url
        /// </summary>
        /// <remarks>
        /// Provides url of a hosted DocuSign view/document, allowing user to sign document electronically
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EmbeddedSignatureView</returns>
        ApiResponse<EmbeddedSignatureView> CarrierservicesSignaturePostWithHttpInfo (SignatureDocumentInfo body = null);

        /// <summary>
        /// Get View Url
        /// </summary>
        /// <remarks>
        /// Provides url of a hosted DocuSign view/document, allowing user to sign document electronically
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of EmbeddedSignatureView</returns>
        System.Threading.Tasks.Task<EmbeddedSignatureView> CarrierservicesSignaturePostAsync (SignatureDocumentInfo body = null);

        /// <summary>
        /// Get View Url
        /// </summary>
        /// <remarks>
        /// Provides url of a hosted DocuSign view/document, allowing user to sign document electronically
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (EmbeddedSignatureView)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmbeddedSignatureView>> CarrierservicesSignaturePostAsyncWithHttpInfo (SignatureDocumentInfo body = null);
        
        /// <summary>
        /// Get a stored transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="filter">Filter</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="lastEntry">Last entry</param>
        /// <returns>List&lt;TransformEndpoint&gt;</returns>
        List<TransformEndpoint> CarrierservicesTransformendpointsGet (string filter = null, string pageSize = null, string lastEntry = null);
  
        /// <summary>
        /// Get a stored transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="filter">Filter</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="lastEntry">Last entry</param>
        /// <returns>ApiResponse of List&lt;TransformEndpoint&gt;</returns>
        ApiResponse<List<TransformEndpoint>> CarrierservicesTransformendpointsGetWithHttpInfo (string filter = null, string pageSize = null, string lastEntry = null);

        /// <summary>
        /// Get a stored transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="filter">Filter</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="lastEntry">Last entry</param>
        /// <returns>Task of List&lt;TransformEndpoint&gt;</returns>
        System.Threading.Tasks.Task<List<TransformEndpoint>> CarrierservicesTransformendpointsGetAsync (string filter = null, string pageSize = null, string lastEntry = null);

        /// <summary>
        /// Get a stored transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="filter">Filter</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="lastEntry">Last entry</param>
        /// <returns>Task of ApiResponse (List&lt;TransformEndpoint&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<TransformEndpoint>>> CarrierservicesTransformendpointsGetAsyncWithHttpInfo (string filter = null, string pageSize = null, string lastEntry = null);
        
        /// <summary>
        /// Add a new transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>TransformEndpoint</returns>
        TransformEndpoint CarrierservicesTransformendpointsPost (TransformEndpoint body = null);
  
        /// <summary>
        /// Add a new transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of TransformEndpoint</returns>
        ApiResponse<TransformEndpoint> CarrierservicesTransformendpointsPostWithHttpInfo (TransformEndpoint body = null);

        /// <summary>
        /// Add a new transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of TransformEndpoint</returns>
        System.Threading.Tasks.Task<TransformEndpoint> CarrierservicesTransformendpointsPostAsync (TransformEndpoint body = null);

        /// <summary>
        /// Add a new transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TransformEndpoint)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransformEndpoint>> CarrierservicesTransformendpointsPostAsyncWithHttpInfo (TransformEndpoint body = null);
        
        /// <summary>
        /// Get a stored Endpoint plan for uploaded Transforms
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Endpoint ID</param>
        /// <returns>TransformEndpoint</returns>
        TransformEndpoint CarrierservicesTransformendpointsIdGet (string id);
  
        /// <summary>
        /// Get a stored Endpoint plan for uploaded Transforms
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Endpoint ID</param>
        /// <returns>ApiResponse of TransformEndpoint</returns>
        ApiResponse<TransformEndpoint> CarrierservicesTransformendpointsIdGetWithHttpInfo (string id);

        /// <summary>
        /// Get a stored Endpoint plan for uploaded Transforms
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Endpoint ID</param>
        /// <returns>Task of TransformEndpoint</returns>
        System.Threading.Tasks.Task<TransformEndpoint> CarrierservicesTransformendpointsIdGetAsync (string id);

        /// <summary>
        /// Get a stored Endpoint plan for uploaded Transforms
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Endpoint ID</param>
        /// <returns>Task of ApiResponse (TransformEndpoint)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransformEndpoint>> CarrierservicesTransformendpointsIdGetAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// Update an existing Endpoint plan for uploaded Transforms
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Endpoint ID</param>
        /// <param name="body"></param>
        /// <returns>TransformEndpoint</returns>
        TransformEndpoint CarrierservicesTransformendpointsIdPut (string id, TransformEndpoint body = null);
  
        /// <summary>
        /// Update an existing Endpoint plan for uploaded Transforms
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Endpoint ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of TransformEndpoint</returns>
        ApiResponse<TransformEndpoint> CarrierservicesTransformendpointsIdPutWithHttpInfo (string id, TransformEndpoint body = null);

        /// <summary>
        /// Update an existing Endpoint plan for uploaded Transforms
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Endpoint ID</param>
        /// <param name="body"></param>
        /// <returns>Task of TransformEndpoint</returns>
        System.Threading.Tasks.Task<TransformEndpoint> CarrierservicesTransformendpointsIdPutAsync (string id, TransformEndpoint body = null);

        /// <summary>
        /// Update an existing Endpoint plan for uploaded Transforms
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Endpoint ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TransformEndpoint)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransformEndpoint>> CarrierservicesTransformendpointsIdPutAsyncWithHttpInfo (string id, TransformEndpoint body = null);
        
        /// <summary>
        /// Delete an existing Endpoint plan for uploaded Transforms
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Endpoint ID</param>
        /// <returns>string</returns>
        string CarrierservicesTransformendpointsIdDelete (string id);
  
        /// <summary>
        /// Delete an existing Endpoint plan for uploaded Transforms
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Endpoint ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> CarrierservicesTransformendpointsIdDeleteWithHttpInfo (string id);

        /// <summary>
        /// Delete an existing Endpoint plan for uploaded Transforms
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Endpoint ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> CarrierservicesTransformendpointsIdDeleteAsync (string id);

        /// <summary>
        /// Delete an existing Endpoint plan for uploaded Transforms
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Endpoint ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> CarrierservicesTransformendpointsIdDeleteAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// Get The progress report for transforming uploaded documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="service">Service Name</param>
        /// <returns>List&lt;TransformProgress&gt;</returns>
        List<TransformProgress> CarrierservicesTransformprogressSearchServiceGet (string service);
  
        /// <summary>
        /// Get The progress report for transforming uploaded documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="service">Service Name</param>
        /// <returns>ApiResponse of List&lt;TransformProgress&gt;</returns>
        ApiResponse<List<TransformProgress>> CarrierservicesTransformprogressSearchServiceGetWithHttpInfo (string service);

        /// <summary>
        /// Get The progress report for transforming uploaded documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="service">Service Name</param>
        /// <returns>Task of List&lt;TransformProgress&gt;</returns>
        System.Threading.Tasks.Task<List<TransformProgress>> CarrierservicesTransformprogressSearchServiceGetAsync (string service);

        /// <summary>
        /// Get The progress report for transforming uploaded documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="service">Service Name</param>
        /// <returns>Task of ApiResponse (List&lt;TransformProgress&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<TransformProgress>>> CarrierservicesTransformprogressSearchServiceGetAsyncWithHttpInfo (string service);
        
        /// <summary>
        /// Get The progress report for transforming uploaded documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="service">Service Name</param>
        /// <param name="modeltype">Model Type</param>
        /// <returns>List&lt;TransformProgress&gt;</returns>
        List<TransformProgress> CarrierservicesTransformprogressSearchServiceModeltypeGet (string service, string modeltype);
  
        /// <summary>
        /// Get The progress report for transforming uploaded documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="service">Service Name</param>
        /// <param name="modeltype">Model Type</param>
        /// <returns>ApiResponse of List&lt;TransformProgress&gt;</returns>
        ApiResponse<List<TransformProgress>> CarrierservicesTransformprogressSearchServiceModeltypeGetWithHttpInfo (string service, string modeltype);

        /// <summary>
        /// Get The progress report for transforming uploaded documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="service">Service Name</param>
        /// <param name="modeltype">Model Type</param>
        /// <returns>Task of List&lt;TransformProgress&gt;</returns>
        System.Threading.Tasks.Task<List<TransformProgress>> CarrierservicesTransformprogressSearchServiceModeltypeGetAsync (string service, string modeltype);

        /// <summary>
        /// Get The progress report for transforming uploaded documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="service">Service Name</param>
        /// <param name="modeltype">Model Type</param>
        /// <returns>Task of ApiResponse (List&lt;TransformProgress&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<TransformProgress>>> CarrierservicesTransformprogressSearchServiceModeltypeGetAsyncWithHttpInfo (string service, string modeltype);
        
        /// <summary>
        /// Get The progress report for transforming uploaded documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="service">Service Name</param>
        /// <param name="modeltype">Model Type</param>
        /// <param name="modelid">Model ID</param>
        /// <returns>List&lt;TransformProgress&gt;</returns>
        List<TransformProgress> CarrierservicesTransformprogressSearchServiceModeltypeModelidGet (string service, string modeltype, string modelid);
  
        /// <summary>
        /// Get The progress report for transforming uploaded documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="service">Service Name</param>
        /// <param name="modeltype">Model Type</param>
        /// <param name="modelid">Model ID</param>
        /// <returns>ApiResponse of List&lt;TransformProgress&gt;</returns>
        ApiResponse<List<TransformProgress>> CarrierservicesTransformprogressSearchServiceModeltypeModelidGetWithHttpInfo (string service, string modeltype, string modelid);

        /// <summary>
        /// Get The progress report for transforming uploaded documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="service">Service Name</param>
        /// <param name="modeltype">Model Type</param>
        /// <param name="modelid">Model ID</param>
        /// <returns>Task of List&lt;TransformProgress&gt;</returns>
        System.Threading.Tasks.Task<List<TransformProgress>> CarrierservicesTransformprogressSearchServiceModeltypeModelidGetAsync (string service, string modeltype, string modelid);

        /// <summary>
        /// Get The progress report for transforming uploaded documents
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="service">Service Name</param>
        /// <param name="modeltype">Model Type</param>
        /// <param name="modelid">Model ID</param>
        /// <returns>Task of ApiResponse (List&lt;TransformProgress&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<TransformProgress>>> CarrierservicesTransformprogressSearchServiceModeltypeModelidGetAsyncWithHttpInfo (string service, string modeltype, string modelid);
        
        /// <summary>
        /// The progress report for an upload
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Upload Progress ID</param>
        /// <returns>TransformProgress</returns>
        TransformProgress CarrierservicesTransformprogressIdGet (string id);
  
        /// <summary>
        /// The progress report for an upload
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Upload Progress ID</param>
        /// <returns>ApiResponse of TransformProgress</returns>
        ApiResponse<TransformProgress> CarrierservicesTransformprogressIdGetWithHttpInfo (string id);

        /// <summary>
        /// The progress report for an upload
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Upload Progress ID</param>
        /// <returns>Task of TransformProgress</returns>
        System.Threading.Tasks.Task<TransformProgress> CarrierservicesTransformprogressIdGetAsync (string id);

        /// <summary>
        /// The progress report for an upload
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Upload Progress ID</param>
        /// <returns>Task of ApiResponse (TransformProgress)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransformProgress>> CarrierservicesTransformprogressIdGetAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// Get a stored transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="filter">Filter</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="lastEntry">Last entry</param>
        /// <returns>SpreadsheetTransformEntityListing</returns>
        SpreadsheetTransformEntityListing CarrierservicesUploadtransformSpreadsheetsGet (string filter = null, string pageSize = null, string lastEntry = null);
  
        /// <summary>
        /// Get a stored transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="filter">Filter</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="lastEntry">Last entry</param>
        /// <returns>ApiResponse of SpreadsheetTransformEntityListing</returns>
        ApiResponse<SpreadsheetTransformEntityListing> CarrierservicesUploadtransformSpreadsheetsGetWithHttpInfo (string filter = null, string pageSize = null, string lastEntry = null);

        /// <summary>
        /// Get a stored transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="filter">Filter</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="lastEntry">Last entry</param>
        /// <returns>Task of SpreadsheetTransformEntityListing</returns>
        System.Threading.Tasks.Task<SpreadsheetTransformEntityListing> CarrierservicesUploadtransformSpreadsheetsGetAsync (string filter = null, string pageSize = null, string lastEntry = null);

        /// <summary>
        /// Get a stored transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="filter">Filter</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="lastEntry">Last entry</param>
        /// <returns>Task of ApiResponse (SpreadsheetTransformEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SpreadsheetTransformEntityListing>> CarrierservicesUploadtransformSpreadsheetsGetAsyncWithHttpInfo (string filter = null, string pageSize = null, string lastEntry = null);
        
        /// <summary>
        /// Add a new transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>SpreadsheetTransform</returns>
        SpreadsheetTransform CarrierservicesUploadtransformSpreadsheetsPost (SpreadsheetTransform body = null);
  
        /// <summary>
        /// Add a new transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of SpreadsheetTransform</returns>
        ApiResponse<SpreadsheetTransform> CarrierservicesUploadtransformSpreadsheetsPostWithHttpInfo (SpreadsheetTransform body = null);

        /// <summary>
        /// Add a new transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of SpreadsheetTransform</returns>
        System.Threading.Tasks.Task<SpreadsheetTransform> CarrierservicesUploadtransformSpreadsheetsPostAsync (SpreadsheetTransform body = null);

        /// <summary>
        /// Add a new transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (SpreadsheetTransform)</returns>
        System.Threading.Tasks.Task<ApiResponse<SpreadsheetTransform>> CarrierservicesUploadtransformSpreadsheetsPostAsyncWithHttpInfo (SpreadsheetTransform body = null);
        
        /// <summary>
        /// Get a stored transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Transform ID</param>
        /// <returns>SpreadsheetTransform</returns>
        SpreadsheetTransform CarrierservicesUploadtransformSpreadsheetsIdGet (string id);
  
        /// <summary>
        /// Get a stored transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Transform ID</param>
        /// <returns>ApiResponse of SpreadsheetTransform</returns>
        ApiResponse<SpreadsheetTransform> CarrierservicesUploadtransformSpreadsheetsIdGetWithHttpInfo (string id);

        /// <summary>
        /// Get a stored transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Transform ID</param>
        /// <returns>Task of SpreadsheetTransform</returns>
        System.Threading.Tasks.Task<SpreadsheetTransform> CarrierservicesUploadtransformSpreadsheetsIdGetAsync (string id);

        /// <summary>
        /// Get a stored transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Transform ID</param>
        /// <returns>Task of ApiResponse (SpreadsheetTransform)</returns>
        System.Threading.Tasks.Task<ApiResponse<SpreadsheetTransform>> CarrierservicesUploadtransformSpreadsheetsIdGetAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// Update an existing transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Transform ID</param>
        /// <param name="body"></param>
        /// <returns>SpreadsheetTransform</returns>
        SpreadsheetTransform CarrierservicesUploadtransformSpreadsheetsIdPut (string id, SpreadsheetTransform body = null);
  
        /// <summary>
        /// Update an existing transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Transform ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of SpreadsheetTransform</returns>
        ApiResponse<SpreadsheetTransform> CarrierservicesUploadtransformSpreadsheetsIdPutWithHttpInfo (string id, SpreadsheetTransform body = null);

        /// <summary>
        /// Update an existing transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Transform ID</param>
        /// <param name="body"></param>
        /// <returns>Task of SpreadsheetTransform</returns>
        System.Threading.Tasks.Task<SpreadsheetTransform> CarrierservicesUploadtransformSpreadsheetsIdPutAsync (string id, SpreadsheetTransform body = null);

        /// <summary>
        /// Update an existing transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Transform ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (SpreadsheetTransform)</returns>
        System.Threading.Tasks.Task<ApiResponse<SpreadsheetTransform>> CarrierservicesUploadtransformSpreadsheetsIdPutAsyncWithHttpInfo (string id, SpreadsheetTransform body = null);
        
        /// <summary>
        /// Delete an existing transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Transform ID</param>
        /// <returns>string</returns>
        string CarrierservicesUploadtransformSpreadsheetsIdDelete (string id);
  
        /// <summary>
        /// Delete an existing transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Transform ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> CarrierservicesUploadtransformSpreadsheetsIdDeleteWithHttpInfo (string id);

        /// <summary>
        /// Delete an existing transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Transform ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> CarrierservicesUploadtransformSpreadsheetsIdDeleteAsync (string id);

        /// <summary>
        /// Delete an existing transform plan for uploaded spreadsheets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Transform ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> CarrierservicesUploadtransformSpreadsheetsIdDeleteAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// Get a stored transform plan for uploaded delimited text tables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="filter">Filter</param>
        /// <returns>TextTableTransformEntityListing</returns>
        TextTableTransformEntityListing CarrierservicesUploadtransformTexttablesGet (string filter = null);
  
        /// <summary>
        /// Get a stored transform plan for uploaded delimited text tables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="filter">Filter</param>
        /// <returns>ApiResponse of TextTableTransformEntityListing</returns>
        ApiResponse<TextTableTransformEntityListing> CarrierservicesUploadtransformTexttablesGetWithHttpInfo (string filter = null);

        /// <summary>
        /// Get a stored transform plan for uploaded delimited text tables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="filter">Filter</param>
        /// <returns>Task of TextTableTransformEntityListing</returns>
        System.Threading.Tasks.Task<TextTableTransformEntityListing> CarrierservicesUploadtransformTexttablesGetAsync (string filter = null);

        /// <summary>
        /// Get a stored transform plan for uploaded delimited text tables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="filter">Filter</param>
        /// <returns>Task of ApiResponse (TextTableTransformEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TextTableTransformEntityListing>> CarrierservicesUploadtransformTexttablesGetAsyncWithHttpInfo (string filter = null);
        
        /// <summary>
        /// Add a new transform plan for uploaded delimited text tables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>TextTableTransform</returns>
        TextTableTransform CarrierservicesUploadtransformTexttablesPost (TextTableTransform body = null);
  
        /// <summary>
        /// Add a new transform plan for uploaded delimited text tables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of TextTableTransform</returns>
        ApiResponse<TextTableTransform> CarrierservicesUploadtransformTexttablesPostWithHttpInfo (TextTableTransform body = null);

        /// <summary>
        /// Add a new transform plan for uploaded delimited text tables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of TextTableTransform</returns>
        System.Threading.Tasks.Task<TextTableTransform> CarrierservicesUploadtransformTexttablesPostAsync (TextTableTransform body = null);

        /// <summary>
        /// Add a new transform plan for uploaded delimited text tables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TextTableTransform)</returns>
        System.Threading.Tasks.Task<ApiResponse<TextTableTransform>> CarrierservicesUploadtransformTexttablesPostAsyncWithHttpInfo (TextTableTransform body = null);
        
        /// <summary>
        /// Get a stored transform plan for uploaded delimited text tables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Transform ID</param>
        /// <returns>TextTableTransform</returns>
        TextTableTransform CarrierservicesUploadtransformTexttablesIdGet (string id);
  
        /// <summary>
        /// Get a stored transform plan for uploaded delimited text tables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Transform ID</param>
        /// <returns>ApiResponse of TextTableTransform</returns>
        ApiResponse<TextTableTransform> CarrierservicesUploadtransformTexttablesIdGetWithHttpInfo (string id);

        /// <summary>
        /// Get a stored transform plan for uploaded delimited text tables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Transform ID</param>
        /// <returns>Task of TextTableTransform</returns>
        System.Threading.Tasks.Task<TextTableTransform> CarrierservicesUploadtransformTexttablesIdGetAsync (string id);

        /// <summary>
        /// Get a stored transform plan for uploaded delimited text tables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Transform ID</param>
        /// <returns>Task of ApiResponse (TextTableTransform)</returns>
        System.Threading.Tasks.Task<ApiResponse<TextTableTransform>> CarrierservicesUploadtransformTexttablesIdGetAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// Update an existing transform plan for uploaded delimited text tables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Transform ID</param>
        /// <param name="body"></param>
        /// <returns>TextTableTransform</returns>
        TextTableTransform CarrierservicesUploadtransformTexttablesIdPut (string id, TextTableTransform body = null);
  
        /// <summary>
        /// Update an existing transform plan for uploaded delimited text tables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Transform ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of TextTableTransform</returns>
        ApiResponse<TextTableTransform> CarrierservicesUploadtransformTexttablesIdPutWithHttpInfo (string id, TextTableTransform body = null);

        /// <summary>
        /// Update an existing transform plan for uploaded delimited text tables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Transform ID</param>
        /// <param name="body"></param>
        /// <returns>Task of TextTableTransform</returns>
        System.Threading.Tasks.Task<TextTableTransform> CarrierservicesUploadtransformTexttablesIdPutAsync (string id, TextTableTransform body = null);

        /// <summary>
        /// Update an existing transform plan for uploaded delimited text tables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Transform ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TextTableTransform)</returns>
        System.Threading.Tasks.Task<ApiResponse<TextTableTransform>> CarrierservicesUploadtransformTexttablesIdPutAsyncWithHttpInfo (string id, TextTableTransform body = null);
        
        /// <summary>
        /// Delete an existing transform plan for uploaded delimited text tables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Transform ID</param>
        /// <returns>string</returns>
        string CarrierservicesUploadtransformTexttablesIdDelete (string id);
  
        /// <summary>
        /// Delete an existing transform plan for uploaded delimited text tables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Transform ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> CarrierservicesUploadtransformTexttablesIdDeleteWithHttpInfo (string id);

        /// <summary>
        /// Delete an existing transform plan for uploaded delimited text tables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Transform ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> CarrierservicesUploadtransformTexttablesIdDeleteAsync (string id);

        /// <summary>
        /// Delete an existing transform plan for uploaded delimited text tables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Transform ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> CarrierservicesUploadtransformTexttablesIdDeleteAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// Get all available XLSX schemas.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>XlsxSchema</returns>
        XlsxSchema CarrierservicesXlsxschemasGet ();
  
        /// <summary>
        /// Get all available XLSX schemas.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of XlsxSchema</returns>
        ApiResponse<XlsxSchema> CarrierservicesXlsxschemasGetWithHttpInfo ();

        /// <summary>
        /// Get all available XLSX schemas.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of XlsxSchema</returns>
        System.Threading.Tasks.Task<XlsxSchema> CarrierservicesXlsxschemasGetAsync ();

        /// <summary>
        /// Get all available XLSX schemas.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (XlsxSchema)</returns>
        System.Threading.Tasks.Task<ApiResponse<XlsxSchema>> CarrierservicesXlsxschemasGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get all XLSX schemas for a given carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <returns>XlsxSchema</returns>
        XlsxSchema CarrierservicesXlsxschemasCarrieridGet (string carrierId);
  
        /// <summary>
        /// Get all XLSX schemas for a given carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <returns>ApiResponse of XlsxSchema</returns>
        ApiResponse<XlsxSchema> CarrierservicesXlsxschemasCarrieridGetWithHttpInfo (string carrierId);

        /// <summary>
        /// Get all XLSX schemas for a given carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <returns>Task of XlsxSchema</returns>
        System.Threading.Tasks.Task<XlsxSchema> CarrierservicesXlsxschemasCarrieridGetAsync (string carrierId);

        /// <summary>
        /// Get all XLSX schemas for a given carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <returns>Task of ApiResponse (XlsxSchema)</returns>
        System.Threading.Tasks.Task<ApiResponse<XlsxSchema>> CarrierservicesXlsxschemasCarrieridGetAsyncWithHttpInfo (string carrierId);
        
        /// <summary>
        /// Updates or creates a XLSX schema for a carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="body">Schema data</param>
        /// <returns>XlsxSchema</returns>
        XlsxSchema CarrierservicesXlsxschemasCarrieridPut (string carrierId, XlsxSchema body = null);
  
        /// <summary>
        /// Updates or creates a XLSX schema for a carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="body">Schema data</param>
        /// <returns>ApiResponse of XlsxSchema</returns>
        ApiResponse<XlsxSchema> CarrierservicesXlsxschemasCarrieridPutWithHttpInfo (string carrierId, XlsxSchema body = null);

        /// <summary>
        /// Updates or creates a XLSX schema for a carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="body">Schema data</param>
        /// <returns>Task of XlsxSchema</returns>
        System.Threading.Tasks.Task<XlsxSchema> CarrierservicesXlsxschemasCarrieridPutAsync (string carrierId, XlsxSchema body = null);

        /// <summary>
        /// Updates or creates a XLSX schema for a carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="body">Schema data</param>
        /// <returns>Task of ApiResponse (XlsxSchema)</returns>
        System.Threading.Tasks.Task<ApiResponse<XlsxSchema>> CarrierservicesXlsxschemasCarrieridPutAsyncWithHttpInfo (string carrierId, XlsxSchema body = null);
        
        /// <summary>
        /// Get all XLSX schemas for a given carrier and name.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="name">Schema name</param>
        /// <returns>XlsxSchema</returns>
        XlsxSchema CarrierservicesXlsxschemasCarrieridNameNameGet (string carrierId, string name);
  
        /// <summary>
        /// Get all XLSX schemas for a given carrier and name.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="name">Schema name</param>
        /// <returns>ApiResponse of XlsxSchema</returns>
        ApiResponse<XlsxSchema> CarrierservicesXlsxschemasCarrieridNameNameGetWithHttpInfo (string carrierId, string name);

        /// <summary>
        /// Get all XLSX schemas for a given carrier and name.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="name">Schema name</param>
        /// <returns>Task of XlsxSchema</returns>
        System.Threading.Tasks.Task<XlsxSchema> CarrierservicesXlsxschemasCarrieridNameNameGetAsync (string carrierId, string name);

        /// <summary>
        /// Get all XLSX schemas for a given carrier and name.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="name">Schema name</param>
        /// <returns>Task of ApiResponse (XlsxSchema)</returns>
        System.Threading.Tasks.Task<ApiResponse<XlsxSchema>> CarrierservicesXlsxschemasCarrieridNameNameGetAsyncWithHttpInfo (string carrierId, string name);
        
        /// <summary>
        /// Deletes a XLSX schema for a carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="name">Schema name</param>
        /// <returns>XlsxSchema</returns>
        XlsxSchema CarrierservicesXlsxschemasCarrieridNameNameDelete (string carrierId, string name);
  
        /// <summary>
        /// Deletes a XLSX schema for a carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="name">Schema name</param>
        /// <returns>ApiResponse of XlsxSchema</returns>
        ApiResponse<XlsxSchema> CarrierservicesXlsxschemasCarrieridNameNameDeleteWithHttpInfo (string carrierId, string name);

        /// <summary>
        /// Deletes a XLSX schema for a carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="name">Schema name</param>
        /// <returns>Task of XlsxSchema</returns>
        System.Threading.Tasks.Task<XlsxSchema> CarrierservicesXlsxschemasCarrieridNameNameDeleteAsync (string carrierId, string name);

        /// <summary>
        /// Deletes a XLSX schema for a carrier.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="name">Schema name</param>
        /// <returns>Task of ApiResponse (XlsxSchema)</returns>
        System.Threading.Tasks.Task<ApiResponse<XlsxSchema>> CarrierservicesXlsxschemasCarrieridNameNameDeleteAsyncWithHttpInfo (string carrierId, string name);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CarrierServicesApi : ICarrierServicesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierServicesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CarrierServicesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierServicesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CarrierServicesApi(Configuration configuration = null)
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
        /// Get the list of carriers 
        /// </summary>
        /// <returns>CarrierEntityListing</returns>
        public CarrierEntityListing CarrierservicesCarriersGet ()
        {
             ApiResponse<CarrierEntityListing> response = CarrierservicesCarriersGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get the list of carriers 
        /// </summary>
        /// <returns>ApiResponse of CarrierEntityListing</returns>
        public ApiResponse< CarrierEntityListing > CarrierservicesCarriersGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/carrierservices/carriers";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CarrierEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CarrierEntityListing) Configuration.ApiClient.Deserialize(response, typeof(CarrierEntityListing)));
            
        }
    
        /// <summary>
        /// Get the list of carriers 
        /// </summary>
        /// <returns>Task of CarrierEntityListing</returns>
        public async System.Threading.Tasks.Task<CarrierEntityListing> CarrierservicesCarriersGetAsync ()
        {
             ApiResponse<CarrierEntityListing> response = await CarrierservicesCarriersGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get the list of carriers 
        /// </summary>
        /// <returns>Task of ApiResponse (CarrierEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CarrierEntityListing>> CarrierservicesCarriersGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/carrierservices/carriers";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CarrierEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CarrierEntityListing) Configuration.ApiClient.Deserialize(response, typeof(CarrierEntityListing)));
            
        }
        
        /// <summary>
        /// Create a carrier 
        /// </summary>
        /// <param name="body">Carrier data</param> 
        /// <returns>CarrierEntityListing</returns>
        public CarrierEntityListing CarrierservicesCarriersPost (List<Carrier> body = null)
        {
             ApiResponse<CarrierEntityListing> response = CarrierservicesCarriersPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a carrier 
        /// </summary>
        /// <param name="body">Carrier data</param> 
        /// <returns>ApiResponse of CarrierEntityListing</returns>
        public ApiResponse< CarrierEntityListing > CarrierservicesCarriersPostWithHttpInfo (List<Carrier> body = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/carriers";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CarrierEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CarrierEntityListing) Configuration.ApiClient.Deserialize(response, typeof(CarrierEntityListing)));
            
        }
    
        /// <summary>
        /// Create a carrier 
        /// </summary>
        /// <param name="body">Carrier data</param>
        /// <returns>Task of CarrierEntityListing</returns>
        public async System.Threading.Tasks.Task<CarrierEntityListing> CarrierservicesCarriersPostAsync (List<Carrier> body = null)
        {
             ApiResponse<CarrierEntityListing> response = await CarrierservicesCarriersPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a carrier 
        /// </summary>
        /// <param name="body">Carrier data</param>
        /// <returns>Task of ApiResponse (CarrierEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CarrierEntityListing>> CarrierservicesCarriersPostAsyncWithHttpInfo (List<Carrier> body = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/carriers";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CarrierEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CarrierEntityListing) Configuration.ApiClient.Deserialize(response, typeof(CarrierEntityListing)));
            
        }
        
        /// <summary>
        /// Get specified carrier by its carrier id 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <returns>Carrier</returns>
        public Carrier CarrierservicesCarriersCarrieridGet (string carrierId)
        {
             ApiResponse<Carrier> response = CarrierservicesCarriersCarrieridGetWithHttpInfo(carrierId);
             return response.Data;
        }

        /// <summary>
        /// Get specified carrier by its carrier id 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <returns>ApiResponse of Carrier</returns>
        public ApiResponse< Carrier > CarrierservicesCarriersCarrieridGetWithHttpInfo (string carrierId)
        {
            
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesCarriersCarrieridGet");
            
    
            var path_ = "/api/v1/carrierservices/carriers/{carrierId}";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Carrier>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Carrier) Configuration.ApiClient.Deserialize(response, typeof(Carrier)));
            
        }
    
        /// <summary>
        /// Get specified carrier by its carrier id 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <returns>Task of Carrier</returns>
        public async System.Threading.Tasks.Task<Carrier> CarrierservicesCarriersCarrieridGetAsync (string carrierId)
        {
             ApiResponse<Carrier> response = await CarrierservicesCarriersCarrieridGetAsyncWithHttpInfo(carrierId);
             return response.Data;

        }

        /// <summary>
        /// Get specified carrier by its carrier id 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <returns>Task of ApiResponse (Carrier)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Carrier>> CarrierservicesCarriersCarrieridGetAsyncWithHttpInfo (string carrierId)
        {
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesCarriersCarrieridGet");
            
    
            var path_ = "/api/v1/carrierservices/carriers/{carrierId}";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Carrier>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Carrier) Configuration.ApiClient.Deserialize(response, typeof(Carrier)));
            
        }
        
        /// <summary>
        /// Update a carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <param name="body">Carrier data</param> 
        /// <returns>Carrier</returns>
        public Carrier CarrierservicesCarriersCarrieridPut (string carrierId, Carrier body = null)
        {
             ApiResponse<Carrier> response = CarrierservicesCarriersCarrieridPutWithHttpInfo(carrierId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <param name="body">Carrier data</param> 
        /// <returns>ApiResponse of Carrier</returns>
        public ApiResponse< Carrier > CarrierservicesCarriersCarrieridPutWithHttpInfo (string carrierId, Carrier body = null)
        {
            
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesCarriersCarrieridPut");
            
    
            var path_ = "/api/v1/carrierservices/carriers/{carrierId}";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Carrier>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Carrier) Configuration.ApiClient.Deserialize(response, typeof(Carrier)));
            
        }
    
        /// <summary>
        /// Update a carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="body">Carrier data</param>
        /// <returns>Task of Carrier</returns>
        public async System.Threading.Tasks.Task<Carrier> CarrierservicesCarriersCarrieridPutAsync (string carrierId, Carrier body = null)
        {
             ApiResponse<Carrier> response = await CarrierservicesCarriersCarrieridPutAsyncWithHttpInfo(carrierId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="body">Carrier data</param>
        /// <returns>Task of ApiResponse (Carrier)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Carrier>> CarrierservicesCarriersCarrieridPutAsyncWithHttpInfo (string carrierId, Carrier body = null)
        {
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesCarriersCarrieridPut");
            
    
            var path_ = "/api/v1/carrierservices/carriers/{carrierId}";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Carrier>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Carrier) Configuration.ApiClient.Deserialize(response, typeof(Carrier)));
            
        }
        
        /// <summary>
        /// Retrieves all services for a given carrier (i.e. OUTBOUND, INBOUND...) 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <param name="fields">Fields</param> 
        /// <param name="filter">Filter</param> 
        /// <returns>ServiceEntityListing</returns>
        public ServiceEntityListing CarrierservicesCarriersCarrieridServicesGet (string carrierId, List<string> fields = null, string filter = null)
        {
             ApiResponse<ServiceEntityListing> response = CarrierservicesCarriersCarrieridServicesGetWithHttpInfo(carrierId, fields, filter);
             return response.Data;
        }

        /// <summary>
        /// Retrieves all services for a given carrier (i.e. OUTBOUND, INBOUND...) 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <param name="fields">Fields</param> 
        /// <param name="filter">Filter</param> 
        /// <returns>ApiResponse of ServiceEntityListing</returns>
        public ApiResponse< ServiceEntityListing > CarrierservicesCarriersCarrieridServicesGetWithHttpInfo (string carrierId, List<string> fields = null, string filter = null)
        {
            
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesCarriersCarrieridServicesGet");
            
    
            var path_ = "/api/v1/carrierservices/carriers/{carrierId}/services";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            
            if (fields != null) queryParams.Add("fields", Configuration.ApiClient.ParameterToString(fields)); // query parameter
            if (filter != null) queryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridServicesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridServicesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ServiceEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServiceEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ServiceEntityListing)));
            
        }
    
        /// <summary>
        /// Retrieves all services for a given carrier (i.e. OUTBOUND, INBOUND...) 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="fields">Fields</param>
        /// <param name="filter">Filter</param>
        /// <returns>Task of ServiceEntityListing</returns>
        public async System.Threading.Tasks.Task<ServiceEntityListing> CarrierservicesCarriersCarrieridServicesGetAsync (string carrierId, List<string> fields = null, string filter = null)
        {
             ApiResponse<ServiceEntityListing> response = await CarrierservicesCarriersCarrieridServicesGetAsyncWithHttpInfo(carrierId, fields, filter);
             return response.Data;

        }

        /// <summary>
        /// Retrieves all services for a given carrier (i.e. OUTBOUND, INBOUND...) 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="fields">Fields</param>
        /// <param name="filter">Filter</param>
        /// <returns>Task of ApiResponse (ServiceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServiceEntityListing>> CarrierservicesCarriersCarrieridServicesGetAsyncWithHttpInfo (string carrierId, List<string> fields = null, string filter = null)
        {
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesCarriersCarrieridServicesGet");
            
    
            var path_ = "/api/v1/carrierservices/carriers/{carrierId}/services";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            
            if (fields != null) queryParams.Add("fields", Configuration.ApiClient.ParameterToString(fields)); // query parameter
            if (filter != null) queryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridServicesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridServicesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ServiceEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServiceEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ServiceEntityListing)));
            
        }
        
        /// <summary>
        /// Creates a carrier service of a specified type (i.e. OUTBOUND, INBOUND...) 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <param name="body"></param> 
        /// <returns>Service</returns>
        public Service CarrierservicesCarriersCarrieridServicesPost (string carrierId, Service body = null)
        {
             ApiResponse<Service> response = CarrierservicesCarriersCarrieridServicesPostWithHttpInfo(carrierId, body);
             return response.Data;
        }

        /// <summary>
        /// Creates a carrier service of a specified type (i.e. OUTBOUND, INBOUND...) 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Service</returns>
        public ApiResponse< Service > CarrierservicesCarriersCarrieridServicesPostWithHttpInfo (string carrierId, Service body = null)
        {
            
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesCarriersCarrieridServicesPost");
            
    
            var path_ = "/api/v1/carrierservices/carriers/{carrierId}/services";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridServicesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridServicesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Service>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Service) Configuration.ApiClient.Deserialize(response, typeof(Service)));
            
        }
    
        /// <summary>
        /// Creates a carrier service of a specified type (i.e. OUTBOUND, INBOUND...) 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Service</returns>
        public async System.Threading.Tasks.Task<Service> CarrierservicesCarriersCarrieridServicesPostAsync (string carrierId, Service body = null)
        {
             ApiResponse<Service> response = await CarrierservicesCarriersCarrieridServicesPostAsyncWithHttpInfo(carrierId, body);
             return response.Data;

        }

        /// <summary>
        /// Creates a carrier service of a specified type (i.e. OUTBOUND, INBOUND...) 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Service)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Service>> CarrierservicesCarriersCarrieridServicesPostAsyncWithHttpInfo (string carrierId, Service body = null)
        {
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesCarriersCarrieridServicesPost");
            
    
            var path_ = "/api/v1/carrierservices/carriers/{carrierId}/services";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridServicesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridServicesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Service>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Service) Configuration.ApiClient.Deserialize(response, typeof(Service)));
            
        }
        
        /// <summary>
        /// Retrieves a specific service for a given carrier (i.e. OUTBOUND, INBOUND...) 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <param name="serviceId">Service ID</param> 
        /// <param name="fields">Fields</param> 
        /// <returns>Service</returns>
        public Service CarrierservicesCarriersCarrieridServicesServiceidGet (string carrierId, string serviceId, List<string> fields = null)
        {
             ApiResponse<Service> response = CarrierservicesCarriersCarrieridServicesServiceidGetWithHttpInfo(carrierId, serviceId, fields);
             return response.Data;
        }

        /// <summary>
        /// Retrieves a specific service for a given carrier (i.e. OUTBOUND, INBOUND...) 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <param name="serviceId">Service ID</param> 
        /// <param name="fields">Fields</param> 
        /// <returns>ApiResponse of Service</returns>
        public ApiResponse< Service > CarrierservicesCarriersCarrieridServicesServiceidGetWithHttpInfo (string carrierId, string serviceId, List<string> fields = null)
        {
            
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesCarriersCarrieridServicesServiceidGet");
            
            // verify the required parameter 'serviceId' is set
            if (serviceId == null) throw new ApiException(400, "Missing required parameter 'serviceId' when calling CarrierservicesCarriersCarrieridServicesServiceidGet");
            
    
            var path_ = "/api/v1/carrierservices/carriers/{carrierId}/services/{serviceId}";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            if (serviceId != null) pathParams.Add("serviceId", Configuration.ApiClient.ParameterToString(serviceId)); // path parameter
            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridServicesServiceidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridServicesServiceidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Service>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Service) Configuration.ApiClient.Deserialize(response, typeof(Service)));
            
        }
    
        /// <summary>
        /// Retrieves a specific service for a given carrier (i.e. OUTBOUND, INBOUND...) 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="serviceId">Service ID</param>
        /// <param name="fields">Fields</param>
        /// <returns>Task of Service</returns>
        public async System.Threading.Tasks.Task<Service> CarrierservicesCarriersCarrieridServicesServiceidGetAsync (string carrierId, string serviceId, List<string> fields = null)
        {
             ApiResponse<Service> response = await CarrierservicesCarriersCarrieridServicesServiceidGetAsyncWithHttpInfo(carrierId, serviceId, fields);
             return response.Data;

        }

        /// <summary>
        /// Retrieves a specific service for a given carrier (i.e. OUTBOUND, INBOUND...) 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="serviceId">Service ID</param>
        /// <param name="fields">Fields</param>
        /// <returns>Task of ApiResponse (Service)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Service>> CarrierservicesCarriersCarrieridServicesServiceidGetAsyncWithHttpInfo (string carrierId, string serviceId, List<string> fields = null)
        {
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesCarriersCarrieridServicesServiceidGet");
            // verify the required parameter 'serviceId' is set
            if (serviceId == null) throw new ApiException(400, "Missing required parameter 'serviceId' when calling CarrierservicesCarriersCarrieridServicesServiceidGet");
            
    
            var path_ = "/api/v1/carrierservices/carriers/{carrierId}/services/{serviceId}";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            if (serviceId != null) pathParams.Add("serviceId", Configuration.ApiClient.ParameterToString(serviceId)); // path parameter
            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridServicesServiceidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridServicesServiceidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Service>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Service) Configuration.ApiClient.Deserialize(response, typeof(Service)));
            
        }
        
        /// <summary>
        /// Updates a specific service for a given carrier (i.e. OUTBOUND, INBOUND...) 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <param name="serviceId">Service ID</param> 
        /// <param name="body"></param> 
        /// <returns>Service</returns>
        public Service CarrierservicesCarriersCarrieridServicesServiceidPut (string carrierId, string serviceId, Service body = null)
        {
             ApiResponse<Service> response = CarrierservicesCarriersCarrieridServicesServiceidPutWithHttpInfo(carrierId, serviceId, body);
             return response.Data;
        }

        /// <summary>
        /// Updates a specific service for a given carrier (i.e. OUTBOUND, INBOUND...) 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <param name="serviceId">Service ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Service</returns>
        public ApiResponse< Service > CarrierservicesCarriersCarrieridServicesServiceidPutWithHttpInfo (string carrierId, string serviceId, Service body = null)
        {
            
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesCarriersCarrieridServicesServiceidPut");
            
            // verify the required parameter 'serviceId' is set
            if (serviceId == null) throw new ApiException(400, "Missing required parameter 'serviceId' when calling CarrierservicesCarriersCarrieridServicesServiceidPut");
            
    
            var path_ = "/api/v1/carrierservices/carriers/{carrierId}/services/{serviceId}";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            if (serviceId != null) pathParams.Add("serviceId", Configuration.ApiClient.ParameterToString(serviceId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridServicesServiceidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridServicesServiceidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Service>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Service) Configuration.ApiClient.Deserialize(response, typeof(Service)));
            
        }
    
        /// <summary>
        /// Updates a specific service for a given carrier (i.e. OUTBOUND, INBOUND...) 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="serviceId">Service ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Service</returns>
        public async System.Threading.Tasks.Task<Service> CarrierservicesCarriersCarrieridServicesServiceidPutAsync (string carrierId, string serviceId, Service body = null)
        {
             ApiResponse<Service> response = await CarrierservicesCarriersCarrieridServicesServiceidPutAsyncWithHttpInfo(carrierId, serviceId, body);
             return response.Data;

        }

        /// <summary>
        /// Updates a specific service for a given carrier (i.e. OUTBOUND, INBOUND...) 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="serviceId">Service ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Service)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Service>> CarrierservicesCarriersCarrieridServicesServiceidPutAsyncWithHttpInfo (string carrierId, string serviceId, Service body = null)
        {
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesCarriersCarrieridServicesServiceidPut");
            // verify the required parameter 'serviceId' is set
            if (serviceId == null) throw new ApiException(400, "Missing required parameter 'serviceId' when calling CarrierservicesCarriersCarrieridServicesServiceidPut");
            
    
            var path_ = "/api/v1/carrierservices/carriers/{carrierId}/services/{serviceId}";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            if (serviceId != null) pathParams.Add("serviceId", Configuration.ApiClient.ParameterToString(serviceId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridServicesServiceidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridServicesServiceidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Service>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Service) Configuration.ApiClient.Deserialize(response, typeof(Service)));
            
        }
        
        /// <summary>
        /// Deletes a specific service for a given carrier (i.e. OUTBOUND, INBOUND...) 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <param name="serviceId">Service ID</param> 
        /// <returns>Service</returns>
        public Service CarrierservicesCarriersCarrieridServicesServiceidDelete (string carrierId, string serviceId)
        {
             ApiResponse<Service> response = CarrierservicesCarriersCarrieridServicesServiceidDeleteWithHttpInfo(carrierId, serviceId);
             return response.Data;
        }

        /// <summary>
        /// Deletes a specific service for a given carrier (i.e. OUTBOUND, INBOUND...) 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <param name="serviceId">Service ID</param> 
        /// <returns>ApiResponse of Service</returns>
        public ApiResponse< Service > CarrierservicesCarriersCarrieridServicesServiceidDeleteWithHttpInfo (string carrierId, string serviceId)
        {
            
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesCarriersCarrieridServicesServiceidDelete");
            
            // verify the required parameter 'serviceId' is set
            if (serviceId == null) throw new ApiException(400, "Missing required parameter 'serviceId' when calling CarrierservicesCarriersCarrieridServicesServiceidDelete");
            
    
            var path_ = "/api/v1/carrierservices/carriers/{carrierId}/services/{serviceId}";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            if (serviceId != null) pathParams.Add("serviceId", Configuration.ApiClient.ParameterToString(serviceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridServicesServiceidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridServicesServiceidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Service>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Service) Configuration.ApiClient.Deserialize(response, typeof(Service)));
            
        }
    
        /// <summary>
        /// Deletes a specific service for a given carrier (i.e. OUTBOUND, INBOUND...) 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="serviceId">Service ID</param>
        /// <returns>Task of Service</returns>
        public async System.Threading.Tasks.Task<Service> CarrierservicesCarriersCarrieridServicesServiceidDeleteAsync (string carrierId, string serviceId)
        {
             ApiResponse<Service> response = await CarrierservicesCarriersCarrieridServicesServiceidDeleteAsyncWithHttpInfo(carrierId, serviceId);
             return response.Data;

        }

        /// <summary>
        /// Deletes a specific service for a given carrier (i.e. OUTBOUND, INBOUND...) 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="serviceId">Service ID</param>
        /// <returns>Task of ApiResponse (Service)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Service>> CarrierservicesCarriersCarrieridServicesServiceidDeleteAsyncWithHttpInfo (string carrierId, string serviceId)
        {
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesCarriersCarrieridServicesServiceidDelete");
            // verify the required parameter 'serviceId' is set
            if (serviceId == null) throw new ApiException(400, "Missing required parameter 'serviceId' when calling CarrierservicesCarriersCarrieridServicesServiceidDelete");
            
    
            var path_ = "/api/v1/carrierservices/carriers/{carrierId}/services/{serviceId}";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            if (serviceId != null) pathParams.Add("serviceId", Configuration.ApiClient.ParameterToString(serviceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridServicesServiceidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCarriersCarrieridServicesServiceidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Service>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Service) Configuration.ApiClient.Deserialize(response, typeof(Service)));
            
        }
        
        /// <summary>
        /// Get all CSV schemas available. 
        /// </summary>
        /// <returns>CsvSchema</returns>
        public CsvSchema CarrierservicesCsvschemasGet ()
        {
             ApiResponse<CsvSchema> response = CarrierservicesCsvschemasGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get all CSV schemas available. 
        /// </summary>
        /// <returns>ApiResponse of CsvSchema</returns>
        public ApiResponse< CsvSchema > CarrierservicesCsvschemasGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/carrierservices/csvschemas";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCsvschemasGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCsvschemasGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CsvSchema>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CsvSchema) Configuration.ApiClient.Deserialize(response, typeof(CsvSchema)));
            
        }
    
        /// <summary>
        /// Get all CSV schemas available. 
        /// </summary>
        /// <returns>Task of CsvSchema</returns>
        public async System.Threading.Tasks.Task<CsvSchema> CarrierservicesCsvschemasGetAsync ()
        {
             ApiResponse<CsvSchema> response = await CarrierservicesCsvschemasGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get all CSV schemas available. 
        /// </summary>
        /// <returns>Task of ApiResponse (CsvSchema)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CsvSchema>> CarrierservicesCsvschemasGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/carrierservices/csvschemas";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCsvschemasGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCsvschemasGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CsvSchema>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CsvSchema) Configuration.ApiClient.Deserialize(response, typeof(CsvSchema)));
            
        }
        
        /// <summary>
        /// Get all CSV schemas for a given carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <returns>CsvSchema</returns>
        public CsvSchema CarrierservicesCsvschemasCarrieridGet (string carrierId)
        {
             ApiResponse<CsvSchema> response = CarrierservicesCsvschemasCarrieridGetWithHttpInfo(carrierId);
             return response.Data;
        }

        /// <summary>
        /// Get all CSV schemas for a given carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <returns>ApiResponse of CsvSchema</returns>
        public ApiResponse< CsvSchema > CarrierservicesCsvschemasCarrieridGetWithHttpInfo (string carrierId)
        {
            
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesCsvschemasCarrieridGet");
            
    
            var path_ = "/api/v1/carrierservices/csvschemas/{carrierId}";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCsvschemasCarrieridGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCsvschemasCarrieridGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CsvSchema>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CsvSchema) Configuration.ApiClient.Deserialize(response, typeof(CsvSchema)));
            
        }
    
        /// <summary>
        /// Get all CSV schemas for a given carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <returns>Task of CsvSchema</returns>
        public async System.Threading.Tasks.Task<CsvSchema> CarrierservicesCsvschemasCarrieridGetAsync (string carrierId)
        {
             ApiResponse<CsvSchema> response = await CarrierservicesCsvschemasCarrieridGetAsyncWithHttpInfo(carrierId);
             return response.Data;

        }

        /// <summary>
        /// Get all CSV schemas for a given carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <returns>Task of ApiResponse (CsvSchema)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CsvSchema>> CarrierservicesCsvschemasCarrieridGetAsyncWithHttpInfo (string carrierId)
        {
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesCsvschemasCarrieridGet");
            
    
            var path_ = "/api/v1/carrierservices/csvschemas/{carrierId}";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCsvschemasCarrieridGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCsvschemasCarrieridGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CsvSchema>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CsvSchema) Configuration.ApiClient.Deserialize(response, typeof(CsvSchema)));
            
        }
        
        /// <summary>
        /// Updates or creates a CSV schema for a carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <param name="body">Schema data</param> 
        /// <returns>CsvSchema</returns>
        public CsvSchema CarrierservicesCsvschemasCarrieridPut (string carrierId, CsvSchema body = null)
        {
             ApiResponse<CsvSchema> response = CarrierservicesCsvschemasCarrieridPutWithHttpInfo(carrierId, body);
             return response.Data;
        }

        /// <summary>
        /// Updates or creates a CSV schema for a carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <param name="body">Schema data</param> 
        /// <returns>ApiResponse of CsvSchema</returns>
        public ApiResponse< CsvSchema > CarrierservicesCsvschemasCarrieridPutWithHttpInfo (string carrierId, CsvSchema body = null)
        {
            
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesCsvschemasCarrieridPut");
            
    
            var path_ = "/api/v1/carrierservices/csvschemas/{carrierId}";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCsvschemasCarrieridPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCsvschemasCarrieridPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CsvSchema>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CsvSchema) Configuration.ApiClient.Deserialize(response, typeof(CsvSchema)));
            
        }
    
        /// <summary>
        /// Updates or creates a CSV schema for a carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="body">Schema data</param>
        /// <returns>Task of CsvSchema</returns>
        public async System.Threading.Tasks.Task<CsvSchema> CarrierservicesCsvschemasCarrieridPutAsync (string carrierId, CsvSchema body = null)
        {
             ApiResponse<CsvSchema> response = await CarrierservicesCsvschemasCarrieridPutAsyncWithHttpInfo(carrierId, body);
             return response.Data;

        }

        /// <summary>
        /// Updates or creates a CSV schema for a carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="body">Schema data</param>
        /// <returns>Task of ApiResponse (CsvSchema)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CsvSchema>> CarrierservicesCsvschemasCarrieridPutAsyncWithHttpInfo (string carrierId, CsvSchema body = null)
        {
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesCsvschemasCarrieridPut");
            
    
            var path_ = "/api/v1/carrierservices/csvschemas/{carrierId}";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCsvschemasCarrieridPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCsvschemasCarrieridPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CsvSchema>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CsvSchema) Configuration.ApiClient.Deserialize(response, typeof(CsvSchema)));
            
        }
        
        /// <summary>
        /// Get all CSV schemas for a given carrier and name. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <param name="name">Schema name</param> 
        /// <returns>CsvSchema</returns>
        public CsvSchema CarrierservicesCsvschemasCarrieridNameNameGet (string carrierId, string name)
        {
             ApiResponse<CsvSchema> response = CarrierservicesCsvschemasCarrieridNameNameGetWithHttpInfo(carrierId, name);
             return response.Data;
        }

        /// <summary>
        /// Get all CSV schemas for a given carrier and name. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <param name="name">Schema name</param> 
        /// <returns>ApiResponse of CsvSchema</returns>
        public ApiResponse< CsvSchema > CarrierservicesCsvschemasCarrieridNameNameGetWithHttpInfo (string carrierId, string name)
        {
            
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesCsvschemasCarrieridNameNameGet");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling CarrierservicesCsvschemasCarrieridNameNameGet");
            
    
            var path_ = "/api/v1/carrierservices/csvschemas/{carrierId}/name/{name}";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            if (name != null) pathParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCsvschemasCarrieridNameNameGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCsvschemasCarrieridNameNameGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CsvSchema>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CsvSchema) Configuration.ApiClient.Deserialize(response, typeof(CsvSchema)));
            
        }
    
        /// <summary>
        /// Get all CSV schemas for a given carrier and name. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="name">Schema name</param>
        /// <returns>Task of CsvSchema</returns>
        public async System.Threading.Tasks.Task<CsvSchema> CarrierservicesCsvschemasCarrieridNameNameGetAsync (string carrierId, string name)
        {
             ApiResponse<CsvSchema> response = await CarrierservicesCsvschemasCarrieridNameNameGetAsyncWithHttpInfo(carrierId, name);
             return response.Data;

        }

        /// <summary>
        /// Get all CSV schemas for a given carrier and name. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="name">Schema name</param>
        /// <returns>Task of ApiResponse (CsvSchema)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CsvSchema>> CarrierservicesCsvschemasCarrieridNameNameGetAsyncWithHttpInfo (string carrierId, string name)
        {
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesCsvschemasCarrieridNameNameGet");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling CarrierservicesCsvschemasCarrieridNameNameGet");
            
    
            var path_ = "/api/v1/carrierservices/csvschemas/{carrierId}/name/{name}";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            if (name != null) pathParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCsvschemasCarrieridNameNameGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCsvschemasCarrieridNameNameGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CsvSchema>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CsvSchema) Configuration.ApiClient.Deserialize(response, typeof(CsvSchema)));
            
        }
        
        /// <summary>
        /// Deletes a CSV schema for a carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <param name="name">Schema name</param> 
        /// <returns>CsvSchema</returns>
        public CsvSchema CarrierservicesCsvschemasCarrieridNameNameDelete (string carrierId, string name)
        {
             ApiResponse<CsvSchema> response = CarrierservicesCsvschemasCarrieridNameNameDeleteWithHttpInfo(carrierId, name);
             return response.Data;
        }

        /// <summary>
        /// Deletes a CSV schema for a carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <param name="name">Schema name</param> 
        /// <returns>ApiResponse of CsvSchema</returns>
        public ApiResponse< CsvSchema > CarrierservicesCsvschemasCarrieridNameNameDeleteWithHttpInfo (string carrierId, string name)
        {
            
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesCsvschemasCarrieridNameNameDelete");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling CarrierservicesCsvschemasCarrieridNameNameDelete");
            
    
            var path_ = "/api/v1/carrierservices/csvschemas/{carrierId}/name/{name}";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            if (name != null) pathParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCsvschemasCarrieridNameNameDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCsvschemasCarrieridNameNameDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CsvSchema>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CsvSchema) Configuration.ApiClient.Deserialize(response, typeof(CsvSchema)));
            
        }
    
        /// <summary>
        /// Deletes a CSV schema for a carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="name">Schema name</param>
        /// <returns>Task of CsvSchema</returns>
        public async System.Threading.Tasks.Task<CsvSchema> CarrierservicesCsvschemasCarrieridNameNameDeleteAsync (string carrierId, string name)
        {
             ApiResponse<CsvSchema> response = await CarrierservicesCsvschemasCarrieridNameNameDeleteAsyncWithHttpInfo(carrierId, name);
             return response.Data;

        }

        /// <summary>
        /// Deletes a CSV schema for a carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="name">Schema name</param>
        /// <returns>Task of ApiResponse (CsvSchema)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CsvSchema>> CarrierservicesCsvschemasCarrieridNameNameDeleteAsyncWithHttpInfo (string carrierId, string name)
        {
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesCsvschemasCarrieridNameNameDelete");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling CarrierservicesCsvschemasCarrieridNameNameDelete");
            
    
            var path_ = "/api/v1/carrierservices/csvschemas/{carrierId}/name/{name}";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            if (name != null) pathParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesCsvschemasCarrieridNameNameDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesCsvschemasCarrieridNameNameDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CsvSchema>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CsvSchema) Configuration.ApiClient.Deserialize(response, typeof(CsvSchema)));
            
        }
        
        /// <summary>
        /// Search for available numbers. 
        /// </summary>
        /// <param name="npa">The allowed number ranges for local numbers are [2-9] for the first digit and [0-9] for both the second and third digits. The allowed numbers for toll-free are 800, 888, etc.</param> 
        /// <param name="state">The two-letter abbreviation of the state the RateCenter is in.</param> 
        /// <param name="city">The name of the city.</param> 
        /// <param name="zip">A five-digit (XXXXX) or nine-digit (XXXXX-XXXX) zip-code value.</param> 
        /// <param name="lata">A maximum five digit (XXXXX) numeric format.</param> 
        /// <param name="rateCenter">The abbreviation for the Rate Center</param> 
        /// <param name="vanity">Requested vanity number. Valid range is from 4 to 7 alphanumeric characters.</param> 
        /// <param name="prefix">Prefix of the number, must be 6 or 7 digits.</param> 
        /// <param name="quantity">The desired quantity of requested numbers. Values range from 1-5000. If no quantity is specified, the default of 5000 is returned.</param> 
        /// <param name="orderBy">The field by which the returned numbers will be sorted. Only supported if at least one of the following search criteria is specified: prefix, city, zip. Allowed values are fullNumber, npaNxxx, npaNxx, and areaCode&gt;</param> 
        /// <param name="enableTNDetail">If set to true, a list of details associated with the telephone number (rate center abbreviation, rate center host city, state, and LATA) will be displayed along with the telephone number. This value is set to false by default.</param> 
        /// <param name="type">The type of phone number (eg us-domestic, toll-free, etc), to determine which third-party api(s) to use for the search.</param> 
        /// <returns></returns>
        public void CarrierservicesNumberpurchaseAvailableGet (string npa = null, string state = null, string city = null, string zip = null, string lata = null, string rateCenter = null, string vanity = null, string prefix = null, int? quantity = null, string orderBy = null, bool? enableTNDetail = null, string type = null)
        {
             CarrierservicesNumberpurchaseAvailableGetWithHttpInfo(npa, state, city, zip, lata, rateCenter, vanity, prefix, quantity, orderBy, enableTNDetail, type);
        }

        /// <summary>
        /// Search for available numbers. 
        /// </summary>
        /// <param name="npa">The allowed number ranges for local numbers are [2-9] for the first digit and [0-9] for both the second and third digits. The allowed numbers for toll-free are 800, 888, etc.</param> 
        /// <param name="state">The two-letter abbreviation of the state the RateCenter is in.</param> 
        /// <param name="city">The name of the city.</param> 
        /// <param name="zip">A five-digit (XXXXX) or nine-digit (XXXXX-XXXX) zip-code value.</param> 
        /// <param name="lata">A maximum five digit (XXXXX) numeric format.</param> 
        /// <param name="rateCenter">The abbreviation for the Rate Center</param> 
        /// <param name="vanity">Requested vanity number. Valid range is from 4 to 7 alphanumeric characters.</param> 
        /// <param name="prefix">Prefix of the number, must be 6 or 7 digits.</param> 
        /// <param name="quantity">The desired quantity of requested numbers. Values range from 1-5000. If no quantity is specified, the default of 5000 is returned.</param> 
        /// <param name="orderBy">The field by which the returned numbers will be sorted. Only supported if at least one of the following search criteria is specified: prefix, city, zip. Allowed values are fullNumber, npaNxxx, npaNxx, and areaCode&gt;</param> 
        /// <param name="enableTNDetail">If set to true, a list of details associated with the telephone number (rate center abbreviation, rate center host city, state, and LATA) will be displayed along with the telephone number. This value is set to false by default.</param> 
        /// <param name="type">The type of phone number (eg us-domestic, toll-free, etc), to determine which third-party api(s) to use for the search.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CarrierservicesNumberpurchaseAvailableGetWithHttpInfo (string npa = null, string state = null, string city = null, string zip = null, string lata = null, string rateCenter = null, string vanity = null, string prefix = null, int? quantity = null, string orderBy = null, bool? enableTNDetail = null, string type = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/numberpurchase/available";
    
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
            
            if (npa != null) queryParams.Add("npa", Configuration.ApiClient.ParameterToString(npa)); // query parameter
            if (state != null) queryParams.Add("state", Configuration.ApiClient.ParameterToString(state)); // query parameter
            if (city != null) queryParams.Add("city", Configuration.ApiClient.ParameterToString(city)); // query parameter
            if (zip != null) queryParams.Add("zip", Configuration.ApiClient.ParameterToString(zip)); // query parameter
            if (lata != null) queryParams.Add("lata", Configuration.ApiClient.ParameterToString(lata)); // query parameter
            if (rateCenter != null) queryParams.Add("rateCenter", Configuration.ApiClient.ParameterToString(rateCenter)); // query parameter
            if (vanity != null) queryParams.Add("vanity", Configuration.ApiClient.ParameterToString(vanity)); // query parameter
            if (prefix != null) queryParams.Add("prefix", Configuration.ApiClient.ParameterToString(prefix)); // query parameter
            if (quantity != null) queryParams.Add("quantity", Configuration.ApiClient.ParameterToString(quantity)); // query parameter
            if (orderBy != null) queryParams.Add("orderBy", Configuration.ApiClient.ParameterToString(orderBy)); // query parameter
            if (enableTNDetail != null) queryParams.Add("enableTNDetail", Configuration.ApiClient.ParameterToString(enableTNDetail)); // query parameter
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
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseAvailableGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseAvailableGet: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Search for available numbers. 
        /// </summary>
        /// <param name="npa">The allowed number ranges for local numbers are [2-9] for the first digit and [0-9] for both the second and third digits. The allowed numbers for toll-free are 800, 888, etc.</param>
        /// <param name="state">The two-letter abbreviation of the state the RateCenter is in.</param>
        /// <param name="city">The name of the city.</param>
        /// <param name="zip">A five-digit (XXXXX) or nine-digit (XXXXX-XXXX) zip-code value.</param>
        /// <param name="lata">A maximum five digit (XXXXX) numeric format.</param>
        /// <param name="rateCenter">The abbreviation for the Rate Center</param>
        /// <param name="vanity">Requested vanity number. Valid range is from 4 to 7 alphanumeric characters.</param>
        /// <param name="prefix">Prefix of the number, must be 6 or 7 digits.</param>
        /// <param name="quantity">The desired quantity of requested numbers. Values range from 1-5000. If no quantity is specified, the default of 5000 is returned.</param>
        /// <param name="orderBy">The field by which the returned numbers will be sorted. Only supported if at least one of the following search criteria is specified: prefix, city, zip. Allowed values are fullNumber, npaNxxx, npaNxx, and areaCode&gt;</param>
        /// <param name="enableTNDetail">If set to true, a list of details associated with the telephone number (rate center abbreviation, rate center host city, state, and LATA) will be displayed along with the telephone number. This value is set to false by default.</param>
        /// <param name="type">The type of phone number (eg us-domestic, toll-free, etc), to determine which third-party api(s) to use for the search.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CarrierservicesNumberpurchaseAvailableGetAsync (string npa = null, string state = null, string city = null, string zip = null, string lata = null, string rateCenter = null, string vanity = null, string prefix = null, int? quantity = null, string orderBy = null, bool? enableTNDetail = null, string type = null)
        {
             await CarrierservicesNumberpurchaseAvailableGetAsyncWithHttpInfo(npa, state, city, zip, lata, rateCenter, vanity, prefix, quantity, orderBy, enableTNDetail, type);

        }

        /// <summary>
        /// Search for available numbers. 
        /// </summary>
        /// <param name="npa">The allowed number ranges for local numbers are [2-9] for the first digit and [0-9] for both the second and third digits. The allowed numbers for toll-free are 800, 888, etc.</param>
        /// <param name="state">The two-letter abbreviation of the state the RateCenter is in.</param>
        /// <param name="city">The name of the city.</param>
        /// <param name="zip">A five-digit (XXXXX) or nine-digit (XXXXX-XXXX) zip-code value.</param>
        /// <param name="lata">A maximum five digit (XXXXX) numeric format.</param>
        /// <param name="rateCenter">The abbreviation for the Rate Center</param>
        /// <param name="vanity">Requested vanity number. Valid range is from 4 to 7 alphanumeric characters.</param>
        /// <param name="prefix">Prefix of the number, must be 6 or 7 digits.</param>
        /// <param name="quantity">The desired quantity of requested numbers. Values range from 1-5000. If no quantity is specified, the default of 5000 is returned.</param>
        /// <param name="orderBy">The field by which the returned numbers will be sorted. Only supported if at least one of the following search criteria is specified: prefix, city, zip. Allowed values are fullNumber, npaNxxx, npaNxx, and areaCode&gt;</param>
        /// <param name="enableTNDetail">If set to true, a list of details associated with the telephone number (rate center abbreviation, rate center host city, state, and LATA) will be displayed along with the telephone number. This value is set to false by default.</param>
        /// <param name="type">The type of phone number (eg us-domestic, toll-free, etc), to determine which third-party api(s) to use for the search.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CarrierservicesNumberpurchaseAvailableGetAsyncWithHttpInfo (string npa = null, string state = null, string city = null, string zip = null, string lata = null, string rateCenter = null, string vanity = null, string prefix = null, int? quantity = null, string orderBy = null, bool? enableTNDetail = null, string type = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/numberpurchase/available";
    
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
            
            if (npa != null) queryParams.Add("npa", Configuration.ApiClient.ParameterToString(npa)); // query parameter
            if (state != null) queryParams.Add("state", Configuration.ApiClient.ParameterToString(state)); // query parameter
            if (city != null) queryParams.Add("city", Configuration.ApiClient.ParameterToString(city)); // query parameter
            if (zip != null) queryParams.Add("zip", Configuration.ApiClient.ParameterToString(zip)); // query parameter
            if (lata != null) queryParams.Add("lata", Configuration.ApiClient.ParameterToString(lata)); // query parameter
            if (rateCenter != null) queryParams.Add("rateCenter", Configuration.ApiClient.ParameterToString(rateCenter)); // query parameter
            if (vanity != null) queryParams.Add("vanity", Configuration.ApiClient.ParameterToString(vanity)); // query parameter
            if (prefix != null) queryParams.Add("prefix", Configuration.ApiClient.ParameterToString(prefix)); // query parameter
            if (quantity != null) queryParams.Add("quantity", Configuration.ApiClient.ParameterToString(quantity)); // query parameter
            if (orderBy != null) queryParams.Add("orderBy", Configuration.ApiClient.ParameterToString(orderBy)); // query parameter
            if (enableTNDetail != null) queryParams.Add("enableTNDetail", Configuration.ApiClient.ParameterToString(enableTNDetail)); // query parameter
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
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseAvailableGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseAvailableGet: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// View all number orders for the organization. 
        /// </summary>
        /// <param name="phoneNumberType">Phone Number Type</param> 
        /// <returns></returns>
        public void CarrierservicesNumberpurchaseOrdersGet (string phoneNumberType = null)
        {
             CarrierservicesNumberpurchaseOrdersGetWithHttpInfo(phoneNumberType);
        }

        /// <summary>
        /// View all number orders for the organization. 
        /// </summary>
        /// <param name="phoneNumberType">Phone Number Type</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CarrierservicesNumberpurchaseOrdersGetWithHttpInfo (string phoneNumberType = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/numberpurchase/orders";
    
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
            
            if (phoneNumberType != null) queryParams.Add("phoneNumberType", Configuration.ApiClient.ParameterToString(phoneNumberType)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseOrdersGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseOrdersGet: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// View all number orders for the organization. 
        /// </summary>
        /// <param name="phoneNumberType">Phone Number Type</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CarrierservicesNumberpurchaseOrdersGetAsync (string phoneNumberType = null)
        {
             await CarrierservicesNumberpurchaseOrdersGetAsyncWithHttpInfo(phoneNumberType);

        }

        /// <summary>
        /// View all number orders for the organization. 
        /// </summary>
        /// <param name="phoneNumberType">Phone Number Type</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CarrierservicesNumberpurchaseOrdersGetAsyncWithHttpInfo (string phoneNumberType = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/numberpurchase/orders";
    
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
            
            if (phoneNumberType != null) queryParams.Add("phoneNumberType", Configuration.ApiClient.ParameterToString(phoneNumberType)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseOrdersGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseOrdersGet: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Purchase numbers. 
        /// </summary>
        /// <param name="phoneNumberType">Phone Number Type</param> 
        /// <param name="body"></param> 
        /// <returns></returns>
        public void CarrierservicesNumberpurchaseOrdersPost (string phoneNumberType = null, NumberOrderRequest body = null)
        {
             CarrierservicesNumberpurchaseOrdersPostWithHttpInfo(phoneNumberType, body);
        }

        /// <summary>
        /// Purchase numbers. 
        /// </summary>
        /// <param name="phoneNumberType">Phone Number Type</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CarrierservicesNumberpurchaseOrdersPostWithHttpInfo (string phoneNumberType = null, NumberOrderRequest body = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/numberpurchase/orders";
    
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
            
            if (phoneNumberType != null) queryParams.Add("phoneNumberType", Configuration.ApiClient.ParameterToString(phoneNumberType)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseOrdersPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseOrdersPost: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Purchase numbers. 
        /// </summary>
        /// <param name="phoneNumberType">Phone Number Type</param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CarrierservicesNumberpurchaseOrdersPostAsync (string phoneNumberType = null, NumberOrderRequest body = null)
        {
             await CarrierservicesNumberpurchaseOrdersPostAsyncWithHttpInfo(phoneNumberType, body);

        }

        /// <summary>
        /// Purchase numbers. 
        /// </summary>
        /// <param name="phoneNumberType">Phone Number Type</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CarrierservicesNumberpurchaseOrdersPostAsyncWithHttpInfo (string phoneNumberType = null, NumberOrderRequest body = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/numberpurchase/orders";
    
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
            
            if (phoneNumberType != null) queryParams.Add("phoneNumberType", Configuration.ApiClient.ParameterToString(phoneNumberType)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseOrdersPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseOrdersPost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// View all a number order record.  Some vender apis have side effects when viewing records with pending operations.  This method also manages the side effects and updates ININ-side data stores to reflect any changes. 
        /// </summary>
        /// <param name="orderId">Phone Number Order ID</param> 
        /// <returns></returns>
        public void CarrierservicesNumberpurchaseOrdersOrderidGet (string orderId)
        {
             CarrierservicesNumberpurchaseOrdersOrderidGetWithHttpInfo(orderId);
        }

        /// <summary>
        /// View all a number order record.  Some vender apis have side effects when viewing records with pending operations.  This method also manages the side effects and updates ININ-side data stores to reflect any changes. 
        /// </summary>
        /// <param name="orderId">Phone Number Order ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CarrierservicesNumberpurchaseOrdersOrderidGetWithHttpInfo (string orderId)
        {
            
            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling CarrierservicesNumberpurchaseOrdersOrderidGet");
            
    
            var path_ = "/api/v1/carrierservices/numberpurchase/orders/{orderId}";
    
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
            if (orderId != null) pathParams.Add("orderId", Configuration.ApiClient.ParameterToString(orderId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseOrdersOrderidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseOrdersOrderidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// View all a number order record.  Some vender apis have side effects when viewing records with pending operations.  This method also manages the side effects and updates ININ-side data stores to reflect any changes. 
        /// </summary>
        /// <param name="orderId">Phone Number Order ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CarrierservicesNumberpurchaseOrdersOrderidGetAsync (string orderId)
        {
             await CarrierservicesNumberpurchaseOrdersOrderidGetAsyncWithHttpInfo(orderId);

        }

        /// <summary>
        /// View all a number order record.  Some vender apis have side effects when viewing records with pending operations.  This method also manages the side effects and updates ININ-side data stores to reflect any changes. 
        /// </summary>
        /// <param name="orderId">Phone Number Order ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CarrierservicesNumberpurchaseOrdersOrderidGetAsyncWithHttpInfo (string orderId)
        {
            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling CarrierservicesNumberpurchaseOrdersOrderidGet");
            
    
            var path_ = "/api/v1/carrierservices/numberpurchase/orders/{orderId}";
    
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
            if (orderId != null) pathParams.Add("orderId", Configuration.ApiClient.ParameterToString(orderId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseOrdersOrderidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseOrdersOrderidGet: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Disconnect the number purchased in a particlar order.  The order record remains (in the deleted state) for record keeping. 
        /// </summary>
        /// <param name="orderId">Phone Number Order ID</param> 
        /// <returns></returns>
        public void CarrierservicesNumberpurchaseOrdersOrderidDelete (string orderId)
        {
             CarrierservicesNumberpurchaseOrdersOrderidDeleteWithHttpInfo(orderId);
        }

        /// <summary>
        /// Disconnect the number purchased in a particlar order.  The order record remains (in the deleted state) for record keeping. 
        /// </summary>
        /// <param name="orderId">Phone Number Order ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CarrierservicesNumberpurchaseOrdersOrderidDeleteWithHttpInfo (string orderId)
        {
            
            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling CarrierservicesNumberpurchaseOrdersOrderidDelete");
            
    
            var path_ = "/api/v1/carrierservices/numberpurchase/orders/{orderId}";
    
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
            if (orderId != null) pathParams.Add("orderId", Configuration.ApiClient.ParameterToString(orderId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseOrdersOrderidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseOrdersOrderidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Disconnect the number purchased in a particlar order.  The order record remains (in the deleted state) for record keeping. 
        /// </summary>
        /// <param name="orderId">Phone Number Order ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CarrierservicesNumberpurchaseOrdersOrderidDeleteAsync (string orderId)
        {
             await CarrierservicesNumberpurchaseOrdersOrderidDeleteAsyncWithHttpInfo(orderId);

        }

        /// <summary>
        /// Disconnect the number purchased in a particlar order.  The order record remains (in the deleted state) for record keeping. 
        /// </summary>
        /// <param name="orderId">Phone Number Order ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CarrierservicesNumberpurchaseOrdersOrderidDeleteAsyncWithHttpInfo (string orderId)
        {
            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling CarrierservicesNumberpurchaseOrdersOrderidDelete");
            
    
            var path_ = "/api/v1/carrierservices/numberpurchase/orders/{orderId}";
    
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
            if (orderId != null) pathParams.Add("orderId", Configuration.ApiClient.ParameterToString(orderId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseOrdersOrderidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseOrdersOrderidDelete: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Reserve available numbers, making them ready for purchase and preventing other users from accessing them. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns></returns>
        public void CarrierservicesNumberpurchaseReservedPost (List<Reservation> body = null)
        {
             CarrierservicesNumberpurchaseReservedPostWithHttpInfo(body);
        }

        /// <summary>
        /// Reserve available numbers, making them ready for purchase and preventing other users from accessing them. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CarrierservicesNumberpurchaseReservedPostWithHttpInfo (List<Reservation> body = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/numberpurchase/reserved";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseReservedPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseReservedPost: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Reserve available numbers, making them ready for purchase and preventing other users from accessing them. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CarrierservicesNumberpurchaseReservedPostAsync (List<Reservation> body = null)
        {
             await CarrierservicesNumberpurchaseReservedPostAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Reserve available numbers, making them ready for purchase and preventing other users from accessing them. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CarrierservicesNumberpurchaseReservedPostAsyncWithHttpInfo (List<Reservation> body = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/numberpurchase/reserved";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseReservedPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseReservedPost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// View a specific reservation. 
        /// </summary>
        /// <param name="reservationId">Phone Number Reservation ID</param> 
        /// <param name="phoneNumberType">Phone Number Type</param> 
        /// <returns></returns>
        public void CarrierservicesNumberpurchaseReservedReservationidGet (string reservationId, string phoneNumberType = null)
        {
             CarrierservicesNumberpurchaseReservedReservationidGetWithHttpInfo(reservationId, phoneNumberType);
        }

        /// <summary>
        /// View a specific reservation. 
        /// </summary>
        /// <param name="reservationId">Phone Number Reservation ID</param> 
        /// <param name="phoneNumberType">Phone Number Type</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CarrierservicesNumberpurchaseReservedReservationidGetWithHttpInfo (string reservationId, string phoneNumberType = null)
        {
            
            // verify the required parameter 'reservationId' is set
            if (reservationId == null) throw new ApiException(400, "Missing required parameter 'reservationId' when calling CarrierservicesNumberpurchaseReservedReservationidGet");
            
    
            var path_ = "/api/v1/carrierservices/numberpurchase/reserved/{reservationId}";
    
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
            if (reservationId != null) pathParams.Add("reservationId", Configuration.ApiClient.ParameterToString(reservationId)); // path parameter
            
            if (phoneNumberType != null) queryParams.Add("phoneNumberType", Configuration.ApiClient.ParameterToString(phoneNumberType)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseReservedReservationidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseReservedReservationidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// View a specific reservation. 
        /// </summary>
        /// <param name="reservationId">Phone Number Reservation ID</param>
        /// <param name="phoneNumberType">Phone Number Type</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CarrierservicesNumberpurchaseReservedReservationidGetAsync (string reservationId, string phoneNumberType = null)
        {
             await CarrierservicesNumberpurchaseReservedReservationidGetAsyncWithHttpInfo(reservationId, phoneNumberType);

        }

        /// <summary>
        /// View a specific reservation. 
        /// </summary>
        /// <param name="reservationId">Phone Number Reservation ID</param>
        /// <param name="phoneNumberType">Phone Number Type</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CarrierservicesNumberpurchaseReservedReservationidGetAsyncWithHttpInfo (string reservationId, string phoneNumberType = null)
        {
            // verify the required parameter 'reservationId' is set
            if (reservationId == null) throw new ApiException(400, "Missing required parameter 'reservationId' when calling CarrierservicesNumberpurchaseReservedReservationidGet");
            
    
            var path_ = "/api/v1/carrierservices/numberpurchase/reserved/{reservationId}";
    
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
            if (reservationId != null) pathParams.Add("reservationId", Configuration.ApiClient.ParameterToString(reservationId)); // path parameter
            
            if (phoneNumberType != null) queryParams.Add("phoneNumberType", Configuration.ApiClient.ParameterToString(phoneNumberType)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseReservedReservationidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseReservedReservationidGet: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Cancel a specific reservation, making the number available for other users, again. 
        /// </summary>
        /// <param name="reservationId">Phone Number Reservation ID</param> 
        /// <param name="phoneNumberType">Phone Number Type</param> 
        /// <returns></returns>
        public void CarrierservicesNumberpurchaseReservedReservationidDelete (string reservationId, string phoneNumberType = null)
        {
             CarrierservicesNumberpurchaseReservedReservationidDeleteWithHttpInfo(reservationId, phoneNumberType);
        }

        /// <summary>
        /// Cancel a specific reservation, making the number available for other users, again. 
        /// </summary>
        /// <param name="reservationId">Phone Number Reservation ID</param> 
        /// <param name="phoneNumberType">Phone Number Type</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CarrierservicesNumberpurchaseReservedReservationidDeleteWithHttpInfo (string reservationId, string phoneNumberType = null)
        {
            
            // verify the required parameter 'reservationId' is set
            if (reservationId == null) throw new ApiException(400, "Missing required parameter 'reservationId' when calling CarrierservicesNumberpurchaseReservedReservationidDelete");
            
    
            var path_ = "/api/v1/carrierservices/numberpurchase/reserved/{reservationId}";
    
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
            if (reservationId != null) pathParams.Add("reservationId", Configuration.ApiClient.ParameterToString(reservationId)); // path parameter
            
            if (phoneNumberType != null) queryParams.Add("phoneNumberType", Configuration.ApiClient.ParameterToString(phoneNumberType)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseReservedReservationidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseReservedReservationidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Cancel a specific reservation, making the number available for other users, again. 
        /// </summary>
        /// <param name="reservationId">Phone Number Reservation ID</param>
        /// <param name="phoneNumberType">Phone Number Type</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CarrierservicesNumberpurchaseReservedReservationidDeleteAsync (string reservationId, string phoneNumberType = null)
        {
             await CarrierservicesNumberpurchaseReservedReservationidDeleteAsyncWithHttpInfo(reservationId, phoneNumberType);

        }

        /// <summary>
        /// Cancel a specific reservation, making the number available for other users, again. 
        /// </summary>
        /// <param name="reservationId">Phone Number Reservation ID</param>
        /// <param name="phoneNumberType">Phone Number Type</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CarrierservicesNumberpurchaseReservedReservationidDeleteAsyncWithHttpInfo (string reservationId, string phoneNumberType = null)
        {
            // verify the required parameter 'reservationId' is set
            if (reservationId == null) throw new ApiException(400, "Missing required parameter 'reservationId' when calling CarrierservicesNumberpurchaseReservedReservationidDelete");
            
    
            var path_ = "/api/v1/carrierservices/numberpurchase/reserved/{reservationId}";
    
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
            if (reservationId != null) pathParams.Add("reservationId", Configuration.ApiClient.ParameterToString(reservationId)); // path parameter
            
            if (phoneNumberType != null) queryParams.Add("phoneNumberType", Configuration.ApiClient.ParameterToString(phoneNumberType)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseReservedReservationidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesNumberpurchaseReservedReservationidDelete: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get ratesheet upload progress for a user. 
        /// </summary>
        /// <returns>UploadProgress</returns>
        public UploadProgress CarrierservicesProgressGet ()
        {
             ApiResponse<UploadProgress> response = CarrierservicesProgressGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get ratesheet upload progress for a user. 
        /// </summary>
        /// <returns>ApiResponse of UploadProgress</returns>
        public ApiResponse< UploadProgress > CarrierservicesProgressGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/carrierservices/progress";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesProgressGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesProgressGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UploadProgress>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UploadProgress) Configuration.ApiClient.Deserialize(response, typeof(UploadProgress)));
            
        }
    
        /// <summary>
        /// Get ratesheet upload progress for a user. 
        /// </summary>
        /// <returns>Task of UploadProgress</returns>
        public async System.Threading.Tasks.Task<UploadProgress> CarrierservicesProgressGetAsync ()
        {
             ApiResponse<UploadProgress> response = await CarrierservicesProgressGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get ratesheet upload progress for a user. 
        /// </summary>
        /// <returns>Task of ApiResponse (UploadProgress)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UploadProgress>> CarrierservicesProgressGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/carrierservices/progress";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesProgressGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesProgressGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UploadProgress>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UploadProgress) Configuration.ApiClient.Deserialize(response, typeof(UploadProgress)));
            
        }
        
        /// <summary>
        /// Get LCR report. This method queries Druid for a Phone Number Purchase Stats database report.  Some Druid terminology is required to use it.  Each query parameter besides dimensions, _pgn, and _pgs, is a Druid dimension.  From the Druid documentation: Dimensions: Aspects or categories of data, such as languages or locations. For example, with language and country as the type of dimension, values could be \&quot;English\&quot; or \&quot;Mandarin\&quot; for language, or \&quot;USA\&quot; or \&quot;China\&quot; for country. In Druid, dimensions can serve as filters for narrowing down hits (for example, language = \&quot;English\&quot; or country = \&quot;China\&quot;).  When using a dimension query parameter with a value the report will return events with granularity of that dimension where the dimension value is equal to the value you specified.  If you want to receive events with dimension based granularity with no filter, opt to use the dimensions query parameters, which is a comma  separated list of values that use the other query parameters as dimension names.  Each  parameter needs to be in the screaming snake case format, or words capitalized with underscores between words (i.e. CUSTOMER_ID).
        /// </summary>
        /// <param name="pageSize">The total page size requested</param> 
        /// <param name="pageNumber">The page number requested</param> 
        /// <param name="sortBy">variable name requested to sort by</param> 
        /// <param name="expand">variable name requested by expand list</param> 
        /// <param name="granularity">The granularity field determines how data gets bucketed across the time dimension, or how it gets aggregated by hour, day, minute, etc. all buckets everything into a single bucket. none does not bucket data (it actually uses the granularity of the index - minimum here is none which means millisecond granularity).</param> 
        /// <param name="dimensions">Dimensions are really any other parameter specified, excluding granularity.  To specify multiple dimensions use comma separated values.</param> 
        /// <param name="startDate">Start dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over.  If not set will always default to now minus 15 days.</param> 
        /// <param name="endDate">End dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over. If not set will always default to startDate plus 30 days.</param> 
        /// <param name="regexFilterEnabled">Specifies if all dimension filters should be implemented as regexps.</param> 
        /// <param name="effectiveStartDate">Effective date number service starts</param> 
        /// <param name="effectiveEndDate">Effective date number service ends</param> 
        /// <param name="did">Number purchased (Can use with regex for npa, etc.)</param> 
        /// <param name="phoneNumberType">Type of number purchased (ie. us-domestic, tollfree...)</param> 
        /// <param name="startAuthUserId">User id for the number purchase</param> 
        /// <param name="endAuthUserId">User id for the number disconnect order</param> 
        /// <param name="status">Status of the number purchase</param> 
        /// <param name="orgId">Organization id for the number purchase</param> 
        /// <returns></returns>
        public void CarrierservicesReportPurchasesGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string granularity = null, string dimensions = null, DateTime? startDate = null, DateTime? endDate = null, bool? regexFilterEnabled = null, DateTime? effectiveStartDate = null, DateTime? effectiveEndDate = null, string did = null, string phoneNumberType = null, string startAuthUserId = null, string endAuthUserId = null, string status = null, string orgId = null)
        {
             CarrierservicesReportPurchasesGetWithHttpInfo(pageSize, pageNumber, sortBy, expand, granularity, dimensions, startDate, endDate, regexFilterEnabled, effectiveStartDate, effectiveEndDate, did, phoneNumberType, startAuthUserId, endAuthUserId, status, orgId);
        }

        /// <summary>
        /// Get LCR report. This method queries Druid for a Phone Number Purchase Stats database report.  Some Druid terminology is required to use it.  Each query parameter besides dimensions, _pgn, and _pgs, is a Druid dimension.  From the Druid documentation: Dimensions: Aspects or categories of data, such as languages or locations. For example, with language and country as the type of dimension, values could be \&quot;English\&quot; or \&quot;Mandarin\&quot; for language, or \&quot;USA\&quot; or \&quot;China\&quot; for country. In Druid, dimensions can serve as filters for narrowing down hits (for example, language = \&quot;English\&quot; or country = \&quot;China\&quot;).  When using a dimension query parameter with a value the report will return events with granularity of that dimension where the dimension value is equal to the value you specified.  If you want to receive events with dimension based granularity with no filter, opt to use the dimensions query parameters, which is a comma  separated list of values that use the other query parameters as dimension names.  Each  parameter needs to be in the screaming snake case format, or words capitalized with underscores between words (i.e. CUSTOMER_ID).
        /// </summary>
        /// <param name="pageSize">The total page size requested</param> 
        /// <param name="pageNumber">The page number requested</param> 
        /// <param name="sortBy">variable name requested to sort by</param> 
        /// <param name="expand">variable name requested by expand list</param> 
        /// <param name="granularity">The granularity field determines how data gets bucketed across the time dimension, or how it gets aggregated by hour, day, minute, etc. all buckets everything into a single bucket. none does not bucket data (it actually uses the granularity of the index - minimum here is none which means millisecond granularity).</param> 
        /// <param name="dimensions">Dimensions are really any other parameter specified, excluding granularity.  To specify multiple dimensions use comma separated values.</param> 
        /// <param name="startDate">Start dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over.  If not set will always default to now minus 15 days.</param> 
        /// <param name="endDate">End dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over. If not set will always default to startDate plus 30 days.</param> 
        /// <param name="regexFilterEnabled">Specifies if all dimension filters should be implemented as regexps.</param> 
        /// <param name="effectiveStartDate">Effective date number service starts</param> 
        /// <param name="effectiveEndDate">Effective date number service ends</param> 
        /// <param name="did">Number purchased (Can use with regex for npa, etc.)</param> 
        /// <param name="phoneNumberType">Type of number purchased (ie. us-domestic, tollfree...)</param> 
        /// <param name="startAuthUserId">User id for the number purchase</param> 
        /// <param name="endAuthUserId">User id for the number disconnect order</param> 
        /// <param name="status">Status of the number purchase</param> 
        /// <param name="orgId">Organization id for the number purchase</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CarrierservicesReportPurchasesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string granularity = null, string dimensions = null, DateTime? startDate = null, DateTime? endDate = null, bool? regexFilterEnabled = null, DateTime? effectiveStartDate = null, DateTime? effectiveEndDate = null, string did = null, string phoneNumberType = null, string startAuthUserId = null, string endAuthUserId = null, string status = null, string orgId = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/report/purchases";
    
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
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (granularity != null) queryParams.Add("granularity", Configuration.ApiClient.ParameterToString(granularity)); // query parameter
            if (dimensions != null) queryParams.Add("dimensions", Configuration.ApiClient.ParameterToString(dimensions)); // query parameter
            if (startDate != null) queryParams.Add("startDate", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) queryParams.Add("endDate", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            if (regexFilterEnabled != null) queryParams.Add("regexFilterEnabled", Configuration.ApiClient.ParameterToString(regexFilterEnabled)); // query parameter
            if (effectiveStartDate != null) queryParams.Add("effectiveStartDate", Configuration.ApiClient.ParameterToString(effectiveStartDate)); // query parameter
            if (effectiveEndDate != null) queryParams.Add("effectiveEndDate", Configuration.ApiClient.ParameterToString(effectiveEndDate)); // query parameter
            if (did != null) queryParams.Add("did", Configuration.ApiClient.ParameterToString(did)); // query parameter
            if (phoneNumberType != null) queryParams.Add("phoneNumberType", Configuration.ApiClient.ParameterToString(phoneNumberType)); // query parameter
            if (startAuthUserId != null) queryParams.Add("startAuthUserId", Configuration.ApiClient.ParameterToString(startAuthUserId)); // query parameter
            if (endAuthUserId != null) queryParams.Add("endAuthUserId", Configuration.ApiClient.ParameterToString(endAuthUserId)); // query parameter
            if (status != null) queryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (orgId != null) queryParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesReportPurchasesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesReportPurchasesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Get LCR report. This method queries Druid for a Phone Number Purchase Stats database report.  Some Druid terminology is required to use it.  Each query parameter besides dimensions, _pgn, and _pgs, is a Druid dimension.  From the Druid documentation: Dimensions: Aspects or categories of data, such as languages or locations. For example, with language and country as the type of dimension, values could be \&quot;English\&quot; or \&quot;Mandarin\&quot; for language, or \&quot;USA\&quot; or \&quot;China\&quot; for country. In Druid, dimensions can serve as filters for narrowing down hits (for example, language = \&quot;English\&quot; or country = \&quot;China\&quot;).  When using a dimension query parameter with a value the report will return events with granularity of that dimension where the dimension value is equal to the value you specified.  If you want to receive events with dimension based granularity with no filter, opt to use the dimensions query parameters, which is a comma  separated list of values that use the other query parameters as dimension names.  Each  parameter needs to be in the screaming snake case format, or words capitalized with underscores between words (i.e. CUSTOMER_ID).
        /// </summary>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="granularity">The granularity field determines how data gets bucketed across the time dimension, or how it gets aggregated by hour, day, minute, etc. all buckets everything into a single bucket. none does not bucket data (it actually uses the granularity of the index - minimum here is none which means millisecond granularity).</param>
        /// <param name="dimensions">Dimensions are really any other parameter specified, excluding granularity.  To specify multiple dimensions use comma separated values.</param>
        /// <param name="startDate">Start dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over.  If not set will always default to now minus 15 days.</param>
        /// <param name="endDate">End dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over. If not set will always default to startDate plus 30 days.</param>
        /// <param name="regexFilterEnabled">Specifies if all dimension filters should be implemented as regexps.</param>
        /// <param name="effectiveStartDate">Effective date number service starts</param>
        /// <param name="effectiveEndDate">Effective date number service ends</param>
        /// <param name="did">Number purchased (Can use with regex for npa, etc.)</param>
        /// <param name="phoneNumberType">Type of number purchased (ie. us-domestic, tollfree...)</param>
        /// <param name="startAuthUserId">User id for the number purchase</param>
        /// <param name="endAuthUserId">User id for the number disconnect order</param>
        /// <param name="status">Status of the number purchase</param>
        /// <param name="orgId">Organization id for the number purchase</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CarrierservicesReportPurchasesGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string granularity = null, string dimensions = null, DateTime? startDate = null, DateTime? endDate = null, bool? regexFilterEnabled = null, DateTime? effectiveStartDate = null, DateTime? effectiveEndDate = null, string did = null, string phoneNumberType = null, string startAuthUserId = null, string endAuthUserId = null, string status = null, string orgId = null)
        {
             await CarrierservicesReportPurchasesGetAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, granularity, dimensions, startDate, endDate, regexFilterEnabled, effectiveStartDate, effectiveEndDate, did, phoneNumberType, startAuthUserId, endAuthUserId, status, orgId);

        }

        /// <summary>
        /// Get LCR report. This method queries Druid for a Phone Number Purchase Stats database report.  Some Druid terminology is required to use it.  Each query parameter besides dimensions, _pgn, and _pgs, is a Druid dimension.  From the Druid documentation: Dimensions: Aspects or categories of data, such as languages or locations. For example, with language and country as the type of dimension, values could be \&quot;English\&quot; or \&quot;Mandarin\&quot; for language, or \&quot;USA\&quot; or \&quot;China\&quot; for country. In Druid, dimensions can serve as filters for narrowing down hits (for example, language = \&quot;English\&quot; or country = \&quot;China\&quot;).  When using a dimension query parameter with a value the report will return events with granularity of that dimension where the dimension value is equal to the value you specified.  If you want to receive events with dimension based granularity with no filter, opt to use the dimensions query parameters, which is a comma  separated list of values that use the other query parameters as dimension names.  Each  parameter needs to be in the screaming snake case format, or words capitalized with underscores between words (i.e. CUSTOMER_ID).
        /// </summary>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="granularity">The granularity field determines how data gets bucketed across the time dimension, or how it gets aggregated by hour, day, minute, etc. all buckets everything into a single bucket. none does not bucket data (it actually uses the granularity of the index - minimum here is none which means millisecond granularity).</param>
        /// <param name="dimensions">Dimensions are really any other parameter specified, excluding granularity.  To specify multiple dimensions use comma separated values.</param>
        /// <param name="startDate">Start dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over.  If not set will always default to now minus 15 days.</param>
        /// <param name="endDate">End dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over. If not set will always default to startDate plus 30 days.</param>
        /// <param name="regexFilterEnabled">Specifies if all dimension filters should be implemented as regexps.</param>
        /// <param name="effectiveStartDate">Effective date number service starts</param>
        /// <param name="effectiveEndDate">Effective date number service ends</param>
        /// <param name="did">Number purchased (Can use with regex for npa, etc.)</param>
        /// <param name="phoneNumberType">Type of number purchased (ie. us-domestic, tollfree...)</param>
        /// <param name="startAuthUserId">User id for the number purchase</param>
        /// <param name="endAuthUserId">User id for the number disconnect order</param>
        /// <param name="status">Status of the number purchase</param>
        /// <param name="orgId">Organization id for the number purchase</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CarrierservicesReportPurchasesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string granularity = null, string dimensions = null, DateTime? startDate = null, DateTime? endDate = null, bool? regexFilterEnabled = null, DateTime? effectiveStartDate = null, DateTime? effectiveEndDate = null, string did = null, string phoneNumberType = null, string startAuthUserId = null, string endAuthUserId = null, string status = null, string orgId = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/report/purchases";
    
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
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (granularity != null) queryParams.Add("granularity", Configuration.ApiClient.ParameterToString(granularity)); // query parameter
            if (dimensions != null) queryParams.Add("dimensions", Configuration.ApiClient.ParameterToString(dimensions)); // query parameter
            if (startDate != null) queryParams.Add("startDate", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) queryParams.Add("endDate", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            if (regexFilterEnabled != null) queryParams.Add("regexFilterEnabled", Configuration.ApiClient.ParameterToString(regexFilterEnabled)); // query parameter
            if (effectiveStartDate != null) queryParams.Add("effectiveStartDate", Configuration.ApiClient.ParameterToString(effectiveStartDate)); // query parameter
            if (effectiveEndDate != null) queryParams.Add("effectiveEndDate", Configuration.ApiClient.ParameterToString(effectiveEndDate)); // query parameter
            if (did != null) queryParams.Add("did", Configuration.ApiClient.ParameterToString(did)); // query parameter
            if (phoneNumberType != null) queryParams.Add("phoneNumberType", Configuration.ApiClient.ParameterToString(phoneNumberType)); // query parameter
            if (startAuthUserId != null) queryParams.Add("startAuthUserId", Configuration.ApiClient.ParameterToString(startAuthUserId)); // query parameter
            if (endAuthUserId != null) queryParams.Add("endAuthUserId", Configuration.ApiClient.ParameterToString(endAuthUserId)); // query parameter
            if (status != null) queryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (orgId != null) queryParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesReportPurchasesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesReportPurchasesGet: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get LCR report. This method queries Druid for a Call Stats database report.  Some Druid terminology is required to use it.  Each query parameter besides dimensions, _pgn, and _pgs, is a Druid dimension.  From the Druid documentation: Dimensions: Aspects or categories of data, such as languages or locations. For example, with language and country as the type of dimension, values could be \&quot;English\&quot; or \&quot;Mandarin\&quot; for language, or \&quot;USA\&quot; or \&quot;China\&quot; for country. In Druid, dimensions can serve as filters for narrowing down hits (for example, language = \&quot;English\&quot; or country = \&quot;China\&quot;).  When using a dimension query parameter with a value the report will return events with granularity of that dimension where the dimension value is equal to the value you specified.  If you want to receive events with dimension based granularity with no filter, opt to use the dimensions query parameters, which is a comma  separated list of values that use the other query parameters as dimension names.  Each  parameter needs to be in the screaming snake case format, or words capitalized with underscores between words (i.e. CUSTOMER_ID).
        /// </summary>
        /// <param name="pageSize">The total page size requested</param> 
        /// <param name="pageNumber">The page number requested</param> 
        /// <param name="sortBy">variable name requested to sort by</param> 
        /// <param name="expand">variable name requested by expand list</param> 
        /// <param name="granularity">The granularity field determines how data gets bucketed across the time dimension, or how it gets aggregated by hour, day, minute, etc. all buckets everything into a single bucket. none does not bucket data (it actually uses the granularity of the index - minimum here is none which means millisecond granularity).</param> 
        /// <param name="dimensions">Dimensions are really any other parameter specified, excluding granularity.  To specify multiple dimensions use comma separated values.</param> 
        /// <param name="startDate">Start dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over.  If not set will always default to now minus 15 days.</param> 
        /// <param name="endDate">End dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over. If not set will always default to startDate plus 30 days.</param> 
        /// <param name="regexFilterEnabled">Specifies if all dimension filters should be implemented as regexps.</param> 
        /// <param name="sipCallId">SIP call id</param> 
        /// <param name="sipReason">SIP human readable status reason</param> 
        /// <param name="lrn"></param> 
        /// <param name="sipStatus">SIP status code</param> 
        /// <param name="dialogId"></param> 
        /// <param name="orgId">Organization id for the placed call</param> 
        /// <param name="cnam"></param> 
        /// <param name="from">From prefix of the number</param> 
        /// <param name="to">To prefix of the number</param> 
        /// <param name="gatewayId"></param> 
        /// <param name="direction">Direction of the call (e.g. incoming/outgoing)</param> 
        /// <param name="serviceId">Purevoice service id</param> 
        /// <param name="sendTime"></param> 
        /// <param name="answerTime">Time in which the call was connected end to end</param> 
        /// <param name="receiveTime">Time in which the call was retrieved by Purevoice</param> 
        /// <param name="failTime"></param> 
        /// <param name="disconnectTime"></param> 
        /// <param name="endTime">Time of success call ending</param> 
        /// <param name="cnamTime"></param> 
        /// <param name="lnpTime"></param> 
        /// <param name="rejectTime"></param> 
        /// <returns></returns>
        public void CarrierservicesReportUsageGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string granularity = null, string dimensions = null, DateTime? startDate = null, DateTime? endDate = null, bool? regexFilterEnabled = null, string sipCallId = null, string sipReason = null, string lrn = null, string sipStatus = null, string dialogId = null, string orgId = null, string cnam = null, string from = null, string to = null, string gatewayId = null, string direction = null, string serviceId = null, DateTime? sendTime = null, DateTime? answerTime = null, DateTime? receiveTime = null, DateTime? failTime = null, DateTime? disconnectTime = null, DateTime? endTime = null, DateTime? cnamTime = null, DateTime? lnpTime = null, DateTime? rejectTime = null)
        {
             CarrierservicesReportUsageGetWithHttpInfo(pageSize, pageNumber, sortBy, expand, granularity, dimensions, startDate, endDate, regexFilterEnabled, sipCallId, sipReason, lrn, sipStatus, dialogId, orgId, cnam, from, to, gatewayId, direction, serviceId, sendTime, answerTime, receiveTime, failTime, disconnectTime, endTime, cnamTime, lnpTime, rejectTime);
        }

        /// <summary>
        /// Get LCR report. This method queries Druid for a Call Stats database report.  Some Druid terminology is required to use it.  Each query parameter besides dimensions, _pgn, and _pgs, is a Druid dimension.  From the Druid documentation: Dimensions: Aspects or categories of data, such as languages or locations. For example, with language and country as the type of dimension, values could be \&quot;English\&quot; or \&quot;Mandarin\&quot; for language, or \&quot;USA\&quot; or \&quot;China\&quot; for country. In Druid, dimensions can serve as filters for narrowing down hits (for example, language = \&quot;English\&quot; or country = \&quot;China\&quot;).  When using a dimension query parameter with a value the report will return events with granularity of that dimension where the dimension value is equal to the value you specified.  If you want to receive events with dimension based granularity with no filter, opt to use the dimensions query parameters, which is a comma  separated list of values that use the other query parameters as dimension names.  Each  parameter needs to be in the screaming snake case format, or words capitalized with underscores between words (i.e. CUSTOMER_ID).
        /// </summary>
        /// <param name="pageSize">The total page size requested</param> 
        /// <param name="pageNumber">The page number requested</param> 
        /// <param name="sortBy">variable name requested to sort by</param> 
        /// <param name="expand">variable name requested by expand list</param> 
        /// <param name="granularity">The granularity field determines how data gets bucketed across the time dimension, or how it gets aggregated by hour, day, minute, etc. all buckets everything into a single bucket. none does not bucket data (it actually uses the granularity of the index - minimum here is none which means millisecond granularity).</param> 
        /// <param name="dimensions">Dimensions are really any other parameter specified, excluding granularity.  To specify multiple dimensions use comma separated values.</param> 
        /// <param name="startDate">Start dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over.  If not set will always default to now minus 15 days.</param> 
        /// <param name="endDate">End dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over. If not set will always default to startDate plus 30 days.</param> 
        /// <param name="regexFilterEnabled">Specifies if all dimension filters should be implemented as regexps.</param> 
        /// <param name="sipCallId">SIP call id</param> 
        /// <param name="sipReason">SIP human readable status reason</param> 
        /// <param name="lrn"></param> 
        /// <param name="sipStatus">SIP status code</param> 
        /// <param name="dialogId"></param> 
        /// <param name="orgId">Organization id for the placed call</param> 
        /// <param name="cnam"></param> 
        /// <param name="from">From prefix of the number</param> 
        /// <param name="to">To prefix of the number</param> 
        /// <param name="gatewayId"></param> 
        /// <param name="direction">Direction of the call (e.g. incoming/outgoing)</param> 
        /// <param name="serviceId">Purevoice service id</param> 
        /// <param name="sendTime"></param> 
        /// <param name="answerTime">Time in which the call was connected end to end</param> 
        /// <param name="receiveTime">Time in which the call was retrieved by Purevoice</param> 
        /// <param name="failTime"></param> 
        /// <param name="disconnectTime"></param> 
        /// <param name="endTime">Time of success call ending</param> 
        /// <param name="cnamTime"></param> 
        /// <param name="lnpTime"></param> 
        /// <param name="rejectTime"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CarrierservicesReportUsageGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string granularity = null, string dimensions = null, DateTime? startDate = null, DateTime? endDate = null, bool? regexFilterEnabled = null, string sipCallId = null, string sipReason = null, string lrn = null, string sipStatus = null, string dialogId = null, string orgId = null, string cnam = null, string from = null, string to = null, string gatewayId = null, string direction = null, string serviceId = null, DateTime? sendTime = null, DateTime? answerTime = null, DateTime? receiveTime = null, DateTime? failTime = null, DateTime? disconnectTime = null, DateTime? endTime = null, DateTime? cnamTime = null, DateTime? lnpTime = null, DateTime? rejectTime = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/report/usage";
    
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
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (granularity != null) queryParams.Add("granularity", Configuration.ApiClient.ParameterToString(granularity)); // query parameter
            if (dimensions != null) queryParams.Add("dimensions", Configuration.ApiClient.ParameterToString(dimensions)); // query parameter
            if (startDate != null) queryParams.Add("startDate", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) queryParams.Add("endDate", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            if (regexFilterEnabled != null) queryParams.Add("regexFilterEnabled", Configuration.ApiClient.ParameterToString(regexFilterEnabled)); // query parameter
            if (sipCallId != null) queryParams.Add("sipCallId", Configuration.ApiClient.ParameterToString(sipCallId)); // query parameter
            if (sipReason != null) queryParams.Add("sipReason", Configuration.ApiClient.ParameterToString(sipReason)); // query parameter
            if (lrn != null) queryParams.Add("lrn", Configuration.ApiClient.ParameterToString(lrn)); // query parameter
            if (sipStatus != null) queryParams.Add("sipStatus", Configuration.ApiClient.ParameterToString(sipStatus)); // query parameter
            if (dialogId != null) queryParams.Add("dialogId", Configuration.ApiClient.ParameterToString(dialogId)); // query parameter
            if (orgId != null) queryParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // query parameter
            if (cnam != null) queryParams.Add("cnam", Configuration.ApiClient.ParameterToString(cnam)); // query parameter
            if (from != null) queryParams.Add("from", Configuration.ApiClient.ParameterToString(from)); // query parameter
            if (to != null) queryParams.Add("to", Configuration.ApiClient.ParameterToString(to)); // query parameter
            if (gatewayId != null) queryParams.Add("gatewayId", Configuration.ApiClient.ParameterToString(gatewayId)); // query parameter
            if (direction != null) queryParams.Add("direction", Configuration.ApiClient.ParameterToString(direction)); // query parameter
            if (serviceId != null) queryParams.Add("serviceId", Configuration.ApiClient.ParameterToString(serviceId)); // query parameter
            if (sendTime != null) queryParams.Add("sendTime", Configuration.ApiClient.ParameterToString(sendTime)); // query parameter
            if (answerTime != null) queryParams.Add("answerTime", Configuration.ApiClient.ParameterToString(answerTime)); // query parameter
            if (receiveTime != null) queryParams.Add("receiveTime", Configuration.ApiClient.ParameterToString(receiveTime)); // query parameter
            if (failTime != null) queryParams.Add("failTime", Configuration.ApiClient.ParameterToString(failTime)); // query parameter
            if (disconnectTime != null) queryParams.Add("disconnectTime", Configuration.ApiClient.ParameterToString(disconnectTime)); // query parameter
            if (endTime != null) queryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (cnamTime != null) queryParams.Add("cnamTime", Configuration.ApiClient.ParameterToString(cnamTime)); // query parameter
            if (lnpTime != null) queryParams.Add("lnpTime", Configuration.ApiClient.ParameterToString(lnpTime)); // query parameter
            if (rejectTime != null) queryParams.Add("rejectTime", Configuration.ApiClient.ParameterToString(rejectTime)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesReportUsageGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesReportUsageGet: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Get LCR report. This method queries Druid for a Call Stats database report.  Some Druid terminology is required to use it.  Each query parameter besides dimensions, _pgn, and _pgs, is a Druid dimension.  From the Druid documentation: Dimensions: Aspects or categories of data, such as languages or locations. For example, with language and country as the type of dimension, values could be \&quot;English\&quot; or \&quot;Mandarin\&quot; for language, or \&quot;USA\&quot; or \&quot;China\&quot; for country. In Druid, dimensions can serve as filters for narrowing down hits (for example, language = \&quot;English\&quot; or country = \&quot;China\&quot;).  When using a dimension query parameter with a value the report will return events with granularity of that dimension where the dimension value is equal to the value you specified.  If you want to receive events with dimension based granularity with no filter, opt to use the dimensions query parameters, which is a comma  separated list of values that use the other query parameters as dimension names.  Each  parameter needs to be in the screaming snake case format, or words capitalized with underscores between words (i.e. CUSTOMER_ID).
        /// </summary>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="granularity">The granularity field determines how data gets bucketed across the time dimension, or how it gets aggregated by hour, day, minute, etc. all buckets everything into a single bucket. none does not bucket data (it actually uses the granularity of the index - minimum here is none which means millisecond granularity).</param>
        /// <param name="dimensions">Dimensions are really any other parameter specified, excluding granularity.  To specify multiple dimensions use comma separated values.</param>
        /// <param name="startDate">Start dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over.  If not set will always default to now minus 15 days.</param>
        /// <param name="endDate">End dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over. If not set will always default to startDate plus 30 days.</param>
        /// <param name="regexFilterEnabled">Specifies if all dimension filters should be implemented as regexps.</param>
        /// <param name="sipCallId">SIP call id</param>
        /// <param name="sipReason">SIP human readable status reason</param>
        /// <param name="lrn"></param>
        /// <param name="sipStatus">SIP status code</param>
        /// <param name="dialogId"></param>
        /// <param name="orgId">Organization id for the placed call</param>
        /// <param name="cnam"></param>
        /// <param name="from">From prefix of the number</param>
        /// <param name="to">To prefix of the number</param>
        /// <param name="gatewayId"></param>
        /// <param name="direction">Direction of the call (e.g. incoming/outgoing)</param>
        /// <param name="serviceId">Purevoice service id</param>
        /// <param name="sendTime"></param>
        /// <param name="answerTime">Time in which the call was connected end to end</param>
        /// <param name="receiveTime">Time in which the call was retrieved by Purevoice</param>
        /// <param name="failTime"></param>
        /// <param name="disconnectTime"></param>
        /// <param name="endTime">Time of success call ending</param>
        /// <param name="cnamTime"></param>
        /// <param name="lnpTime"></param>
        /// <param name="rejectTime"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CarrierservicesReportUsageGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string granularity = null, string dimensions = null, DateTime? startDate = null, DateTime? endDate = null, bool? regexFilterEnabled = null, string sipCallId = null, string sipReason = null, string lrn = null, string sipStatus = null, string dialogId = null, string orgId = null, string cnam = null, string from = null, string to = null, string gatewayId = null, string direction = null, string serviceId = null, DateTime? sendTime = null, DateTime? answerTime = null, DateTime? receiveTime = null, DateTime? failTime = null, DateTime? disconnectTime = null, DateTime? endTime = null, DateTime? cnamTime = null, DateTime? lnpTime = null, DateTime? rejectTime = null)
        {
             await CarrierservicesReportUsageGetAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, granularity, dimensions, startDate, endDate, regexFilterEnabled, sipCallId, sipReason, lrn, sipStatus, dialogId, orgId, cnam, from, to, gatewayId, direction, serviceId, sendTime, answerTime, receiveTime, failTime, disconnectTime, endTime, cnamTime, lnpTime, rejectTime);

        }

        /// <summary>
        /// Get LCR report. This method queries Druid for a Call Stats database report.  Some Druid terminology is required to use it.  Each query parameter besides dimensions, _pgn, and _pgs, is a Druid dimension.  From the Druid documentation: Dimensions: Aspects or categories of data, such as languages or locations. For example, with language and country as the type of dimension, values could be \&quot;English\&quot; or \&quot;Mandarin\&quot; for language, or \&quot;USA\&quot; or \&quot;China\&quot; for country. In Druid, dimensions can serve as filters for narrowing down hits (for example, language = \&quot;English\&quot; or country = \&quot;China\&quot;).  When using a dimension query parameter with a value the report will return events with granularity of that dimension where the dimension value is equal to the value you specified.  If you want to receive events with dimension based granularity with no filter, opt to use the dimensions query parameters, which is a comma  separated list of values that use the other query parameters as dimension names.  Each  parameter needs to be in the screaming snake case format, or words capitalized with underscores between words (i.e. CUSTOMER_ID).
        /// </summary>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="granularity">The granularity field determines how data gets bucketed across the time dimension, or how it gets aggregated by hour, day, minute, etc. all buckets everything into a single bucket. none does not bucket data (it actually uses the granularity of the index - minimum here is none which means millisecond granularity).</param>
        /// <param name="dimensions">Dimensions are really any other parameter specified, excluding granularity.  To specify multiple dimensions use comma separated values.</param>
        /// <param name="startDate">Start dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over.  If not set will always default to now minus 15 days.</param>
        /// <param name="endDate">End dateTime for ISO-8601 Intervals. This defines the time ranges to run the query over. If not set will always default to startDate plus 30 days.</param>
        /// <param name="regexFilterEnabled">Specifies if all dimension filters should be implemented as regexps.</param>
        /// <param name="sipCallId">SIP call id</param>
        /// <param name="sipReason">SIP human readable status reason</param>
        /// <param name="lrn"></param>
        /// <param name="sipStatus">SIP status code</param>
        /// <param name="dialogId"></param>
        /// <param name="orgId">Organization id for the placed call</param>
        /// <param name="cnam"></param>
        /// <param name="from">From prefix of the number</param>
        /// <param name="to">To prefix of the number</param>
        /// <param name="gatewayId"></param>
        /// <param name="direction">Direction of the call (e.g. incoming/outgoing)</param>
        /// <param name="serviceId">Purevoice service id</param>
        /// <param name="sendTime"></param>
        /// <param name="answerTime">Time in which the call was connected end to end</param>
        /// <param name="receiveTime">Time in which the call was retrieved by Purevoice</param>
        /// <param name="failTime"></param>
        /// <param name="disconnectTime"></param>
        /// <param name="endTime">Time of success call ending</param>
        /// <param name="cnamTime"></param>
        /// <param name="lnpTime"></param>
        /// <param name="rejectTime"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CarrierservicesReportUsageGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string granularity = null, string dimensions = null, DateTime? startDate = null, DateTime? endDate = null, bool? regexFilterEnabled = null, string sipCallId = null, string sipReason = null, string lrn = null, string sipStatus = null, string dialogId = null, string orgId = null, string cnam = null, string from = null, string to = null, string gatewayId = null, string direction = null, string serviceId = null, DateTime? sendTime = null, DateTime? answerTime = null, DateTime? receiveTime = null, DateTime? failTime = null, DateTime? disconnectTime = null, DateTime? endTime = null, DateTime? cnamTime = null, DateTime? lnpTime = null, DateTime? rejectTime = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/report/usage";
    
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
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (granularity != null) queryParams.Add("granularity", Configuration.ApiClient.ParameterToString(granularity)); // query parameter
            if (dimensions != null) queryParams.Add("dimensions", Configuration.ApiClient.ParameterToString(dimensions)); // query parameter
            if (startDate != null) queryParams.Add("startDate", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) queryParams.Add("endDate", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            if (regexFilterEnabled != null) queryParams.Add("regexFilterEnabled", Configuration.ApiClient.ParameterToString(regexFilterEnabled)); // query parameter
            if (sipCallId != null) queryParams.Add("sipCallId", Configuration.ApiClient.ParameterToString(sipCallId)); // query parameter
            if (sipReason != null) queryParams.Add("sipReason", Configuration.ApiClient.ParameterToString(sipReason)); // query parameter
            if (lrn != null) queryParams.Add("lrn", Configuration.ApiClient.ParameterToString(lrn)); // query parameter
            if (sipStatus != null) queryParams.Add("sipStatus", Configuration.ApiClient.ParameterToString(sipStatus)); // query parameter
            if (dialogId != null) queryParams.Add("dialogId", Configuration.ApiClient.ParameterToString(dialogId)); // query parameter
            if (orgId != null) queryParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // query parameter
            if (cnam != null) queryParams.Add("cnam", Configuration.ApiClient.ParameterToString(cnam)); // query parameter
            if (from != null) queryParams.Add("from", Configuration.ApiClient.ParameterToString(from)); // query parameter
            if (to != null) queryParams.Add("to", Configuration.ApiClient.ParameterToString(to)); // query parameter
            if (gatewayId != null) queryParams.Add("gatewayId", Configuration.ApiClient.ParameterToString(gatewayId)); // query parameter
            if (direction != null) queryParams.Add("direction", Configuration.ApiClient.ParameterToString(direction)); // query parameter
            if (serviceId != null) queryParams.Add("serviceId", Configuration.ApiClient.ParameterToString(serviceId)); // query parameter
            if (sendTime != null) queryParams.Add("sendTime", Configuration.ApiClient.ParameterToString(sendTime)); // query parameter
            if (answerTime != null) queryParams.Add("answerTime", Configuration.ApiClient.ParameterToString(answerTime)); // query parameter
            if (receiveTime != null) queryParams.Add("receiveTime", Configuration.ApiClient.ParameterToString(receiveTime)); // query parameter
            if (failTime != null) queryParams.Add("failTime", Configuration.ApiClient.ParameterToString(failTime)); // query parameter
            if (disconnectTime != null) queryParams.Add("disconnectTime", Configuration.ApiClient.ParameterToString(disconnectTime)); // query parameter
            if (endTime != null) queryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (cnamTime != null) queryParams.Add("cnamTime", Configuration.ApiClient.ParameterToString(cnamTime)); // query parameter
            if (lnpTime != null) queryParams.Add("lnpTime", Configuration.ApiClient.ParameterToString(lnpTime)); // query parameter
            if (rejectTime != null) queryParams.Add("rejectTime", Configuration.ApiClient.ParameterToString(rejectTime)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesReportUsageGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesReportUsageGet: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get View Url Provides url of a hosted DocuSign view/document, allowing user to sign document electronically
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>EmbeddedSignatureView</returns>
        public EmbeddedSignatureView CarrierservicesSignaturePost (SignatureDocumentInfo body = null)
        {
             ApiResponse<EmbeddedSignatureView> response = CarrierservicesSignaturePostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Get View Url Provides url of a hosted DocuSign view/document, allowing user to sign document electronically
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of EmbeddedSignatureView</returns>
        public ApiResponse< EmbeddedSignatureView > CarrierservicesSignaturePostWithHttpInfo (SignatureDocumentInfo body = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/signature";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesSignaturePost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesSignaturePost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EmbeddedSignatureView>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmbeddedSignatureView) Configuration.ApiClient.Deserialize(response, typeof(EmbeddedSignatureView)));
            
        }
    
        /// <summary>
        /// Get View Url Provides url of a hosted DocuSign view/document, allowing user to sign document electronically
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of EmbeddedSignatureView</returns>
        public async System.Threading.Tasks.Task<EmbeddedSignatureView> CarrierservicesSignaturePostAsync (SignatureDocumentInfo body = null)
        {
             ApiResponse<EmbeddedSignatureView> response = await CarrierservicesSignaturePostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Get View Url Provides url of a hosted DocuSign view/document, allowing user to sign document electronically
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (EmbeddedSignatureView)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmbeddedSignatureView>> CarrierservicesSignaturePostAsyncWithHttpInfo (SignatureDocumentInfo body = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/signature";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesSignaturePost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesSignaturePost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EmbeddedSignatureView>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmbeddedSignatureView) Configuration.ApiClient.Deserialize(response, typeof(EmbeddedSignatureView)));
            
        }
        
        /// <summary>
        /// Get a stored transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="filter">Filter</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="lastEntry">Last entry</param> 
        /// <returns>List&lt;TransformEndpoint&gt;</returns>
        public List<TransformEndpoint> CarrierservicesTransformendpointsGet (string filter = null, string pageSize = null, string lastEntry = null)
        {
             ApiResponse<List<TransformEndpoint>> response = CarrierservicesTransformendpointsGetWithHttpInfo(filter, pageSize, lastEntry);
             return response.Data;
        }

        /// <summary>
        /// Get a stored transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="filter">Filter</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="lastEntry">Last entry</param> 
        /// <returns>ApiResponse of List&lt;TransformEndpoint&gt;</returns>
        public ApiResponse< List<TransformEndpoint> > CarrierservicesTransformendpointsGetWithHttpInfo (string filter = null, string pageSize = null, string lastEntry = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/transformendpoints";
    
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
            
            if (filter != null) queryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (lastEntry != null) queryParams.Add("lastEntry", Configuration.ApiClient.ParameterToString(lastEntry)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformendpointsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformendpointsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<TransformEndpoint>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<TransformEndpoint>) Configuration.ApiClient.Deserialize(response, typeof(List<TransformEndpoint>)));
            
        }
    
        /// <summary>
        /// Get a stored transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="filter">Filter</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="lastEntry">Last entry</param>
        /// <returns>Task of List&lt;TransformEndpoint&gt;</returns>
        public async System.Threading.Tasks.Task<List<TransformEndpoint>> CarrierservicesTransformendpointsGetAsync (string filter = null, string pageSize = null, string lastEntry = null)
        {
             ApiResponse<List<TransformEndpoint>> response = await CarrierservicesTransformendpointsGetAsyncWithHttpInfo(filter, pageSize, lastEntry);
             return response.Data;

        }

        /// <summary>
        /// Get a stored transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="filter">Filter</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="lastEntry">Last entry</param>
        /// <returns>Task of ApiResponse (List&lt;TransformEndpoint&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<TransformEndpoint>>> CarrierservicesTransformendpointsGetAsyncWithHttpInfo (string filter = null, string pageSize = null, string lastEntry = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/transformendpoints";
    
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
            
            if (filter != null) queryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (lastEntry != null) queryParams.Add("lastEntry", Configuration.ApiClient.ParameterToString(lastEntry)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformendpointsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformendpointsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<TransformEndpoint>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<TransformEndpoint>) Configuration.ApiClient.Deserialize(response, typeof(List<TransformEndpoint>)));
            
        }
        
        /// <summary>
        /// Add a new transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>TransformEndpoint</returns>
        public TransformEndpoint CarrierservicesTransformendpointsPost (TransformEndpoint body = null)
        {
             ApiResponse<TransformEndpoint> response = CarrierservicesTransformendpointsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Add a new transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of TransformEndpoint</returns>
        public ApiResponse< TransformEndpoint > CarrierservicesTransformendpointsPostWithHttpInfo (TransformEndpoint body = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/transformendpoints";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformendpointsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformendpointsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TransformEndpoint>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransformEndpoint) Configuration.ApiClient.Deserialize(response, typeof(TransformEndpoint)));
            
        }
    
        /// <summary>
        /// Add a new transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of TransformEndpoint</returns>
        public async System.Threading.Tasks.Task<TransformEndpoint> CarrierservicesTransformendpointsPostAsync (TransformEndpoint body = null)
        {
             ApiResponse<TransformEndpoint> response = await CarrierservicesTransformendpointsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Add a new transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TransformEndpoint)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransformEndpoint>> CarrierservicesTransformendpointsPostAsyncWithHttpInfo (TransformEndpoint body = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/transformendpoints";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformendpointsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformendpointsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TransformEndpoint>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransformEndpoint) Configuration.ApiClient.Deserialize(response, typeof(TransformEndpoint)));
            
        }
        
        /// <summary>
        /// Get a stored Endpoint plan for uploaded Transforms 
        /// </summary>
        /// <param name="id">Endpoint ID</param> 
        /// <returns>TransformEndpoint</returns>
        public TransformEndpoint CarrierservicesTransformendpointsIdGet (string id)
        {
             ApiResponse<TransformEndpoint> response = CarrierservicesTransformendpointsIdGetWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        /// Get a stored Endpoint plan for uploaded Transforms 
        /// </summary>
        /// <param name="id">Endpoint ID</param> 
        /// <returns>ApiResponse of TransformEndpoint</returns>
        public ApiResponse< TransformEndpoint > CarrierservicesTransformendpointsIdGetWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CarrierservicesTransformendpointsIdGet");
            
    
            var path_ = "/api/v1/carrierservices/transformendpoints/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformendpointsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformendpointsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TransformEndpoint>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransformEndpoint) Configuration.ApiClient.Deserialize(response, typeof(TransformEndpoint)));
            
        }
    
        /// <summary>
        /// Get a stored Endpoint plan for uploaded Transforms 
        /// </summary>
        /// <param name="id">Endpoint ID</param>
        /// <returns>Task of TransformEndpoint</returns>
        public async System.Threading.Tasks.Task<TransformEndpoint> CarrierservicesTransformendpointsIdGetAsync (string id)
        {
             ApiResponse<TransformEndpoint> response = await CarrierservicesTransformendpointsIdGetAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        /// Get a stored Endpoint plan for uploaded Transforms 
        /// </summary>
        /// <param name="id">Endpoint ID</param>
        /// <returns>Task of ApiResponse (TransformEndpoint)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransformEndpoint>> CarrierservicesTransformendpointsIdGetAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CarrierservicesTransformendpointsIdGet");
            
    
            var path_ = "/api/v1/carrierservices/transformendpoints/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformendpointsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformendpointsIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TransformEndpoint>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransformEndpoint) Configuration.ApiClient.Deserialize(response, typeof(TransformEndpoint)));
            
        }
        
        /// <summary>
        /// Update an existing Endpoint plan for uploaded Transforms 
        /// </summary>
        /// <param name="id">Endpoint ID</param> 
        /// <param name="body"></param> 
        /// <returns>TransformEndpoint</returns>
        public TransformEndpoint CarrierservicesTransformendpointsIdPut (string id, TransformEndpoint body = null)
        {
             ApiResponse<TransformEndpoint> response = CarrierservicesTransformendpointsIdPutWithHttpInfo(id, body);
             return response.Data;
        }

        /// <summary>
        /// Update an existing Endpoint plan for uploaded Transforms 
        /// </summary>
        /// <param name="id">Endpoint ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of TransformEndpoint</returns>
        public ApiResponse< TransformEndpoint > CarrierservicesTransformendpointsIdPutWithHttpInfo (string id, TransformEndpoint body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CarrierservicesTransformendpointsIdPut");
            
    
            var path_ = "/api/v1/carrierservices/transformendpoints/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformendpointsIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformendpointsIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TransformEndpoint>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransformEndpoint) Configuration.ApiClient.Deserialize(response, typeof(TransformEndpoint)));
            
        }
    
        /// <summary>
        /// Update an existing Endpoint plan for uploaded Transforms 
        /// </summary>
        /// <param name="id">Endpoint ID</param>
        /// <param name="body"></param>
        /// <returns>Task of TransformEndpoint</returns>
        public async System.Threading.Tasks.Task<TransformEndpoint> CarrierservicesTransformendpointsIdPutAsync (string id, TransformEndpoint body = null)
        {
             ApiResponse<TransformEndpoint> response = await CarrierservicesTransformendpointsIdPutAsyncWithHttpInfo(id, body);
             return response.Data;

        }

        /// <summary>
        /// Update an existing Endpoint plan for uploaded Transforms 
        /// </summary>
        /// <param name="id">Endpoint ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TransformEndpoint)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransformEndpoint>> CarrierservicesTransformendpointsIdPutAsyncWithHttpInfo (string id, TransformEndpoint body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CarrierservicesTransformendpointsIdPut");
            
    
            var path_ = "/api/v1/carrierservices/transformendpoints/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformendpointsIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformendpointsIdPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TransformEndpoint>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransformEndpoint) Configuration.ApiClient.Deserialize(response, typeof(TransformEndpoint)));
            
        }
        
        /// <summary>
        /// Delete an existing Endpoint plan for uploaded Transforms 
        /// </summary>
        /// <param name="id">Endpoint ID</param> 
        /// <returns>string</returns>
        public string CarrierservicesTransformendpointsIdDelete (string id)
        {
             ApiResponse<string> response = CarrierservicesTransformendpointsIdDeleteWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        /// Delete an existing Endpoint plan for uploaded Transforms 
        /// </summary>
        /// <param name="id">Endpoint ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > CarrierservicesTransformendpointsIdDeleteWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CarrierservicesTransformendpointsIdDelete");
            
    
            var path_ = "/api/v1/carrierservices/transformendpoints/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformendpointsIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformendpointsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete an existing Endpoint plan for uploaded Transforms 
        /// </summary>
        /// <param name="id">Endpoint ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> CarrierservicesTransformendpointsIdDeleteAsync (string id)
        {
             ApiResponse<string> response = await CarrierservicesTransformendpointsIdDeleteAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        /// Delete an existing Endpoint plan for uploaded Transforms 
        /// </summary>
        /// <param name="id">Endpoint ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> CarrierservicesTransformendpointsIdDeleteAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CarrierservicesTransformendpointsIdDelete");
            
    
            var path_ = "/api/v1/carrierservices/transformendpoints/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformendpointsIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformendpointsIdDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get The progress report for transforming uploaded documents 
        /// </summary>
        /// <param name="service">Service Name</param> 
        /// <returns>List&lt;TransformProgress&gt;</returns>
        public List<TransformProgress> CarrierservicesTransformprogressSearchServiceGet (string service)
        {
             ApiResponse<List<TransformProgress>> response = CarrierservicesTransformprogressSearchServiceGetWithHttpInfo(service);
             return response.Data;
        }

        /// <summary>
        /// Get The progress report for transforming uploaded documents 
        /// </summary>
        /// <param name="service">Service Name</param> 
        /// <returns>ApiResponse of List&lt;TransformProgress&gt;</returns>
        public ApiResponse< List<TransformProgress> > CarrierservicesTransformprogressSearchServiceGetWithHttpInfo (string service)
        {
            
            // verify the required parameter 'service' is set
            if (service == null) throw new ApiException(400, "Missing required parameter 'service' when calling CarrierservicesTransformprogressSearchServiceGet");
            
    
            var path_ = "/api/v1/carrierservices/transformprogress/search/{service}";
    
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
            if (service != null) pathParams.Add("service", Configuration.ApiClient.ParameterToString(service)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformprogressSearchServiceGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformprogressSearchServiceGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<TransformProgress>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<TransformProgress>) Configuration.ApiClient.Deserialize(response, typeof(List<TransformProgress>)));
            
        }
    
        /// <summary>
        /// Get The progress report for transforming uploaded documents 
        /// </summary>
        /// <param name="service">Service Name</param>
        /// <returns>Task of List&lt;TransformProgress&gt;</returns>
        public async System.Threading.Tasks.Task<List<TransformProgress>> CarrierservicesTransformprogressSearchServiceGetAsync (string service)
        {
             ApiResponse<List<TransformProgress>> response = await CarrierservicesTransformprogressSearchServiceGetAsyncWithHttpInfo(service);
             return response.Data;

        }

        /// <summary>
        /// Get The progress report for transforming uploaded documents 
        /// </summary>
        /// <param name="service">Service Name</param>
        /// <returns>Task of ApiResponse (List&lt;TransformProgress&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<TransformProgress>>> CarrierservicesTransformprogressSearchServiceGetAsyncWithHttpInfo (string service)
        {
            // verify the required parameter 'service' is set
            if (service == null) throw new ApiException(400, "Missing required parameter 'service' when calling CarrierservicesTransformprogressSearchServiceGet");
            
    
            var path_ = "/api/v1/carrierservices/transformprogress/search/{service}";
    
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
            if (service != null) pathParams.Add("service", Configuration.ApiClient.ParameterToString(service)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformprogressSearchServiceGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformprogressSearchServiceGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<TransformProgress>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<TransformProgress>) Configuration.ApiClient.Deserialize(response, typeof(List<TransformProgress>)));
            
        }
        
        /// <summary>
        /// Get The progress report for transforming uploaded documents 
        /// </summary>
        /// <param name="service">Service Name</param> 
        /// <param name="modeltype">Model Type</param> 
        /// <returns>List&lt;TransformProgress&gt;</returns>
        public List<TransformProgress> CarrierservicesTransformprogressSearchServiceModeltypeGet (string service, string modeltype)
        {
             ApiResponse<List<TransformProgress>> response = CarrierservicesTransformprogressSearchServiceModeltypeGetWithHttpInfo(service, modeltype);
             return response.Data;
        }

        /// <summary>
        /// Get The progress report for transforming uploaded documents 
        /// </summary>
        /// <param name="service">Service Name</param> 
        /// <param name="modeltype">Model Type</param> 
        /// <returns>ApiResponse of List&lt;TransformProgress&gt;</returns>
        public ApiResponse< List<TransformProgress> > CarrierservicesTransformprogressSearchServiceModeltypeGetWithHttpInfo (string service, string modeltype)
        {
            
            // verify the required parameter 'service' is set
            if (service == null) throw new ApiException(400, "Missing required parameter 'service' when calling CarrierservicesTransformprogressSearchServiceModeltypeGet");
            
            // verify the required parameter 'modeltype' is set
            if (modeltype == null) throw new ApiException(400, "Missing required parameter 'modeltype' when calling CarrierservicesTransformprogressSearchServiceModeltypeGet");
            
    
            var path_ = "/api/v1/carrierservices/transformprogress/search/{service}/{modeltype}";
    
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
            if (service != null) pathParams.Add("service", Configuration.ApiClient.ParameterToString(service)); // path parameter
            if (modeltype != null) pathParams.Add("modeltype", Configuration.ApiClient.ParameterToString(modeltype)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformprogressSearchServiceModeltypeGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformprogressSearchServiceModeltypeGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<TransformProgress>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<TransformProgress>) Configuration.ApiClient.Deserialize(response, typeof(List<TransformProgress>)));
            
        }
    
        /// <summary>
        /// Get The progress report for transforming uploaded documents 
        /// </summary>
        /// <param name="service">Service Name</param>
        /// <param name="modeltype">Model Type</param>
        /// <returns>Task of List&lt;TransformProgress&gt;</returns>
        public async System.Threading.Tasks.Task<List<TransformProgress>> CarrierservicesTransformprogressSearchServiceModeltypeGetAsync (string service, string modeltype)
        {
             ApiResponse<List<TransformProgress>> response = await CarrierservicesTransformprogressSearchServiceModeltypeGetAsyncWithHttpInfo(service, modeltype);
             return response.Data;

        }

        /// <summary>
        /// Get The progress report for transforming uploaded documents 
        /// </summary>
        /// <param name="service">Service Name</param>
        /// <param name="modeltype">Model Type</param>
        /// <returns>Task of ApiResponse (List&lt;TransformProgress&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<TransformProgress>>> CarrierservicesTransformprogressSearchServiceModeltypeGetAsyncWithHttpInfo (string service, string modeltype)
        {
            // verify the required parameter 'service' is set
            if (service == null) throw new ApiException(400, "Missing required parameter 'service' when calling CarrierservicesTransformprogressSearchServiceModeltypeGet");
            // verify the required parameter 'modeltype' is set
            if (modeltype == null) throw new ApiException(400, "Missing required parameter 'modeltype' when calling CarrierservicesTransformprogressSearchServiceModeltypeGet");
            
    
            var path_ = "/api/v1/carrierservices/transformprogress/search/{service}/{modeltype}";
    
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
            if (service != null) pathParams.Add("service", Configuration.ApiClient.ParameterToString(service)); // path parameter
            if (modeltype != null) pathParams.Add("modeltype", Configuration.ApiClient.ParameterToString(modeltype)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformprogressSearchServiceModeltypeGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformprogressSearchServiceModeltypeGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<TransformProgress>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<TransformProgress>) Configuration.ApiClient.Deserialize(response, typeof(List<TransformProgress>)));
            
        }
        
        /// <summary>
        /// Get The progress report for transforming uploaded documents 
        /// </summary>
        /// <param name="service">Service Name</param> 
        /// <param name="modeltype">Model Type</param> 
        /// <param name="modelid">Model ID</param> 
        /// <returns>List&lt;TransformProgress&gt;</returns>
        public List<TransformProgress> CarrierservicesTransformprogressSearchServiceModeltypeModelidGet (string service, string modeltype, string modelid)
        {
             ApiResponse<List<TransformProgress>> response = CarrierservicesTransformprogressSearchServiceModeltypeModelidGetWithHttpInfo(service, modeltype, modelid);
             return response.Data;
        }

        /// <summary>
        /// Get The progress report for transforming uploaded documents 
        /// </summary>
        /// <param name="service">Service Name</param> 
        /// <param name="modeltype">Model Type</param> 
        /// <param name="modelid">Model ID</param> 
        /// <returns>ApiResponse of List&lt;TransformProgress&gt;</returns>
        public ApiResponse< List<TransformProgress> > CarrierservicesTransformprogressSearchServiceModeltypeModelidGetWithHttpInfo (string service, string modeltype, string modelid)
        {
            
            // verify the required parameter 'service' is set
            if (service == null) throw new ApiException(400, "Missing required parameter 'service' when calling CarrierservicesTransformprogressSearchServiceModeltypeModelidGet");
            
            // verify the required parameter 'modeltype' is set
            if (modeltype == null) throw new ApiException(400, "Missing required parameter 'modeltype' when calling CarrierservicesTransformprogressSearchServiceModeltypeModelidGet");
            
            // verify the required parameter 'modelid' is set
            if (modelid == null) throw new ApiException(400, "Missing required parameter 'modelid' when calling CarrierservicesTransformprogressSearchServiceModeltypeModelidGet");
            
    
            var path_ = "/api/v1/carrierservices/transformprogress/search/{service}/{modeltype}/{modelid}";
    
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
            if (service != null) pathParams.Add("service", Configuration.ApiClient.ParameterToString(service)); // path parameter
            if (modeltype != null) pathParams.Add("modeltype", Configuration.ApiClient.ParameterToString(modeltype)); // path parameter
            if (modelid != null) pathParams.Add("modelid", Configuration.ApiClient.ParameterToString(modelid)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformprogressSearchServiceModeltypeModelidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformprogressSearchServiceModeltypeModelidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<TransformProgress>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<TransformProgress>) Configuration.ApiClient.Deserialize(response, typeof(List<TransformProgress>)));
            
        }
    
        /// <summary>
        /// Get The progress report for transforming uploaded documents 
        /// </summary>
        /// <param name="service">Service Name</param>
        /// <param name="modeltype">Model Type</param>
        /// <param name="modelid">Model ID</param>
        /// <returns>Task of List&lt;TransformProgress&gt;</returns>
        public async System.Threading.Tasks.Task<List<TransformProgress>> CarrierservicesTransformprogressSearchServiceModeltypeModelidGetAsync (string service, string modeltype, string modelid)
        {
             ApiResponse<List<TransformProgress>> response = await CarrierservicesTransformprogressSearchServiceModeltypeModelidGetAsyncWithHttpInfo(service, modeltype, modelid);
             return response.Data;

        }

        /// <summary>
        /// Get The progress report for transforming uploaded documents 
        /// </summary>
        /// <param name="service">Service Name</param>
        /// <param name="modeltype">Model Type</param>
        /// <param name="modelid">Model ID</param>
        /// <returns>Task of ApiResponse (List&lt;TransformProgress&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<TransformProgress>>> CarrierservicesTransformprogressSearchServiceModeltypeModelidGetAsyncWithHttpInfo (string service, string modeltype, string modelid)
        {
            // verify the required parameter 'service' is set
            if (service == null) throw new ApiException(400, "Missing required parameter 'service' when calling CarrierservicesTransformprogressSearchServiceModeltypeModelidGet");
            // verify the required parameter 'modeltype' is set
            if (modeltype == null) throw new ApiException(400, "Missing required parameter 'modeltype' when calling CarrierservicesTransformprogressSearchServiceModeltypeModelidGet");
            // verify the required parameter 'modelid' is set
            if (modelid == null) throw new ApiException(400, "Missing required parameter 'modelid' when calling CarrierservicesTransformprogressSearchServiceModeltypeModelidGet");
            
    
            var path_ = "/api/v1/carrierservices/transformprogress/search/{service}/{modeltype}/{modelid}";
    
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
            if (service != null) pathParams.Add("service", Configuration.ApiClient.ParameterToString(service)); // path parameter
            if (modeltype != null) pathParams.Add("modeltype", Configuration.ApiClient.ParameterToString(modeltype)); // path parameter
            if (modelid != null) pathParams.Add("modelid", Configuration.ApiClient.ParameterToString(modelid)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformprogressSearchServiceModeltypeModelidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformprogressSearchServiceModeltypeModelidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<TransformProgress>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<TransformProgress>) Configuration.ApiClient.Deserialize(response, typeof(List<TransformProgress>)));
            
        }
        
        /// <summary>
        /// The progress report for an upload 
        /// </summary>
        /// <param name="id">Upload Progress ID</param> 
        /// <returns>TransformProgress</returns>
        public TransformProgress CarrierservicesTransformprogressIdGet (string id)
        {
             ApiResponse<TransformProgress> response = CarrierservicesTransformprogressIdGetWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        /// The progress report for an upload 
        /// </summary>
        /// <param name="id">Upload Progress ID</param> 
        /// <returns>ApiResponse of TransformProgress</returns>
        public ApiResponse< TransformProgress > CarrierservicesTransformprogressIdGetWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CarrierservicesTransformprogressIdGet");
            
    
            var path_ = "/api/v1/carrierservices/transformprogress/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformprogressIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformprogressIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TransformProgress>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransformProgress) Configuration.ApiClient.Deserialize(response, typeof(TransformProgress)));
            
        }
    
        /// <summary>
        /// The progress report for an upload 
        /// </summary>
        /// <param name="id">Upload Progress ID</param>
        /// <returns>Task of TransformProgress</returns>
        public async System.Threading.Tasks.Task<TransformProgress> CarrierservicesTransformprogressIdGetAsync (string id)
        {
             ApiResponse<TransformProgress> response = await CarrierservicesTransformprogressIdGetAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        /// The progress report for an upload 
        /// </summary>
        /// <param name="id">Upload Progress ID</param>
        /// <returns>Task of ApiResponse (TransformProgress)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransformProgress>> CarrierservicesTransformprogressIdGetAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CarrierservicesTransformprogressIdGet");
            
    
            var path_ = "/api/v1/carrierservices/transformprogress/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformprogressIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesTransformprogressIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TransformProgress>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransformProgress) Configuration.ApiClient.Deserialize(response, typeof(TransformProgress)));
            
        }
        
        /// <summary>
        /// Get a stored transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="filter">Filter</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="lastEntry">Last entry</param> 
        /// <returns>SpreadsheetTransformEntityListing</returns>
        public SpreadsheetTransformEntityListing CarrierservicesUploadtransformSpreadsheetsGet (string filter = null, string pageSize = null, string lastEntry = null)
        {
             ApiResponse<SpreadsheetTransformEntityListing> response = CarrierservicesUploadtransformSpreadsheetsGetWithHttpInfo(filter, pageSize, lastEntry);
             return response.Data;
        }

        /// <summary>
        /// Get a stored transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="filter">Filter</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="lastEntry">Last entry</param> 
        /// <returns>ApiResponse of SpreadsheetTransformEntityListing</returns>
        public ApiResponse< SpreadsheetTransformEntityListing > CarrierservicesUploadtransformSpreadsheetsGetWithHttpInfo (string filter = null, string pageSize = null, string lastEntry = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/uploadtransform/spreadsheets";
    
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
            
            if (filter != null) queryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (lastEntry != null) queryParams.Add("lastEntry", Configuration.ApiClient.ParameterToString(lastEntry)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformSpreadsheetsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformSpreadsheetsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SpreadsheetTransformEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SpreadsheetTransformEntityListing) Configuration.ApiClient.Deserialize(response, typeof(SpreadsheetTransformEntityListing)));
            
        }
    
        /// <summary>
        /// Get a stored transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="filter">Filter</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="lastEntry">Last entry</param>
        /// <returns>Task of SpreadsheetTransformEntityListing</returns>
        public async System.Threading.Tasks.Task<SpreadsheetTransformEntityListing> CarrierservicesUploadtransformSpreadsheetsGetAsync (string filter = null, string pageSize = null, string lastEntry = null)
        {
             ApiResponse<SpreadsheetTransformEntityListing> response = await CarrierservicesUploadtransformSpreadsheetsGetAsyncWithHttpInfo(filter, pageSize, lastEntry);
             return response.Data;

        }

        /// <summary>
        /// Get a stored transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="filter">Filter</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="lastEntry">Last entry</param>
        /// <returns>Task of ApiResponse (SpreadsheetTransformEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SpreadsheetTransformEntityListing>> CarrierservicesUploadtransformSpreadsheetsGetAsyncWithHttpInfo (string filter = null, string pageSize = null, string lastEntry = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/uploadtransform/spreadsheets";
    
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
            
            if (filter != null) queryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (lastEntry != null) queryParams.Add("lastEntry", Configuration.ApiClient.ParameterToString(lastEntry)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformSpreadsheetsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformSpreadsheetsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SpreadsheetTransformEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SpreadsheetTransformEntityListing) Configuration.ApiClient.Deserialize(response, typeof(SpreadsheetTransformEntityListing)));
            
        }
        
        /// <summary>
        /// Add a new transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>SpreadsheetTransform</returns>
        public SpreadsheetTransform CarrierservicesUploadtransformSpreadsheetsPost (SpreadsheetTransform body = null)
        {
             ApiResponse<SpreadsheetTransform> response = CarrierservicesUploadtransformSpreadsheetsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Add a new transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of SpreadsheetTransform</returns>
        public ApiResponse< SpreadsheetTransform > CarrierservicesUploadtransformSpreadsheetsPostWithHttpInfo (SpreadsheetTransform body = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/uploadtransform/spreadsheets";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformSpreadsheetsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformSpreadsheetsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SpreadsheetTransform>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SpreadsheetTransform) Configuration.ApiClient.Deserialize(response, typeof(SpreadsheetTransform)));
            
        }
    
        /// <summary>
        /// Add a new transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of SpreadsheetTransform</returns>
        public async System.Threading.Tasks.Task<SpreadsheetTransform> CarrierservicesUploadtransformSpreadsheetsPostAsync (SpreadsheetTransform body = null)
        {
             ApiResponse<SpreadsheetTransform> response = await CarrierservicesUploadtransformSpreadsheetsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Add a new transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (SpreadsheetTransform)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SpreadsheetTransform>> CarrierservicesUploadtransformSpreadsheetsPostAsyncWithHttpInfo (SpreadsheetTransform body = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/uploadtransform/spreadsheets";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformSpreadsheetsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformSpreadsheetsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SpreadsheetTransform>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SpreadsheetTransform) Configuration.ApiClient.Deserialize(response, typeof(SpreadsheetTransform)));
            
        }
        
        /// <summary>
        /// Get a stored transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="id">Transform ID</param> 
        /// <returns>SpreadsheetTransform</returns>
        public SpreadsheetTransform CarrierservicesUploadtransformSpreadsheetsIdGet (string id)
        {
             ApiResponse<SpreadsheetTransform> response = CarrierservicesUploadtransformSpreadsheetsIdGetWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        /// Get a stored transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="id">Transform ID</param> 
        /// <returns>ApiResponse of SpreadsheetTransform</returns>
        public ApiResponse< SpreadsheetTransform > CarrierservicesUploadtransformSpreadsheetsIdGetWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CarrierservicesUploadtransformSpreadsheetsIdGet");
            
    
            var path_ = "/api/v1/carrierservices/uploadtransform/spreadsheets/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformSpreadsheetsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformSpreadsheetsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SpreadsheetTransform>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SpreadsheetTransform) Configuration.ApiClient.Deserialize(response, typeof(SpreadsheetTransform)));
            
        }
    
        /// <summary>
        /// Get a stored transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="id">Transform ID</param>
        /// <returns>Task of SpreadsheetTransform</returns>
        public async System.Threading.Tasks.Task<SpreadsheetTransform> CarrierservicesUploadtransformSpreadsheetsIdGetAsync (string id)
        {
             ApiResponse<SpreadsheetTransform> response = await CarrierservicesUploadtransformSpreadsheetsIdGetAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        /// Get a stored transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="id">Transform ID</param>
        /// <returns>Task of ApiResponse (SpreadsheetTransform)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SpreadsheetTransform>> CarrierservicesUploadtransformSpreadsheetsIdGetAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CarrierservicesUploadtransformSpreadsheetsIdGet");
            
    
            var path_ = "/api/v1/carrierservices/uploadtransform/spreadsheets/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformSpreadsheetsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformSpreadsheetsIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SpreadsheetTransform>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SpreadsheetTransform) Configuration.ApiClient.Deserialize(response, typeof(SpreadsheetTransform)));
            
        }
        
        /// <summary>
        /// Update an existing transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="id">Transform ID</param> 
        /// <param name="body"></param> 
        /// <returns>SpreadsheetTransform</returns>
        public SpreadsheetTransform CarrierservicesUploadtransformSpreadsheetsIdPut (string id, SpreadsheetTransform body = null)
        {
             ApiResponse<SpreadsheetTransform> response = CarrierservicesUploadtransformSpreadsheetsIdPutWithHttpInfo(id, body);
             return response.Data;
        }

        /// <summary>
        /// Update an existing transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="id">Transform ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of SpreadsheetTransform</returns>
        public ApiResponse< SpreadsheetTransform > CarrierservicesUploadtransformSpreadsheetsIdPutWithHttpInfo (string id, SpreadsheetTransform body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CarrierservicesUploadtransformSpreadsheetsIdPut");
            
    
            var path_ = "/api/v1/carrierservices/uploadtransform/spreadsheets/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformSpreadsheetsIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformSpreadsheetsIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SpreadsheetTransform>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SpreadsheetTransform) Configuration.ApiClient.Deserialize(response, typeof(SpreadsheetTransform)));
            
        }
    
        /// <summary>
        /// Update an existing transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="id">Transform ID</param>
        /// <param name="body"></param>
        /// <returns>Task of SpreadsheetTransform</returns>
        public async System.Threading.Tasks.Task<SpreadsheetTransform> CarrierservicesUploadtransformSpreadsheetsIdPutAsync (string id, SpreadsheetTransform body = null)
        {
             ApiResponse<SpreadsheetTransform> response = await CarrierservicesUploadtransformSpreadsheetsIdPutAsyncWithHttpInfo(id, body);
             return response.Data;

        }

        /// <summary>
        /// Update an existing transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="id">Transform ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (SpreadsheetTransform)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SpreadsheetTransform>> CarrierservicesUploadtransformSpreadsheetsIdPutAsyncWithHttpInfo (string id, SpreadsheetTransform body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CarrierservicesUploadtransformSpreadsheetsIdPut");
            
    
            var path_ = "/api/v1/carrierservices/uploadtransform/spreadsheets/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformSpreadsheetsIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformSpreadsheetsIdPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SpreadsheetTransform>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SpreadsheetTransform) Configuration.ApiClient.Deserialize(response, typeof(SpreadsheetTransform)));
            
        }
        
        /// <summary>
        /// Delete an existing transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="id">Transform ID</param> 
        /// <returns>string</returns>
        public string CarrierservicesUploadtransformSpreadsheetsIdDelete (string id)
        {
             ApiResponse<string> response = CarrierservicesUploadtransformSpreadsheetsIdDeleteWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        /// Delete an existing transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="id">Transform ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > CarrierservicesUploadtransformSpreadsheetsIdDeleteWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CarrierservicesUploadtransformSpreadsheetsIdDelete");
            
    
            var path_ = "/api/v1/carrierservices/uploadtransform/spreadsheets/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformSpreadsheetsIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformSpreadsheetsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete an existing transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="id">Transform ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> CarrierservicesUploadtransformSpreadsheetsIdDeleteAsync (string id)
        {
             ApiResponse<string> response = await CarrierservicesUploadtransformSpreadsheetsIdDeleteAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        /// Delete an existing transform plan for uploaded spreadsheets 
        /// </summary>
        /// <param name="id">Transform ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> CarrierservicesUploadtransformSpreadsheetsIdDeleteAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CarrierservicesUploadtransformSpreadsheetsIdDelete");
            
    
            var path_ = "/api/v1/carrierservices/uploadtransform/spreadsheets/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformSpreadsheetsIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformSpreadsheetsIdDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get a stored transform plan for uploaded delimited text tables 
        /// </summary>
        /// <param name="filter">Filter</param> 
        /// <returns>TextTableTransformEntityListing</returns>
        public TextTableTransformEntityListing CarrierservicesUploadtransformTexttablesGet (string filter = null)
        {
             ApiResponse<TextTableTransformEntityListing> response = CarrierservicesUploadtransformTexttablesGetWithHttpInfo(filter);
             return response.Data;
        }

        /// <summary>
        /// Get a stored transform plan for uploaded delimited text tables 
        /// </summary>
        /// <param name="filter">Filter</param> 
        /// <returns>ApiResponse of TextTableTransformEntityListing</returns>
        public ApiResponse< TextTableTransformEntityListing > CarrierservicesUploadtransformTexttablesGetWithHttpInfo (string filter = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/uploadtransform/texttables";
    
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
            
            if (filter != null) queryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformTexttablesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformTexttablesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TextTableTransformEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextTableTransformEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TextTableTransformEntityListing)));
            
        }
    
        /// <summary>
        /// Get a stored transform plan for uploaded delimited text tables 
        /// </summary>
        /// <param name="filter">Filter</param>
        /// <returns>Task of TextTableTransformEntityListing</returns>
        public async System.Threading.Tasks.Task<TextTableTransformEntityListing> CarrierservicesUploadtransformTexttablesGetAsync (string filter = null)
        {
             ApiResponse<TextTableTransformEntityListing> response = await CarrierservicesUploadtransformTexttablesGetAsyncWithHttpInfo(filter);
             return response.Data;

        }

        /// <summary>
        /// Get a stored transform plan for uploaded delimited text tables 
        /// </summary>
        /// <param name="filter">Filter</param>
        /// <returns>Task of ApiResponse (TextTableTransformEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TextTableTransformEntityListing>> CarrierservicesUploadtransformTexttablesGetAsyncWithHttpInfo (string filter = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/uploadtransform/texttables";
    
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
            
            if (filter != null) queryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformTexttablesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformTexttablesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TextTableTransformEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextTableTransformEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TextTableTransformEntityListing)));
            
        }
        
        /// <summary>
        /// Add a new transform plan for uploaded delimited text tables 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>TextTableTransform</returns>
        public TextTableTransform CarrierservicesUploadtransformTexttablesPost (TextTableTransform body = null)
        {
             ApiResponse<TextTableTransform> response = CarrierservicesUploadtransformTexttablesPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Add a new transform plan for uploaded delimited text tables 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of TextTableTransform</returns>
        public ApiResponse< TextTableTransform > CarrierservicesUploadtransformTexttablesPostWithHttpInfo (TextTableTransform body = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/uploadtransform/texttables";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformTexttablesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformTexttablesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TextTableTransform>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextTableTransform) Configuration.ApiClient.Deserialize(response, typeof(TextTableTransform)));
            
        }
    
        /// <summary>
        /// Add a new transform plan for uploaded delimited text tables 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of TextTableTransform</returns>
        public async System.Threading.Tasks.Task<TextTableTransform> CarrierservicesUploadtransformTexttablesPostAsync (TextTableTransform body = null)
        {
             ApiResponse<TextTableTransform> response = await CarrierservicesUploadtransformTexttablesPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Add a new transform plan for uploaded delimited text tables 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TextTableTransform)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TextTableTransform>> CarrierservicesUploadtransformTexttablesPostAsyncWithHttpInfo (TextTableTransform body = null)
        {
            
    
            var path_ = "/api/v1/carrierservices/uploadtransform/texttables";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformTexttablesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformTexttablesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TextTableTransform>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextTableTransform) Configuration.ApiClient.Deserialize(response, typeof(TextTableTransform)));
            
        }
        
        /// <summary>
        /// Get a stored transform plan for uploaded delimited text tables 
        /// </summary>
        /// <param name="id">Transform ID</param> 
        /// <returns>TextTableTransform</returns>
        public TextTableTransform CarrierservicesUploadtransformTexttablesIdGet (string id)
        {
             ApiResponse<TextTableTransform> response = CarrierservicesUploadtransformTexttablesIdGetWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        /// Get a stored transform plan for uploaded delimited text tables 
        /// </summary>
        /// <param name="id">Transform ID</param> 
        /// <returns>ApiResponse of TextTableTransform</returns>
        public ApiResponse< TextTableTransform > CarrierservicesUploadtransformTexttablesIdGetWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CarrierservicesUploadtransformTexttablesIdGet");
            
    
            var path_ = "/api/v1/carrierservices/uploadtransform/texttables/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformTexttablesIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformTexttablesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TextTableTransform>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextTableTransform) Configuration.ApiClient.Deserialize(response, typeof(TextTableTransform)));
            
        }
    
        /// <summary>
        /// Get a stored transform plan for uploaded delimited text tables 
        /// </summary>
        /// <param name="id">Transform ID</param>
        /// <returns>Task of TextTableTransform</returns>
        public async System.Threading.Tasks.Task<TextTableTransform> CarrierservicesUploadtransformTexttablesIdGetAsync (string id)
        {
             ApiResponse<TextTableTransform> response = await CarrierservicesUploadtransformTexttablesIdGetAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        /// Get a stored transform plan for uploaded delimited text tables 
        /// </summary>
        /// <param name="id">Transform ID</param>
        /// <returns>Task of ApiResponse (TextTableTransform)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TextTableTransform>> CarrierservicesUploadtransformTexttablesIdGetAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CarrierservicesUploadtransformTexttablesIdGet");
            
    
            var path_ = "/api/v1/carrierservices/uploadtransform/texttables/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformTexttablesIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformTexttablesIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TextTableTransform>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextTableTransform) Configuration.ApiClient.Deserialize(response, typeof(TextTableTransform)));
            
        }
        
        /// <summary>
        /// Update an existing transform plan for uploaded delimited text tables 
        /// </summary>
        /// <param name="id">Transform ID</param> 
        /// <param name="body"></param> 
        /// <returns>TextTableTransform</returns>
        public TextTableTransform CarrierservicesUploadtransformTexttablesIdPut (string id, TextTableTransform body = null)
        {
             ApiResponse<TextTableTransform> response = CarrierservicesUploadtransformTexttablesIdPutWithHttpInfo(id, body);
             return response.Data;
        }

        /// <summary>
        /// Update an existing transform plan for uploaded delimited text tables 
        /// </summary>
        /// <param name="id">Transform ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of TextTableTransform</returns>
        public ApiResponse< TextTableTransform > CarrierservicesUploadtransformTexttablesIdPutWithHttpInfo (string id, TextTableTransform body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CarrierservicesUploadtransformTexttablesIdPut");
            
    
            var path_ = "/api/v1/carrierservices/uploadtransform/texttables/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformTexttablesIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformTexttablesIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TextTableTransform>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextTableTransform) Configuration.ApiClient.Deserialize(response, typeof(TextTableTransform)));
            
        }
    
        /// <summary>
        /// Update an existing transform plan for uploaded delimited text tables 
        /// </summary>
        /// <param name="id">Transform ID</param>
        /// <param name="body"></param>
        /// <returns>Task of TextTableTransform</returns>
        public async System.Threading.Tasks.Task<TextTableTransform> CarrierservicesUploadtransformTexttablesIdPutAsync (string id, TextTableTransform body = null)
        {
             ApiResponse<TextTableTransform> response = await CarrierservicesUploadtransformTexttablesIdPutAsyncWithHttpInfo(id, body);
             return response.Data;

        }

        /// <summary>
        /// Update an existing transform plan for uploaded delimited text tables 
        /// </summary>
        /// <param name="id">Transform ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (TextTableTransform)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TextTableTransform>> CarrierservicesUploadtransformTexttablesIdPutAsyncWithHttpInfo (string id, TextTableTransform body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CarrierservicesUploadtransformTexttablesIdPut");
            
    
            var path_ = "/api/v1/carrierservices/uploadtransform/texttables/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformTexttablesIdPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformTexttablesIdPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TextTableTransform>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextTableTransform) Configuration.ApiClient.Deserialize(response, typeof(TextTableTransform)));
            
        }
        
        /// <summary>
        /// Delete an existing transform plan for uploaded delimited text tables 
        /// </summary>
        /// <param name="id">Transform ID</param> 
        /// <returns>string</returns>
        public string CarrierservicesUploadtransformTexttablesIdDelete (string id)
        {
             ApiResponse<string> response = CarrierservicesUploadtransformTexttablesIdDeleteWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        /// Delete an existing transform plan for uploaded delimited text tables 
        /// </summary>
        /// <param name="id">Transform ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > CarrierservicesUploadtransformTexttablesIdDeleteWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CarrierservicesUploadtransformTexttablesIdDelete");
            
    
            var path_ = "/api/v1/carrierservices/uploadtransform/texttables/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformTexttablesIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformTexttablesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete an existing transform plan for uploaded delimited text tables 
        /// </summary>
        /// <param name="id">Transform ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> CarrierservicesUploadtransformTexttablesIdDeleteAsync (string id)
        {
             ApiResponse<string> response = await CarrierservicesUploadtransformTexttablesIdDeleteAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        /// Delete an existing transform plan for uploaded delimited text tables 
        /// </summary>
        /// <param name="id">Transform ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> CarrierservicesUploadtransformTexttablesIdDeleteAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CarrierservicesUploadtransformTexttablesIdDelete");
            
    
            var path_ = "/api/v1/carrierservices/uploadtransform/texttables/{id}";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformTexttablesIdDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesUploadtransformTexttablesIdDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get all available XLSX schemas. 
        /// </summary>
        /// <returns>XlsxSchema</returns>
        public XlsxSchema CarrierservicesXlsxschemasGet ()
        {
             ApiResponse<XlsxSchema> response = CarrierservicesXlsxschemasGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get all available XLSX schemas. 
        /// </summary>
        /// <returns>ApiResponse of XlsxSchema</returns>
        public ApiResponse< XlsxSchema > CarrierservicesXlsxschemasGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/carrierservices/xlsxschemas";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesXlsxschemasGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesXlsxschemasGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<XlsxSchema>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (XlsxSchema) Configuration.ApiClient.Deserialize(response, typeof(XlsxSchema)));
            
        }
    
        /// <summary>
        /// Get all available XLSX schemas. 
        /// </summary>
        /// <returns>Task of XlsxSchema</returns>
        public async System.Threading.Tasks.Task<XlsxSchema> CarrierservicesXlsxschemasGetAsync ()
        {
             ApiResponse<XlsxSchema> response = await CarrierservicesXlsxschemasGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get all available XLSX schemas. 
        /// </summary>
        /// <returns>Task of ApiResponse (XlsxSchema)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<XlsxSchema>> CarrierservicesXlsxschemasGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/carrierservices/xlsxschemas";
    
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
                throw new ApiException (statusCode, "Error calling CarrierservicesXlsxschemasGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesXlsxschemasGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<XlsxSchema>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (XlsxSchema) Configuration.ApiClient.Deserialize(response, typeof(XlsxSchema)));
            
        }
        
        /// <summary>
        /// Get all XLSX schemas for a given carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <returns>XlsxSchema</returns>
        public XlsxSchema CarrierservicesXlsxschemasCarrieridGet (string carrierId)
        {
             ApiResponse<XlsxSchema> response = CarrierservicesXlsxschemasCarrieridGetWithHttpInfo(carrierId);
             return response.Data;
        }

        /// <summary>
        /// Get all XLSX schemas for a given carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <returns>ApiResponse of XlsxSchema</returns>
        public ApiResponse< XlsxSchema > CarrierservicesXlsxschemasCarrieridGetWithHttpInfo (string carrierId)
        {
            
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesXlsxschemasCarrieridGet");
            
    
            var path_ = "/api/v1/carrierservices/xlsxschemas/{carrierId}";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesXlsxschemasCarrieridGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesXlsxschemasCarrieridGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<XlsxSchema>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (XlsxSchema) Configuration.ApiClient.Deserialize(response, typeof(XlsxSchema)));
            
        }
    
        /// <summary>
        /// Get all XLSX schemas for a given carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <returns>Task of XlsxSchema</returns>
        public async System.Threading.Tasks.Task<XlsxSchema> CarrierservicesXlsxschemasCarrieridGetAsync (string carrierId)
        {
             ApiResponse<XlsxSchema> response = await CarrierservicesXlsxschemasCarrieridGetAsyncWithHttpInfo(carrierId);
             return response.Data;

        }

        /// <summary>
        /// Get all XLSX schemas for a given carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <returns>Task of ApiResponse (XlsxSchema)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<XlsxSchema>> CarrierservicesXlsxschemasCarrieridGetAsyncWithHttpInfo (string carrierId)
        {
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesXlsxschemasCarrieridGet");
            
    
            var path_ = "/api/v1/carrierservices/xlsxschemas/{carrierId}";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesXlsxschemasCarrieridGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesXlsxschemasCarrieridGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<XlsxSchema>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (XlsxSchema) Configuration.ApiClient.Deserialize(response, typeof(XlsxSchema)));
            
        }
        
        /// <summary>
        /// Updates or creates a XLSX schema for a carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <param name="body">Schema data</param> 
        /// <returns>XlsxSchema</returns>
        public XlsxSchema CarrierservicesXlsxschemasCarrieridPut (string carrierId, XlsxSchema body = null)
        {
             ApiResponse<XlsxSchema> response = CarrierservicesXlsxschemasCarrieridPutWithHttpInfo(carrierId, body);
             return response.Data;
        }

        /// <summary>
        /// Updates or creates a XLSX schema for a carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <param name="body">Schema data</param> 
        /// <returns>ApiResponse of XlsxSchema</returns>
        public ApiResponse< XlsxSchema > CarrierservicesXlsxschemasCarrieridPutWithHttpInfo (string carrierId, XlsxSchema body = null)
        {
            
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesXlsxschemasCarrieridPut");
            
    
            var path_ = "/api/v1/carrierservices/xlsxschemas/{carrierId}";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesXlsxschemasCarrieridPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesXlsxschemasCarrieridPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<XlsxSchema>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (XlsxSchema) Configuration.ApiClient.Deserialize(response, typeof(XlsxSchema)));
            
        }
    
        /// <summary>
        /// Updates or creates a XLSX schema for a carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="body">Schema data</param>
        /// <returns>Task of XlsxSchema</returns>
        public async System.Threading.Tasks.Task<XlsxSchema> CarrierservicesXlsxschemasCarrieridPutAsync (string carrierId, XlsxSchema body = null)
        {
             ApiResponse<XlsxSchema> response = await CarrierservicesXlsxschemasCarrieridPutAsyncWithHttpInfo(carrierId, body);
             return response.Data;

        }

        /// <summary>
        /// Updates or creates a XLSX schema for a carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="body">Schema data</param>
        /// <returns>Task of ApiResponse (XlsxSchema)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<XlsxSchema>> CarrierservicesXlsxschemasCarrieridPutAsyncWithHttpInfo (string carrierId, XlsxSchema body = null)
        {
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesXlsxschemasCarrieridPut");
            
    
            var path_ = "/api/v1/carrierservices/xlsxschemas/{carrierId}";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesXlsxschemasCarrieridPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesXlsxschemasCarrieridPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<XlsxSchema>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (XlsxSchema) Configuration.ApiClient.Deserialize(response, typeof(XlsxSchema)));
            
        }
        
        /// <summary>
        /// Get all XLSX schemas for a given carrier and name. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <param name="name">Schema name</param> 
        /// <returns>XlsxSchema</returns>
        public XlsxSchema CarrierservicesXlsxschemasCarrieridNameNameGet (string carrierId, string name)
        {
             ApiResponse<XlsxSchema> response = CarrierservicesXlsxschemasCarrieridNameNameGetWithHttpInfo(carrierId, name);
             return response.Data;
        }

        /// <summary>
        /// Get all XLSX schemas for a given carrier and name. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <param name="name">Schema name</param> 
        /// <returns>ApiResponse of XlsxSchema</returns>
        public ApiResponse< XlsxSchema > CarrierservicesXlsxschemasCarrieridNameNameGetWithHttpInfo (string carrierId, string name)
        {
            
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesXlsxschemasCarrieridNameNameGet");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling CarrierservicesXlsxschemasCarrieridNameNameGet");
            
    
            var path_ = "/api/v1/carrierservices/xlsxschemas/{carrierId}/name/{name}";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            if (name != null) pathParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesXlsxschemasCarrieridNameNameGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesXlsxschemasCarrieridNameNameGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<XlsxSchema>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (XlsxSchema) Configuration.ApiClient.Deserialize(response, typeof(XlsxSchema)));
            
        }
    
        /// <summary>
        /// Get all XLSX schemas for a given carrier and name. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="name">Schema name</param>
        /// <returns>Task of XlsxSchema</returns>
        public async System.Threading.Tasks.Task<XlsxSchema> CarrierservicesXlsxschemasCarrieridNameNameGetAsync (string carrierId, string name)
        {
             ApiResponse<XlsxSchema> response = await CarrierservicesXlsxschemasCarrieridNameNameGetAsyncWithHttpInfo(carrierId, name);
             return response.Data;

        }

        /// <summary>
        /// Get all XLSX schemas for a given carrier and name. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="name">Schema name</param>
        /// <returns>Task of ApiResponse (XlsxSchema)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<XlsxSchema>> CarrierservicesXlsxschemasCarrieridNameNameGetAsyncWithHttpInfo (string carrierId, string name)
        {
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesXlsxschemasCarrieridNameNameGet");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling CarrierservicesXlsxschemasCarrieridNameNameGet");
            
    
            var path_ = "/api/v1/carrierservices/xlsxschemas/{carrierId}/name/{name}";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            if (name != null) pathParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesXlsxschemasCarrieridNameNameGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesXlsxschemasCarrieridNameNameGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<XlsxSchema>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (XlsxSchema) Configuration.ApiClient.Deserialize(response, typeof(XlsxSchema)));
            
        }
        
        /// <summary>
        /// Deletes a XLSX schema for a carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <param name="name">Schema name</param> 
        /// <returns>XlsxSchema</returns>
        public XlsxSchema CarrierservicesXlsxschemasCarrieridNameNameDelete (string carrierId, string name)
        {
             ApiResponse<XlsxSchema> response = CarrierservicesXlsxschemasCarrieridNameNameDeleteWithHttpInfo(carrierId, name);
             return response.Data;
        }

        /// <summary>
        /// Deletes a XLSX schema for a carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param> 
        /// <param name="name">Schema name</param> 
        /// <returns>ApiResponse of XlsxSchema</returns>
        public ApiResponse< XlsxSchema > CarrierservicesXlsxschemasCarrieridNameNameDeleteWithHttpInfo (string carrierId, string name)
        {
            
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesXlsxschemasCarrieridNameNameDelete");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling CarrierservicesXlsxschemasCarrieridNameNameDelete");
            
    
            var path_ = "/api/v1/carrierservices/xlsxschemas/{carrierId}/name/{name}";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            if (name != null) pathParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesXlsxschemasCarrieridNameNameDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesXlsxschemasCarrieridNameNameDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<XlsxSchema>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (XlsxSchema) Configuration.ApiClient.Deserialize(response, typeof(XlsxSchema)));
            
        }
    
        /// <summary>
        /// Deletes a XLSX schema for a carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="name">Schema name</param>
        /// <returns>Task of XlsxSchema</returns>
        public async System.Threading.Tasks.Task<XlsxSchema> CarrierservicesXlsxschemasCarrieridNameNameDeleteAsync (string carrierId, string name)
        {
             ApiResponse<XlsxSchema> response = await CarrierservicesXlsxschemasCarrieridNameNameDeleteAsyncWithHttpInfo(carrierId, name);
             return response.Data;

        }

        /// <summary>
        /// Deletes a XLSX schema for a carrier. 
        /// </summary>
        /// <param name="carrierId">Carrier ID</param>
        /// <param name="name">Schema name</param>
        /// <returns>Task of ApiResponse (XlsxSchema)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<XlsxSchema>> CarrierservicesXlsxschemasCarrieridNameNameDeleteAsyncWithHttpInfo (string carrierId, string name)
        {
            // verify the required parameter 'carrierId' is set
            if (carrierId == null) throw new ApiException(400, "Missing required parameter 'carrierId' when calling CarrierservicesXlsxschemasCarrieridNameNameDelete");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling CarrierservicesXlsxschemasCarrieridNameNameDelete");
            
    
            var path_ = "/api/v1/carrierservices/xlsxschemas/{carrierId}/name/{name}";
    
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
            if (carrierId != null) pathParams.Add("carrierId", Configuration.ApiClient.ParameterToString(carrierId)); // path parameter
            if (name != null) pathParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling CarrierservicesXlsxschemasCarrieridNameNameDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CarrierservicesXlsxschemasCarrieridNameNameDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<XlsxSchema>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (XlsxSchema) Configuration.ApiClient.Deserialize(response, typeof(XlsxSchema)));
            
        }
        
    }
    
}
