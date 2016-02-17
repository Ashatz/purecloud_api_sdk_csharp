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
    public class AttachmentTests
    {
        private Attachment instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Attachment();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Attachment
        /// </summary>
        [Test]
        public void AttachmentInstanceTest()
        {
            Assert.IsInstanceOf<Attachment> (instance, "instance is a Attachment");
        }

        
        /// <summary>
        /// Test the property 'AttachmentId' 
        /// </summary>
        [Test]
        public void AttachmentIdTest()
        {
            // TODO: unit test for the property 'AttachmentId' 
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
        /// Test the property 'ContentUri' 
        /// </summary>
        [Test]
        public void ContentUriTest()
        {
            // TODO: unit test for the property 'ContentUri' 
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
        /// Test the property 'ContentLength' 
        /// </summary>
        [Test]
        public void ContentLengthTest()
        {
            // TODO: unit test for the property 'ContentLength' 
        }
        

    }

}
