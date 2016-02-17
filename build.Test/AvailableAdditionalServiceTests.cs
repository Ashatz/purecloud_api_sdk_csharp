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
    public class AvailableAdditionalServiceTests
    {
        private AvailableAdditionalService instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AvailableAdditionalService();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of AvailableAdditionalService
        /// </summary>
        [Test]
        public void AvailableAdditionalServiceInstanceTest()
        {
            Assert.IsInstanceOf<AvailableAdditionalService> (instance, "instance is a AvailableAdditionalService");
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
        /// Test the property 'Description' 
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO: unit test for the property 'Description' 
        }
        
        /// <summary>
        /// Test the property 'PartNumber' 
        /// </summary>
        [Test]
        public void PartNumberTest()
        {
            // TODO: unit test for the property 'PartNumber' 
        }
        
        /// <summary>
        /// Test the property 'RequiredForProducts' 
        /// </summary>
        [Test]
        public void RequiredForProductsTest()
        {
            // TODO: unit test for the property 'RequiredForProducts' 
        }
        
        /// <summary>
        /// Test the property 'Rate' 
        /// </summary>
        [Test]
        public void RateTest()
        {
            // TODO: unit test for the property 'Rate' 
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
