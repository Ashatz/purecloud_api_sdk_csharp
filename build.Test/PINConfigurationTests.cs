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
    public class PINConfigurationTests
    {
        private PINConfiguration instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PINConfiguration();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of PINConfiguration
        /// </summary>
        [Test]
        public void PINConfigurationInstanceTest()
        {
            Assert.IsInstanceOf<PINConfiguration> (instance, "instance is a PINConfiguration");
        }

        
        /// <summary>
        /// Test the property 'MinimumLength' 
        /// </summary>
        [Test]
        public void MinimumLengthTest()
        {
            // TODO: unit test for the property 'MinimumLength' 
        }
        
        /// <summary>
        /// Test the property 'MaximumLength' 
        /// </summary>
        [Test]
        public void MaximumLengthTest()
        {
            // TODO: unit test for the property 'MaximumLength' 
        }
        

    }

}
