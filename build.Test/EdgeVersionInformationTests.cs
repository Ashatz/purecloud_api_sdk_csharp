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
    public class EdgeVersionInformationTests
    {
        private EdgeVersionInformation instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EdgeVersionInformation();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of EdgeVersionInformation
        /// </summary>
        [Test]
        public void EdgeVersionInformationInstanceTest()
        {
            Assert.IsInstanceOf<EdgeVersionInformation> (instance, "instance is a EdgeVersionInformation");
        }

        
        /// <summary>
        /// Test the property 'SoftwareVersion' 
        /// </summary>
        [Test]
        public void SoftwareVersionTest()
        {
            // TODO: unit test for the property 'SoftwareVersion' 
        }
        

    }

}
