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
    public class BackendFlowAvailableActionsTests
    {
        private BackendFlowAvailableActions instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BackendFlowAvailableActions();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of BackendFlowAvailableActions
        /// </summary>
        [Test]
        public void BackendFlowAvailableActionsInstanceTest()
        {
            Assert.IsInstanceOf<BackendFlowAvailableActions> (instance, "instance is a BackendFlowAvailableActions");
        }

        
        /// <summary>
        /// Test the property 'CanTerminate' 
        /// </summary>
        [Test]
        public void CanTerminateTest()
        {
            // TODO: unit test for the property 'CanTerminate' 
        }
        

    }

}
