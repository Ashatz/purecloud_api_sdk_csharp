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
    public class RoutingStatusTests
    {
        private RoutingStatus instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RoutingStatus();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of RoutingStatus
        /// </summary>
        [Test]
        public void RoutingStatusInstanceTest()
        {
            Assert.IsInstanceOf<RoutingStatus> (instance, "instance is a RoutingStatus");
        }

        
        /// <summary>
        /// Test the property 'UserId' 
        /// </summary>
        [Test]
        public void UserIdTest()
        {
            // TODO: unit test for the property 'UserId' 
        }
        
        /// <summary>
        /// Test the property 'Status' 
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO: unit test for the property 'Status' 
        }
        
        /// <summary>
        /// Test the property 'StartTime' 
        /// </summary>
        [Test]
        public void StartTimeTest()
        {
            // TODO: unit test for the property 'StartTime' 
        }
        

    }

}
