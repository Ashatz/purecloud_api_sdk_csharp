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
    public class OktaTests
    {
        private Okta instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Okta();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Okta
        /// </summary>
        [Test]
        public void OktaInstanceTest()
        {
            Assert.IsInstanceOf<Okta> (instance, "instance is a Okta");
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
