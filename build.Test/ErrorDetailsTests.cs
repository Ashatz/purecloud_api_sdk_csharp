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
    public class ErrorDetailsTests
    {
        private ErrorDetails instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ErrorDetails();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ErrorDetails
        /// </summary>
        [Test]
        public void ErrorDetailsInstanceTest()
        {
            Assert.IsInstanceOf<ErrorDetails> (instance, "instance is a ErrorDetails");
        }

        
        /// <summary>
        /// Test the property 'Status' 
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO: unit test for the property 'Status' 
        }
        
        /// <summary>
        /// Test the property 'Message' 
        /// </summary>
        [Test]
        public void MessageTest()
        {
            // TODO: unit test for the property 'Message' 
        }
        
        /// <summary>
        /// Test the property 'MessageWithParams' 
        /// </summary>
        [Test]
        public void MessageWithParamsTest()
        {
            // TODO: unit test for the property 'MessageWithParams' 
        }
        
        /// <summary>
        /// Test the property 'MessageParams' 
        /// </summary>
        [Test]
        public void MessageParamsTest()
        {
            // TODO: unit test for the property 'MessageParams' 
        }
        
        /// <summary>
        /// Test the property 'Code' 
        /// </summary>
        [Test]
        public void CodeTest()
        {
            // TODO: unit test for the property 'Code' 
        }
        
        /// <summary>
        /// Test the property 'ContextId' 
        /// </summary>
        [Test]
        public void ContextIdTest()
        {
            // TODO: unit test for the property 'ContextId' 
        }
        
        /// <summary>
        /// Test the property 'Nested' 
        /// </summary>
        [Test]
        public void NestedTest()
        {
            // TODO: unit test for the property 'Nested' 
        }
        
        /// <summary>
        /// Test the property 'Details' 
        /// </summary>
        [Test]
        public void DetailsTest()
        {
            // TODO: unit test for the property 'Details' 
        }
        

    }

}
