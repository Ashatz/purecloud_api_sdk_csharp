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
    public class GatewayTests
    {
        private Gateway instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Gateway();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Gateway
        /// </summary>
        [Test]
        public void GatewayInstanceTest()
        {
            Assert.IsInstanceOf<Gateway> (instance, "instance is a Gateway");
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
        /// Test the property 'Ip' 
        /// </summary>
        [Test]
        public void IpTest()
        {
            // TODO: unit test for the property 'Ip' 
        }
        
        /// <summary>
        /// Test the property 'Port' 
        /// </summary>
        [Test]
        public void PortTest()
        {
            // TODO: unit test for the property 'Port' 
        }
        

    }

}
