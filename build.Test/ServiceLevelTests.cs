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
    public class ServiceLevelTests
    {
        private ServiceLevel instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ServiceLevel();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ServiceLevel
        /// </summary>
        [Test]
        public void ServiceLevelInstanceTest()
        {
            Assert.IsInstanceOf<ServiceLevel> (instance, "instance is a ServiceLevel");
        }

        
        /// <summary>
        /// Test the property 'Percentage' 
        /// </summary>
        [Test]
        public void PercentageTest()
        {
            // TODO: unit test for the property 'Percentage' 
        }
        
        /// <summary>
        /// Test the property 'DurationMs' 
        /// </summary>
        [Test]
        public void DurationMsTest()
        {
            // TODO: unit test for the property 'DurationMs' 
        }
        

    }

}
