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
    public class EdgeVersionReportTests
    {
        private EdgeVersionReport instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EdgeVersionReport();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of EdgeVersionReport
        /// </summary>
        [Test]
        public void EdgeVersionReportInstanceTest()
        {
            Assert.IsInstanceOf<EdgeVersionReport> (instance, "instance is a EdgeVersionReport");
        }

        
        /// <summary>
        /// Test the property 'OldestVersion' 
        /// </summary>
        [Test]
        public void OldestVersionTest()
        {
            // TODO: unit test for the property 'OldestVersion' 
        }
        
        /// <summary>
        /// Test the property 'NewestVersion' 
        /// </summary>
        [Test]
        public void NewestVersionTest()
        {
            // TODO: unit test for the property 'NewestVersion' 
        }
        

    }

}