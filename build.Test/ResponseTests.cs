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
    public class ResponseTests
    {
        private Response instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Response();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Response
        /// </summary>
        [Test]
        public void ResponseInstanceTest()
        {
            Assert.IsInstanceOf<Response> (instance, "instance is a Response");
        }

        
        /// <summary>
        /// Test the property 'MessageReturned' 
        /// </summary>
        [Test]
        public void MessageReturnedTest()
        {
            // TODO: unit test for the property 'MessageReturned' 
        }
        
        /// <summary>
        /// Test the property 'Status' 
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO: unit test for the property 'Status' 
        }
        

    }

}
