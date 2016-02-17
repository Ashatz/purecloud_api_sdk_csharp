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
    public class FlowStateTests
    {
        private FlowState instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FlowState();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FlowState
        /// </summary>
        [Test]
        public void FlowStateInstanceTest()
        {
            Assert.IsInstanceOf<FlowState> (instance, "instance is a FlowState");
        }

        
        /// <summary>
        /// Test the property 'StateExecId' 
        /// </summary>
        [Test]
        public void StateExecIdTest()
        {
            // TODO: unit test for the property 'StateExecId' 
        }
        
        /// <summary>
        /// Test the property 'StateConfigId' 
        /// </summary>
        [Test]
        public void StateConfigIdTest()
        {
            // TODO: unit test for the property 'StateConfigId' 
        }
        
        /// <summary>
        /// Test the property 'StateName' 
        /// </summary>
        [Test]
        public void StateNameTest()
        {
            // TODO: unit test for the property 'StateName' 
        }
        

    }

}
