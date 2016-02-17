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
    public class DomainNetworkRouteTests
    {
        private DomainNetworkRoute instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DomainNetworkRoute();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DomainNetworkRoute
        /// </summary>
        [Test]
        public void DomainNetworkRouteInstanceTest()
        {
            Assert.IsInstanceOf<DomainNetworkRoute> (instance, "instance is a DomainNetworkRoute");
        }

        
        /// <summary>
        /// Test the property 'Prefix' 
        /// </summary>
        [Test]
        public void PrefixTest()
        {
            // TODO: unit test for the property 'Prefix' 
        }
        
        /// <summary>
        /// Test the property 'Nexthop' 
        /// </summary>
        [Test]
        public void NexthopTest()
        {
            // TODO: unit test for the property 'Nexthop' 
        }
        
        /// <summary>
        /// Test the property 'Persistent' 
        /// </summary>
        [Test]
        public void PersistentTest()
        {
            // TODO: unit test for the property 'Persistent' 
        }
        
        /// <summary>
        /// Test the property 'Metric' 
        /// </summary>
        [Test]
        public void MetricTest()
        {
            // TODO: unit test for the property 'Metric' 
        }
        
        /// <summary>
        /// Test the property 'Family' 
        /// </summary>
        [Test]
        public void FamilyTest()
        {
            // TODO: unit test for the property 'Family' 
        }
        

    }

}
