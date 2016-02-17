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
    public class CertificateTests
    {
        private Certificate instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Certificate();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Certificate
        /// </summary>
        [Test]
        public void CertificateInstanceTest()
        {
            Assert.IsInstanceOf<Certificate> (instance, "instance is a Certificate");
        }

        
        /// <summary>
        /// Test the property '_Certificate' 
        /// </summary>
        [Test]
        public void _CertificateTest()
        {
            // TODO: unit test for the property '_Certificate' 
        }
        

    }

}
