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
    public class DomainPhysicalCapabilitiesTests
    {
        private DomainPhysicalCapabilities instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DomainPhysicalCapabilities();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DomainPhysicalCapabilities
        /// </summary>
        [Test]
        public void DomainPhysicalCapabilitiesInstanceTest()
        {
            Assert.IsInstanceOf<DomainPhysicalCapabilities> (instance, "instance is a DomainPhysicalCapabilities");
        }

        
        /// <summary>
        /// Test the property 'Vlan' 
        /// </summary>
        [Test]
        public void VlanTest()
        {
            // TODO: unit test for the property 'Vlan' 
        }
        
        /// <summary>
        /// Test the property 'Team' 
        /// </summary>
        [Test]
        public void TeamTest()
        {
            // TODO: unit test for the property 'Team' 
        }
        

    }

}
