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
    public class WorkItemTests
    {
        private WorkItem instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WorkItem();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of WorkItem
        /// </summary>
        [Test]
        public void WorkItemInstanceTest()
        {
            Assert.IsInstanceOf<WorkItem> (instance, "instance is a WorkItem");
        }

        
        /// <summary>
        /// Test the property 'WorkItemExecId' 
        /// </summary>
        [Test]
        public void WorkItemExecIdTest()
        {
            // TODO: unit test for the property 'WorkItemExecId' 
        }
        
        /// <summary>
        /// Test the property 'WorkItemConfigId' 
        /// </summary>
        [Test]
        public void WorkItemConfigIdTest()
        {
            // TODO: unit test for the property 'WorkItemConfigId' 
        }
        
        /// <summary>
        /// Test the property 'WorkItemName' 
        /// </summary>
        [Test]
        public void WorkItemNameTest()
        {
            // TODO: unit test for the property 'WorkItemName' 
        }
        

    }

}
