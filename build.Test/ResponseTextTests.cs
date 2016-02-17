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
    public class ResponseTextTests
    {
        private ResponseText instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ResponseText();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ResponseText
        /// </summary>
        [Test]
        public void ResponseTextInstanceTest()
        {
            Assert.IsInstanceOf<ResponseText> (instance, "instance is a ResponseText");
        }

        
        /// <summary>
        /// Test the property 'Content' 
        /// </summary>
        [Test]
        public void ContentTest()
        {
            // TODO: unit test for the property 'Content' 
        }
        
        /// <summary>
        /// Test the property 'ContentType' 
        /// </summary>
        [Test]
        public void ContentTypeTest()
        {
            // TODO: unit test for the property 'ContentType' 
        }
        

    }

}
