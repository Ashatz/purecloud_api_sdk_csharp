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
    public class ReplaceRequestTests
    {
        private ReplaceRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ReplaceRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ReplaceRequest
        /// </summary>
        [Test]
        public void ReplaceRequestInstanceTest()
        {
            Assert.IsInstanceOf<ReplaceRequest> (instance, "instance is a ReplaceRequest");
        }

        
        /// <summary>
        /// Test the property 'ChangeNumber' 
        /// </summary>
        [Test]
        public void ChangeNumberTest()
        {
            // TODO: unit test for the property 'ChangeNumber' 
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
        /// Test the property 'AuthToken' 
        /// </summary>
        [Test]
        public void AuthTokenTest()
        {
            // TODO: unit test for the property 'AuthToken' 
        }
        

    }

}
