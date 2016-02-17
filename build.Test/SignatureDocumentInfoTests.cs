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
    public class SignatureDocumentInfoTests
    {
        private SignatureDocumentInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SignatureDocumentInfo();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of SignatureDocumentInfo
        /// </summary>
        [Test]
        public void SignatureDocumentInfoInstanceTest()
        {
            Assert.IsInstanceOf<SignatureDocumentInfo> (instance, "instance is a SignatureDocumentInfo");
        }

        
        /// <summary>
        /// Test the property 'Org' 
        /// </summary>
        [Test]
        public void OrgTest()
        {
            // TODO: unit test for the property 'Org' 
        }
        
        /// <summary>
        /// Test the property 'User' 
        /// </summary>
        [Test]
        public void UserTest()
        {
            // TODO: unit test for the property 'User' 
        }
        
        /// <summary>
        /// Test the property 'ReturnUrl' 
        /// </summary>
        [Test]
        public void ReturnUrlTest()
        {
            // TODO: unit test for the property 'ReturnUrl' 
        }
        

    }

}
