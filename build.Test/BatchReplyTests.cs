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
    public class BatchReplyTests
    {
        private BatchReply instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BatchReply();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of BatchReply
        /// </summary>
        [Test]
        public void BatchReplyInstanceTest()
        {
            Assert.IsInstanceOf<BatchReply> (instance, "instance is a BatchReply");
        }

        
        /// <summary>
        /// Test the property 'Items' 
        /// </summary>
        [Test]
        public void ItemsTest()
        {
            // TODO: unit test for the property 'Items' 
        }
        

    }

}
