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
    public class ContactCallbackRequestTests
    {
        private ContactCallbackRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ContactCallbackRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ContactCallbackRequest
        /// </summary>
        [Test]
        public void ContactCallbackRequestInstanceTest()
        {
            Assert.IsInstanceOf<ContactCallbackRequest> (instance, "instance is a ContactCallbackRequest");
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
        /// Test the property 'ContactListId' 
        /// </summary>
        [Test]
        public void ContactListIdTest()
        {
            // TODO: unit test for the property 'ContactListId' 
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
        /// Test the property 'PhoneColumn' 
        /// </summary>
        [Test]
        public void PhoneColumnTest()
        {
            // TODO: unit test for the property 'PhoneColumn' 
        }
        
        /// <summary>
        /// Test the property 'Schedule' 
        /// </summary>
        [Test]
        public void ScheduleTest()
        {
            // TODO: unit test for the property 'Schedule' 
        }
        

    }

}
