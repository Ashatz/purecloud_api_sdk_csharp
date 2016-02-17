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
    public class AlertTests
    {
        private Alert instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Alert();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Alert
        /// </summary>
        [Test]
        public void AlertInstanceTest()
        {
            Assert.IsInstanceOf<Alert> (instance, "instance is a Alert");
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
        /// Test the property 'Name' 
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name' 
        }
        
        /// <summary>
        /// Test the property 'Title' 
        /// </summary>
        [Test]
        public void TitleTest()
        {
            // TODO: unit test for the property 'Title' 
        }
        
        /// <summary>
        /// Test the property 'Description' 
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO: unit test for the property 'Description' 
        }
        
        /// <summary>
        /// Test the property 'Unread' 
        /// </summary>
        [Test]
        public void UnreadTest()
        {
            // TODO: unit test for the property 'Unread' 
        }
        
        /// <summary>
        /// Test the property 'Entity' 
        /// </summary>
        [Test]
        public void EntityTest()
        {
            // TODO: unit test for the property 'Entity' 
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
        /// Test the property 'MetricThresholds' 
        /// </summary>
        [Test]
        public void MetricThresholdsTest()
        {
            // TODO: unit test for the property 'MetricThresholds' 
        }
        
        /// <summary>
        /// Test the property 'MetricValue' 
        /// </summary>
        [Test]
        public void MetricValueTest()
        {
            // TODO: unit test for the property 'MetricValue' 
        }
        
        /// <summary>
        /// Test the property 'StartTime' 
        /// </summary>
        [Test]
        public void StartTimeTest()
        {
            // TODO: unit test for the property 'StartTime' 
        }
        
        /// <summary>
        /// Test the property 'EndTime' 
        /// </summary>
        [Test]
        public void EndTimeTest()
        {
            // TODO: unit test for the property 'EndTime' 
        }
        
        /// <summary>
        /// Test the property 'MediaType' 
        /// </summary>
        [Test]
        public void MediaTypeTest()
        {
            // TODO: unit test for the property 'MediaType' 
        }
        
        /// <summary>
        /// Test the property 'Statistic' 
        /// </summary>
        [Test]
        public void StatisticTest()
        {
            // TODO: unit test for the property 'Statistic' 
        }
        
        /// <summary>
        /// Test the property 'RuleUri' 
        /// </summary>
        [Test]
        public void RuleUriTest()
        {
            // TODO: unit test for the property 'RuleUri' 
        }
        
        /// <summary>
        /// Test the property 'SelfUri' 
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri' 
        }
        

    }

}
