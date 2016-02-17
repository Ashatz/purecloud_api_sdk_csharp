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
    public class CertificateDetailsTests
    {
        private CertificateDetails instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CertificateDetails();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of CertificateDetails
        /// </summary>
        [Test]
        public void CertificateDetailsInstanceTest()
        {
            Assert.IsInstanceOf<CertificateDetails> (instance, "instance is a CertificateDetails");
        }

        
        /// <summary>
        /// Test the property 'Issuer' 
        /// </summary>
        [Test]
        public void IssuerTest()
        {
            // TODO: unit test for the property 'Issuer' 
        }
        
        /// <summary>
        /// Test the property 'Subject' 
        /// </summary>
        [Test]
        public void SubjectTest()
        {
            // TODO: unit test for the property 'Subject' 
        }
        
        /// <summary>
        /// Test the property 'ExpirationDate' 
        /// </summary>
        [Test]
        public void ExpirationDateTest()
        {
            // TODO: unit test for the property 'ExpirationDate' 
        }
        
        /// <summary>
        /// Test the property 'IssueDate' 
        /// </summary>
        [Test]
        public void IssueDateTest()
        {
            // TODO: unit test for the property 'IssueDate' 
        }
        
        /// <summary>
        /// Test the property 'Expired' 
        /// </summary>
        [Test]
        public void ExpiredTest()
        {
            // TODO: unit test for the property 'Expired' 
        }
        
        /// <summary>
        /// Test the property 'SignatureValid' 
        /// </summary>
        [Test]
        public void SignatureValidTest()
        {
            // TODO: unit test for the property 'SignatureValid' 
        }
        
        /// <summary>
        /// Test the property 'Valid' 
        /// </summary>
        [Test]
        public void ValidTest()
        {
            // TODO: unit test for the property 'Valid' 
        }
        

    }

}
