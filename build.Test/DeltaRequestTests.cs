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
    public class DeltaRequestTests
    {
        private DeltaRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DeltaRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DeltaRequest
        /// </summary>
        [Test]
        public void DeltaRequestInstanceTest()
        {
            Assert.IsInstanceOf<DeltaRequest> (instance, "instance is a DeltaRequest");
        }

        
        /// <summary>
        /// Test the property 'ContextToken' 
        /// </summary>
        [Test]
        public void ContextTokenTest()
        {
            // TODO: unit test for the property 'ContextToken' 
        }
        

    }

}