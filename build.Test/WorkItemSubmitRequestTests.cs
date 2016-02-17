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
    public class WorkItemSubmitRequestTests
    {
        private WorkItemSubmitRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WorkItemSubmitRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of WorkItemSubmitRequest
        /// </summary>
        [Test]
        public void WorkItemSubmitRequestInstanceTest()
        {
            Assert.IsInstanceOf<WorkItemSubmitRequest> (instance, "instance is a WorkItemSubmitRequest");
        }

        
        /// <summary>
        /// Test the property 'CommandId' 
        /// </summary>
        [Test]
        public void CommandIdTest()
        {
            // TODO: unit test for the property 'CommandId' 
        }
        
        /// <summary>
        /// Test the property 'DataItems' 
        /// </summary>
        [Test]
        public void DataItemsTest()
        {
            // TODO: unit test for the property 'DataItems' 
        }
        

    }

}
