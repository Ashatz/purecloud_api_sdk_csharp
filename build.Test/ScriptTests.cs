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
    public class ScriptTests
    {
        private Script instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Script();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Script
        /// </summary>
        [Test]
        public void ScriptInstanceTest()
        {
            Assert.IsInstanceOf<Script> (instance, "instance is a Script");
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
        /// Test the property 'VersionId' 
        /// </summary>
        [Test]
        public void VersionIdTest()
        {
            // TODO: unit test for the property 'VersionId' 
        }
        
        /// <summary>
        /// Test the property 'CreatedDate' 
        /// </summary>
        [Test]
        public void CreatedDateTest()
        {
            // TODO: unit test for the property 'CreatedDate' 
        }
        
        /// <summary>
        /// Test the property 'ModifiedDate' 
        /// </summary>
        [Test]
        public void ModifiedDateTest()
        {
            // TODO: unit test for the property 'ModifiedDate' 
        }
        
        /// <summary>
        /// Test the property 'PublishedDate' 
        /// </summary>
        [Test]
        public void PublishedDateTest()
        {
            // TODO: unit test for the property 'PublishedDate' 
        }
        
        /// <summary>
        /// Test the property 'VersionDate' 
        /// </summary>
        [Test]
        public void VersionDateTest()
        {
            // TODO: unit test for the property 'VersionDate' 
        }
        
        /// <summary>
        /// Test the property 'StartPageId' 
        /// </summary>
        [Test]
        public void StartPageIdTest()
        {
            // TODO: unit test for the property 'StartPageId' 
        }
        
        /// <summary>
        /// Test the property 'StartPageName' 
        /// </summary>
        [Test]
        public void StartPageNameTest()
        {
            // TODO: unit test for the property 'StartPageName' 
        }
        
        /// <summary>
        /// Test the property 'Features' 
        /// </summary>
        [Test]
        public void FeaturesTest()
        {
            // TODO: unit test for the property 'Features' 
        }
        
        /// <summary>
        /// Test the property 'Variables' 
        /// </summary>
        [Test]
        public void VariablesTest()
        {
            // TODO: unit test for the property 'Variables' 
        }
        
        /// <summary>
        /// Test the property 'CustomActions' 
        /// </summary>
        [Test]
        public void CustomActionsTest()
        {
            // TODO: unit test for the property 'CustomActions' 
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
