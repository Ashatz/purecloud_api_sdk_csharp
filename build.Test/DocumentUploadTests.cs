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
    public class DocumentUploadTests
    {
        private DocumentUpload instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DocumentUpload();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DocumentUpload
        /// </summary>
        [Test]
        public void DocumentUploadInstanceTest()
        {
            Assert.IsInstanceOf<DocumentUpload> (instance, "instance is a DocumentUpload");
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
        /// Test the property 'Workspace' 
        /// </summary>
        [Test]
        public void WorkspaceTest()
        {
            // TODO: unit test for the property 'Workspace' 
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
        /// Test the property 'TagIds' 
        /// </summary>
        [Test]
        public void TagIdsTest()
        {
            // TODO: unit test for the property 'TagIds' 
        }
        

    }

}
