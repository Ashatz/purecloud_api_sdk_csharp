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
    public class ThirdPartySubscriptionTests
    {
        private ThirdPartySubscription instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ThirdPartySubscription();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ThirdPartySubscription
        /// </summary>
        [Test]
        public void ThirdPartySubscriptionInstanceTest()
        {
            Assert.IsInstanceOf<ThirdPartySubscription> (instance, "instance is a ThirdPartySubscription");
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
        /// Test the property 'Notes' 
        /// </summary>
        [Test]
        public void NotesTest()
        {
            // TODO: unit test for the property 'Notes' 
        }
        
        /// <summary>
        /// Test the property 'ContractEffectiveDate' 
        /// </summary>
        [Test]
        public void ContractEffectiveDateTest()
        {
            // TODO: unit test for the property 'ContractEffectiveDate' 
        }
        
        /// <summary>
        /// Test the property 'Version' 
        /// </summary>
        [Test]
        public void VersionTest()
        {
            // TODO: unit test for the property 'Version' 
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
