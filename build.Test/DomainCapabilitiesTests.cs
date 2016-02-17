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
    public class DomainCapabilitiesTests
    {
        private DomainCapabilities instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DomainCapabilities();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DomainCapabilities
        /// </summary>
        [Test]
        public void DomainCapabilitiesInstanceTest()
        {
            Assert.IsInstanceOf<DomainCapabilities> (instance, "instance is a DomainCapabilities");
        }

        
        /// <summary>
        /// Test the property 'Enabled' 
        /// </summary>
        [Test]
        public void EnabledTest()
        {
            // TODO: unit test for the property 'Enabled' 
        }
        
        /// <summary>
        /// Test the property 'Dhcp' 
        /// </summary>
        [Test]
        public void DhcpTest()
        {
            // TODO: unit test for the property 'Dhcp' 
        }
        
        /// <summary>
        /// Test the property 'Metric' 
        /// </summary>
        [Test]
        public void MetricTest()
        {
            // TODO: unit test for the property 'Metric' 
        }
        

    }

}
