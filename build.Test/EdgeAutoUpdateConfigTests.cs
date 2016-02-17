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
    public class EdgeAutoUpdateConfigTests
    {
        private EdgeAutoUpdateConfig instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EdgeAutoUpdateConfig();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of EdgeAutoUpdateConfig
        /// </summary>
        [Test]
        public void EdgeAutoUpdateConfigInstanceTest()
        {
            Assert.IsInstanceOf<EdgeAutoUpdateConfig> (instance, "instance is a EdgeAutoUpdateConfig");
        }

        
        /// <summary>
        /// Test the property 'TimeZone' 
        /// </summary>
        [Test]
        public void TimeZoneTest()
        {
            // TODO: unit test for the property 'TimeZone' 
        }
        
        /// <summary>
        /// Test the property 'Rrule' 
        /// </summary>
        [Test]
        public void RruleTest()
        {
            // TODO: unit test for the property 'Rrule' 
        }
        
        /// <summary>
        /// Test the property 'Start' 
        /// </summary>
        [Test]
        public void StartTest()
        {
            // TODO: unit test for the property 'Start' 
        }
        
        /// <summary>
        /// Test the property 'End' 
        /// </summary>
        [Test]
        public void EndTest()
        {
            // TODO: unit test for the property 'End' 
        }
        

    }

}
