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
    public class ValidateAddressResponseTests
    {
        private ValidateAddressResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ValidateAddressResponse();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ValidateAddressResponse
        /// </summary>
        [Test]
        public void ValidateAddressResponseInstanceTest()
        {
            Assert.IsInstanceOf<ValidateAddressResponse> (instance, "instance is a ValidateAddressResponse");
        }

        
        /// <summary>
        /// Test the property 'Valid' 
        /// </summary>
        [Test]
        public void ValidTest()
        {
            // TODO: unit test for the property 'Valid' 
        }
        
        /// <summary>
        /// Test the property 'Response' 
        /// </summary>
        [Test]
        public void ResponseTest()
        {
            // TODO: unit test for the property 'Response' 
        }
        

    }

}
