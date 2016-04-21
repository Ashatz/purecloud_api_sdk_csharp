# ININ.PureCloudApi.Api.TelephonyProvidersEdgeApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteProvidersEdgesCertificateauthoritiesCertificateId**](TelephonyProvidersEdgeApi.md#deleteprovidersedgescertificateauthoritiescertificateid) | **DELETE** /api/v2/telephony/providers/edges/certificateauthorities/{certificateId} | Delete a certificate authority. |
| [**DeleteProvidersEdgesDidpoolsDidpoolId**](TelephonyProvidersEdgeApi.md#deleteprovidersedgesdidpoolsdidpoolid) | **DELETE** /api/v2/telephony/providers/edges/didpools/{didPoolId} | Delete a DID Pool by ID. |
| [**DeleteProvidersEdgesEdgeId**](TelephonyProvidersEdgeApi.md#deleteprovidersedgesedgeid) | **DELETE** /api/v2/telephony/providers/edges/{edgeId} | Delete a edge. |
| [**DeleteProvidersEdgesEdgeIdLogicalinterfacesInterfaceId**](TelephonyProvidersEdgeApi.md#deleteprovidersedgesedgeidlogicalinterfacesinterfaceid) | **DELETE** /api/v2/telephony/providers/edges/{edgeId}/logicalinterfaces/{interfaceId} | Delete an edge logical interface |
| [**DeleteProvidersEdgesEdgeIdSoftwareupdate**](TelephonyProvidersEdgeApi.md#deleteprovidersedgesedgeidsoftwareupdate) | **DELETE** /api/v2/telephony/providers/edges/{edgeId}/softwareupdate | Cancels any in-progress update for this edge. |
| [**DeleteProvidersEdgesEdgegroupsEdgegroupId**](TelephonyProvidersEdgeApi.md#deleteprovidersedgesedgegroupsedgegroupid) | **DELETE** /api/v2/telephony/providers/edges/edgegroups/{edgeGroupId} | Delete an edge group. |
| [**DeleteProvidersEdgesEndpointsEndpointId**](TelephonyProvidersEdgeApi.md#deleteprovidersedgesendpointsendpointid) | **DELETE** /api/v2/telephony/providers/edges/endpoints/{endpointId} | Delete endpoint |
| [**DeleteProvidersEdgesExtensionpoolsExtensionpoolId**](TelephonyProvidersEdgeApi.md#deleteprovidersedgesextensionpoolsextensionpoolid) | **DELETE** /api/v2/telephony/providers/edges/extensionpools/{extensionPoolId} | Delete an extension pool by ID |
| [**DeleteProvidersEdgesOutboundroutesOutboundrouteId**](TelephonyProvidersEdgeApi.md#deleteprovidersedgesoutboundroutesoutboundrouteid) | **DELETE** /api/v2/telephony/providers/edges/outboundroutes/{outboundRouteId} | Delete Outbound Route |
| [**DeleteProvidersEdgesPhonebasesettingsPhonebaseId**](TelephonyProvidersEdgeApi.md#deleteprovidersedgesphonebasesettingsphonebaseid) | **DELETE** /api/v2/telephony/providers/edges/phonebasesettings/{phoneBaseId} | Delete a Phone Base Settings by ID |
| [**DeleteProvidersEdgesPhonesPhoneId**](TelephonyProvidersEdgeApi.md#deleteprovidersedgesphonesphoneid) | **DELETE** /api/v2/telephony/providers/edges/phones/{phoneId} | Delete a Phone by ID |
| [**DeleteProvidersEdgesSitesSiteId**](TelephonyProvidersEdgeApi.md#deleteprovidersedgessitessiteid) | **DELETE** /api/v2/telephony/providers/edges/sites/{siteId} | Delete an ednpoint |
| [**DeleteProvidersEdgesTrunkbasesettingsTrunkbasesettingsId**](TelephonyProvidersEdgeApi.md#deleteprovidersedgestrunkbasesettingstrunkbasesettingsid) | **DELETE** /api/v2/telephony/providers/edges/trunkbasesettings/{trunkBaseSettingsId} | Delete a Trunk Base Settings object by ID |
| [**GetProvidersEdges**](TelephonyProvidersEdgeApi.md#getprovidersedges) | **GET** /api/v2/telephony/providers/edges | Get the list of edges. |
| [**GetProvidersEdgesCertificateauthorities**](TelephonyProvidersEdgeApi.md#getprovidersedgescertificateauthorities) | **GET** /api/v2/telephony/providers/edges/certificateauthorities | Get the list of certificate authorities. |
| [**GetProvidersEdgesCertificateauthoritiesCertificateId**](TelephonyProvidersEdgeApi.md#getprovidersedgescertificateauthoritiescertificateid) | **GET** /api/v2/telephony/providers/edges/certificateauthorities/{certificateId} | Get a certificate authority. |
| [**GetProvidersEdgesDidpools**](TelephonyProvidersEdgeApi.md#getprovidersedgesdidpools) | **GET** /api/v2/telephony/providers/edges/didpools | Get a listing of DID Pools |
| [**GetProvidersEdgesDidpoolsDidpoolId**](TelephonyProvidersEdgeApi.md#getprovidersedgesdidpoolsdidpoolid) | **GET** /api/v2/telephony/providers/edges/didpools/{didPoolId} | Get a DID Pool by ID. |
| [**GetProvidersEdgesDids**](TelephonyProvidersEdgeApi.md#getprovidersedgesdids) | **GET** /api/v2/telephony/providers/edges/dids | Get a listing of DIDs |
| [**GetProvidersEdgesDidsDidId**](TelephonyProvidersEdgeApi.md#getprovidersedgesdidsdidid) | **GET** /api/v2/telephony/providers/edges/dids/{didId} | Get a DID by ID. |
| [**GetProvidersEdgesEdgeId**](TelephonyProvidersEdgeApi.md#getprovidersedgesedgeid) | **GET** /api/v2/telephony/providers/edges/{edgeId} | Get edge. |
| [**GetProvidersEdgesEdgeIdLines**](TelephonyProvidersEdgeApi.md#getprovidersedgesedgeidlines) | **GET** /api/v2/telephony/providers/edges/{edgeId}/lines | Get the list of lines. |
| [**GetProvidersEdgesEdgeIdLinesLineId**](TelephonyProvidersEdgeApi.md#getprovidersedgesedgeidlineslineid) | **GET** /api/v2/telephony/providers/edges/{edgeId}/lines/{lineId} | Get line |
| [**GetProvidersEdgesEdgeIdLogicalinterfaces**](TelephonyProvidersEdgeApi.md#getprovidersedgesedgeidlogicalinterfaces) | **GET** /api/v2/telephony/providers/edges/{edgeId}/logicalinterfaces | Get edge logical interfaces. |
| [**GetProvidersEdgesEdgeIdLogicalinterfacesInterfaceId**](TelephonyProvidersEdgeApi.md#getprovidersedgesedgeidlogicalinterfacesinterfaceid) | **GET** /api/v2/telephony/providers/edges/{edgeId}/logicalinterfaces/{interfaceId} | Get an edge logical interface |
| [**GetProvidersEdgesEdgeIdLogsJobsJobId**](TelephonyProvidersEdgeApi.md#getprovidersedgesedgeidlogsjobsjobid) | **GET** /api/v2/telephony/providers/edges/{edgeId}/logs/jobs/{jobId} | Get an Edge logs job. |
| [**GetProvidersEdgesEdgeIdPhysicalinterfaces**](TelephonyProvidersEdgeApi.md#getprovidersedgesedgeidphysicalinterfaces) | **GET** /api/v2/telephony/providers/edges/{edgeId}/physicalinterfaces | Retrieve a list of all configured physical interfaces from a specific edge. |
| [**GetProvidersEdgesEdgeIdPhysicalinterfacesInterfaceId**](TelephonyProvidersEdgeApi.md#getprovidersedgesedgeidphysicalinterfacesinterfaceid) | **GET** /api/v2/telephony/providers/edges/{edgeId}/physicalinterfaces/{interfaceId} | Get edge physical interface. |
| [**GetProvidersEdgesEdgeIdSoftwareupdate**](TelephonyProvidersEdgeApi.md#getprovidersedgesedgeidsoftwareupdate) | **GET** /api/v2/telephony/providers/edges/{edgeId}/softwareupdate | Gets software update status information about any edge. |
| [**GetProvidersEdgesEdgeIdSoftwareversions**](TelephonyProvidersEdgeApi.md#getprovidersedgesedgeidsoftwareversions) | **GET** /api/v2/telephony/providers/edges/{edgeId}/softwareversions | Gets all the available software versions for this edge. |
| [**GetProvidersEdgesEdgegroups**](TelephonyProvidersEdgeApi.md#getprovidersedgesedgegroups) | **GET** /api/v2/telephony/providers/edges/edgegroups | Get the list of edge groups. |
| [**GetProvidersEdgesEdgegroupsEdgegroupId**](TelephonyProvidersEdgeApi.md#getprovidersedgesedgegroupsedgegroupid) | **GET** /api/v2/telephony/providers/edges/edgegroups/{edgeGroupId} | Get edge group. |
| [**GetProvidersEdgesEdgeversionreport**](TelephonyProvidersEdgeApi.md#getprovidersedgesedgeversionreport) | **GET** /api/v2/telephony/providers/edges/edgeversionreport | Get the edge version report. |
| [**GetProvidersEdgesEndpoints**](TelephonyProvidersEdgeApi.md#getprovidersedgesendpoints) | **GET** /api/v2/telephony/providers/edges/endpoints | Get endpoints |
| [**GetProvidersEdgesEndpointsEndpointId**](TelephonyProvidersEdgeApi.md#getprovidersedgesendpointsendpointid) | **GET** /api/v2/telephony/providers/edges/endpoints/{endpointId} | Get endpoint |
| [**GetProvidersEdgesExtensionpools**](TelephonyProvidersEdgeApi.md#getprovidersedgesextensionpools) | **GET** /api/v2/telephony/providers/edges/extensionpools | Get a listing of extension pools |
| [**GetProvidersEdgesExtensionpoolsExtensionpoolId**](TelephonyProvidersEdgeApi.md#getprovidersedgesextensionpoolsextensionpoolid) | **GET** /api/v2/telephony/providers/edges/extensionpools/{extensionPoolId} | Get an extension pool by ID |
| [**GetProvidersEdgesExtensions**](TelephonyProvidersEdgeApi.md#getprovidersedgesextensions) | **GET** /api/v2/telephony/providers/edges/extensions | Get a listing of extensions |
| [**GetProvidersEdgesExtensionsExtensionId**](TelephonyProvidersEdgeApi.md#getprovidersedgesextensionsextensionid) | **GET** /api/v2/telephony/providers/edges/extensions/{extensionId} | Get an extension by ID. |
| [**GetProvidersEdgesLinebasesettings**](TelephonyProvidersEdgeApi.md#getprovidersedgeslinebasesettings) | **GET** /api/v2/telephony/providers/edges/linebasesettings | Get a listing of line base settings objects |
| [**GetProvidersEdgesLinebasesettingsLinebaseId**](TelephonyProvidersEdgeApi.md#getprovidersedgeslinebasesettingslinebaseid) | **GET** /api/v2/telephony/providers/edges/linebasesettings/{lineBaseId} | Get a line base settings object by ID |
| [**GetProvidersEdgesLines**](TelephonyProvidersEdgeApi.md#getprovidersedgeslines) | **GET** /api/v2/telephony/providers/edges/lines | Get a list of Lines |
| [**GetProvidersEdgesLinesLineId**](TelephonyProvidersEdgeApi.md#getprovidersedgeslineslineid) | **GET** /api/v2/telephony/providers/edges/lines/{lineId} | Get a Line by ID |
| [**GetProvidersEdgesLinesTemplate**](TelephonyProvidersEdgeApi.md#getprovidersedgeslinestemplate) | **GET** /api/v2/telephony/providers/edges/lines/template | Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance |
| [**GetProvidersEdgesOutboundroutes**](TelephonyProvidersEdgeApi.md#getprovidersedgesoutboundroutes) | **GET** /api/v2/telephony/providers/edges/outboundroutes | Get outbound routes |
| [**GetProvidersEdgesOutboundroutesOutboundrouteId**](TelephonyProvidersEdgeApi.md#getprovidersedgesoutboundroutesoutboundrouteid) | **GET** /api/v2/telephony/providers/edges/outboundroutes/{outboundRouteId} | Get outbound route |
| [**GetProvidersEdgesPhonebasesettings**](TelephonyProvidersEdgeApi.md#getprovidersedgesphonebasesettings) | **GET** /api/v2/telephony/providers/edges/phonebasesettings | Get a list of Phone Base Settings objects |
| [**GetProvidersEdgesPhonebasesettingsAvailablemetabases**](TelephonyProvidersEdgeApi.md#getprovidersedgesphonebasesettingsavailablemetabases) | **GET** /api/v2/telephony/providers/edges/phonebasesettings/availablemetabases | Get a list of available makes and models to create a new Phone Base Settings |
| [**GetProvidersEdgesPhonebasesettingsPhonebaseId**](TelephonyProvidersEdgeApi.md#getprovidersedgesphonebasesettingsphonebaseid) | **GET** /api/v2/telephony/providers/edges/phonebasesettings/{phoneBaseId} | Get a Phone Base Settings object by ID |
| [**GetProvidersEdgesPhonebasesettingsTemplate**](TelephonyProvidersEdgeApi.md#getprovidersedgesphonebasesettingstemplate) | **GET** /api/v2/telephony/providers/edges/phonebasesettings/template | Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance |
| [**GetProvidersEdgesPhones**](TelephonyProvidersEdgeApi.md#getprovidersedgesphones) | **GET** /api/v2/telephony/providers/edges/phones | Get a list of Phone Instances |
| [**GetProvidersEdgesPhonesPhoneId**](TelephonyProvidersEdgeApi.md#getprovidersedgesphonesphoneid) | **GET** /api/v2/telephony/providers/edges/phones/{phoneId} | Get a Phone by ID |
| [**GetProvidersEdgesPhonesTemplate**](TelephonyProvidersEdgeApi.md#getprovidersedgesphonestemplate) | **GET** /api/v2/telephony/providers/edges/phones/template | Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance |
| [**GetProvidersEdgesSites**](TelephonyProvidersEdgeApi.md#getprovidersedgessites) | **GET** /api/v2/telephony/providers/edges/sites | Get the list of sites. |
| [**GetProvidersEdgesSitesSiteId**](TelephonyProvidersEdgeApi.md#getprovidersedgessitessiteid) | **GET** /api/v2/telephony/providers/edges/sites/{siteId} | Get endpoint. |
| [**GetProvidersEdgesSitesSiteIdNumberplans**](TelephonyProvidersEdgeApi.md#getprovidersedgessitessiteidnumberplans) | **GET** /api/v2/telephony/providers/edges/sites/{siteId}/numberplans | Get the list of Number Plans for this Site. |
| [**GetProvidersEdgesSitesSiteIdNumberplansClassifications**](TelephonyProvidersEdgeApi.md#getprovidersedgessitessiteidnumberplansclassifications) | **GET** /api/v2/telephony/providers/edges/sites/{siteId}/numberplans/classifications | Get a list of Classifications for this Site |
| [**GetProvidersEdgesSitesSiteIdNumberplansNumberplanId**](TelephonyProvidersEdgeApi.md#getprovidersedgessitessiteidnumberplansnumberplanid) | **GET** /api/v2/telephony/providers/edges/sites/{siteId}/numberplans/{numberPlanId} | Get a Number Plan by ID. |
| [**GetProvidersEdgesTimezones**](TelephonyProvidersEdgeApi.md#getprovidersedgestimezones) | **GET** /api/v2/telephony/providers/edges/timezones | Get a list of Edge-compatible time zones |
| [**GetProvidersEdgesTrunkbasesettings**](TelephonyProvidersEdgeApi.md#getprovidersedgestrunkbasesettings) | **GET** /api/v2/telephony/providers/edges/trunkbasesettings | Get Trunk Base Settings listing |
| [**GetProvidersEdgesTrunkbasesettingsAvailablemetabases**](TelephonyProvidersEdgeApi.md#getprovidersedgestrunkbasesettingsavailablemetabases) | **GET** /api/v2/telephony/providers/edges/trunkbasesettings/availablemetabases | Get a list of available makes and models to create a new Trunk Base Settings |
| [**GetProvidersEdgesTrunkbasesettingsTemplate**](TelephonyProvidersEdgeApi.md#getprovidersedgestrunkbasesettingstemplate) | **GET** /api/v2/telephony/providers/edges/trunkbasesettings/template | Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance |
| [**GetProvidersEdgesTrunkbasesettingsTrunkbasesettingsId**](TelephonyProvidersEdgeApi.md#getprovidersedgestrunkbasesettingstrunkbasesettingsid) | **GET** /api/v2/telephony/providers/edges/trunkbasesettings/{trunkBaseSettingsId} | Get a Trunk Base Settings object by ID |
| [**GetSchemasEdgesVnext**](TelephonyProvidersEdgeApi.md#getschemasedgesvnext) | **GET** /api/v2/configuration/schemas/edges/vnext | Lists available schema categories |
| [**GetSchemasEdgesVnextSchemacategory**](TelephonyProvidersEdgeApi.md#getschemasedgesvnextschemacategory) | **GET** /api/v2/configuration/schemas/edges/vnext/{schemaCategory} | List schemas of a specific category |
| [**GetSchemasEdgesVnextSchemacategorySchematype**](TelephonyProvidersEdgeApi.md#getschemasedgesvnextschemacategoryschematype) | **GET** /api/v2/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType} | List schemas of a specific category |
| [**GetSchemasEdgesVnextSchemacategorySchematypeSchemaId**](TelephonyProvidersEdgeApi.md#getschemasedgesvnextschemacategoryschematypeschemaid) | **GET** /api/v2/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}/{schemaId} | Get a json schema |
| [**GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId**](TelephonyProvidersEdgeApi.md#getschemasedgesvnextschemacategoryschematypeschemaidextensionmetadataid) | **GET** /api/v2/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}/{schemaId}/{extension}/{metadataId} | Get metadata for a schema |
| [**PostProvidersEdges**](TelephonyProvidersEdgeApi.md#postprovidersedges) | **POST** /api/v2/telephony/providers/edges | Create a edge. |
| [**PostProvidersEdgesAddressvalidation**](TelephonyProvidersEdgeApi.md#postprovidersedgesaddressvalidation) | **POST** /api/v2/telephony/providers/edges/addressvalidation | Validates a street address |
| [**PostProvidersEdgesCertificateauthorities**](TelephonyProvidersEdgeApi.md#postprovidersedgescertificateauthorities) | **POST** /api/v2/telephony/providers/edges/certificateauthorities | Create a certificate authority. |
| [**PostProvidersEdgesDidpools**](TelephonyProvidersEdgeApi.md#postprovidersedgesdidpools) | **POST** /api/v2/telephony/providers/edges/didpools | Create a new DID pool |
| [**PostProvidersEdgesEdgeIdLogicalinterfaces**](TelephonyProvidersEdgeApi.md#postprovidersedgesedgeidlogicalinterfaces) | **POST** /api/v2/telephony/providers/edges/{edgeId}/logicalinterfaces | Create an edge logical interface. |
| [**PostProvidersEdgesEdgeIdLogsJobs**](TelephonyProvidersEdgeApi.md#postprovidersedgesedgeidlogsjobs) | **POST** /api/v2/telephony/providers/edges/{edgeId}/logs/jobs | Create a job to upload a list of Edge logs. |
| [**PostProvidersEdgesEdgeIdLogsJobsJobIdUpload**](TelephonyProvidersEdgeApi.md#postprovidersedgesedgeidlogsjobsjobidupload) | **POST** /api/v2/telephony/providers/edges/{edgeId}/logs/jobs/{jobId}/upload | Request that the specified fileIds be uploaded from the Edge. |
| [**PostProvidersEdgesEdgeIdReboot**](TelephonyProvidersEdgeApi.md#postprovidersedgesedgeidreboot) | **POST** /api/v2/telephony/providers/edges/{edgeId}/reboot | Reboot an Edge |
| [**PostProvidersEdgesEdgeIdSoftwareupdate**](TelephonyProvidersEdgeApi.md#postprovidersedgesedgeidsoftwareupdate) | **POST** /api/v2/telephony/providers/edges/{edgeId}/softwareupdate | Starts a software update for this edge. |
| [**PostProvidersEdgesEdgeIdUnpair**](TelephonyProvidersEdgeApi.md#postprovidersedgesedgeidunpair) | **POST** /api/v2/telephony/providers/edges/{edgeId}/unpair | Unpair an Edge |
| [**PostProvidersEdgesEdgegroups**](TelephonyProvidersEdgeApi.md#postprovidersedgesedgegroups) | **POST** /api/v2/telephony/providers/edges/edgegroups | Create an edge group. |
| [**PostProvidersEdgesEndpoints**](TelephonyProvidersEdgeApi.md#postprovidersedgesendpoints) | **POST** /api/v2/telephony/providers/edges/endpoints | Create endpoint |
| [**PostProvidersEdgesExtensionpools**](TelephonyProvidersEdgeApi.md#postprovidersedgesextensionpools) | **POST** /api/v2/telephony/providers/edges/extensionpools | Create a new extension pool |
| [**PostProvidersEdgesOutboundroutes**](TelephonyProvidersEdgeApi.md#postprovidersedgesoutboundroutes) | **POST** /api/v2/telephony/providers/edges/outboundroutes | Create outbound rule |
| [**PostProvidersEdgesPhonebasesettings**](TelephonyProvidersEdgeApi.md#postprovidersedgesphonebasesettings) | **POST** /api/v2/telephony/providers/edges/phonebasesettings | Create a new Phone Base Settings object |
| [**PostProvidersEdgesPhones**](TelephonyProvidersEdgeApi.md#postprovidersedgesphones) | **POST** /api/v2/telephony/providers/edges/phones | Create a new Phone |
| [**PostProvidersEdgesPhonesPhoneIdReboot**](TelephonyProvidersEdgeApi.md#postprovidersedgesphonesphoneidreboot) | **POST** /api/v2/telephony/providers/edges/phones/{phoneId}/reboot | Reboot a Phone |
| [**PostProvidersEdgesPhonesReboot**](TelephonyProvidersEdgeApi.md#postprovidersedgesphonesreboot) | **POST** /api/v2/telephony/providers/edges/phones/reboot | Reboot Multiple Phones |
| [**PostProvidersEdgesSites**](TelephonyProvidersEdgeApi.md#postprovidersedgessites) | **POST** /api/v2/telephony/providers/edges/sites | Create a endpoint. |
| [**PostProvidersEdgesSitesSiteIdRebalance**](TelephonyProvidersEdgeApi.md#postprovidersedgessitessiteidrebalance) | **POST** /api/v2/telephony/providers/edges/sites/{siteId}/rebalance | Triggers the rebalance operation. |
| [**PostProvidersEdgesTrunkbasesettings**](TelephonyProvidersEdgeApi.md#postprovidersedgestrunkbasesettings) | **POST** /api/v2/telephony/providers/edges/trunkbasesettings | Create a Trunk Base Settings object |
| [**PutProvidersEdgesCertificateauthoritiesCertificateId**](TelephonyProvidersEdgeApi.md#putprovidersedgescertificateauthoritiescertificateid) | **PUT** /api/v2/telephony/providers/edges/certificateauthorities/{certificateId} | Update a certificate authority. |
| [**PutProvidersEdgesDidpoolsDidpoolId**](TelephonyProvidersEdgeApi.md#putprovidersedgesdidpoolsdidpoolid) | **PUT** /api/v2/telephony/providers/edges/didpools/{didPoolId} | Update a DID Pool by ID. |
| [**PutProvidersEdgesDidsDidId**](TelephonyProvidersEdgeApi.md#putprovidersedgesdidsdidid) | **PUT** /api/v2/telephony/providers/edges/dids/{didId} | Update a DID by ID. |
| [**PutProvidersEdgesEdgeId**](TelephonyProvidersEdgeApi.md#putprovidersedgesedgeid) | **PUT** /api/v2/telephony/providers/edges/{edgeId} | Update a edge. |
| [**PutProvidersEdgesEdgeIdLinesLineId**](TelephonyProvidersEdgeApi.md#putprovidersedgesedgeidlineslineid) | **PUT** /api/v2/telephony/providers/edges/{edgeId}/lines/{lineId} | Update a line. |
| [**PutProvidersEdgesEdgeIdLogicalinterfacesInterfaceId**](TelephonyProvidersEdgeApi.md#putprovidersedgesedgeidlogicalinterfacesinterfaceid) | **PUT** /api/v2/telephony/providers/edges/{edgeId}/logicalinterfaces/{interfaceId} | Update an edge logical interface. |
| [**PutProvidersEdgesEdgegroupsEdgegroupId**](TelephonyProvidersEdgeApi.md#putprovidersedgesedgegroupsedgegroupid) | **PUT** /api/v2/telephony/providers/edges/edgegroups/{edgeGroupId} | Update an edge group. |
| [**PutProvidersEdgesEndpointsEndpointId**](TelephonyProvidersEdgeApi.md#putprovidersedgesendpointsendpointid) | **PUT** /api/v2/telephony/providers/edges/endpoints/{endpointId} | Update endpoint |
| [**PutProvidersEdgesExtensionpoolsExtensionpoolId**](TelephonyProvidersEdgeApi.md#putprovidersedgesextensionpoolsextensionpoolid) | **PUT** /api/v2/telephony/providers/edges/extensionpools/{extensionPoolId} | Update an extension pool by ID |
| [**PutProvidersEdgesExtensionsExtensionId**](TelephonyProvidersEdgeApi.md#putprovidersedgesextensionsextensionid) | **PUT** /api/v2/telephony/providers/edges/extensions/{extensionId} | Update an extension by ID. |
| [**PutProvidersEdgesOutboundroutesOutboundrouteId**](TelephonyProvidersEdgeApi.md#putprovidersedgesoutboundroutesoutboundrouteid) | **PUT** /api/v2/telephony/providers/edges/outboundroutes/{outboundRouteId} | Update outbound route |
| [**PutProvidersEdgesPhonebasesettingsPhonebaseId**](TelephonyProvidersEdgeApi.md#putprovidersedgesphonebasesettingsphonebaseid) | **PUT** /api/v2/telephony/providers/edges/phonebasesettings/{phoneBaseId} | Update a Phone Base Settings by ID |
| [**PutProvidersEdgesPhonesPhoneId**](TelephonyProvidersEdgeApi.md#putprovidersedgesphonesphoneid) | **PUT** /api/v2/telephony/providers/edges/phones/{phoneId} | Update a Phone by ID |
| [**PutProvidersEdgesSitesSiteId**](TelephonyProvidersEdgeApi.md#putprovidersedgessitessiteid) | **PUT** /api/v2/telephony/providers/edges/sites/{siteId} | Update a endpoint. |
| [**PutProvidersEdgesSitesSiteIdNumberplans**](TelephonyProvidersEdgeApi.md#putprovidersedgessitessiteidnumberplans) | **PUT** /api/v2/telephony/providers/edges/sites/{siteId}/numberplans | Update the list of Number Plans. |
| [**PutProvidersEdgesTrunkbasesettingsTrunkbasesettingsId**](TelephonyProvidersEdgeApi.md#putprovidersedgestrunkbasesettingstrunkbasesettingsid) | **PUT** /api/v2/telephony/providers/edges/trunkbasesettings/{trunkBaseSettingsId} | Update a Trunk Base Settings object by ID |
{: class="table table-striped"}

<a name="DeleteProvidersEdgesCertificateauthoritiesCertificateId"></a>
## string** DeleteProvidersEdgesCertificateauthoritiesCertificateId (string certificateId)

Delete a certificate authority.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteProvidersEdgesCertificateauthoritiesCertificateIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var certificateId = certificateId_example;  // string | Certificate ID

            try
            {
                // Delete a certificate authority.
                string result = apiInstance.DeleteProvidersEdgesCertificateauthoritiesCertificateId(certificateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteProvidersEdgesCertificateauthoritiesCertificateId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **certificateId** | **string**| Certificate ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="DeleteProvidersEdgesDidpoolsDidpoolId"></a>
## string** DeleteProvidersEdgesDidpoolsDidpoolId (string didPoolId)

Delete a DID Pool by ID.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteProvidersEdgesDidpoolsDidpoolIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var didPoolId = didPoolId_example;  // string | DID pool ID

            try
            {
                // Delete a DID Pool by ID.
                string result = apiInstance.DeleteProvidersEdgesDidpoolsDidpoolId(didPoolId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteProvidersEdgesDidpoolsDidpoolId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **didPoolId** | **string**| DID pool ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="DeleteProvidersEdgesEdgeId"></a>
## string** DeleteProvidersEdgesEdgeId (string edgeId)

Delete a edge.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteProvidersEdgesEdgeIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            {
                // Delete a edge.
                string result = apiInstance.DeleteProvidersEdgesEdgeId(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteProvidersEdgesEdgeId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="DeleteProvidersEdgesEdgeIdLogicalinterfacesInterfaceId"></a>
## void DeleteProvidersEdgesEdgeIdLogicalinterfacesInterfaceId (string edgeId, string interfaceId)

Delete an edge logical interface



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteProvidersEdgesEdgeIdLogicalinterfacesInterfaceIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var interfaceId = interfaceId_example;  // string | Interface ID

            try
            {
                // Delete an edge logical interface
                apiInstance.DeleteProvidersEdgesEdgeIdLogicalinterfacesInterfaceId(edgeId, interfaceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteProvidersEdgesEdgeIdLogicalinterfacesInterfaceId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **interfaceId** | **string**| Interface ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="DeleteProvidersEdgesEdgeIdSoftwareupdate"></a>
## string** DeleteProvidersEdgesEdgeIdSoftwareupdate (string edgeId)

Cancels any in-progress update for this edge.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteProvidersEdgesEdgeIdSoftwareupdateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            {
                // Cancels any in-progress update for this edge.
                string result = apiInstance.DeleteProvidersEdgesEdgeIdSoftwareupdate(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteProvidersEdgesEdgeIdSoftwareupdate: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="DeleteProvidersEdgesEdgegroupsEdgegroupId"></a>
## string** DeleteProvidersEdgesEdgegroupsEdgegroupId (string edgeGroupId)

Delete an edge group.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteProvidersEdgesEdgegroupsEdgegroupIdExample
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
                string result = apiInstance.DeleteProvidersEdgesEdgegroupsEdgegroupId(edgeGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteProvidersEdgesEdgegroupsEdgegroupId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeGroupId** | **string**| Edge group ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="DeleteProvidersEdgesEndpointsEndpointId"></a>
## string** DeleteProvidersEdgesEndpointsEndpointId (string endpointId)

Delete endpoint



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteProvidersEdgesEndpointsEndpointIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var endpointId = endpointId_example;  // string | Endpoint ID

            try
            {
                // Delete endpoint
                string result = apiInstance.DeleteProvidersEdgesEndpointsEndpointId(endpointId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteProvidersEdgesEndpointsEndpointId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **endpointId** | **string**| Endpoint ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="DeleteProvidersEdgesExtensionpoolsExtensionpoolId"></a>
## string** DeleteProvidersEdgesExtensionpoolsExtensionpoolId (string extensionPoolId)

Delete an extension pool by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteProvidersEdgesExtensionpoolsExtensionpoolIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var extensionPoolId = extensionPoolId_example;  // string | Extension pool ID

            try
            {
                // Delete an extension pool by ID
                string result = apiInstance.DeleteProvidersEdgesExtensionpoolsExtensionpoolId(extensionPoolId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteProvidersEdgesExtensionpoolsExtensionpoolId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **extensionPoolId** | **string**| Extension pool ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="DeleteProvidersEdgesOutboundroutesOutboundrouteId"></a>
## string** DeleteProvidersEdgesOutboundroutesOutboundrouteId (string outboundRouteId)

Delete Outbound Route



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteProvidersEdgesOutboundroutesOutboundrouteIdExample
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
                string result = apiInstance.DeleteProvidersEdgesOutboundroutesOutboundrouteId(outboundRouteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteProvidersEdgesOutboundroutesOutboundrouteId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **outboundRouteId** | **string**| Outbound route ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="DeleteProvidersEdgesPhonebasesettingsPhonebaseId"></a>
## string** DeleteProvidersEdgesPhonebasesettingsPhonebaseId (string phoneBaseId)

Delete a Phone Base Settings by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteProvidersEdgesPhonebasesettingsPhonebaseIdExample
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
                string result = apiInstance.DeleteProvidersEdgesPhonebasesettingsPhonebaseId(phoneBaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteProvidersEdgesPhonebasesettingsPhonebaseId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneBaseId** | **string**| Phone base ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="DeleteProvidersEdgesPhonesPhoneId"></a>
## string** DeleteProvidersEdgesPhonesPhoneId (string phoneId)

Delete a Phone by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteProvidersEdgesPhonesPhoneIdExample
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
                string result = apiInstance.DeleteProvidersEdgesPhonesPhoneId(phoneId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteProvidersEdgesPhonesPhoneId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneId** | **string**| Phone ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="DeleteProvidersEdgesSitesSiteId"></a>
## string** DeleteProvidersEdgesSitesSiteId (string siteId)

Delete an ednpoint



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteProvidersEdgesSitesSiteIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID

            try
            {
                // Delete an ednpoint
                string result = apiInstance.DeleteProvidersEdgesSitesSiteId(siteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteProvidersEdgesSitesSiteId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="DeleteProvidersEdgesTrunkbasesettingsTrunkbasesettingsId"></a>
## string** DeleteProvidersEdgesTrunkbasesettingsTrunkbasesettingsId (string trunkBaseSettingsId)

Delete a Trunk Base Settings object by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteProvidersEdgesTrunkbasesettingsTrunkbasesettingsIdExample
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
                string result = apiInstance.DeleteProvidersEdgesTrunkbasesettingsTrunkbasesettingsId(trunkBaseSettingsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteProvidersEdgesTrunkbasesettingsTrunkbasesettingsId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trunkBaseSettingsId** | **string**| Trunk Base ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="GetProvidersEdges"></a>
## [**EdgeEntityListing**](EdgeEntityListing.html) GetProvidersEdges (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null)

Get the list of edges.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesExample
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
            var edgeGroupId = edgeGroupId_example;  // string | Filter by edgeGroup.id (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)

            try
            {
                // Get the list of edges.
                EdgeEntityListing result = apiInstance.GetProvidersEdges(pageSize, pageNumber, name, siteId, edgeGroupId, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdges: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **name** | **string**| Name | [optional]  |
| **siteId** | **string**| Filter by site.id | [optional]  |
| **edgeGroupId** | **string**| Filter by edgeGroup.id | [optional]  |
| **sortBy** | **string**| Sort by | [optional] [default to name] |
{: class="table table-striped"}

### Return type

[**EdgeEntityListing**](EdgeEntityListing.md)

<a name="GetProvidersEdgesCertificateauthorities"></a>
## [**CertificateAuthorityEntityListing**](CertificateAuthorityEntityListing.html) GetProvidersEdgesCertificateauthorities ()

Get the list of certificate authorities.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesCertificateauthoritiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();

            try
            {
                // Get the list of certificate authorities.
                CertificateAuthorityEntityListing result = apiInstance.GetProvidersEdgesCertificateauthorities();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesCertificateauthorities: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**CertificateAuthorityEntityListing**](CertificateAuthorityEntityListing.md)

<a name="GetProvidersEdgesCertificateauthoritiesCertificateId"></a>
## [**DomainCertificateAuthority**](DomainCertificateAuthority.html) GetProvidersEdgesCertificateauthoritiesCertificateId (string certificateId)

Get a certificate authority.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesCertificateauthoritiesCertificateIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var certificateId = certificateId_example;  // string | Certificate ID

            try
            {
                // Get a certificate authority.
                DomainCertificateAuthority result = apiInstance.GetProvidersEdgesCertificateauthoritiesCertificateId(certificateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesCertificateauthoritiesCertificateId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **certificateId** | **string**| Certificate ID |  |
{: class="table table-striped"}

### Return type

[**DomainCertificateAuthority**](DomainCertificateAuthority.md)

<a name="GetProvidersEdgesDidpools"></a>
## [**DIDPoolEntityListing**](DIDPoolEntityListing.html) GetProvidersEdgesDidpools (int? pageSize = null, int? pageNumber = null, string sortBy = null)

Get a listing of DID Pools



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesDidpoolsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to number)

            try
            {
                // Get a listing of DID Pools
                DIDPoolEntityListing result = apiInstance.GetProvidersEdgesDidpools(pageSize, pageNumber, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesDidpools: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to number] |
{: class="table table-striped"}

### Return type

[**DIDPoolEntityListing**](DIDPoolEntityListing.md)

<a name="GetProvidersEdgesDidpoolsDidpoolId"></a>
## [**DIDPool**](DIDPool.html) GetProvidersEdgesDidpoolsDidpoolId (string didPoolId)

Get a DID Pool by ID.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesDidpoolsDidpoolIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var didPoolId = didPoolId_example;  // string | DID pool ID

            try
            {
                // Get a DID Pool by ID.
                DIDPool result = apiInstance.GetProvidersEdgesDidpoolsDidpoolId(didPoolId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesDidpoolsDidpoolId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **didPoolId** | **string**| DID pool ID |  |
{: class="table table-striped"}

### Return type

[**DIDPool**](DIDPool.md)

<a name="GetProvidersEdgesDids"></a>
## [**DIDEntityListing**](DIDEntityListing.html) GetProvidersEdgesDids (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null)

Get a listing of DIDs



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesDidsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to number)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ASC)
            var phoneNumber = phoneNumber_example;  // string | Filter by phoneNumber (optional) 

            try
            {
                // Get a listing of DIDs
                DIDEntityListing result = apiInstance.GetProvidersEdgesDids(pageSize, pageNumber, sortBy, sortOrder, phoneNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesDids: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to number] |
| **sortOrder** | **string**| Sort order | [optional] [default to ASC] |
| **phoneNumber** | **string**| Filter by phoneNumber | [optional]  |
{: class="table table-striped"}

### Return type

[**DIDEntityListing**](DIDEntityListing.md)

<a name="GetProvidersEdgesDidsDidId"></a>
## [**DID**](DID.html) GetProvidersEdgesDidsDidId (string didId)

Get a DID by ID.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesDidsDidIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var didId = didId_example;  // string | DID ID

            try
            {
                // Get a DID by ID.
                DID result = apiInstance.GetProvidersEdgesDidsDidId(didId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesDidsDidId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **didId** | **string**| DID ID |  |
{: class="table table-striped"}

### Return type

[**DID**](DID.md)

<a name="GetProvidersEdgesEdgeId"></a>
## [**Edge**](Edge.html) GetProvidersEdgesEdgeId (string edgeId)

Get edge.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesEdgeIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            {
                // Get edge.
                Edge result = apiInstance.GetProvidersEdgesEdgeId(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesEdgeId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
{: class="table table-striped"}

### Return type

[**Edge**](Edge.md)

<a name="GetProvidersEdgesEdgeIdLines"></a>
## [**EdgeLineEntityListing**](EdgeLineEntityListing.html) GetProvidersEdgesEdgeIdLines (string edgeId, int? pageSize = null, int? pageNumber = null)

Get the list of lines.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesEdgeIdLinesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get the list of lines.
                EdgeLineEntityListing result = apiInstance.GetProvidersEdgesEdgeIdLines(edgeId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesEdgeIdLines: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**EdgeLineEntityListing**](EdgeLineEntityListing.md)

<a name="GetProvidersEdgesEdgeIdLinesLineId"></a>
## [**EdgeLine**](EdgeLine.html) GetProvidersEdgesEdgeIdLinesLineId (string edgeId, string lineId)

Get line



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesEdgeIdLinesLineIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var lineId = lineId_example;  // string | Line ID

            try
            {
                // Get line
                EdgeLine result = apiInstance.GetProvidersEdgesEdgeIdLinesLineId(edgeId, lineId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesEdgeIdLinesLineId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **lineId** | **string**| Line ID |  |
{: class="table table-striped"}

### Return type

[**EdgeLine**](EdgeLine.md)

<a name="GetProvidersEdgesEdgeIdLogicalinterfaces"></a>
## [**LogicalInterfaceEntityListing**](LogicalInterfaceEntityListing.html) GetProvidersEdgesEdgeIdLogicalinterfaces (string edgeId)

Get edge logical interfaces.

Retrieve a list of all configured logical interfaces from a specific edge.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesEdgeIdLogicalinterfacesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            {
                // Get edge logical interfaces.
                LogicalInterfaceEntityListing result = apiInstance.GetProvidersEdgesEdgeIdLogicalinterfaces(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesEdgeIdLogicalinterfaces: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
{: class="table table-striped"}

### Return type

[**LogicalInterfaceEntityListing**](LogicalInterfaceEntityListing.md)

<a name="GetProvidersEdgesEdgeIdLogicalinterfacesInterfaceId"></a>
## [**DomainLogicalInterface**](DomainLogicalInterface.html) GetProvidersEdgesEdgeIdLogicalinterfacesInterfaceId (string edgeId, string interfaceId)

Get an edge logical interface



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesEdgeIdLogicalinterfacesInterfaceIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var interfaceId = interfaceId_example;  // string | Interface ID

            try
            {
                // Get an edge logical interface
                DomainLogicalInterface result = apiInstance.GetProvidersEdgesEdgeIdLogicalinterfacesInterfaceId(edgeId, interfaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesEdgeIdLogicalinterfacesInterfaceId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **interfaceId** | **string**| Interface ID |  |
{: class="table table-striped"}

### Return type

[**DomainLogicalInterface**](DomainLogicalInterface.md)

<a name="GetProvidersEdgesEdgeIdLogsJobsJobId"></a>
## [**EdgeLogsJob**](EdgeLogsJob.html) GetProvidersEdgesEdgeIdLogsJobsJobId (string edgeId, string jobId)

Get an Edge logs job.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesEdgeIdLogsJobsJobIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var jobId = jobId_example;  // string | Job ID

            try
            {
                // Get an Edge logs job.
                EdgeLogsJob result = apiInstance.GetProvidersEdgesEdgeIdLogsJobsJobId(edgeId, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesEdgeIdLogsJobsJobId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **jobId** | **string**| Job ID |  |
{: class="table table-striped"}

### Return type

[**EdgeLogsJob**](EdgeLogsJob.md)

<a name="GetProvidersEdgesEdgeIdPhysicalinterfaces"></a>
## [**PhysicalInterfaceEntityListing**](PhysicalInterfaceEntityListing.html) GetProvidersEdgesEdgeIdPhysicalinterfaces (string edgeId)

Retrieve a list of all configured physical interfaces from a specific edge.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesEdgeIdPhysicalinterfacesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            {
                // Retrieve a list of all configured physical interfaces from a specific edge.
                PhysicalInterfaceEntityListing result = apiInstance.GetProvidersEdgesEdgeIdPhysicalinterfaces(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesEdgeIdPhysicalinterfaces: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
{: class="table table-striped"}

### Return type

[**PhysicalInterfaceEntityListing**](PhysicalInterfaceEntityListing.md)

<a name="GetProvidersEdgesEdgeIdPhysicalinterfacesInterfaceId"></a>
## [**DomainPhysicalInterface**](DomainPhysicalInterface.html) GetProvidersEdgesEdgeIdPhysicalinterfacesInterfaceId (string edgeId, string interfaceId)

Get edge physical interface.

Retrieve a physical interface from a specific edge.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesEdgeIdPhysicalinterfacesInterfaceIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var interfaceId = interfaceId_example;  // string | Interface ID

            try
            {
                // Get edge physical interface.
                DomainPhysicalInterface result = apiInstance.GetProvidersEdgesEdgeIdPhysicalinterfacesInterfaceId(edgeId, interfaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesEdgeIdPhysicalinterfacesInterfaceId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **interfaceId** | **string**| Interface ID |  |
{: class="table table-striped"}

### Return type

[**DomainPhysicalInterface**](DomainPhysicalInterface.md)

<a name="GetProvidersEdgesEdgeIdSoftwareupdate"></a>
## [**DomainEdgeSoftwareUpdateDto**](DomainEdgeSoftwareUpdateDto.html) GetProvidersEdgesEdgeIdSoftwareupdate (string edgeId)

Gets software update status information about any edge.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesEdgeIdSoftwareupdateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            {
                // Gets software update status information about any edge.
                DomainEdgeSoftwareUpdateDto result = apiInstance.GetProvidersEdgesEdgeIdSoftwareupdate(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesEdgeIdSoftwareupdate: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
{: class="table table-striped"}

### Return type

[**DomainEdgeSoftwareUpdateDto**](DomainEdgeSoftwareUpdateDto.md)

<a name="GetProvidersEdgesEdgeIdSoftwareversions"></a>
## [**DomainEdgeSoftwareVersionDto**](DomainEdgeSoftwareVersionDto.html) GetProvidersEdgesEdgeIdSoftwareversions (string edgeId)

Gets all the available software versions for this edge.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesEdgeIdSoftwareversionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            {
                // Gets all the available software versions for this edge.
                DomainEdgeSoftwareVersionDto result = apiInstance.GetProvidersEdgesEdgeIdSoftwareversions(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesEdgeIdSoftwareversions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
{: class="table table-striped"}

### Return type

[**DomainEdgeSoftwareVersionDto**](DomainEdgeSoftwareVersionDto.md)

<a name="GetProvidersEdgesEdgegroups"></a>
## [**EdgeGroupEntityListing**](EdgeGroupEntityListing.html) GetProvidersEdgesEdgegroups (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)

Get the list of edge groups.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesEdgegroupsExample
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
                EdgeGroupEntityListing result = apiInstance.GetProvidersEdgesEdgegroups(pageSize, pageNumber, name, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesEdgegroups: " + e.Message );
            }
        }
    }
}
~~~

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

<a name="GetProvidersEdgesEdgegroupsEdgegroupId"></a>
## [**EdgeGroup**](EdgeGroup.html) GetProvidersEdgesEdgegroupsEdgegroupId (string edgeGroupId)

Get edge group.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesEdgegroupsEdgegroupIdExample
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
                EdgeGroup result = apiInstance.GetProvidersEdgesEdgegroupsEdgegroupId(edgeGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesEdgegroupsEdgegroupId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeGroupId** | **string**| Edge group ID |  |
{: class="table table-striped"}

### Return type

[**EdgeGroup**](EdgeGroup.md)

<a name="GetProvidersEdgesEdgeversionreport"></a>
## [**EdgeVersionReport**](EdgeVersionReport.html) GetProvidersEdgesEdgeversionreport ()

Get the edge version report.

The report will not have consistent data about the edge version(s) until all edges have been reset.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesEdgeversionreportExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();

            try
            {
                // Get the edge version report.
                EdgeVersionReport result = apiInstance.GetProvidersEdgesEdgeversionreport();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesEdgeversionreport: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**EdgeVersionReport**](EdgeVersionReport.md)

<a name="GetProvidersEdgesEndpoints"></a>
## [**EndpointEntityListing**](EndpointEntityListing.html) GetProvidersEdgesEndpoints (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)

Get endpoints



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesEndpointsExample
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
                // Get endpoints
                EndpointEntityListing result = apiInstance.GetProvidersEdgesEndpoints(pageSize, pageNumber, name, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesEndpoints: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional] [default to name] |
{: class="table table-striped"}

### Return type

[**EndpointEntityListing**](EndpointEntityListing.md)

<a name="GetProvidersEdgesEndpointsEndpointId"></a>
## [**Endpoint**](Endpoint.html) GetProvidersEdgesEndpointsEndpointId (string endpointId)

Get endpoint



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesEndpointsEndpointIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var endpointId = endpointId_example;  // string | Endpoint ID

            try
            {
                // Get endpoint
                Endpoint result = apiInstance.GetProvidersEdgesEndpointsEndpointId(endpointId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesEndpointsEndpointId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **endpointId** | **string**| Endpoint ID |  |
{: class="table table-striped"}

### Return type

[**Endpoint**](Endpoint.md)

<a name="GetProvidersEdgesExtensionpools"></a>
## [**ExtensionPoolEntityListing**](ExtensionPoolEntityListing.html) GetProvidersEdgesExtensionpools (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null)

Get a listing of extension pools



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesExtensionpoolsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to startNumber)
            var number = number_example;  // string | Number (optional) 

            try
            {
                // Get a listing of extension pools
                ExtensionPoolEntityListing result = apiInstance.GetProvidersEdgesExtensionpools(pageSize, pageNumber, sortBy, number);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesExtensionpools: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to startNumber] |
| **number** | **string**| Number | [optional]  |
{: class="table table-striped"}

### Return type

[**ExtensionPoolEntityListing**](ExtensionPoolEntityListing.md)

<a name="GetProvidersEdgesExtensionpoolsExtensionpoolId"></a>
## [**ExtensionPool**](ExtensionPool.html) GetProvidersEdgesExtensionpoolsExtensionpoolId (string extensionPoolId)

Get an extension pool by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesExtensionpoolsExtensionpoolIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var extensionPoolId = extensionPoolId_example;  // string | Extension pool ID

            try
            {
                // Get an extension pool by ID
                ExtensionPool result = apiInstance.GetProvidersEdgesExtensionpoolsExtensionpoolId(extensionPoolId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesExtensionpoolsExtensionpoolId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **extensionPoolId** | **string**| Extension pool ID |  |
{: class="table table-striped"}

### Return type

[**ExtensionPool**](ExtensionPool.md)

<a name="GetProvidersEdgesExtensions"></a>
## [**ExtensionEntityListing**](ExtensionEntityListing.html) GetProvidersEdgesExtensions (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null)

Get a listing of extensions



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesExtensionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to number)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ASC)
            var number = number_example;  // string | Filter by number (optional) 

            try
            {
                // Get a listing of extensions
                ExtensionEntityListing result = apiInstance.GetProvidersEdgesExtensions(pageSize, pageNumber, sortBy, sortOrder, number);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesExtensions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to number] |
| **sortOrder** | **string**| Sort order | [optional] [default to ASC] |
| **number** | **string**| Filter by number | [optional]  |
{: class="table table-striped"}

### Return type

[**ExtensionEntityListing**](ExtensionEntityListing.md)

<a name="GetProvidersEdgesExtensionsExtensionId"></a>
## [**Extension**](Extension.html) GetProvidersEdgesExtensionsExtensionId (string extensionId)

Get an extension by ID.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesExtensionsExtensionIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var extensionId = extensionId_example;  // string | Extension ID

            try
            {
                // Get an extension by ID.
                Extension result = apiInstance.GetProvidersEdgesExtensionsExtensionId(extensionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesExtensionsExtensionId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **extensionId** | **string**| Extension ID |  |
{: class="table table-striped"}

### Return type

[**Extension**](Extension.md)

<a name="GetProvidersEdgesLinebasesettings"></a>
## [**LineBaseEntityListing**](LineBaseEntityListing.html) GetProvidersEdgesLinebasesettings (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)

Get a listing of line base settings objects



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesLinebasesettingsExample
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
                LineBaseEntityListing result = apiInstance.GetProvidersEdgesLinebasesettings(pageNumber, pageSize, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesLinebasesettings: " + e.Message );
            }
        }
    }
}
~~~

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

<a name="GetProvidersEdgesLinebasesettingsLinebaseId"></a>
## [**LineBase**](LineBase.html) GetProvidersEdgesLinebasesettingsLinebaseId (string lineBaseId)

Get a line base settings object by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesLinebasesettingsLinebaseIdExample
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
                LineBase result = apiInstance.GetProvidersEdgesLinebasesettingsLinebaseId(lineBaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesLinebasesettingsLinebaseId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **lineBaseId** | **string**| Line base ID |  |
{: class="table table-striped"}

### Return type

[**LineBase**](LineBase.md)

<a name="GetProvidersEdgesLines"></a>
## [**LineEntityListing**](LineEntityListing.html) GetProvidersEdgesLines (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, List<string> expand = null)

Get a list of Lines



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesLinesExample
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
                LineEntityListing result = apiInstance.GetProvidersEdgesLines(pageSize, pageNumber, name, sortBy, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesLines: " + e.Message );
            }
        }
    }
}
~~~

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

<a name="GetProvidersEdgesLinesLineId"></a>
## [**Line**](Line.html) GetProvidersEdgesLinesLineId (string lineId)

Get a Line by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesLinesLineIdExample
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
                Line result = apiInstance.GetProvidersEdgesLinesLineId(lineId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesLinesLineId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **lineId** | **string**| Line ID |  |
{: class="table table-striped"}

### Return type

[**Line**](Line.md)

<a name="GetProvidersEdgesLinesTemplate"></a>
## [**Line**](Line.html) GetProvidersEdgesLinesTemplate (string lineBaseSettingsId)

Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesLinesTemplateExample
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
                Line result = apiInstance.GetProvidersEdgesLinesTemplate(lineBaseSettingsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesLinesTemplate: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **lineBaseSettingsId** | **string**| The id of a Line Base Settings object upon which to base this Line |  |
{: class="table table-striped"}

### Return type

[**Line**](Line.md)

<a name="GetProvidersEdgesOutboundroutes"></a>
## [**OutboundRouteEntityListing**](OutboundRouteEntityListing.html) GetProvidersEdgesOutboundroutes (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string sortBy = null)

Get outbound routes



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesOutboundroutesExample
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
                OutboundRouteEntityListing result = apiInstance.GetProvidersEdgesOutboundroutes(pageSize, pageNumber, name, siteId, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesOutboundroutes: " + e.Message );
            }
        }
    }
}
~~~

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

<a name="GetProvidersEdgesOutboundroutesOutboundrouteId"></a>
## [**OutboundRoute**](OutboundRoute.html) GetProvidersEdgesOutboundroutesOutboundrouteId (string outboundRouteId)

Get outbound route



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesOutboundroutesOutboundrouteIdExample
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
                OutboundRoute result = apiInstance.GetProvidersEdgesOutboundroutesOutboundrouteId(outboundRouteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesOutboundroutesOutboundrouteId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **outboundRouteId** | **string**| Outbound route ID |  |
{: class="table table-striped"}

### Return type

[**OutboundRoute**](OutboundRoute.md)

<a name="GetProvidersEdgesPhonebasesettings"></a>
## [**PhoneBaseEntityListing**](PhoneBaseEntityListing.html) GetProvidersEdgesPhonebasesettings (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)

Get a list of Phone Base Settings objects



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesPhonebasesettingsExample
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
                PhoneBaseEntityListing result = apiInstance.GetProvidersEdgesPhonebasesettings(pageNumber, pageSize, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesPhonebasesettings: " + e.Message );
            }
        }
    }
}
~~~

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

<a name="GetProvidersEdgesPhonebasesettingsAvailablemetabases"></a>
## [**PhoneMetaBaseEntityListing**](PhoneMetaBaseEntityListing.html) GetProvidersEdgesPhonebasesettingsAvailablemetabases (int? pageSize = null, int? pageNumber = null)

Get a list of available makes and models to create a new Phone Base Settings



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesPhonebasesettingsAvailablemetabasesExample
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
                PhoneMetaBaseEntityListing result = apiInstance.GetProvidersEdgesPhonebasesettingsAvailablemetabases(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesPhonebasesettingsAvailablemetabases: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**PhoneMetaBaseEntityListing**](PhoneMetaBaseEntityListing.md)

<a name="GetProvidersEdgesPhonebasesettingsPhonebaseId"></a>
## [**PhoneBase**](PhoneBase.html) GetProvidersEdgesPhonebasesettingsPhonebaseId (string phoneBaseId)

Get a Phone Base Settings object by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesPhonebasesettingsPhonebaseIdExample
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
                PhoneBase result = apiInstance.GetProvidersEdgesPhonebasesettingsPhonebaseId(phoneBaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesPhonebasesettingsPhonebaseId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneBaseId** | **string**| Phone base ID |  |
{: class="table table-striped"}

### Return type

[**PhoneBase**](PhoneBase.md)

<a name="GetProvidersEdgesPhonebasesettingsTemplate"></a>
## [**PhoneBase**](PhoneBase.html) GetProvidersEdgesPhonebasesettingsTemplate (string phoneMetabaseId)

Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesPhonebasesettingsTemplateExample
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
                PhoneBase result = apiInstance.GetProvidersEdgesPhonebasesettingsTemplate(phoneMetabaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesPhonebasesettingsTemplate: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneMetabaseId** | **string**| The id of a metabase object upon which to base this Phone Base Settings |  |
{: class="table table-striped"}

### Return type

[**PhoneBase**](PhoneBase.md)

<a name="GetProvidersEdgesPhones"></a>
## [**PhoneEntityListing**](PhoneEntityListing.html) GetProvidersEdgesPhones (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string phoneBaseSettingsId = null, string phoneHardwareId = null, List<string> expand = null, List<string> fields = null)

Get a list of Phone Instances



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesPhonesExample
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
                PhoneEntityListing result = apiInstance.GetProvidersEdgesPhones(pageNumber, pageSize, sortBy, sortOrder, siteId, phoneBaseSettingsId, phoneHardwareId, expand, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesPhones: " + e.Message );
            }
        }
    }
}
~~~

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

<a name="GetProvidersEdgesPhonesPhoneId"></a>
## [**Phone**](Phone.html) GetProvidersEdgesPhonesPhoneId (string phoneId)

Get a Phone by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesPhonesPhoneIdExample
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
                Phone result = apiInstance.GetProvidersEdgesPhonesPhoneId(phoneId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesPhonesPhoneId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneId** | **string**| Phone ID |  |
{: class="table table-striped"}

### Return type

[**Phone**](Phone.md)

<a name="GetProvidersEdgesPhonesTemplate"></a>
## [**Phone**](Phone.html) GetProvidersEdgesPhonesTemplate (string phoneBaseSettingsId)

Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesPhonesTemplateExample
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
                Phone result = apiInstance.GetProvidersEdgesPhonesTemplate(phoneBaseSettingsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesPhonesTemplate: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneBaseSettingsId** | **string**| The id of a Phone Base Settings object upon which to base this Phone |  |
{: class="table table-striped"}

### Return type

[**Phone**](Phone.md)

<a name="GetProvidersEdgesSites"></a>
## [**SiteEntityListing**](SiteEntityListing.html) GetProvidersEdgesSites (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null)

Get the list of sites.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesSitesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to name)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ASC)
            var name = name_example;  // string | Name (optional) 
            var locationId = locationId_example;  // string | Location Id (optional) 

            try
            {
                // Get the list of sites.
                SiteEntityListing result = apiInstance.GetProvidersEdgesSites(pageSize, pageNumber, sortBy, sortOrder, name, locationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesSites: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to name] |
| **sortOrder** | **string**| Sort order | [optional] [default to ASC] |
| **name** | **string**| Name | [optional]  |
| **locationId** | **string**| Location Id | [optional]  |
{: class="table table-striped"}

### Return type

[**SiteEntityListing**](SiteEntityListing.md)

<a name="GetProvidersEdgesSitesSiteId"></a>
## [**Site**](Site.html) GetProvidersEdgesSitesSiteId (string siteId)

Get endpoint.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesSitesSiteIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID

            try
            {
                // Get endpoint.
                Site result = apiInstance.GetProvidersEdgesSitesSiteId(siteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesSitesSiteId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
{: class="table table-striped"}

### Return type

[**Site**](Site.md)

<a name="GetProvidersEdgesSitesSiteIdNumberplans"></a>
## [**List&lt;NumberPlan&gt;**](NumberPlan.html) GetProvidersEdgesSitesSiteIdNumberplans (string siteId)

Get the list of Number Plans for this Site.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesSitesSiteIdNumberplansExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID

            try
            {
                // Get the list of Number Plans for this Site.
                List&lt;NumberPlan&gt; result = apiInstance.GetProvidersEdgesSitesSiteIdNumberplans(siteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesSitesSiteIdNumberplans: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
{: class="table table-striped"}

### Return type

[**List<NumberPlan>**](NumberPlan.md)

<a name="GetProvidersEdgesSitesSiteIdNumberplansClassifications"></a>
## List&lt;string&gt;** GetProvidersEdgesSitesSiteIdNumberplansClassifications (string siteId, string classification = null)

Get a list of Classifications for this Site



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesSitesSiteIdNumberplansClassificationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID
            var classification = classification_example;  // string | Classification (optional) 

            try
            {
                // Get a list of Classifications for this Site
                List&lt;string&gt; result = apiInstance.GetProvidersEdgesSitesSiteIdNumberplansClassifications(siteId, classification);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesSitesSiteIdNumberplansClassifications: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **classification** | **string**| Classification | [optional]  |
{: class="table table-striped"}

### Return type

**List<string>**

<a name="GetProvidersEdgesSitesSiteIdNumberplansNumberplanId"></a>
## [**NumberPlan**](NumberPlan.html) GetProvidersEdgesSitesSiteIdNumberplansNumberplanId (string siteId, string numberPlanId)

Get a Number Plan by ID.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesSitesSiteIdNumberplansNumberplanIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID
            var numberPlanId = numberPlanId_example;  // string | Number Plan ID

            try
            {
                // Get a Number Plan by ID.
                NumberPlan result = apiInstance.GetProvidersEdgesSitesSiteIdNumberplansNumberplanId(siteId, numberPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesSitesSiteIdNumberplansNumberplanId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **numberPlanId** | **string**| Number Plan ID |  |
{: class="table table-striped"}

### Return type

[**NumberPlan**](NumberPlan.md)

<a name="GetProvidersEdgesTimezones"></a>
## [**TimeZoneEntityListing**](TimeZoneEntityListing.html) GetProvidersEdgesTimezones (int? pageSize = null, int? pageNumber = null)

Get a list of Edge-compatible time zones



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesTimezonesExample
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
                TimeZoneEntityListing result = apiInstance.GetProvidersEdgesTimezones(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesTimezones: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 1000] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**TimeZoneEntityListing**](TimeZoneEntityListing.md)

<a name="GetProvidersEdgesTrunkbasesettings"></a>
## [**TrunkBase**](TrunkBase.html) GetProvidersEdgesTrunkbasesettings (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)

Get Trunk Base Settings listing



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesTrunkbasesettingsExample
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
                TrunkBase result = apiInstance.GetProvidersEdgesTrunkbasesettings(pageNumber, pageSize, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesTrunkbasesettings: " + e.Message );
            }
        }
    }
}
~~~

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

<a name="GetProvidersEdgesTrunkbasesettingsAvailablemetabases"></a>
## [**TrunkMetabaseEntityListing**](TrunkMetabaseEntityListing.html) GetProvidersEdgesTrunkbasesettingsAvailablemetabases (string type = null, int? pageSize = null, int? pageNumber = null)

Get a list of available makes and models to create a new Trunk Base Settings



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesTrunkbasesettingsAvailablemetabasesExample
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
                TrunkMetabaseEntityListing result = apiInstance.GetProvidersEdgesTrunkbasesettingsAvailablemetabases(type, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesTrunkbasesettingsAvailablemetabases: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **type** | **string**|  | [optional]  |
| **pageSize** | **int?**|  | [optional] [default to 25] |
| **pageNumber** | **int?**|  | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**TrunkMetabaseEntityListing**](TrunkMetabaseEntityListing.md)

<a name="GetProvidersEdgesTrunkbasesettingsTemplate"></a>
## [**TrunkBase**](TrunkBase.html) GetProvidersEdgesTrunkbasesettingsTemplate (string trunkMetabaseId)

Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesTrunkbasesettingsTemplateExample
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
                TrunkBase result = apiInstance.GetProvidersEdgesTrunkbasesettingsTemplate(trunkMetabaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesTrunkbasesettingsTemplate: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trunkMetabaseId** | **string**| The id of a metabase object upon which to base this Trunk Base Settings |  |
{: class="table table-striped"}

### Return type

[**TrunkBase**](TrunkBase.md)

<a name="GetProvidersEdgesTrunkbasesettingsTrunkbasesettingsId"></a>
## [**TrunkBase**](TrunkBase.html) GetProvidersEdgesTrunkbasesettingsTrunkbasesettingsId (string trunkBaseSettingsId)

Get a Trunk Base Settings object by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesTrunkbasesettingsTrunkbasesettingsIdExample
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
                TrunkBase result = apiInstance.GetProvidersEdgesTrunkbasesettingsTrunkbasesettingsId(trunkBaseSettingsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesTrunkbasesettingsTrunkbasesettingsId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trunkBaseSettingsId** | **string**| Trunk Base ID |  |
{: class="table table-striped"}

### Return type

[**TrunkBase**](TrunkBase.md)

<a name="GetSchemasEdgesVnext"></a>
## [**SchemaCategoryEntityListing**](SchemaCategoryEntityListing.html) GetSchemasEdgesVnext (int? pageSize = null, int? pageNumber = null)

Lists available schema categories



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSchemasEdgesVnextExample
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
                // Lists available schema categories
                SchemaCategoryEntityListing result = apiInstance.GetSchemasEdgesVnext(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetSchemasEdgesVnext: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**SchemaCategoryEntityListing**](SchemaCategoryEntityListing.md)

<a name="GetSchemasEdgesVnextSchemacategory"></a>
## [**SchemaReferenceEntityListing**](SchemaReferenceEntityListing.html) GetSchemasEdgesVnextSchemacategory (string schemaCategory, int? pageSize = null, int? pageNumber = null)

List schemas of a specific category



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSchemasEdgesVnextSchemacategoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var schemaCategory = schemaCategory_example;  // string | Schema category
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // List schemas of a specific category
                SchemaReferenceEntityListing result = apiInstance.GetSchemasEdgesVnextSchemacategory(schemaCategory, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetSchemasEdgesVnextSchemacategory: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaCategory** | **string**| Schema category |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**SchemaReferenceEntityListing**](SchemaReferenceEntityListing.md)

<a name="GetSchemasEdgesVnextSchemacategorySchematype"></a>
## [**SchemaReferenceEntityListing**](SchemaReferenceEntityListing.html) GetSchemasEdgesVnextSchemacategorySchematype (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null)

List schemas of a specific category



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSchemasEdgesVnextSchemacategorySchematypeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var schemaCategory = schemaCategory_example;  // string | Schema category
            var schemaType = schemaType_example;  // string | Schema type
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // List schemas of a specific category
                SchemaReferenceEntityListing result = apiInstance.GetSchemasEdgesVnextSchemacategorySchematype(schemaCategory, schemaType, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetSchemasEdgesVnextSchemacategorySchematype: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaCategory** | **string**| Schema category |  |
| **schemaType** | **string**| Schema type |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**SchemaReferenceEntityListing**](SchemaReferenceEntityListing.md)

<a name="GetSchemasEdgesVnextSchemacategorySchematypeSchemaId"></a>
## [**Organization**](Organization.html) GetSchemasEdgesVnextSchemacategorySchematypeSchemaId (string schemaCategory, string schemaType, string schemaId)

Get a json schema



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var schemaCategory = schemaCategory_example;  // string | Schema category
            var schemaType = schemaType_example;  // string | Schema type
            var schemaId = schemaId_example;  // string | Schema ID

            try
            {
                // Get a json schema
                Organization result = apiInstance.GetSchemasEdgesVnextSchemacategorySchematypeSchemaId(schemaCategory, schemaType, schemaId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetSchemasEdgesVnextSchemacategorySchematypeSchemaId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaCategory** | **string**| Schema category |  |
| **schemaType** | **string**| Schema type |  |
| **schemaId** | **string**| Schema ID |  |
{: class="table table-striped"}

### Return type

[**Organization**](Organization.md)

<a name="GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId"></a>
## [**Organization**](Organization.html) GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null)

Get metadata for a schema



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var schemaCategory = schemaCategory_example;  // string | Schema category
            var schemaType = schemaType_example;  // string | Schema type
            var schemaId = schemaId_example;  // string | Schema ID
            var extension = extension_example;  // string | extension
            var metadataId = metadataId_example;  // string | Metadata ID
            var type = type_example;  // string | Type (optional) 

            try
            {
                // Get metadata for a schema
                Organization result = apiInstance.GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId(schemaCategory, schemaType, schemaId, extension, metadataId, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **schemaCategory** | **string**| Schema category |  |
| **schemaType** | **string**| Schema type |  |
| **schemaId** | **string**| Schema ID |  |
| **extension** | **string**| extension |  |
| **metadataId** | **string**| Metadata ID |  |
| **type** | **string**| Type | [optional]  |
{: class="table table-striped"}

### Return type

[**Organization**](Organization.md)

<a name="PostProvidersEdges"></a>
## [**Edge**](Edge.html) PostProvidersEdges (Edge body = null)

Create a edge.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostProvidersEdgesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new Edge(); // Edge | Edge (optional) 

            try
            {
                // Create a edge.
                Edge result = apiInstance.PostProvidersEdges(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdges: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Edge**](Edge.md)| Edge | [optional]  |
{: class="table table-striped"}

### Return type

[**Edge**](Edge.md)

<a name="PostProvidersEdgesAddressvalidation"></a>
## [**ValidateAddressResponse**](ValidateAddressResponse.html) PostProvidersEdgesAddressvalidation (ValidateAddressRequest body = null)

Validates a street address



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostProvidersEdgesAddressvalidationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new ValidateAddressRequest(); // ValidateAddressRequest |  (optional) 

            try
            {
                // Validates a street address
                ValidateAddressResponse result = apiInstance.PostProvidersEdgesAddressvalidation(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgesAddressvalidation: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ValidateAddressRequest**](ValidateAddressRequest.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**ValidateAddressResponse**](ValidateAddressResponse.md)

<a name="PostProvidersEdgesCertificateauthorities"></a>
## [**DomainCertificateAuthority**](DomainCertificateAuthority.html) PostProvidersEdgesCertificateauthorities (DomainCertificateAuthority body = null)

Create a certificate authority.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostProvidersEdgesCertificateauthoritiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new DomainCertificateAuthority(); // DomainCertificateAuthority | CertificateAuthority (optional) 

            try
            {
                // Create a certificate authority.
                DomainCertificateAuthority result = apiInstance.PostProvidersEdgesCertificateauthorities(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgesCertificateauthorities: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DomainCertificateAuthority**](DomainCertificateAuthority.md)| CertificateAuthority | [optional]  |
{: class="table table-striped"}

### Return type

[**DomainCertificateAuthority**](DomainCertificateAuthority.md)

<a name="PostProvidersEdgesDidpools"></a>
## [**DIDPool**](DIDPool.html) PostProvidersEdgesDidpools (DIDPool body = null)

Create a new DID pool



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostProvidersEdgesDidpoolsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new DIDPool(); // DIDPool |  (optional) 

            try
            {
                // Create a new DID pool
                DIDPool result = apiInstance.PostProvidersEdgesDidpools(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgesDidpools: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DIDPool**](DIDPool.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**DIDPool**](DIDPool.md)

<a name="PostProvidersEdgesEdgeIdLogicalinterfaces"></a>
## [**DomainLogicalInterface**](DomainLogicalInterface.html) PostProvidersEdgesEdgeIdLogicalinterfaces (string edgeId, DomainLogicalInterface body = null)

Create an edge logical interface.

Create

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostProvidersEdgesEdgeIdLogicalinterfacesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var body = new DomainLogicalInterface(); // DomainLogicalInterface |  (optional) 

            try
            {
                // Create an edge logical interface.
                DomainLogicalInterface result = apiInstance.PostProvidersEdgesEdgeIdLogicalinterfaces(edgeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgesEdgeIdLogicalinterfaces: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **body** | [**DomainLogicalInterface**](DomainLogicalInterface.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**DomainLogicalInterface**](DomainLogicalInterface.md)

<a name="PostProvidersEdgesEdgeIdLogsJobs"></a>
## [**EdgeLogsJobResponse**](EdgeLogsJobResponse.html) PostProvidersEdgesEdgeIdLogsJobs (string edgeId, EdgeLogsJobRequest body = null)

Create a job to upload a list of Edge logs.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostProvidersEdgesEdgeIdLogsJobsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var body = new EdgeLogsJobRequest(); // EdgeLogsJobRequest | EdgeLogsJobRequest (optional) 

            try
            {
                // Create a job to upload a list of Edge logs.
                EdgeLogsJobResponse result = apiInstance.PostProvidersEdgesEdgeIdLogsJobs(edgeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgesEdgeIdLogsJobs: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **body** | [**EdgeLogsJobRequest**](EdgeLogsJobRequest.md)| EdgeLogsJobRequest | [optional]  |
{: class="table table-striped"}

### Return type

[**EdgeLogsJobResponse**](EdgeLogsJobResponse.md)

<a name="PostProvidersEdgesEdgeIdLogsJobsJobIdUpload"></a>
## void PostProvidersEdgesEdgeIdLogsJobsJobIdUpload (string edgeId, string jobId, EdgeLogsJobUploadRequest body = null)

Request that the specified fileIds be uploaded from the Edge.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostProvidersEdgesEdgeIdLogsJobsJobIdUploadExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var jobId = jobId_example;  // string | Job ID
            var body = new EdgeLogsJobUploadRequest(); // EdgeLogsJobUploadRequest |  (optional) 

            try
            {
                // Request that the specified fileIds be uploaded from the Edge.
                apiInstance.PostProvidersEdgesEdgeIdLogsJobsJobIdUpload(edgeId, jobId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgesEdgeIdLogsJobsJobIdUpload: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **jobId** | **string**| Job ID |  |
| **body** | [**EdgeLogsJobUploadRequest**](EdgeLogsJobUploadRequest.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="PostProvidersEdgesEdgeIdReboot"></a>
## string** PostProvidersEdgesEdgeIdReboot (string edgeId)

Reboot an Edge



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostProvidersEdgesEdgeIdRebootExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID

            try
            {
                // Reboot an Edge
                string result = apiInstance.PostProvidersEdgesEdgeIdReboot(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgesEdgeIdReboot: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="PostProvidersEdgesEdgeIdSoftwareupdate"></a>
## [**DomainEdgeSoftwareUpdateDto**](DomainEdgeSoftwareUpdateDto.html) PostProvidersEdgesEdgeIdSoftwareupdate (string edgeId, DomainEdgeSoftwareUpdateDto body = null)

Starts a software update for this edge.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostProvidersEdgesEdgeIdSoftwareupdateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var body = new DomainEdgeSoftwareUpdateDto(); // DomainEdgeSoftwareUpdateDto |  (optional) 

            try
            {
                // Starts a software update for this edge.
                DomainEdgeSoftwareUpdateDto result = apiInstance.PostProvidersEdgesEdgeIdSoftwareupdate(edgeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgesEdgeIdSoftwareupdate: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **body** | [**DomainEdgeSoftwareUpdateDto**](DomainEdgeSoftwareUpdateDto.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**DomainEdgeSoftwareUpdateDto**](DomainEdgeSoftwareUpdateDto.md)

<a name="PostProvidersEdgesEdgeIdUnpair"></a>
## string** PostProvidersEdgesEdgeIdUnpair (string edgeId)

Unpair an Edge



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostProvidersEdgesEdgeIdUnpairExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge Id

            try
            {
                // Unpair an Edge
                string result = apiInstance.PostProvidersEdgesEdgeIdUnpair(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgesEdgeIdUnpair: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge Id |  |
{: class="table table-striped"}

### Return type

**string**

<a name="PostProvidersEdgesEdgegroups"></a>
## [**EdgeGroup**](EdgeGroup.html) PostProvidersEdgesEdgegroups (EdgeGroup body = null)

Create an edge group.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostProvidersEdgesEdgegroupsExample
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
                EdgeGroup result = apiInstance.PostProvidersEdgesEdgegroups(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgesEdgegroups: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EdgeGroup**](EdgeGroup.md)| EdgeGroup | [optional]  |
{: class="table table-striped"}

### Return type

[**EdgeGroup**](EdgeGroup.md)

<a name="PostProvidersEdgesEndpoints"></a>
## [**Endpoint**](Endpoint.html) PostProvidersEdgesEndpoints (Endpoint body = null)

Create endpoint



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostProvidersEdgesEndpointsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new Endpoint(); // Endpoint | EndpointTemplate (optional) 

            try
            {
                // Create endpoint
                Endpoint result = apiInstance.PostProvidersEdgesEndpoints(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgesEndpoints: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Endpoint**](Endpoint.md)| EndpointTemplate | [optional]  |
{: class="table table-striped"}

### Return type

[**Endpoint**](Endpoint.md)

<a name="PostProvidersEdgesExtensionpools"></a>
## [**Extension**](Extension.html) PostProvidersEdgesExtensionpools (ExtensionPool body = null)

Create a new extension pool



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostProvidersEdgesExtensionpoolsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new ExtensionPool(); // ExtensionPool | ExtensionPool (optional) 

            try
            {
                // Create a new extension pool
                Extension result = apiInstance.PostProvidersEdgesExtensionpools(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgesExtensionpools: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ExtensionPool**](ExtensionPool.md)| ExtensionPool | [optional]  |
{: class="table table-striped"}

### Return type

[**Extension**](Extension.md)

<a name="PostProvidersEdgesOutboundroutes"></a>
## [**OutboundRoute**](OutboundRoute.html) PostProvidersEdgesOutboundroutes (OutboundRoute body = null)

Create outbound rule



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostProvidersEdgesOutboundroutesExample
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
                OutboundRoute result = apiInstance.PostProvidersEdgesOutboundroutes(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgesOutboundroutes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OutboundRoute**](OutboundRoute.md)| OutboundRoute | [optional]  |
{: class="table table-striped"}

### Return type

[**OutboundRoute**](OutboundRoute.md)

<a name="PostProvidersEdgesPhonebasesettings"></a>
## [**PhoneBase**](PhoneBase.html) PostProvidersEdgesPhonebasesettings (PhoneBase body = null)

Create a new Phone Base Settings object



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostProvidersEdgesPhonebasesettingsExample
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
                PhoneBase result = apiInstance.PostProvidersEdgesPhonebasesettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgesPhonebasesettings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PhoneBase**](PhoneBase.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**PhoneBase**](PhoneBase.md)

<a name="PostProvidersEdgesPhones"></a>
## [**Phone**](Phone.html) PostProvidersEdgesPhones (Phone body = null)

Create a new Phone



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostProvidersEdgesPhonesExample
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
                Phone result = apiInstance.PostProvidersEdgesPhones(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgesPhones: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Phone**](Phone.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**Phone**](Phone.md)

<a name="PostProvidersEdgesPhonesPhoneIdReboot"></a>
## void PostProvidersEdgesPhonesPhoneIdReboot (string phoneId)

Reboot a Phone



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostProvidersEdgesPhonesPhoneIdRebootExample
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
                apiInstance.PostProvidersEdgesPhonesPhoneIdReboot(phoneId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgesPhonesPhoneIdReboot: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneId** | **string**| Phone Id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="PostProvidersEdgesPhonesReboot"></a>
## void PostProvidersEdgesPhonesReboot (PhonesReboot body = null)

Reboot Multiple Phones



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostProvidersEdgesPhonesRebootExample
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
                apiInstance.PostProvidersEdgesPhonesReboot(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgesPhonesReboot: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PhonesReboot**](PhonesReboot.md)| body | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="PostProvidersEdgesSites"></a>
## [**Site**](Site.html) PostProvidersEdgesSites (Site body = null)

Create a endpoint.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostProvidersEdgesSitesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var body = new Site(); // Site | Site (optional) 

            try
            {
                // Create a endpoint.
                Site result = apiInstance.PostProvidersEdgesSites(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgesSites: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Site**](Site.md)| Site | [optional]  |
{: class="table table-striped"}

### Return type

[**Site**](Site.md)

<a name="PostProvidersEdgesSitesSiteIdRebalance"></a>
## void PostProvidersEdgesSitesSiteIdRebalance (string siteId)

Triggers the rebalance operation.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostProvidersEdgesSitesSiteIdRebalanceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID

            try
            {
                // Triggers the rebalance operation.
                apiInstance.PostProvidersEdgesSitesSiteIdRebalance(siteId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgesSitesSiteIdRebalance: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="PostProvidersEdgesTrunkbasesettings"></a>
## [**TrunkBase**](TrunkBase.html) PostProvidersEdgesTrunkbasesettings (TrunkBase body = null)

Create a Trunk Base Settings object



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostProvidersEdgesTrunkbasesettingsExample
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
                TrunkBase result = apiInstance.PostProvidersEdgesTrunkbasesettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgesTrunkbasesettings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TrunkBase**](TrunkBase.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**TrunkBase**](TrunkBase.md)

<a name="PutProvidersEdgesCertificateauthoritiesCertificateId"></a>
## [**DomainCertificateAuthority**](DomainCertificateAuthority.html) PutProvidersEdgesCertificateauthoritiesCertificateId (string certificateId, DomainCertificateAuthority body = null)

Update a certificate authority.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutProvidersEdgesCertificateauthoritiesCertificateIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var certificateId = certificateId_example;  // string | Certificate ID
            var body = new DomainCertificateAuthority(); // DomainCertificateAuthority |  (optional) 

            try
            {
                // Update a certificate authority.
                DomainCertificateAuthority result = apiInstance.PutProvidersEdgesCertificateauthoritiesCertificateId(certificateId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesCertificateauthoritiesCertificateId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **certificateId** | **string**| Certificate ID |  |
| **body** | [**DomainCertificateAuthority**](DomainCertificateAuthority.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**DomainCertificateAuthority**](DomainCertificateAuthority.md)

<a name="PutProvidersEdgesDidpoolsDidpoolId"></a>
## [**DIDPool**](DIDPool.html) PutProvidersEdgesDidpoolsDidpoolId (string didPoolId, DIDPool body = null)

Update a DID Pool by ID.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutProvidersEdgesDidpoolsDidpoolIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var didPoolId = didPoolId_example;  // string | DID pool ID
            var body = new DIDPool(); // DIDPool |  (optional) 

            try
            {
                // Update a DID Pool by ID.
                DIDPool result = apiInstance.PutProvidersEdgesDidpoolsDidpoolId(didPoolId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesDidpoolsDidpoolId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **didPoolId** | **string**| DID pool ID |  |
| **body** | [**DIDPool**](DIDPool.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**DIDPool**](DIDPool.md)

<a name="PutProvidersEdgesDidsDidId"></a>
## [**DID**](DID.html) PutProvidersEdgesDidsDidId (string didId, DID body = null)

Update a DID by ID.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutProvidersEdgesDidsDidIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var didId = didId_example;  // string | DID ID
            var body = new DID(); // DID |  (optional) 

            try
            {
                // Update a DID by ID.
                DID result = apiInstance.PutProvidersEdgesDidsDidId(didId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesDidsDidId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **didId** | **string**| DID ID |  |
| **body** | [**DID**](DID.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**DID**](DID.md)

<a name="PutProvidersEdgesEdgeId"></a>
## [**Edge**](Edge.html) PutProvidersEdgesEdgeId (string edgeId, Edge body = null)

Update a edge.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutProvidersEdgesEdgeIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var body = new Edge(); // Edge | Edge (optional) 

            try
            {
                // Update a edge.
                Edge result = apiInstance.PutProvidersEdgesEdgeId(edgeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesEdgeId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **body** | [**Edge**](Edge.md)| Edge | [optional]  |
{: class="table table-striped"}

### Return type

[**Edge**](Edge.md)

<a name="PutProvidersEdgesEdgeIdLinesLineId"></a>
## [**EdgeLine**](EdgeLine.html) PutProvidersEdgesEdgeIdLinesLineId (string edgeId, string lineId, EdgeLine body = null)

Update a line.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutProvidersEdgesEdgeIdLinesLineIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var lineId = lineId_example;  // string | Line ID
            var body = new EdgeLine(); // EdgeLine | Line (optional) 

            try
            {
                // Update a line.
                EdgeLine result = apiInstance.PutProvidersEdgesEdgeIdLinesLineId(edgeId, lineId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesEdgeIdLinesLineId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **lineId** | **string**| Line ID |  |
| **body** | [**EdgeLine**](EdgeLine.md)| Line | [optional]  |
{: class="table table-striped"}

### Return type

[**EdgeLine**](EdgeLine.md)

<a name="PutProvidersEdgesEdgeIdLogicalinterfacesInterfaceId"></a>
## [**DomainLogicalInterface**](DomainLogicalInterface.html) PutProvidersEdgesEdgeIdLogicalinterfacesInterfaceId (string edgeId, string interfaceId, DomainLogicalInterface body = null)

Update an edge logical interface.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutProvidersEdgesEdgeIdLogicalinterfacesInterfaceIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var interfaceId = interfaceId_example;  // string | Interface ID
            var body = new DomainLogicalInterface(); // DomainLogicalInterface |  (optional) 

            try
            {
                // Update an edge logical interface.
                DomainLogicalInterface result = apiInstance.PutProvidersEdgesEdgeIdLogicalinterfacesInterfaceId(edgeId, interfaceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesEdgeIdLogicalinterfacesInterfaceId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **interfaceId** | **string**| Interface ID |  |
| **body** | [**DomainLogicalInterface**](DomainLogicalInterface.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**DomainLogicalInterface**](DomainLogicalInterface.md)

<a name="PutProvidersEdgesEdgegroupsEdgegroupId"></a>
## [**EdgeGroup**](EdgeGroup.html) PutProvidersEdgesEdgegroupsEdgegroupId (string edgeGroupId, EdgeGroup body = null)

Update an edge group.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutProvidersEdgesEdgegroupsEdgegroupIdExample
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
                EdgeGroup result = apiInstance.PutProvidersEdgesEdgegroupsEdgegroupId(edgeGroupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesEdgegroupsEdgegroupId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeGroupId** | **string**| Edge group ID |  |
| **body** | [**EdgeGroup**](EdgeGroup.md)| EdgeGroup | [optional]  |
{: class="table table-striped"}

### Return type

[**EdgeGroup**](EdgeGroup.md)

<a name="PutProvidersEdgesEndpointsEndpointId"></a>
## [**Endpoint**](Endpoint.html) PutProvidersEdgesEndpointsEndpointId (string endpointId, Endpoint body = null)

Update endpoint



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutProvidersEdgesEndpointsEndpointIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var endpointId = endpointId_example;  // string | Endpoint ID
            var body = new Endpoint(); // Endpoint | EndpointTemplate (optional) 

            try
            {
                // Update endpoint
                Endpoint result = apiInstance.PutProvidersEdgesEndpointsEndpointId(endpointId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesEndpointsEndpointId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **endpointId** | **string**| Endpoint ID |  |
| **body** | [**Endpoint**](Endpoint.md)| EndpointTemplate | [optional]  |
{: class="table table-striped"}

### Return type

[**Endpoint**](Endpoint.md)

<a name="PutProvidersEdgesExtensionpoolsExtensionpoolId"></a>
## [**ExtensionPool**](ExtensionPool.html) PutProvidersEdgesExtensionpoolsExtensionpoolId (string extensionPoolId, ExtensionPool body = null)

Update an extension pool by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutProvidersEdgesExtensionpoolsExtensionpoolIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var extensionPoolId = extensionPoolId_example;  // string | Extension pool ID
            var body = new ExtensionPool(); // ExtensionPool | ExtensionPool (optional) 

            try
            {
                // Update an extension pool by ID
                ExtensionPool result = apiInstance.PutProvidersEdgesExtensionpoolsExtensionpoolId(extensionPoolId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesExtensionpoolsExtensionpoolId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **extensionPoolId** | **string**| Extension pool ID |  |
| **body** | [**ExtensionPool**](ExtensionPool.md)| ExtensionPool | [optional]  |
{: class="table table-striped"}

### Return type

[**ExtensionPool**](ExtensionPool.md)

<a name="PutProvidersEdgesExtensionsExtensionId"></a>
## [**Extension**](Extension.html) PutProvidersEdgesExtensionsExtensionId (string extensionId, Extension body = null)

Update an extension by ID.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutProvidersEdgesExtensionsExtensionIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var extensionId = extensionId_example;  // string | Extension ID
            var body = new Extension(); // Extension |  (optional) 

            try
            {
                // Update an extension by ID.
                Extension result = apiInstance.PutProvidersEdgesExtensionsExtensionId(extensionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesExtensionsExtensionId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **extensionId** | **string**| Extension ID |  |
| **body** | [**Extension**](Extension.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**Extension**](Extension.md)

<a name="PutProvidersEdgesOutboundroutesOutboundrouteId"></a>
## [**OutboundRoute**](OutboundRoute.html) PutProvidersEdgesOutboundroutesOutboundrouteId (string outboundRouteId, OutboundRoute body = null)

Update outbound route



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutProvidersEdgesOutboundroutesOutboundrouteIdExample
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
                OutboundRoute result = apiInstance.PutProvidersEdgesOutboundroutesOutboundrouteId(outboundRouteId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesOutboundroutesOutboundrouteId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **outboundRouteId** | **string**| Outbound route ID |  |
| **body** | [**OutboundRoute**](OutboundRoute.md)| OutboundRoute | [optional]  |
{: class="table table-striped"}

### Return type

[**OutboundRoute**](OutboundRoute.md)

<a name="PutProvidersEdgesPhonebasesettingsPhonebaseId"></a>
## [**PhoneBase**](PhoneBase.html) PutProvidersEdgesPhonebasesettingsPhonebaseId (string phoneBaseId, PhoneBase body = null)

Update a Phone Base Settings by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutProvidersEdgesPhonebasesettingsPhonebaseIdExample
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
                PhoneBase result = apiInstance.PutProvidersEdgesPhonebasesettingsPhonebaseId(phoneBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesPhonebasesettingsPhonebaseId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneBaseId** | **string**| Phone base ID |  |
| **body** | [**PhoneBase**](PhoneBase.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**PhoneBase**](PhoneBase.md)

<a name="PutProvidersEdgesPhonesPhoneId"></a>
## [**Phone**](Phone.html) PutProvidersEdgesPhonesPhoneId (string phoneId, Phone body = null)

Update a Phone by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutProvidersEdgesPhonesPhoneIdExample
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
                Phone result = apiInstance.PutProvidersEdgesPhonesPhoneId(phoneId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesPhonesPhoneId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneId** | **string**| Phone ID |  |
| **body** | [**Phone**](Phone.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**Phone**](Phone.md)

<a name="PutProvidersEdgesSitesSiteId"></a>
## [**Site**](Site.html) PutProvidersEdgesSitesSiteId (string siteId, Site body = null)

Update a endpoint.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutProvidersEdgesSitesSiteIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID
            var body = new Site(); // Site | Site (optional) 

            try
            {
                // Update a endpoint.
                Site result = apiInstance.PutProvidersEdgesSitesSiteId(siteId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesSitesSiteId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **body** | [**Site**](Site.md)| Site | [optional]  |
{: class="table table-striped"}

### Return type

[**Site**](Site.md)

<a name="PutProvidersEdgesSitesSiteIdNumberplans"></a>
## [**List&lt;NumberPlan&gt;**](NumberPlan.html) PutProvidersEdgesSitesSiteIdNumberplans (string siteId, List<NumberPlan> body = null)

Update the list of Number Plans.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutProvidersEdgesSitesSiteIdNumberplansExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID
            var body = new List<NumberPlan>(); // List<NumberPlan> |  (optional) 

            try
            {
                // Update the list of Number Plans.
                List&lt;NumberPlan&gt; result = apiInstance.PutProvidersEdgesSitesSiteIdNumberplans(siteId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesSitesSiteIdNumberplans: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **body** | [**List<NumberPlan>**](NumberPlan.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**List<NumberPlan>**](NumberPlan.md)

<a name="PutProvidersEdgesTrunkbasesettingsTrunkbasesettingsId"></a>
## [**TrunkBase**](TrunkBase.html) PutProvidersEdgesTrunkbasesettingsTrunkbasesettingsId (string trunkBaseSettingsId, TrunkBase body = null)

Update a Trunk Base Settings object by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutProvidersEdgesTrunkbasesettingsTrunkbasesettingsIdExample
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
                TrunkBase result = apiInstance.PutProvidersEdgesTrunkbasesettingsTrunkbasesettingsId(trunkBaseSettingsId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesTrunkbasesettingsTrunkbasesettingsId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trunkBaseSettingsId** | **string**| Trunk Base ID |  |
| **body** | [**TrunkBase**](TrunkBase.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**TrunkBase**](TrunkBase.md)

