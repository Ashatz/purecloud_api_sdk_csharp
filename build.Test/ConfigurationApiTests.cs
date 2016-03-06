using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Model;

namespace ININ.PureCloudApi.Test
{
    [TestFixture]
    public class ConfigurationApiTests
    {
        private ConfigurationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new ConfigurationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ConfigurationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<ConfigurationApi> (instance, "instance is a ConfigurationApi");
        }

        
        /// <summary>
        /// Test GetDidpools
        /// </summary>
        [Test]
        public void GetDidpoolsTest()
        {
            // TODO: add unit test for the method 'GetDidpools'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            
            var response = instance.GetDidpools(pageSize, pageNumber, sortBy);
            Assert.IsInstanceOf<DIDPoolEntityListing> (response, "response is DIDPoolEntityListing"); 
        }
        
        /// <summary>
        /// Test PostDidpools
        /// </summary>
        [Test]
        public void PostDidpoolsTest()
        {
            // TODO: add unit test for the method 'PostDidpools'
            DIDPool body = null; // TODO: replace null with proper value
            
            var response = instance.PostDidpools(body);
            Assert.IsInstanceOf<DIDPool> (response, "response is DIDPool"); 
        }
        
        /// <summary>
        /// Test GetDidpoolsDidpoolId
        /// </summary>
        [Test]
        public void GetDidpoolsDidpoolIdTest()
        {
            // TODO: add unit test for the method 'GetDidpoolsDidpoolId'
            string didPoolId = null; // TODO: replace null with proper value
            
            var response = instance.GetDidpoolsDidpoolId(didPoolId);
            Assert.IsInstanceOf<DIDPool> (response, "response is DIDPool"); 
        }
        
        /// <summary>
        /// Test PutDidpoolsDidpoolId
        /// </summary>
        [Test]
        public void PutDidpoolsDidpoolIdTest()
        {
            // TODO: add unit test for the method 'PutDidpoolsDidpoolId'
            string didPoolId = null; // TODO: replace null with proper value
            DIDPool body = null; // TODO: replace null with proper value
            
            var response = instance.PutDidpoolsDidpoolId(didPoolId, body);
            Assert.IsInstanceOf<DIDPool> (response, "response is DIDPool"); 
        }
        
