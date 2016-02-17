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
    public class ProvisionInfoTests
    {
        private ProvisionInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProvisionInfo();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ProvisionInfo
        /// </summary>
        [Test]
        public void ProvisionInfoInstanceTest()
        {
            Assert.IsInstanceOf<ProvisionInfo> (instance, "instance is a ProvisionInfo");
        }

        
        /// <summary>
        /// Test the property 'Time' 
        /// </summary>
        [Test]
        public void TimeTest()
        {
            // TODO: unit test for the property 'Time' 
        }
        
        /// <summary>
        /// Test the property 'Source' 
        /// </summary>
        [Test]
        public void SourceTest()
        {
            // TODO: unit test for the property 'Source' 
        }
        
        /// <summary>
        /// Test the property 'ErrorInfo' 
        /// </summary>
        [Test]
        public void ErrorInfoTest()
        {
            // TODO: unit test for the property 'ErrorInfo' 
        }
        

    }

}
