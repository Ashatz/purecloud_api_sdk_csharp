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
    public interface IBillingApi
    {
        
        /// <summary>
        /// Get constumer account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>CustomerAccount</returns>
        CustomerAccount BillingAccountGet ();
  
        /// <summary>
        /// Get constumer account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of CustomerAccount</returns>
        ApiResponse<CustomerAccount> BillingAccountGetWithHttpInfo ();

        /// <summary>
        /// Get constumer account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of CustomerAccount</returns>
        System.Threading.Tasks.Task<CustomerAccount> BillingAccountGetAsync ();

        /// <summary>
        /// Get constumer account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (CustomerAccount)</returns>
        System.Threading.Tasks.Task<ApiResponse<CustomerAccount>> BillingAccountGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Update customer account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The account to be updated</param>
        /// <returns>CustomerAccount</returns>
        CustomerAccount BillingAccountPut (CustomerAccount body = null);
  
        /// <summary>
        /// Update customer account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The account to be updated</param>
        /// <returns>ApiResponse of CustomerAccount</returns>
        ApiResponse<CustomerAccount> BillingAccountPutWithHttpInfo (CustomerAccount body = null);

        /// <summary>
        /// Update customer account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The account to be updated</param>
        /// <returns>Task of CustomerAccount</returns>
        System.Threading.Tasks.Task<CustomerAccount> BillingAccountPutAsync (CustomerAccount body = null);

        /// <summary>
        /// Update customer account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The account to be updated</param>
        /// <returns>Task of ApiResponse (CustomerAccount)</returns>
        System.Threading.Tasks.Task<ApiResponse<CustomerAccount>> BillingAccountPutAsyncWithHttpInfo (CustomerAccount body = null);
        
        /// <summary>
        /// Create billing account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The account to be created</param>
        /// <returns>Account</returns>
        Account BillingAccountsPost (Account body = null);
  
        /// <summary>
        /// Create billing account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The account to be created</param>
        /// <returns>ApiResponse of Account</returns>
        ApiResponse<Account> BillingAccountsPostWithHttpInfo (Account body = null);

        /// <summary>
        /// Create billing account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The account to be created</param>
        /// <returns>Task of Account</returns>
        System.Threading.Tasks.Task<Account> BillingAccountsPostAsync (Account body = null);

        /// <summary>
        /// Create billing account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The account to be created</param>
        /// <returns>Task of ApiResponse (Account)</returns>
        System.Threading.Tasks.Task<ApiResponse<Account>> BillingAccountsPostAsyncWithHttpInfo (Account body = null);
        
        /// <summary>
        /// Get billing account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the account to be retrieved</param>
        /// <param name="fields">Fields needed</param>
        /// <returns>Account</returns>
        Account BillingAccountsAccountidGet (string accountId, string fields = null);
  
        /// <summary>
        /// Get billing account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the account to be retrieved</param>
        /// <param name="fields">Fields needed</param>
        /// <returns>ApiResponse of Account</returns>
        ApiResponse<Account> BillingAccountsAccountidGetWithHttpInfo (string accountId, string fields = null);

        /// <summary>
        /// Get billing account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the account to be retrieved</param>
        /// <param name="fields">Fields needed</param>
        /// <returns>Task of Account</returns>
        System.Threading.Tasks.Task<Account> BillingAccountsAccountidGetAsync (string accountId, string fields = null);

        /// <summary>
        /// Get billing account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the account to be retrieved</param>
        /// <param name="fields">Fields needed</param>
        /// <returns>Task of ApiResponse (Account)</returns>
        System.Threading.Tasks.Task<ApiResponse<Account>> BillingAccountsAccountidGetAsyncWithHttpInfo (string accountId, string fields = null);
        
        /// <summary>
        /// Updates the billing account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the account to be updated</param>
        /// <param name="body">The account to be updated</param>
        /// <returns>Account</returns>
        Account BillingAccountsAccountidPut (string accountId, Account body = null);
  
        /// <summary>
        /// Updates the billing account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the account to be updated</param>
        /// <param name="body">The account to be updated</param>
        /// <returns>ApiResponse of Account</returns>
        ApiResponse<Account> BillingAccountsAccountidPutWithHttpInfo (string accountId, Account body = null);

        /// <summary>
        /// Updates the billing account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the account to be updated</param>
        /// <param name="body">The account to be updated</param>
        /// <returns>Task of Account</returns>
        System.Threading.Tasks.Task<Account> BillingAccountsAccountidPutAsync (string accountId, Account body = null);

        /// <summary>
        /// Updates the billing account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the account to be updated</param>
        /// <param name="body">The account to be updated</param>
        /// <returns>Task of ApiResponse (Account)</returns>
        System.Threading.Tasks.Task<ApiResponse<Account>> BillingAccountsAccountidPutAsyncWithHttpInfo (string accountId, Account body = null);
        
        /// <summary>
        /// Terminates the billing account of the org.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the account to be terminated</param>
        /// <returns></returns>
        void BillingAccountsAccountidDelete (string accountId);
  
        /// <summary>
        /// Terminates the billing account of the org.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the account to be terminated</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> BillingAccountsAccountidDeleteWithHttpInfo (string accountId);

        /// <summary>
        /// Terminates the billing account of the org.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the account to be terminated</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task BillingAccountsAccountidDeleteAsync (string accountId);

        /// <summary>
        /// Terminates the billing account of the org.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the account to be terminated</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> BillingAccountsAccountidDeleteAsyncWithHttpInfo (string accountId);
        
        /// <summary>
        /// Get billing account overview.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the account whose status should be retrieved</param>
        /// <returns>AccountOverview</returns>
        AccountOverview BillingAccountsAccountidOverviewGet (string accountId);
  
        /// <summary>
        /// Get billing account overview.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the account whose status should be retrieved</param>
        /// <returns>ApiResponse of AccountOverview</returns>
        ApiResponse<AccountOverview> BillingAccountsAccountidOverviewGetWithHttpInfo (string accountId);

        /// <summary>
        /// Get billing account overview.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the account whose status should be retrieved</param>
        /// <returns>Task of AccountOverview</returns>
        System.Threading.Tasks.Task<AccountOverview> BillingAccountsAccountidOverviewGetAsync (string accountId);

        /// <summary>
        /// Get billing account overview.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the account whose status should be retrieved</param>
        /// <returns>Task of ApiResponse (AccountOverview)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountOverview>> BillingAccountsAccountidOverviewGetAsyncWithHttpInfo (string accountId);
        
        /// <summary>
        /// Get billing account status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the account whose status should be retrieved</param>
        /// <returns>AccountStatus</returns>
        AccountStatus BillingAccountsAccountidStatusGet (string accountId);
  
        /// <summary>
        /// Get billing account status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the account whose status should be retrieved</param>
        /// <returns>ApiResponse of AccountStatus</returns>
        ApiResponse<AccountStatus> BillingAccountsAccountidStatusGetWithHttpInfo (string accountId);

        /// <summary>
        /// Get billing account status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the account whose status should be retrieved</param>
        /// <returns>Task of AccountStatus</returns>
        System.Threading.Tasks.Task<AccountStatus> BillingAccountsAccountidStatusGetAsync (string accountId);

        /// <summary>
        /// Get billing account status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the account whose status should be retrieved</param>
        /// <returns>Task of ApiResponse (AccountStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountStatus>> BillingAccountsAccountidStatusGetAsyncWithHttpInfo (string accountId);
        
        /// <summary>
        /// Updates the billing account status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the account whose status should be updated</param>
        /// <param name="body">The account status to be updated</param>
        /// <returns>Account</returns>
        Account BillingAccountsAccountidStatusPut (string accountId, AccountStatus body = null);
  
        /// <summary>
        /// Updates the billing account status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the account whose status should be updated</param>
        /// <param name="body">The account status to be updated</param>
        /// <returns>ApiResponse of Account</returns>
        ApiResponse<Account> BillingAccountsAccountidStatusPutWithHttpInfo (string accountId, AccountStatus body = null);

        /// <summary>
        /// Updates the billing account status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the account whose status should be updated</param>
        /// <param name="body">The account status to be updated</param>
        /// <returns>Task of Account</returns>
        System.Threading.Tasks.Task<Account> BillingAccountsAccountidStatusPutAsync (string accountId, AccountStatus body = null);

        /// <summary>
        /// Updates the billing account status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the account whose status should be updated</param>
        /// <param name="body">The account status to be updated</param>
        /// <returns>Task of ApiResponse (Account)</returns>
        System.Threading.Tasks.Task<ApiResponse<Account>> BillingAccountsAccountidStatusPutAsyncWithHttpInfo (string accountId, AccountStatus body = null);
        
        /// <summary>
        /// Get available additional services.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>AvailableAdditionalServiceListing</returns>
        AvailableAdditionalServiceListing BillingAdditionalservicesGet ();
  
        /// <summary>
        /// Get available additional services.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of AvailableAdditionalServiceListing</returns>
        ApiResponse<AvailableAdditionalServiceListing> BillingAdditionalservicesGetWithHttpInfo ();

        /// <summary>
        /// Get available additional services.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of AvailableAdditionalServiceListing</returns>
        System.Threading.Tasks.Task<AvailableAdditionalServiceListing> BillingAdditionalservicesGetAsync ();

        /// <summary>
        /// Get available additional services.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (AvailableAdditionalServiceListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<AvailableAdditionalServiceListing>> BillingAdditionalservicesGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get billing addresses.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>AddressListing</returns>
        AddressListing BillingAddressesGet ();
  
        /// <summary>
        /// Get billing addresses.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of AddressListing</returns>
        ApiResponse<AddressListing> BillingAddressesGetWithHttpInfo ();

        /// <summary>
        /// Get billing addresses.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of AddressListing</returns>
        System.Threading.Tasks.Task<AddressListing> BillingAddressesGetAsync ();

        /// <summary>
        /// Get billing addresses.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (AddressListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddressListing>> BillingAddressesGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Create billing address.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The address to be created</param>
        /// <returns>Address</returns>
        Address BillingAddressesPost (Address body = null);
  
        /// <summary>
        /// Create billing address.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The address to be created</param>
        /// <returns>ApiResponse of Address</returns>
        ApiResponse<Address> BillingAddressesPostWithHttpInfo (Address body = null);

        /// <summary>
        /// Create billing address.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The address to be created</param>
        /// <returns>Task of Address</returns>
        System.Threading.Tasks.Task<Address> BillingAddressesPostAsync (Address body = null);

        /// <summary>
        /// Create billing address.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The address to be created</param>
        /// <returns>Task of ApiResponse (Address)</returns>
        System.Threading.Tasks.Task<ApiResponse<Address>> BillingAddressesPostAsyncWithHttpInfo (Address body = null);
        
        /// <summary>
        /// Get a billing address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="addressId">The ID of the address</param>
        /// <returns>Address</returns>
        Address BillingAddressesAddressidGet (string addressId);
  
        /// <summary>
        /// Get a billing address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="addressId">The ID of the address</param>
        /// <returns>ApiResponse of Address</returns>
        ApiResponse<Address> BillingAddressesAddressidGetWithHttpInfo (string addressId);

        /// <summary>
        /// Get a billing address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="addressId">The ID of the address</param>
        /// <returns>Task of Address</returns>
        System.Threading.Tasks.Task<Address> BillingAddressesAddressidGetAsync (string addressId);

        /// <summary>
        /// Get a billing address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="addressId">The ID of the address</param>
        /// <returns>Task of ApiResponse (Address)</returns>
        System.Threading.Tasks.Task<ApiResponse<Address>> BillingAddressesAddressidGetAsyncWithHttpInfo (string addressId);
        
        /// <summary>
        /// Update billing address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="addressId">The ID of the address</param>
        /// <param name="body">The address to be updated</param>
        /// <returns>Address</returns>
        Address BillingAddressesAddressidPut (string addressId, Address body = null);
  
        /// <summary>
        /// Update billing address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="addressId">The ID of the address</param>
        /// <param name="body">The address to be updated</param>
        /// <returns>ApiResponse of Address</returns>
        ApiResponse<Address> BillingAddressesAddressidPutWithHttpInfo (string addressId, Address body = null);

        /// <summary>
        /// Update billing address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="addressId">The ID of the address</param>
        /// <param name="body">The address to be updated</param>
        /// <returns>Task of Address</returns>
        System.Threading.Tasks.Task<Address> BillingAddressesAddressidPutAsync (string addressId, Address body = null);

        /// <summary>
        /// Update billing address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="addressId">The ID of the address</param>
        /// <param name="body">The address to be updated</param>
        /// <returns>Task of ApiResponse (Address)</returns>
        System.Threading.Tasks.Task<ApiResponse<Address>> BillingAddressesAddressidPutAsyncWithHttpInfo (string addressId, Address body = null);
        
        /// <summary>
        /// Delete billing address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="addressId">The ID of the address</param>
        /// <returns></returns>
        void BillingAddressesAddressidDelete (string addressId);
  
        /// <summary>
        /// Delete billing address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="addressId">The ID of the address</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> BillingAddressesAddressidDeleteWithHttpInfo (string addressId);

        /// <summary>
        /// Delete billing address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="addressId">The ID of the address</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task BillingAddressesAddressidDeleteAsync (string addressId);

        /// <summary>
        /// Delete billing address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="addressId">The ID of the address</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> BillingAddressesAddressidDeleteAsyncWithHttpInfo (string addressId);
        
        /// <summary>
        /// Get basic products.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>List&lt;string&gt;</returns>
        List<string> BillingBasicproductsGet ();
  
        /// <summary>
        /// Get basic products.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> BillingBasicproductsGetWithHttpInfo ();

        /// <summary>
        /// Get basic products.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> BillingBasicproductsGetAsync ();

        /// <summary>
        /// Get basic products.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> BillingBasicproductsGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get carrier services usage data.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="from">startDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="to">endDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="limit">Limit the number of results</param>
        /// <returns>UrlResponse</returns>
        UrlResponse BillingCarrierservicesUsageCallsGet (DateTime? from = null, DateTime? to = null, int? limit = null);
  
        /// <summary>
        /// Get carrier services usage data.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="from">startDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="to">endDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="limit">Limit the number of results</param>
        /// <returns>ApiResponse of UrlResponse</returns>
        ApiResponse<UrlResponse> BillingCarrierservicesUsageCallsGetWithHttpInfo (DateTime? from = null, DateTime? to = null, int? limit = null);

        /// <summary>
        /// Get carrier services usage data.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="from">startDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="to">endDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="limit">Limit the number of results</param>
        /// <returns>Task of UrlResponse</returns>
        System.Threading.Tasks.Task<UrlResponse> BillingCarrierservicesUsageCallsGetAsync (DateTime? from = null, DateTime? to = null, int? limit = null);

        /// <summary>
        /// Get carrier services usage data.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="from">startDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="to">endDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="limit">Limit the number of results</param>
        /// <returns>Task of ApiResponse (UrlResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UrlResponse>> BillingCarrierservicesUsageCallsGetAsyncWithHttpInfo (DateTime? from = null, DateTime? to = null, int? limit = null);
        
        /// <summary>
        /// Get carrier services usage data CSV.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="from">startDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="to">endDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="limit">Limit the number of results</param>
        /// <returns>UrlResponse</returns>
        UrlResponse BillingCarrierservicesUsageCallsCsvGet (DateTime? from = null, DateTime? to = null, int? limit = null);
  
        /// <summary>
        /// Get carrier services usage data CSV.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="from">startDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="to">endDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="limit">Limit the number of results</param>
        /// <returns>ApiResponse of UrlResponse</returns>
        ApiResponse<UrlResponse> BillingCarrierservicesUsageCallsCsvGetWithHttpInfo (DateTime? from = null, DateTime? to = null, int? limit = null);

        /// <summary>
        /// Get carrier services usage data CSV.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="from">startDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="to">endDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="limit">Limit the number of results</param>
        /// <returns>Task of UrlResponse</returns>
        System.Threading.Tasks.Task<UrlResponse> BillingCarrierservicesUsageCallsCsvGetAsync (DateTime? from = null, DateTime? to = null, int? limit = null);

        /// <summary>
        /// Get carrier services usage data CSV.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="from">startDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="to">endDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="limit">Limit the number of results</param>
        /// <returns>Task of ApiResponse (UrlResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UrlResponse>> BillingCarrierservicesUsageCallsCsvGetAsyncWithHttpInfo (DateTime? from = null, DateTime? to = null, int? limit = null);
        
        /// <summary>
        /// Contact Sales.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The contact sales details</param>
        /// <returns>ContactSalesResponse</returns>
        ContactSalesResponse BillingContactsalesPost (ContactSales body = null);
  
        /// <summary>
        /// Contact Sales.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The contact sales details</param>
        /// <returns>ApiResponse of ContactSalesResponse</returns>
        ApiResponse<ContactSalesResponse> BillingContactsalesPostWithHttpInfo (ContactSales body = null);

        /// <summary>
        /// Contact Sales.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The contact sales details</param>
        /// <returns>Task of ContactSalesResponse</returns>
        System.Threading.Tasks.Task<ContactSalesResponse> BillingContactsalesPostAsync (ContactSales body = null);

        /// <summary>
        /// Contact Sales.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The contact sales details</param>
        /// <returns>Task of ApiResponse (ContactSalesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactSalesResponse>> BillingContactsalesPostAsyncWithHttpInfo (ContactSales body = null);
        
        /// <summary>
        /// Create contract and signer view URL.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The contract to be created</param>
        /// <returns>Contract</returns>
        Contract BillingContractsPost (Contract body = null);
  
        /// <summary>
        /// Create contract and signer view URL.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The contract to be created</param>
        /// <returns>ApiResponse of Contract</returns>
        ApiResponse<Contract> BillingContractsPostWithHttpInfo (Contract body = null);

        /// <summary>
        /// Create contract and signer view URL.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The contract to be created</param>
        /// <returns>Task of Contract</returns>
        System.Threading.Tasks.Task<Contract> BillingContractsPostAsync (Contract body = null);

        /// <summary>
        /// Create contract and signer view URL.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The contract to be created</param>
        /// <returns>Task of ApiResponse (Contract)</returns>
        System.Threading.Tasks.Task<ApiResponse<Contract>> BillingContractsPostAsyncWithHttpInfo (Contract body = null);
        
        /// <summary>
        /// Gets a job that was started to generate a contract for a quote
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="jobId">The ID of the job</param>
        /// <returns>ContractJob</returns>
        ContractJob BillingContractsJobsJobidGet (string jobId);
  
        /// <summary>
        /// Gets a job that was started to generate a contract for a quote
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="jobId">The ID of the job</param>
        /// <returns>ApiResponse of ContractJob</returns>
        ApiResponse<ContractJob> BillingContractsJobsJobidGetWithHttpInfo (string jobId);

        /// <summary>
        /// Gets a job that was started to generate a contract for a quote
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="jobId">The ID of the job</param>
        /// <returns>Task of ContractJob</returns>
        System.Threading.Tasks.Task<ContractJob> BillingContractsJobsJobidGetAsync (string jobId);

        /// <summary>
        /// Gets a job that was started to generate a contract for a quote
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="jobId">The ID of the job</param>
        /// <returns>Task of ApiResponse (ContractJob)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContractJob>> BillingContractsJobsJobidGetAsyncWithHttpInfo (string jobId);
        
        /// <summary>
        /// Get a contract that was generated for a quote
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contractId">The ID of the contract</param>
        /// <returns>Contract</returns>
        Contract BillingContractsContractidGet (string contractId);
  
        /// <summary>
        /// Get a contract that was generated for a quote
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contractId">The ID of the contract</param>
        /// <returns>ApiResponse of Contract</returns>
        ApiResponse<Contract> BillingContractsContractidGetWithHttpInfo (string contractId);

        /// <summary>
        /// Get a contract that was generated for a quote
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contractId">The ID of the contract</param>
        /// <returns>Task of Contract</returns>
        System.Threading.Tasks.Task<Contract> BillingContractsContractidGetAsync (string contractId);

        /// <summary>
        /// Get a contract that was generated for a quote
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contractId">The ID of the contract</param>
        /// <returns>Task of ApiResponse (Contract)</returns>
        System.Threading.Tasks.Task<ApiResponse<Contract>> BillingContractsContractidGetAsyncWithHttpInfo (string contractId);
        
        /// <summary>
        /// Get available currencies.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>List&lt;string&gt;</returns>
        List<string> BillingCurrenciesGet ();
  
        /// <summary>
        /// Get available currencies.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> BillingCurrenciesGetWithHttpInfo ();

        /// <summary>
        /// Get available currencies.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> BillingCurrenciesGetAsync ();

        /// <summary>
        /// Get available currencies.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> BillingCurrenciesGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get rates for available hardware.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="productSubCategory">Filter rates by product subcategory. Examples are &#39;Phones&#39; or &#39;PowerCords&#39;.</param>
        /// <returns>HardwareRateListing</returns>
        HardwareRateListing BillingHardwareratesGet (string productSubCategory);
  
        /// <summary>
        /// Get rates for available hardware.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="productSubCategory">Filter rates by product subcategory. Examples are &#39;Phones&#39; or &#39;PowerCords&#39;.</param>
        /// <returns>ApiResponse of HardwareRateListing</returns>
        ApiResponse<HardwareRateListing> BillingHardwareratesGetWithHttpInfo (string productSubCategory);

        /// <summary>
        /// Get rates for available hardware.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="productSubCategory">Filter rates by product subcategory. Examples are &#39;Phones&#39; or &#39;PowerCords&#39;.</param>
        /// <returns>Task of HardwareRateListing</returns>
        System.Threading.Tasks.Task<HardwareRateListing> BillingHardwareratesGetAsync (string productSubCategory);

        /// <summary>
        /// Get rates for available hardware.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="productSubCategory">Filter rates by product subcategory. Examples are &#39;Phones&#39; or &#39;PowerCords&#39;.</param>
        /// <returns>Task of ApiResponse (HardwareRateListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<HardwareRateListing>> BillingHardwareratesGetAsyncWithHttpInfo (string productSubCategory);
        
        /// <summary>
        /// Get historical extended billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of historical extended billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="groupName">Filter voice rates by group.</param>
        /// <param name="areaCode">Filter voice rates by areaCode.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>DomainVoiceRateResponseItemEntityListing</returns>
        DomainVoiceRateResponseItemEntityListing BillingHistoricalvoiceratesExtendedGet (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string groupName = null, string areaCode = null, int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get historical extended billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of historical extended billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="groupName">Filter voice rates by group.</param>
        /// <param name="areaCode">Filter voice rates by areaCode.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of DomainVoiceRateResponseItemEntityListing</returns>
        ApiResponse<DomainVoiceRateResponseItemEntityListing> BillingHistoricalvoiceratesExtendedGetWithHttpInfo (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string groupName = null, string areaCode = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get historical extended billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of historical extended billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="groupName">Filter voice rates by group.</param>
        /// <param name="areaCode">Filter voice rates by areaCode.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainVoiceRateResponseItemEntityListing</returns>
        System.Threading.Tasks.Task<DomainVoiceRateResponseItemEntityListing> BillingHistoricalvoiceratesExtendedGetAsync (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string groupName = null, string areaCode = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get historical extended billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of historical extended billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="groupName">Filter voice rates by group.</param>
        /// <param name="areaCode">Filter voice rates by areaCode.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainVoiceRateResponseItemEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainVoiceRateResponseItemEntityListing>> BillingHistoricalvoiceratesExtendedGetAsyncWithHttpInfo (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string groupName = null, string areaCode = null, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get historical inbound billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of historical inbound billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>DomainVoiceRateResponseItemEntityListing</returns>
        DomainVoiceRateResponseItemEntityListing BillingHistoricalvoiceratesInboundGet (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string type = null, int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get historical inbound billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of historical inbound billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of DomainVoiceRateResponseItemEntityListing</returns>
        ApiResponse<DomainVoiceRateResponseItemEntityListing> BillingHistoricalvoiceratesInboundGetWithHttpInfo (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string type = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get historical inbound billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of historical inbound billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainVoiceRateResponseItemEntityListing</returns>
        System.Threading.Tasks.Task<DomainVoiceRateResponseItemEntityListing> BillingHistoricalvoiceratesInboundGetAsync (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string type = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get historical inbound billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of historical inbound billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainVoiceRateResponseItemEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainVoiceRateResponseItemEntityListing>> BillingHistoricalvoiceratesInboundGetAsyncWithHttpInfo (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string type = null, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get historical outbound domestic billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of historical outbound domestic billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>DomainVoiceRateResponseItemEntityListing</returns>
        DomainVoiceRateResponseItemEntityListing BillingHistoricalvoiceratesOutboundDomesticGet (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string type = null, int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get historical outbound domestic billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of historical outbound domestic billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of DomainVoiceRateResponseItemEntityListing</returns>
        ApiResponse<DomainVoiceRateResponseItemEntityListing> BillingHistoricalvoiceratesOutboundDomesticGetWithHttpInfo (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string type = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get historical outbound domestic billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of historical outbound domestic billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainVoiceRateResponseItemEntityListing</returns>
        System.Threading.Tasks.Task<DomainVoiceRateResponseItemEntityListing> BillingHistoricalvoiceratesOutboundDomesticGetAsync (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string type = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get historical outbound domestic billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of historical outbound domestic billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainVoiceRateResponseItemEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainVoiceRateResponseItemEntityListing>> BillingHistoricalvoiceratesOutboundDomesticGetAsyncWithHttpInfo (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string type = null, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get historical outbound international billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of historical outbound international billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="origin">Filter voice rates by origin.</param>
        /// <param name="destination">Filter voice rates by destination.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>DomainVoiceRateResponseItemEntityListing</returns>
        DomainVoiceRateResponseItemEntityListing BillingHistoricalvoiceratesOutboundInternationalGet (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string origin = null, string destination = null, int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get historical outbound international billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of historical outbound international billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="origin">Filter voice rates by origin.</param>
        /// <param name="destination">Filter voice rates by destination.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of DomainVoiceRateResponseItemEntityListing</returns>
        ApiResponse<DomainVoiceRateResponseItemEntityListing> BillingHistoricalvoiceratesOutboundInternationalGetWithHttpInfo (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string origin = null, string destination = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get historical outbound international billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of historical outbound international billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="origin">Filter voice rates by origin.</param>
        /// <param name="destination">Filter voice rates by destination.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainVoiceRateResponseItemEntityListing</returns>
        System.Threading.Tasks.Task<DomainVoiceRateResponseItemEntityListing> BillingHistoricalvoiceratesOutboundInternationalGetAsync (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string origin = null, string destination = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get historical outbound international billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of historical outbound international billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="origin">Filter voice rates by origin.</param>
        /// <param name="destination">Filter voice rates by destination.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainVoiceRateResponseItemEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainVoiceRateResponseItemEntityListing>> BillingHistoricalvoiceratesOutboundInternationalGetAsyncWithHttpInfo (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string origin = null, string destination = null, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get invoices
        /// </summary>
        /// <remarks>
        /// Retrieve a list of invoices stored in the system.
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>DomainInvoiceEntityListing</returns>
        DomainInvoiceEntityListing BillingInvoicesGet (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get invoices
        /// </summary>
        /// <remarks>
        /// Retrieve a list of invoices stored in the system.
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of DomainInvoiceEntityListing</returns>
        ApiResponse<DomainInvoiceEntityListing> BillingInvoicesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get invoices
        /// </summary>
        /// <remarks>
        /// Retrieve a list of invoices stored in the system.
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainInvoiceEntityListing</returns>
        System.Threading.Tasks.Task<DomainInvoiceEntityListing> BillingInvoicesGetAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get invoices
        /// </summary>
        /// <remarks>
        /// Retrieve a list of invoices stored in the system.
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainInvoiceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainInvoiceEntityListing>> BillingInvoicesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get invoice.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="invoiceId">Identifies the invoice to be retrieved</param>
        /// <returns>Invoice</returns>
        Invoice BillingInvoicesInvoiceidGet (string invoiceId);
  
        /// <summary>
        /// Get invoice.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="invoiceId">Identifies the invoice to be retrieved</param>
        /// <returns>ApiResponse of Invoice</returns>
        ApiResponse<Invoice> BillingInvoicesInvoiceidGetWithHttpInfo (string invoiceId);

        /// <summary>
        /// Get invoice.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="invoiceId">Identifies the invoice to be retrieved</param>
        /// <returns>Task of Invoice</returns>
        System.Threading.Tasks.Task<Invoice> BillingInvoicesInvoiceidGetAsync (string invoiceId);

        /// <summary>
        /// Get invoice.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="invoiceId">Identifies the invoice to be retrieved</param>
        /// <returns>Task of ApiResponse (Invoice)</returns>
        System.Threading.Tasks.Task<ApiResponse<Invoice>> BillingInvoicesInvoiceidGetAsyncWithHttpInfo (string invoiceId);
        
        /// <summary>
        /// Get invoice PDF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="invoiceId">Identifies the invoice PDF to be retrieved</param>
        /// <returns>UrlResponse</returns>
        UrlResponse BillingInvoicesInvoiceidPdfGet (string invoiceId);
  
        /// <summary>
        /// Get invoice PDF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="invoiceId">Identifies the invoice PDF to be retrieved</param>
        /// <returns>ApiResponse of UrlResponse</returns>
        ApiResponse<UrlResponse> BillingInvoicesInvoiceidPdfGetWithHttpInfo (string invoiceId);

        /// <summary>
        /// Get invoice PDF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="invoiceId">Identifies the invoice PDF to be retrieved</param>
        /// <returns>Task of UrlResponse</returns>
        System.Threading.Tasks.Task<UrlResponse> BillingInvoicesInvoiceidPdfGetAsync (string invoiceId);

        /// <summary>
        /// Get invoice PDF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="invoiceId">Identifies the invoice PDF to be retrieved</param>
        /// <returns>Task of ApiResponse (UrlResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UrlResponse>> BillingInvoicesInvoiceidPdfGetAsyncWithHttpInfo (string invoiceId);
        
        /// <summary>
        /// Create billing order.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The order to be created</param>
        /// <returns>Order</returns>
        Order BillingOrdersPost (Order body = null);
  
        /// <summary>
        /// Create billing order.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The order to be created</param>
        /// <returns>ApiResponse of Order</returns>
        ApiResponse<Order> BillingOrdersPostWithHttpInfo (Order body = null);

        /// <summary>
        /// Create billing order.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The order to be created</param>
        /// <returns>Task of Order</returns>
        System.Threading.Tasks.Task<Order> BillingOrdersPostAsync (Order body = null);

        /// <summary>
        /// Create billing order.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The order to be created</param>
        /// <returns>Task of ApiResponse (Order)</returns>
        System.Threading.Tasks.Task<ApiResponse<Order>> BillingOrdersPostAsyncWithHttpInfo (Order body = null);
        
        /// <summary>
        /// Get billing periods
        /// </summary>
        /// <remarks>
        /// Retrieve a list of billing periods stored in the system.
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>DomainBillingPeriodEntityListing</returns>
        DomainBillingPeriodEntityListing BillingPeriodsGet (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get billing periods
        /// </summary>
        /// <remarks>
        /// Retrieve a list of billing periods stored in the system.
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of DomainBillingPeriodEntityListing</returns>
        ApiResponse<DomainBillingPeriodEntityListing> BillingPeriodsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get billing periods
        /// </summary>
        /// <remarks>
        /// Retrieve a list of billing periods stored in the system.
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainBillingPeriodEntityListing</returns>
        System.Threading.Tasks.Task<DomainBillingPeriodEntityListing> BillingPeriodsGetAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get billing periods
        /// </summary>
        /// <remarks>
        /// Retrieve a list of billing periods stored in the system.
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainBillingPeriodEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainBillingPeriodEntityListing>> BillingPeriodsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get products.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Product</returns>
        Product BillingProductsGet ();
  
        /// <summary>
        /// Get products.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of Product</returns>
        ApiResponse<Product> BillingProductsGetWithHttpInfo ();

        /// <summary>
        /// Get products.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of Product</returns>
        System.Threading.Tasks.Task<Product> BillingProductsGetAsync ();

        /// <summary>
        /// Get products.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (Product)</returns>
        System.Threading.Tasks.Task<ApiResponse<Product>> BillingProductsGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Update products.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The products to activate</param>
        /// <returns>Product</returns>
        Product BillingProductsPut (List<Product> body = null);
  
        /// <summary>
        /// Update products.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The products to activate</param>
        /// <returns>ApiResponse of Product</returns>
        ApiResponse<Product> BillingProductsPutWithHttpInfo (List<Product> body = null);

        /// <summary>
        /// Update products.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The products to activate</param>
        /// <returns>Task of Product</returns>
        System.Threading.Tasks.Task<Product> BillingProductsPutAsync (List<Product> body = null);

        /// <summary>
        /// Update products.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The products to activate</param>
        /// <returns>Task of ApiResponse (Product)</returns>
        System.Threading.Tasks.Task<ApiResponse<Product>> BillingProductsPutAsyncWithHttpInfo (List<Product> body = null);
        
        /// <summary>
        /// Get billing quotes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>QuoteListing</returns>
        QuoteListing BillingQuotesGet ();
  
        /// <summary>
        /// Get billing quotes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of QuoteListing</returns>
        ApiResponse<QuoteListing> BillingQuotesGetWithHttpInfo ();

        /// <summary>
        /// Get billing quotes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of QuoteListing</returns>
        System.Threading.Tasks.Task<QuoteListing> BillingQuotesGetAsync ();

        /// <summary>
        /// Get billing quotes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (QuoteListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<QuoteListing>> BillingQuotesGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Create billing quote.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The quote to be created</param>
        /// <returns>Quote</returns>
        Quote BillingQuotesPost (Quote body = null);
  
        /// <summary>
        /// Create billing quote.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The quote to be created</param>
        /// <returns>ApiResponse of Quote</returns>
        ApiResponse<Quote> BillingQuotesPostWithHttpInfo (Quote body = null);

        /// <summary>
        /// Create billing quote.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The quote to be created</param>
        /// <returns>Task of Quote</returns>
        System.Threading.Tasks.Task<Quote> BillingQuotesPostAsync (Quote body = null);

        /// <summary>
        /// Create billing quote.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">The quote to be created</param>
        /// <returns>Task of ApiResponse (Quote)</returns>
        System.Threading.Tasks.Task<ApiResponse<Quote>> BillingQuotesPostAsyncWithHttpInfo (Quote body = null);
        
        /// <summary>
        /// Get a billing quote
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="quoteId">The ID of the quote</param>
        /// <returns>Quote</returns>
        Quote BillingQuotesQuoteidGet (string quoteId);
  
        /// <summary>
        /// Get a billing quote
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="quoteId">The ID of the quote</param>
        /// <returns>ApiResponse of Quote</returns>
        ApiResponse<Quote> BillingQuotesQuoteidGetWithHttpInfo (string quoteId);

        /// <summary>
        /// Get a billing quote
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="quoteId">The ID of the quote</param>
        /// <returns>Task of Quote</returns>
        System.Threading.Tasks.Task<Quote> BillingQuotesQuoteidGetAsync (string quoteId);

        /// <summary>
        /// Get a billing quote
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="quoteId">The ID of the quote</param>
        /// <returns>Task of ApiResponse (Quote)</returns>
        System.Threading.Tasks.Task<ApiResponse<Quote>> BillingQuotesQuoteidGetAsyncWithHttpInfo (string quoteId);
        
        /// <summary>
        /// Update billing quote
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="quoteId">The ID of the quote</param>
        /// <param name="body">The quote to be updated</param>
        /// <returns>Quote</returns>
        Quote BillingQuotesQuoteidPut (string quoteId, Quote body = null);
  
        /// <summary>
        /// Update billing quote
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="quoteId">The ID of the quote</param>
        /// <param name="body">The quote to be updated</param>
        /// <returns>ApiResponse of Quote</returns>
        ApiResponse<Quote> BillingQuotesQuoteidPutWithHttpInfo (string quoteId, Quote body = null);

        /// <summary>
        /// Update billing quote
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="quoteId">The ID of the quote</param>
        /// <param name="body">The quote to be updated</param>
        /// <returns>Task of Quote</returns>
        System.Threading.Tasks.Task<Quote> BillingQuotesQuoteidPutAsync (string quoteId, Quote body = null);

        /// <summary>
        /// Update billing quote
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="quoteId">The ID of the quote</param>
        /// <param name="body">The quote to be updated</param>
        /// <returns>Task of ApiResponse (Quote)</returns>
        System.Threading.Tasks.Task<ApiResponse<Quote>> BillingQuotesQuoteidPutAsyncWithHttpInfo (string quoteId, Quote body = null);
        
        /// <summary>
        /// Delete billing quote
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="quoteId">The ID of the quote</param>
        /// <returns></returns>
        void BillingQuotesQuoteidDelete (string quoteId);
  
        /// <summary>
        /// Delete billing quote
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="quoteId">The ID of the quote</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> BillingQuotesQuoteidDeleteWithHttpInfo (string quoteId);

        /// <summary>
        /// Delete billing quote
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="quoteId">The ID of the quote</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task BillingQuotesQuoteidDeleteAsync (string quoteId);

        /// <summary>
        /// Delete billing quote
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="quoteId">The ID of the quote</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> BillingQuotesQuoteidDeleteAsyncWithHttpInfo (string quoteId);
        
        /// <summary>
        /// Get billing rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of billing rates stored in the system.
        /// </remarks>
        /// <param name="chargeType">Filter rates by charge type. Examples are Usage, Recurring, or OneTime.</param>
        /// <returns>List&lt;Rate&gt;</returns>
        List<Rate> BillingRatesGet (string chargeType = null);
  
        /// <summary>
        /// Get billing rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of billing rates stored in the system.
        /// </remarks>
        /// <param name="chargeType">Filter rates by charge type. Examples are Usage, Recurring, or OneTime.</param>
        /// <returns>ApiResponse of List&lt;Rate&gt;</returns>
        ApiResponse<List<Rate>> BillingRatesGetWithHttpInfo (string chargeType = null);

        /// <summary>
        /// Get billing rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of billing rates stored in the system.
        /// </remarks>
        /// <param name="chargeType">Filter rates by charge type. Examples are Usage, Recurring, or OneTime.</param>
        /// <returns>Task of List&lt;Rate&gt;</returns>
        System.Threading.Tasks.Task<List<Rate>> BillingRatesGetAsync (string chargeType = null);

        /// <summary>
        /// Get billing rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of billing rates stored in the system.
        /// </remarks>
        /// <param name="chargeType">Filter rates by charge type. Examples are Usage, Recurring, or OneTime.</param>
        /// <returns>Task of ApiResponse (List&lt;Rate&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Rate>>> BillingRatesGetAsyncWithHttpInfo (string chargeType = null);
        
        /// <summary>
        /// Get rate.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="rateId">Identifies the rate to be retrieved</param>
        /// <returns>Rate</returns>
        Rate BillingRatesRateidGet (string rateId);
  
        /// <summary>
        /// Get rate.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="rateId">Identifies the rate to be retrieved</param>
        /// <returns>ApiResponse of Rate</returns>
        ApiResponse<Rate> BillingRatesRateidGetWithHttpInfo (string rateId);

        /// <summary>
        /// Get rate.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="rateId">Identifies the rate to be retrieved</param>
        /// <returns>Task of Rate</returns>
        System.Threading.Tasks.Task<Rate> BillingRatesRateidGetAsync (string rateId);

        /// <summary>
        /// Get rate.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="rateId">Identifies the rate to be retrieved</param>
        /// <returns>Task of ApiResponse (Rate)</returns>
        System.Threading.Tasks.Task<ApiResponse<Rate>> BillingRatesRateidGetAsyncWithHttpInfo (string rateId);
        
        /// <summary>
        /// Get billable usage data report CSV.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="reportId">Identifies the report CSV to be retrieved</param>
        /// <returns>UrlResponse</returns>
        UrlResponse BillingReportsBillableusagedataReportidCsvGet (string reportId);
  
        /// <summary>
        /// Get billable usage data report CSV.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="reportId">Identifies the report CSV to be retrieved</param>
        /// <returns>ApiResponse of UrlResponse</returns>
        ApiResponse<UrlResponse> BillingReportsBillableusagedataReportidCsvGetWithHttpInfo (string reportId);

        /// <summary>
        /// Get billable usage data report CSV.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="reportId">Identifies the report CSV to be retrieved</param>
        /// <returns>Task of UrlResponse</returns>
        System.Threading.Tasks.Task<UrlResponse> BillingReportsBillableusagedataReportidCsvGetAsync (string reportId);

        /// <summary>
        /// Get billable usage data report CSV.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="reportId">Identifies the report CSV to be retrieved</param>
        /// <returns>Task of ApiResponse (UrlResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UrlResponse>> BillingReportsBillableusagedataReportidCsvGetAsyncWithHttpInfo (string reportId);
        
        /// <summary>
        /// Get concurrent usage data report CSV.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="reportId">Identifies the report CSV to be retrieved</param>
        /// <returns>UrlResponse</returns>
        UrlResponse BillingReportsConcurrentusagedataReportidCsvGet (string reportId);
  
        /// <summary>
        /// Get concurrent usage data report CSV.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="reportId">Identifies the report CSV to be retrieved</param>
        /// <returns>ApiResponse of UrlResponse</returns>
        ApiResponse<UrlResponse> BillingReportsConcurrentusagedataReportidCsvGetWithHttpInfo (string reportId);

        /// <summary>
        /// Get concurrent usage data report CSV.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="reportId">Identifies the report CSV to be retrieved</param>
        /// <returns>Task of UrlResponse</returns>
        System.Threading.Tasks.Task<UrlResponse> BillingReportsConcurrentusagedataReportidCsvGetAsync (string reportId);

        /// <summary>
        /// Get concurrent usage data report CSV.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="reportId">Identifies the report CSV to be retrieved</param>
        /// <returns>Task of ApiResponse (UrlResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UrlResponse>> BillingReportsConcurrentusagedataReportidCsvGetAsyncWithHttpInfo (string reportId);
        
        /// <summary>
        /// Creates a billing snapshot
        /// </summary>
        /// <remarks>
        /// Creates a billing snapshot which is used to determine usage counts for a billing period.
        /// </remarks>
        /// <returns></returns>
        void BillingSnapshotsPost ();
  
        /// <summary>
        /// Creates a billing snapshot
        /// </summary>
        /// <remarks>
        /// Creates a billing snapshot which is used to determine usage counts for a billing period.
        /// </remarks>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> BillingSnapshotsPostWithHttpInfo ();

        /// <summary>
        /// Creates a billing snapshot
        /// </summary>
        /// <remarks>
        /// Creates a billing snapshot which is used to determine usage counts for a billing period.
        /// </remarks>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task BillingSnapshotsPostAsync ();

        /// <summary>
        /// Creates a billing snapshot
        /// </summary>
        /// <remarks>
        /// Creates a billing snapshot which is used to determine usage counts for a billing period.
        /// </remarks>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> BillingSnapshotsPostAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get third party accounts
        /// </summary>
        /// <remarks>
        /// Retrieve a list of third party accounts stored in the back-end system.
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="search">Search for accounts with this text</param>
        /// <returns>DomainThirdPartyAccountEntityListing</returns>
        DomainThirdPartyAccountEntityListing BillingThirdpartyaccountsGet (int? pageSize = null, int? pageNumber = null, string search = null);
  
        /// <summary>
        /// Get third party accounts
        /// </summary>
        /// <remarks>
        /// Retrieve a list of third party accounts stored in the back-end system.
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="search">Search for accounts with this text</param>
        /// <returns>ApiResponse of DomainThirdPartyAccountEntityListing</returns>
        ApiResponse<DomainThirdPartyAccountEntityListing> BillingThirdpartyaccountsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string search = null);

        /// <summary>
        /// Get third party accounts
        /// </summary>
        /// <remarks>
        /// Retrieve a list of third party accounts stored in the back-end system.
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="search">Search for accounts with this text</param>
        /// <returns>Task of DomainThirdPartyAccountEntityListing</returns>
        System.Threading.Tasks.Task<DomainThirdPartyAccountEntityListing> BillingThirdpartyaccountsGetAsync (int? pageSize = null, int? pageNumber = null, string search = null);

        /// <summary>
        /// Get third party accounts
        /// </summary>
        /// <remarks>
        /// Retrieve a list of third party accounts stored in the back-end system.
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="search">Search for accounts with this text</param>
        /// <returns>Task of ApiResponse (DomainThirdPartyAccountEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainThirdPartyAccountEntityListing>> BillingThirdpartyaccountsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string search = null);
        
        /// <summary>
        /// Get third party billing account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the third party account to be retrieved</param>
        /// <returns>ThirdPartyAccount</returns>
        ThirdPartyAccount BillingThirdpartyaccountsAccountidGet (string accountId);
  
        /// <summary>
        /// Get third party billing account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the third party account to be retrieved</param>
        /// <returns>ApiResponse of ThirdPartyAccount</returns>
        ApiResponse<ThirdPartyAccount> BillingThirdpartyaccountsAccountidGetWithHttpInfo (string accountId);

        /// <summary>
        /// Get third party billing account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the third party account to be retrieved</param>
        /// <returns>Task of ThirdPartyAccount</returns>
        System.Threading.Tasks.Task<ThirdPartyAccount> BillingThirdpartyaccountsAccountidGetAsync (string accountId);

        /// <summary>
        /// Get third party billing account.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the third party account to be retrieved</param>
        /// <returns>Task of ApiResponse (ThirdPartyAccount)</returns>
        System.Threading.Tasks.Task<ApiResponse<ThirdPartyAccount>> BillingThirdpartyaccountsAccountidGetAsyncWithHttpInfo (string accountId);
        
        /// <summary>
        /// Get third party subscriptions
        /// </summary>
        /// <remarks>
        /// Retrieve a list of third party subscriptions stored in the back-end system.
        /// </remarks>
        /// <param name="accountId">Identifies the third party account to be retrieved</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>DomainThirdPartySubscriptionEntityListing</returns>
        DomainThirdPartySubscriptionEntityListing BillingThirdpartyaccountsAccountidSubscriptionsGet (string accountId, int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get third party subscriptions
        /// </summary>
        /// <remarks>
        /// Retrieve a list of third party subscriptions stored in the back-end system.
        /// </remarks>
        /// <param name="accountId">Identifies the third party account to be retrieved</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of DomainThirdPartySubscriptionEntityListing</returns>
        ApiResponse<DomainThirdPartySubscriptionEntityListing> BillingThirdpartyaccountsAccountidSubscriptionsGetWithHttpInfo (string accountId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get third party subscriptions
        /// </summary>
        /// <remarks>
        /// Retrieve a list of third party subscriptions stored in the back-end system.
        /// </remarks>
        /// <param name="accountId">Identifies the third party account to be retrieved</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainThirdPartySubscriptionEntityListing</returns>
        System.Threading.Tasks.Task<DomainThirdPartySubscriptionEntityListing> BillingThirdpartyaccountsAccountidSubscriptionsGetAsync (string accountId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get third party subscriptions
        /// </summary>
        /// <remarks>
        /// Retrieve a list of third party subscriptions stored in the back-end system.
        /// </remarks>
        /// <param name="accountId">Identifies the third party account to be retrieved</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainThirdPartySubscriptionEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainThirdPartySubscriptionEntityListing>> BillingThirdpartyaccountsAccountidSubscriptionsGetAsyncWithHttpInfo (string accountId, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get third party billing subscription.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the third party account to be retrieved</param>
        /// <param name="subscriptionId">Identifies the third party subscription to be retrieved</param>
        /// <returns>ThirdPartySubscription</returns>
        ThirdPartySubscription BillingThirdpartyaccountsAccountidSubscriptionsSubscriptionidGet (string accountId, string subscriptionId);
  
        /// <summary>
        /// Get third party billing subscription.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the third party account to be retrieved</param>
        /// <param name="subscriptionId">Identifies the third party subscription to be retrieved</param>
        /// <returns>ApiResponse of ThirdPartySubscription</returns>
        ApiResponse<ThirdPartySubscription> BillingThirdpartyaccountsAccountidSubscriptionsSubscriptionidGetWithHttpInfo (string accountId, string subscriptionId);

        /// <summary>
        /// Get third party billing subscription.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the third party account to be retrieved</param>
        /// <param name="subscriptionId">Identifies the third party subscription to be retrieved</param>
        /// <returns>Task of ThirdPartySubscription</returns>
        System.Threading.Tasks.Task<ThirdPartySubscription> BillingThirdpartyaccountsAccountidSubscriptionsSubscriptionidGetAsync (string accountId, string subscriptionId);

        /// <summary>
        /// Get third party billing subscription.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="accountId">Identifies the third party account to be retrieved</param>
        /// <param name="subscriptionId">Identifies the third party subscription to be retrieved</param>
        /// <returns>Task of ApiResponse (ThirdPartySubscription)</returns>
        System.Threading.Tasks.Task<ApiResponse<ThirdPartySubscription>> BillingThirdpartyaccountsAccountidSubscriptionsSubscriptionidGetAsyncWithHttpInfo (string accountId, string subscriptionId);
        
        /// <summary>
        /// Update billing voice rate
        /// </summary>
        /// <remarks>
        /// Update a billing voice rate currently stored in the system.
        /// </remarks>
        /// <param name="body">The voice rate to be created</param>
        /// <returns>VoiceRateUpdate</returns>
        VoiceRateUpdate BillingVoiceratePut (VoiceRateUpdate body = null);
  
        /// <summary>
        /// Update billing voice rate
        /// </summary>
        /// <remarks>
        /// Update a billing voice rate currently stored in the system.
        /// </remarks>
        /// <param name="body">The voice rate to be created</param>
        /// <returns>ApiResponse of VoiceRateUpdate</returns>
        ApiResponse<VoiceRateUpdate> BillingVoiceratePutWithHttpInfo (VoiceRateUpdate body = null);

        /// <summary>
        /// Update billing voice rate
        /// </summary>
        /// <remarks>
        /// Update a billing voice rate currently stored in the system.
        /// </remarks>
        /// <param name="body">The voice rate to be created</param>
        /// <returns>Task of VoiceRateUpdate</returns>
        System.Threading.Tasks.Task<VoiceRateUpdate> BillingVoiceratePutAsync (VoiceRateUpdate body = null);

        /// <summary>
        /// Update billing voice rate
        /// </summary>
        /// <remarks>
        /// Update a billing voice rate currently stored in the system.
        /// </remarks>
        /// <param name="body">The voice rate to be created</param>
        /// <returns>Task of ApiResponse (VoiceRateUpdate)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoiceRateUpdate>> BillingVoiceratePutAsyncWithHttpInfo (VoiceRateUpdate body = null);
        
        /// <summary>
        /// Delete billing voice rate
        /// </summary>
        /// <remarks>
        /// Delete a pending billing voice rate currently stored in the system.
        /// </remarks>
        /// <param name="currency">The currency of the voice rate</param>
        /// <param name="amendmentId">The amendment Id of the voice rate</param>
        /// <returns></returns>
        void BillingVoicerateCurrencyAmendmentidDelete (string currency, string amendmentId);
  
        /// <summary>
        /// Delete billing voice rate
        /// </summary>
        /// <remarks>
        /// Delete a pending billing voice rate currently stored in the system.
        /// </remarks>
        /// <param name="currency">The currency of the voice rate</param>
        /// <param name="amendmentId">The amendment Id of the voice rate</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> BillingVoicerateCurrencyAmendmentidDeleteWithHttpInfo (string currency, string amendmentId);

        /// <summary>
        /// Delete billing voice rate
        /// </summary>
        /// <remarks>
        /// Delete a pending billing voice rate currently stored in the system.
        /// </remarks>
        /// <param name="currency">The currency of the voice rate</param>
        /// <param name="amendmentId">The amendment Id of the voice rate</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task BillingVoicerateCurrencyAmendmentidDeleteAsync (string currency, string amendmentId);

        /// <summary>
        /// Delete billing voice rate
        /// </summary>
        /// <remarks>
        /// Delete a pending billing voice rate currently stored in the system.
        /// </remarks>
        /// <param name="currency">The currency of the voice rate</param>
        /// <param name="amendmentId">The amendment Id of the voice rate</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> BillingVoicerateCurrencyAmendmentidDeleteAsyncWithHttpInfo (string currency, string amendmentId);
        
        /// <summary>
        /// Get current extended billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of current extended billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="areaCode">Filter voice rates by area code.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>VoiceRateInternationalEntityListing</returns>
        VoiceRateInternationalEntityListing BillingVoiceratesExtendedGet (string currency, string areaCode = null, int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get current extended billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of current extended billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="areaCode">Filter voice rates by area code.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of VoiceRateInternationalEntityListing</returns>
        ApiResponse<VoiceRateInternationalEntityListing> BillingVoiceratesExtendedGetWithHttpInfo (string currency, string areaCode = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get current extended billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of current extended billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="areaCode">Filter voice rates by area code.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of VoiceRateInternationalEntityListing</returns>
        System.Threading.Tasks.Task<VoiceRateInternationalEntityListing> BillingVoiceratesExtendedGetAsync (string currency, string areaCode = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get current extended billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of current extended billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="areaCode">Filter voice rates by area code.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (VoiceRateInternationalEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoiceRateInternationalEntityListing>> BillingVoiceratesExtendedGetAsyncWithHttpInfo (string currency, string areaCode = null, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get current inbound billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of current inbound billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param>
        /// <returns>List&lt;VoiceRate&gt;</returns>
        List<VoiceRate> BillingVoiceratesInboundGet (string currency, string type = null);
  
        /// <summary>
        /// Get current inbound billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of current inbound billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param>
        /// <returns>ApiResponse of List&lt;VoiceRate&gt;</returns>
        ApiResponse<List<VoiceRate>> BillingVoiceratesInboundGetWithHttpInfo (string currency, string type = null);

        /// <summary>
        /// Get current inbound billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of current inbound billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param>
        /// <returns>Task of List&lt;VoiceRate&gt;</returns>
        System.Threading.Tasks.Task<List<VoiceRate>> BillingVoiceratesInboundGetAsync (string currency, string type = null);

        /// <summary>
        /// Get current inbound billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of current inbound billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param>
        /// <returns>Task of ApiResponse (List&lt;VoiceRate&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<VoiceRate>>> BillingVoiceratesInboundGetAsyncWithHttpInfo (string currency, string type = null);
        
        /// <summary>
        /// Get current outbound domestic billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of current outbound domestic billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param>
        /// <returns>List&lt;VoiceRate&gt;</returns>
        List<VoiceRate> BillingVoiceratesOutboundDomesticGet (string currency, string type = null);
  
        /// <summary>
        /// Get current outbound domestic billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of current outbound domestic billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param>
        /// <returns>ApiResponse of List&lt;VoiceRate&gt;</returns>
        ApiResponse<List<VoiceRate>> BillingVoiceratesOutboundDomesticGetWithHttpInfo (string currency, string type = null);

        /// <summary>
        /// Get current outbound domestic billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of current outbound domestic billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param>
        /// <returns>Task of List&lt;VoiceRate&gt;</returns>
        System.Threading.Tasks.Task<List<VoiceRate>> BillingVoiceratesOutboundDomesticGetAsync (string currency, string type = null);

        /// <summary>
        /// Get current outbound domestic billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of current outbound domestic billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param>
        /// <returns>Task of ApiResponse (List&lt;VoiceRate&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<VoiceRate>>> BillingVoiceratesOutboundDomesticGetAsyncWithHttpInfo (string currency, string type = null);
        
        /// <summary>
        /// Get current outbound international billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of current outbound international billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="origin">Filter voice rates by origin.</param>
        /// <param name="destination">Filter voice rates by destination.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>DomainVoiceRateResponseItemEntityListing</returns>
        DomainVoiceRateResponseItemEntityListing BillingVoiceratesOutboundInternationalGet (string currency, string origin = null, string destination = null, int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get current outbound international billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of current outbound international billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="origin">Filter voice rates by origin.</param>
        /// <param name="destination">Filter voice rates by destination.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of DomainVoiceRateResponseItemEntityListing</returns>
        ApiResponse<DomainVoiceRateResponseItemEntityListing> BillingVoiceratesOutboundInternationalGetWithHttpInfo (string currency, string origin = null, string destination = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get current outbound international billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of current outbound international billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="origin">Filter voice rates by origin.</param>
        /// <param name="destination">Filter voice rates by destination.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainVoiceRateResponseItemEntityListing</returns>
        System.Threading.Tasks.Task<DomainVoiceRateResponseItemEntityListing> BillingVoiceratesOutboundInternationalGetAsync (string currency, string origin = null, string destination = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get current outbound international billing voice rates
        /// </summary>
        /// <remarks>
        /// Retrieve a list of current outbound international billing voice rates stored in the system.
        /// </remarks>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="origin">Filter voice rates by origin.</param>
        /// <param name="destination">Filter voice rates by destination.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainVoiceRateResponseItemEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainVoiceRateResponseItemEntityListing>> BillingVoiceratesOutboundInternationalGetAsyncWithHttpInfo (string currency, string origin = null, string destination = null, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get current billing voice rates csv
        /// </summary>
        /// <remarks>
        /// Retrieve a csv of current billing voice rates stored in the system.
        /// </remarks>
        /// <returns>VoiceRatesCsv</returns>
        VoiceRatesCsv BillingVoiceratescsvGet ();
  
        /// <summary>
        /// Get current billing voice rates csv
        /// </summary>
        /// <remarks>
        /// Retrieve a csv of current billing voice rates stored in the system.
        /// </remarks>
        /// <returns>ApiResponse of VoiceRatesCsv</returns>
        ApiResponse<VoiceRatesCsv> BillingVoiceratescsvGetWithHttpInfo ();

        /// <summary>
        /// Get current billing voice rates csv
        /// </summary>
        /// <remarks>
        /// Retrieve a csv of current billing voice rates stored in the system.
        /// </remarks>
        /// <returns>Task of VoiceRatesCsv</returns>
        System.Threading.Tasks.Task<VoiceRatesCsv> BillingVoiceratescsvGetAsync ();

        /// <summary>
        /// Get current billing voice rates csv
        /// </summary>
        /// <remarks>
        /// Retrieve a csv of current billing voice rates stored in the system.
        /// </remarks>
        /// <returns>Task of ApiResponse (VoiceRatesCsv)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoiceRatesCsv>> BillingVoiceratescsvGetAsyncWithHttpInfo ();
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BillingApi : IBillingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BillingApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BillingApi(Configuration configuration = null)
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
        /// Get constumer account. 
        /// </summary>
        /// <returns>CustomerAccount</returns>
        public CustomerAccount BillingAccountGet ()
        {
             ApiResponse<CustomerAccount> response = BillingAccountGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get constumer account. 
        /// </summary>
        /// <returns>ApiResponse of CustomerAccount</returns>
        public ApiResponse< CustomerAccount > BillingAccountGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/billing/account";
    
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
                throw new ApiException (statusCode, "Error calling BillingAccountGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAccountGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CustomerAccount>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomerAccount) Configuration.ApiClient.Deserialize(response, typeof(CustomerAccount)));
            
        }
    
        /// <summary>
        /// Get constumer account. 
        /// </summary>
        /// <returns>Task of CustomerAccount</returns>
        public async System.Threading.Tasks.Task<CustomerAccount> BillingAccountGetAsync ()
        {
             ApiResponse<CustomerAccount> response = await BillingAccountGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get constumer account. 
        /// </summary>
        /// <returns>Task of ApiResponse (CustomerAccount)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CustomerAccount>> BillingAccountGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/billing/account";
    
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
                throw new ApiException (statusCode, "Error calling BillingAccountGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAccountGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CustomerAccount>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomerAccount) Configuration.ApiClient.Deserialize(response, typeof(CustomerAccount)));
            
        }
        
        /// <summary>
        /// Update customer account. 
        /// </summary>
        /// <param name="body">The account to be updated</param> 
        /// <returns>CustomerAccount</returns>
        public CustomerAccount BillingAccountPut (CustomerAccount body = null)
        {
             ApiResponse<CustomerAccount> response = BillingAccountPutWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Update customer account. 
        /// </summary>
        /// <param name="body">The account to be updated</param> 
        /// <returns>ApiResponse of CustomerAccount</returns>
        public ApiResponse< CustomerAccount > BillingAccountPutWithHttpInfo (CustomerAccount body = null)
        {
            
    
            var path_ = "/api/v1/billing/account";
    
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
                throw new ApiException (statusCode, "Error calling BillingAccountPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAccountPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CustomerAccount>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomerAccount) Configuration.ApiClient.Deserialize(response, typeof(CustomerAccount)));
            
        }
    
        /// <summary>
        /// Update customer account. 
        /// </summary>
        /// <param name="body">The account to be updated</param>
        /// <returns>Task of CustomerAccount</returns>
        public async System.Threading.Tasks.Task<CustomerAccount> BillingAccountPutAsync (CustomerAccount body = null)
        {
             ApiResponse<CustomerAccount> response = await BillingAccountPutAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Update customer account. 
        /// </summary>
        /// <param name="body">The account to be updated</param>
        /// <returns>Task of ApiResponse (CustomerAccount)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CustomerAccount>> BillingAccountPutAsyncWithHttpInfo (CustomerAccount body = null)
        {
            
    
            var path_ = "/api/v1/billing/account";
    
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
                throw new ApiException (statusCode, "Error calling BillingAccountPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAccountPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CustomerAccount>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomerAccount) Configuration.ApiClient.Deserialize(response, typeof(CustomerAccount)));
            
        }
        
        /// <summary>
        /// Create billing account. 
        /// </summary>
        /// <param name="body">The account to be created</param> 
        /// <returns>Account</returns>
        public Account BillingAccountsPost (Account body = null)
        {
             ApiResponse<Account> response = BillingAccountsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create billing account. 
        /// </summary>
        /// <param name="body">The account to be created</param> 
        /// <returns>ApiResponse of Account</returns>
        public ApiResponse< Account > BillingAccountsPostWithHttpInfo (Account body = null)
        {
            
    
            var path_ = "/api/v1/billing/accounts";
    
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
                throw new ApiException (statusCode, "Error calling BillingAccountsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAccountsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Account>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Account) Configuration.ApiClient.Deserialize(response, typeof(Account)));
            
        }
    
        /// <summary>
        /// Create billing account. 
        /// </summary>
        /// <param name="body">The account to be created</param>
        /// <returns>Task of Account</returns>
        public async System.Threading.Tasks.Task<Account> BillingAccountsPostAsync (Account body = null)
        {
             ApiResponse<Account> response = await BillingAccountsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create billing account. 
        /// </summary>
        /// <param name="body">The account to be created</param>
        /// <returns>Task of ApiResponse (Account)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Account>> BillingAccountsPostAsyncWithHttpInfo (Account body = null)
        {
            
    
            var path_ = "/api/v1/billing/accounts";
    
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
                throw new ApiException (statusCode, "Error calling BillingAccountsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAccountsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Account>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Account) Configuration.ApiClient.Deserialize(response, typeof(Account)));
            
        }
        
        /// <summary>
        /// Get billing account. 
        /// </summary>
        /// <param name="accountId">Identifies the account to be retrieved</param> 
        /// <param name="fields">Fields needed</param> 
        /// <returns>Account</returns>
        public Account BillingAccountsAccountidGet (string accountId, string fields = null)
        {
             ApiResponse<Account> response = BillingAccountsAccountidGetWithHttpInfo(accountId, fields);
             return response.Data;
        }

        /// <summary>
        /// Get billing account. 
        /// </summary>
        /// <param name="accountId">Identifies the account to be retrieved</param> 
        /// <param name="fields">Fields needed</param> 
        /// <returns>ApiResponse of Account</returns>
        public ApiResponse< Account > BillingAccountsAccountidGetWithHttpInfo (string accountId, string fields = null)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling BillingAccountsAccountidGet");
            
    
            var path_ = "/api/v1/billing/accounts/{accountId}";
    
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
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
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
                throw new ApiException (statusCode, "Error calling BillingAccountsAccountidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAccountsAccountidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Account>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Account) Configuration.ApiClient.Deserialize(response, typeof(Account)));
            
        }
    
        /// <summary>
        /// Get billing account. 
        /// </summary>
        /// <param name="accountId">Identifies the account to be retrieved</param>
        /// <param name="fields">Fields needed</param>
        /// <returns>Task of Account</returns>
        public async System.Threading.Tasks.Task<Account> BillingAccountsAccountidGetAsync (string accountId, string fields = null)
        {
             ApiResponse<Account> response = await BillingAccountsAccountidGetAsyncWithHttpInfo(accountId, fields);
             return response.Data;

        }

        /// <summary>
        /// Get billing account. 
        /// </summary>
        /// <param name="accountId">Identifies the account to be retrieved</param>
        /// <param name="fields">Fields needed</param>
        /// <returns>Task of ApiResponse (Account)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Account>> BillingAccountsAccountidGetAsyncWithHttpInfo (string accountId, string fields = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling BillingAccountsAccountidGet");
            
    
            var path_ = "/api/v1/billing/accounts/{accountId}";
    
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
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
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
                throw new ApiException (statusCode, "Error calling BillingAccountsAccountidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAccountsAccountidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Account>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Account) Configuration.ApiClient.Deserialize(response, typeof(Account)));
            
        }
        
        /// <summary>
        /// Updates the billing account. 
        /// </summary>
        /// <param name="accountId">Identifies the account to be updated</param> 
        /// <param name="body">The account to be updated</param> 
        /// <returns>Account</returns>
        public Account BillingAccountsAccountidPut (string accountId, Account body = null)
        {
             ApiResponse<Account> response = BillingAccountsAccountidPutWithHttpInfo(accountId, body);
             return response.Data;
        }

        /// <summary>
        /// Updates the billing account. 
        /// </summary>
        /// <param name="accountId">Identifies the account to be updated</param> 
        /// <param name="body">The account to be updated</param> 
        /// <returns>ApiResponse of Account</returns>
        public ApiResponse< Account > BillingAccountsAccountidPutWithHttpInfo (string accountId, Account body = null)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling BillingAccountsAccountidPut");
            
    
            var path_ = "/api/v1/billing/accounts/{accountId}";
    
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
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling BillingAccountsAccountidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAccountsAccountidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Account>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Account) Configuration.ApiClient.Deserialize(response, typeof(Account)));
            
        }
    
        /// <summary>
        /// Updates the billing account. 
        /// </summary>
        /// <param name="accountId">Identifies the account to be updated</param>
        /// <param name="body">The account to be updated</param>
        /// <returns>Task of Account</returns>
        public async System.Threading.Tasks.Task<Account> BillingAccountsAccountidPutAsync (string accountId, Account body = null)
        {
             ApiResponse<Account> response = await BillingAccountsAccountidPutAsyncWithHttpInfo(accountId, body);
             return response.Data;

        }

        /// <summary>
        /// Updates the billing account. 
        /// </summary>
        /// <param name="accountId">Identifies the account to be updated</param>
        /// <param name="body">The account to be updated</param>
        /// <returns>Task of ApiResponse (Account)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Account>> BillingAccountsAccountidPutAsyncWithHttpInfo (string accountId, Account body = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling BillingAccountsAccountidPut");
            
    
            var path_ = "/api/v1/billing/accounts/{accountId}";
    
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
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling BillingAccountsAccountidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAccountsAccountidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Account>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Account) Configuration.ApiClient.Deserialize(response, typeof(Account)));
            
        }
        
        /// <summary>
        /// Terminates the billing account of the org. 
        /// </summary>
        /// <param name="accountId">Identifies the account to be terminated</param> 
        /// <returns></returns>
        public void BillingAccountsAccountidDelete (string accountId)
        {
             BillingAccountsAccountidDeleteWithHttpInfo(accountId);
        }

        /// <summary>
        /// Terminates the billing account of the org. 
        /// </summary>
        /// <param name="accountId">Identifies the account to be terminated</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> BillingAccountsAccountidDeleteWithHttpInfo (string accountId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling BillingAccountsAccountidDelete");
            
    
            var path_ = "/api/v1/billing/accounts/{accountId}";
    
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
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingAccountsAccountidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAccountsAccountidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Terminates the billing account of the org. 
        /// </summary>
        /// <param name="accountId">Identifies the account to be terminated</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task BillingAccountsAccountidDeleteAsync (string accountId)
        {
             await BillingAccountsAccountidDeleteAsyncWithHttpInfo(accountId);

        }

        /// <summary>
        /// Terminates the billing account of the org. 
        /// </summary>
        /// <param name="accountId">Identifies the account to be terminated</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> BillingAccountsAccountidDeleteAsyncWithHttpInfo (string accountId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling BillingAccountsAccountidDelete");
            
    
            var path_ = "/api/v1/billing/accounts/{accountId}";
    
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
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingAccountsAccountidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAccountsAccountidDelete: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get billing account overview. 
        /// </summary>
        /// <param name="accountId">Identifies the account whose status should be retrieved</param> 
        /// <returns>AccountOverview</returns>
        public AccountOverview BillingAccountsAccountidOverviewGet (string accountId)
        {
             ApiResponse<AccountOverview> response = BillingAccountsAccountidOverviewGetWithHttpInfo(accountId);
             return response.Data;
        }

        /// <summary>
        /// Get billing account overview. 
        /// </summary>
        /// <param name="accountId">Identifies the account whose status should be retrieved</param> 
        /// <returns>ApiResponse of AccountOverview</returns>
        public ApiResponse< AccountOverview > BillingAccountsAccountidOverviewGetWithHttpInfo (string accountId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling BillingAccountsAccountidOverviewGet");
            
    
            var path_ = "/api/v1/billing/accounts/{accountId}/overview";
    
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
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingAccountsAccountidOverviewGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAccountsAccountidOverviewGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<AccountOverview>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AccountOverview) Configuration.ApiClient.Deserialize(response, typeof(AccountOverview)));
            
        }
    
        /// <summary>
        /// Get billing account overview. 
        /// </summary>
        /// <param name="accountId">Identifies the account whose status should be retrieved</param>
        /// <returns>Task of AccountOverview</returns>
        public async System.Threading.Tasks.Task<AccountOverview> BillingAccountsAccountidOverviewGetAsync (string accountId)
        {
             ApiResponse<AccountOverview> response = await BillingAccountsAccountidOverviewGetAsyncWithHttpInfo(accountId);
             return response.Data;

        }

        /// <summary>
        /// Get billing account overview. 
        /// </summary>
        /// <param name="accountId">Identifies the account whose status should be retrieved</param>
        /// <returns>Task of ApiResponse (AccountOverview)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccountOverview>> BillingAccountsAccountidOverviewGetAsyncWithHttpInfo (string accountId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling BillingAccountsAccountidOverviewGet");
            
    
            var path_ = "/api/v1/billing/accounts/{accountId}/overview";
    
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
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingAccountsAccountidOverviewGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAccountsAccountidOverviewGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AccountOverview>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AccountOverview) Configuration.ApiClient.Deserialize(response, typeof(AccountOverview)));
            
        }
        
        /// <summary>
        /// Get billing account status. 
        /// </summary>
        /// <param name="accountId">Identifies the account whose status should be retrieved</param> 
        /// <returns>AccountStatus</returns>
        public AccountStatus BillingAccountsAccountidStatusGet (string accountId)
        {
             ApiResponse<AccountStatus> response = BillingAccountsAccountidStatusGetWithHttpInfo(accountId);
             return response.Data;
        }

        /// <summary>
        /// Get billing account status. 
        /// </summary>
        /// <param name="accountId">Identifies the account whose status should be retrieved</param> 
        /// <returns>ApiResponse of AccountStatus</returns>
        public ApiResponse< AccountStatus > BillingAccountsAccountidStatusGetWithHttpInfo (string accountId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling BillingAccountsAccountidStatusGet");
            
    
            var path_ = "/api/v1/billing/accounts/{accountId}/status";
    
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
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingAccountsAccountidStatusGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAccountsAccountidStatusGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<AccountStatus>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AccountStatus) Configuration.ApiClient.Deserialize(response, typeof(AccountStatus)));
            
        }
    
        /// <summary>
        /// Get billing account status. 
        /// </summary>
        /// <param name="accountId">Identifies the account whose status should be retrieved</param>
        /// <returns>Task of AccountStatus</returns>
        public async System.Threading.Tasks.Task<AccountStatus> BillingAccountsAccountidStatusGetAsync (string accountId)
        {
             ApiResponse<AccountStatus> response = await BillingAccountsAccountidStatusGetAsyncWithHttpInfo(accountId);
             return response.Data;

        }

        /// <summary>
        /// Get billing account status. 
        /// </summary>
        /// <param name="accountId">Identifies the account whose status should be retrieved</param>
        /// <returns>Task of ApiResponse (AccountStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccountStatus>> BillingAccountsAccountidStatusGetAsyncWithHttpInfo (string accountId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling BillingAccountsAccountidStatusGet");
            
    
            var path_ = "/api/v1/billing/accounts/{accountId}/status";
    
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
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingAccountsAccountidStatusGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAccountsAccountidStatusGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AccountStatus>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AccountStatus) Configuration.ApiClient.Deserialize(response, typeof(AccountStatus)));
            
        }
        
        /// <summary>
        /// Updates the billing account status. 
        /// </summary>
        /// <param name="accountId">Identifies the account whose status should be updated</param> 
        /// <param name="body">The account status to be updated</param> 
        /// <returns>Account</returns>
        public Account BillingAccountsAccountidStatusPut (string accountId, AccountStatus body = null)
        {
             ApiResponse<Account> response = BillingAccountsAccountidStatusPutWithHttpInfo(accountId, body);
             return response.Data;
        }

        /// <summary>
        /// Updates the billing account status. 
        /// </summary>
        /// <param name="accountId">Identifies the account whose status should be updated</param> 
        /// <param name="body">The account status to be updated</param> 
        /// <returns>ApiResponse of Account</returns>
        public ApiResponse< Account > BillingAccountsAccountidStatusPutWithHttpInfo (string accountId, AccountStatus body = null)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling BillingAccountsAccountidStatusPut");
            
    
            var path_ = "/api/v1/billing/accounts/{accountId}/status";
    
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
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling BillingAccountsAccountidStatusPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAccountsAccountidStatusPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Account>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Account) Configuration.ApiClient.Deserialize(response, typeof(Account)));
            
        }
    
        /// <summary>
        /// Updates the billing account status. 
        /// </summary>
        /// <param name="accountId">Identifies the account whose status should be updated</param>
        /// <param name="body">The account status to be updated</param>
        /// <returns>Task of Account</returns>
        public async System.Threading.Tasks.Task<Account> BillingAccountsAccountidStatusPutAsync (string accountId, AccountStatus body = null)
        {
             ApiResponse<Account> response = await BillingAccountsAccountidStatusPutAsyncWithHttpInfo(accountId, body);
             return response.Data;

        }

        /// <summary>
        /// Updates the billing account status. 
        /// </summary>
        /// <param name="accountId">Identifies the account whose status should be updated</param>
        /// <param name="body">The account status to be updated</param>
        /// <returns>Task of ApiResponse (Account)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Account>> BillingAccountsAccountidStatusPutAsyncWithHttpInfo (string accountId, AccountStatus body = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling BillingAccountsAccountidStatusPut");
            
    
            var path_ = "/api/v1/billing/accounts/{accountId}/status";
    
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
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling BillingAccountsAccountidStatusPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAccountsAccountidStatusPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Account>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Account) Configuration.ApiClient.Deserialize(response, typeof(Account)));
            
        }
        
        /// <summary>
        /// Get available additional services. 
        /// </summary>
        /// <returns>AvailableAdditionalServiceListing</returns>
        public AvailableAdditionalServiceListing BillingAdditionalservicesGet ()
        {
             ApiResponse<AvailableAdditionalServiceListing> response = BillingAdditionalservicesGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get available additional services. 
        /// </summary>
        /// <returns>ApiResponse of AvailableAdditionalServiceListing</returns>
        public ApiResponse< AvailableAdditionalServiceListing > BillingAdditionalservicesGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/billing/additionalservices";
    
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
                throw new ApiException (statusCode, "Error calling BillingAdditionalservicesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAdditionalservicesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<AvailableAdditionalServiceListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvailableAdditionalServiceListing) Configuration.ApiClient.Deserialize(response, typeof(AvailableAdditionalServiceListing)));
            
        }
    
        /// <summary>
        /// Get available additional services. 
        /// </summary>
        /// <returns>Task of AvailableAdditionalServiceListing</returns>
        public async System.Threading.Tasks.Task<AvailableAdditionalServiceListing> BillingAdditionalservicesGetAsync ()
        {
             ApiResponse<AvailableAdditionalServiceListing> response = await BillingAdditionalservicesGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get available additional services. 
        /// </summary>
        /// <returns>Task of ApiResponse (AvailableAdditionalServiceListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AvailableAdditionalServiceListing>> BillingAdditionalservicesGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/billing/additionalservices";
    
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
                throw new ApiException (statusCode, "Error calling BillingAdditionalservicesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAdditionalservicesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AvailableAdditionalServiceListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvailableAdditionalServiceListing) Configuration.ApiClient.Deserialize(response, typeof(AvailableAdditionalServiceListing)));
            
        }
        
        /// <summary>
        /// Get billing addresses. 
        /// </summary>
        /// <returns>AddressListing</returns>
        public AddressListing BillingAddressesGet ()
        {
             ApiResponse<AddressListing> response = BillingAddressesGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get billing addresses. 
        /// </summary>
        /// <returns>ApiResponse of AddressListing</returns>
        public ApiResponse< AddressListing > BillingAddressesGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/billing/addresses";
    
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
                throw new ApiException (statusCode, "Error calling BillingAddressesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAddressesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<AddressListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AddressListing) Configuration.ApiClient.Deserialize(response, typeof(AddressListing)));
            
        }
    
        /// <summary>
        /// Get billing addresses. 
        /// </summary>
        /// <returns>Task of AddressListing</returns>
        public async System.Threading.Tasks.Task<AddressListing> BillingAddressesGetAsync ()
        {
             ApiResponse<AddressListing> response = await BillingAddressesGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get billing addresses. 
        /// </summary>
        /// <returns>Task of ApiResponse (AddressListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AddressListing>> BillingAddressesGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/billing/addresses";
    
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
                throw new ApiException (statusCode, "Error calling BillingAddressesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAddressesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AddressListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AddressListing) Configuration.ApiClient.Deserialize(response, typeof(AddressListing)));
            
        }
        
        /// <summary>
        /// Create billing address. 
        /// </summary>
        /// <param name="body">The address to be created</param> 
        /// <returns>Address</returns>
        public Address BillingAddressesPost (Address body = null)
        {
             ApiResponse<Address> response = BillingAddressesPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create billing address. 
        /// </summary>
        /// <param name="body">The address to be created</param> 
        /// <returns>ApiResponse of Address</returns>
        public ApiResponse< Address > BillingAddressesPostWithHttpInfo (Address body = null)
        {
            
    
            var path_ = "/api/v1/billing/addresses";
    
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
                throw new ApiException (statusCode, "Error calling BillingAddressesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAddressesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Address>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Address) Configuration.ApiClient.Deserialize(response, typeof(Address)));
            
        }
    
        /// <summary>
        /// Create billing address. 
        /// </summary>
        /// <param name="body">The address to be created</param>
        /// <returns>Task of Address</returns>
        public async System.Threading.Tasks.Task<Address> BillingAddressesPostAsync (Address body = null)
        {
             ApiResponse<Address> response = await BillingAddressesPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create billing address. 
        /// </summary>
        /// <param name="body">The address to be created</param>
        /// <returns>Task of ApiResponse (Address)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Address>> BillingAddressesPostAsyncWithHttpInfo (Address body = null)
        {
            
    
            var path_ = "/api/v1/billing/addresses";
    
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
                throw new ApiException (statusCode, "Error calling BillingAddressesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAddressesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Address>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Address) Configuration.ApiClient.Deserialize(response, typeof(Address)));
            
        }
        
        /// <summary>
        /// Get a billing address 
        /// </summary>
        /// <param name="addressId">The ID of the address</param> 
        /// <returns>Address</returns>
        public Address BillingAddressesAddressidGet (string addressId)
        {
             ApiResponse<Address> response = BillingAddressesAddressidGetWithHttpInfo(addressId);
             return response.Data;
        }

        /// <summary>
        /// Get a billing address 
        /// </summary>
        /// <param name="addressId">The ID of the address</param> 
        /// <returns>ApiResponse of Address</returns>
        public ApiResponse< Address > BillingAddressesAddressidGetWithHttpInfo (string addressId)
        {
            
            // verify the required parameter 'addressId' is set
            if (addressId == null) throw new ApiException(400, "Missing required parameter 'addressId' when calling BillingAddressesAddressidGet");
            
    
            var path_ = "/api/v1/billing/addresses/{addressId}";
    
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
            if (addressId != null) pathParams.Add("addressId", Configuration.ApiClient.ParameterToString(addressId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingAddressesAddressidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAddressesAddressidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Address>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Address) Configuration.ApiClient.Deserialize(response, typeof(Address)));
            
        }
    
        /// <summary>
        /// Get a billing address 
        /// </summary>
        /// <param name="addressId">The ID of the address</param>
        /// <returns>Task of Address</returns>
        public async System.Threading.Tasks.Task<Address> BillingAddressesAddressidGetAsync (string addressId)
        {
             ApiResponse<Address> response = await BillingAddressesAddressidGetAsyncWithHttpInfo(addressId);
             return response.Data;

        }

        /// <summary>
        /// Get a billing address 
        /// </summary>
        /// <param name="addressId">The ID of the address</param>
        /// <returns>Task of ApiResponse (Address)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Address>> BillingAddressesAddressidGetAsyncWithHttpInfo (string addressId)
        {
            // verify the required parameter 'addressId' is set
            if (addressId == null) throw new ApiException(400, "Missing required parameter 'addressId' when calling BillingAddressesAddressidGet");
            
    
            var path_ = "/api/v1/billing/addresses/{addressId}";
    
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
            if (addressId != null) pathParams.Add("addressId", Configuration.ApiClient.ParameterToString(addressId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingAddressesAddressidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAddressesAddressidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Address>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Address) Configuration.ApiClient.Deserialize(response, typeof(Address)));
            
        }
        
        /// <summary>
        /// Update billing address 
        /// </summary>
        /// <param name="addressId">The ID of the address</param> 
        /// <param name="body">The address to be updated</param> 
        /// <returns>Address</returns>
        public Address BillingAddressesAddressidPut (string addressId, Address body = null)
        {
             ApiResponse<Address> response = BillingAddressesAddressidPutWithHttpInfo(addressId, body);
             return response.Data;
        }

        /// <summary>
        /// Update billing address 
        /// </summary>
        /// <param name="addressId">The ID of the address</param> 
        /// <param name="body">The address to be updated</param> 
        /// <returns>ApiResponse of Address</returns>
        public ApiResponse< Address > BillingAddressesAddressidPutWithHttpInfo (string addressId, Address body = null)
        {
            
            // verify the required parameter 'addressId' is set
            if (addressId == null) throw new ApiException(400, "Missing required parameter 'addressId' when calling BillingAddressesAddressidPut");
            
    
            var path_ = "/api/v1/billing/addresses/{addressId}";
    
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
            if (addressId != null) pathParams.Add("addressId", Configuration.ApiClient.ParameterToString(addressId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling BillingAddressesAddressidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAddressesAddressidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Address>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Address) Configuration.ApiClient.Deserialize(response, typeof(Address)));
            
        }
    
        /// <summary>
        /// Update billing address 
        /// </summary>
        /// <param name="addressId">The ID of the address</param>
        /// <param name="body">The address to be updated</param>
        /// <returns>Task of Address</returns>
        public async System.Threading.Tasks.Task<Address> BillingAddressesAddressidPutAsync (string addressId, Address body = null)
        {
             ApiResponse<Address> response = await BillingAddressesAddressidPutAsyncWithHttpInfo(addressId, body);
             return response.Data;

        }

        /// <summary>
        /// Update billing address 
        /// </summary>
        /// <param name="addressId">The ID of the address</param>
        /// <param name="body">The address to be updated</param>
        /// <returns>Task of ApiResponse (Address)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Address>> BillingAddressesAddressidPutAsyncWithHttpInfo (string addressId, Address body = null)
        {
            // verify the required parameter 'addressId' is set
            if (addressId == null) throw new ApiException(400, "Missing required parameter 'addressId' when calling BillingAddressesAddressidPut");
            
    
            var path_ = "/api/v1/billing/addresses/{addressId}";
    
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
            if (addressId != null) pathParams.Add("addressId", Configuration.ApiClient.ParameterToString(addressId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling BillingAddressesAddressidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAddressesAddressidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Address>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Address) Configuration.ApiClient.Deserialize(response, typeof(Address)));
            
        }
        
        /// <summary>
        /// Delete billing address 
        /// </summary>
        /// <param name="addressId">The ID of the address</param> 
        /// <returns></returns>
        public void BillingAddressesAddressidDelete (string addressId)
        {
             BillingAddressesAddressidDeleteWithHttpInfo(addressId);
        }

        /// <summary>
        /// Delete billing address 
        /// </summary>
        /// <param name="addressId">The ID of the address</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> BillingAddressesAddressidDeleteWithHttpInfo (string addressId)
        {
            
            // verify the required parameter 'addressId' is set
            if (addressId == null) throw new ApiException(400, "Missing required parameter 'addressId' when calling BillingAddressesAddressidDelete");
            
    
            var path_ = "/api/v1/billing/addresses/{addressId}";
    
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
            if (addressId != null) pathParams.Add("addressId", Configuration.ApiClient.ParameterToString(addressId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingAddressesAddressidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAddressesAddressidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete billing address 
        /// </summary>
        /// <param name="addressId">The ID of the address</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task BillingAddressesAddressidDeleteAsync (string addressId)
        {
             await BillingAddressesAddressidDeleteAsyncWithHttpInfo(addressId);

        }

        /// <summary>
        /// Delete billing address 
        /// </summary>
        /// <param name="addressId">The ID of the address</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> BillingAddressesAddressidDeleteAsyncWithHttpInfo (string addressId)
        {
            // verify the required parameter 'addressId' is set
            if (addressId == null) throw new ApiException(400, "Missing required parameter 'addressId' when calling BillingAddressesAddressidDelete");
            
    
            var path_ = "/api/v1/billing/addresses/{addressId}";
    
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
            if (addressId != null) pathParams.Add("addressId", Configuration.ApiClient.ParameterToString(addressId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingAddressesAddressidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingAddressesAddressidDelete: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get basic products. 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> BillingBasicproductsGet ()
        {
             ApiResponse<List<string>> response = BillingBasicproductsGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get basic products. 
        /// </summary>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > BillingBasicproductsGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/billing/basicproducts";
    
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
                throw new ApiException (statusCode, "Error calling BillingBasicproductsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingBasicproductsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(response, typeof(List<string>)));
            
        }
    
        /// <summary>
        /// Get basic products. 
        /// </summary>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> BillingBasicproductsGetAsync ()
        {
             ApiResponse<List<string>> response = await BillingBasicproductsGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get basic products. 
        /// </summary>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> BillingBasicproductsGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/billing/basicproducts";
    
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
                throw new ApiException (statusCode, "Error calling BillingBasicproductsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingBasicproductsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(response, typeof(List<string>)));
            
        }
        
        /// <summary>
        /// Get carrier services usage data. 
        /// </summary>
        /// <param name="from">startDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="to">endDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="limit">Limit the number of results</param> 
        /// <returns>UrlResponse</returns>
        public UrlResponse BillingCarrierservicesUsageCallsGet (DateTime? from = null, DateTime? to = null, int? limit = null)
        {
             ApiResponse<UrlResponse> response = BillingCarrierservicesUsageCallsGetWithHttpInfo(from, to, limit);
             return response.Data;
        }

        /// <summary>
        /// Get carrier services usage data. 
        /// </summary>
        /// <param name="from">startDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="to">endDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="limit">Limit the number of results</param> 
        /// <returns>ApiResponse of UrlResponse</returns>
        public ApiResponse< UrlResponse > BillingCarrierservicesUsageCallsGetWithHttpInfo (DateTime? from = null, DateTime? to = null, int? limit = null)
        {
            
    
            var path_ = "/api/v1/billing/carrierservices/usage/calls";
    
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
            
            if (from != null) queryParams.Add("from", Configuration.ApiClient.ParameterToString(from)); // query parameter
            if (to != null) queryParams.Add("to", Configuration.ApiClient.ParameterToString(to)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingCarrierservicesUsageCallsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingCarrierservicesUsageCallsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UrlResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UrlResponse) Configuration.ApiClient.Deserialize(response, typeof(UrlResponse)));
            
        }
    
        /// <summary>
        /// Get carrier services usage data. 
        /// </summary>
        /// <param name="from">startDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="to">endDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="limit">Limit the number of results</param>
        /// <returns>Task of UrlResponse</returns>
        public async System.Threading.Tasks.Task<UrlResponse> BillingCarrierservicesUsageCallsGetAsync (DateTime? from = null, DateTime? to = null, int? limit = null)
        {
             ApiResponse<UrlResponse> response = await BillingCarrierservicesUsageCallsGetAsyncWithHttpInfo(from, to, limit);
             return response.Data;

        }

        /// <summary>
        /// Get carrier services usage data. 
        /// </summary>
        /// <param name="from">startDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="to">endDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="limit">Limit the number of results</param>
        /// <returns>Task of ApiResponse (UrlResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UrlResponse>> BillingCarrierservicesUsageCallsGetAsyncWithHttpInfo (DateTime? from = null, DateTime? to = null, int? limit = null)
        {
            
    
            var path_ = "/api/v1/billing/carrierservices/usage/calls";
    
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
            
            if (from != null) queryParams.Add("from", Configuration.ApiClient.ParameterToString(from)); // query parameter
            if (to != null) queryParams.Add("to", Configuration.ApiClient.ParameterToString(to)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingCarrierservicesUsageCallsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingCarrierservicesUsageCallsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UrlResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UrlResponse) Configuration.ApiClient.Deserialize(response, typeof(UrlResponse)));
            
        }
        
        /// <summary>
        /// Get carrier services usage data CSV. 
        /// </summary>
        /// <param name="from">startDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="to">endDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="limit">Limit the number of results</param> 
        /// <returns>UrlResponse</returns>
        public UrlResponse BillingCarrierservicesUsageCallsCsvGet (DateTime? from = null, DateTime? to = null, int? limit = null)
        {
             ApiResponse<UrlResponse> response = BillingCarrierservicesUsageCallsCsvGetWithHttpInfo(from, to, limit);
             return response.Data;
        }

        /// <summary>
        /// Get carrier services usage data CSV. 
        /// </summary>
        /// <param name="from">startDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="to">endDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="limit">Limit the number of results</param> 
        /// <returns>ApiResponse of UrlResponse</returns>
        public ApiResponse< UrlResponse > BillingCarrierservicesUsageCallsCsvGetWithHttpInfo (DateTime? from = null, DateTime? to = null, int? limit = null)
        {
            
    
            var path_ = "/api/v1/billing/carrierservices/usage/calls/csv";
    
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
            
            if (from != null) queryParams.Add("from", Configuration.ApiClient.ParameterToString(from)); // query parameter
            if (to != null) queryParams.Add("to", Configuration.ApiClient.ParameterToString(to)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingCarrierservicesUsageCallsCsvGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingCarrierservicesUsageCallsCsvGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UrlResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UrlResponse) Configuration.ApiClient.Deserialize(response, typeof(UrlResponse)));
            
        }
    
        /// <summary>
        /// Get carrier services usage data CSV. 
        /// </summary>
        /// <param name="from">startDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="to">endDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="limit">Limit the number of results</param>
        /// <returns>Task of UrlResponse</returns>
        public async System.Threading.Tasks.Task<UrlResponse> BillingCarrierservicesUsageCallsCsvGetAsync (DateTime? from = null, DateTime? to = null, int? limit = null)
        {
             ApiResponse<UrlResponse> response = await BillingCarrierservicesUsageCallsCsvGetAsyncWithHttpInfo(from, to, limit);
             return response.Data;

        }

        /// <summary>
        /// Get carrier services usage data CSV. 
        /// </summary>
        /// <param name="from">startDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="to">endDateTime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="limit">Limit the number of results</param>
        /// <returns>Task of ApiResponse (UrlResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UrlResponse>> BillingCarrierservicesUsageCallsCsvGetAsyncWithHttpInfo (DateTime? from = null, DateTime? to = null, int? limit = null)
        {
            
    
            var path_ = "/api/v1/billing/carrierservices/usage/calls/csv";
    
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
            
            if (from != null) queryParams.Add("from", Configuration.ApiClient.ParameterToString(from)); // query parameter
            if (to != null) queryParams.Add("to", Configuration.ApiClient.ParameterToString(to)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingCarrierservicesUsageCallsCsvGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingCarrierservicesUsageCallsCsvGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UrlResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UrlResponse) Configuration.ApiClient.Deserialize(response, typeof(UrlResponse)));
            
        }
        
        /// <summary>
        /// Contact Sales. 
        /// </summary>
        /// <param name="body">The contact sales details</param> 
        /// <returns>ContactSalesResponse</returns>
        public ContactSalesResponse BillingContactsalesPost (ContactSales body = null)
        {
             ApiResponse<ContactSalesResponse> response = BillingContactsalesPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Contact Sales. 
        /// </summary>
        /// <param name="body">The contact sales details</param> 
        /// <returns>ApiResponse of ContactSalesResponse</returns>
        public ApiResponse< ContactSalesResponse > BillingContactsalesPostWithHttpInfo (ContactSales body = null)
        {
            
    
            var path_ = "/api/v1/billing/contactsales";
    
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
                throw new ApiException (statusCode, "Error calling BillingContactsalesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingContactsalesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ContactSalesResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactSalesResponse) Configuration.ApiClient.Deserialize(response, typeof(ContactSalesResponse)));
            
        }
    
        /// <summary>
        /// Contact Sales. 
        /// </summary>
        /// <param name="body">The contact sales details</param>
        /// <returns>Task of ContactSalesResponse</returns>
        public async System.Threading.Tasks.Task<ContactSalesResponse> BillingContactsalesPostAsync (ContactSales body = null)
        {
             ApiResponse<ContactSalesResponse> response = await BillingContactsalesPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Contact Sales. 
        /// </summary>
        /// <param name="body">The contact sales details</param>
        /// <returns>Task of ApiResponse (ContactSalesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactSalesResponse>> BillingContactsalesPostAsyncWithHttpInfo (ContactSales body = null)
        {
            
    
            var path_ = "/api/v1/billing/contactsales";
    
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
                throw new ApiException (statusCode, "Error calling BillingContactsalesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingContactsalesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ContactSalesResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactSalesResponse) Configuration.ApiClient.Deserialize(response, typeof(ContactSalesResponse)));
            
        }
        
        /// <summary>
        /// Create contract and signer view URL. 
        /// </summary>
        /// <param name="body">The contract to be created</param> 
        /// <returns>Contract</returns>
        public Contract BillingContractsPost (Contract body = null)
        {
             ApiResponse<Contract> response = BillingContractsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create contract and signer view URL. 
        /// </summary>
        /// <param name="body">The contract to be created</param> 
        /// <returns>ApiResponse of Contract</returns>
        public ApiResponse< Contract > BillingContractsPostWithHttpInfo (Contract body = null)
        {
            
    
            var path_ = "/api/v1/billing/contracts";
    
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
                throw new ApiException (statusCode, "Error calling BillingContractsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingContractsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Contract>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Contract) Configuration.ApiClient.Deserialize(response, typeof(Contract)));
            
        }
    
        /// <summary>
        /// Create contract and signer view URL. 
        /// </summary>
        /// <param name="body">The contract to be created</param>
        /// <returns>Task of Contract</returns>
        public async System.Threading.Tasks.Task<Contract> BillingContractsPostAsync (Contract body = null)
        {
             ApiResponse<Contract> response = await BillingContractsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create contract and signer view URL. 
        /// </summary>
        /// <param name="body">The contract to be created</param>
        /// <returns>Task of ApiResponse (Contract)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Contract>> BillingContractsPostAsyncWithHttpInfo (Contract body = null)
        {
            
    
            var path_ = "/api/v1/billing/contracts";
    
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
                throw new ApiException (statusCode, "Error calling BillingContractsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingContractsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Contract>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Contract) Configuration.ApiClient.Deserialize(response, typeof(Contract)));
            
        }
        
        /// <summary>
        /// Gets a job that was started to generate a contract for a quote 
        /// </summary>
        /// <param name="jobId">The ID of the job</param> 
        /// <returns>ContractJob</returns>
        public ContractJob BillingContractsJobsJobidGet (string jobId)
        {
             ApiResponse<ContractJob> response = BillingContractsJobsJobidGetWithHttpInfo(jobId);
             return response.Data;
        }

        /// <summary>
        /// Gets a job that was started to generate a contract for a quote 
        /// </summary>
        /// <param name="jobId">The ID of the job</param> 
        /// <returns>ApiResponse of ContractJob</returns>
        public ApiResponse< ContractJob > BillingContractsJobsJobidGetWithHttpInfo (string jobId)
        {
            
            // verify the required parameter 'jobId' is set
            if (jobId == null) throw new ApiException(400, "Missing required parameter 'jobId' when calling BillingContractsJobsJobidGet");
            
    
            var path_ = "/api/v1/billing/contracts/jobs/{jobId}";
    
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
            if (jobId != null) pathParams.Add("jobId", Configuration.ApiClient.ParameterToString(jobId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingContractsJobsJobidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingContractsJobsJobidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ContractJob>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContractJob) Configuration.ApiClient.Deserialize(response, typeof(ContractJob)));
            
        }
    
        /// <summary>
        /// Gets a job that was started to generate a contract for a quote 
        /// </summary>
        /// <param name="jobId">The ID of the job</param>
        /// <returns>Task of ContractJob</returns>
        public async System.Threading.Tasks.Task<ContractJob> BillingContractsJobsJobidGetAsync (string jobId)
        {
             ApiResponse<ContractJob> response = await BillingContractsJobsJobidGetAsyncWithHttpInfo(jobId);
             return response.Data;

        }

        /// <summary>
        /// Gets a job that was started to generate a contract for a quote 
        /// </summary>
        /// <param name="jobId">The ID of the job</param>
        /// <returns>Task of ApiResponse (ContractJob)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContractJob>> BillingContractsJobsJobidGetAsyncWithHttpInfo (string jobId)
        {
            // verify the required parameter 'jobId' is set
            if (jobId == null) throw new ApiException(400, "Missing required parameter 'jobId' when calling BillingContractsJobsJobidGet");
            
    
            var path_ = "/api/v1/billing/contracts/jobs/{jobId}";
    
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
            if (jobId != null) pathParams.Add("jobId", Configuration.ApiClient.ParameterToString(jobId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingContractsJobsJobidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingContractsJobsJobidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ContractJob>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContractJob) Configuration.ApiClient.Deserialize(response, typeof(ContractJob)));
            
        }
        
        /// <summary>
        /// Get a contract that was generated for a quote 
        /// </summary>
        /// <param name="contractId">The ID of the contract</param> 
        /// <returns>Contract</returns>
        public Contract BillingContractsContractidGet (string contractId)
        {
             ApiResponse<Contract> response = BillingContractsContractidGetWithHttpInfo(contractId);
             return response.Data;
        }

        /// <summary>
        /// Get a contract that was generated for a quote 
        /// </summary>
        /// <param name="contractId">The ID of the contract</param> 
        /// <returns>ApiResponse of Contract</returns>
        public ApiResponse< Contract > BillingContractsContractidGetWithHttpInfo (string contractId)
        {
            
            // verify the required parameter 'contractId' is set
            if (contractId == null) throw new ApiException(400, "Missing required parameter 'contractId' when calling BillingContractsContractidGet");
            
    
            var path_ = "/api/v1/billing/contracts/{contractId}";
    
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
            if (contractId != null) pathParams.Add("contractId", Configuration.ApiClient.ParameterToString(contractId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingContractsContractidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingContractsContractidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Contract>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Contract) Configuration.ApiClient.Deserialize(response, typeof(Contract)));
            
        }
    
        /// <summary>
        /// Get a contract that was generated for a quote 
        /// </summary>
        /// <param name="contractId">The ID of the contract</param>
        /// <returns>Task of Contract</returns>
        public async System.Threading.Tasks.Task<Contract> BillingContractsContractidGetAsync (string contractId)
        {
             ApiResponse<Contract> response = await BillingContractsContractidGetAsyncWithHttpInfo(contractId);
             return response.Data;

        }

        /// <summary>
        /// Get a contract that was generated for a quote 
        /// </summary>
        /// <param name="contractId">The ID of the contract</param>
        /// <returns>Task of ApiResponse (Contract)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Contract>> BillingContractsContractidGetAsyncWithHttpInfo (string contractId)
        {
            // verify the required parameter 'contractId' is set
            if (contractId == null) throw new ApiException(400, "Missing required parameter 'contractId' when calling BillingContractsContractidGet");
            
    
            var path_ = "/api/v1/billing/contracts/{contractId}";
    
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
            if (contractId != null) pathParams.Add("contractId", Configuration.ApiClient.ParameterToString(contractId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingContractsContractidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingContractsContractidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Contract>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Contract) Configuration.ApiClient.Deserialize(response, typeof(Contract)));
            
        }
        
        /// <summary>
        /// Get available currencies. 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> BillingCurrenciesGet ()
        {
             ApiResponse<List<string>> response = BillingCurrenciesGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get available currencies. 
        /// </summary>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > BillingCurrenciesGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/billing/currencies";
    
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
                throw new ApiException (statusCode, "Error calling BillingCurrenciesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingCurrenciesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(response, typeof(List<string>)));
            
        }
    
        /// <summary>
        /// Get available currencies. 
        /// </summary>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> BillingCurrenciesGetAsync ()
        {
             ApiResponse<List<string>> response = await BillingCurrenciesGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get available currencies. 
        /// </summary>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> BillingCurrenciesGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/billing/currencies";
    
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
                throw new ApiException (statusCode, "Error calling BillingCurrenciesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingCurrenciesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<string>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(response, typeof(List<string>)));
            
        }
        
        /// <summary>
        /// Get rates for available hardware. 
        /// </summary>
        /// <param name="productSubCategory">Filter rates by product subcategory. Examples are &#39;Phones&#39; or &#39;PowerCords&#39;.</param> 
        /// <returns>HardwareRateListing</returns>
        public HardwareRateListing BillingHardwareratesGet (string productSubCategory)
        {
             ApiResponse<HardwareRateListing> response = BillingHardwareratesGetWithHttpInfo(productSubCategory);
             return response.Data;
        }

        /// <summary>
        /// Get rates for available hardware. 
        /// </summary>
        /// <param name="productSubCategory">Filter rates by product subcategory. Examples are &#39;Phones&#39; or &#39;PowerCords&#39;.</param> 
        /// <returns>ApiResponse of HardwareRateListing</returns>
        public ApiResponse< HardwareRateListing > BillingHardwareratesGetWithHttpInfo (string productSubCategory)
        {
            
            // verify the required parameter 'productSubCategory' is set
            if (productSubCategory == null) throw new ApiException(400, "Missing required parameter 'productSubCategory' when calling BillingHardwareratesGet");
            
    
            var path_ = "/api/v1/billing/hardwarerates";
    
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
            
            if (productSubCategory != null) queryParams.Add("productSubCategory", Configuration.ApiClient.ParameterToString(productSubCategory)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingHardwareratesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingHardwareratesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<HardwareRateListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HardwareRateListing) Configuration.ApiClient.Deserialize(response, typeof(HardwareRateListing)));
            
        }
    
        /// <summary>
        /// Get rates for available hardware. 
        /// </summary>
        /// <param name="productSubCategory">Filter rates by product subcategory. Examples are &#39;Phones&#39; or &#39;PowerCords&#39;.</param>
        /// <returns>Task of HardwareRateListing</returns>
        public async System.Threading.Tasks.Task<HardwareRateListing> BillingHardwareratesGetAsync (string productSubCategory)
        {
             ApiResponse<HardwareRateListing> response = await BillingHardwareratesGetAsyncWithHttpInfo(productSubCategory);
             return response.Data;

        }

        /// <summary>
        /// Get rates for available hardware. 
        /// </summary>
        /// <param name="productSubCategory">Filter rates by product subcategory. Examples are &#39;Phones&#39; or &#39;PowerCords&#39;.</param>
        /// <returns>Task of ApiResponse (HardwareRateListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<HardwareRateListing>> BillingHardwareratesGetAsyncWithHttpInfo (string productSubCategory)
        {
            // verify the required parameter 'productSubCategory' is set
            if (productSubCategory == null) throw new ApiException(400, "Missing required parameter 'productSubCategory' when calling BillingHardwareratesGet");
            
    
            var path_ = "/api/v1/billing/hardwarerates";
    
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
            
            if (productSubCategory != null) queryParams.Add("productSubCategory", Configuration.ApiClient.ParameterToString(productSubCategory)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingHardwareratesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingHardwareratesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<HardwareRateListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HardwareRateListing) Configuration.ApiClient.Deserialize(response, typeof(HardwareRateListing)));
            
        }
        
        /// <summary>
        /// Get historical extended billing voice rates Retrieve a list of historical extended billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param> 
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="groupName">Filter voice rates by group.</param> 
        /// <param name="areaCode">Filter voice rates by areaCode.</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>DomainVoiceRateResponseItemEntityListing</returns>
        public DomainVoiceRateResponseItemEntityListing BillingHistoricalvoiceratesExtendedGet (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string groupName = null, string areaCode = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainVoiceRateResponseItemEntityListing> response = BillingHistoricalvoiceratesExtendedGetWithHttpInfo(currency, effectiveDateStart, effectiveDateEnd, groupName, areaCode, pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get historical extended billing voice rates Retrieve a list of historical extended billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param> 
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="groupName">Filter voice rates by group.</param> 
        /// <param name="areaCode">Filter voice rates by areaCode.</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of DomainVoiceRateResponseItemEntityListing</returns>
        public ApiResponse< DomainVoiceRateResponseItemEntityListing > BillingHistoricalvoiceratesExtendedGetWithHttpInfo (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string groupName = null, string areaCode = null, int? pageSize = null, int? pageNumber = null)
        {
            
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling BillingHistoricalvoiceratesExtendedGet");
            
    
            var path_ = "/api/v1/billing/historicalvoicerates/extended";
    
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
            
            if (currency != null) queryParams.Add("currency", Configuration.ApiClient.ParameterToString(currency)); // query parameter
            if (effectiveDateStart != null) queryParams.Add("effectiveDateStart", Configuration.ApiClient.ParameterToString(effectiveDateStart)); // query parameter
            if (effectiveDateEnd != null) queryParams.Add("effectiveDateEnd", Configuration.ApiClient.ParameterToString(effectiveDateEnd)); // query parameter
            if (groupName != null) queryParams.Add("groupName", Configuration.ApiClient.ParameterToString(groupName)); // query parameter
            if (areaCode != null) queryParams.Add("areaCode", Configuration.ApiClient.ParameterToString(areaCode)); // query parameter
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
                throw new ApiException (statusCode, "Error calling BillingHistoricalvoiceratesExtendedGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingHistoricalvoiceratesExtendedGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainVoiceRateResponseItemEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainVoiceRateResponseItemEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainVoiceRateResponseItemEntityListing)));
            
        }
    
        /// <summary>
        /// Get historical extended billing voice rates Retrieve a list of historical extended billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="groupName">Filter voice rates by group.</param>
        /// <param name="areaCode">Filter voice rates by areaCode.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainVoiceRateResponseItemEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainVoiceRateResponseItemEntityListing> BillingHistoricalvoiceratesExtendedGetAsync (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string groupName = null, string areaCode = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainVoiceRateResponseItemEntityListing> response = await BillingHistoricalvoiceratesExtendedGetAsyncWithHttpInfo(currency, effectiveDateStart, effectiveDateEnd, groupName, areaCode, pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get historical extended billing voice rates Retrieve a list of historical extended billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="groupName">Filter voice rates by group.</param>
        /// <param name="areaCode">Filter voice rates by areaCode.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainVoiceRateResponseItemEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainVoiceRateResponseItemEntityListing>> BillingHistoricalvoiceratesExtendedGetAsyncWithHttpInfo (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string groupName = null, string areaCode = null, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling BillingHistoricalvoiceratesExtendedGet");
            
    
            var path_ = "/api/v1/billing/historicalvoicerates/extended";
    
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
            
            if (currency != null) queryParams.Add("currency", Configuration.ApiClient.ParameterToString(currency)); // query parameter
            if (effectiveDateStart != null) queryParams.Add("effectiveDateStart", Configuration.ApiClient.ParameterToString(effectiveDateStart)); // query parameter
            if (effectiveDateEnd != null) queryParams.Add("effectiveDateEnd", Configuration.ApiClient.ParameterToString(effectiveDateEnd)); // query parameter
            if (groupName != null) queryParams.Add("groupName", Configuration.ApiClient.ParameterToString(groupName)); // query parameter
            if (areaCode != null) queryParams.Add("areaCode", Configuration.ApiClient.ParameterToString(areaCode)); // query parameter
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
                throw new ApiException (statusCode, "Error calling BillingHistoricalvoiceratesExtendedGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingHistoricalvoiceratesExtendedGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainVoiceRateResponseItemEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainVoiceRateResponseItemEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainVoiceRateResponseItemEntityListing)));
            
        }
        
        /// <summary>
        /// Get historical inbound billing voice rates Retrieve a list of historical inbound billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param> 
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>DomainVoiceRateResponseItemEntityListing</returns>
        public DomainVoiceRateResponseItemEntityListing BillingHistoricalvoiceratesInboundGet (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string type = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainVoiceRateResponseItemEntityListing> response = BillingHistoricalvoiceratesInboundGetWithHttpInfo(currency, effectiveDateStart, effectiveDateEnd, type, pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get historical inbound billing voice rates Retrieve a list of historical inbound billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param> 
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of DomainVoiceRateResponseItemEntityListing</returns>
        public ApiResponse< DomainVoiceRateResponseItemEntityListing > BillingHistoricalvoiceratesInboundGetWithHttpInfo (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string type = null, int? pageSize = null, int? pageNumber = null)
        {
            
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling BillingHistoricalvoiceratesInboundGet");
            
    
            var path_ = "/api/v1/billing/historicalvoicerates/inbound";
    
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
            
            if (currency != null) queryParams.Add("currency", Configuration.ApiClient.ParameterToString(currency)); // query parameter
            if (effectiveDateStart != null) queryParams.Add("effectiveDateStart", Configuration.ApiClient.ParameterToString(effectiveDateStart)); // query parameter
            if (effectiveDateEnd != null) queryParams.Add("effectiveDateEnd", Configuration.ApiClient.ParameterToString(effectiveDateEnd)); // query parameter
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
                throw new ApiException (statusCode, "Error calling BillingHistoricalvoiceratesInboundGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingHistoricalvoiceratesInboundGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainVoiceRateResponseItemEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainVoiceRateResponseItemEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainVoiceRateResponseItemEntityListing)));
            
        }
    
        /// <summary>
        /// Get historical inbound billing voice rates Retrieve a list of historical inbound billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainVoiceRateResponseItemEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainVoiceRateResponseItemEntityListing> BillingHistoricalvoiceratesInboundGetAsync (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string type = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainVoiceRateResponseItemEntityListing> response = await BillingHistoricalvoiceratesInboundGetAsyncWithHttpInfo(currency, effectiveDateStart, effectiveDateEnd, type, pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get historical inbound billing voice rates Retrieve a list of historical inbound billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainVoiceRateResponseItemEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainVoiceRateResponseItemEntityListing>> BillingHistoricalvoiceratesInboundGetAsyncWithHttpInfo (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string type = null, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling BillingHistoricalvoiceratesInboundGet");
            
    
            var path_ = "/api/v1/billing/historicalvoicerates/inbound";
    
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
            
            if (currency != null) queryParams.Add("currency", Configuration.ApiClient.ParameterToString(currency)); // query parameter
            if (effectiveDateStart != null) queryParams.Add("effectiveDateStart", Configuration.ApiClient.ParameterToString(effectiveDateStart)); // query parameter
            if (effectiveDateEnd != null) queryParams.Add("effectiveDateEnd", Configuration.ApiClient.ParameterToString(effectiveDateEnd)); // query parameter
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
                throw new ApiException (statusCode, "Error calling BillingHistoricalvoiceratesInboundGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingHistoricalvoiceratesInboundGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainVoiceRateResponseItemEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainVoiceRateResponseItemEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainVoiceRateResponseItemEntityListing)));
            
        }
        
        /// <summary>
        /// Get historical outbound domestic billing voice rates Retrieve a list of historical outbound domestic billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param> 
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>DomainVoiceRateResponseItemEntityListing</returns>
        public DomainVoiceRateResponseItemEntityListing BillingHistoricalvoiceratesOutboundDomesticGet (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string type = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainVoiceRateResponseItemEntityListing> response = BillingHistoricalvoiceratesOutboundDomesticGetWithHttpInfo(currency, effectiveDateStart, effectiveDateEnd, type, pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get historical outbound domestic billing voice rates Retrieve a list of historical outbound domestic billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param> 
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of DomainVoiceRateResponseItemEntityListing</returns>
        public ApiResponse< DomainVoiceRateResponseItemEntityListing > BillingHistoricalvoiceratesOutboundDomesticGetWithHttpInfo (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string type = null, int? pageSize = null, int? pageNumber = null)
        {
            
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling BillingHistoricalvoiceratesOutboundDomesticGet");
            
    
            var path_ = "/api/v1/billing/historicalvoicerates/outbound/domestic";
    
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
            
            if (currency != null) queryParams.Add("currency", Configuration.ApiClient.ParameterToString(currency)); // query parameter
            if (effectiveDateStart != null) queryParams.Add("effectiveDateStart", Configuration.ApiClient.ParameterToString(effectiveDateStart)); // query parameter
            if (effectiveDateEnd != null) queryParams.Add("effectiveDateEnd", Configuration.ApiClient.ParameterToString(effectiveDateEnd)); // query parameter
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
                throw new ApiException (statusCode, "Error calling BillingHistoricalvoiceratesOutboundDomesticGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingHistoricalvoiceratesOutboundDomesticGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainVoiceRateResponseItemEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainVoiceRateResponseItemEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainVoiceRateResponseItemEntityListing)));
            
        }
    
        /// <summary>
        /// Get historical outbound domestic billing voice rates Retrieve a list of historical outbound domestic billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainVoiceRateResponseItemEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainVoiceRateResponseItemEntityListing> BillingHistoricalvoiceratesOutboundDomesticGetAsync (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string type = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainVoiceRateResponseItemEntityListing> response = await BillingHistoricalvoiceratesOutboundDomesticGetAsyncWithHttpInfo(currency, effectiveDateStart, effectiveDateEnd, type, pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get historical outbound domestic billing voice rates Retrieve a list of historical outbound domestic billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainVoiceRateResponseItemEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainVoiceRateResponseItemEntityListing>> BillingHistoricalvoiceratesOutboundDomesticGetAsyncWithHttpInfo (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string type = null, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling BillingHistoricalvoiceratesOutboundDomesticGet");
            
    
            var path_ = "/api/v1/billing/historicalvoicerates/outbound/domestic";
    
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
            
            if (currency != null) queryParams.Add("currency", Configuration.ApiClient.ParameterToString(currency)); // query parameter
            if (effectiveDateStart != null) queryParams.Add("effectiveDateStart", Configuration.ApiClient.ParameterToString(effectiveDateStart)); // query parameter
            if (effectiveDateEnd != null) queryParams.Add("effectiveDateEnd", Configuration.ApiClient.ParameterToString(effectiveDateEnd)); // query parameter
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
                throw new ApiException (statusCode, "Error calling BillingHistoricalvoiceratesOutboundDomesticGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingHistoricalvoiceratesOutboundDomesticGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainVoiceRateResponseItemEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainVoiceRateResponseItemEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainVoiceRateResponseItemEntityListing)));
            
        }
        
        /// <summary>
        /// Get historical outbound international billing voice rates Retrieve a list of historical outbound international billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param> 
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="origin">Filter voice rates by origin.</param> 
        /// <param name="destination">Filter voice rates by destination.</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>DomainVoiceRateResponseItemEntityListing</returns>
        public DomainVoiceRateResponseItemEntityListing BillingHistoricalvoiceratesOutboundInternationalGet (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string origin = null, string destination = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainVoiceRateResponseItemEntityListing> response = BillingHistoricalvoiceratesOutboundInternationalGetWithHttpInfo(currency, effectiveDateStart, effectiveDateEnd, origin, destination, pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get historical outbound international billing voice rates Retrieve a list of historical outbound international billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param> 
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="origin">Filter voice rates by origin.</param> 
        /// <param name="destination">Filter voice rates by destination.</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of DomainVoiceRateResponseItemEntityListing</returns>
        public ApiResponse< DomainVoiceRateResponseItemEntityListing > BillingHistoricalvoiceratesOutboundInternationalGetWithHttpInfo (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string origin = null, string destination = null, int? pageSize = null, int? pageNumber = null)
        {
            
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling BillingHistoricalvoiceratesOutboundInternationalGet");
            
    
            var path_ = "/api/v1/billing/historicalvoicerates/outbound/international";
    
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
            
            if (currency != null) queryParams.Add("currency", Configuration.ApiClient.ParameterToString(currency)); // query parameter
            if (effectiveDateStart != null) queryParams.Add("effectiveDateStart", Configuration.ApiClient.ParameterToString(effectiveDateStart)); // query parameter
            if (effectiveDateEnd != null) queryParams.Add("effectiveDateEnd", Configuration.ApiClient.ParameterToString(effectiveDateEnd)); // query parameter
            if (origin != null) queryParams.Add("origin", Configuration.ApiClient.ParameterToString(origin)); // query parameter
            if (destination != null) queryParams.Add("destination", Configuration.ApiClient.ParameterToString(destination)); // query parameter
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
                throw new ApiException (statusCode, "Error calling BillingHistoricalvoiceratesOutboundInternationalGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingHistoricalvoiceratesOutboundInternationalGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainVoiceRateResponseItemEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainVoiceRateResponseItemEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainVoiceRateResponseItemEntityListing)));
            
        }
    
        /// <summary>
        /// Get historical outbound international billing voice rates Retrieve a list of historical outbound international billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="origin">Filter voice rates by origin.</param>
        /// <param name="destination">Filter voice rates by destination.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainVoiceRateResponseItemEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainVoiceRateResponseItemEntityListing> BillingHistoricalvoiceratesOutboundInternationalGetAsync (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string origin = null, string destination = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainVoiceRateResponseItemEntityListing> response = await BillingHistoricalvoiceratesOutboundInternationalGetAsyncWithHttpInfo(currency, effectiveDateStart, effectiveDateEnd, origin, destination, pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get historical outbound international billing voice rates Retrieve a list of historical outbound international billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="effectiveDateStart">Filter voice rates by effective start date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="effectiveDateEnd">Filter voice rates by effective end date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="origin">Filter voice rates by origin.</param>
        /// <param name="destination">Filter voice rates by destination.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainVoiceRateResponseItemEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainVoiceRateResponseItemEntityListing>> BillingHistoricalvoiceratesOutboundInternationalGetAsyncWithHttpInfo (string currency, DateTime? effectiveDateStart = null, DateTime? effectiveDateEnd = null, string origin = null, string destination = null, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling BillingHistoricalvoiceratesOutboundInternationalGet");
            
    
            var path_ = "/api/v1/billing/historicalvoicerates/outbound/international";
    
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
            
            if (currency != null) queryParams.Add("currency", Configuration.ApiClient.ParameterToString(currency)); // query parameter
            if (effectiveDateStart != null) queryParams.Add("effectiveDateStart", Configuration.ApiClient.ParameterToString(effectiveDateStart)); // query parameter
            if (effectiveDateEnd != null) queryParams.Add("effectiveDateEnd", Configuration.ApiClient.ParameterToString(effectiveDateEnd)); // query parameter
            if (origin != null) queryParams.Add("origin", Configuration.ApiClient.ParameterToString(origin)); // query parameter
            if (destination != null) queryParams.Add("destination", Configuration.ApiClient.ParameterToString(destination)); // query parameter
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
                throw new ApiException (statusCode, "Error calling BillingHistoricalvoiceratesOutboundInternationalGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingHistoricalvoiceratesOutboundInternationalGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainVoiceRateResponseItemEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainVoiceRateResponseItemEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainVoiceRateResponseItemEntityListing)));
            
        }
        
        /// <summary>
        /// Get invoices Retrieve a list of invoices stored in the system.
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>DomainInvoiceEntityListing</returns>
        public DomainInvoiceEntityListing BillingInvoicesGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainInvoiceEntityListing> response = BillingInvoicesGetWithHttpInfo(pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get invoices Retrieve a list of invoices stored in the system.
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of DomainInvoiceEntityListing</returns>
        public ApiResponse< DomainInvoiceEntityListing > BillingInvoicesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/billing/invoices";
    
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
                throw new ApiException (statusCode, "Error calling BillingInvoicesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingInvoicesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainInvoiceEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainInvoiceEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainInvoiceEntityListing)));
            
        }
    
        /// <summary>
        /// Get invoices Retrieve a list of invoices stored in the system.
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainInvoiceEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainInvoiceEntityListing> BillingInvoicesGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainInvoiceEntityListing> response = await BillingInvoicesGetAsyncWithHttpInfo(pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get invoices Retrieve a list of invoices stored in the system.
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainInvoiceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainInvoiceEntityListing>> BillingInvoicesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/billing/invoices";
    
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
                throw new ApiException (statusCode, "Error calling BillingInvoicesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingInvoicesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainInvoiceEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainInvoiceEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainInvoiceEntityListing)));
            
        }
        
        /// <summary>
        /// Get invoice. 
        /// </summary>
        /// <param name="invoiceId">Identifies the invoice to be retrieved</param> 
        /// <returns>Invoice</returns>
        public Invoice BillingInvoicesInvoiceidGet (string invoiceId)
        {
             ApiResponse<Invoice> response = BillingInvoicesInvoiceidGetWithHttpInfo(invoiceId);
             return response.Data;
        }

        /// <summary>
        /// Get invoice. 
        /// </summary>
        /// <param name="invoiceId">Identifies the invoice to be retrieved</param> 
        /// <returns>ApiResponse of Invoice</returns>
        public ApiResponse< Invoice > BillingInvoicesInvoiceidGetWithHttpInfo (string invoiceId)
        {
            
            // verify the required parameter 'invoiceId' is set
            if (invoiceId == null) throw new ApiException(400, "Missing required parameter 'invoiceId' when calling BillingInvoicesInvoiceidGet");
            
    
            var path_ = "/api/v1/billing/invoices/{invoiceId}";
    
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
            if (invoiceId != null) pathParams.Add("invoiceId", Configuration.ApiClient.ParameterToString(invoiceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingInvoicesInvoiceidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingInvoicesInvoiceidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Invoice>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Invoice) Configuration.ApiClient.Deserialize(response, typeof(Invoice)));
            
        }
    
        /// <summary>
        /// Get invoice. 
        /// </summary>
        /// <param name="invoiceId">Identifies the invoice to be retrieved</param>
        /// <returns>Task of Invoice</returns>
        public async System.Threading.Tasks.Task<Invoice> BillingInvoicesInvoiceidGetAsync (string invoiceId)
        {
             ApiResponse<Invoice> response = await BillingInvoicesInvoiceidGetAsyncWithHttpInfo(invoiceId);
             return response.Data;

        }

        /// <summary>
        /// Get invoice. 
        /// </summary>
        /// <param name="invoiceId">Identifies the invoice to be retrieved</param>
        /// <returns>Task of ApiResponse (Invoice)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Invoice>> BillingInvoicesInvoiceidGetAsyncWithHttpInfo (string invoiceId)
        {
            // verify the required parameter 'invoiceId' is set
            if (invoiceId == null) throw new ApiException(400, "Missing required parameter 'invoiceId' when calling BillingInvoicesInvoiceidGet");
            
    
            var path_ = "/api/v1/billing/invoices/{invoiceId}";
    
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
            if (invoiceId != null) pathParams.Add("invoiceId", Configuration.ApiClient.ParameterToString(invoiceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingInvoicesInvoiceidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingInvoicesInvoiceidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Invoice>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Invoice) Configuration.ApiClient.Deserialize(response, typeof(Invoice)));
            
        }
        
        /// <summary>
        /// Get invoice PDF. 
        /// </summary>
        /// <param name="invoiceId">Identifies the invoice PDF to be retrieved</param> 
        /// <returns>UrlResponse</returns>
        public UrlResponse BillingInvoicesInvoiceidPdfGet (string invoiceId)
        {
             ApiResponse<UrlResponse> response = BillingInvoicesInvoiceidPdfGetWithHttpInfo(invoiceId);
             return response.Data;
        }

        /// <summary>
        /// Get invoice PDF. 
        /// </summary>
        /// <param name="invoiceId">Identifies the invoice PDF to be retrieved</param> 
        /// <returns>ApiResponse of UrlResponse</returns>
        public ApiResponse< UrlResponse > BillingInvoicesInvoiceidPdfGetWithHttpInfo (string invoiceId)
        {
            
            // verify the required parameter 'invoiceId' is set
            if (invoiceId == null) throw new ApiException(400, "Missing required parameter 'invoiceId' when calling BillingInvoicesInvoiceidPdfGet");
            
    
            var path_ = "/api/v1/billing/invoices/{invoiceId}/pdf";
    
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
            if (invoiceId != null) pathParams.Add("invoiceId", Configuration.ApiClient.ParameterToString(invoiceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingInvoicesInvoiceidPdfGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingInvoicesInvoiceidPdfGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UrlResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UrlResponse) Configuration.ApiClient.Deserialize(response, typeof(UrlResponse)));
            
        }
    
        /// <summary>
        /// Get invoice PDF. 
        /// </summary>
        /// <param name="invoiceId">Identifies the invoice PDF to be retrieved</param>
        /// <returns>Task of UrlResponse</returns>
        public async System.Threading.Tasks.Task<UrlResponse> BillingInvoicesInvoiceidPdfGetAsync (string invoiceId)
        {
             ApiResponse<UrlResponse> response = await BillingInvoicesInvoiceidPdfGetAsyncWithHttpInfo(invoiceId);
             return response.Data;

        }

        /// <summary>
        /// Get invoice PDF. 
        /// </summary>
        /// <param name="invoiceId">Identifies the invoice PDF to be retrieved</param>
        /// <returns>Task of ApiResponse (UrlResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UrlResponse>> BillingInvoicesInvoiceidPdfGetAsyncWithHttpInfo (string invoiceId)
        {
            // verify the required parameter 'invoiceId' is set
            if (invoiceId == null) throw new ApiException(400, "Missing required parameter 'invoiceId' when calling BillingInvoicesInvoiceidPdfGet");
            
    
            var path_ = "/api/v1/billing/invoices/{invoiceId}/pdf";
    
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
            if (invoiceId != null) pathParams.Add("invoiceId", Configuration.ApiClient.ParameterToString(invoiceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingInvoicesInvoiceidPdfGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingInvoicesInvoiceidPdfGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UrlResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UrlResponse) Configuration.ApiClient.Deserialize(response, typeof(UrlResponse)));
            
        }
        
        /// <summary>
        /// Create billing order. 
        /// </summary>
        /// <param name="body">The order to be created</param> 
        /// <returns>Order</returns>
        public Order BillingOrdersPost (Order body = null)
        {
             ApiResponse<Order> response = BillingOrdersPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create billing order. 
        /// </summary>
        /// <param name="body">The order to be created</param> 
        /// <returns>ApiResponse of Order</returns>
        public ApiResponse< Order > BillingOrdersPostWithHttpInfo (Order body = null)
        {
            
    
            var path_ = "/api/v1/billing/orders";
    
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
                throw new ApiException (statusCode, "Error calling BillingOrdersPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingOrdersPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Order>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Order) Configuration.ApiClient.Deserialize(response, typeof(Order)));
            
        }
    
        /// <summary>
        /// Create billing order. 
        /// </summary>
        /// <param name="body">The order to be created</param>
        /// <returns>Task of Order</returns>
        public async System.Threading.Tasks.Task<Order> BillingOrdersPostAsync (Order body = null)
        {
             ApiResponse<Order> response = await BillingOrdersPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create billing order. 
        /// </summary>
        /// <param name="body">The order to be created</param>
        /// <returns>Task of ApiResponse (Order)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Order>> BillingOrdersPostAsyncWithHttpInfo (Order body = null)
        {
            
    
            var path_ = "/api/v1/billing/orders";
    
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
                throw new ApiException (statusCode, "Error calling BillingOrdersPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingOrdersPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Order>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Order) Configuration.ApiClient.Deserialize(response, typeof(Order)));
            
        }
        
        /// <summary>
        /// Get billing periods Retrieve a list of billing periods stored in the system.
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>DomainBillingPeriodEntityListing</returns>
        public DomainBillingPeriodEntityListing BillingPeriodsGet (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainBillingPeriodEntityListing> response = BillingPeriodsGetWithHttpInfo(pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get billing periods Retrieve a list of billing periods stored in the system.
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of DomainBillingPeriodEntityListing</returns>
        public ApiResponse< DomainBillingPeriodEntityListing > BillingPeriodsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/billing/periods";
    
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
                throw new ApiException (statusCode, "Error calling BillingPeriodsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingPeriodsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainBillingPeriodEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainBillingPeriodEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainBillingPeriodEntityListing)));
            
        }
    
        /// <summary>
        /// Get billing periods Retrieve a list of billing periods stored in the system.
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainBillingPeriodEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainBillingPeriodEntityListing> BillingPeriodsGetAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainBillingPeriodEntityListing> response = await BillingPeriodsGetAsyncWithHttpInfo(pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get billing periods Retrieve a list of billing periods stored in the system.
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainBillingPeriodEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainBillingPeriodEntityListing>> BillingPeriodsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var path_ = "/api/v1/billing/periods";
    
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
                throw new ApiException (statusCode, "Error calling BillingPeriodsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingPeriodsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainBillingPeriodEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainBillingPeriodEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainBillingPeriodEntityListing)));
            
        }
        
        /// <summary>
        /// Get products. 
        /// </summary>
        /// <returns>Product</returns>
        public Product BillingProductsGet ()
        {
             ApiResponse<Product> response = BillingProductsGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get products. 
        /// </summary>
        /// <returns>ApiResponse of Product</returns>
        public ApiResponse< Product > BillingProductsGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/billing/products";
    
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
                throw new ApiException (statusCode, "Error calling BillingProductsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingProductsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Product>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Product) Configuration.ApiClient.Deserialize(response, typeof(Product)));
            
        }
    
        /// <summary>
        /// Get products. 
        /// </summary>
        /// <returns>Task of Product</returns>
        public async System.Threading.Tasks.Task<Product> BillingProductsGetAsync ()
        {
             ApiResponse<Product> response = await BillingProductsGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get products. 
        /// </summary>
        /// <returns>Task of ApiResponse (Product)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Product>> BillingProductsGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/billing/products";
    
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
                throw new ApiException (statusCode, "Error calling BillingProductsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingProductsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Product>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Product) Configuration.ApiClient.Deserialize(response, typeof(Product)));
            
        }
        
        /// <summary>
        /// Update products. 
        /// </summary>
        /// <param name="body">The products to activate</param> 
        /// <returns>Product</returns>
        public Product BillingProductsPut (List<Product> body = null)
        {
             ApiResponse<Product> response = BillingProductsPutWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Update products. 
        /// </summary>
        /// <param name="body">The products to activate</param> 
        /// <returns>ApiResponse of Product</returns>
        public ApiResponse< Product > BillingProductsPutWithHttpInfo (List<Product> body = null)
        {
            
    
            var path_ = "/api/v1/billing/products";
    
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
                throw new ApiException (statusCode, "Error calling BillingProductsPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingProductsPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Product>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Product) Configuration.ApiClient.Deserialize(response, typeof(Product)));
            
        }
    
        /// <summary>
        /// Update products. 
        /// </summary>
        /// <param name="body">The products to activate</param>
        /// <returns>Task of Product</returns>
        public async System.Threading.Tasks.Task<Product> BillingProductsPutAsync (List<Product> body = null)
        {
             ApiResponse<Product> response = await BillingProductsPutAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Update products. 
        /// </summary>
        /// <param name="body">The products to activate</param>
        /// <returns>Task of ApiResponse (Product)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Product>> BillingProductsPutAsyncWithHttpInfo (List<Product> body = null)
        {
            
    
            var path_ = "/api/v1/billing/products";
    
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
                throw new ApiException (statusCode, "Error calling BillingProductsPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingProductsPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Product>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Product) Configuration.ApiClient.Deserialize(response, typeof(Product)));
            
        }
        
        /// <summary>
        /// Get billing quotes. 
        /// </summary>
        /// <returns>QuoteListing</returns>
        public QuoteListing BillingQuotesGet ()
        {
             ApiResponse<QuoteListing> response = BillingQuotesGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get billing quotes. 
        /// </summary>
        /// <returns>ApiResponse of QuoteListing</returns>
        public ApiResponse< QuoteListing > BillingQuotesGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/billing/quotes";
    
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
                throw new ApiException (statusCode, "Error calling BillingQuotesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingQuotesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<QuoteListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QuoteListing) Configuration.ApiClient.Deserialize(response, typeof(QuoteListing)));
            
        }
    
        /// <summary>
        /// Get billing quotes. 
        /// </summary>
        /// <returns>Task of QuoteListing</returns>
        public async System.Threading.Tasks.Task<QuoteListing> BillingQuotesGetAsync ()
        {
             ApiResponse<QuoteListing> response = await BillingQuotesGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get billing quotes. 
        /// </summary>
        /// <returns>Task of ApiResponse (QuoteListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QuoteListing>> BillingQuotesGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/billing/quotes";
    
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
                throw new ApiException (statusCode, "Error calling BillingQuotesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingQuotesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<QuoteListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QuoteListing) Configuration.ApiClient.Deserialize(response, typeof(QuoteListing)));
            
        }
        
        /// <summary>
        /// Create billing quote. 
        /// </summary>
        /// <param name="body">The quote to be created</param> 
        /// <returns>Quote</returns>
        public Quote BillingQuotesPost (Quote body = null)
        {
             ApiResponse<Quote> response = BillingQuotesPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create billing quote. 
        /// </summary>
        /// <param name="body">The quote to be created</param> 
        /// <returns>ApiResponse of Quote</returns>
        public ApiResponse< Quote > BillingQuotesPostWithHttpInfo (Quote body = null)
        {
            
    
            var path_ = "/api/v1/billing/quotes";
    
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
                throw new ApiException (statusCode, "Error calling BillingQuotesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingQuotesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Quote>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Quote) Configuration.ApiClient.Deserialize(response, typeof(Quote)));
            
        }
    
        /// <summary>
        /// Create billing quote. 
        /// </summary>
        /// <param name="body">The quote to be created</param>
        /// <returns>Task of Quote</returns>
        public async System.Threading.Tasks.Task<Quote> BillingQuotesPostAsync (Quote body = null)
        {
             ApiResponse<Quote> response = await BillingQuotesPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create billing quote. 
        /// </summary>
        /// <param name="body">The quote to be created</param>
        /// <returns>Task of ApiResponse (Quote)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Quote>> BillingQuotesPostAsyncWithHttpInfo (Quote body = null)
        {
            
    
            var path_ = "/api/v1/billing/quotes";
    
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
                throw new ApiException (statusCode, "Error calling BillingQuotesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingQuotesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Quote>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Quote) Configuration.ApiClient.Deserialize(response, typeof(Quote)));
            
        }
        
        /// <summary>
        /// Get a billing quote 
        /// </summary>
        /// <param name="quoteId">The ID of the quote</param> 
        /// <returns>Quote</returns>
        public Quote BillingQuotesQuoteidGet (string quoteId)
        {
             ApiResponse<Quote> response = BillingQuotesQuoteidGetWithHttpInfo(quoteId);
             return response.Data;
        }

        /// <summary>
        /// Get a billing quote 
        /// </summary>
        /// <param name="quoteId">The ID of the quote</param> 
        /// <returns>ApiResponse of Quote</returns>
        public ApiResponse< Quote > BillingQuotesQuoteidGetWithHttpInfo (string quoteId)
        {
            
            // verify the required parameter 'quoteId' is set
            if (quoteId == null) throw new ApiException(400, "Missing required parameter 'quoteId' when calling BillingQuotesQuoteidGet");
            
    
            var path_ = "/api/v1/billing/quotes/{quoteId}";
    
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
            if (quoteId != null) pathParams.Add("quoteId", Configuration.ApiClient.ParameterToString(quoteId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingQuotesQuoteidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingQuotesQuoteidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Quote>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Quote) Configuration.ApiClient.Deserialize(response, typeof(Quote)));
            
        }
    
        /// <summary>
        /// Get a billing quote 
        /// </summary>
        /// <param name="quoteId">The ID of the quote</param>
        /// <returns>Task of Quote</returns>
        public async System.Threading.Tasks.Task<Quote> BillingQuotesQuoteidGetAsync (string quoteId)
        {
             ApiResponse<Quote> response = await BillingQuotesQuoteidGetAsyncWithHttpInfo(quoteId);
             return response.Data;

        }

        /// <summary>
        /// Get a billing quote 
        /// </summary>
        /// <param name="quoteId">The ID of the quote</param>
        /// <returns>Task of ApiResponse (Quote)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Quote>> BillingQuotesQuoteidGetAsyncWithHttpInfo (string quoteId)
        {
            // verify the required parameter 'quoteId' is set
            if (quoteId == null) throw new ApiException(400, "Missing required parameter 'quoteId' when calling BillingQuotesQuoteidGet");
            
    
            var path_ = "/api/v1/billing/quotes/{quoteId}";
    
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
            if (quoteId != null) pathParams.Add("quoteId", Configuration.ApiClient.ParameterToString(quoteId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingQuotesQuoteidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingQuotesQuoteidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Quote>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Quote) Configuration.ApiClient.Deserialize(response, typeof(Quote)));
            
        }
        
        /// <summary>
        /// Update billing quote 
        /// </summary>
        /// <param name="quoteId">The ID of the quote</param> 
        /// <param name="body">The quote to be updated</param> 
        /// <returns>Quote</returns>
        public Quote BillingQuotesQuoteidPut (string quoteId, Quote body = null)
        {
             ApiResponse<Quote> response = BillingQuotesQuoteidPutWithHttpInfo(quoteId, body);
             return response.Data;
        }

        /// <summary>
        /// Update billing quote 
        /// </summary>
        /// <param name="quoteId">The ID of the quote</param> 
        /// <param name="body">The quote to be updated</param> 
        /// <returns>ApiResponse of Quote</returns>
        public ApiResponse< Quote > BillingQuotesQuoteidPutWithHttpInfo (string quoteId, Quote body = null)
        {
            
            // verify the required parameter 'quoteId' is set
            if (quoteId == null) throw new ApiException(400, "Missing required parameter 'quoteId' when calling BillingQuotesQuoteidPut");
            
    
            var path_ = "/api/v1/billing/quotes/{quoteId}";
    
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
            if (quoteId != null) pathParams.Add("quoteId", Configuration.ApiClient.ParameterToString(quoteId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling BillingQuotesQuoteidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingQuotesQuoteidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Quote>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Quote) Configuration.ApiClient.Deserialize(response, typeof(Quote)));
            
        }
    
        /// <summary>
        /// Update billing quote 
        /// </summary>
        /// <param name="quoteId">The ID of the quote</param>
        /// <param name="body">The quote to be updated</param>
        /// <returns>Task of Quote</returns>
        public async System.Threading.Tasks.Task<Quote> BillingQuotesQuoteidPutAsync (string quoteId, Quote body = null)
        {
             ApiResponse<Quote> response = await BillingQuotesQuoteidPutAsyncWithHttpInfo(quoteId, body);
             return response.Data;

        }

        /// <summary>
        /// Update billing quote 
        /// </summary>
        /// <param name="quoteId">The ID of the quote</param>
        /// <param name="body">The quote to be updated</param>
        /// <returns>Task of ApiResponse (Quote)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Quote>> BillingQuotesQuoteidPutAsyncWithHttpInfo (string quoteId, Quote body = null)
        {
            // verify the required parameter 'quoteId' is set
            if (quoteId == null) throw new ApiException(400, "Missing required parameter 'quoteId' when calling BillingQuotesQuoteidPut");
            
    
            var path_ = "/api/v1/billing/quotes/{quoteId}";
    
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
            if (quoteId != null) pathParams.Add("quoteId", Configuration.ApiClient.ParameterToString(quoteId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling BillingQuotesQuoteidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingQuotesQuoteidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Quote>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Quote) Configuration.ApiClient.Deserialize(response, typeof(Quote)));
            
        }
        
        /// <summary>
        /// Delete billing quote 
        /// </summary>
        /// <param name="quoteId">The ID of the quote</param> 
        /// <returns></returns>
        public void BillingQuotesQuoteidDelete (string quoteId)
        {
             BillingQuotesQuoteidDeleteWithHttpInfo(quoteId);
        }

        /// <summary>
        /// Delete billing quote 
        /// </summary>
        /// <param name="quoteId">The ID of the quote</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> BillingQuotesQuoteidDeleteWithHttpInfo (string quoteId)
        {
            
            // verify the required parameter 'quoteId' is set
            if (quoteId == null) throw new ApiException(400, "Missing required parameter 'quoteId' when calling BillingQuotesQuoteidDelete");
            
    
            var path_ = "/api/v1/billing/quotes/{quoteId}";
    
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
            if (quoteId != null) pathParams.Add("quoteId", Configuration.ApiClient.ParameterToString(quoteId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingQuotesQuoteidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingQuotesQuoteidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete billing quote 
        /// </summary>
        /// <param name="quoteId">The ID of the quote</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task BillingQuotesQuoteidDeleteAsync (string quoteId)
        {
             await BillingQuotesQuoteidDeleteAsyncWithHttpInfo(quoteId);

        }

        /// <summary>
        /// Delete billing quote 
        /// </summary>
        /// <param name="quoteId">The ID of the quote</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> BillingQuotesQuoteidDeleteAsyncWithHttpInfo (string quoteId)
        {
            // verify the required parameter 'quoteId' is set
            if (quoteId == null) throw new ApiException(400, "Missing required parameter 'quoteId' when calling BillingQuotesQuoteidDelete");
            
    
            var path_ = "/api/v1/billing/quotes/{quoteId}";
    
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
            if (quoteId != null) pathParams.Add("quoteId", Configuration.ApiClient.ParameterToString(quoteId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingQuotesQuoteidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingQuotesQuoteidDelete: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get billing rates Retrieve a list of billing rates stored in the system.
        /// </summary>
        /// <param name="chargeType">Filter rates by charge type. Examples are Usage, Recurring, or OneTime.</param> 
        /// <returns>List&lt;Rate&gt;</returns>
        public List<Rate> BillingRatesGet (string chargeType = null)
        {
             ApiResponse<List<Rate>> response = BillingRatesGetWithHttpInfo(chargeType);
             return response.Data;
        }

        /// <summary>
        /// Get billing rates Retrieve a list of billing rates stored in the system.
        /// </summary>
        /// <param name="chargeType">Filter rates by charge type. Examples are Usage, Recurring, or OneTime.</param> 
        /// <returns>ApiResponse of List&lt;Rate&gt;</returns>
        public ApiResponse< List<Rate> > BillingRatesGetWithHttpInfo (string chargeType = null)
        {
            
    
            var path_ = "/api/v1/billing/rates";
    
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
            
            if (chargeType != null) queryParams.Add("chargeType", Configuration.ApiClient.ParameterToString(chargeType)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingRatesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingRatesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<Rate>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Rate>) Configuration.ApiClient.Deserialize(response, typeof(List<Rate>)));
            
        }
    
        /// <summary>
        /// Get billing rates Retrieve a list of billing rates stored in the system.
        /// </summary>
        /// <param name="chargeType">Filter rates by charge type. Examples are Usage, Recurring, or OneTime.</param>
        /// <returns>Task of List&lt;Rate&gt;</returns>
        public async System.Threading.Tasks.Task<List<Rate>> BillingRatesGetAsync (string chargeType = null)
        {
             ApiResponse<List<Rate>> response = await BillingRatesGetAsyncWithHttpInfo(chargeType);
             return response.Data;

        }

        /// <summary>
        /// Get billing rates Retrieve a list of billing rates stored in the system.
        /// </summary>
        /// <param name="chargeType">Filter rates by charge type. Examples are Usage, Recurring, or OneTime.</param>
        /// <returns>Task of ApiResponse (List&lt;Rate&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Rate>>> BillingRatesGetAsyncWithHttpInfo (string chargeType = null)
        {
            
    
            var path_ = "/api/v1/billing/rates";
    
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
            
            if (chargeType != null) queryParams.Add("chargeType", Configuration.ApiClient.ParameterToString(chargeType)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingRatesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingRatesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<Rate>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Rate>) Configuration.ApiClient.Deserialize(response, typeof(List<Rate>)));
            
        }
        
        /// <summary>
        /// Get rate. 
        /// </summary>
        /// <param name="rateId">Identifies the rate to be retrieved</param> 
        /// <returns>Rate</returns>
        public Rate BillingRatesRateidGet (string rateId)
        {
             ApiResponse<Rate> response = BillingRatesRateidGetWithHttpInfo(rateId);
             return response.Data;
        }

        /// <summary>
        /// Get rate. 
        /// </summary>
        /// <param name="rateId">Identifies the rate to be retrieved</param> 
        /// <returns>ApiResponse of Rate</returns>
        public ApiResponse< Rate > BillingRatesRateidGetWithHttpInfo (string rateId)
        {
            
            // verify the required parameter 'rateId' is set
            if (rateId == null) throw new ApiException(400, "Missing required parameter 'rateId' when calling BillingRatesRateidGet");
            
    
            var path_ = "/api/v1/billing/rates/{rateId}";
    
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
            if (rateId != null) pathParams.Add("rateId", Configuration.ApiClient.ParameterToString(rateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingRatesRateidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingRatesRateidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Rate>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Rate) Configuration.ApiClient.Deserialize(response, typeof(Rate)));
            
        }
    
        /// <summary>
        /// Get rate. 
        /// </summary>
        /// <param name="rateId">Identifies the rate to be retrieved</param>
        /// <returns>Task of Rate</returns>
        public async System.Threading.Tasks.Task<Rate> BillingRatesRateidGetAsync (string rateId)
        {
             ApiResponse<Rate> response = await BillingRatesRateidGetAsyncWithHttpInfo(rateId);
             return response.Data;

        }

        /// <summary>
        /// Get rate. 
        /// </summary>
        /// <param name="rateId">Identifies the rate to be retrieved</param>
        /// <returns>Task of ApiResponse (Rate)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Rate>> BillingRatesRateidGetAsyncWithHttpInfo (string rateId)
        {
            // verify the required parameter 'rateId' is set
            if (rateId == null) throw new ApiException(400, "Missing required parameter 'rateId' when calling BillingRatesRateidGet");
            
    
            var path_ = "/api/v1/billing/rates/{rateId}";
    
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
            if (rateId != null) pathParams.Add("rateId", Configuration.ApiClient.ParameterToString(rateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingRatesRateidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingRatesRateidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Rate>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Rate) Configuration.ApiClient.Deserialize(response, typeof(Rate)));
            
        }
        
        /// <summary>
        /// Get billable usage data report CSV. 
        /// </summary>
        /// <param name="reportId">Identifies the report CSV to be retrieved</param> 
        /// <returns>UrlResponse</returns>
        public UrlResponse BillingReportsBillableusagedataReportidCsvGet (string reportId)
        {
             ApiResponse<UrlResponse> response = BillingReportsBillableusagedataReportidCsvGetWithHttpInfo(reportId);
             return response.Data;
        }

        /// <summary>
        /// Get billable usage data report CSV. 
        /// </summary>
        /// <param name="reportId">Identifies the report CSV to be retrieved</param> 
        /// <returns>ApiResponse of UrlResponse</returns>
        public ApiResponse< UrlResponse > BillingReportsBillableusagedataReportidCsvGetWithHttpInfo (string reportId)
        {
            
            // verify the required parameter 'reportId' is set
            if (reportId == null) throw new ApiException(400, "Missing required parameter 'reportId' when calling BillingReportsBillableusagedataReportidCsvGet");
            
    
            var path_ = "/api/v1/billing/reports/billableusagedata/{reportId}/csv";
    
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
            if (reportId != null) pathParams.Add("reportId", Configuration.ApiClient.ParameterToString(reportId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingReportsBillableusagedataReportidCsvGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingReportsBillableusagedataReportidCsvGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UrlResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UrlResponse) Configuration.ApiClient.Deserialize(response, typeof(UrlResponse)));
            
        }
    
        /// <summary>
        /// Get billable usage data report CSV. 
        /// </summary>
        /// <param name="reportId">Identifies the report CSV to be retrieved</param>
        /// <returns>Task of UrlResponse</returns>
        public async System.Threading.Tasks.Task<UrlResponse> BillingReportsBillableusagedataReportidCsvGetAsync (string reportId)
        {
             ApiResponse<UrlResponse> response = await BillingReportsBillableusagedataReportidCsvGetAsyncWithHttpInfo(reportId);
             return response.Data;

        }

        /// <summary>
        /// Get billable usage data report CSV. 
        /// </summary>
        /// <param name="reportId">Identifies the report CSV to be retrieved</param>
        /// <returns>Task of ApiResponse (UrlResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UrlResponse>> BillingReportsBillableusagedataReportidCsvGetAsyncWithHttpInfo (string reportId)
        {
            // verify the required parameter 'reportId' is set
            if (reportId == null) throw new ApiException(400, "Missing required parameter 'reportId' when calling BillingReportsBillableusagedataReportidCsvGet");
            
    
            var path_ = "/api/v1/billing/reports/billableusagedata/{reportId}/csv";
    
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
            if (reportId != null) pathParams.Add("reportId", Configuration.ApiClient.ParameterToString(reportId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingReportsBillableusagedataReportidCsvGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingReportsBillableusagedataReportidCsvGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UrlResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UrlResponse) Configuration.ApiClient.Deserialize(response, typeof(UrlResponse)));
            
        }
        
        /// <summary>
        /// Get concurrent usage data report CSV. 
        /// </summary>
        /// <param name="reportId">Identifies the report CSV to be retrieved</param> 
        /// <returns>UrlResponse</returns>
        public UrlResponse BillingReportsConcurrentusagedataReportidCsvGet (string reportId)
        {
             ApiResponse<UrlResponse> response = BillingReportsConcurrentusagedataReportidCsvGetWithHttpInfo(reportId);
             return response.Data;
        }

        /// <summary>
        /// Get concurrent usage data report CSV. 
        /// </summary>
        /// <param name="reportId">Identifies the report CSV to be retrieved</param> 
        /// <returns>ApiResponse of UrlResponse</returns>
        public ApiResponse< UrlResponse > BillingReportsConcurrentusagedataReportidCsvGetWithHttpInfo (string reportId)
        {
            
            // verify the required parameter 'reportId' is set
            if (reportId == null) throw new ApiException(400, "Missing required parameter 'reportId' when calling BillingReportsConcurrentusagedataReportidCsvGet");
            
    
            var path_ = "/api/v1/billing/reports/concurrentusagedata/{reportId}/csv";
    
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
            if (reportId != null) pathParams.Add("reportId", Configuration.ApiClient.ParameterToString(reportId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingReportsConcurrentusagedataReportidCsvGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingReportsConcurrentusagedataReportidCsvGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UrlResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UrlResponse) Configuration.ApiClient.Deserialize(response, typeof(UrlResponse)));
            
        }
    
        /// <summary>
        /// Get concurrent usage data report CSV. 
        /// </summary>
        /// <param name="reportId">Identifies the report CSV to be retrieved</param>
        /// <returns>Task of UrlResponse</returns>
        public async System.Threading.Tasks.Task<UrlResponse> BillingReportsConcurrentusagedataReportidCsvGetAsync (string reportId)
        {
             ApiResponse<UrlResponse> response = await BillingReportsConcurrentusagedataReportidCsvGetAsyncWithHttpInfo(reportId);
             return response.Data;

        }

        /// <summary>
        /// Get concurrent usage data report CSV. 
        /// </summary>
        /// <param name="reportId">Identifies the report CSV to be retrieved</param>
        /// <returns>Task of ApiResponse (UrlResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UrlResponse>> BillingReportsConcurrentusagedataReportidCsvGetAsyncWithHttpInfo (string reportId)
        {
            // verify the required parameter 'reportId' is set
            if (reportId == null) throw new ApiException(400, "Missing required parameter 'reportId' when calling BillingReportsConcurrentusagedataReportidCsvGet");
            
    
            var path_ = "/api/v1/billing/reports/concurrentusagedata/{reportId}/csv";
    
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
            if (reportId != null) pathParams.Add("reportId", Configuration.ApiClient.ParameterToString(reportId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingReportsConcurrentusagedataReportidCsvGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingReportsConcurrentusagedataReportidCsvGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UrlResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UrlResponse) Configuration.ApiClient.Deserialize(response, typeof(UrlResponse)));
            
        }
        
        /// <summary>
        /// Creates a billing snapshot Creates a billing snapshot which is used to determine usage counts for a billing period.
        /// </summary>
        /// <returns></returns>
        public void BillingSnapshotsPost ()
        {
             BillingSnapshotsPostWithHttpInfo();
        }

        /// <summary>
        /// Creates a billing snapshot Creates a billing snapshot which is used to determine usage counts for a billing period.
        /// </summary>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> BillingSnapshotsPostWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/billing/snapshots";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling BillingSnapshotsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingSnapshotsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Creates a billing snapshot Creates a billing snapshot which is used to determine usage counts for a billing period.
        /// </summary>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task BillingSnapshotsPostAsync ()
        {
             await BillingSnapshotsPostAsyncWithHttpInfo();

        }

        /// <summary>
        /// Creates a billing snapshot Creates a billing snapshot which is used to determine usage counts for a billing period.
        /// </summary>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> BillingSnapshotsPostAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/billing/snapshots";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling BillingSnapshotsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingSnapshotsPost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get third party accounts Retrieve a list of third party accounts stored in the back-end system.
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="search">Search for accounts with this text</param> 
        /// <returns>DomainThirdPartyAccountEntityListing</returns>
        public DomainThirdPartyAccountEntityListing BillingThirdpartyaccountsGet (int? pageSize = null, int? pageNumber = null, string search = null)
        {
             ApiResponse<DomainThirdPartyAccountEntityListing> response = BillingThirdpartyaccountsGetWithHttpInfo(pageSize, pageNumber, search);
             return response.Data;
        }

        /// <summary>
        /// Get third party accounts Retrieve a list of third party accounts stored in the back-end system.
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="search">Search for accounts with this text</param> 
        /// <returns>ApiResponse of DomainThirdPartyAccountEntityListing</returns>
        public ApiResponse< DomainThirdPartyAccountEntityListing > BillingThirdpartyaccountsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string search = null)
        {
            
    
            var path_ = "/api/v1/billing/thirdpartyaccounts";
    
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
            if (search != null) queryParams.Add("search", Configuration.ApiClient.ParameterToString(search)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingThirdpartyaccountsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingThirdpartyaccountsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainThirdPartyAccountEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainThirdPartyAccountEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainThirdPartyAccountEntityListing)));
            
        }
    
        /// <summary>
        /// Get third party accounts Retrieve a list of third party accounts stored in the back-end system.
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="search">Search for accounts with this text</param>
        /// <returns>Task of DomainThirdPartyAccountEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainThirdPartyAccountEntityListing> BillingThirdpartyaccountsGetAsync (int? pageSize = null, int? pageNumber = null, string search = null)
        {
             ApiResponse<DomainThirdPartyAccountEntityListing> response = await BillingThirdpartyaccountsGetAsyncWithHttpInfo(pageSize, pageNumber, search);
             return response.Data;

        }

        /// <summary>
        /// Get third party accounts Retrieve a list of third party accounts stored in the back-end system.
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="search">Search for accounts with this text</param>
        /// <returns>Task of ApiResponse (DomainThirdPartyAccountEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainThirdPartyAccountEntityListing>> BillingThirdpartyaccountsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string search = null)
        {
            
    
            var path_ = "/api/v1/billing/thirdpartyaccounts";
    
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
            if (search != null) queryParams.Add("search", Configuration.ApiClient.ParameterToString(search)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingThirdpartyaccountsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingThirdpartyaccountsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainThirdPartyAccountEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainThirdPartyAccountEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainThirdPartyAccountEntityListing)));
            
        }
        
        /// <summary>
        /// Get third party billing account. 
        /// </summary>
        /// <param name="accountId">Identifies the third party account to be retrieved</param> 
        /// <returns>ThirdPartyAccount</returns>
        public ThirdPartyAccount BillingThirdpartyaccountsAccountidGet (string accountId)
        {
             ApiResponse<ThirdPartyAccount> response = BillingThirdpartyaccountsAccountidGetWithHttpInfo(accountId);
             return response.Data;
        }

        /// <summary>
        /// Get third party billing account. 
        /// </summary>
        /// <param name="accountId">Identifies the third party account to be retrieved</param> 
        /// <returns>ApiResponse of ThirdPartyAccount</returns>
        public ApiResponse< ThirdPartyAccount > BillingThirdpartyaccountsAccountidGetWithHttpInfo (string accountId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling BillingThirdpartyaccountsAccountidGet");
            
    
            var path_ = "/api/v1/billing/thirdpartyaccounts/{accountId}";
    
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
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingThirdpartyaccountsAccountidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingThirdpartyaccountsAccountidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ThirdPartyAccount>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ThirdPartyAccount) Configuration.ApiClient.Deserialize(response, typeof(ThirdPartyAccount)));
            
        }
    
        /// <summary>
        /// Get third party billing account. 
        /// </summary>
        /// <param name="accountId">Identifies the third party account to be retrieved</param>
        /// <returns>Task of ThirdPartyAccount</returns>
        public async System.Threading.Tasks.Task<ThirdPartyAccount> BillingThirdpartyaccountsAccountidGetAsync (string accountId)
        {
             ApiResponse<ThirdPartyAccount> response = await BillingThirdpartyaccountsAccountidGetAsyncWithHttpInfo(accountId);
             return response.Data;

        }

        /// <summary>
        /// Get third party billing account. 
        /// </summary>
        /// <param name="accountId">Identifies the third party account to be retrieved</param>
        /// <returns>Task of ApiResponse (ThirdPartyAccount)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ThirdPartyAccount>> BillingThirdpartyaccountsAccountidGetAsyncWithHttpInfo (string accountId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling BillingThirdpartyaccountsAccountidGet");
            
    
            var path_ = "/api/v1/billing/thirdpartyaccounts/{accountId}";
    
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
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingThirdpartyaccountsAccountidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingThirdpartyaccountsAccountidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ThirdPartyAccount>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ThirdPartyAccount) Configuration.ApiClient.Deserialize(response, typeof(ThirdPartyAccount)));
            
        }
        
        /// <summary>
        /// Get third party subscriptions Retrieve a list of third party subscriptions stored in the back-end system.
        /// </summary>
        /// <param name="accountId">Identifies the third party account to be retrieved</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>DomainThirdPartySubscriptionEntityListing</returns>
        public DomainThirdPartySubscriptionEntityListing BillingThirdpartyaccountsAccountidSubscriptionsGet (string accountId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainThirdPartySubscriptionEntityListing> response = BillingThirdpartyaccountsAccountidSubscriptionsGetWithHttpInfo(accountId, pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get third party subscriptions Retrieve a list of third party subscriptions stored in the back-end system.
        /// </summary>
        /// <param name="accountId">Identifies the third party account to be retrieved</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of DomainThirdPartySubscriptionEntityListing</returns>
        public ApiResponse< DomainThirdPartySubscriptionEntityListing > BillingThirdpartyaccountsAccountidSubscriptionsGetWithHttpInfo (string accountId, int? pageSize = null, int? pageNumber = null)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling BillingThirdpartyaccountsAccountidSubscriptionsGet");
            
    
            var path_ = "/api/v1/billing/thirdpartyaccounts/{accountId}/subscriptions";
    
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
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
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
                throw new ApiException (statusCode, "Error calling BillingThirdpartyaccountsAccountidSubscriptionsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingThirdpartyaccountsAccountidSubscriptionsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainThirdPartySubscriptionEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainThirdPartySubscriptionEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainThirdPartySubscriptionEntityListing)));
            
        }
    
        /// <summary>
        /// Get third party subscriptions Retrieve a list of third party subscriptions stored in the back-end system.
        /// </summary>
        /// <param name="accountId">Identifies the third party account to be retrieved</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainThirdPartySubscriptionEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainThirdPartySubscriptionEntityListing> BillingThirdpartyaccountsAccountidSubscriptionsGetAsync (string accountId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainThirdPartySubscriptionEntityListing> response = await BillingThirdpartyaccountsAccountidSubscriptionsGetAsyncWithHttpInfo(accountId, pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get third party subscriptions Retrieve a list of third party subscriptions stored in the back-end system.
        /// </summary>
        /// <param name="accountId">Identifies the third party account to be retrieved</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainThirdPartySubscriptionEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainThirdPartySubscriptionEntityListing>> BillingThirdpartyaccountsAccountidSubscriptionsGetAsyncWithHttpInfo (string accountId, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling BillingThirdpartyaccountsAccountidSubscriptionsGet");
            
    
            var path_ = "/api/v1/billing/thirdpartyaccounts/{accountId}/subscriptions";
    
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
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
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
                throw new ApiException (statusCode, "Error calling BillingThirdpartyaccountsAccountidSubscriptionsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingThirdpartyaccountsAccountidSubscriptionsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainThirdPartySubscriptionEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainThirdPartySubscriptionEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainThirdPartySubscriptionEntityListing)));
            
        }
        
        /// <summary>
        /// Get third party billing subscription. 
        /// </summary>
        /// <param name="accountId">Identifies the third party account to be retrieved</param> 
        /// <param name="subscriptionId">Identifies the third party subscription to be retrieved</param> 
        /// <returns>ThirdPartySubscription</returns>
        public ThirdPartySubscription BillingThirdpartyaccountsAccountidSubscriptionsSubscriptionidGet (string accountId, string subscriptionId)
        {
             ApiResponse<ThirdPartySubscription> response = BillingThirdpartyaccountsAccountidSubscriptionsSubscriptionidGetWithHttpInfo(accountId, subscriptionId);
             return response.Data;
        }

        /// <summary>
        /// Get third party billing subscription. 
        /// </summary>
        /// <param name="accountId">Identifies the third party account to be retrieved</param> 
        /// <param name="subscriptionId">Identifies the third party subscription to be retrieved</param> 
        /// <returns>ApiResponse of ThirdPartySubscription</returns>
        public ApiResponse< ThirdPartySubscription > BillingThirdpartyaccountsAccountidSubscriptionsSubscriptionidGetWithHttpInfo (string accountId, string subscriptionId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling BillingThirdpartyaccountsAccountidSubscriptionsSubscriptionidGet");
            
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null) throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling BillingThirdpartyaccountsAccountidSubscriptionsSubscriptionidGet");
            
    
            var path_ = "/api/v1/billing/thirdpartyaccounts/{accountId}/subscriptions/{subscriptionId}";
    
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
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (subscriptionId != null) pathParams.Add("subscriptionId", Configuration.ApiClient.ParameterToString(subscriptionId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingThirdpartyaccountsAccountidSubscriptionsSubscriptionidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingThirdpartyaccountsAccountidSubscriptionsSubscriptionidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ThirdPartySubscription>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ThirdPartySubscription) Configuration.ApiClient.Deserialize(response, typeof(ThirdPartySubscription)));
            
        }
    
        /// <summary>
        /// Get third party billing subscription. 
        /// </summary>
        /// <param name="accountId">Identifies the third party account to be retrieved</param>
        /// <param name="subscriptionId">Identifies the third party subscription to be retrieved</param>
        /// <returns>Task of ThirdPartySubscription</returns>
        public async System.Threading.Tasks.Task<ThirdPartySubscription> BillingThirdpartyaccountsAccountidSubscriptionsSubscriptionidGetAsync (string accountId, string subscriptionId)
        {
             ApiResponse<ThirdPartySubscription> response = await BillingThirdpartyaccountsAccountidSubscriptionsSubscriptionidGetAsyncWithHttpInfo(accountId, subscriptionId);
             return response.Data;

        }

        /// <summary>
        /// Get third party billing subscription. 
        /// </summary>
        /// <param name="accountId">Identifies the third party account to be retrieved</param>
        /// <param name="subscriptionId">Identifies the third party subscription to be retrieved</param>
        /// <returns>Task of ApiResponse (ThirdPartySubscription)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ThirdPartySubscription>> BillingThirdpartyaccountsAccountidSubscriptionsSubscriptionidGetAsyncWithHttpInfo (string accountId, string subscriptionId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling BillingThirdpartyaccountsAccountidSubscriptionsSubscriptionidGet");
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null) throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling BillingThirdpartyaccountsAccountidSubscriptionsSubscriptionidGet");
            
    
            var path_ = "/api/v1/billing/thirdpartyaccounts/{accountId}/subscriptions/{subscriptionId}";
    
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
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (subscriptionId != null) pathParams.Add("subscriptionId", Configuration.ApiClient.ParameterToString(subscriptionId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingThirdpartyaccountsAccountidSubscriptionsSubscriptionidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingThirdpartyaccountsAccountidSubscriptionsSubscriptionidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ThirdPartySubscription>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ThirdPartySubscription) Configuration.ApiClient.Deserialize(response, typeof(ThirdPartySubscription)));
            
        }
        
        /// <summary>
        /// Update billing voice rate Update a billing voice rate currently stored in the system.
        /// </summary>
        /// <param name="body">The voice rate to be created</param> 
        /// <returns>VoiceRateUpdate</returns>
        public VoiceRateUpdate BillingVoiceratePut (VoiceRateUpdate body = null)
        {
             ApiResponse<VoiceRateUpdate> response = BillingVoiceratePutWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Update billing voice rate Update a billing voice rate currently stored in the system.
        /// </summary>
        /// <param name="body">The voice rate to be created</param> 
        /// <returns>ApiResponse of VoiceRateUpdate</returns>
        public ApiResponse< VoiceRateUpdate > BillingVoiceratePutWithHttpInfo (VoiceRateUpdate body = null)
        {
            
    
            var path_ = "/api/v1/billing/voicerate";
    
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
                throw new ApiException (statusCode, "Error calling BillingVoiceratePut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingVoiceratePut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<VoiceRateUpdate>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoiceRateUpdate) Configuration.ApiClient.Deserialize(response, typeof(VoiceRateUpdate)));
            
        }
    
        /// <summary>
        /// Update billing voice rate Update a billing voice rate currently stored in the system.
        /// </summary>
        /// <param name="body">The voice rate to be created</param>
        /// <returns>Task of VoiceRateUpdate</returns>
        public async System.Threading.Tasks.Task<VoiceRateUpdate> BillingVoiceratePutAsync (VoiceRateUpdate body = null)
        {
             ApiResponse<VoiceRateUpdate> response = await BillingVoiceratePutAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Update billing voice rate Update a billing voice rate currently stored in the system.
        /// </summary>
        /// <param name="body">The voice rate to be created</param>
        /// <returns>Task of ApiResponse (VoiceRateUpdate)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoiceRateUpdate>> BillingVoiceratePutAsyncWithHttpInfo (VoiceRateUpdate body = null)
        {
            
    
            var path_ = "/api/v1/billing/voicerate";
    
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
                throw new ApiException (statusCode, "Error calling BillingVoiceratePut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingVoiceratePut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<VoiceRateUpdate>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoiceRateUpdate) Configuration.ApiClient.Deserialize(response, typeof(VoiceRateUpdate)));
            
        }
        
        /// <summary>
        /// Delete billing voice rate Delete a pending billing voice rate currently stored in the system.
        /// </summary>
        /// <param name="currency">The currency of the voice rate</param> 
        /// <param name="amendmentId">The amendment Id of the voice rate</param> 
        /// <returns></returns>
        public void BillingVoicerateCurrencyAmendmentidDelete (string currency, string amendmentId)
        {
             BillingVoicerateCurrencyAmendmentidDeleteWithHttpInfo(currency, amendmentId);
        }

        /// <summary>
        /// Delete billing voice rate Delete a pending billing voice rate currently stored in the system.
        /// </summary>
        /// <param name="currency">The currency of the voice rate</param> 
        /// <param name="amendmentId">The amendment Id of the voice rate</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> BillingVoicerateCurrencyAmendmentidDeleteWithHttpInfo (string currency, string amendmentId)
        {
            
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling BillingVoicerateCurrencyAmendmentidDelete");
            
            // verify the required parameter 'amendmentId' is set
            if (amendmentId == null) throw new ApiException(400, "Missing required parameter 'amendmentId' when calling BillingVoicerateCurrencyAmendmentidDelete");
            
    
            var path_ = "/api/v1/billing/voicerate/{currency}/{amendmentId}";
    
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
            if (currency != null) pathParams.Add("currency", Configuration.ApiClient.ParameterToString(currency)); // path parameter
            if (amendmentId != null) pathParams.Add("amendmentId", Configuration.ApiClient.ParameterToString(amendmentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingVoicerateCurrencyAmendmentidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingVoicerateCurrencyAmendmentidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete billing voice rate Delete a pending billing voice rate currently stored in the system.
        /// </summary>
        /// <param name="currency">The currency of the voice rate</param>
        /// <param name="amendmentId">The amendment Id of the voice rate</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task BillingVoicerateCurrencyAmendmentidDeleteAsync (string currency, string amendmentId)
        {
             await BillingVoicerateCurrencyAmendmentidDeleteAsyncWithHttpInfo(currency, amendmentId);

        }

        /// <summary>
        /// Delete billing voice rate Delete a pending billing voice rate currently stored in the system.
        /// </summary>
        /// <param name="currency">The currency of the voice rate</param>
        /// <param name="amendmentId">The amendment Id of the voice rate</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> BillingVoicerateCurrencyAmendmentidDeleteAsyncWithHttpInfo (string currency, string amendmentId)
        {
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling BillingVoicerateCurrencyAmendmentidDelete");
            // verify the required parameter 'amendmentId' is set
            if (amendmentId == null) throw new ApiException(400, "Missing required parameter 'amendmentId' when calling BillingVoicerateCurrencyAmendmentidDelete");
            
    
            var path_ = "/api/v1/billing/voicerate/{currency}/{amendmentId}";
    
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
            if (currency != null) pathParams.Add("currency", Configuration.ApiClient.ParameterToString(currency)); // path parameter
            if (amendmentId != null) pathParams.Add("amendmentId", Configuration.ApiClient.ParameterToString(amendmentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling BillingVoicerateCurrencyAmendmentidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingVoicerateCurrencyAmendmentidDelete: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get current extended billing voice rates Retrieve a list of current extended billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param> 
        /// <param name="areaCode">Filter voice rates by area code.</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>VoiceRateInternationalEntityListing</returns>
        public VoiceRateInternationalEntityListing BillingVoiceratesExtendedGet (string currency, string areaCode = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<VoiceRateInternationalEntityListing> response = BillingVoiceratesExtendedGetWithHttpInfo(currency, areaCode, pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get current extended billing voice rates Retrieve a list of current extended billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param> 
        /// <param name="areaCode">Filter voice rates by area code.</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of VoiceRateInternationalEntityListing</returns>
        public ApiResponse< VoiceRateInternationalEntityListing > BillingVoiceratesExtendedGetWithHttpInfo (string currency, string areaCode = null, int? pageSize = null, int? pageNumber = null)
        {
            
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling BillingVoiceratesExtendedGet");
            
    
            var path_ = "/api/v1/billing/voicerates/extended";
    
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
            
            if (currency != null) queryParams.Add("currency", Configuration.ApiClient.ParameterToString(currency)); // query parameter
            if (areaCode != null) queryParams.Add("areaCode", Configuration.ApiClient.ParameterToString(areaCode)); // query parameter
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
                throw new ApiException (statusCode, "Error calling BillingVoiceratesExtendedGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingVoiceratesExtendedGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<VoiceRateInternationalEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoiceRateInternationalEntityListing) Configuration.ApiClient.Deserialize(response, typeof(VoiceRateInternationalEntityListing)));
            
        }
    
        /// <summary>
        /// Get current extended billing voice rates Retrieve a list of current extended billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="areaCode">Filter voice rates by area code.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of VoiceRateInternationalEntityListing</returns>
        public async System.Threading.Tasks.Task<VoiceRateInternationalEntityListing> BillingVoiceratesExtendedGetAsync (string currency, string areaCode = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<VoiceRateInternationalEntityListing> response = await BillingVoiceratesExtendedGetAsyncWithHttpInfo(currency, areaCode, pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get current extended billing voice rates Retrieve a list of current extended billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="areaCode">Filter voice rates by area code.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (VoiceRateInternationalEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoiceRateInternationalEntityListing>> BillingVoiceratesExtendedGetAsyncWithHttpInfo (string currency, string areaCode = null, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling BillingVoiceratesExtendedGet");
            
    
            var path_ = "/api/v1/billing/voicerates/extended";
    
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
            
            if (currency != null) queryParams.Add("currency", Configuration.ApiClient.ParameterToString(currency)); // query parameter
            if (areaCode != null) queryParams.Add("areaCode", Configuration.ApiClient.ParameterToString(areaCode)); // query parameter
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
                throw new ApiException (statusCode, "Error calling BillingVoiceratesExtendedGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingVoiceratesExtendedGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<VoiceRateInternationalEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoiceRateInternationalEntityListing) Configuration.ApiClient.Deserialize(response, typeof(VoiceRateInternationalEntityListing)));
            
        }
        
        /// <summary>
        /// Get current inbound billing voice rates Retrieve a list of current inbound billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param> 
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param> 
        /// <returns>List&lt;VoiceRate&gt;</returns>
        public List<VoiceRate> BillingVoiceratesInboundGet (string currency, string type = null)
        {
             ApiResponse<List<VoiceRate>> response = BillingVoiceratesInboundGetWithHttpInfo(currency, type);
             return response.Data;
        }

        /// <summary>
        /// Get current inbound billing voice rates Retrieve a list of current inbound billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param> 
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param> 
        /// <returns>ApiResponse of List&lt;VoiceRate&gt;</returns>
        public ApiResponse< List<VoiceRate> > BillingVoiceratesInboundGetWithHttpInfo (string currency, string type = null)
        {
            
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling BillingVoiceratesInboundGet");
            
    
            var path_ = "/api/v1/billing/voicerates/inbound";
    
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
            
            if (currency != null) queryParams.Add("currency", Configuration.ApiClient.ParameterToString(currency)); // query parameter
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
                throw new ApiException (statusCode, "Error calling BillingVoiceratesInboundGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingVoiceratesInboundGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<VoiceRate>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<VoiceRate>) Configuration.ApiClient.Deserialize(response, typeof(List<VoiceRate>)));
            
        }
    
        /// <summary>
        /// Get current inbound billing voice rates Retrieve a list of current inbound billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param>
        /// <returns>Task of List&lt;VoiceRate&gt;</returns>
        public async System.Threading.Tasks.Task<List<VoiceRate>> BillingVoiceratesInboundGetAsync (string currency, string type = null)
        {
             ApiResponse<List<VoiceRate>> response = await BillingVoiceratesInboundGetAsyncWithHttpInfo(currency, type);
             return response.Data;

        }

        /// <summary>
        /// Get current inbound billing voice rates Retrieve a list of current inbound billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param>
        /// <returns>Task of ApiResponse (List&lt;VoiceRate&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<VoiceRate>>> BillingVoiceratesInboundGetAsyncWithHttpInfo (string currency, string type = null)
        {
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling BillingVoiceratesInboundGet");
            
    
            var path_ = "/api/v1/billing/voicerates/inbound";
    
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
            
            if (currency != null) queryParams.Add("currency", Configuration.ApiClient.ParameterToString(currency)); // query parameter
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
                throw new ApiException (statusCode, "Error calling BillingVoiceratesInboundGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingVoiceratesInboundGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<VoiceRate>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<VoiceRate>) Configuration.ApiClient.Deserialize(response, typeof(List<VoiceRate>)));
            
        }
        
        /// <summary>
        /// Get current outbound domestic billing voice rates Retrieve a list of current outbound domestic billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param> 
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param> 
        /// <returns>List&lt;VoiceRate&gt;</returns>
        public List<VoiceRate> BillingVoiceratesOutboundDomesticGet (string currency, string type = null)
        {
             ApiResponse<List<VoiceRate>> response = BillingVoiceratesOutboundDomesticGetWithHttpInfo(currency, type);
             return response.Data;
        }

        /// <summary>
        /// Get current outbound domestic billing voice rates Retrieve a list of current outbound domestic billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param> 
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param> 
        /// <returns>ApiResponse of List&lt;VoiceRate&gt;</returns>
        public ApiResponse< List<VoiceRate> > BillingVoiceratesOutboundDomesticGetWithHttpInfo (string currency, string type = null)
        {
            
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling BillingVoiceratesOutboundDomesticGet");
            
    
            var path_ = "/api/v1/billing/voicerates/outbound/domestic";
    
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
            
            if (currency != null) queryParams.Add("currency", Configuration.ApiClient.ParameterToString(currency)); // query parameter
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
                throw new ApiException (statusCode, "Error calling BillingVoiceratesOutboundDomesticGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingVoiceratesOutboundDomesticGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<VoiceRate>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<VoiceRate>) Configuration.ApiClient.Deserialize(response, typeof(List<VoiceRate>)));
            
        }
    
        /// <summary>
        /// Get current outbound domestic billing voice rates Retrieve a list of current outbound domestic billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param>
        /// <returns>Task of List&lt;VoiceRate&gt;</returns>
        public async System.Threading.Tasks.Task<List<VoiceRate>> BillingVoiceratesOutboundDomesticGetAsync (string currency, string type = null)
        {
             ApiResponse<List<VoiceRate>> response = await BillingVoiceratesOutboundDomesticGetAsyncWithHttpInfo(currency, type);
             return response.Data;

        }

        /// <summary>
        /// Get current outbound domestic billing voice rates Retrieve a list of current outbound domestic billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="type">Filter voice rates by &#39;inboundTolled&#39;, &#39;inboundTollFree&#39;, &#39;outboundInterState&#39;, &#39;outboundIntraState&#39;, or &#39;outboundLocal&#39;.</param>
        /// <returns>Task of ApiResponse (List&lt;VoiceRate&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<VoiceRate>>> BillingVoiceratesOutboundDomesticGetAsyncWithHttpInfo (string currency, string type = null)
        {
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling BillingVoiceratesOutboundDomesticGet");
            
    
            var path_ = "/api/v1/billing/voicerates/outbound/domestic";
    
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
            
            if (currency != null) queryParams.Add("currency", Configuration.ApiClient.ParameterToString(currency)); // query parameter
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
                throw new ApiException (statusCode, "Error calling BillingVoiceratesOutboundDomesticGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingVoiceratesOutboundDomesticGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<VoiceRate>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<VoiceRate>) Configuration.ApiClient.Deserialize(response, typeof(List<VoiceRate>)));
            
        }
        
        /// <summary>
        /// Get current outbound international billing voice rates Retrieve a list of current outbound international billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param> 
        /// <param name="origin">Filter voice rates by origin.</param> 
        /// <param name="destination">Filter voice rates by destination.</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>DomainVoiceRateResponseItemEntityListing</returns>
        public DomainVoiceRateResponseItemEntityListing BillingVoiceratesOutboundInternationalGet (string currency, string origin = null, string destination = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainVoiceRateResponseItemEntityListing> response = BillingVoiceratesOutboundInternationalGetWithHttpInfo(currency, origin, destination, pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Get current outbound international billing voice rates Retrieve a list of current outbound international billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param> 
        /// <param name="origin">Filter voice rates by origin.</param> 
        /// <param name="destination">Filter voice rates by destination.</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of DomainVoiceRateResponseItemEntityListing</returns>
        public ApiResponse< DomainVoiceRateResponseItemEntityListing > BillingVoiceratesOutboundInternationalGetWithHttpInfo (string currency, string origin = null, string destination = null, int? pageSize = null, int? pageNumber = null)
        {
            
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling BillingVoiceratesOutboundInternationalGet");
            
    
            var path_ = "/api/v1/billing/voicerates/outbound/international";
    
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
            
            if (currency != null) queryParams.Add("currency", Configuration.ApiClient.ParameterToString(currency)); // query parameter
            if (origin != null) queryParams.Add("origin", Configuration.ApiClient.ParameterToString(origin)); // query parameter
            if (destination != null) queryParams.Add("destination", Configuration.ApiClient.ParameterToString(destination)); // query parameter
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
                throw new ApiException (statusCode, "Error calling BillingVoiceratesOutboundInternationalGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingVoiceratesOutboundInternationalGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DomainVoiceRateResponseItemEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainVoiceRateResponseItemEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainVoiceRateResponseItemEntityListing)));
            
        }
    
        /// <summary>
        /// Get current outbound international billing voice rates Retrieve a list of current outbound international billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="origin">Filter voice rates by origin.</param>
        /// <param name="destination">Filter voice rates by destination.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of DomainVoiceRateResponseItemEntityListing</returns>
        public async System.Threading.Tasks.Task<DomainVoiceRateResponseItemEntityListing> BillingVoiceratesOutboundInternationalGetAsync (string currency, string origin = null, string destination = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<DomainVoiceRateResponseItemEntityListing> response = await BillingVoiceratesOutboundInternationalGetAsyncWithHttpInfo(currency, origin, destination, pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Get current outbound international billing voice rates Retrieve a list of current outbound international billing voice rates stored in the system.
        /// </summary>
        /// <param name="currency">Filter voice rates by currency.</param>
        /// <param name="origin">Filter voice rates by origin.</param>
        /// <param name="destination">Filter voice rates by destination.</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (DomainVoiceRateResponseItemEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainVoiceRateResponseItemEntityListing>> BillingVoiceratesOutboundInternationalGetAsyncWithHttpInfo (string currency, string origin = null, string destination = null, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling BillingVoiceratesOutboundInternationalGet");
            
    
            var path_ = "/api/v1/billing/voicerates/outbound/international";
    
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
            
            if (currency != null) queryParams.Add("currency", Configuration.ApiClient.ParameterToString(currency)); // query parameter
            if (origin != null) queryParams.Add("origin", Configuration.ApiClient.ParameterToString(origin)); // query parameter
            if (destination != null) queryParams.Add("destination", Configuration.ApiClient.ParameterToString(destination)); // query parameter
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
                throw new ApiException (statusCode, "Error calling BillingVoiceratesOutboundInternationalGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingVoiceratesOutboundInternationalGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DomainVoiceRateResponseItemEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainVoiceRateResponseItemEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DomainVoiceRateResponseItemEntityListing)));
            
        }
        
        /// <summary>
        /// Get current billing voice rates csv Retrieve a csv of current billing voice rates stored in the system.
        /// </summary>
        /// <returns>VoiceRatesCsv</returns>
        public VoiceRatesCsv BillingVoiceratescsvGet ()
        {
             ApiResponse<VoiceRatesCsv> response = BillingVoiceratescsvGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get current billing voice rates csv Retrieve a csv of current billing voice rates stored in the system.
        /// </summary>
        /// <returns>ApiResponse of VoiceRatesCsv</returns>
        public ApiResponse< VoiceRatesCsv > BillingVoiceratescsvGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/billing/voiceratescsv";
    
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
                throw new ApiException (statusCode, "Error calling BillingVoiceratescsvGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingVoiceratescsvGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<VoiceRatesCsv>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoiceRatesCsv) Configuration.ApiClient.Deserialize(response, typeof(VoiceRatesCsv)));
            
        }
    
        /// <summary>
        /// Get current billing voice rates csv Retrieve a csv of current billing voice rates stored in the system.
        /// </summary>
        /// <returns>Task of VoiceRatesCsv</returns>
        public async System.Threading.Tasks.Task<VoiceRatesCsv> BillingVoiceratescsvGetAsync ()
        {
             ApiResponse<VoiceRatesCsv> response = await BillingVoiceratescsvGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get current billing voice rates csv Retrieve a csv of current billing voice rates stored in the system.
        /// </summary>
        /// <returns>Task of ApiResponse (VoiceRatesCsv)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoiceRatesCsv>> BillingVoiceratescsvGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/billing/voiceratescsv";
    
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
                throw new ApiException (statusCode, "Error calling BillingVoiceratescsvGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling BillingVoiceratescsvGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<VoiceRatesCsv>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoiceRatesCsv) Configuration.ApiClient.Deserialize(response, typeof(VoiceRatesCsv)));
            
        }
        
    }
    
}
