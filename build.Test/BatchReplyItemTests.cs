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
    public class BatchReplyItemTests
    {
        private BatchReplyItem instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BatchReplyItem();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of BatchReplyItem
        /// </summary>
        [Test]
        public void BatchReplyItemInstanceTest()
        {
            Assert.IsInstanceOf<BatchReplyItem> (instance, "instance is a BatchReplyItem");
        }

        
        /// <summary>
        /// Test the property 'Code' 
        /// </summary>
        [Test]
        public void CodeTest()
        {
            // TODO: unit test for the property 'Code' 
        }
        
        /// <summary>
        /// Test the property 'Error' 
        /// </summary>
        [Test]
        public void ErrorTest()
        {
            // TODO: unit test for the property 'Error' 
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
