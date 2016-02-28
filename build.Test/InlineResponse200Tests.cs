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
    public class InlineResponse200Tests
    {
        private InlineResponse200 instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new InlineResponse200();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of InlineResponse200
        /// </summary>
        [Test]
        public void InlineResponse200InstanceTest()
        {
            Assert.IsInstanceOf<InlineResponse200> (instance, "instance is a InlineResponse200");
        }

        

    }

}
