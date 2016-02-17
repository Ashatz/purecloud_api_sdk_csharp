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
    public class UnreadMetricTests
    {
        private UnreadMetric instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UnreadMetric();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of UnreadMetric
        /// </summary>
        [Test]
        public void UnreadMetricInstanceTest()
        {
            Assert.IsInstanceOf<UnreadMetric> (instance, "instance is a UnreadMetric");
        }

        
        /// <summary>
        /// Test the property 'Count' 
        /// </summary>
        [Test]
        public void CountTest()
        {
            // TODO: unit test for the property 'Count' 
        }
        

    }

}
