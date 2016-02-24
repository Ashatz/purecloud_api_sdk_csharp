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
    public class WorkItemDefinitionTests
    {
        private WorkItemDefinition instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WorkItemDefinition();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of WorkItemDefinition
        /// </summary>
        [Test]
        public void WorkItemDefinitionInstanceTest()
        {
            Assert.IsInstanceOf<WorkItemDefinition> (instance, "instance is a WorkItemDefinition");
        }

        
        /// <summary>
        /// Test the property 'Id' 
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id' 
        }
        
        /// <summary>
        /// Test the property 'Name' 
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name' 
        }
        
        /// <summary>
        /// Test the property 'CommandCategories' 
        /// </summary>
        [Test]
        public void CommandCategoriesTest()
        {
            // TODO: unit test for the property 'CommandCategories' 
        }
        
        /// <summary>
        /// Test the property 'Form' 
        /// </summary>
        [Test]
        public void FormTest()
        {
            // TODO: unit test for the property 'Form' 
        }
        

    }

}
