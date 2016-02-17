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
    public class WorkItemCommandGroupTests
    {
        private WorkItemCommandGroup instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WorkItemCommandGroup();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of WorkItemCommandGroup
        /// </summary>
        [Test]
        public void WorkItemCommandGroupInstanceTest()
        {
            Assert.IsInstanceOf<WorkItemCommandGroup> (instance, "instance is a WorkItemCommandGroup");
        }

        
        /// <summary>
        /// Test the property 'Category' 
        /// </summary>
        [Test]
        public void CategoryTest()
        {
            // TODO: unit test for the property 'Category' 
        }
        
        /// <summary>
        /// Test the property 'DefaultCommandId' 
        /// </summary>
        [Test]
        public void DefaultCommandIdTest()
        {
            // TODO: unit test for the property 'DefaultCommandId' 
        }
        
        /// <summary>
        /// Test the property 'Commands' 
        /// </summary>
        [Test]
        public void CommandsTest()
        {
            // TODO: unit test for the property 'Commands' 
        }
        

    }

}
