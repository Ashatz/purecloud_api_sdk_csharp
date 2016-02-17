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
    public class SupportTests
    {
        private Support instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Support();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Support
        /// </summary>
        [Test]
        public void SupportInstanceTest()
        {
            Assert.IsInstanceOf<Support> (instance, "instance is a Support");
        }

        
        /// <summary>
        /// Test the property 'Phone' 
        /// </summary>
        [Test]
        public void PhoneTest()
        {
            // TODO: unit test for the property 'Phone' 
        }
        
        /// <summary>
        /// Test the property 'Email' 
        /// </summary>
        [Test]
        public void EmailTest()
        {
            // TODO: unit test for the property 'Email' 
        }
        
        /// <summary>
        /// Test the property 'Website' 
        /// </summary>
        [Test]
        public void WebsiteTest()
        {
            // TODO: unit test for the property 'Website' 
        }
        

    }

}
