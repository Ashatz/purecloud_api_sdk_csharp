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
    public class BasicTransformTests
    {
        private BasicTransform instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BasicTransform();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of BasicTransform
        /// </summary>
        [Test]
        public void BasicTransformInstanceTest()
        {
            Assert.IsInstanceOf<BasicTransform> (instance, "instance is a BasicTransform");
        }

        
        /// <summary>
        /// Test the property 'Replaces' 
        /// </summary>
        [Test]
        public void ReplacesTest()
        {
            // TODO: unit test for the property 'Replaces' 
        }
        
        /// <summary>
        /// Test the property 'EntityPath' 
        /// </summary>
        [Test]
        public void EntityPathTest()
        {
            // TODO: unit test for the property 'EntityPath' 
        }
        

    }

}
