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
    public class FlowAssociateWorkspacesRequestTests
    {
        private FlowAssociateWorkspacesRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FlowAssociateWorkspacesRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FlowAssociateWorkspacesRequest
        /// </summary>
        [Test]
        public void FlowAssociateWorkspacesRequestInstanceTest()
        {
            Assert.IsInstanceOf<FlowAssociateWorkspacesRequest> (instance, "instance is a FlowAssociateWorkspacesRequest");
        }

        
        /// <summary>
        /// Test the property 'Workspaces' 
        /// </summary>
        [Test]
        public void WorkspacesTest()
        {
            // TODO: unit test for the property 'Workspaces' 
        }
        

    }

}
