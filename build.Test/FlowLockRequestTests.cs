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
    public class FlowLockRequestTests
    {
        private FlowLockRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FlowLockRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FlowLockRequest
        /// </summary>
        [Test]
        public void FlowLockRequestInstanceTest()
        {
            Assert.IsInstanceOf<FlowLockRequest> (instance, "instance is a FlowLockRequest");
        }

        
        /// <summary>
        /// Test the property 'Locked' 
        /// </summary>
        [Test]
        public void LockedTest()
        {
            // TODO: unit test for the property 'Locked' 
        }
        

    }

}
