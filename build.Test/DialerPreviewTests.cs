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
    public class DialerPreviewTests
    {
        private DialerPreview instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DialerPreview();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DialerPreview
        /// </summary>
        [Test]
        public void DialerPreviewInstanceTest()
        {
            Assert.IsInstanceOf<DialerPreview> (instance, "instance is a DialerPreview");
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
        /// Test the property 'ContactId' 
        /// </summary>
        [Test]
        public void ContactIdTest()
        {
            // TODO: unit test for the property 'ContactId' 
        }
        
        /// <summary>
        /// Test the property 'ContactListId' 
        /// </summary>
        [Test]
        public void ContactListIdTest()
        {
            // TODO: unit test for the property 'ContactListId' 
        }
        
        /// <summary>
        /// Test the property 'CampaignId' 
        /// </summary>
        [Test]
        public void CampaignIdTest()
        {
            // TODO: unit test for the property 'CampaignId' 
        }
        
        /// <summary>
        /// Test the property 'PhoneNumberColumns' 
        /// </summary>
        [Test]
        public void PhoneNumberColumnsTest()
        {
            // TODO: unit test for the property 'PhoneNumberColumns' 
        }
        

    }

}
