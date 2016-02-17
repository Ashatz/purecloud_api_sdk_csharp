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
    public class PolicyErrorMessageTests
    {
        private PolicyErrorMessage instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PolicyErrorMessage();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of PolicyErrorMessage
        /// </summary>
        [Test]
        public void PolicyErrorMessageInstanceTest()
        {
            Assert.IsInstanceOf<PolicyErrorMessage> (instance, "instance is a PolicyErrorMessage");
        }

        
        /// <summary>
        /// Test the property 'StatusCode' 
        /// </summary>
        [Test]
        public void StatusCodeTest()
        {
            // TODO: unit test for the property 'StatusCode' 
        }
        
        /// <summary>
        /// Test the property 'UserMessage' 
        /// </summary>
        [Test]
        public void UserMessageTest()
        {
            // TODO: unit test for the property 'UserMessage' 
        }
        
        /// <summary>
        /// Test the property 'UserParamsMessage' 
        /// </summary>
        [Test]
        public void UserParamsMessageTest()
        {
            // TODO: unit test for the property 'UserParamsMessage' 
        }
        
        /// <summary>
        /// Test the property 'ErrorCode' 
        /// </summary>
        [Test]
        public void ErrorCodeTest()
        {
            // TODO: unit test for the property 'ErrorCode' 
        }
        
        /// <summary>
        /// Test the property 'CorrelationId' 
        /// </summary>
        [Test]
        public void CorrelationIdTest()
        {
            // TODO: unit test for the property 'CorrelationId' 
        }
        
        /// <summary>
        /// Test the property 'UserParams' 
        /// </summary>
        [Test]
        public void UserParamsTest()
        {
            // TODO: unit test for the property 'UserParams' 
        }
        
        /// <summary>
        /// Test the property 'InsertDate' 
        /// </summary>
        [Test]
        public void InsertDateTest()
        {
            // TODO: unit test for the property 'InsertDate' 
        }
        

    }

}
