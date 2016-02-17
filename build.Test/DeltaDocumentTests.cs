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
    public class DeltaDocumentTests
    {
        private DeltaDocument instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DeltaDocument();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DeltaDocument
        /// </summary>
        [Test]
        public void DeltaDocumentInstanceTest()
        {
            Assert.IsInstanceOf<DeltaDocument> (instance, "instance is a DeltaDocument");
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
        /// Test the property 'Filename' 
        /// </summary>
        [Test]
        public void FilenameTest()
        {
            // TODO: unit test for the property 'Filename' 
        }
        
        /// <summary>
        /// Test the property 'ContentType' 
        /// </summary>
        [Test]
        public void ContentTypeTest()
        {
            // TODO: unit test for the property 'ContentType' 
        }
        
        /// <summary>
        /// Test the property 'ContentLengthBytes' 
        /// </summary>
        [Test]
        public void ContentLengthBytesTest()
        {
            // TODO: unit test for the property 'ContentLengthBytes' 
        }
        
        /// <summary>
        /// Test the property 'Operation' 
        /// </summary>
        [Test]
        public void OperationTest()
        {
            // TODO: unit test for the property 'Operation' 
        }
        
        /// <summary>
        /// Test the property 'DateModified' 
        /// </summary>
        [Test]
        public void DateModifiedTest()
        {
            // TODO: unit test for the property 'DateModified' 
        }
        

    }

}
