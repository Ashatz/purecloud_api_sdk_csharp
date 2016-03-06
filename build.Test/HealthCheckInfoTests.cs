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
    public class HealthCheckInfoTests
    {
        private HealthCheckInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new HealthCheckInfo();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of HealthCheckInfo
        /// </summary>
        [Test]
        public void HealthCheckInfoInstanceTest()
        {
            Assert.IsInstanceOf<HealthCheckInfo> (instance, "instance is a HealthCheckInfo");
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
        /// Test the property 'SelfUri' 
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri' 
        }
        
        /// <summary>
        /// Test the property 'BuildTime' 
        /// </summary>
        [Test]
        public void BuildTimeTest()
        {
            // TODO: unit test for the property 'BuildTime' 
        }
        
        /// <summary>
        /// Test the property 'BuildVersion' 
        /// </summary>
        [Test]
        public void BuildVersionTest()
        {
            // TODO: unit test for the property 'BuildVersion' 
        }
        
        /// <summary>
        /// Test the property 'BuildJdk' 
        /// </summary>
        [Test]
        public void BuildJdkTest()
        {
            // TODO: unit test for the property 'BuildJdk' 
        }
        
        /// <summary>
        /// Test the property 'BuiltBy' 
        /// </summary>
        [Test]
        public void BuiltByTest()
        {
            // TODO: unit test for the property 'BuiltBy' 
        }
        
        /// <summary>
        /// Test the property 'ImplementationBuild' 
        /// </summary>
        [Test]
        public void ImplementationBuildTest()
        {
            // TODO: unit test for the property 'ImplementationBuild' 
        }
        
        /// <summary>
        /// Test the property 'ImplementationVersion' 
        /// </summary>
        [Test]
        public void ImplementationVersionTest()
        {
            // TODO: unit test for the property 'ImplementationVersion' 
        }
        
        /// <summary>
        /// Test the property 'Status' 
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO: unit test for the property 'Status' 
        }
        
        /// <summary>
        /// Test the property 'PingMs' 
        /// </summary>
        [Test]
        public void PingMsTest()
        {
            // TODO: unit test for the property 'PingMs' 
        }
        
        /// <summary>
        /// Test the property 'Date' 
        /// </summary>
        [Test]
        public void DateTest()
        {
            // TODO: unit test for the property 'Date' 
        }
        

    }

}
