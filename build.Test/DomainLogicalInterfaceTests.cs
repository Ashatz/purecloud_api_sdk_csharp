using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Model;
using ININ.PureCloudApi.Client;
using System.Reflection;

namespace ININ.PureCloudApi.Test
{
    [TestFixture]
    public class DomainLogicalInterfaceTests
    {
        private DomainLogicalInterface instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DomainLogicalInterface();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DomainLogicalInterface
        /// </summary>
        [Test]
        public void DomainLogicalInterfaceInstanceTest()
        {
            Assert.IsInstanceOf<DomainLogicalInterface> (instance, "instance is a DomainLogicalInterface");
        }

        
        /// <summary>
        /// Test the property 'Id' 
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id' 
        }
        
        /// <summary>
        /// Test the property 'Name' 
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name' 
        }
        
        /// <summary>
        /// Test the property 'Description' 
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO: unit test for the property 'Description' 
        }
        
        /// <summary>
        /// Test the property 'Version' 
        /// </summary>
        [Test]
        public void VersionTest()
        {
            // TODO: unit test for the property 'Version' 
        }
        
        /// <summary>
        /// Test the property 'DateCreated' 
        /// </summary>
        [Test]
        public void DateCreatedTest()
        {
            // TODO: unit test for the property 'DateCreated' 
        }
        
        /// <summary>
        /// Test the property 'DateModified' 
        /// </summary>
        [Test]
        public void DateModifiedTest()
        {
            // TODO: unit test for the property 'DateModified' 
        }
        
        /// <summary>
        /// Test the property 'ModifiedBy' 
        /// </summary>
        [Test]
        public void ModifiedByTest()
        {
            // TODO: unit test for the property 'ModifiedBy' 
        }
        
        /// <summary>
        /// Test the property 'CreatedBy' 
        /// </summary>
        [Test]
        public void CreatedByTest()
        {
            // TODO: unit test for the property 'CreatedBy' 
        }
        
        /// <summary>
        /// Test the property 'State' 
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO: unit test for the property 'State' 
        }
        
        /// <summary>
        /// Test the property 'ModifiedByApp' 
        /// </summary>
        [Test]
        public void ModifiedByAppTest()
        {
            // TODO: unit test for the property 'ModifiedByApp' 
        }
        
        /// <summary>
        /// Test the property 'CreatedByApp' 
        /// </summary>
        [Test]
        public void CreatedByAppTest()
        {
            // TODO: unit test for the property 'CreatedByApp' 
        }
        
        /// <summary>
        /// Test the property 'EdgeUri' 
        /// </summary>
        [Test]
        public void EdgeUriTest()
        {
            // TODO: unit test for the property 'EdgeUri' 
        }
        
        /// <summary>
        /// Test the property 'EdgeAssignedId' 
        /// </summary>
        [Test]
        public void EdgeAssignedIdTest()
        {
            // TODO: unit test for the property 'EdgeAssignedId' 
        }
        
        /// <summary>
        /// Test the property 'FriendlyName' 
        /// </summary>
        [Test]
        public void FriendlyNameTest()
        {
            // TODO: unit test for the property 'FriendlyName' 
        }
        
        /// <summary>
        /// Test the property 'VlanTagId' 
        /// </summary>
        [Test]
        public void VlanTagIdTest()
        {
            // TODO: unit test for the property 'VlanTagId' 
        }
        
        /// <summary>
        /// Test the property 'HardwareAddress' 
        /// </summary>
        [Test]
        public void HardwareAddressTest()
        {
            // TODO: unit test for the property 'HardwareAddress' 
        }
        
        /// <summary>
        /// Test the property 'PhysicalAdapterId' 
        /// </summary>
        [Test]
        public void PhysicalAdapterIdTest()
        {
            // TODO: unit test for the property 'PhysicalAdapterId' 
        }
        
        /// <summary>
        /// Test the property 'IpAddress' 
        /// </summary>
        [Test]
        public void IpAddressTest()
        {
            // TODO: unit test for the property 'IpAddress' 
        }
        
        /// <summary>
        /// Test the property 'Gateway' 
        /// </summary>
        [Test]
        public void GatewayTest()
        {
            // TODO: unit test for the property 'Gateway' 
        }
        
        /// <summary>
        /// Test the property 'PrimaryDns' 
        /// </summary>
        [Test]
        public void PrimaryDnsTest()
        {
            // TODO: unit test for the property 'PrimaryDns' 
        }
        
        /// <summary>
        /// Test the property 'SecondaryDns' 
        /// </summary>
        [Test]
        public void SecondaryDnsTest()
        {
            // TODO: unit test for the property 'SecondaryDns' 
        }
        
        /// <summary>
        /// Test the property 'IfStatus' 
        /// </summary>
        [Test]
        public void IfStatusTest()
        {
            // TODO: unit test for the property 'IfStatus' 
        }
        
        /// <summary>
        /// Test the property 'Routes' 
        /// </summary>
        [Test]
        public void RoutesTest()
        {
            // TODO: unit test for the property 'Routes' 
        }
        
        /// <summary>
        /// Test the property 'Addresses' 
        /// </summary>
        [Test]
        public void AddressesTest()
        {
            // TODO: unit test for the property 'Addresses' 
        }
        
        /// <summary>
        /// Test the property 'Ipv4Capabilities' 
        /// </summary>
        [Test]
        public void Ipv4CapabilitiesTest()
        {
            // TODO: unit test for the property 'Ipv4Capabilities' 
        }
        
        /// <summary>
        /// Test the property 'Ipv6Capabilities' 
        /// </summary>
        [Test]
        public void Ipv6CapabilitiesTest()
        {
            // TODO: unit test for the property 'Ipv6Capabilities' 
        }
        
        /// <summary>
        /// Test the property 'CurrentState' 
        /// </summary>
        [Test]
        public void CurrentStateTest()
        {
            // TODO: unit test for the property 'CurrentState' 
        }
        
        /// <summary>
        /// Test the property 'LastModifiedUserId' 
        /// </summary>
        [Test]
        public void LastModifiedUserIdTest()
        {
            // TODO: unit test for the property 'LastModifiedUserId' 
        }
        
        /// <summary>
        /// Test the property 'LastModifiedCorrelationId' 
        /// </summary>
        [Test]
        public void LastModifiedCorrelationIdTest()
        {
            // TODO: unit test for the property 'LastModifiedCorrelationId' 
        }
        
        /// <summary>
        /// Test the property 'CommandResponses' 
        /// </summary>
        [Test]
        public void CommandResponsesTest()
        {
            // TODO: unit test for the property 'CommandResponses' 
        }
        
        /// <summary>
        /// Test the property 'InheritPhoneTrunkBases' 
        /// </summary>
        [Test]
        public void InheritPhoneTrunkBasesTest()
        {
            // TODO: unit test for the property 'InheritPhoneTrunkBases' 
        }
        
        /// <summary>
        /// Test the property 'UseForInternalEdgeCommunication' 
        /// </summary>
        [Test]
        public void UseForInternalEdgeCommunicationTest()
        {
            // TODO: unit test for the property 'UseForInternalEdgeCommunication' 
        }
        
        /// <summary>
        /// Test the property 'ExternalTrunkBaseAssignments' 
        /// </summary>
        [Test]
        public void ExternalTrunkBaseAssignmentsTest()
        {
            // TODO: unit test for the property 'ExternalTrunkBaseAssignments' 
        }
        
        /// <summary>
        /// Test the property 'PhoneTrunkBaseAssignments' 
        /// </summary>
        [Test]
        public void PhoneTrunkBaseAssignmentsTest()
        {
            // TODO: unit test for the property 'PhoneTrunkBaseAssignments' 
        }
        
        /// <summary>
        /// Test the property 'SelfUri' 
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri' 
        }
        

    }

}
