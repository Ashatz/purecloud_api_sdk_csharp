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
    public class FlowActivateRequestTests
    {
        private FlowActivateRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FlowActivateRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FlowActivateRequest
        /// </summary>
        [Test]
        public void FlowActivateRequestInstanceTest()
        {
            Assert.IsInstanceOf<FlowActivateRequest> (instance, "instance is a FlowActivateRequest");
        }

        
        /// <summary>
        /// Test the property 'Activated' 
        /// </summary>
        [Test]
        public void ActivatedTest()
        {
            // TODO: unit test for the property 'Activated' 
        }
        

    }

}
