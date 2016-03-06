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
    public class EmailMessageTests
    {
        private EmailMessage instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EmailMessage();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of EmailMessage
        /// </summary>
        [Test]
        public void EmailMessageInstanceTest()
        {
            Assert.IsInstanceOf<EmailMessage> (instance, "instance is a EmailMessage");
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
        /// Test the property 'To' 
        /// </summary>
        [Test]
        public void ToTest()
        {
            // TODO: unit test for the property 'To' 
        }
        
        /// <summary>
        /// Test the property 'Cc' 
        /// </summary>
        [Test]
        public void CcTest()
        {
            // TODO: unit test for the property 'Cc' 
        }
        
        /// <summary>
        /// Test the property 'Bcc' 
        /// </summary>
        [Test]
        public void BccTest()
        {
            // TODO: unit test for the property 'Bcc' 
        }
        
        /// <summary>
        /// Test the property 'From' 
        /// </summary>
        [Test]
        public void FromTest()
        {
            // TODO: unit test for the property 'From' 
        }
        
        /// <summary>
        /// Test the property 'Subject' 
        /// </summary>
        [Test]
        public void SubjectTest()
        {
            // TODO: unit test for the property 'Subject' 
        }
        
        /// <summary>
        /// Test the property 'Attachments' 
        /// </summary>
        [Test]
        public void AttachmentsTest()
        {
            // TODO: unit test for the property 'Attachments' 
        }
        
        /// <summary>
        /// Test the property 'TextBody' 
        /// </summary>
        [Test]
        public void TextBodyTest()
        {
            // TODO: unit test for the property 'TextBody' 
        }
        
        /// <summary>
        /// Test the property 'HtmlBody' 
        /// </summary>
        [Test]
        public void HtmlBodyTest()
        {
            // TODO: unit test for the property 'HtmlBody' 
        }
        
        /// <summary>
        /// Test the property 'Time' 
        /// </summary>
        [Test]
        public void TimeTest()
        {
            // TODO: unit test for the property 'Time' 
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
