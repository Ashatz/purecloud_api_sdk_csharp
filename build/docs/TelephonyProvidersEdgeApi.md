# ININ.PureCloudApi.Api.TelephonyProvidersEdgeApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**TelephonyProvidersEdgeEdgegroupsEdgegroupidDelete**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgeedgegroupsedgegroupiddelete) | **DELETE** /api/v1/telephony/providers/edge/edgegroups/{edgeGroupId} | Delete an edge group. |
| [**TelephonyProvidersEdgeEdgegroupsEdgegroupidGet**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgeedgegroupsedgegroupidget) | **GET** /api/v1/telephony/providers/edge/edgegroups/{edgeGroupId} | Get edge group. |
| [**TelephonyProvidersEdgeEdgegroupsEdgegroupidPut**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgeedgegroupsedgegroupidput) | **PUT** /api/v1/telephony/providers/edge/edgegroups/{edgeGroupId} | Update an edge group. |
| [**TelephonyProvidersEdgeEdgegroupsGet**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgeedgegroupsget) | **GET** /api/v1/telephony/providers/edge/edgegroups | Get the list of edge groups. |
| [**TelephonyProvidersEdgeEdgegroupsPost**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgeedgegroupspost) | **POST** /api/v1/telephony/providers/edge/edgegroups | Create an edge group. |
| [**TelephonyProvidersEdgeLinebasesettingsGet**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgelinebasesettingsget) | **GET** /api/v1/telephony/providers/edge/linebasesettings | Get a listing of line base settings objects |
| [**TelephonyProvidersEdgeLinebasesettingsLinebaseidGet**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgelinebasesettingslinebaseidget) | **GET** /api/v1/telephony/providers/edge/linebasesettings/{lineBaseId} | Get a line base settings object by ID |
| [**TelephonyProvidersEdgeLinesGet**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgelinesget) | **GET** /api/v1/telephony/providers/edge/lines | Get a list of Lines |
| [**TelephonyProvidersEdgeLinesLineidGet**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgelineslineidget) | **GET** /api/v1/telephony/providers/edge/lines/{lineId} | Get a Line by ID |
| [**TelephonyProvidersEdgeLinesTemplateGet**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgelinestemplateget) | **GET** /api/v1/telephony/providers/edge/lines/template | Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance |
| [**TelephonyProvidersEdgeOutboundroutesGet**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgeoutboundroutesget) | **GET** /api/v1/telephony/providers/edge/outboundroutes | Get outbound routes |
| [**TelephonyProvidersEdgeOutboundroutesOutboundrouteidDelete**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgeoutboundroutesoutboundrouteiddelete) | **DELETE** /api/v1/telephony/providers/edge/outboundroutes/{outboundRouteId} | Delete Outbound Route |
| [**TelephonyProvidersEdgeOutboundroutesOutboundrouteidGet**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgeoutboundroutesoutboundrouteidget) | **GET** /api/v1/telephony/providers/edge/outboundroutes/{outboundRouteId} | Get outbound route |
| [**TelephonyProvidersEdgeOutboundroutesOutboundrouteidPut**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgeoutboundroutesoutboundrouteidput) | **PUT** /api/v1/telephony/providers/edge/outboundroutes/{outboundRouteId} | Update outbound route |
| [**TelephonyProvidersEdgeOutboundroutesPost**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgeoutboundroutespost) | **POST** /api/v1/telephony/providers/edge/outboundroutes | Create outbound rule |
| [**TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGet**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgephonebasesettingsavailablemetabasesget) | **GET** /api/v1/telephony/providers/edge/phonebasesettings/availablemetabases | Get a list of available makes and models to create a new Phone Base Settings |
| [**TelephonyProvidersEdgePhonebasesettingsGet**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgephonebasesettingsget) | **GET** /api/v1/telephony/providers/edge/phonebasesettings | Get a list of Phone Base Settings objects |
| [**TelephonyProvidersEdgePhonebasesettingsPhonebaseidDelete**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgephonebasesettingsphonebaseiddelete) | **DELETE** /api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId} | Delete a Phone Base Settings by ID |
| [**TelephonyProvidersEdgePhonebasesettingsPhonebaseidGet**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgephonebasesettingsphonebaseidget) | **GET** /api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId} | Get a Phone Base Settings object by ID |
| [**TelephonyProvidersEdgePhonebasesettingsPhonebaseidPut**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgephonebasesettingsphonebaseidput) | **PUT** /api/v1/telephony/providers/edge/phonebasesettings/{phoneBaseId} | Update a Phone Base Settings by ID |
| [**TelephonyProvidersEdgePhonebasesettingsPost**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgephonebasesettingspost) | **POST** /api/v1/telephony/providers/edge/phonebasesettings | Create a new Phone Base Settings object |
| [**TelephonyProvidersEdgePhonebasesettingsTemplateGet**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgephonebasesettingstemplateget) | **GET** /api/v1/telephony/providers/edge/phonebasesettings/template | Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance |
| [**TelephonyProvidersEdgePhonesGet**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgephonesget) | **GET** /api/v1/telephony/providers/edge/phones | Get a list of Phone Instances |
| [**TelephonyProvidersEdgePhonesPhoneidDelete**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgephonesphoneiddelete) | **DELETE** /api/v1/telephony/providers/edge/phones/{phoneId} | Delete a Phone by ID |
| [**TelephonyProvidersEdgePhonesPhoneidGet**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgephonesphoneidget) | **GET** /api/v1/telephony/providers/edge/phones/{phoneId} | Get a Phone by ID |
| [**TelephonyProvidersEdgePhonesPhoneidPut**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgephonesphoneidput) | **PUT** /api/v1/telephony/providers/edge/phones/{phoneId} | Update a Phone by ID |
| [**TelephonyProvidersEdgePhonesPhoneidRebootPost**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgephonesphoneidrebootpost) | **POST** /api/v1/telephony/providers/edge/phones/{phoneId}/reboot | Reboot a Phone |
| [**TelephonyProvidersEdgePhonesPost**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgephonespost) | **POST** /api/v1/telephony/providers/edge/phones | Create a new Phone |
| [**TelephonyProvidersEdgePhonesRebootPost**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgephonesrebootpost) | **POST** /api/v1/telephony/providers/edge/phones/reboot | Reboot Multiple Phones |
| [**TelephonyProvidersEdgePhonesTemplateGet**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgephonestemplateget) | **GET** /api/v1/telephony/providers/edge/phones/template | Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance |
| [**TelephonyProvidersEdgeTimezonesGet**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgetimezonesget) | **GET** /api/v1/telephony/providers/edge/timezones | Get a list of Edge-compatible time zones |
| [**TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGet**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgetrunkbasesettingsavailablemetabasesget) | **GET** /api/v1/telephony/providers/edge/trunkbasesettings/availablemetabases | Get a list of available makes and models to create a new Trunk Base Settings |
| [**TelephonyProvidersEdgeTrunkbasesettingsGet**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgetrunkbasesettingsget) | **GET** /api/v1/telephony/providers/edge/trunkbasesettings | Get Trunk Base Settings listing |
| [**TelephonyProvidersEdgeTrunkbasesettingsPost**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgetrunkbasesettingspost) | **POST** /api/v1/telephony/providers/edge/trunkbasesettings | Create a Trunk Base Settings object |
| [**TelephonyProvidersEdgeTrunkbasesettingsTemplateGet**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgetrunkbasesettingstemplateget) | **GET** /api/v1/telephony/providers/edge/trunkbasesettings/template | Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance |
| [**TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDelete**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgetrunkbasesettingstrunkbasesettingsiddelete) | **DELETE** /api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId} | Delete a Trunk Base Settings object by ID |
| [**TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGet**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgetrunkbasesettingstrunkbasesettingsidget) | **GET** /api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId} | Get a Trunk Base Settings object by ID |
| [**TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPut**](TelephonyProvidersEdgeApi.md#telephonyprovidersedgetrunkbasesettingstrunkbasesettingsidput) | **PUT** /api/v1/telephony/providers/edge/trunkbasesettings/{trunkBaseSettingsId} | Update a Trunk Base Settings object by ID |
{: class="table table-striped"}

<a name="TelephonyProvidersEdgeEdgegroupsEdgegroupidDelete"></a>
## string** TelephonyProvidersEdgeEdgegroupsEdgegroupidDelete (string edgeGroupId)

Delete an edge group.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgeEdgegroupsEdgegroupidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeGroupId = edgeGroupId_example;  // string | Edge group ID

            try
            {
                // Delete an edge group.
                string result = apiInstance.TelephonyProvidersEdgeEdgegroupsEdgegroupidDelete(edgeGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgeEdgegroupsEdgegroupidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeGroupId** | **string**| Edge group ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="TelephonyProvidersEdgeEdgegroupsEdgegroupidGet"></a>
## [**EdgeGroup**](EdgeGroup.html) TelephonyProvidersEdgeEdgegroupsEdgegroupidGet (string edgeGroupId)

Get edge group.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgeEdgegroupsEdgegroupidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeGroupId = edgeGroupId_example;  // string | Edge group ID

            try
            {
                // Get edge group.
                EdgeGroup result = apiInstance.TelephonyProvidersEdgeEdgegroupsEdgegroupidGet(edgeGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgeEdgegroupsEdgegroupidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeGroupId** | **string**| Edge group ID |  |
{: class="table table-striped"}

### Return type

[**EdgeGroup**](EdgeGroup.md)

<a name="TelephonyProvidersEdgeEdgegroupsEdgegroupidPut"></a>
## [**EdgeGroup**](EdgeGroup.html) TelephonyProvidersEdgeEdgegroupsEdgegroupidPut (string edgeGroupId, EdgeGroup body = null)

Update an edge group.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgeEdgegroupsEdgegroupidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeGroupId = edgeGroupId_example;  // string | Edge group ID
            var body = new EdgeGroup(); // EdgeGroup | EdgeGroup (optional) 

            try
            {
                // Update an edge group.
                EdgeGroup result = apiInstance.TelephonyProvidersEdgeEdgegroupsEdgegroupidPut(edgeGroupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgeEdgegroupsEdgegroupidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeGroupId** | **string**| Edge group ID |  |
| **body** | [**EdgeGroup**](EdgeGroup.md)| EdgeGroup | [optional]  |
{: class="table table-striped"}

### Return type

[**EdgeGroup**](EdgeGroup.md)

<a name="TelephonyProvidersEdgeEdgegroupsGet"></a>
## [**EdgeGroupEntityListing**](EdgeGroupEntityListing.html) TelephonyProvidersEdgeEdgegroupsGet (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)

Get the list of edge groups.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgeEdgegroupsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)

            try
            {
                // Get the list of edge groups.
                EdgeGroupEntityListing result = apiInstance.TelephonyProvidersEdgeEdgegroupsGet(pageSize, pageNumber, name, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgeEdgegroupsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional] [default to name] |
{: class="table table-striped"}

### Return type

[**EdgeGroupEntityListing**](EdgeGroupEntityListing.md)

<a name="TelephonyProvidersEdgeEdgegroupsPost"></a>
## [**EdgeGroup**](EdgeGroup.html) TelephonyProvidersEdgeEdgegroupsPost (EdgeGroup body = null)

Create an edge group.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgeEdgegroupsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new EdgeGroup(); // EdgeGroup | EdgeGroup (optional) 

            try
            {
                // Create an edge group.
                EdgeGroup result = apiInstance.TelephonyProvidersEdgeEdgegroupsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgeEdgegroupsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EdgeGroup**](EdgeGroup.md)| EdgeGroup | [optional]  |
{: class="table table-striped"}

### Return type

[**EdgeGroup**](EdgeGroup.md)

<a name="TelephonyProvidersEdgeLinebasesettingsGet"></a>
## [**LineBaseEntityListing**](LineBaseEntityListing.html) TelephonyProvidersEdgeLinebasesettingsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)

Get a listing of line base settings objects



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgeLinebasesettingsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Value by which to sort (optional)  (default to name)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ASC)

            try
            {
                // Get a listing of line base settings objects
                LineBaseEntityListing result = apiInstance.TelephonyProvidersEdgeLinebasesettingsGet(pageNumber, pageSize, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgeLinebasesettingsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Value by which to sort | [optional] [default to name] |
| **sortOrder** | **string**| Sort order | [optional] [default to ASC] |
{: class="table table-striped"}

### Return type

[**LineBaseEntityListing**](LineBaseEntityListing.md)

<a name="TelephonyProvidersEdgeLinebasesettingsLinebaseidGet"></a>
## [**LineBase**](LineBase.html) TelephonyProvidersEdgeLinebasesettingsLinebaseidGet (string lineBaseId)

Get a line base settings object by ID



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgeLinebasesettingsLinebaseidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var lineBaseId = lineBaseId_example;  // string | Line base ID

            try
            {
                // Get a line base settings object by ID
                LineBase result = apiInstance.TelephonyProvidersEdgeLinebasesettingsLinebaseidGet(lineBaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgeLinebasesettingsLinebaseidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **lineBaseId** | **string**| Line base ID |  |
{: class="table table-striped"}

### Return type

[**LineBase**](LineBase.md)

<a name="TelephonyProvidersEdgeLinesGet"></a>
## [**LineEntityListing**](LineEntityListing.html) TelephonyProvidersEdgeLinesGet (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null)

Get a list of Lines



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgeLinesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Value by which to sort (optional)  (default to name)
            var expand = new List<string>(); // List<string> | Fields to expand in the response, comma-separated (optional) 

            try
            {
                // Get a list of Lines
                LineEntityListing result = apiInstance.TelephonyProvidersEdgeLinesGet(pageSize, pageNumber, name, sortBy, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgeLinesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Value by which to sort | [optional] [default to name] |
| **expand** | [**List<string>**](string.md)| Fields to expand in the response, comma-separated | [optional]  |
{: class="table table-striped"}

### Return type

[**LineEntityListing**](LineEntityListing.md)

<a name="TelephonyProvidersEdgeLinesLineidGet"></a>
## [**Line**](Line.html) TelephonyProvidersEdgeLinesLineidGet (string lineId)

Get a Line by ID



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgeLinesLineidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var lineId = lineId_example;  // string | Line ID

            try
            {
                // Get a Line by ID
                Line result = apiInstance.TelephonyProvidersEdgeLinesLineidGet(lineId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgeLinesLineidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **lineId** | **string**| Line ID |  |
{: class="table table-striped"}

### Return type

[**Line**](Line.md)

<a name="TelephonyProvidersEdgeLinesTemplateGet"></a>
## [**Line**](Line.html) TelephonyProvidersEdgeLinesTemplateGet (string lineBaseSettingsId)

Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgeLinesTemplateGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var lineBaseSettingsId = lineBaseSettingsId_example;  // string | The id of a Line Base Settings object upon which to base this Line

            try
            {
                // Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance
                Line result = apiInstance.TelephonyProvidersEdgeLinesTemplateGet(lineBaseSettingsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgeLinesTemplateGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **lineBaseSettingsId** | **string**| The id of a Line Base Settings object upon which to base this Line |  |
{: class="table table-striped"}

### Return type

[**Line**](Line.md)

<a name="TelephonyProvidersEdgeOutboundroutesGet"></a>
## [**OutboundRouteEntityListing**](OutboundRouteEntityListing.html) TelephonyProvidersEdgeOutboundroutesGet (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null)

Get outbound routes



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgeOutboundroutesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var name = name_example;  // string | Name (optional) 
            var siteId = siteId_example;  // string | Filter by site.id (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)

            try
            {
                // Get outbound routes
                OutboundRouteEntityListing result = apiInstance.TelephonyProvidersEdgeOutboundroutesGet(pageSize, pageNumber, name, siteId, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgeOutboundroutesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **name** | **string**| Name | [optional]  |
| **siteId** | **string**| Filter by site.id | [optional]  |
| **sortBy** | **string**| Sort by | [optional] [default to name] |
{: class="table table-striped"}

### Return type

[**OutboundRouteEntityListing**](OutboundRouteEntityListing.md)

<a name="TelephonyProvidersEdgeOutboundroutesOutboundrouteidDelete"></a>
## string** TelephonyProvidersEdgeOutboundroutesOutboundrouteidDelete (string outboundRouteId)

Delete Outbound Route



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgeOutboundroutesOutboundrouteidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var outboundRouteId = outboundRouteId_example;  // string | Outbound route ID

            try
            {
                // Delete Outbound Route
                string result = apiInstance.TelephonyProvidersEdgeOutboundroutesOutboundrouteidDelete(outboundRouteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgeOutboundroutesOutboundrouteidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **outboundRouteId** | **string**| Outbound route ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="TelephonyProvidersEdgeOutboundroutesOutboundrouteidGet"></a>
## [**OutboundRoute**](OutboundRoute.html) TelephonyProvidersEdgeOutboundroutesOutboundrouteidGet (string outboundRouteId)

Get outbound route



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgeOutboundroutesOutboundrouteidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var outboundRouteId = outboundRouteId_example;  // string | Outbound route ID

            try
            {
                // Get outbound route
                OutboundRoute result = apiInstance.TelephonyProvidersEdgeOutboundroutesOutboundrouteidGet(outboundRouteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgeOutboundroutesOutboundrouteidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **outboundRouteId** | **string**| Outbound route ID |  |
{: class="table table-striped"}

### Return type

[**OutboundRoute**](OutboundRoute.md)

<a name="TelephonyProvidersEdgeOutboundroutesOutboundrouteidPut"></a>
## [**OutboundRoute**](OutboundRoute.html) TelephonyProvidersEdgeOutboundroutesOutboundrouteidPut (string outboundRouteId, OutboundRoute body = null)

Update outbound route



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgeOutboundroutesOutboundrouteidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var outboundRouteId = outboundRouteId_example;  // string | Outbound route ID
            var body = new OutboundRoute(); // OutboundRoute | OutboundRoute (optional) 

            try
            {
                // Update outbound route
                OutboundRoute result = apiInstance.TelephonyProvidersEdgeOutboundroutesOutboundrouteidPut(outboundRouteId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgeOutboundroutesOutboundrouteidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **outboundRouteId** | **string**| Outbound route ID |  |
| **body** | [**OutboundRoute**](OutboundRoute.md)| OutboundRoute | [optional]  |
{: class="table table-striped"}

### Return type

[**OutboundRoute**](OutboundRoute.md)

<a name="TelephonyProvidersEdgeOutboundroutesPost"></a>
## [**OutboundRoute**](OutboundRoute.html) TelephonyProvidersEdgeOutboundroutesPost (OutboundRoute body = null)

Create outbound rule



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgeOutboundroutesPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new OutboundRoute(); // OutboundRoute | OutboundRoute (optional) 

            try
            {
                // Create outbound rule
                OutboundRoute result = apiInstance.TelephonyProvidersEdgeOutboundroutesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgeOutboundroutesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OutboundRoute**](OutboundRoute.md)| OutboundRoute | [optional]  |
{: class="table table-striped"}

### Return type

[**OutboundRoute**](OutboundRoute.md)

<a name="TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGet"></a>
## [**PhoneMetaBaseEntityListing**](PhoneMetaBaseEntityListing.html) TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGet (int? pageSize = null, int? pageNumber = null)

Get a list of available makes and models to create a new Phone Base Settings



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get a list of available makes and models to create a new Phone Base Settings
                PhoneMetaBaseEntityListing result = apiInstance.TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGet(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgePhonebasesettingsAvailablemetabasesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**PhoneMetaBaseEntityListing**](PhoneMetaBaseEntityListing.md)

<a name="TelephonyProvidersEdgePhonebasesettingsGet"></a>
## [**PhoneBaseEntityListing**](PhoneBaseEntityListing.html) TelephonyProvidersEdgePhonebasesettingsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)

Get a list of Phone Base Settings objects



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgePhonebasesettingsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Value by which to sort (optional)  (default to name)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ASC)

            try
            {
                // Get a list of Phone Base Settings objects
                PhoneBaseEntityListing result = apiInstance.TelephonyProvidersEdgePhonebasesettingsGet(pageNumber, pageSize, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgePhonebasesettingsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Value by which to sort | [optional] [default to name] |
| **sortOrder** | **string**| Sort order | [optional] [default to ASC] |
{: class="table table-striped"}

### Return type

[**PhoneBaseEntityListing**](PhoneBaseEntityListing.md)

<a name="TelephonyProvidersEdgePhonebasesettingsPhonebaseidDelete"></a>
## string** TelephonyProvidersEdgePhonebasesettingsPhonebaseidDelete (string phoneBaseId)

Delete a Phone Base Settings by ID



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgePhonebasesettingsPhonebaseidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneBaseId = phoneBaseId_example;  // string | Phone base ID

            try
            {
                // Delete a Phone Base Settings by ID
                string result = apiInstance.TelephonyProvidersEdgePhonebasesettingsPhonebaseidDelete(phoneBaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgePhonebasesettingsPhonebaseidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneBaseId** | **string**| Phone base ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="TelephonyProvidersEdgePhonebasesettingsPhonebaseidGet"></a>
## [**PhoneBase**](PhoneBase.html) TelephonyProvidersEdgePhonebasesettingsPhonebaseidGet (string phoneBaseId)

Get a Phone Base Settings object by ID



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgePhonebasesettingsPhonebaseidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneBaseId = phoneBaseId_example;  // string | Phone base ID

            try
            {
                // Get a Phone Base Settings object by ID
                PhoneBase result = apiInstance.TelephonyProvidersEdgePhonebasesettingsPhonebaseidGet(phoneBaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgePhonebasesettingsPhonebaseidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneBaseId** | **string**| Phone base ID |  |
{: class="table table-striped"}

### Return type

[**PhoneBase**](PhoneBase.md)

<a name="TelephonyProvidersEdgePhonebasesettingsPhonebaseidPut"></a>
## [**PhoneBase**](PhoneBase.html) TelephonyProvidersEdgePhonebasesettingsPhonebaseidPut (string phoneBaseId, PhoneBase body = null)

Update a Phone Base Settings by ID



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgePhonebasesettingsPhonebaseidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneBaseId = phoneBaseId_example;  // string | Phone base ID
            var body = new PhoneBase(); // PhoneBase |  (optional) 

            try
            {
                // Update a Phone Base Settings by ID
                PhoneBase result = apiInstance.TelephonyProvidersEdgePhonebasesettingsPhonebaseidPut(phoneBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgePhonebasesettingsPhonebaseidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneBaseId** | **string**| Phone base ID |  |
| **body** | [**PhoneBase**](PhoneBase.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**PhoneBase**](PhoneBase.md)

<a name="TelephonyProvidersEdgePhonebasesettingsPost"></a>
## [**PhoneBase**](PhoneBase.html) TelephonyProvidersEdgePhonebasesettingsPost (PhoneBase body = null)

Create a new Phone Base Settings object



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgePhonebasesettingsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new PhoneBase(); // PhoneBase |  (optional) 

            try
            {
                // Create a new Phone Base Settings object
                PhoneBase result = apiInstance.TelephonyProvidersEdgePhonebasesettingsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgePhonebasesettingsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PhoneBase**](PhoneBase.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**PhoneBase**](PhoneBase.md)

<a name="TelephonyProvidersEdgePhonebasesettingsTemplateGet"></a>
## [**PhoneBase**](PhoneBase.html) TelephonyProvidersEdgePhonebasesettingsTemplateGet (string phoneMetabaseId)

Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgePhonebasesettingsTemplateGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneMetabaseId = phoneMetabaseId_example;  // string | The id of a metabase object upon which to base this Phone Base Settings

            try
            {
                // Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance
                PhoneBase result = apiInstance.TelephonyProvidersEdgePhonebasesettingsTemplateGet(phoneMetabaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgePhonebasesettingsTemplateGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneMetabaseId** | **string**| The id of a metabase object upon which to base this Phone Base Settings |  |
{: class="table table-striped"}

### Return type

[**PhoneBase**](PhoneBase.md)

<a name="TelephonyProvidersEdgePhonesGet"></a>
## [**PhoneEntityListing**](PhoneEntityListing.html) TelephonyProvidersEdgePhonesGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null)

Get a list of Phone Instances



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgePhonesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Value by which to sort (optional)  (default to name)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ASC)
            var siteId = siteId_example;  // string | Filter by site.id (optional) 
            var phoneBaseSettingsId = phoneBaseSettingsId_example;  // string | Filter by phoneBaseSettings.id (optional) 
            var phoneHardwareId = phoneHardwareId_example;  // string | Filter by phone_hardwareId (optional) 
            var expand = new List<string>(); // List<string> | Fields to expand in the response, comma-separated (optional) 
            var fields = new List<string>(); // List<string> | Fields under properties to get, comma-separated (optional) 

            try
            {
                // Get a list of Phone Instances
                PhoneEntityListing result = apiInstance.TelephonyProvidersEdgePhonesGet(pageNumber, pageSize, sortBy, sortOrder, siteId, phoneBaseSettingsId, phoneHardwareId, expand, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgePhonesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Value by which to sort | [optional] [default to name] |
| **sortOrder** | **string**| Sort order | [optional] [default to ASC] |
| **siteId** | **string**| Filter by site.id | [optional]  |
| **phoneBaseSettingsId** | **string**| Filter by phoneBaseSettings.id | [optional]  |
| **phoneHardwareId** | **string**| Filter by phone_hardwareId | [optional]  |
| **expand** | [**List<string>**](string.md)| Fields to expand in the response, comma-separated | [optional]  |
| **fields** | [**List<string>**](string.md)| Fields under properties to get, comma-separated | [optional]  |
{: class="table table-striped"}

### Return type

[**PhoneEntityListing**](PhoneEntityListing.md)

<a name="TelephonyProvidersEdgePhonesPhoneidDelete"></a>
## string** TelephonyProvidersEdgePhonesPhoneidDelete (string phoneId)

Delete a Phone by ID



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgePhonesPhoneidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneId = phoneId_example;  // string | Phone ID

            try
            {
                // Delete a Phone by ID
                string result = apiInstance.TelephonyProvidersEdgePhonesPhoneidDelete(phoneId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgePhonesPhoneidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneId** | **string**| Phone ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="TelephonyProvidersEdgePhonesPhoneidGet"></a>
## [**Phone**](Phone.html) TelephonyProvidersEdgePhonesPhoneidGet (string phoneId)

Get a Phone by ID



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgePhonesPhoneidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneId = phoneId_example;  // string | Phone ID

            try
            {
                // Get a Phone by ID
                Phone result = apiInstance.TelephonyProvidersEdgePhonesPhoneidGet(phoneId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgePhonesPhoneidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneId** | **string**| Phone ID |  |
{: class="table table-striped"}

### Return type

[**Phone**](Phone.md)

<a name="TelephonyProvidersEdgePhonesPhoneidPut"></a>
## [**Phone**](Phone.html) TelephonyProvidersEdgePhonesPhoneidPut (string phoneId, Phone body = null)

Update a Phone by ID



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgePhonesPhoneidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneId = phoneId_example;  // string | Phone ID
            var body = new Phone(); // Phone |  (optional) 

            try
            {
                // Update a Phone by ID
                Phone result = apiInstance.TelephonyProvidersEdgePhonesPhoneidPut(phoneId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgePhonesPhoneidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneId** | **string**| Phone ID |  |
| **body** | [**Phone**](Phone.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**Phone**](Phone.md)

<a name="TelephonyProvidersEdgePhonesPhoneidRebootPost"></a>
## void TelephonyProvidersEdgePhonesPhoneidRebootPost (string phoneId)

Reboot a Phone



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgePhonesPhoneidRebootPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneId = phoneId_example;  // string | Phone Id

            try
            {
                // Reboot a Phone
                apiInstance.TelephonyProvidersEdgePhonesPhoneidRebootPost(phoneId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgePhonesPhoneidRebootPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneId** | **string**| Phone Id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="TelephonyProvidersEdgePhonesPost"></a>
## [**Phone**](Phone.html) TelephonyProvidersEdgePhonesPost (Phone body = null)

Create a new Phone



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgePhonesPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new Phone(); // Phone |  (optional) 

            try
            {
                // Create a new Phone
                Phone result = apiInstance.TelephonyProvidersEdgePhonesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgePhonesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Phone**](Phone.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**Phone**](Phone.md)

<a name="TelephonyProvidersEdgePhonesRebootPost"></a>
## void TelephonyProvidersEdgePhonesRebootPost (PhonesReboot body = null)

Reboot Multiple Phones



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgePhonesRebootPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new PhonesReboot(); // PhonesReboot | body (optional) 

            try
            {
                // Reboot Multiple Phones
                apiInstance.TelephonyProvidersEdgePhonesRebootPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgePhonesRebootPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PhonesReboot**](PhonesReboot.md)| body | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="TelephonyProvidersEdgePhonesTemplateGet"></a>
## [**Phone**](Phone.html) TelephonyProvidersEdgePhonesTemplateGet (string phoneBaseSettingsId)

Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgePhonesTemplateGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneBaseSettingsId = phoneBaseSettingsId_example;  // string | The id of a Phone Base Settings object upon which to base this Phone

            try
            {
                // Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance
                Phone result = apiInstance.TelephonyProvidersEdgePhonesTemplateGet(phoneBaseSettingsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgePhonesTemplateGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneBaseSettingsId** | **string**| The id of a Phone Base Settings object upon which to base this Phone |  |
{: class="table table-striped"}

### Return type

[**Phone**](Phone.md)

<a name="TelephonyProvidersEdgeTimezonesGet"></a>
## [**TimeZoneEntityListing**](TimeZoneEntityListing.html) TelephonyProvidersEdgeTimezonesGet (int? pageSize = null, int? pageNumber = null)

Get a list of Edge-compatible time zones



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgeTimezonesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 1000)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get a list of Edge-compatible time zones
                TimeZoneEntityListing result = apiInstance.TelephonyProvidersEdgeTimezonesGet(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgeTimezonesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 1000] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**TimeZoneEntityListing**](TimeZoneEntityListing.md)

<a name="TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGet"></a>
## [**TrunkMetabaseEntityListing**](TrunkMetabaseEntityListing.html) TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGet (string type = null, int? pageSize = null, int? pageNumber = null)

Get a list of available makes and models to create a new Trunk Base Settings



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var type = type_example;  // string |  (optional) 
            var pageSize = 56;  // int? |  (optional)  (default to 25)
            var pageNumber = 56;  // int? |  (optional)  (default to 1)

            try
            {
                // Get a list of available makes and models to create a new Trunk Base Settings
                TrunkMetabaseEntityListing result = apiInstance.TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGet(type, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **type** | **string**|  | [optional]  |
| **pageSize** | **int?**|  | [optional] [default to 25] |
| **pageNumber** | **int?**|  | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**TrunkMetabaseEntityListing**](TrunkMetabaseEntityListing.md)

<a name="TelephonyProvidersEdgeTrunkbasesettingsGet"></a>
## [**TrunkBase**](TrunkBase.html) TelephonyProvidersEdgeTrunkbasesettingsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)

Get Trunk Base Settings listing



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgeTrunkbasesettingsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Value by which to sort (optional)  (default to name)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ASC)

            try
            {
                // Get Trunk Base Settings listing
                TrunkBase result = apiInstance.TelephonyProvidersEdgeTrunkbasesettingsGet(pageNumber, pageSize, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgeTrunkbasesettingsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| Value by which to sort | [optional] [default to name] |
| **sortOrder** | **string**| Sort order | [optional] [default to ASC] |
{: class="table table-striped"}

### Return type

[**TrunkBase**](TrunkBase.md)

<a name="TelephonyProvidersEdgeTrunkbasesettingsPost"></a>
## [**TrunkBase**](TrunkBase.html) TelephonyProvidersEdgeTrunkbasesettingsPost (TrunkBase body = null)

Create a Trunk Base Settings object



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgeTrunkbasesettingsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new TrunkBase(); // TrunkBase |  (optional) 

            try
            {
                // Create a Trunk Base Settings object
                TrunkBase result = apiInstance.TelephonyProvidersEdgeTrunkbasesettingsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgeTrunkbasesettingsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TrunkBase**](TrunkBase.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**TrunkBase**](TrunkBase.md)

<a name="TelephonyProvidersEdgeTrunkbasesettingsTemplateGet"></a>
## [**TrunkBase**](TrunkBase.html) TelephonyProvidersEdgeTrunkbasesettingsTemplateGet (string trunkMetabaseId)

Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgeTrunkbasesettingsTemplateGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var trunkMetabaseId = trunkMetabaseId_example;  // string | The id of a metabase object upon which to base this Trunk Base Settings

            try
            {
                // Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance
                TrunkBase result = apiInstance.TelephonyProvidersEdgeTrunkbasesettingsTemplateGet(trunkMetabaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgeTrunkbasesettingsTemplateGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trunkMetabaseId** | **string**| The id of a metabase object upon which to base this Trunk Base Settings |  |
{: class="table table-striped"}

### Return type

[**TrunkBase**](TrunkBase.md)

<a name="TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDelete"></a>
## string** TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDelete (string trunkBaseSettingsId)

Delete a Trunk Base Settings object by ID



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var trunkBaseSettingsId = trunkBaseSettingsId_example;  // string | Trunk Base ID

            try
            {
                // Delete a Trunk Base Settings object by ID
                string result = apiInstance.TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDelete(trunkBaseSettingsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trunkBaseSettingsId** | **string**| Trunk Base ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGet"></a>
## [**TrunkBase**](TrunkBase.html) TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGet (string trunkBaseSettingsId)

Get a Trunk Base Settings object by ID



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var trunkBaseSettingsId = trunkBaseSettingsId_example;  // string | Trunk Base ID

            try
            {
                // Get a Trunk Base Settings object by ID
                TrunkBase result = apiInstance.TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGet(trunkBaseSettingsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trunkBaseSettingsId** | **string**| Trunk Base ID |  |
{: class="table table-striped"}

### Return type

[**TrunkBase**](TrunkBase.md)

<a name="TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPut"></a>
## [**TrunkBase**](TrunkBase.html) TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPut (string trunkBaseSettingsId, TrunkBase body = null)

Update a Trunk Base Settings object by ID



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var trunkBaseSettingsId = trunkBaseSettingsId_example;  // string | Trunk Base ID
            var body = new TrunkBase(); // TrunkBase |  (optional) 

            try
            {
                // Update a Trunk Base Settings object by ID
                TrunkBase result = apiInstance.TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPut(trunkBaseSettingsId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.TelephonyProvidersEdgeTrunkbasesettingsTrunkbasesettingsidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trunkBaseSettingsId** | **string**| Trunk Base ID |  |
| **body** | [**TrunkBase**](TrunkBase.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**TrunkBase**](TrunkBase.md)

