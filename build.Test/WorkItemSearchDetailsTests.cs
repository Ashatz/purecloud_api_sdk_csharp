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
    public class WorkItemSearchDetailsTests
    {
        private WorkItemSearchDetails instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WorkItemSearchDetails();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of WorkItemSearchDetails
        /// </summary>
        [Test]
        public void WorkItemSearchDetailsInstanceTest()
        {
            Assert.IsInstanceOf<WorkItemSearchDetails> (instance, "instance is a WorkItemSearchDetails");
        }

        
        /// <summary>
        /// Test the property 'WorkItem' 
        /// </summary>
        [Test]
        public void WorkItemTest()
        {
            // TODO: unit test for the property 'WorkItem' 
        }
        

    }

}
