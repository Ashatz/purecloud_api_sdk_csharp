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
    public class DnsTests
    {
        private Dns instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Dns();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Dns
        /// </summary>
        [Test]
        public void DnsInstanceTest()
        {
            Assert.IsInstanceOf<Dns> (instance, "instance is a Dns");
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
