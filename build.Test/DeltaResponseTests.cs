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
    public class DeltaResponseTests
    {
        private DeltaResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DeltaResponse();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DeltaResponse
        /// </summary>
        [Test]
        public void DeltaResponseInstanceTest()
        {
            Assert.IsInstanceOf<DeltaResponse> (instance, "instance is a DeltaResponse");
        }

        
        /// <summary>
        /// Test the property 'ContextToken' 
        /// </summary>
        [Test]
        public void ContextTokenTest()
        {
            // TODO: unit test for the property 'ContextToken' 
        }
        
        /// <summary>
        /// Test the property 'Documents' 
        /// </summary>
        [Test]
        public void DocumentsTest()
        {
            // TODO: unit test for the property 'Documents' 
        }
        
        /// <summary>
        /// Test the property 'HasMore' 
        /// </summary>
        [Test]
        public void HasMoreTest()
        {
            // TODO: unit test for the property 'HasMore' 
        }
        

    }

}
