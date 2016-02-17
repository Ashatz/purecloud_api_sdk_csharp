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
    public class FlowVersionTests
    {
        private FlowVersion instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FlowVersion();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FlowVersion
        /// </summary>
        [Test]
        public void FlowVersionInstanceTest()
        {
            Assert.IsInstanceOf<FlowVersion> (instance, "instance is a FlowVersion");
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
        /// Test the property 'CommitVersion' 
        /// </summary>
        [Test]
        public void CommitVersionTest()
        {
            // TODO: unit test for the property 'CommitVersion' 
        }
        
        /// <summary>
        /// Test the property 'ConfigurationVersion' 
        /// </summary>
        [Test]
        public void ConfigurationVersionTest()
        {
            // TODO: unit test for the property 'ConfigurationVersion' 
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
        /// Test the property 'CreatedBy' 
        /// </summary>
        [Test]
        public void CreatedByTest()
        {
            // TODO: unit test for the property 'CreatedBy' 
        }
        
        /// <summary>
        /// Test the property 'ConfigurationUri' 
        /// </summary>
        [Test]
        public void ConfigurationUriTest()
        {
            // TODO: unit test for the property 'ConfigurationUri' 
        }
        
        /// <summary>
        /// Test the property 'DateCreated' 
        /// </summary>
        [Test]
        public void DateCreatedTest()
        {
            // TODO: unit test for the property 'DateCreated' 
        }
        
        /// <summary>
        /// Test the property 'GenerationId' 
        /// </summary>
        [Test]
        public void GenerationIdTest()
        {
            // TODO: unit test for the property 'GenerationId' 
        }
        
        /// <summary>
        /// Test the property 'PublishResultUri' 
        /// </summary>
        [Test]
        public void PublishResultUriTest()
        {
            // TODO: unit test for the property 'PublishResultUri' 
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
