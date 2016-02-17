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
    public class UrlResponseTests
    {
        private UrlResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UrlResponse();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of UrlResponse
        /// </summary>
        [Test]
        public void UrlResponseInstanceTest()
        {
            Assert.IsInstanceOf<UrlResponse> (instance, "instance is a UrlResponse");
        }

        
        /// <summary>
        /// Test the property 'Url' 
        /// </summary>
        [Test]
        public void UrlTest()
        {
            // TODO: unit test for the property 'Url' 
        }
        

    }

}
