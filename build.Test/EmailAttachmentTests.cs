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
    public class EmailAttachmentTests
    {
        private EmailAttachment instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EmailAttachment();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of EmailAttachment
        /// </summary>
        [Test]
        public void EmailAttachmentInstanceTest()
        {
            Assert.IsInstanceOf<EmailAttachment> (instance, "instance is a EmailAttachment");
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
        /// Test the property 'ContentPath' 
        /// </summary>
        [Test]
        public void ContentPathTest()
        {
            // TODO: unit test for the property 'ContentPath' 
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
        /// Test the property 'AttachmentId' 
        /// </summary>
        [Test]
        public void AttachmentIdTest()
        {
            // TODO: unit test for the property 'AttachmentId' 
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