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
    public class FlowTests
    {
        private Flow instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Flow();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Flow
        /// </summary>
        [Test]
        public void FlowInstanceTest()
        {
            Assert.IsInstanceOf<Flow> (instance, "instance is a Flow");
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
        /// Test the property 'Description' 
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO: unit test for the property 'Description' 
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
        /// Test the property 'LockedUser' 
        /// </summary>
        [Test]
        public void LockedUserTest()
        {
            // TODO: unit test for the property 'LockedUser' 
        }
        
        /// <summary>
        /// Test the property 'Active' 
        /// </summary>
        [Test]
        public void ActiveTest()
        {
            // TODO: unit test for the property 'Active' 
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
        /// Test the property 'PublishedVersion' 
        /// </summary>
        [Test]
        public void PublishedVersionTest()
        {
            // TODO: unit test for the property 'PublishedVersion' 
        }
        
        /// <summary>
        /// Test the property 'CheckedInVersion' 
        /// </summary>
        [Test]
        public void CheckedInVersionTest()
        {
            // TODO: unit test for the property 'CheckedInVersion' 
        }
        
        /// <summary>
        /// Test the property 'SavedVersion' 
        /// </summary>
        [Test]
        public void SavedVersionTest()
        {
            // TODO: unit test for the property 'SavedVersion' 
        }
        
        /// <summary>
        /// Test the property 'System' 
        /// </summary>
        [Test]
        public void SystemTest()
        {
            // TODO: unit test for the property 'System' 
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
