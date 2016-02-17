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
    public class DomainPhysicalInterfaceTests
    {
        private DomainPhysicalInterface instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DomainPhysicalInterface();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DomainPhysicalInterface
        /// </summary>
        [Test]
        public void DomainPhysicalInterfaceInstanceTest()
        {
            Assert.IsInstanceOf<DomainPhysicalInterface> (instance, "instance is a DomainPhysicalInterface");
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
        /// Test the property 'EdgeUri' 
        /// </summary>
        [Test]
        public void EdgeUriTest()
        {
            // TODO: unit test for the property 'EdgeUri' 
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
        /// Test the property 'HardwareAddress' 
        /// </summary>
        [Test]
        public void HardwareAddressTest()
        {
            // TODO: unit test for the property 'HardwareAddress' 
        }
        
        /// <summary>
        /// Test the property 'PortLabel' 
        /// </summary>
        [Test]
        public void PortLabelTest()
        {
            // TODO: unit test for the property 'PortLabel' 
        }
        
        /// <summary>
        /// Test the property 'PhysicalCapabilities' 
        /// </summary>
        [Test]
        public void PhysicalCapabilitiesTest()
        {
            // TODO: unit test for the property 'PhysicalCapabilities' 
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
