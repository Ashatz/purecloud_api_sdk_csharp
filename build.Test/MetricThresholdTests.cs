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
    public class MetricThresholdTests
    {
        private MetricThreshold instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MetricThreshold();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of MetricThreshold
        /// </summary>
        [Test]
        public void MetricThresholdInstanceTest()
        {
            Assert.IsInstanceOf<MetricThreshold> (instance, "instance is a MetricThreshold");
        }

        
        /// <summary>
        /// Test the property 'Op' 
        /// </summary>
        [Test]
        public void OpTest()
        {
            // TODO: unit test for the property 'Op' 
        }
        
        /// <summary>
        /// Test the property 'Value' 
        /// </summary>
        [Test]
        public void ValueTest()
        {
            // TODO: unit test for the property 'Value' 
        }
        

    }

}
