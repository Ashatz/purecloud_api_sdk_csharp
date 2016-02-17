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
    public class UserActionMetadataTests
    {
        private UserActionMetadata instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserActionMetadata();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of UserActionMetadata
        /// </summary>
        [Test]
        public void UserActionMetadataInstanceTest()
        {
            Assert.IsInstanceOf<UserActionMetadata> (instance, "instance is a UserActionMetadata");
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
        /// Test the property 'Category' 
        /// </summary>
        [Test]
        public void CategoryTest()
        {
            // TODO: unit test for the property 'Category' 
        }
        
        /// <summary>
        /// Test the property 'Deprecated' 
        /// </summary>
        [Test]
        public void DeprecatedTest()
        {
            // TODO: unit test for the property 'Deprecated' 
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
        /// Test the property 'Published' 
        /// </summary>
        [Test]
        public void PublishedTest()
        {
            // TODO: unit test for the property 'Published' 
        }
        
        /// <summary>
        /// Test the property 'Tags' 
        /// </summary>
        [Test]
        public void TagsTest()
        {
            // TODO: unit test for the property 'Tags' 
        }
        
        /// <summary>
        /// Test the property 'HelpLink' 
        /// </summary>
        [Test]
        public void HelpLinkTest()
        {
            // TODO: unit test for the property 'HelpLink' 
        }
        
        /// <summary>
        /// Test the property 'Requests' 
        /// </summary>
        [Test]
        public void RequestsTest()
        {
            // TODO: unit test for the property 'Requests' 
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
