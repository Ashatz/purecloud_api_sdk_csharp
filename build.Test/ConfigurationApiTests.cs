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
        /// Test GetDidpool
        /// </summary>
        [Test]
        public void GetDidpoolTest()
        {
            // TODO: add unit test for the method 'GetDidpool'
            string didPoolId = null; // TODO: replace null with proper value
            
            var response = instance.GetDidpool(didPoolId);
            Assert.IsInstanceOf<DIDPool> (response, "response is DIDPool"); 
        }
        
        /// <summary>
        /// Test PutDidpool
        /// </summary>
        [Test]
        public void PutDidpoolTest()
        {
            // TODO: add unit test for the method 'PutDidpool'
            string didPoolId = null; // TODO: replace null with proper value
            DIDPool body = null; // TODO: replace null with proper value
            
            var response = instance.PutDidpool(didPoolId, body);
            Assert.IsInstanceOf<DIDPool> (response, "response is DIDPool"); 
        }
        
        /// <summary>
        /// Test DeleteDidpool
        /// </summary>
        [Test]
        public void DeleteDidpoolTest()
        {
            // TODO: add unit test for the method 'DeleteDidpool'
            string didPoolId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteDidpool(didPoolId);
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
        /// Test GetDid
        /// </summary>
        [Test]
        public void GetDidTest()
        {
            // TODO: add unit test for the method 'GetDid'
            string didId = null; // TODO: replace null with proper value
            
            var response = instance.GetDid(didId);
            Assert.IsInstanceOf<DID> (response, "response is DID"); 
        }
        
        /// <summary>
        /// Test PutDid
        /// </summary>
        [Test]
        public void PutDidTest()
        {
            // TODO: add unit test for the method 'PutDid'
            string didId = null; // TODO: replace null with proper value
            DID body = null; // TODO: replace null with proper value
            
            var response = instance.PutDid(didId, body);
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
        /// Test GetEdgesCertificateauthoritie
        /// </summary>
        [Test]
        public void GetEdgesCertificateauthoritieTest()
        {
            // TODO: add unit test for the method 'GetEdgesCertificateauthoritie'
            string certificateId = null; // TODO: replace null with proper value
            
            var response = instance.GetEdgesCertificateauthoritie(certificateId);
            Assert.IsInstanceOf<DomainCertificateAuthority> (response, "response is DomainCertificateAuthority"); 
        }
        
        /// <summary>
        /// Test PutEdgesCertificateauthoritie
        /// </summary>
        [Test]
        public void PutEdgesCertificateauthoritieTest()
        {
            // TODO: add unit test for the method 'PutEdgesCertificateauthoritie'
            string certificateId = null; // TODO: replace null with proper value
            DomainCertificateAuthority body = null; // TODO: replace null with proper value
            
            var response = instance.PutEdgesCertificateauthoritie(certificateId, body);
            Assert.IsInstanceOf<DomainCertificateAuthority> (response, "response is DomainCertificateAuthority"); 
        }
        
        /// <summary>
        /// Test DeleteEdgesCertificateauthoritie
        /// </summary>
        [Test]
        public void DeleteEdgesCertificateauthoritieTest()
        {
            // TODO: add unit test for the method 'DeleteEdgesCertificateauthoritie'
            string certificateId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteEdgesCertificateauthoritie(certificateId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetEdge
        /// </summary>
        [Test]
        public void GetEdgeTest()
        {
            // TODO: add unit test for the method 'GetEdge'
            string edgeId = null; // TODO: replace null with proper value
            
            var response = instance.GetEdge(edgeId);
            Assert.IsInstanceOf<Edge> (response, "response is Edge"); 
        }
        
        /// <summary>
        /// Test PutEdge
        /// </summary>
        [Test]
        public void PutEdgeTest()
        {
            // TODO: add unit test for the method 'PutEdge'
            string edgeId = null; // TODO: replace null with proper value
            Edge body = null; // TODO: replace null with proper value
            
            var response = instance.PutEdge(edgeId, body);
            Assert.IsInstanceOf<Edge> (response, "response is Edge"); 
        }
        
        /// <summary>
        /// Test DeleteEdge
        /// </summary>
        [Test]
        public void DeleteEdgeTest()
        {
            // TODO: add unit test for the method 'DeleteEdge'
            string edgeId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteEdge(edgeId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetEdgeLines
        /// </summary>
        [Test]
        public void GetEdgeLinesTest()
        {
            // TODO: add unit test for the method 'GetEdgeLines'
            string edgeId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetEdgeLines(edgeId, pageSize, pageNumber);
            Assert.IsInstanceOf<EdgeLineEntityListing> (response, "response is EdgeLineEntityListing"); 
        }
        
        /// <summary>
        /// Test GetEdgeLine
        /// </summary>
        [Test]
        public void GetEdgeLineTest()
        {
            // TODO: add unit test for the method 'GetEdgeLine'
            string edgeId = null; // TODO: replace null with proper value
            string lineId = null; // TODO: replace null with proper value
            
            var response = instance.GetEdgeLine(edgeId, lineId);
            Assert.IsInstanceOf<EdgeLine> (response, "response is EdgeLine"); 
        }
        
        /// <summary>
        /// Test PutEdgeLine
        /// </summary>
        [Test]
        public void PutEdgeLineTest()
        {
            // TODO: add unit test for the method 'PutEdgeLine'
            string edgeId = null; // TODO: replace null with proper value
            string lineId = null; // TODO: replace null with proper value
            EdgeLine body = null; // TODO: replace null with proper value
            
            var response = instance.PutEdgeLine(edgeId, lineId, body);
            Assert.IsInstanceOf<EdgeLine> (response, "response is EdgeLine"); 
        }
        
        /// <summary>
        /// Test GetEdgeLogicalinterfaces
        /// </summary>
        [Test]
        public void GetEdgeLogicalinterfacesTest()
        {
            // TODO: add unit test for the method 'GetEdgeLogicalinterfaces'
            string edgeId = null; // TODO: replace null with proper value
            
            var response = instance.GetEdgeLogicalinterfaces(edgeId);
            Assert.IsInstanceOf<LogicalInterfaceEntityListing> (response, "response is LogicalInterfaceEntityListing"); 
        }
        
        /// <summary>
        /// Test PostEdgeLogicalinterfaces
        /// </summary>
        [Test]
        public void PostEdgeLogicalinterfacesTest()
        {
            // TODO: add unit test for the method 'PostEdgeLogicalinterfaces'
            string edgeId = null; // TODO: replace null with proper value
            DomainLogicalInterface body = null; // TODO: replace null with proper value
            
            var response = instance.PostEdgeLogicalinterfaces(edgeId, body);
            Assert.IsInstanceOf<DomainLogicalInterface> (response, "response is DomainLogicalInterface"); 
        }
        
        /// <summary>
        /// Test GetEdgeLogicalinterface
        /// </summary>
        [Test]
        public void GetEdgeLogicalinterfaceTest()
        {
            // TODO: add unit test for the method 'GetEdgeLogicalinterface'
            string edgeId = null; // TODO: replace null with proper value
            string interfaceId = null; // TODO: replace null with proper value
            
            var response = instance.GetEdgeLogicalinterface(edgeId, interfaceId);
            Assert.IsInstanceOf<DomainLogicalInterface> (response, "response is DomainLogicalInterface"); 
        }
        
        /// <summary>
        /// Test PutEdgeLogicalinterface
        /// </summary>
        [Test]
        public void PutEdgeLogicalinterfaceTest()
        {
            // TODO: add unit test for the method 'PutEdgeLogicalinterface'
            string edgeId = null; // TODO: replace null with proper value
            string interfaceId = null; // TODO: replace null with proper value
            DomainLogicalInterface body = null; // TODO: replace null with proper value
            
            var response = instance.PutEdgeLogicalinterface(edgeId, interfaceId, body);
            Assert.IsInstanceOf<DomainLogicalInterface> (response, "response is DomainLogicalInterface"); 
        }
        
        /// <summary>
        /// Test DeleteEdgeLogicalinterface
        /// </summary>
        [Test]
        public void DeleteEdgeLogicalinterfaceTest()
        {
            // TODO: add unit test for the method 'DeleteEdgeLogicalinterface'
            string edgeId = null; // TODO: replace null with proper value
            string interfaceId = null; // TODO: replace null with proper value
            
            instance.DeleteEdgeLogicalinterface(edgeId, interfaceId);
             
        }
        
        /// <summary>
        /// Test GetEdgePhysicalinterfaces
        /// </summary>
        [Test]
        public void GetEdgePhysicalinterfacesTest()
        {
            // TODO: add unit test for the method 'GetEdgePhysicalinterfaces'
            string edgeId = null; // TODO: replace null with proper value
            
            var response = instance.GetEdgePhysicalinterfaces(edgeId);
            Assert.IsInstanceOf<PhysicalInterfaceEntityListing> (response, "response is PhysicalInterfaceEntityListing"); 
        }
        
        /// <summary>
        /// Test GetEdgePhysicalinterface
        /// </summary>
        [Test]
        public void GetEdgePhysicalinterfaceTest()
        {
            // TODO: add unit test for the method 'GetEdgePhysicalinterface'
            string edgeId = null; // TODO: replace null with proper value
            string interfaceId = null; // TODO: replace null with proper value
            
            var response = instance.GetEdgePhysicalinterface(edgeId, interfaceId);
            Assert.IsInstanceOf<DomainPhysicalInterface> (response, "response is DomainPhysicalInterface"); 
        }
        
        /// <summary>
        /// Test PostEdgeReboot
        /// </summary>
        [Test]
        public void PostEdgeRebootTest()
        {
            // TODO: add unit test for the method 'PostEdgeReboot'
            string edgeId = null; // TODO: replace null with proper value
            
            var response = instance.PostEdgeReboot(edgeId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetEdgeSoftwareupdate
        /// </summary>
        [Test]
        public void GetEdgeSoftwareupdateTest()
        {
            // TODO: add unit test for the method 'GetEdgeSoftwareupdate'
            string edgeId = null; // TODO: replace null with proper value
            
            var response = instance.GetEdgeSoftwareupdate(edgeId);
            Assert.IsInstanceOf<DomainEdgeSoftwareUpdateDto> (response, "response is DomainEdgeSoftwareUpdateDto"); 
        }
        
        /// <summary>
        /// Test PostEdgeSoftwareupdate
        /// </summary>
        [Test]
        public void PostEdgeSoftwareupdateTest()
        {
            // TODO: add unit test for the method 'PostEdgeSoftwareupdate'
            string edgeId = null; // TODO: replace null with proper value
            DomainEdgeSoftwareUpdateDto body = null; // TODO: replace null with proper value
            
            instance.PostEdgeSoftwareupdate(edgeId, body);
             
        }
        
        /// <summary>
        /// Test DeleteEdgeSoftwareupdate
        /// </summary>
        [Test]
        public void DeleteEdgeSoftwareupdateTest()
        {
            // TODO: add unit test for the method 'DeleteEdgeSoftwareupdate'
            string edgeId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteEdgeSoftwareupdate(edgeId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetEdgeSoftwareversions
        /// </summary>
        [Test]
        public void GetEdgeSoftwareversionsTest()
        {
            // TODO: add unit test for the method 'GetEdgeSoftwareversions'
            string edgeId = null; // TODO: replace null with proper value
            
            var response = instance.GetEdgeSoftwareversions(edgeId);
            Assert.IsInstanceOf<DomainEdgeSoftwareVersionDto> (response, "response is DomainEdgeSoftwareVersionDto"); 
        }
        
        /// <summary>
        /// Test PostEdgeUnpair
        /// </summary>
        [Test]
        public void PostEdgeUnpairTest()
        {
            // TODO: add unit test for the method 'PostEdgeUnpair'
            string edgeId = null; // TODO: replace null with proper value
            
            var response = instance.PostEdgeUnpair(edgeId);
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
        /// Test GetEndpoint
        /// </summary>
        [Test]
        public void GetEndpointTest()
        {
            // TODO: add unit test for the method 'GetEndpoint'
            string endpointId = null; // TODO: replace null with proper value
            
            var response = instance.GetEndpoint(endpointId);
            Assert.IsInstanceOf<Endpoint> (response, "response is Endpoint"); 
        }
        
        /// <summary>
        /// Test PutEndpoint
        /// </summary>
        [Test]
        public void PutEndpointTest()
        {
            // TODO: add unit test for the method 'PutEndpoint'
            string endpointId = null; // TODO: replace null with proper value
            Endpoint body = null; // TODO: replace null with proper value
            
            var response = instance.PutEndpoint(endpointId, body);
            Assert.IsInstanceOf<Endpoint> (response, "response is Endpoint"); 
        }
        
        /// <summary>
        /// Test DeleteEndpoint
        /// </summary>
        [Test]
        public void DeleteEndpointTest()
        {
            // TODO: add unit test for the method 'DeleteEndpoint'
            string endpointId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteEndpoint(endpointId);
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
        /// Test GetExtensionpool
        /// </summary>
        [Test]
        public void GetExtensionpoolTest()
        {
            // TODO: add unit test for the method 'GetExtensionpool'
            string extensionPoolId = null; // TODO: replace null with proper value
            
            var response = instance.GetExtensionpool(extensionPoolId);
            Assert.IsInstanceOf<ExtensionPool> (response, "response is ExtensionPool"); 
        }
        
        /// <summary>
        /// Test PutExtensionpool
        /// </summary>
        [Test]
        public void PutExtensionpoolTest()
        {
            // TODO: add unit test for the method 'PutExtensionpool'
            string extensionPoolId = null; // TODO: replace null with proper value
            ExtensionPool body = null; // TODO: replace null with proper value
            
            var response = instance.PutExtensionpool(extensionPoolId, body);
            Assert.IsInstanceOf<ExtensionPool> (response, "response is ExtensionPool"); 
        }
        
        /// <summary>
        /// Test DeleteExtensionpool
        /// </summary>
        [Test]
        public void DeleteExtensionpoolTest()
        {
            // TODO: add unit test for the method 'DeleteExtensionpool'
            string extensionPoolId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteExtensionpool(extensionPoolId);
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
        /// Test GetExtension
        /// </summary>
        [Test]
        public void GetExtensionTest()
        {
            // TODO: add unit test for the method 'GetExtension'
            string extensionId = null; // TODO: replace null with proper value
            
            var response = instance.GetExtension(extensionId);
            Assert.IsInstanceOf<Extension> (response, "response is Extension"); 
        }
        
        /// <summary>
        /// Test PutExtension
        /// </summary>
        [Test]
        public void PutExtensionTest()
        {
            // TODO: add unit test for the method 'PutExtension'
            string extensionId = null; // TODO: replace null with proper value
            Extension body = null; // TODO: replace null with proper value
            
            var response = instance.PutExtension(extensionId, body);
            Assert.IsInstanceOf<Extension> (response, "response is Extension"); 
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
        /// Test GetOrganization_0
        /// </summary>
        [Test]
        public void GetOrganization_0Test()
        {
            // TODO: add unit test for the method 'GetOrganization_0'
            string orgId = null; // TODO: replace null with proper value
            
            var response = instance.GetOrganization_0(orgId);
            Assert.IsInstanceOf<Organization> (response, "response is Organization"); 
        }
        
        /// <summary>
        /// Test PutOrganization_0
        /// </summary>
        [Test]
        public void PutOrganization_0Test()
        {
            // TODO: add unit test for the method 'PutOrganization_0'
            string orgId = null; // TODO: replace null with proper value
            Organization body = null; // TODO: replace null with proper value
            
            var response = instance.PutOrganization_0(orgId, body);
            Assert.IsInstanceOf<Organization> (response, "response is Organization"); 
        }
        
        /// <summary>
        /// Test DeleteOrganization
        /// </summary>
        [Test]
        public void DeleteOrganizationTest()
        {
            // TODO: add unit test for the method 'DeleteOrganization'
            string orgId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteOrganization(orgId);
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
        /// Test GetRetentionpolicie
        /// </summary>
        [Test]
        public void GetRetentionpolicieTest()
        {
            // TODO: add unit test for the method 'GetRetentionpolicie'
            string policyId = null; // TODO: replace null with proper value
            
            var response = instance.GetRetentionpolicie(policyId);
            Assert.IsInstanceOf<Policy> (response, "response is Policy"); 
        }
        
        /// <summary>
        /// Test PutRetentionpolicie
        /// </summary>
        [Test]
        public void PutRetentionpolicieTest()
        {
            // TODO: add unit test for the method 'PutRetentionpolicie'
            string policyId = null; // TODO: replace null with proper value
            Policy body = null; // TODO: replace null with proper value
            
            var response = instance.PutRetentionpolicie(policyId, body);
            Assert.IsInstanceOf<Policy> (response, "response is Policy"); 
        }
        
        /// <summary>
        /// Test DeleteRetentionpolicie
        /// </summary>
        [Test]
        public void DeleteRetentionpolicieTest()
        {
            // TODO: add unit test for the method 'DeleteRetentionpolicie'
            string policyId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteRetentionpolicie(policyId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test PatchRetentionpolicie
        /// </summary>
        [Test]
        public void PatchRetentionpolicieTest()
        {
            // TODO: add unit test for the method 'PatchRetentionpolicie'
            string policyId = null; // TODO: replace null with proper value
            Policy body = null; // TODO: replace null with proper value
            
            var response = instance.PatchRetentionpolicie(policyId, body);
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
        /// Test GetSchemasEdgesVnext_0
        /// </summary>
        [Test]
        public void GetSchemasEdgesVnext_0Test()
        {
            // TODO: add unit test for the method 'GetSchemasEdgesVnext_0'
            string schemaCategory = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetSchemasEdgesVnext_0(schemaCategory, pageSize, pageNumber);
            Assert.IsInstanceOf<SchemaReferenceEntityListing> (response, "response is SchemaReferenceEntityListing"); 
        }
        
        /// <summary>
        /// Test GetSchemasEdgesVnext_1
        /// </summary>
        [Test]
        public void GetSchemasEdgesVnext_1Test()
        {
            // TODO: add unit test for the method 'GetSchemasEdgesVnext_1'
            string schemaCategory = null; // TODO: replace null with proper value
            string schemaType = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetSchemasEdgesVnext_1(schemaCategory, schemaType, pageSize, pageNumber);
            Assert.IsInstanceOf<SchemaReferenceEntityListing> (response, "response is SchemaReferenceEntityListing"); 
        }
        
        /// <summary>
        /// Test GetSchemasEdgesVnext_2
        /// </summary>
        [Test]
        public void GetSchemasEdgesVnext_2Test()
        {
            // TODO: add unit test for the method 'GetSchemasEdgesVnext_2'
            string schemaCategory = null; // TODO: replace null with proper value
            string schemaType = null; // TODO: replace null with proper value
            string schemaId = null; // TODO: replace null with proper value
            
            var response = instance.GetSchemasEdgesVnext_2(schemaCategory, schemaType, schemaId);
            Assert.IsInstanceOf<Organization> (response, "response is Organization"); 
        }
        
        /// <summary>
        /// Test GetSchemasEdgesVnext_3
        /// </summary>
        [Test]
        public void GetSchemasEdgesVnext_3Test()
        {
            // TODO: add unit test for the method 'GetSchemasEdgesVnext_3'
            string schemaCategory = null; // TODO: replace null with proper value
            string schemaType = null; // TODO: replace null with proper value
            string schemaId = null; // TODO: replace null with proper value
            string extension = null; // TODO: replace null with proper value
            string metadataId = null; // TODO: replace null with proper value
            string type = null; // TODO: replace null with proper value
            
            var response = instance.GetSchemasEdgesVnext_3(schemaCategory, schemaType, schemaId, extension, metadataId, type);
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
        /// Test GetSite
        /// </summary>
        [Test]
        public void GetSiteTest()
        {
            // TODO: add unit test for the method 'GetSite'
            string siteId = null; // TODO: replace null with proper value
            
            var response = instance.GetSite(siteId);
            Assert.IsInstanceOf<Site> (response, "response is Site"); 
        }
        
        /// <summary>
        /// Test PutSite
        /// </summary>
        [Test]
        public void PutSiteTest()
        {
            // TODO: add unit test for the method 'PutSite'
            string siteId = null; // TODO: replace null with proper value
            Site body = null; // TODO: replace null with proper value
            
            var response = instance.PutSite(siteId, body);
            Assert.IsInstanceOf<Site> (response, "response is Site"); 
        }
        
        /// <summary>
        /// Test DeleteSite
        /// </summary>
        [Test]
        public void DeleteSiteTest()
        {
            // TODO: add unit test for the method 'DeleteSite'
            string siteId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteSite(siteId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetSiteNumberplans
        /// </summary>
        [Test]
        public void GetSiteNumberplansTest()
        {
            // TODO: add unit test for the method 'GetSiteNumberplans'
            string siteId = null; // TODO: replace null with proper value
            
            var response = instance.GetSiteNumberplans(siteId);
            Assert.IsInstanceOf<List<NumberPlan>> (response, "response is List<NumberPlan>"); 
        }
        
        /// <summary>
        /// Test PutSiteNumberplans
        /// </summary>
        [Test]
        public void PutSiteNumberplansTest()
        {
            // TODO: add unit test for the method 'PutSiteNumberplans'
            string siteId = null; // TODO: replace null with proper value
            List<NumberPlan> body = null; // TODO: replace null with proper value
            
            var response = instance.PutSiteNumberplans(siteId, body);
            Assert.IsInstanceOf<List<NumberPlan>> (response, "response is List<NumberPlan>"); 
        }
        
        /// <summary>
        /// Test GetSiteNumberplansClassifications
        /// </summary>
        [Test]
        public void GetSiteNumberplansClassificationsTest()
        {
            // TODO: add unit test for the method 'GetSiteNumberplansClassifications'
            string siteId = null; // TODO: replace null with proper value
            string classification = null; // TODO: replace null with proper value
            
            var response = instance.GetSiteNumberplansClassifications(siteId, classification);
            Assert.IsInstanceOf<List<string>> (response, "response is List<string>"); 
        }
        
        /// <summary>
        /// Test GetSiteNumberplan
        /// </summary>
        [Test]
        public void GetSiteNumberplanTest()
        {
            // TODO: add unit test for the method 'GetSiteNumberplan'
            string siteId = null; // TODO: replace null with proper value
            string numberPlanId = null; // TODO: replace null with proper value
            
            var response = instance.GetSiteNumberplan(siteId, numberPlanId);
            Assert.IsInstanceOf<NumberPlan> (response, "response is NumberPlan"); 
        }
        
        /// <summary>
        /// Test PostSiteRebalance
        /// </summary>
        [Test]
        public void PostSiteRebalanceTest()
        {
            // TODO: add unit test for the method 'PostSiteRebalance'
            string siteId = null; // TODO: replace null with proper value
            
            instance.PostSiteRebalance(siteId);
             
        }
        
    }

}
