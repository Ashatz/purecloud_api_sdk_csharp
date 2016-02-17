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
    public class UploadProgressTests
    {
        private UploadProgress instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UploadProgress();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of UploadProgress
        /// </summary>
        [Test]
        public void UploadProgressInstanceTest()
        {
            Assert.IsInstanceOf<UploadProgress> (instance, "instance is a UploadProgress");
        }

        
        /// <summary>
        /// Test the property 'CarrierId' 
        /// </summary>
        [Test]
        public void CarrierIdTest()
        {
            // TODO: unit test for the property 'CarrierId' 
        }
        
        /// <summary>
        /// Test the property 'SchemaName' 
        /// </summary>
        [Test]
        public void SchemaNameTest()
        {
            // TODO: unit test for the property 'SchemaName' 
        }
        
        /// <summary>
        /// Test the property 'Status' 
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO: unit test for the property 'Status' 
        }
        
        /// <summary>
        /// Test the property 'Filename' 
        /// </summary>
        [Test]
        public void FilenameTest()
        {
            // TODO: unit test for the property 'Filename' 
        }
        
        /// <summary>
        /// Test the property 'Filetype' 
        /// </summary>
        [Test]
        public void FiletypeTest()
        {
            // TODO: unit test for the property 'Filetype' 
        }
        
        /// <summary>
        /// Test the property 'Created' 
        /// </summary>
        [Test]
        public void CreatedTest()
        {
            // TODO: unit test for the property 'Created' 
        }
        
        /// <summary>
        /// Test the property 'Updated' 
        /// </summary>
        [Test]
        public void UpdatedTest()
        {
            // TODO: unit test for the property 'Updated' 
        }
        

    }

}
