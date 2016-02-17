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
    public class ParsedCertificateTests
    {
        private ParsedCertificate instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ParsedCertificate();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ParsedCertificate
        /// </summary>
        [Test]
        public void ParsedCertificateInstanceTest()
        {
            Assert.IsInstanceOf<ParsedCertificate> (instance, "instance is a ParsedCertificate");
        }

        
        /// <summary>
        /// Test the property 'CertificateDetails' 
        /// </summary>
        [Test]
        public void CertificateDetailsTest()
        {
            // TODO: unit test for the property 'CertificateDetails' 
        }
        

    }

}