        /// <summary>
        /// Test DeleteDidpoolsDidpoolId
        /// </summary>
        [Test]
        public void DeleteDidpoolsDidpoolIdTest()
        {
            // TODO: add unit test for the method 'DeleteDidpoolsDidpoolId'
            string didPoolId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteDidpoolsDidpoolId(didPoolId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetDids
        /// </summary>
        [Test]
        public void GetDidsTest()
        {
            // TODO: add unit test for the method 'GetDids'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            string phoneNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetDids(pageSize, pageNumber, sortBy, sortOrder, phoneNumber);
            Assert.IsInstanceOf<DIDEntityListing> (response, "response is DIDEntityListing"); 
        }
        
        /// <summary>
        /// Test GetDidsDidId
        /// </summary>
        [Test]
        public void GetDidsDidIdTest()
        {
            // TODO: add unit test for the method 'GetDidsDidId'
            string didId = null; // TODO: replace null with proper value
            
            var response = instance.GetDidsDidId(didId);
            Assert.IsInstanceOf<DID> (response, "response is DID"); 
        }
        
        /// <summary>
        /// Test PutDidsDidId
        /// </summary>
        [Test]
        public void PutDidsDidIdTest()
        {
            // TODO: add unit test for the method 'PutDidsDidId'
            string didId = null; // TODO: replace null with proper value
            DID body = null; // TODO: replace null with proper value
            
            var response = instance.PutDidsDidId(didId, body);
            Assert.IsInstanceOf<DID> (response, "response is DID"); 
        }
        
        /// <summary>
        /// Test GetEdges
        /// </summary>
        [Test]
        public void GetEdgesTest()
        {
            // TODO: add unit test for the method 'GetEdges'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string siteId = null; // TODO: replace null with proper value
            string edgeGroupId = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            
            var response = instance.GetEdges(pageSize, pageNumber, name, siteId, edgeGroupId, sortBy);
            Assert.IsInstanceOf<EdgeEntityListing> (response, "response is EdgeEntityListing"); 
        }
        
        /// <summary>
        /// Test PostEdges
        /// </summary>
        [Test]
        public void PostEdgesTest()
        {
            // TODO: add unit test for the method 'PostEdges'
            Edge body = null; // TODO: replace null with proper value
            
            var response = instance.PostEdges(body);
            Assert.IsInstanceOf<Edge> (response, "response is Edge"); 
        }
        
        /// <summary>
        /// Test GetEdgesCertificateauthorities
        /// </summary>
        [Test]
        public void GetEdgesCertificateauthoritiesTest()
        {
            // TODO: add unit test for the method 'GetEdgesCertificateauthorities'
            
            var response = instance.GetEdgesCertificateauthorities();
            Assert.IsInstanceOf<CertificateAuthorityEntityListing> (response, "response is CertificateAuthorityEntityListing"); 
        }
        
        /// <summary>
        /// Test PostEdgesCertificateauthorities
        /// </summary>
        [Test]
        public void PostEdgesCertificateauthoritiesTest()
        {
            // TODO: add unit test for the method 'PostEdgesCertificateauthorities'
            DomainCertificateAuthority body = null; // TODO: replace null with proper value
            
            var response = instance.PostEdgesCertificateauthorities(body);
            Assert.IsInstanceOf<DomainCertificateAuthority> (response, "response is DomainCertificateAuthority"); 
        }
        
        /// <summary>
        /// Test GetEdgesCertificateauthoritiesCertificateId
        /// </summary>
        [Test]
        public void GetEdgesCertificateauthoritiesCertificateIdTest()
        {
            // TODO: add unit test for the method 'GetEdgesCertificateauthoritiesCertificateId'
            string certificateId = null; // TODO: replace null with proper value
            
            var response = instance.GetEdgesCertificateauthoritiesCertificateId(certificateId);
            Assert.IsInstanceOf<DomainCertificateAuthority> (response, "response is DomainCertificateAuthority"); 
        }
        
        /// <summary>
        /// Test PutEdgesCertificateauthoritiesCertificateId
        /// </summary>
        [Test]
        public void PutEdgesCertificateauthoritiesCertificateIdTest()
        {
            // TODO: add unit test for the method 'PutEdgesCertificateauthoritiesCertificateId'
            string certificateId = null; // TODO: replace null with proper value
            DomainCertificateAuthority body = null; // TODO: replace null with proper value
            
            var response = instance.PutEdgesCertificateauthoritiesCertificateId(certificateId, body);
            Assert.IsInstanceOf<DomainCertificateAuthority> (response, "response is DomainCertificateAuthority"); 
        }
        
        /// <summary>
        /// Test DeleteEdgesCertificateauthoritiesCertificateId
        /// </summary>
        [Test]
        public void DeleteEdgesCertificateauthoritiesCertificateIdTest()
        {
            // TODO: add unit test for the method 'DeleteEdgesCertificateauthoritiesCertificateId'
            string certificateId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteEdgesCertificateauthoritiesCertificateId(certificateId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetEdgesEdgeId
        /// </summary>
        [Test]
        public void GetEdgesEdgeIdTest()
        {
            // TODO: add unit test for the method 'GetEdgesEdgeId'
            string edgeId = null; // TODO: replace null with proper value
            
            var response = instance.GetEdgesEdgeId(edgeId);
            Assert.IsInstanceOf<Edge> (response, "response is Edge"); 
        }
        
        /// <summary>
        /// Test PutEdgesEdgeId
        /// </summary>
        [Test]
        public void PutEdgesEdgeIdTest()
        {
            // TODO: add unit test for the method 'PutEdgesEdgeId'
            string edgeId = null; // TODO: replace null with proper value
            Edge body = null; // TODO: replace null with proper value
            
            var response = instance.PutEdgesEdgeId(edgeId, body);
            Assert.IsInstanceOf<Edge> (response, "response is Edge"); 
        }
        
        /// <summary>
        /// Test DeleteEdgesEdgeId
        /// </summary>
        [Test]
        public void DeleteEdgesEdgeIdTest()
        {
            // TODO: add unit test for the method 'DeleteEdgesEdgeId'
            string edgeId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteEdgesEdgeId(edgeId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetEdgesEdgeIdLines
        /// </summary>
        [Test]
        public void GetEdgesEdgeIdLinesTest()
        {
            // TODO: add unit test for the method 'GetEdgesEdgeIdLines'
            string edgeId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetEdgesEdgeIdLines(edgeId, pageSize, pageNumber);
            Assert.IsInstanceOf<EdgeLineEntityListing> (response, "response is EdgeLineEntityListing"); 
        }
        
        /// <summary>
        /// Test GetEdgesEdgeIdLinesLineId
        /// </summary>
        [Test]
        public void GetEdgesEdgeIdLinesLineIdTest()
        {
            // TODO: add unit test for the method 'GetEdgesEdgeIdLinesLineId'
            string edgeId = null; // TODO: replace null with proper value
            string lineId = null; // TODO: replace null with proper value
            
            var response = instance.GetEdgesEdgeIdLinesLineId(edgeId, lineId);
            Assert.IsInstanceOf<EdgeLine> (response, "response is EdgeLine"); 
        }
        
        /// <summary>
        /// Test PutEdgesEdgeIdLinesLineId
        /// </summary>
        [Test]
        public void PutEdgesEdgeIdLinesLineIdTest()
        {
            // TODO: add unit test for the method 'PutEdgesEdgeIdLinesLineId'
            string edgeId = null; // TODO: replace null with proper value
            string lineId = null; // TODO: replace null with proper value
            EdgeLine body = null; // TODO: replace null with proper value
            
            var response = instance.PutEdgesEdgeIdLinesLineId(edgeId, lineId, body);
            Assert.IsInstanceOf<EdgeLine> (response, "response is EdgeLine"); 
        }
        
        /// <summary>
        /// Test GetEdgesEdgeIdLogicalinterfaces
        /// </summary>
        [Test]
        public void GetEdgesEdgeIdLogicalinterfacesTest()
        {
            // TODO: add unit test for the method 'GetEdgesEdgeIdLogicalinterfaces'
            string edgeId = null; // TODO: replace null with proper value
            
            var response = instance.GetEdgesEdgeIdLogicalinterfaces(edgeId);
            Assert.IsInstanceOf<LogicalInterfaceEntityListing> (response, "response is LogicalInterfaceEntityListing"); 
        }
        
        /// <summary>
        /// Test PostEdgesEdgeIdLogicalinterfaces
        /// </summary>
        [Test]
        public void PostEdgesEdgeIdLogicalinterfacesTest()
        {
            // TODO: add unit test for the method 'PostEdgesEdgeIdLogicalinterfaces'
            string edgeId = null; // TODO: replace null with proper value
            DomainLogicalInterface body = null; // TODO: replace null with proper value
            
            var response = instance.PostEdgesEdgeIdLogicalinterfaces(edgeId, body);
            Assert.IsInstanceOf<DomainLogicalInterface> (response, "response is DomainLogicalInterface"); 
        }
        
        /// <summary>
        /// Test GetEdgesEdgeIdLogicalinterfacesInterfaceId
        /// </summary>
        [Test]
        public void GetEdgesEdgeIdLogicalinterfacesInterfaceIdTest()
        {
            // TODO: add unit test for the method 'GetEdgesEdgeIdLogicalinterfacesInterfaceId'
            string edgeId = null; // TODO: replace null with proper value
            string interfaceId = null; // TODO: replace null with proper value
            
            var response = instance.GetEdgesEdgeIdLogicalinterfacesInterfaceId(edgeId, interfaceId);
            Assert.IsInstanceOf<DomainLogicalInterface> (response, "response is DomainLogicalInterface"); 
        }
        
        /// <summary>
        /// Test PutEdgesEdgeIdLogicalinterfacesInterfaceId
        /// </summary>
        [Test]
        public void PutEdgesEdgeIdLogicalinterfacesInterfaceIdTest()
        {
            // TODO: add unit test for the method 'PutEdgesEdgeIdLogicalinterfacesInterfaceId'
            string edgeId = null; // TODO: replace null with proper value
            string interfaceId = null; // TODO: replace null with proper value
            DomainLogicalInterface body = null; // TODO: replace null with proper value
            
            var response = instance.PutEdgesEdgeIdLogicalinterfacesInterfaceId(edgeId, interfaceId, body);
            Assert.IsInstanceOf<DomainLogicalInterface> (response, "response is DomainLogicalInterface"); 
        }
        
        /// <summary>
        /// Test DeleteEdgesEdgeIdLogicalinterfacesInterfaceId
        /// </summary>
        [Test]
        public void DeleteEdgesEdgeIdLogicalinterfacesInterfaceIdTest()
        {
            // TODO: add unit test for the method 'DeleteEdgesEdgeIdLogicalinterfacesInterfaceId'
            string edgeId = null; // TODO: replace null with proper value
            string interfaceId = null; // TODO: replace null with proper value
            
            instance.DeleteEdgesEdgeIdLogicalinterfacesInterfaceId(edgeId, interfaceId);
             
        }
        
        /// <summary>
        /// Test PostEdgesEdgeIdLogsJobs
        /// </summary>
        [Test]
        public void PostEdgesEdgeIdLogsJobsTest()
        {
            // TODO: add unit test for the method 'PostEdgesEdgeIdLogsJobs'
            string edgeId = null; // TODO: replace null with proper value
            EdgeLogsJobRequest body = null; // TODO: replace null with proper value
            
            var response = instance.PostEdgesEdgeIdLogsJobs(edgeId, body);
            Assert.IsInstanceOf<EdgeLogsJobResponse> (response, "response is EdgeLogsJobResponse"); 
        }
        
        /// <summary>
        /// Test GetEdgesEdgeIdLogsJobsJobId
        /// </summary>
        [Test]
        public void GetEdgesEdgeIdLogsJobsJobIdTest()
        {
            // TODO: add unit test for the method 'GetEdgesEdgeIdLogsJobsJobId'
            string edgeId = null; // TODO: replace null with proper value
            string jobId = null; // TODO: replace null with proper value
            
            var response = instance.GetEdgesEdgeIdLogsJobsJobId(edgeId, jobId);
            Assert.IsInstanceOf<EdgeLogsJob> (response, "response is EdgeLogsJob"); 
        }
        
        /// <summary>
        /// Test PostEdgesEdgeIdLogsJobsJobIdUpload
        /// </summary>
        [Test]
        public void PostEdgesEdgeIdLogsJobsJobIdUploadTest()
        {
            // TODO: add unit test for the method 'PostEdgesEdgeIdLogsJobsJobIdUpload'
            string edgeId = null; // TODO: replace null with proper value
            string jobId = null; // TODO: replace null with proper value
            EdgeLogsJobUploadRequest body = null; // TODO: replace null with proper value
            
            instance.PostEdgesEdgeIdLogsJobsJobIdUpload(edgeId, jobId, body);
             
        }
        
        /// <summary>
        /// Test GetEdgesEdgeIdPhysicalinterfaces
        /// </summary>
        [Test]
        public void GetEdgesEdgeIdPhysicalinterfacesTest()
        {
            // TODO: add unit test for the method 'GetEdgesEdgeIdPhysicalinterfaces'
            string edgeId = null; // TODO: replace null with proper value
            
            var response = instance.GetEdgesEdgeIdPhysicalinterfaces(edgeId);
            Assert.IsInstanceOf<PhysicalInterfaceEntityListing> (response, "response is PhysicalInterfaceEntityListing"); 
        }
        
        /// <summary>
        /// Test GetEdgesEdgeIdPhysicalinterfacesInterfaceId
        /// </summary>
        [Test]
        public void GetEdgesEdgeIdPhysicalinterfacesInterfaceIdTest()
        {
            // TODO: add unit test for the method 'GetEdgesEdgeIdPhysicalinterfacesInterfaceId'
            string edgeId = null; // TODO: replace null with proper value
            string interfaceId = null; // TODO: replace null with proper value
            
            var response = instance.GetEdgesEdgeIdPhysicalinterfacesInterfaceId(edgeId, interfaceId);
            Assert.IsInstanceOf<DomainPhysicalInterface> (response, "response is DomainPhysicalInterface"); 
        }
        
        /// <summary>
        /// Test PostEdgesEdgeIdReboot
        /// </summary>
        [Test]
        public void PostEdgesEdgeIdRebootTest()
        {
            // TODO: add unit test for the method 'PostEdgesEdgeIdReboot'
            string edgeId = null; // TODO: replace null with proper value
            
            var response = instance.PostEdgesEdgeIdReboot(edgeId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetEdgesEdgeIdSoftwareupdate
        /// </summary>
        [Test]
        public void GetEdgesEdgeIdSoftwareupdateTest()
        {
            // TODO: add unit test for the method 'GetEdgesEdgeIdSoftwareupdate'
            string edgeId = null; // TODO: replace null with proper value
            
            var response = instance.GetEdgesEdgeIdSoftwareupdate(edgeId);
            Assert.IsInstanceOf<DomainEdgeSoftwareUpdateDto> (response, "response is DomainEdgeSoftwareUpdateDto"); 
        }
        
        /// <summary>
        /// Test PostEdgesEdgeIdSoftwareupdate
        /// </summary>
        [Test]
        public void PostEdgesEdgeIdSoftwareupdateTest()
        {
            // TODO: add unit test for the method 'PostEdgesEdgeIdSoftwareupdate'
            string edgeId = null; // TODO: replace null with proper value
            DomainEdgeSoftwareUpdateDto body = null; // TODO: replace null with proper value
            
            var response = instance.PostEdgesEdgeIdSoftwareupdate(edgeId, body);
            Assert.IsInstanceOf<DomainEdgeSoftwareUpdateDto> (response, "response is DomainEdgeSoftwareUpdateDto"); 
        }
        
        /// <summary>
        /// Test DeleteEdgesEdgeIdSoftwareupdate
        /// </summary>
        [Test]
        public void DeleteEdgesEdgeIdSoftwareupdateTest()
        {
            // TODO: add unit test for the method 'DeleteEdgesEdgeIdSoftwareupdate'
            string edgeId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteEdgesEdgeIdSoftwareupdate(edgeId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetEdgesEdgeIdSoftwareversions
        /// </summary>
        [Test]
        public void GetEdgesEdgeIdSoftwareversionsTest()
        {
            // TODO: add unit test for the method 'GetEdgesEdgeIdSoftwareversions'
            string edgeId = null; // TODO: replace null with proper value
            
            var response = instance.GetEdgesEdgeIdSoftwareversions(edgeId);
            Assert.IsInstanceOf<DomainEdgeSoftwareVersionDto> (response, "response is DomainEdgeSoftwareVersionDto"); 
        }
        
        /// <summary>
        /// Test PostEdgesEdgeIdUnpair
        /// </summary>
        [Test]
        public void PostEdgesEdgeIdUnpairTest()
        {
            // TODO: add unit test for the method 'PostEdgesEdgeIdUnpair'
            string edgeId = null; // TODO: replace null with proper value
            
            var response = instance.PostEdgesEdgeIdUnpair(edgeId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetEdgeversionreport
        /// </summary>
        [Test]
        public void GetEdgeversionreportTest()
        {
            // TODO: add unit test for the method 'GetEdgeversionreport'
            
            var response = instance.GetEdgeversionreport();
            Assert.IsInstanceOf<EdgeVersionReport> (response, "response is EdgeVersionReport"); 
        }
        
        /// <summary>
        /// Test GetEndpoints
        /// </summary>
        [Test]
        public void GetEndpointsTest()
        {
            // TODO: add unit test for the method 'GetEndpoints'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            
            var response = instance.GetEndpoints(pageSize, pageNumber, name, sortBy);
            Assert.IsInstanceOf<EndpointEntityListing> (response, "response is EndpointEntityListing"); 
        }
        
        /// <summary>
        /// Test PostEndpoints
        /// </summary>
        [Test]
        public void PostEndpointsTest()
        {
            // TODO: add unit test for the method 'PostEndpoints'
            Endpoint body = null; // TODO: replace null with proper value
            
            var response = instance.PostEndpoints(body);
            Assert.IsInstanceOf<Endpoint> (response, "response is Endpoint"); 
        }
        
        /// <summary>
        /// Test GetEndpointsEndpointId
        /// </summary>
        [Test]
        public void GetEndpointsEndpointIdTest()
        {
            // TODO: add unit test for the method 'GetEndpointsEndpointId'
            string endpointId = null; // TODO: replace null with proper value
            
            var response = instance.GetEndpointsEndpointId(endpointId);
            Assert.IsInstanceOf<Endpoint> (response, "response is Endpoint"); 
        }
        
        /// <summary>
        /// Test PutEndpointsEndpointId
        /// </summary>
        [Test]
        public void PutEndpointsEndpointIdTest()
        {
            // TODO: add unit test for the method 'PutEndpointsEndpointId'
            string endpointId = null; // TODO: replace null with proper value
            Endpoint body = null; // TODO: replace null with proper value
            
            var response = instance.PutEndpointsEndpointId(endpointId, body);
            Assert.IsInstanceOf<Endpoint> (response, "response is Endpoint"); 
        }
        
        /// <summary>
        /// Test DeleteEndpointsEndpointId
        /// </summary>
        [Test]
        public void DeleteEndpointsEndpointIdTest()
        {
            // TODO: add unit test for the method 'DeleteEndpointsEndpointId'
            string endpointId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteEndpointsEndpointId(endpointId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetExtensionpools
        /// </summary>
        [Test]
        public void GetExtensionpoolsTest()
        {
            // TODO: add unit test for the method 'GetExtensionpools'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string number = null; // TODO: replace null with proper value
            
            var response = instance.GetExtensionpools(pageSize, pageNumber, sortBy, number);
            Assert.IsInstanceOf<ExtensionPoolEntityListing> (response, "response is ExtensionPoolEntityListing"); 
        }
        
        /// <summary>
        /// Test PostExtensionpools
        /// </summary>
        [Test]
        public void PostExtensionpoolsTest()
        {
            // TODO: add unit test for the method 'PostExtensionpools'
            ExtensionPool body = null; // TODO: replace null with proper value
            
            var response = instance.PostExtensionpools(body);
            Assert.IsInstanceOf<Extension> (response, "response is Extension"); 
        }
        
        /// <summary>
        /// Test GetExtensionpoolsExtensionpoolId
        /// </summary>
        [Test]
        public void GetExtensionpoolsExtensionpoolIdTest()
        {
            // TODO: add unit test for the method 'GetExtensionpoolsExtensionpoolId'
            string extensionPoolId = null; // TODO: replace null with proper value
            
            var response = instance.GetExtensionpoolsExtensionpoolId(extensionPoolId);
            Assert.IsInstanceOf<ExtensionPool> (response, "response is ExtensionPool"); 
        }
        
        /// <summary>
        /// Test PutExtensionpoolsExtensionpoolId
        /// </summary>
        [Test]
        public void PutExtensionpoolsExtensionpoolIdTest()
        {
            // TODO: add unit test for the method 'PutExtensionpoolsExtensionpoolId'
            string extensionPoolId = null; // TODO: replace null with proper value
            ExtensionPool body = null; // TODO: replace null with proper value
            
            var response = instance.PutExtensionpoolsExtensionpoolId(extensionPoolId, body);
            Assert.IsInstanceOf<ExtensionPool> (response, "response is ExtensionPool"); 
        }
        
        /// <summary>
        /// Test DeleteExtensionpoolsExtensionpoolId
        /// </summary>
        [Test]
        public void DeleteExtensionpoolsExtensionpoolIdTest()
        {
            // TODO: add unit test for the method 'DeleteExtensionpoolsExtensionpoolId'
            string extensionPoolId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteExtensionpoolsExtensionpoolId(extensionPoolId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetExtensions
        /// </summary>
        [Test]
        public void GetExtensionsTest()
        {
            // TODO: add unit test for the method 'GetExtensions'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            string number = null; // TODO: replace null with proper value
            
            var response = instance.GetExtensions(pageSize, pageNumber, sortBy, sortOrder, number);
            Assert.IsInstanceOf<ExtensionEntityListing> (response, "response is ExtensionEntityListing"); 
        }
        
        /// <summary>
        /// Test GetExtensionsExtensionId
        /// </summary>
        [Test]
        public void GetExtensionsExtensionIdTest()
        {
            // TODO: add unit test for the method 'GetExtensionsExtensionId'
            string extensionId = null; // TODO: replace null with proper value
            
            var response = instance.GetExtensionsExtensionId(extensionId);
            Assert.IsInstanceOf<Extension> (response, "response is Extension"); 
        }
        
        /// <summary>
        /// Test PutExtensionsExtensionId
        /// </summary>
        [Test]
        public void PutExtensionsExtensionIdTest()
        {
            // TODO: add unit test for the method 'PutExtensionsExtensionId'
            string extensionId = null; // TODO: replace null with proper value
            Extension body = null; // TODO: replace null with proper value
            
            var response = instance.PutExtensionsExtensionId(extensionId, body);
            Assert.IsInstanceOf<Extension> (response, "response is Extension"); 
        }
        
        /// <summary>
        /// Test GetMediaretentionpolicies
        /// </summary>
        [Test]
        public void GetMediaretentionpoliciesTest()
        {
            // TODO: add unit test for the method 'GetMediaretentionpolicies'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            bool? enabled = null; // TODO: replace null with proper value
            bool? summary = null; // TODO: replace null with proper value
            bool? hasErrors = null; // TODO: replace null with proper value
            
            var response = instance.GetMediaretentionpolicies(pageSize, pageNumber, sortBy, expand, name, enabled, summary, hasErrors);
            Assert.IsInstanceOf<PolicyEntityListing> (response, "response is PolicyEntityListing"); 
        }
        
        /// <summary>
        /// Test PostMediaretentionpolicies
        /// </summary>
        [Test]
        public void PostMediaretentionpoliciesTest()
        {
            // TODO: add unit test for the method 'PostMediaretentionpolicies'
            Policy body = null; // TODO: replace null with proper value
            
            var response = instance.PostMediaretentionpolicies(body);
            Assert.IsInstanceOf<Policy> (response, "response is Policy"); 
        }
        
        /// <summary>
        /// Test DeleteMediaretentionpolicies
        /// </summary>
        [Test]
        public void DeleteMediaretentionpoliciesTest()
        {
            // TODO: add unit test for the method 'DeleteMediaretentionpolicies'
            string ids = null; // TODO: replace null with proper value
            
            var response = instance.DeleteMediaretentionpolicies(ids);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetMediaretentionpoliciesPolicyId
        /// </summary>
        [Test]
        public void GetMediaretentionpoliciesPolicyIdTest()
        {
            // TODO: add unit test for the method 'GetMediaretentionpoliciesPolicyId'
            string policyId = null; // TODO: replace null with proper value
            
            var response = instance.GetMediaretentionpoliciesPolicyId(policyId);
            Assert.IsInstanceOf<Policy> (response, "response is Policy"); 
        }
        
        /// <summary>
        /// Test PutMediaretentionpoliciesPolicyId
        /// </summary>
        [Test]
        public void PutMediaretentionpoliciesPolicyIdTest()
        {
            // TODO: add unit test for the method 'PutMediaretentionpoliciesPolicyId'
            string policyId = null; // TODO: replace null with proper value
            Policy body = null; // TODO: replace null with proper value
            
            var response = instance.PutMediaretentionpoliciesPolicyId(policyId, body);
            Assert.IsInstanceOf<Policy> (response, "response is Policy"); 
        }
        
        /// <summary>
        /// Test DeleteMediaretentionpoliciesPolicyId
        /// </summary>
        [Test]
        public void DeleteMediaretentionpoliciesPolicyIdTest()
        {
            // TODO: add unit test for the method 'DeleteMediaretentionpoliciesPolicyId'
            string policyId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteMediaretentionpoliciesPolicyId(policyId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test PatchMediaretentionpoliciesPolicyId
        /// </summary>
        [Test]
        public void PatchMediaretentionpoliciesPolicyIdTest()
        {
            // TODO: add unit test for the method 'PatchMediaretentionpoliciesPolicyId'
            string policyId = null; // TODO: replace null with proper value
            Policy body = null; // TODO: replace null with proper value
            
            var response = instance.PatchMediaretentionpoliciesPolicyId(policyId, body);
            Assert.IsInstanceOf<Policy> (response, "response is Policy"); 
        }
        
        /// <summary>
        /// Test GetOrganization
        /// </summary>
        [Test]
        public void GetOrganizationTest()
        {
            // TODO: add unit test for the method 'GetOrganization'
            
            var response = instance.GetOrganization();
            Assert.IsInstanceOf<Organization> (response, "response is Organization"); 
        }
        
        /// <summary>
        /// Test PutOrganization
        /// </summary>
        [Test]
        public void PutOrganizationTest()
        {
            // TODO: add unit test for the method 'PutOrganization'
            Organization body = null; // TODO: replace null with proper value
            
            var response = instance.PutOrganization(body);
            Assert.IsInstanceOf<Organization> (response, "response is Organization"); 
        }
        
        /// <summary>
        /// Test PostOrganizations
        /// </summary>
        [Test]
        public void PostOrganizationsTest()
        {
            // TODO: add unit test for the method 'PostOrganizations'
            OrganizationCreate body = null; // TODO: replace null with proper value
            
            var response = instance.PostOrganizations(body);
            Assert.IsInstanceOf<Organization> (response, "response is Organization"); 
        }
        
        /// <summary>
        /// Test GetOrganizationsOrgId
        /// </summary>
        [Test]
        public void GetOrganizationsOrgIdTest()
        {
            // TODO: add unit test for the method 'GetOrganizationsOrgId'
            string orgId = null; // TODO: replace null with proper value
            
            var response = instance.GetOrganizationsOrgId(orgId);
            Assert.IsInstanceOf<Organization> (response, "response is Organization"); 
        }
        
        /// <summary>
        /// Test PutOrganizationsOrgId
        /// </summary>
        [Test]
        public void PutOrganizationsOrgIdTest()
        {
            // TODO: add unit test for the method 'PutOrganizationsOrgId'
            string orgId = null; // TODO: replace null with proper value
            Organization body = null; // TODO: replace null with proper value
            
            var response = instance.PutOrganizationsOrgId(orgId, body);
            Assert.IsInstanceOf<Organization> (response, "response is Organization"); 
        }
        
        /// <summary>
        /// Test DeleteOrganizationsOrgId
        /// </summary>
        [Test]
        public void DeleteOrganizationsOrgIdTest()
        {
            // TODO: add unit test for the method 'DeleteOrganizationsOrgId'
            string orgId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteOrganizationsOrgId(orgId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetRecordingkeys
        /// </summary>
        [Test]
        public void GetRecordingkeysTest()
        {
            // TODO: add unit test for the method 'GetRecordingkeys'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetRecordingkeys(pageSize, pageNumber);
            Assert.IsInstanceOf<EncryptionKeyEntityListing> (response, "response is EncryptionKeyEntityListing"); 
        }
        
        /// <summary>
        /// Test PostRecordingkeys
        /// </summary>
        [Test]
        public void PostRecordingkeysTest()
        {
            // TODO: add unit test for the method 'PostRecordingkeys'
            
            var response = instance.PostRecordingkeys();
            Assert.IsInstanceOf<EncryptionKey> (response, "response is EncryptionKey"); 
        }
        
        /// <summary>
        /// Test GetRecordingkeysRotationschedule
        /// </summary>
        [Test]
        public void GetRecordingkeysRotationscheduleTest()
        {
            // TODO: add unit test for the method 'GetRecordingkeysRotationschedule'
            
            var response = instance.GetRecordingkeysRotationschedule();
            Assert.IsInstanceOf<KeyRotationSchedule> (response, "response is KeyRotationSchedule"); 
        }
        
        /// <summary>
        /// Test PutRecordingkeysRotationschedule
        /// </summary>
        [Test]
        public void PutRecordingkeysRotationscheduleTest()
        {
            // TODO: add unit test for the method 'PutRecordingkeysRotationschedule'
            KeyRotationSchedule body = null; // TODO: replace null with proper value
            
            var response = instance.PutRecordingkeysRotationschedule(body);
            Assert.IsInstanceOf<KeyRotationSchedule> (response, "response is KeyRotationSchedule"); 
        }
        
        /// <summary>
        /// Test GetRetentionpolicies
        /// </summary>
        [Test]
        public void GetRetentionpoliciesTest()
        {
            // TODO: add unit test for the method 'GetRetentionpolicies'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            bool? enabled = null; // TODO: replace null with proper value
            bool? summary = null; // TODO: replace null with proper value
            bool? hasErrors = null; // TODO: replace null with proper value
            
            var response = instance.GetRetentionpolicies(pageSize, pageNumber, sortBy, expand, name, enabled, summary, hasErrors);
            Assert.IsInstanceOf<PolicyEntityListing> (response, "response is PolicyEntityListing"); 
        }
        
        /// <summary>
        /// Test PostRetentionpolicies
        /// </summary>
        [Test]
        public void PostRetentionpoliciesTest()
        {
            // TODO: add unit test for the method 'PostRetentionpolicies'
            Policy body = null; // TODO: replace null with proper value
            
            var response = instance.PostRetentionpolicies(body);
            Assert.IsInstanceOf<Policy> (response, "response is Policy"); 
        }
        
        /// <summary>
        /// Test DeleteRetentionpolicies
        /// </summary>
        [Test]
        public void DeleteRetentionpoliciesTest()
        {
            // TODO: add unit test for the method 'DeleteRetentionpolicies'
            string ids = null; // TODO: replace null with proper value
            
            var response = instance.DeleteRetentionpolicies(ids);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetRetentionpoliciesPolicyId
        /// </summary>
        [Test]
        public void GetRetentionpoliciesPolicyIdTest()
        {
            // TODO: add unit test for the method 'GetRetentionpoliciesPolicyId'
            string policyId = null; // TODO: replace null with proper value
            
            var response = instance.GetRetentionpoliciesPolicyId(policyId);
            Assert.IsInstanceOf<Policy> (response, "response is Policy"); 
        }
        
        /// <summary>
        /// Test PutRetentionpoliciesPolicyId
        /// </summary>
        [Test]
        public void PutRetentionpoliciesPolicyIdTest()
        {
            // TODO: add unit test for the method 'PutRetentionpoliciesPolicyId'
            string policyId = null; // TODO: replace null with proper value
            Policy body = null; // TODO: replace null with proper value
            
            var response = instance.PutRetentionpoliciesPolicyId(policyId, body);
            Assert.IsInstanceOf<Policy> (response, "response is Policy"); 
        }
        
        /// <summary>
        /// Test DeleteRetentionpoliciesPolicyId
        /// </summary>
        [Test]
        public void DeleteRetentionpoliciesPolicyIdTest()
        {
            // TODO: add unit test for the method 'DeleteRetentionpoliciesPolicyId'
            string policyId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteRetentionpoliciesPolicyId(policyId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test PatchRetentionpoliciesPolicyId
        /// </summary>
        [Test]
        public void PatchRetentionpoliciesPolicyIdTest()
        {
            // TODO: add unit test for the method 'PatchRetentionpoliciesPolicyId'
            string policyId = null; // TODO: replace null with proper value
            Policy body = null; // TODO: replace null with proper value
            
            var response = instance.PatchRetentionpoliciesPolicyId(policyId, body);
            Assert.IsInstanceOf<Policy> (response, "response is Policy"); 
        }
        
        /// <summary>
        /// Test GetSchemasEdgesVnext
        /// </summary>
        [Test]
        public void GetSchemasEdgesVnextTest()
        {
            // TODO: add unit test for the method 'GetSchemasEdgesVnext'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetSchemasEdgesVnext(pageSize, pageNumber);
            Assert.IsInstanceOf<SchemaCategoryEntityListing> (response, "response is SchemaCategoryEntityListing"); 
        }
        
        /// <summary>
        /// Test GetSchemasEdgesVnextSchemacategory
        /// </summary>
        [Test]
        public void GetSchemasEdgesVnextSchemacategoryTest()
        {
            // TODO: add unit test for the method 'GetSchemasEdgesVnextSchemacategory'
            string schemaCategory = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetSchemasEdgesVnextSchemacategory(schemaCategory, pageSize, pageNumber);
            Assert.IsInstanceOf<SchemaReferenceEntityListing> (response, "response is SchemaReferenceEntityListing"); 
        }
        
        /// <summary>
        /// Test GetSchemasEdgesVnextSchemacategorySchematype
        /// </summary>
        [Test]
        public void GetSchemasEdgesVnextSchemacategorySchematypeTest()
        {
            // TODO: add unit test for the method 'GetSchemasEdgesVnextSchemacategorySchematype'
            string schemaCategory = null; // TODO: replace null with proper value
            string schemaType = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetSchemasEdgesVnextSchemacategorySchematype(schemaCategory, schemaType, pageSize, pageNumber);
            Assert.IsInstanceOf<SchemaReferenceEntityListing> (response, "response is SchemaReferenceEntityListing"); 
        }
        
        /// <summary>
        /// Test GetSchemasEdgesVnextSchemacategorySchematypeSchemaId
        /// </summary>
        [Test]
        public void GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdTest()
        {
            // TODO: add unit test for the method 'GetSchemasEdgesVnextSchemacategorySchematypeSchemaId'
            string schemaCategory = null; // TODO: replace null with proper value
            string schemaType = null; // TODO: replace null with proper value
            string schemaId = null; // TODO: replace null with proper value
            
            var response = instance.GetSchemasEdgesVnextSchemacategorySchematypeSchemaId(schemaCategory, schemaType, schemaId);
            Assert.IsInstanceOf<Organization> (response, "response is Organization"); 
        }
        
        /// <summary>
        /// Test GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId
        /// </summary>
        [Test]
        public void GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataIdTest()
        {
            // TODO: add unit test for the method 'GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId'
            string schemaCategory = null; // TODO: replace null with proper value
            string schemaType = null; // TODO: replace null with proper value
            string schemaId = null; // TODO: replace null with proper value
            string extension = null; // TODO: replace null with proper value
            string metadataId = null; // TODO: replace null with proper value
            string type = null; // TODO: replace null with proper value
            
            var response = instance.GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId(schemaCategory, schemaType, schemaId, extension, metadataId, type);
            Assert.IsInstanceOf<Organization> (response, "response is Organization"); 
        }
        
        /// <summary>
        /// Test GetSites
        /// </summary>
        [Test]
        public void GetSitesTest()
        {
            // TODO: add unit test for the method 'GetSites'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string locationId = null; // TODO: replace null with proper value
            
            var response = instance.GetSites(pageSize, pageNumber, sortBy, sortOrder, name, locationId);
            Assert.IsInstanceOf<SiteEntityListing> (response, "response is SiteEntityListing"); 
        }
        
        /// <summary>
        /// Test PostSites
        /// </summary>
        [Test]
        public void PostSitesTest()
        {
            // TODO: add unit test for the method 'PostSites'
            Site body = null; // TODO: replace null with proper value
            
            var response = instance.PostSites(body);
            Assert.IsInstanceOf<Site> (response, "response is Site"); 
        }
        
        /// <summary>
        /// Test GetSitesSiteId
        /// </summary>
        [Test]
        public void GetSitesSiteIdTest()
        {
            // TODO: add unit test for the method 'GetSitesSiteId'
            string siteId = null; // TODO: replace null with proper value
            
            var response = instance.GetSitesSiteId(siteId);
            Assert.IsInstanceOf<Site> (response, "response is Site"); 
        }
        
        /// <summary>
        /// Test PutSitesSiteId
        /// </summary>
        [Test]
        public void PutSitesSiteIdTest()
        {
            // TODO: add unit test for the method 'PutSitesSiteId'
            string siteId = null; // TODO: replace null with proper value
            Site body = null; // TODO: replace null with proper value
            
            var response = instance.PutSitesSiteId(siteId, body);
            Assert.IsInstanceOf<Site> (response, "response is Site"); 
        }
        
        /// <summary>
        /// Test DeleteSitesSiteId
        /// </summary>
        [Test]
        public void DeleteSitesSiteIdTest()
        {
            // TODO: add unit test for the method 'DeleteSitesSiteId'
            string siteId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteSitesSiteId(siteId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetSitesSiteIdNumberplans
        /// </summary>
        [Test]
        public void GetSitesSiteIdNumberplansTest()
        {
            // TODO: add unit test for the method 'GetSitesSiteIdNumberplans'
            string siteId = null; // TODO: replace null with proper value
            
            var response = instance.GetSitesSiteIdNumberplans(siteId);
            Assert.IsInstanceOf<List<NumberPlan>> (response, "response is List<NumberPlan>"); 
        }
        
        /// <summary>
        /// Test PutSitesSiteIdNumberplans
        /// </summary>
        [Test]
        public void PutSitesSiteIdNumberplansTest()
        {
            // TODO: add unit test for the method 'PutSitesSiteIdNumberplans'
            string siteId = null; // TODO: replace null with proper value
            List<NumberPlan> body = null; // TODO: replace null with proper value
            
            var response = instance.PutSitesSiteIdNumberplans(siteId, body);
            Assert.IsInstanceOf<List<NumberPlan>> (response, "response is List<NumberPlan>"); 
        }
        
        /// <summary>
        /// Test GetSitesSiteIdNumberplansClassifications
        /// </summary>
        [Test]
        public void GetSitesSiteIdNumberplansClassificationsTest()
        {
            // TODO: add unit test for the method 'GetSitesSiteIdNumberplansClassifications'
            string siteId = null; // TODO: replace null with proper value
            string classification = null; // TODO: replace null with proper value
            
            var response = instance.GetSitesSiteIdNumberplansClassifications(siteId, classification);
            Assert.IsInstanceOf<List<string>> (response, "response is List<string>"); 
        }
        
        /// <summary>
        /// Test GetSitesSiteIdNumberplansNumberplanId
        /// </summary>
        [Test]
        public void GetSitesSiteIdNumberplansNumberplanIdTest()
        {
            // TODO: add unit test for the method 'GetSitesSiteIdNumberplansNumberplanId'
            string siteId = null; // TODO: replace null with proper value
            string numberPlanId = null; // TODO: replace null with proper value
            
            var response = instance.GetSitesSiteIdNumberplansNumberplanId(siteId, numberPlanId);
            Assert.IsInstanceOf<NumberPlan> (response, "response is NumberPlan"); 
        }
        
        /// <summary>
        /// Test PostSitesSiteIdRebalance
        /// </summary>
        [Test]
        public void PostSitesSiteIdRebalanceTest()
        {
            // TODO: add unit test for the method 'PostSitesSiteIdRebalance'
            string siteId = null; // TODO: replace null with proper value
            
            instance.PostSitesSiteIdRebalance(siteId);
             
        }
        
    }

}
