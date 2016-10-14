---
title: TelephonyProvidersEdgeApi
---
## ININ.PureCloudApi.Api.TelephonyProvidersEdgeApi

All URIs are relative to *https://api.inindca.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteProvidersEdge**](TelephonyProvidersEdgeApi.html#deleteprovidersedge) | **DELETE** /api/v2/telephony/providers/edges/{edgeId} | Delete a edge. |
| [**DeleteProvidersEdgeLogicalinterface**](TelephonyProvidersEdgeApi.html#deleteprovidersedgelogicalinterface) | **DELETE** /api/v2/telephony/providers/edges/{edgeId}/logicalinterfaces/{interfaceId} | Delete an edge logical interface |
| [**DeleteProvidersEdgeSoftwareupdate**](TelephonyProvidersEdgeApi.html#deleteprovidersedgesoftwareupdate) | **DELETE** /api/v2/telephony/providers/edges/{edgeId}/softwareupdate | Cancels any in-progress update for this edge. |
| [**DeleteProvidersEdgesCertificateauthority**](TelephonyProvidersEdgeApi.html#deleteprovidersedgescertificateauthority) | **DELETE** /api/v2/telephony/providers/edges/certificateauthorities/{certificateId} | Delete a certificate authority. |
| [**DeleteProvidersEdgesDidpool**](TelephonyProvidersEdgeApi.html#deleteprovidersedgesdidpool) | **DELETE** /api/v2/telephony/providers/edges/didpools/{didPoolId} | Delete a DID Pool by ID. |
| [**DeleteProvidersEdgesEdgegroup**](TelephonyProvidersEdgeApi.html#deleteprovidersedgesedgegroup) | **DELETE** /api/v2/telephony/providers/edges/edgegroups/{edgeGroupId} | Delete an edge group. |
| [**DeleteProvidersEdgesEndpoint**](TelephonyProvidersEdgeApi.html#deleteprovidersedgesendpoint) | **DELETE** /api/v2/telephony/providers/edges/endpoints/{endpointId} | Delete endpoint |
| [**DeleteProvidersEdgesExtensionpool**](TelephonyProvidersEdgeApi.html#deleteprovidersedgesextensionpool) | **DELETE** /api/v2/telephony/providers/edges/extensionpools/{extensionPoolId} | Delete an extension pool by ID |
| [**DeleteProvidersEdgesOutboundroute**](TelephonyProvidersEdgeApi.html#deleteprovidersedgesoutboundroute) | **DELETE** /api/v2/telephony/providers/edges/outboundroutes/{outboundRouteId} | Delete Outbound Route |
| [**DeleteProvidersEdgesPhone**](TelephonyProvidersEdgeApi.html#deleteprovidersedgesphone) | **DELETE** /api/v2/telephony/providers/edges/phones/{phoneId} | Delete a Phone by ID |
| [**DeleteProvidersEdgesPhonebasesetting**](TelephonyProvidersEdgeApi.html#deleteprovidersedgesphonebasesetting) | **DELETE** /api/v2/telephony/providers/edges/phonebasesettings/{phoneBaseId} | Delete a Phone Base Settings by ID |
| [**DeleteProvidersEdgesSite**](TelephonyProvidersEdgeApi.html#deleteprovidersedgessite) | **DELETE** /api/v2/telephony/providers/edges/sites/{siteId} | Delete a Site by ID |
| [**DeleteProvidersEdgesTrunkbasesetting**](TelephonyProvidersEdgeApi.html#deleteprovidersedgestrunkbasesetting) | **DELETE** /api/v2/telephony/providers/edges/trunkbasesettings/{trunkBaseSettingsId} | Delete a Trunk Base Settings object by ID |
| [**GetProvidersEdge**](TelephonyProvidersEdgeApi.html#getprovidersedge) | **GET** /api/v2/telephony/providers/edges/{edgeId} | Get edge. |
| [**GetProvidersEdgeLine**](TelephonyProvidersEdgeApi.html#getprovidersedgeline) | **GET** /api/v2/telephony/providers/edges/{edgeId}/lines/{lineId} | Get line |
| [**GetProvidersEdgeLines**](TelephonyProvidersEdgeApi.html#getprovidersedgelines) | **GET** /api/v2/telephony/providers/edges/{edgeId}/lines | Get the list of lines. |
| [**GetProvidersEdgeLogicalinterface**](TelephonyProvidersEdgeApi.html#getprovidersedgelogicalinterface) | **GET** /api/v2/telephony/providers/edges/{edgeId}/logicalinterfaces/{interfaceId} | Get an edge logical interface |
| [**GetProvidersEdgeLogicalinterfaces**](TelephonyProvidersEdgeApi.html#getprovidersedgelogicalinterfaces) | **GET** /api/v2/telephony/providers/edges/{edgeId}/logicalinterfaces | Get edge logical interfaces. |
| [**GetProvidersEdgeLogsJob**](TelephonyProvidersEdgeApi.html#getprovidersedgelogsjob) | **GET** /api/v2/telephony/providers/edges/{edgeId}/logs/jobs/{jobId} | Get an Edge logs job. |
| [**GetProvidersEdgePhysicalinterface**](TelephonyProvidersEdgeApi.html#getprovidersedgephysicalinterface) | **GET** /api/v2/telephony/providers/edges/{edgeId}/physicalinterfaces/{interfaceId} | Get edge physical interface. |
| [**GetProvidersEdgePhysicalinterfaces**](TelephonyProvidersEdgeApi.html#getprovidersedgephysicalinterfaces) | **GET** /api/v2/telephony/providers/edges/{edgeId}/physicalinterfaces | Retrieve a list of all configured physical interfaces from a specific edge. |
| [**GetProvidersEdgeSoftwareupdate**](TelephonyProvidersEdgeApi.html#getprovidersedgesoftwareupdate) | **GET** /api/v2/telephony/providers/edges/{edgeId}/softwareupdate | Gets software update status information about any edge. |
| [**GetProvidersEdgeSoftwareversions**](TelephonyProvidersEdgeApi.html#getprovidersedgesoftwareversions) | **GET** /api/v2/telephony/providers/edges/{edgeId}/softwareversions | Gets all the available software versions for this edge. |
| [**GetProvidersEdges**](TelephonyProvidersEdgeApi.html#getprovidersedges) | **GET** /api/v2/telephony/providers/edges | Get the list of edges. |
| [**GetProvidersEdgesAvailablelanguages**](TelephonyProvidersEdgeApi.html#getprovidersedgesavailablelanguages) | **GET** /api/v2/telephony/providers/edges/availablelanguages | Get the list of available languages. |
| [**GetProvidersEdgesCertificateauthorities**](TelephonyProvidersEdgeApi.html#getprovidersedgescertificateauthorities) | **GET** /api/v2/telephony/providers/edges/certificateauthorities | Get the list of certificate authorities. |
| [**GetProvidersEdgesCertificateauthority**](TelephonyProvidersEdgeApi.html#getprovidersedgescertificateauthority) | **GET** /api/v2/telephony/providers/edges/certificateauthorities/{certificateId} | Get a certificate authority. |
| [**GetProvidersEdgesDid**](TelephonyProvidersEdgeApi.html#getprovidersedgesdid) | **GET** /api/v2/telephony/providers/edges/dids/{didId} | Get a DID by ID. |
| [**GetProvidersEdgesDidpool**](TelephonyProvidersEdgeApi.html#getprovidersedgesdidpool) | **GET** /api/v2/telephony/providers/edges/didpools/{didPoolId} | Get a DID Pool by ID. |
| [**GetProvidersEdgesDidpools**](TelephonyProvidersEdgeApi.html#getprovidersedgesdidpools) | **GET** /api/v2/telephony/providers/edges/didpools | Get a listing of DID Pools |
| [**GetProvidersEdgesDids**](TelephonyProvidersEdgeApi.html#getprovidersedgesdids) | **GET** /api/v2/telephony/providers/edges/dids | Get a listing of DIDs |
| [**GetProvidersEdgesEdgegroup**](TelephonyProvidersEdgeApi.html#getprovidersedgesedgegroup) | **GET** /api/v2/telephony/providers/edges/edgegroups/{edgeGroupId} | Get edge group. |
| [**GetProvidersEdgesEdgegroups**](TelephonyProvidersEdgeApi.html#getprovidersedgesedgegroups) | **GET** /api/v2/telephony/providers/edges/edgegroups | Get the list of edge groups. |
| [**GetProvidersEdgesEdgeversionreport**](TelephonyProvidersEdgeApi.html#getprovidersedgesedgeversionreport) | **GET** /api/v2/telephony/providers/edges/edgeversionreport | Get the edge version report. |
| [**GetProvidersEdgesEndpoint**](TelephonyProvidersEdgeApi.html#getprovidersedgesendpoint) | **GET** /api/v2/telephony/providers/edges/endpoints/{endpointId} | Get endpoint |
| [**GetProvidersEdgesEndpoints**](TelephonyProvidersEdgeApi.html#getprovidersedgesendpoints) | **GET** /api/v2/telephony/providers/edges/endpoints | Get endpoints |
| [**GetProvidersEdgesExtension**](TelephonyProvidersEdgeApi.html#getprovidersedgesextension) | **GET** /api/v2/telephony/providers/edges/extensions/{extensionId} | Get an extension by ID. |
| [**GetProvidersEdgesExtensionpool**](TelephonyProvidersEdgeApi.html#getprovidersedgesextensionpool) | **GET** /api/v2/telephony/providers/edges/extensionpools/{extensionPoolId} | Get an extension pool by ID |
| [**GetProvidersEdgesExtensionpools**](TelephonyProvidersEdgeApi.html#getprovidersedgesextensionpools) | **GET** /api/v2/telephony/providers/edges/extensionpools | Get a listing of extension pools |
| [**GetProvidersEdgesExtensions**](TelephonyProvidersEdgeApi.html#getprovidersedgesextensions) | **GET** /api/v2/telephony/providers/edges/extensions | Get a listing of extensions |
| [**GetProvidersEdgesLine**](TelephonyProvidersEdgeApi.html#getprovidersedgesline) | **GET** /api/v2/telephony/providers/edges/lines/{lineId} | Get a Line by ID |
| [**GetProvidersEdgesLinebasesetting**](TelephonyProvidersEdgeApi.html#getprovidersedgeslinebasesetting) | **GET** /api/v2/telephony/providers/edges/linebasesettings/{lineBaseId} | Get a line base settings object by ID |
| [**GetProvidersEdgesLinebasesettings**](TelephonyProvidersEdgeApi.html#getprovidersedgeslinebasesettings) | **GET** /api/v2/telephony/providers/edges/linebasesettings | Get a listing of line base settings objects |
| [**GetProvidersEdgesLines**](TelephonyProvidersEdgeApi.html#getprovidersedgeslines) | **GET** /api/v2/telephony/providers/edges/lines | Get a list of Lines |
| [**GetProvidersEdgesLinesTemplate**](TelephonyProvidersEdgeApi.html#getprovidersedgeslinestemplate) | **GET** /api/v2/telephony/providers/edges/lines/template | Get a Line instance template based on a Line Base Settings object. This object can then be modified and saved as a new Line instance |
| [**GetProvidersEdgesOutboundroute**](TelephonyProvidersEdgeApi.html#getprovidersedgesoutboundroute) | **GET** /api/v2/telephony/providers/edges/outboundroutes/{outboundRouteId} | Get outbound route |
| [**GetProvidersEdgesOutboundroutes**](TelephonyProvidersEdgeApi.html#getprovidersedgesoutboundroutes) | **GET** /api/v2/telephony/providers/edges/outboundroutes | Get outbound routes |
| [**GetProvidersEdgesPhone**](TelephonyProvidersEdgeApi.html#getprovidersedgesphone) | **GET** /api/v2/telephony/providers/edges/phones/{phoneId} | Get a Phone by ID |
| [**GetProvidersEdgesPhonebasesetting**](TelephonyProvidersEdgeApi.html#getprovidersedgesphonebasesetting) | **GET** /api/v2/telephony/providers/edges/phonebasesettings/{phoneBaseId} | Get a Phone Base Settings object by ID |
| [**GetProvidersEdgesPhonebasesettings**](TelephonyProvidersEdgeApi.html#getprovidersedgesphonebasesettings) | **GET** /api/v2/telephony/providers/edges/phonebasesettings | Get a list of Phone Base Settings objects |
| [**GetProvidersEdgesPhonebasesettingsAvailablemetabases**](TelephonyProvidersEdgeApi.html#getprovidersedgesphonebasesettingsavailablemetabases) | **GET** /api/v2/telephony/providers/edges/phonebasesettings/availablemetabases | Get a list of available makes and models to create a new Phone Base Settings |
| [**GetProvidersEdgesPhonebasesettingsTemplate**](TelephonyProvidersEdgeApi.html#getprovidersedgesphonebasesettingstemplate) | **GET** /api/v2/telephony/providers/edges/phonebasesettings/template | Get a Phone Base Settings instance template from a given make and model. This object can then be modified and saved as a new Phone Base Settings instance |
| [**GetProvidersEdgesPhones**](TelephonyProvidersEdgeApi.html#getprovidersedgesphones) | **GET** /api/v2/telephony/providers/edges/phones | Get a list of Phone Instances |
| [**GetProvidersEdgesPhonesTemplate**](TelephonyProvidersEdgeApi.html#getprovidersedgesphonestemplate) | **GET** /api/v2/telephony/providers/edges/phones/template | Get a Phone instance template based on a Phone Base Settings object. This object can then be modified and saved as a new Phone instance |
| [**GetProvidersEdgesSite**](TelephonyProvidersEdgeApi.html#getprovidersedgessite) | **GET** /api/v2/telephony/providers/edges/sites/{siteId} | Get a Site by ID. |
| [**GetProvidersEdgesSiteNumberplan**](TelephonyProvidersEdgeApi.html#getprovidersedgessitenumberplan) | **GET** /api/v2/telephony/providers/edges/sites/{siteId}/numberplans/{numberPlanId} | Get a Number Plan by ID. |
| [**GetProvidersEdgesSiteNumberplans**](TelephonyProvidersEdgeApi.html#getprovidersedgessitenumberplans) | **GET** /api/v2/telephony/providers/edges/sites/{siteId}/numberplans | Get the list of Number Plans for this Site. |
| [**GetProvidersEdgesSiteNumberplansClassifications**](TelephonyProvidersEdgeApi.html#getprovidersedgessitenumberplansclassifications) | **GET** /api/v2/telephony/providers/edges/sites/{siteId}/numberplans/classifications | Get a list of Classifications for this Site |
| [**GetProvidersEdgesSites**](TelephonyProvidersEdgeApi.html#getprovidersedgessites) | **GET** /api/v2/telephony/providers/edges/sites | Get the list of Sites. |
| [**GetProvidersEdgesTimezones**](TelephonyProvidersEdgeApi.html#getprovidersedgestimezones) | **GET** /api/v2/telephony/providers/edges/timezones | Get a list of Edge-compatible time zones |
| [**GetProvidersEdgesTrunk**](TelephonyProvidersEdgeApi.html#getprovidersedgestrunk) | **GET** /api/v2/telephony/providers/edges/trunks/{trunkId} | Get a Trunk by ID |
| [**GetProvidersEdgesTrunkbasesetting**](TelephonyProvidersEdgeApi.html#getprovidersedgestrunkbasesetting) | **GET** /api/v2/telephony/providers/edges/trunkbasesettings/{trunkBaseSettingsId} | Get a Trunk Base Settings object by ID |
| [**GetProvidersEdgesTrunkbasesettings**](TelephonyProvidersEdgeApi.html#getprovidersedgestrunkbasesettings) | **GET** /api/v2/telephony/providers/edges/trunkbasesettings | Get Trunk Base Settings listing |
| [**GetProvidersEdgesTrunkbasesettingsAvailablemetabases**](TelephonyProvidersEdgeApi.html#getprovidersedgestrunkbasesettingsavailablemetabases) | **GET** /api/v2/telephony/providers/edges/trunkbasesettings/availablemetabases | Get a list of available makes and models to create a new Trunk Base Settings |
| [**GetProvidersEdgesTrunkbasesettingsTemplate**](TelephonyProvidersEdgeApi.html#getprovidersedgestrunkbasesettingstemplate) | **GET** /api/v2/telephony/providers/edges/trunkbasesettings/template | Get a Trunk Base Settings instance template from a given make and model. This object can then be modified and saved as a new Trunk Base Settings instance |
| [**GetProvidersEdgesTrunks**](TelephonyProvidersEdgeApi.html#getprovidersedgestrunks) | **GET** /api/v2/telephony/providers/edges/trunks | Get the list of available trunks. |
| [**GetProvidersEdgesTrunkswithrecording**](TelephonyProvidersEdgeApi.html#getprovidersedgestrunkswithrecording) | **GET** /api/v2/telephony/providers/edges/trunkswithrecording | Get Counts of trunks that have recording disabled or enabled |
| [**GetSchemasEdgesVnext**](TelephonyProvidersEdgeApi.html#getschemasedgesvnext) | **GET** /api/v2/configuration/schemas/edges/vnext | Lists available schema categories |
| [**GetSchemasEdgesVnextSchemaCategory**](TelephonyProvidersEdgeApi.html#getschemasedgesvnextschemacategory) | **GET** /api/v2/configuration/schemas/edges/vnext/{schemaCategory} | List schemas of a specific category |
| [**GetSchemasEdgesVnextSchemaCategorySchemaType**](TelephonyProvidersEdgeApi.html#getschemasedgesvnextschemacategoryschematype) | **GET** /api/v2/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType} | List schemas of a specific category |
| [**GetSchemasEdgesVnextSchemaCategorySchemaTypeSchemaId**](TelephonyProvidersEdgeApi.html#getschemasedgesvnextschemacategoryschematypeschemaid) | **GET** /api/v2/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}/{schemaId} | Get a json schema |
| [**GetSchemasEdgesVnextSchemaCategorySchemaTypeSchemaIdExtensionTypeMetadataId**](TelephonyProvidersEdgeApi.html#getschemasedgesvnextschemacategoryschematypeschemaidextensiontypemetadataid) | **GET** /api/v2/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}/{schemaId}/{extensionType}/{metadataId} | Get metadata for a schema |
| [**PostProvidersEdgeLogicalinterfaces**](TelephonyProvidersEdgeApi.html#postprovidersedgelogicalinterfaces) | **POST** /api/v2/telephony/providers/edges/{edgeId}/logicalinterfaces | Create an edge logical interface. |
| [**PostProvidersEdgeLogsJobUpload**](TelephonyProvidersEdgeApi.html#postprovidersedgelogsjobupload) | **POST** /api/v2/telephony/providers/edges/{edgeId}/logs/jobs/{jobId}/upload | Request that the specified fileIds be uploaded from the Edge. |
| [**PostProvidersEdgeLogsJobs**](TelephonyProvidersEdgeApi.html#postprovidersedgelogsjobs) | **POST** /api/v2/telephony/providers/edges/{edgeId}/logs/jobs | Create a job to upload a list of Edge logs. |
| [**PostProvidersEdgeReboot**](TelephonyProvidersEdgeApi.html#postprovidersedgereboot) | **POST** /api/v2/telephony/providers/edges/{edgeId}/reboot | Reboot an Edge |
| [**PostProvidersEdgeSoftwareupdate**](TelephonyProvidersEdgeApi.html#postprovidersedgesoftwareupdate) | **POST** /api/v2/telephony/providers/edges/{edgeId}/softwareupdate | Starts a software update for this edge. |
| [**PostProvidersEdgeUnpair**](TelephonyProvidersEdgeApi.html#postprovidersedgeunpair) | **POST** /api/v2/telephony/providers/edges/{edgeId}/unpair | Unpair an Edge |
| [**PostProvidersEdges**](TelephonyProvidersEdgeApi.html#postprovidersedges) | **POST** /api/v2/telephony/providers/edges | Create a edge. |
| [**PostProvidersEdgesAddressvalidation**](TelephonyProvidersEdgeApi.html#postprovidersedgesaddressvalidation) | **POST** /api/v2/telephony/providers/edges/addressvalidation | Validates a street address |
| [**PostProvidersEdgesCertificateauthorities**](TelephonyProvidersEdgeApi.html#postprovidersedgescertificateauthorities) | **POST** /api/v2/telephony/providers/edges/certificateauthorities | Create a certificate authority. |
| [**PostProvidersEdgesDidpools**](TelephonyProvidersEdgeApi.html#postprovidersedgesdidpools) | **POST** /api/v2/telephony/providers/edges/didpools | Create a new DID pool |
| [**PostProvidersEdgesEdgegroups**](TelephonyProvidersEdgeApi.html#postprovidersedgesedgegroups) | **POST** /api/v2/telephony/providers/edges/edgegroups | Create an edge group. |
| [**PostProvidersEdgesEndpoints**](TelephonyProvidersEdgeApi.html#postprovidersedgesendpoints) | **POST** /api/v2/telephony/providers/edges/endpoints | Create endpoint |
| [**PostProvidersEdgesExtensionpools**](TelephonyProvidersEdgeApi.html#postprovidersedgesextensionpools) | **POST** /api/v2/telephony/providers/edges/extensionpools | Create a new extension pool |
| [**PostProvidersEdgesOutboundroutes**](TelephonyProvidersEdgeApi.html#postprovidersedgesoutboundroutes) | **POST** /api/v2/telephony/providers/edges/outboundroutes | Create outbound rule |
| [**PostProvidersEdgesPhoneReboot**](TelephonyProvidersEdgeApi.html#postprovidersedgesphonereboot) | **POST** /api/v2/telephony/providers/edges/phones/{phoneId}/reboot | Reboot a Phone |
| [**PostProvidersEdgesPhonebasesettings**](TelephonyProvidersEdgeApi.html#postprovidersedgesphonebasesettings) | **POST** /api/v2/telephony/providers/edges/phonebasesettings | Create a new Phone Base Settings object |
| [**PostProvidersEdgesPhones**](TelephonyProvidersEdgeApi.html#postprovidersedgesphones) | **POST** /api/v2/telephony/providers/edges/phones | Create a new Phone |
| [**PostProvidersEdgesPhonesReboot**](TelephonyProvidersEdgeApi.html#postprovidersedgesphonesreboot) | **POST** /api/v2/telephony/providers/edges/phones/reboot | Reboot Multiple Phones |
| [**PostProvidersEdgesSiteRebalance**](TelephonyProvidersEdgeApi.html#postprovidersedgessiterebalance) | **POST** /api/v2/telephony/providers/edges/sites/{siteId}/rebalance | Triggers the rebalance operation. |
| [**PostProvidersEdgesSites**](TelephonyProvidersEdgeApi.html#postprovidersedgessites) | **POST** /api/v2/telephony/providers/edges/sites | Create a Site. |
| [**PostProvidersEdgesTrunkbasesettings**](TelephonyProvidersEdgeApi.html#postprovidersedgestrunkbasesettings) | **POST** /api/v2/telephony/providers/edges/trunkbasesettings | Create a Trunk Base Settings object |
| [**PutProvidersEdge**](TelephonyProvidersEdgeApi.html#putprovidersedge) | **PUT** /api/v2/telephony/providers/edges/{edgeId} | Update a edge. |
| [**PutProvidersEdgeLine**](TelephonyProvidersEdgeApi.html#putprovidersedgeline) | **PUT** /api/v2/telephony/providers/edges/{edgeId}/lines/{lineId} | Update a line. |
| [**PutProvidersEdgeLogicalinterface**](TelephonyProvidersEdgeApi.html#putprovidersedgelogicalinterface) | **PUT** /api/v2/telephony/providers/edges/{edgeId}/logicalinterfaces/{interfaceId} | Update an edge logical interface. |
| [**PutProvidersEdgesCertificateauthority**](TelephonyProvidersEdgeApi.html#putprovidersedgescertificateauthority) | **PUT** /api/v2/telephony/providers/edges/certificateauthorities/{certificateId} | Update a certificate authority. |
| [**PutProvidersEdgesDid**](TelephonyProvidersEdgeApi.html#putprovidersedgesdid) | **PUT** /api/v2/telephony/providers/edges/dids/{didId} | Update a DID by ID. |
| [**PutProvidersEdgesDidpool**](TelephonyProvidersEdgeApi.html#putprovidersedgesdidpool) | **PUT** /api/v2/telephony/providers/edges/didpools/{didPoolId} | Update a DID Pool by ID. |
| [**PutProvidersEdgesEdgegroup**](TelephonyProvidersEdgeApi.html#putprovidersedgesedgegroup) | **PUT** /api/v2/telephony/providers/edges/edgegroups/{edgeGroupId} | Update an edge group. |
| [**PutProvidersEdgesEndpoint**](TelephonyProvidersEdgeApi.html#putprovidersedgesendpoint) | **PUT** /api/v2/telephony/providers/edges/endpoints/{endpointId} | Update endpoint |
| [**PutProvidersEdgesExtension**](TelephonyProvidersEdgeApi.html#putprovidersedgesextension) | **PUT** /api/v2/telephony/providers/edges/extensions/{extensionId} | Update an extension by ID. |
| [**PutProvidersEdgesExtensionpool**](TelephonyProvidersEdgeApi.html#putprovidersedgesextensionpool) | **PUT** /api/v2/telephony/providers/edges/extensionpools/{extensionPoolId} | Update an extension pool by ID |
| [**PutProvidersEdgesOutboundroute**](TelephonyProvidersEdgeApi.html#putprovidersedgesoutboundroute) | **PUT** /api/v2/telephony/providers/edges/outboundroutes/{outboundRouteId} | Update outbound route |
| [**PutProvidersEdgesPhone**](TelephonyProvidersEdgeApi.html#putprovidersedgesphone) | **PUT** /api/v2/telephony/providers/edges/phones/{phoneId} | Update a Phone by ID |
| [**PutProvidersEdgesPhonebasesetting**](TelephonyProvidersEdgeApi.html#putprovidersedgesphonebasesetting) | **PUT** /api/v2/telephony/providers/edges/phonebasesettings/{phoneBaseId} | Update a Phone Base Settings by ID |
| [**PutProvidersEdgesSite**](TelephonyProvidersEdgeApi.html#putprovidersedgessite) | **PUT** /api/v2/telephony/providers/edges/sites/{siteId} | Update a Site by ID. |
| [**PutProvidersEdgesSiteNumberplans**](TelephonyProvidersEdgeApi.html#putprovidersedgessitenumberplans) | **PUT** /api/v2/telephony/providers/edges/sites/{siteId}/numberplans | Update the list of Number Plans. |
| [**PutProvidersEdgesTrunkbasesetting**](TelephonyProvidersEdgeApi.html#putprovidersedgestrunkbasesetting) | **PUT** /api/v2/telephony/providers/edges/trunkbasesettings/{trunkBaseSettingsId} | Update a Trunk Base Settings object by ID |
{: class="table table-striped"}

<a name="deleteprovidersedge"></a>

## **string** DeleteProvidersEdge (string edgeId)

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
    public class DeleteProvidersEdgeExample
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
                string result = apiInstance.DeleteProvidersEdge(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteProvidersEdge: " + e.Message );
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

<a name="deleteprovidersedgelogicalinterface"></a>

## void DeleteProvidersEdgeLogicalinterface (string edgeId, string interfaceId)

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
    public class DeleteProvidersEdgeLogicalinterfaceExample
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
                apiInstance.DeleteProvidersEdgeLogicalinterface(edgeId, interfaceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteProvidersEdgeLogicalinterface: " + e.Message );
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

<a name="deleteprovidersedgesoftwareupdate"></a>

## **string** DeleteProvidersEdgeSoftwareupdate (string edgeId)

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
    public class DeleteProvidersEdgeSoftwareupdateExample
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
                string result = apiInstance.DeleteProvidersEdgeSoftwareupdate(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteProvidersEdgeSoftwareupdate: " + e.Message );
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

<a name="deleteprovidersedgescertificateauthority"></a>

## **string** DeleteProvidersEdgesCertificateauthority (string certificateId)

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
    public class DeleteProvidersEdgesCertificateauthorityExample
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
                string result = apiInstance.DeleteProvidersEdgesCertificateauthority(certificateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteProvidersEdgesCertificateauthority: " + e.Message );
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

<a name="deleteprovidersedgesdidpool"></a>

## **string** DeleteProvidersEdgesDidpool (string didPoolId)

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
    public class DeleteProvidersEdgesDidpoolExample
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
                string result = apiInstance.DeleteProvidersEdgesDidpool(didPoolId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteProvidersEdgesDidpool: " + e.Message );
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

<a name="deleteprovidersedgesedgegroup"></a>

## **string** DeleteProvidersEdgesEdgegroup (string edgeGroupId)

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
    public class DeleteProvidersEdgesEdgegroupExample
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
                string result = apiInstance.DeleteProvidersEdgesEdgegroup(edgeGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteProvidersEdgesEdgegroup: " + e.Message );
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

<a name="deleteprovidersedgesendpoint"></a>

## **string** DeleteProvidersEdgesEndpoint (string endpointId)

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
    public class DeleteProvidersEdgesEndpointExample
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
                string result = apiInstance.DeleteProvidersEdgesEndpoint(endpointId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteProvidersEdgesEndpoint: " + e.Message );
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

<a name="deleteprovidersedgesextensionpool"></a>

## **string** DeleteProvidersEdgesExtensionpool (string extensionPoolId)

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
    public class DeleteProvidersEdgesExtensionpoolExample
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
                string result = apiInstance.DeleteProvidersEdgesExtensionpool(extensionPoolId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteProvidersEdgesExtensionpool: " + e.Message );
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

<a name="deleteprovidersedgesoutboundroute"></a>

## **string** DeleteProvidersEdgesOutboundroute (string outboundRouteId)

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
    public class DeleteProvidersEdgesOutboundrouteExample
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
                string result = apiInstance.DeleteProvidersEdgesOutboundroute(outboundRouteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteProvidersEdgesOutboundroute: " + e.Message );
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

<a name="deleteprovidersedgesphone"></a>

## **string** DeleteProvidersEdgesPhone (string phoneId)

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
    public class DeleteProvidersEdgesPhoneExample
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
                string result = apiInstance.DeleteProvidersEdgesPhone(phoneId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteProvidersEdgesPhone: " + e.Message );
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

<a name="deleteprovidersedgesphonebasesetting"></a>

## **string** DeleteProvidersEdgesPhonebasesetting (string phoneBaseId)

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
    public class DeleteProvidersEdgesPhonebasesettingExample
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
                string result = apiInstance.DeleteProvidersEdgesPhonebasesetting(phoneBaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteProvidersEdgesPhonebasesetting: " + e.Message );
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

<a name="deleteprovidersedgessite"></a>

## **string** DeleteProvidersEdgesSite (string siteId)

Delete a Site by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteProvidersEdgesSiteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID

            try
            {
                // Delete a Site by ID
                string result = apiInstance.DeleteProvidersEdgesSite(siteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteProvidersEdgesSite: " + e.Message );
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

<a name="deleteprovidersedgestrunkbasesetting"></a>

## **string** DeleteProvidersEdgesTrunkbasesetting (string trunkBaseSettingsId)

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
    public class DeleteProvidersEdgesTrunkbasesettingExample
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
                string result = apiInstance.DeleteProvidersEdgesTrunkbasesetting(trunkBaseSettingsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.DeleteProvidersEdgesTrunkbasesetting: " + e.Message );
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

<a name="getprovidersedge"></a>

## [**Edge**](Edge.html) GetProvidersEdge (string edgeId)

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
    public class GetProvidersEdgeExample
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
                Edge result = apiInstance.GetProvidersEdge(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdge: " + e.Message );
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

[**Edge**](Edge.html)

<a name="getprovidersedgeline"></a>

## [**EdgeLine**](EdgeLine.html) GetProvidersEdgeLine (string edgeId, string lineId)

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
    public class GetProvidersEdgeLineExample
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
                EdgeLine result = apiInstance.GetProvidersEdgeLine(edgeId, lineId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgeLine: " + e.Message );
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

[**EdgeLine**](EdgeLine.html)

<a name="getprovidersedgelines"></a>

## [**EdgeLineEntityListing**](EdgeLineEntityListing.html) GetProvidersEdgeLines (string edgeId, int? pageSize = null, int? pageNumber = null)

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
    public class GetProvidersEdgeLinesExample
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
                EdgeLineEntityListing result = apiInstance.GetProvidersEdgeLines(edgeId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgeLines: " + e.Message );
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

[**EdgeLineEntityListing**](EdgeLineEntityListing.html)

<a name="getprovidersedgelogicalinterface"></a>

## [**DomainLogicalInterface**](DomainLogicalInterface.html) GetProvidersEdgeLogicalinterface (string edgeId, string interfaceId, List<string> expand = null)

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
    public class GetProvidersEdgeLogicalinterfaceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var interfaceId = interfaceId_example;  // string | Interface ID
            var expand = new List<string>(); // List<string> | Field to expand in the response (optional) 

            try
            {
                // Get an edge logical interface
                DomainLogicalInterface result = apiInstance.GetProvidersEdgeLogicalinterface(edgeId, interfaceId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgeLogicalinterface: " + e.Message );
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
| **expand** | [**List<string>**](string.html)| Field to expand in the response | [optional]  |
{: class="table table-striped"}

### Return type

[**DomainLogicalInterface**](DomainLogicalInterface.html)

<a name="getprovidersedgelogicalinterfaces"></a>

## [**LogicalInterfaceEntityListing**](LogicalInterfaceEntityListing.html) GetProvidersEdgeLogicalinterfaces (string edgeId, List<string> expand = null)

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
    public class GetProvidersEdgeLogicalinterfacesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var expand = new List<string>(); // List<string> | Field to expand in the response (optional) 

            try
            {
                // Get edge logical interfaces.
                LogicalInterfaceEntityListing result = apiInstance.GetProvidersEdgeLogicalinterfaces(edgeId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgeLogicalinterfaces: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **expand** | [**List<string>**](string.html)| Field to expand in the response | [optional]  |
{: class="table table-striped"}

### Return type

[**LogicalInterfaceEntityListing**](LogicalInterfaceEntityListing.html)

<a name="getprovidersedgelogsjob"></a>

## [**EdgeLogsJob**](EdgeLogsJob.html) GetProvidersEdgeLogsJob (string edgeId, string jobId)

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
    public class GetProvidersEdgeLogsJobExample
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
                EdgeLogsJob result = apiInstance.GetProvidersEdgeLogsJob(edgeId, jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgeLogsJob: " + e.Message );
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

[**EdgeLogsJob**](EdgeLogsJob.html)

<a name="getprovidersedgephysicalinterface"></a>

## [**DomainPhysicalInterface**](DomainPhysicalInterface.html) GetProvidersEdgePhysicalinterface (string edgeId, string interfaceId)

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
    public class GetProvidersEdgePhysicalinterfaceExample
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
                DomainPhysicalInterface result = apiInstance.GetProvidersEdgePhysicalinterface(edgeId, interfaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgePhysicalinterface: " + e.Message );
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

[**DomainPhysicalInterface**](DomainPhysicalInterface.html)

<a name="getprovidersedgephysicalinterfaces"></a>

## [**PhysicalInterfaceEntityListing**](PhysicalInterfaceEntityListing.html) GetProvidersEdgePhysicalinterfaces (string edgeId)

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
    public class GetProvidersEdgePhysicalinterfacesExample
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
                PhysicalInterfaceEntityListing result = apiInstance.GetProvidersEdgePhysicalinterfaces(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgePhysicalinterfaces: " + e.Message );
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

[**PhysicalInterfaceEntityListing**](PhysicalInterfaceEntityListing.html)

<a name="getprovidersedgesoftwareupdate"></a>

## [**DomainEdgeSoftwareUpdateDto**](DomainEdgeSoftwareUpdateDto.html) GetProvidersEdgeSoftwareupdate (string edgeId)

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
    public class GetProvidersEdgeSoftwareupdateExample
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
                DomainEdgeSoftwareUpdateDto result = apiInstance.GetProvidersEdgeSoftwareupdate(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgeSoftwareupdate: " + e.Message );
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

[**DomainEdgeSoftwareUpdateDto**](DomainEdgeSoftwareUpdateDto.html)

<a name="getprovidersedgesoftwareversions"></a>

## [**DomainEdgeSoftwareVersionDto**](DomainEdgeSoftwareVersionDto.html) GetProvidersEdgeSoftwareversions (string edgeId)

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
    public class GetProvidersEdgeSoftwareversionsExample
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
                DomainEdgeSoftwareVersionDto result = apiInstance.GetProvidersEdgeSoftwareversions(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgeSoftwareversions: " + e.Message );
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

[**DomainEdgeSoftwareVersionDto**](DomainEdgeSoftwareVersionDto.html)

<a name="getprovidersedges"></a>

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

[**EdgeEntityListing**](EdgeEntityListing.html)

<a name="getprovidersedgesavailablelanguages"></a>

## [**AvailableLanguageList**](AvailableLanguageList.html) GetProvidersEdgesAvailablelanguages ()

Get the list of available languages.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesAvailablelanguagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();

            try
            {
                // Get the list of available languages.
                AvailableLanguageList result = apiInstance.GetProvidersEdgesAvailablelanguages();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesAvailablelanguages: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**AvailableLanguageList**](AvailableLanguageList.html)

<a name="getprovidersedgescertificateauthorities"></a>

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

[**CertificateAuthorityEntityListing**](CertificateAuthorityEntityListing.html)

<a name="getprovidersedgescertificateauthority"></a>

## [**DomainCertificateAuthority**](DomainCertificateAuthority.html) GetProvidersEdgesCertificateauthority (string certificateId)

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
    public class GetProvidersEdgesCertificateauthorityExample
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
                DomainCertificateAuthority result = apiInstance.GetProvidersEdgesCertificateauthority(certificateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesCertificateauthority: " + e.Message );
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

[**DomainCertificateAuthority**](DomainCertificateAuthority.html)

<a name="getprovidersedgesdid"></a>

## [**DID**](DID.html) GetProvidersEdgesDid (string didId)

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
    public class GetProvidersEdgesDidExample
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
                DID result = apiInstance.GetProvidersEdgesDid(didId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesDid: " + e.Message );
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

[**DID**](DID.html)

<a name="getprovidersedgesdidpool"></a>

## [**DIDPool**](DIDPool.html) GetProvidersEdgesDidpool (string didPoolId)

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
    public class GetProvidersEdgesDidpoolExample
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
                DIDPool result = apiInstance.GetProvidersEdgesDidpool(didPoolId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesDidpool: " + e.Message );
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

[**DIDPool**](DIDPool.html)

<a name="getprovidersedgesdidpools"></a>

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

[**DIDPoolEntityListing**](DIDPoolEntityListing.html)

<a name="getprovidersedgesdids"></a>

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

[**DIDEntityListing**](DIDEntityListing.html)

<a name="getprovidersedgesedgegroup"></a>

## [**EdgeGroup**](EdgeGroup.html) GetProvidersEdgesEdgegroup (string edgeGroupId, List<string> expand = null)

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
    public class GetProvidersEdgesEdgegroupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeGroupId = edgeGroupId_example;  // string | Edge group ID
            var expand = new List<string>(); // List<string> | Fields to expand in the response (optional) 

            try
            {
                // Get edge group.
                EdgeGroup result = apiInstance.GetProvidersEdgesEdgegroup(edgeGroupId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesEdgegroup: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeGroupId** | **string**| Edge group ID |  |
| **expand** | [**List<string>**](string.html)| Fields to expand in the response | [optional]  |
{: class="table table-striped"}

### Return type

[**EdgeGroup**](EdgeGroup.html)

<a name="getprovidersedgesedgegroups"></a>

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

[**EdgeGroupEntityListing**](EdgeGroupEntityListing.html)

<a name="getprovidersedgesedgeversionreport"></a>

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

[**EdgeVersionReport**](EdgeVersionReport.html)

<a name="getprovidersedgesendpoint"></a>

## [**Endpoint**](Endpoint.html) GetProvidersEdgesEndpoint (string endpointId)

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
    public class GetProvidersEdgesEndpointExample
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
                Endpoint result = apiInstance.GetProvidersEdgesEndpoint(endpointId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesEndpoint: " + e.Message );
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

[**Endpoint**](Endpoint.html)

<a name="getprovidersedgesendpoints"></a>

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

[**EndpointEntityListing**](EndpointEntityListing.html)

<a name="getprovidersedgesextension"></a>

## [**Extension**](Extension.html) GetProvidersEdgesExtension (string extensionId)

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
    public class GetProvidersEdgesExtensionExample
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
                Extension result = apiInstance.GetProvidersEdgesExtension(extensionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesExtension: " + e.Message );
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

[**Extension**](Extension.html)

<a name="getprovidersedgesextensionpool"></a>

## [**ExtensionPool**](ExtensionPool.html) GetProvidersEdgesExtensionpool (string extensionPoolId)

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
    public class GetProvidersEdgesExtensionpoolExample
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
                ExtensionPool result = apiInstance.GetProvidersEdgesExtensionpool(extensionPoolId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesExtensionpool: " + e.Message );
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

[**ExtensionPool**](ExtensionPool.html)

<a name="getprovidersedgesextensionpools"></a>

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

[**ExtensionPoolEntityListing**](ExtensionPoolEntityListing.html)

<a name="getprovidersedgesextensions"></a>

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

[**ExtensionEntityListing**](ExtensionEntityListing.html)

<a name="getprovidersedgesline"></a>

## [**Line**](Line.html) GetProvidersEdgesLine (string lineId)

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
    public class GetProvidersEdgesLineExample
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
                Line result = apiInstance.GetProvidersEdgesLine(lineId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesLine: " + e.Message );
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

[**Line**](Line.html)

<a name="getprovidersedgeslinebasesetting"></a>

## [**LineBase**](LineBase.html) GetProvidersEdgesLinebasesetting (string lineBaseId)

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
    public class GetProvidersEdgesLinebasesettingExample
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
                LineBase result = apiInstance.GetProvidersEdgesLinebasesetting(lineBaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesLinebasesetting: " + e.Message );
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

[**LineBase**](LineBase.html)

<a name="getprovidersedgeslinebasesettings"></a>

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

[**LineBaseEntityListing**](LineBaseEntityListing.html)

<a name="getprovidersedgeslines"></a>

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
| **expand** | [**List<string>**](string.html)| Fields to expand in the response, comma-separated | [optional]  |
{: class="table table-striped"}

### Return type

[**LineEntityListing**](LineEntityListing.html)

<a name="getprovidersedgeslinestemplate"></a>

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

[**Line**](Line.html)

<a name="getprovidersedgesoutboundroute"></a>

## [**OutboundRoute**](OutboundRoute.html) GetProvidersEdgesOutboundroute (string outboundRouteId)

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
    public class GetProvidersEdgesOutboundrouteExample
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
                OutboundRoute result = apiInstance.GetProvidersEdgesOutboundroute(outboundRouteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesOutboundroute: " + e.Message );
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

[**OutboundRoute**](OutboundRoute.html)

<a name="getprovidersedgesoutboundroutes"></a>

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

[**OutboundRouteEntityListing**](OutboundRouteEntityListing.html)

<a name="getprovidersedgesphone"></a>

## [**Phone**](Phone.html) GetProvidersEdgesPhone (string phoneId)

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
    public class GetProvidersEdgesPhoneExample
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
                Phone result = apiInstance.GetProvidersEdgesPhone(phoneId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesPhone: " + e.Message );
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

[**Phone**](Phone.html)

<a name="getprovidersedgesphonebasesetting"></a>

## [**PhoneBase**](PhoneBase.html) GetProvidersEdgesPhonebasesetting (string phoneBaseId)

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
    public class GetProvidersEdgesPhonebasesettingExample
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
                PhoneBase result = apiInstance.GetProvidersEdgesPhonebasesetting(phoneBaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesPhonebasesetting: " + e.Message );
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

[**PhoneBase**](PhoneBase.html)

<a name="getprovidersedgesphonebasesettings"></a>

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

[**PhoneBaseEntityListing**](PhoneBaseEntityListing.html)

<a name="getprovidersedgesphonebasesettingsavailablemetabases"></a>

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

[**PhoneMetaBaseEntityListing**](PhoneMetaBaseEntityListing.html)

<a name="getprovidersedgesphonebasesettingstemplate"></a>

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

[**PhoneBase**](PhoneBase.html)

<a name="getprovidersedgesphones"></a>

## [**PhoneEntityListing**](PhoneEntityListing.html) GetProvidersEdgesPhones (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string webRtcUserId = null, string phoneBaseSettingsId = null, string linesLoggedInUserId = null, string linesDefaultForUserId = null, string phoneHardwareId = null, string linesId = null, string linesName = null, List<string> expand = null, List<string> fields = null)

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
            var webRtcUserId = webRtcUserId_example;  // string | Filter by webRtcUser.id (optional) 
            var phoneBaseSettingsId = phoneBaseSettingsId_example;  // string | Filter by phoneBaseSettings.id (optional) 
            var linesLoggedInUserId = linesLoggedInUserId_example;  // string | Filter by lines.loggedInUser.id (optional) 
            var linesDefaultForUserId = linesDefaultForUserId_example;  // string | Filter by lines.defaultForUser.id (optional) 
            var phoneHardwareId = phoneHardwareId_example;  // string | Filter by phone_hardwareId (optional) 
            var linesId = linesId_example;  // string | Filter by lines.id (optional) 
            var linesName = linesName_example;  // string | Filter by lines.name (optional) 
            var expand = new List<string>(); // List<string> | Fields to expand in the response, comma-separated (optional) 
            var fields = new List<string>(); // List<string> | Fields and properties to get, comma-separated (optional) 

            try
            {
                // Get a list of Phone Instances
                PhoneEntityListing result = apiInstance.GetProvidersEdgesPhones(pageNumber, pageSize, sortBy, sortOrder, siteId, webRtcUserId, phoneBaseSettingsId, linesLoggedInUserId, linesDefaultForUserId, phoneHardwareId, linesId, linesName, expand, fields);
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
| **webRtcUserId** | **string**| Filter by webRtcUser.id | [optional]  |
| **phoneBaseSettingsId** | **string**| Filter by phoneBaseSettings.id | [optional]  |
| **linesLoggedInUserId** | **string**| Filter by lines.loggedInUser.id | [optional]  |
| **linesDefaultForUserId** | **string**| Filter by lines.defaultForUser.id | [optional]  |
| **phoneHardwareId** | **string**| Filter by phone_hardwareId | [optional]  |
| **linesId** | **string**| Filter by lines.id | [optional]  |
| **linesName** | **string**| Filter by lines.name | [optional]  |
| **expand** | [**List<string>**](string.html)| Fields to expand in the response, comma-separated | [optional]  |
| **fields** | [**List<string>**](string.html)| Fields and properties to get, comma-separated | [optional]  |
{: class="table table-striped"}

### Return type

[**PhoneEntityListing**](PhoneEntityListing.html)

<a name="getprovidersedgesphonestemplate"></a>

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

[**Phone**](Phone.html)

<a name="getprovidersedgessite"></a>

## [**Site**](Site.html) GetProvidersEdgesSite (string siteId)

Get a Site by ID.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesSiteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID

            try
            {
                // Get a Site by ID.
                Site result = apiInstance.GetProvidersEdgesSite(siteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesSite: " + e.Message );
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

[**Site**](Site.html)

<a name="getprovidersedgessitenumberplan"></a>

## [**NumberPlan**](NumberPlan.html) GetProvidersEdgesSiteNumberplan (string siteId, string numberPlanId)

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
    public class GetProvidersEdgesSiteNumberplanExample
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
                NumberPlan result = apiInstance.GetProvidersEdgesSiteNumberplan(siteId, numberPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesSiteNumberplan: " + e.Message );
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

[**NumberPlan**](NumberPlan.html)

<a name="getprovidersedgessitenumberplans"></a>

## [**List&lt;NumberPlan&gt;**](NumberPlan.html) GetProvidersEdgesSiteNumberplans (string siteId)

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
    public class GetProvidersEdgesSiteNumberplansExample
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
                List&lt;NumberPlan&gt; result = apiInstance.GetProvidersEdgesSiteNumberplans(siteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesSiteNumberplans: " + e.Message );
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

[**List<NumberPlan>**](NumberPlan.html)

<a name="getprovidersedgessitenumberplansclassifications"></a>

## **List&lt;string&gt;** GetProvidersEdgesSiteNumberplansClassifications (string siteId, string classification = null)

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
    public class GetProvidersEdgesSiteNumberplansClassificationsExample
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
                List&lt;string&gt; result = apiInstance.GetProvidersEdgesSiteNumberplansClassifications(siteId, classification);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesSiteNumberplansClassifications: " + e.Message );
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

<a name="getprovidersedgessites"></a>

## [**SiteEntityListing**](SiteEntityListing.html) GetProvidersEdgesSites (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null)

Get the list of Sites.



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
                // Get the list of Sites.
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

[**SiteEntityListing**](SiteEntityListing.html)

<a name="getprovidersedgestimezones"></a>

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

[**TimeZoneEntityListing**](TimeZoneEntityListing.html)

<a name="getprovidersedgestrunk"></a>

## [**Trunk**](Trunk.html) GetProvidersEdgesTrunk (string trunkId)

Get a Trunk by ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesTrunkExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var trunkId = trunkId_example;  // string | Trunk ID

            try
            {
                // Get a Trunk by ID
                Trunk result = apiInstance.GetProvidersEdgesTrunk(trunkId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesTrunk: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trunkId** | **string**| Trunk ID |  |
{: class="table table-striped"}

### Return type

[**Trunk**](Trunk.html)

<a name="getprovidersedgestrunkbasesetting"></a>

## [**TrunkBase**](TrunkBase.html) GetProvidersEdgesTrunkbasesetting (string trunkBaseSettingsId)

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
    public class GetProvidersEdgesTrunkbasesettingExample
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
                TrunkBase result = apiInstance.GetProvidersEdgesTrunkbasesetting(trunkBaseSettingsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesTrunkbasesetting: " + e.Message );
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

[**TrunkBase**](TrunkBase.html)

<a name="getprovidersedgestrunkbasesettings"></a>

## [**TrunkBase**](TrunkBase.html) GetProvidersEdgesTrunkbasesettings (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, bool? recordingEnabled = null)

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
            var recordingEnabled = true;  // bool? | Filter trunks by recording enabled (optional) 

            try
            {
                // Get Trunk Base Settings listing
                TrunkBase result = apiInstance.GetProvidersEdgesTrunkbasesettings(pageNumber, pageSize, sortBy, sortOrder, recordingEnabled);
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
| **recordingEnabled** | **bool?**| Filter trunks by recording enabled | [optional]  |
{: class="table table-striped"}

### Return type

[**TrunkBase**](TrunkBase.html)

<a name="getprovidersedgestrunkbasesettingsavailablemetabases"></a>

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

[**TrunkMetabaseEntityListing**](TrunkMetabaseEntityListing.html)

<a name="getprovidersedgestrunkbasesettingstemplate"></a>

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

[**TrunkBase**](TrunkBase.html)

<a name="getprovidersedgestrunks"></a>

## [**TrunkEntityListing**](TrunkEntityListing.html) GetProvidersEdgesTrunks (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string edgeId = null, string trunkBaseId = null, string trunkType = null)

Get the list of available trunks.

Trunks are created by assigning trunk base settings to an Edge or Edge Group.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesTrunksExample
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
            var edgeId = edgeId_example;  // string | Filter by Edge Ids (optional) 
            var trunkBaseId = trunkBaseId_example;  // string | Filter by Trunk Base Ids (optional) 
            var trunkType = trunkType_example;  // string | Filter by a Trunk type (optional) 

            try
            {
                // Get the list of available trunks.
                TrunkEntityListing result = apiInstance.GetProvidersEdgesTrunks(pageNumber, pageSize, sortBy, sortOrder, edgeId, trunkBaseId, trunkType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesTrunks: " + e.Message );
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
| **edgeId** | **string**| Filter by Edge Ids | [optional]  |
| **trunkBaseId** | **string**| Filter by Trunk Base Ids | [optional]  |
| **trunkType** | **string**| Filter by a Trunk type | [optional]  |
{: class="table table-striped"}

### Return type

[**TrunkEntityListing**](TrunkEntityListing.html)

<a name="getprovidersedgestrunkswithrecording"></a>

## [**TrunkRecordingEnabledCount**](TrunkRecordingEnabledCount.html) GetProvidersEdgesTrunkswithrecording (string trunkType = null)

Get Counts of trunks that have recording disabled or enabled



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProvidersEdgesTrunkswithrecordingExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var trunkType = trunkType_example;  // string | The type of this trunk base. (optional) 

            try
            {
                // Get Counts of trunks that have recording disabled or enabled
                TrunkRecordingEnabledCount result = apiInstance.GetProvidersEdgesTrunkswithrecording(trunkType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetProvidersEdgesTrunkswithrecording: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trunkType** | **string**| The type of this trunk base. | [optional]  |
{: class="table table-striped"}

### Return type

[**TrunkRecordingEnabledCount**](TrunkRecordingEnabledCount.html)

<a name="getschemasedgesvnext"></a>

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

[**SchemaCategoryEntityListing**](SchemaCategoryEntityListing.html)

<a name="getschemasedgesvnextschemacategory"></a>

## [**SchemaReferenceEntityListing**](SchemaReferenceEntityListing.html) GetSchemasEdgesVnextSchemaCategory (string schemaCategory, int? pageSize = null, int? pageNumber = null)

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
    public class GetSchemasEdgesVnextSchemaCategoryExample
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
                SchemaReferenceEntityListing result = apiInstance.GetSchemasEdgesVnextSchemaCategory(schemaCategory, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetSchemasEdgesVnextSchemaCategory: " + e.Message );
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

[**SchemaReferenceEntityListing**](SchemaReferenceEntityListing.html)

<a name="getschemasedgesvnextschemacategoryschematype"></a>

## [**SchemaReferenceEntityListing**](SchemaReferenceEntityListing.html) GetSchemasEdgesVnextSchemaCategorySchemaType (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null)

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
    public class GetSchemasEdgesVnextSchemaCategorySchemaTypeExample
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
                SchemaReferenceEntityListing result = apiInstance.GetSchemasEdgesVnextSchemaCategorySchemaType(schemaCategory, schemaType, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetSchemasEdgesVnextSchemaCategorySchemaType: " + e.Message );
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

[**SchemaReferenceEntityListing**](SchemaReferenceEntityListing.html)

<a name="getschemasedgesvnextschemacategoryschematypeschemaid"></a>

## [**Organization**](Organization.html) GetSchemasEdgesVnextSchemaCategorySchemaTypeSchemaId (string schemaCategory, string schemaType, string schemaId)

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
    public class GetSchemasEdgesVnextSchemaCategorySchemaTypeSchemaIdExample
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
                Organization result = apiInstance.GetSchemasEdgesVnextSchemaCategorySchemaTypeSchemaId(schemaCategory, schemaType, schemaId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetSchemasEdgesVnextSchemaCategorySchemaTypeSchemaId: " + e.Message );
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

[**Organization**](Organization.html)

<a name="getschemasedgesvnextschemacategoryschematypeschemaidextensiontypemetadataid"></a>

## [**Organization**](Organization.html) GetSchemasEdgesVnextSchemaCategorySchemaTypeSchemaIdExtensionTypeMetadataId (string schemaCategory, string schemaType, string schemaId, string extensionType, string metadataId, string type = null)

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
    public class GetSchemasEdgesVnextSchemaCategorySchemaTypeSchemaIdExtensionTypeMetadataIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var schemaCategory = schemaCategory_example;  // string | Schema category
            var schemaType = schemaType_example;  // string | Schema type
            var schemaId = schemaId_example;  // string | Schema ID
            var extensionType = extensionType_example;  // string | extension
            var metadataId = metadataId_example;  // string | Metadata ID
            var type = type_example;  // string | Type (optional) 

            try
            {
                // Get metadata for a schema
                Organization result = apiInstance.GetSchemasEdgesVnextSchemaCategorySchemaTypeSchemaIdExtensionTypeMetadataId(schemaCategory, schemaType, schemaId, extensionType, metadataId, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.GetSchemasEdgesVnextSchemaCategorySchemaTypeSchemaIdExtensionTypeMetadataId: " + e.Message );
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
| **extensionType** | **string**| extension |  |
| **metadataId** | **string**| Metadata ID |  |
| **type** | **string**| Type | [optional]  |
{: class="table table-striped"}

### Return type

[**Organization**](Organization.html)

<a name="postprovidersedgelogicalinterfaces"></a>

## [**DomainLogicalInterface**](DomainLogicalInterface.html) PostProvidersEdgeLogicalinterfaces (string edgeId, DomainLogicalInterface body)

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
    public class PostProvidersEdgeLogicalinterfacesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var body = new DomainLogicalInterface(); // DomainLogicalInterface | Logical interface

            try
            {
                // Create an edge logical interface.
                DomainLogicalInterface result = apiInstance.PostProvidersEdgeLogicalinterfaces(edgeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgeLogicalinterfaces: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **body** | [**DomainLogicalInterface**](DomainLogicalInterface.html)| Logical interface |  |
{: class="table table-striped"}

### Return type

[**DomainLogicalInterface**](DomainLogicalInterface.html)

<a name="postprovidersedgelogsjobupload"></a>

## void PostProvidersEdgeLogsJobUpload (string edgeId, string jobId, EdgeLogsJobUploadRequest body)

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
    public class PostProvidersEdgeLogsJobUploadExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var jobId = jobId_example;  // string | Job ID
            var body = new EdgeLogsJobUploadRequest(); // EdgeLogsJobUploadRequest | Log upload request

            try
            {
                // Request that the specified fileIds be uploaded from the Edge.
                apiInstance.PostProvidersEdgeLogsJobUpload(edgeId, jobId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgeLogsJobUpload: " + e.Message );
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
| **body** | [**EdgeLogsJobUploadRequest**](EdgeLogsJobUploadRequest.html)| Log upload request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postprovidersedgelogsjobs"></a>

## [**EdgeLogsJobResponse**](EdgeLogsJobResponse.html) PostProvidersEdgeLogsJobs (string edgeId, EdgeLogsJobRequest body)

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
    public class PostProvidersEdgeLogsJobsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var body = new EdgeLogsJobRequest(); // EdgeLogsJobRequest | EdgeLogsJobRequest

            try
            {
                // Create a job to upload a list of Edge logs.
                EdgeLogsJobResponse result = apiInstance.PostProvidersEdgeLogsJobs(edgeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgeLogsJobs: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **body** | [**EdgeLogsJobRequest**](EdgeLogsJobRequest.html)| EdgeLogsJobRequest |  |
{: class="table table-striped"}

### Return type

[**EdgeLogsJobResponse**](EdgeLogsJobResponse.html)

<a name="postprovidersedgereboot"></a>

## **string** PostProvidersEdgeReboot (string edgeId)

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
    public class PostProvidersEdgeRebootExample
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
                string result = apiInstance.PostProvidersEdgeReboot(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgeReboot: " + e.Message );
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

<a name="postprovidersedgesoftwareupdate"></a>

## [**DomainEdgeSoftwareUpdateDto**](DomainEdgeSoftwareUpdateDto.html) PostProvidersEdgeSoftwareupdate (string edgeId, DomainEdgeSoftwareUpdateDto body)

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
    public class PostProvidersEdgeSoftwareupdateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var body = new DomainEdgeSoftwareUpdateDto(); // DomainEdgeSoftwareUpdateDto | Software update request

            try
            {
                // Starts a software update for this edge.
                DomainEdgeSoftwareUpdateDto result = apiInstance.PostProvidersEdgeSoftwareupdate(edgeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgeSoftwareupdate: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **body** | [**DomainEdgeSoftwareUpdateDto**](DomainEdgeSoftwareUpdateDto.html)| Software update request |  |
{: class="table table-striped"}

### Return type

[**DomainEdgeSoftwareUpdateDto**](DomainEdgeSoftwareUpdateDto.html)

<a name="postprovidersedgeunpair"></a>

## **string** PostProvidersEdgeUnpair (string edgeId)

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
    public class PostProvidersEdgeUnpairExample
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
                string result = apiInstance.PostProvidersEdgeUnpair(edgeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgeUnpair: " + e.Message );
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

<a name="postprovidersedges"></a>

## [**Edge**](Edge.html) PostProvidersEdges (Edge body)

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
            var body = new Edge(); // Edge | Edge

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
| **body** | [**Edge**](Edge.html)| Edge |  |
{: class="table table-striped"}

### Return type

[**Edge**](Edge.html)

<a name="postprovidersedgesaddressvalidation"></a>

## [**ValidateAddressResponse**](ValidateAddressResponse.html) PostProvidersEdgesAddressvalidation (ValidateAddressRequest body)

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
            var body = new ValidateAddressRequest(); // ValidateAddressRequest | Address

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
| **body** | [**ValidateAddressRequest**](ValidateAddressRequest.html)| Address |  |
{: class="table table-striped"}

### Return type

[**ValidateAddressResponse**](ValidateAddressResponse.html)

<a name="postprovidersedgescertificateauthorities"></a>

## [**DomainCertificateAuthority**](DomainCertificateAuthority.html) PostProvidersEdgesCertificateauthorities (DomainCertificateAuthority body)

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
            var body = new DomainCertificateAuthority(); // DomainCertificateAuthority | CertificateAuthority

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
| **body** | [**DomainCertificateAuthority**](DomainCertificateAuthority.html)| CertificateAuthority |  |
{: class="table table-striped"}

### Return type

[**DomainCertificateAuthority**](DomainCertificateAuthority.html)

<a name="postprovidersedgesdidpools"></a>

## [**DIDPool**](DIDPool.html) PostProvidersEdgesDidpools (DIDPool body)

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
            var body = new DIDPool(); // DIDPool | DID pool

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
| **body** | [**DIDPool**](DIDPool.html)| DID pool |  |
{: class="table table-striped"}

### Return type

[**DIDPool**](DIDPool.html)

<a name="postprovidersedgesedgegroups"></a>

## [**EdgeGroup**](EdgeGroup.html) PostProvidersEdgesEdgegroups (EdgeGroup body)

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
            var body = new EdgeGroup(); // EdgeGroup | EdgeGroup

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
| **body** | [**EdgeGroup**](EdgeGroup.html)| EdgeGroup |  |
{: class="table table-striped"}

### Return type

[**EdgeGroup**](EdgeGroup.html)

<a name="postprovidersedgesendpoints"></a>

## [**Endpoint**](Endpoint.html) PostProvidersEdgesEndpoints (Endpoint body)

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
            var body = new Endpoint(); // Endpoint | EndpointTemplate

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
| **body** | [**Endpoint**](Endpoint.html)| EndpointTemplate |  |
{: class="table table-striped"}

### Return type

[**Endpoint**](Endpoint.html)

<a name="postprovidersedgesextensionpools"></a>

## [**Extension**](Extension.html) PostProvidersEdgesExtensionpools (ExtensionPool body)

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
            var body = new ExtensionPool(); // ExtensionPool | ExtensionPool

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
| **body** | [**ExtensionPool**](ExtensionPool.html)| ExtensionPool |  |
{: class="table table-striped"}

### Return type

[**Extension**](Extension.html)

<a name="postprovidersedgesoutboundroutes"></a>

## [**OutboundRoute**](OutboundRoute.html) PostProvidersEdgesOutboundroutes (OutboundRoute body)

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
            var body = new OutboundRoute(); // OutboundRoute | OutboundRoute

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
| **body** | [**OutboundRoute**](OutboundRoute.html)| OutboundRoute |  |
{: class="table table-striped"}

### Return type

[**OutboundRoute**](OutboundRoute.html)

<a name="postprovidersedgesphonereboot"></a>

## void PostProvidersEdgesPhoneReboot (string phoneId)

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
    public class PostProvidersEdgesPhoneRebootExample
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
                apiInstance.PostProvidersEdgesPhoneReboot(phoneId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgesPhoneReboot: " + e.Message );
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

<a name="postprovidersedgesphonebasesettings"></a>

## [**PhoneBase**](PhoneBase.html) PostProvidersEdgesPhonebasesettings (PhoneBase body)

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
            var body = new PhoneBase(); // PhoneBase | Phone base settings

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
| **body** | [**PhoneBase**](PhoneBase.html)| Phone base settings |  |
{: class="table table-striped"}

### Return type

[**PhoneBase**](PhoneBase.html)

<a name="postprovidersedgesphones"></a>

## [**Phone**](Phone.html) PostProvidersEdgesPhones (Phone body)

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
            var body = new Phone(); // Phone | Phone

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
| **body** | [**Phone**](Phone.html)| Phone |  |
{: class="table table-striped"}

### Return type

[**Phone**](Phone.html)

<a name="postprovidersedgesphonesreboot"></a>

## void PostProvidersEdgesPhonesReboot (PhonesReboot body)

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
            var body = new PhonesReboot(); // PhonesReboot | Phones

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
| **body** | [**PhonesReboot**](PhonesReboot.html)| Phones |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postprovidersedgessiterebalance"></a>

## void PostProvidersEdgesSiteRebalance (string siteId)

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
    public class PostProvidersEdgesSiteRebalanceExample
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
                apiInstance.PostProvidersEdgesSiteRebalance(siteId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PostProvidersEdgesSiteRebalance: " + e.Message );
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

<a name="postprovidersedgessites"></a>

## [**Site**](Site.html) PostProvidersEdgesSites (Site body)

Create a Site.



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
            var body = new Site(); // Site | Site

            try
            {
                // Create a Site.
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
| **body** | [**Site**](Site.html)| Site |  |
{: class="table table-striped"}

### Return type

[**Site**](Site.html)

<a name="postprovidersedgestrunkbasesettings"></a>

## [**TrunkBase**](TrunkBase.html) PostProvidersEdgesTrunkbasesettings (TrunkBase body)

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
            var body = new TrunkBase(); // TrunkBase | Trunk base settings

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
| **body** | [**TrunkBase**](TrunkBase.html)| Trunk base settings |  |
{: class="table table-striped"}

### Return type

[**TrunkBase**](TrunkBase.html)

<a name="putprovidersedge"></a>

## [**Edge**](Edge.html) PutProvidersEdge (string edgeId, Edge body)

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
    public class PutProvidersEdgeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var body = new Edge(); // Edge | Edge

            try
            {
                // Update a edge.
                Edge result = apiInstance.PutProvidersEdge(edgeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdge: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeId** | **string**| Edge ID |  |
| **body** | [**Edge**](Edge.html)| Edge |  |
{: class="table table-striped"}

### Return type

[**Edge**](Edge.html)

<a name="putprovidersedgeline"></a>

## [**EdgeLine**](EdgeLine.html) PutProvidersEdgeLine (string edgeId, string lineId, EdgeLine body)

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
    public class PutProvidersEdgeLineExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var lineId = lineId_example;  // string | Line ID
            var body = new EdgeLine(); // EdgeLine | Line

            try
            {
                // Update a line.
                EdgeLine result = apiInstance.PutProvidersEdgeLine(edgeId, lineId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgeLine: " + e.Message );
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
| **body** | [**EdgeLine**](EdgeLine.html)| Line |  |
{: class="table table-striped"}

### Return type

[**EdgeLine**](EdgeLine.html)

<a name="putprovidersedgelogicalinterface"></a>

## [**DomainLogicalInterface**](DomainLogicalInterface.html) PutProvidersEdgeLogicalinterface (string edgeId, string interfaceId, DomainLogicalInterface body)

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
    public class PutProvidersEdgeLogicalinterfaceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeId = edgeId_example;  // string | Edge ID
            var interfaceId = interfaceId_example;  // string | Interface ID
            var body = new DomainLogicalInterface(); // DomainLogicalInterface | Logical interface

            try
            {
                // Update an edge logical interface.
                DomainLogicalInterface result = apiInstance.PutProvidersEdgeLogicalinterface(edgeId, interfaceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgeLogicalinterface: " + e.Message );
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
| **body** | [**DomainLogicalInterface**](DomainLogicalInterface.html)| Logical interface |  |
{: class="table table-striped"}

### Return type

[**DomainLogicalInterface**](DomainLogicalInterface.html)

<a name="putprovidersedgescertificateauthority"></a>

## [**DomainCertificateAuthority**](DomainCertificateAuthority.html) PutProvidersEdgesCertificateauthority (string certificateId, DomainCertificateAuthority body)

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
    public class PutProvidersEdgesCertificateauthorityExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var certificateId = certificateId_example;  // string | Certificate ID
            var body = new DomainCertificateAuthority(); // DomainCertificateAuthority | Certificate authority

            try
            {
                // Update a certificate authority.
                DomainCertificateAuthority result = apiInstance.PutProvidersEdgesCertificateauthority(certificateId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesCertificateauthority: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **certificateId** | **string**| Certificate ID |  |
| **body** | [**DomainCertificateAuthority**](DomainCertificateAuthority.html)| Certificate authority |  |
{: class="table table-striped"}

### Return type

[**DomainCertificateAuthority**](DomainCertificateAuthority.html)

<a name="putprovidersedgesdid"></a>

## [**DID**](DID.html) PutProvidersEdgesDid (string didId, DID body)

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
    public class PutProvidersEdgesDidExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var didId = didId_example;  // string | DID ID
            var body = new DID(); // DID | DID

            try
            {
                // Update a DID by ID.
                DID result = apiInstance.PutProvidersEdgesDid(didId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesDid: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **didId** | **string**| DID ID |  |
| **body** | [**DID**](DID.html)| DID |  |
{: class="table table-striped"}

### Return type

[**DID**](DID.html)

<a name="putprovidersedgesdidpool"></a>

## [**DIDPool**](DIDPool.html) PutProvidersEdgesDidpool (string didPoolId, DIDPool body)

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
    public class PutProvidersEdgesDidpoolExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var didPoolId = didPoolId_example;  // string | DID pool ID
            var body = new DIDPool(); // DIDPool | DID pool

            try
            {
                // Update a DID Pool by ID.
                DIDPool result = apiInstance.PutProvidersEdgesDidpool(didPoolId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesDidpool: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **didPoolId** | **string**| DID pool ID |  |
| **body** | [**DIDPool**](DIDPool.html)| DID pool |  |
{: class="table table-striped"}

### Return type

[**DIDPool**](DIDPool.html)

<a name="putprovidersedgesedgegroup"></a>

## [**EdgeGroup**](EdgeGroup.html) PutProvidersEdgesEdgegroup (string edgeGroupId, EdgeGroup body)

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
    public class PutProvidersEdgesEdgegroupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var edgeGroupId = edgeGroupId_example;  // string | Edge group ID
            var body = new EdgeGroup(); // EdgeGroup | EdgeGroup

            try
            {
                // Update an edge group.
                EdgeGroup result = apiInstance.PutProvidersEdgesEdgegroup(edgeGroupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesEdgegroup: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **edgeGroupId** | **string**| Edge group ID |  |
| **body** | [**EdgeGroup**](EdgeGroup.html)| EdgeGroup |  |
{: class="table table-striped"}

### Return type

[**EdgeGroup**](EdgeGroup.html)

<a name="putprovidersedgesendpoint"></a>

## [**Endpoint**](Endpoint.html) PutProvidersEdgesEndpoint (string endpointId, Endpoint body)

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
    public class PutProvidersEdgesEndpointExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var endpointId = endpointId_example;  // string | Endpoint ID
            var body = new Endpoint(); // Endpoint | EndpointTemplate

            try
            {
                // Update endpoint
                Endpoint result = apiInstance.PutProvidersEdgesEndpoint(endpointId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesEndpoint: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **endpointId** | **string**| Endpoint ID |  |
| **body** | [**Endpoint**](Endpoint.html)| EndpointTemplate |  |
{: class="table table-striped"}

### Return type

[**Endpoint**](Endpoint.html)

<a name="putprovidersedgesextension"></a>

## [**Extension**](Extension.html) PutProvidersEdgesExtension (string extensionId, Extension body)

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
    public class PutProvidersEdgesExtensionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var extensionId = extensionId_example;  // string | Extension ID
            var body = new Extension(); // Extension | Extension

            try
            {
                // Update an extension by ID.
                Extension result = apiInstance.PutProvidersEdgesExtension(extensionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesExtension: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **extensionId** | **string**| Extension ID |  |
| **body** | [**Extension**](Extension.html)| Extension |  |
{: class="table table-striped"}

### Return type

[**Extension**](Extension.html)

<a name="putprovidersedgesextensionpool"></a>

## [**ExtensionPool**](ExtensionPool.html) PutProvidersEdgesExtensionpool (string extensionPoolId, ExtensionPool body)

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
    public class PutProvidersEdgesExtensionpoolExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var extensionPoolId = extensionPoolId_example;  // string | Extension pool ID
            var body = new ExtensionPool(); // ExtensionPool | ExtensionPool

            try
            {
                // Update an extension pool by ID
                ExtensionPool result = apiInstance.PutProvidersEdgesExtensionpool(extensionPoolId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesExtensionpool: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **extensionPoolId** | **string**| Extension pool ID |  |
| **body** | [**ExtensionPool**](ExtensionPool.html)| ExtensionPool |  |
{: class="table table-striped"}

### Return type

[**ExtensionPool**](ExtensionPool.html)

<a name="putprovidersedgesoutboundroute"></a>

## [**OutboundRoute**](OutboundRoute.html) PutProvidersEdgesOutboundroute (string outboundRouteId, OutboundRoute body)

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
    public class PutProvidersEdgesOutboundrouteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var outboundRouteId = outboundRouteId_example;  // string | Outbound route ID
            var body = new OutboundRoute(); // OutboundRoute | OutboundRoute

            try
            {
                // Update outbound route
                OutboundRoute result = apiInstance.PutProvidersEdgesOutboundroute(outboundRouteId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesOutboundroute: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **outboundRouteId** | **string**| Outbound route ID |  |
| **body** | [**OutboundRoute**](OutboundRoute.html)| OutboundRoute |  |
{: class="table table-striped"}

### Return type

[**OutboundRoute**](OutboundRoute.html)

<a name="putprovidersedgesphone"></a>

## [**Phone**](Phone.html) PutProvidersEdgesPhone (string phoneId, Phone body)

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
    public class PutProvidersEdgesPhoneExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneId = phoneId_example;  // string | Phone ID
            var body = new Phone(); // Phone | Phone

            try
            {
                // Update a Phone by ID
                Phone result = apiInstance.PutProvidersEdgesPhone(phoneId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesPhone: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneId** | **string**| Phone ID |  |
| **body** | [**Phone**](Phone.html)| Phone |  |
{: class="table table-striped"}

### Return type

[**Phone**](Phone.html)

<a name="putprovidersedgesphonebasesetting"></a>

## [**PhoneBase**](PhoneBase.html) PutProvidersEdgesPhonebasesetting (string phoneBaseId, PhoneBase body)

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
    public class PutProvidersEdgesPhonebasesettingExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var phoneBaseId = phoneBaseId_example;  // string | Phone base ID
            var body = new PhoneBase(); // PhoneBase | Phone base settings

            try
            {
                // Update a Phone Base Settings by ID
                PhoneBase result = apiInstance.PutProvidersEdgesPhonebasesetting(phoneBaseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesPhonebasesetting: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **phoneBaseId** | **string**| Phone base ID |  |
| **body** | [**PhoneBase**](PhoneBase.html)| Phone base settings |  |
{: class="table table-striped"}

### Return type

[**PhoneBase**](PhoneBase.html)

<a name="putprovidersedgessite"></a>

## [**Site**](Site.html) PutProvidersEdgesSite (string siteId, Site body)

Update a Site by ID.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutProvidersEdgesSiteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID
            var body = new Site(); // Site | Site

            try
            {
                // Update a Site by ID.
                Site result = apiInstance.PutProvidersEdgesSite(siteId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesSite: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **body** | [**Site**](Site.html)| Site |  |
{: class="table table-striped"}

### Return type

[**Site**](Site.html)

<a name="putprovidersedgessitenumberplans"></a>

## [**List&lt;NumberPlan&gt;**](NumberPlan.html) PutProvidersEdgesSiteNumberplans (string siteId, List<NumberPlan> body)

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
    public class PutProvidersEdgesSiteNumberplansExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var siteId = siteId_example;  // string | Site ID
            var body = new List<NumberPlan>(); // List<NumberPlan> | List of number plans

            try
            {
                // Update the list of Number Plans.
                List&lt;NumberPlan&gt; result = apiInstance.PutProvidersEdgesSiteNumberplans(siteId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesSiteNumberplans: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **siteId** | **string**| Site ID |  |
| **body** | [**List<NumberPlan>**](NumberPlan.html)| List of number plans |  |
{: class="table table-striped"}

### Return type

[**List<NumberPlan>**](NumberPlan.html)

<a name="putprovidersedgestrunkbasesetting"></a>

## [**TrunkBase**](TrunkBase.html) PutProvidersEdgesTrunkbasesetting (string trunkBaseSettingsId, TrunkBase body)

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
    public class PutProvidersEdgesTrunkbasesettingExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new TelephonyProvidersEdgeApi();
            var trunkBaseSettingsId = trunkBaseSettingsId_example;  // string | Trunk Base ID
            var body = new TrunkBase(); // TrunkBase | Trunk base settings

            try
            {
                // Update a Trunk Base Settings object by ID
                TrunkBase result = apiInstance.PutProvidersEdgesTrunkbasesetting(trunkBaseSettingsId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TelephonyProvidersEdgeApi.PutProvidersEdgesTrunkbasesetting: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **trunkBaseSettingsId** | **string**| Trunk Base ID |  |
| **body** | [**TrunkBase**](TrunkBase.html)| Trunk base settings |  |
{: class="table table-striped"}

### Return type

[**TrunkBase**](TrunkBase.html)

