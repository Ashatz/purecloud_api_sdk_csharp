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
    public class OneLoginTests
    {
        private OneLogin instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OneLogin();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of OneLogin
        /// </summary>
        [Test]
        public void OneLoginInstanceTest()
        {
            Assert.IsInstanceOf<OneLogin> (instance, "instance is a OneLogin");
        }

        
        /// <summary>
        /// Test the property 'Id' 
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id' 
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
        /// Test the property 'Certificate' 
        /// </summary>
        [Test]
        public void CertificateTest()
        {
            // TODO: unit test for the property 'Certificate' 
        }
        
        /// <summary>
        /// Test the property 'IssuerURI' 
        /// </summary>
        [Test]
        public void IssuerURITest()
        {
            // TODO: unit test for the property 'IssuerURI' 
        }
        
        /// <summary>
        /// Test the property 'SsoTargetURI' 
        /// </summary>
        [Test]
        public void SsoTargetURITest()
        {
            // TODO: unit test for the property 'SsoTargetURI' 
        }
        
        /// <summary>
        /// Test the property 'SelfUri' 
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri' 
        }
        

    }

}
