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
    public class FlowTerminateRequestTests
    {
        private FlowTerminateRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FlowTerminateRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FlowTerminateRequest
        /// </summary>
        [Test]
        public void FlowTerminateRequestInstanceTest()
        {
            Assert.IsInstanceOf<FlowTerminateRequest> (instance, "instance is a FlowTerminateRequest");
        }

        
        /// <summary>
        /// Test the property 'Force' 
        /// </summary>
        [Test]
        public void ForceTest()
        {
            // TODO: unit test for the property 'Force' 
        }
        
        /// <summary>
        /// Test the property 'Reason' 
        /// </summary>
        [Test]
        public void ReasonTest()
        {
            // TODO: unit test for the property 'Reason' 
        }
        

    }

}
