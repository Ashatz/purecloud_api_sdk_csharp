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
    public class TransformProgressTests
    {
        private TransformProgress instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TransformProgress();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of TransformProgress
        /// </summary>
        [Test]
        public void TransformProgressInstanceTest()
        {
            Assert.IsInstanceOf<TransformProgress> (instance, "instance is a TransformProgress");
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
        /// Test the property 'Service' 
        /// </summary>
        [Test]
        public void ServiceTest()
        {
            // TODO: unit test for the property 'Service' 
        }
        
        /// <summary>
        /// Test the property 'User' 
        /// </summary>
        [Test]
        public void UserTest()
        {
            // TODO: unit test for the property 'User' 
        }
        
        /// <summary>
        /// Test the property 'UploadTime' 
        /// </summary>
        [Test]
        public void UploadTimeTest()
        {
            // TODO: unit test for the property 'UploadTime' 
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
        /// Test the property 'Tags' 
        /// </summary>
        [Test]
        public void TagsTest()
        {
            // TODO: unit test for the property 'Tags' 
        }
        
        /// <summary>
        /// Test the property 'Progress' 
        /// </summary>
        [Test]
        public void ProgressTest()
        {
            // TODO: unit test for the property 'Progress' 
        }
        
        /// <summary>
        /// Test the property 'Model' 
        /// </summary>
        [Test]
        public void ModelTest()
        {
            // TODO: unit test for the property 'Model' 
        }
        
        /// <summary>
        /// Test the property 'Errors' 
        /// </summary>
        [Test]
        public void ErrorsTest()
        {
            // TODO: unit test for the property 'Errors' 
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