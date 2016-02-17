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
    public class FlowConfigMetaDataTests
    {
        private FlowConfigMetaData instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FlowConfigMetaData();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FlowConfigMetaData
        /// </summary>
        [Test]
        public void FlowConfigMetaDataInstanceTest()
        {
            Assert.IsInstanceOf<FlowConfigMetaData> (instance, "instance is a FlowConfigMetaData");
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
        /// Test the property 'ConfigState' 
        /// </summary>
        [Test]
        public void ConfigStateTest()
        {
            // TODO: unit test for the property 'ConfigState' 
        }
        
        /// <summary>
        /// Test the property 'FlowType' 
        /// </summary>
        [Test]
        public void FlowTypeTest()
        {
            // TODO: unit test for the property 'FlowType' 
        }
        
        /// <summary>
        /// Test the property 'LockedByUser' 
        /// </summary>
        [Test]
        public void LockedByUserTest()
        {
            // TODO: unit test for the property 'LockedByUser' 
        }
        
        /// <summary>
        /// Test the property 'NewestPublishedVersion' 
        /// </summary>
        [Test]
        public void NewestPublishedVersionTest()
        {
            // TODO: unit test for the property 'NewestPublishedVersion' 
        }
        
        /// <summary>
        /// Test the property 'NewestVersion' 
        /// </summary>
        [Test]
        public void NewestVersionTest()
        {
            // TODO: unit test for the property 'NewestVersion' 
        }
        
        /// <summary>
        /// Test the property 'AssociatedWorkspaces' 
        /// </summary>
        [Test]
        public void AssociatedWorkspacesTest()
        {
            // TODO: unit test for the property 'AssociatedWorkspaces' 
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
        /// Test the property 'HasDraft' 
        /// </summary>
        [Test]
        public void HasDraftTest()
        {
            // TODO: unit test for the property 'HasDraft' 
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
