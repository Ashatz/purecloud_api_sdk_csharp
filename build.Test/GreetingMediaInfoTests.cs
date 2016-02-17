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
    public class GreetingMediaInfoTests
    {
        private GreetingMediaInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GreetingMediaInfo();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of GreetingMediaInfo
        /// </summary>
        [Test]
        public void GreetingMediaInfoInstanceTest()
        {
            Assert.IsInstanceOf<GreetingMediaInfo> (instance, "instance is a GreetingMediaInfo");
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
        /// Test the property 'MediaFileUri' 
        /// </summary>
        [Test]
        public void MediaFileUriTest()
        {
            // TODO: unit test for the property 'MediaFileUri' 
        }
        
        /// <summary>
        /// Test the property 'MediaImageUri' 
        /// </summary>
        [Test]
        public void MediaImageUriTest()
        {
            // TODO: unit test for the property 'MediaImageUri' 
        }
        

    }

}
