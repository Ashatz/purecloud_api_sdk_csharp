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
    public class PhoneBaseTests
    {
        private PhoneBase instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PhoneBase();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of PhoneBase
        /// </summary>
        [Test]
        public void PhoneBaseInstanceTest()
        {
            Assert.IsInstanceOf<PhoneBase> (instance, "instance is a PhoneBase");
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
        /// Test the property 'PhoneMetaBase' 
        /// </summary>
        [Test]
        public void PhoneMetaBaseTest()
        {
            // TODO: unit test for the property 'PhoneMetaBase' 
        }
        
        /// <summary>
        /// Test the property 'Lines' 
        /// </summary>
        [Test]
        public void LinesTest()
        {
            // TODO: unit test for the property 'Lines' 
        }
        
        /// <summary>
        /// Test the property 'Properties' 
        /// </summary>
        [Test]
        public void PropertiesTest()
        {
            // TODO: unit test for the property 'Properties' 
        }
        
        /// <summary>
        /// Test the property 'Capabilities' 
        /// </summary>
        [Test]
        public void CapabilitiesTest()
        {
            // TODO: unit test for the property 'Capabilities' 
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