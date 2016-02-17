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
    public class DependencyObjectTests
    {
        private DependencyObject instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DependencyObject();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DependencyObject
        /// </summary>
        [Test]
        public void DependencyObjectInstanceTest()
        {
            Assert.IsInstanceOf<DependencyObject> (instance, "instance is a DependencyObject");
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
        /// Test the property 'Version' 
        /// </summary>
        [Test]
        public void VersionTest()
        {
            // TODO: unit test for the property 'Version' 
        }
        
        /// <summary>
        /// Test the property 'Type' 
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO: unit test for the property 'Type' 
        }
        
        /// <summary>
        /// Test the property 'Deleted' 
        /// </summary>
        [Test]
        public void DeletedTest()
        {
            // TODO: unit test for the property 'Deleted' 
        }
        
        /// <summary>
        /// Test the property 'ConsumedResources' 
        /// </summary>
        [Test]
        public void ConsumedResourcesTest()
        {
            // TODO: unit test for the property 'ConsumedResources' 
        }
        
        /// <summary>
        /// Test the property 'ConsumingResources' 
        /// </summary>
        [Test]
        public void ConsumingResourcesTest()
        {
            // TODO: unit test for the property 'ConsumingResources' 
        }
        
        /// <summary>
        /// Test the property 'SelfUri' 
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri' 
        }
        

    }

}
