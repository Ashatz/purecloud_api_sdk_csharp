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
    public class FlowLaunchRequestTests
    {
        private FlowLaunchRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FlowLaunchRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FlowLaunchRequest
        /// </summary>
        [Test]
        public void FlowLaunchRequestInstanceTest()
        {
            Assert.IsInstanceOf<FlowLaunchRequest> (instance, "instance is a FlowLaunchRequest");
        }

        
        /// <summary>
        /// Test the property 'FlowConfigId' 
        /// </summary>
        [Test]
        public void FlowConfigIdTest()
        {
            // TODO: unit test for the property 'FlowConfigId' 
        }
        
        /// <summary>
        /// Test the property 'FlowInstanceName' 
        /// </summary>
        [Test]
        public void FlowInstanceNameTest()
        {
            // TODO: unit test for the property 'FlowInstanceName' 
        }
        
        /// <summary>
        /// Test the property 'InputData' 
        /// </summary>
        [Test]
        public void InputDataTest()
        {
            // TODO: unit test for the property 'InputData' 
        }
        
        /// <summary>
        /// Test the property 'LaunchType' 
        /// </summary>
        [Test]
        public void LaunchTypeTest()
        {
            // TODO: unit test for the property 'LaunchType' 
        }
        

    }

}
