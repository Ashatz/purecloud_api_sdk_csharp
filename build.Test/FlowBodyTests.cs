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
    public class FlowBodyTests
    {
        private FlowBody instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FlowBody();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FlowBody
        /// </summary>
        [Test]
        public void FlowBodyInstanceTest()
        {
            Assert.IsInstanceOf<FlowBody> (instance, "instance is a FlowBody");
        }

        
        /// <summary>
        /// Test the property 'Format' 
        /// </summary>
        [Test]
        public void FormatTest()
        {
            // TODO: unit test for the property 'Format' 
        }
        
        /// <summary>
        /// Test the property 'Body' 
        /// </summary>
        [Test]
        public void BodyTest()
        {
            // TODO: unit test for the property 'Body' 
        }
        

    }

}
