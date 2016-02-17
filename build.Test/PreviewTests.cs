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
    public class PreviewTests
    {
        private Preview instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Preview();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Preview
        /// </summary>
        [Test]
        public void PreviewInstanceTest()
        {
            Assert.IsInstanceOf<Preview> (instance, "instance is a Preview");
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
        /// Test the property 'SelfUri' 
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri' 
        }
        
        /// <summary>
        /// Test the property 'Campaign' 
        /// </summary>
        [Test]
        public void CampaignTest()
        {
            // TODO: unit test for the property 'Campaign' 
        }
        
        /// <summary>
        /// Test the property 'ContactList' 
        /// </summary>
        [Test]
        public void ContactListTest()
        {
            // TODO: unit test for the property 'ContactList' 
        }
        
        /// <summary>
        /// Test the property 'Contact' 
        /// </summary>
        [Test]
        public void ContactTest()
        {
            // TODO: unit test for the property 'Contact' 
        }
        
        /// <summary>
        /// Test the property 'AvailablePhoneNumbers' 
        /// </summary>
        [Test]
        public void AvailablePhoneNumbersTest()
        {
            // TODO: unit test for the property 'AvailablePhoneNumbers' 
        }
        
        /// <summary>
        /// Test the property 'RemainingSeconds' 
        /// </summary>
        [Test]
        public void RemainingSecondsTest()
        {
            // TODO: unit test for the property 'RemainingSeconds' 
        }
        
        /// <summary>
        /// Test the property 'ScriptId' 
        /// </summary>
        [Test]
        public void ScriptIdTest()
        {
            // TODO: unit test for the property 'ScriptId' 
        }
        
        /// <summary>
        /// Test the property 'TimedOut' 
        /// </summary>
        [Test]
        public void TimedOutTest()
        {
            // TODO: unit test for the property 'TimedOut' 
        }
        

    }

}
