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
    public class InboundRouteTests
    {
        private InboundRoute instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new InboundRoute();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of InboundRoute
        /// </summary>
        [Test]
        public void InboundRouteInstanceTest()
        {
            Assert.IsInstanceOf<InboundRoute> (instance, "instance is a InboundRoute");
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
        /// Test the property 'Pattern' 
        /// </summary>
        [Test]
        public void PatternTest()
        {
            // TODO: unit test for the property 'Pattern' 
        }
        
        /// <summary>
        /// Test the property 'Queue' 
        /// </summary>
        [Test]
        public void QueueTest()
        {
            // TODO: unit test for the property 'Queue' 
        }
        
        /// <summary>
        /// Test the property 'Priority' 
        /// </summary>
        [Test]
        public void PriorityTest()
        {
            // TODO: unit test for the property 'Priority' 
        }
        
        /// <summary>
        /// Test the property 'Skills' 
        /// </summary>
        [Test]
        public void SkillsTest()
        {
            // TODO: unit test for the property 'Skills' 
        }
        
        /// <summary>
        /// Test the property 'Language' 
        /// </summary>
        [Test]
        public void LanguageTest()
        {
            // TODO: unit test for the property 'Language' 
        }
        
        /// <summary>
        /// Test the property 'FromName' 
        /// </summary>
        [Test]
        public void FromNameTest()
        {
            // TODO: unit test for the property 'FromName' 
        }
        
        /// <summary>
        /// Test the property 'FromEmail' 
        /// </summary>
        [Test]
        public void FromEmailTest()
        {
            // TODO: unit test for the property 'FromEmail' 
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
