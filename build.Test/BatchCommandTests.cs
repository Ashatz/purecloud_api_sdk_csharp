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
    public class BatchCommandTests
    {
        private BatchCommand instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BatchCommand();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of BatchCommand
        /// </summary>
        [Test]
        public void BatchCommandInstanceTest()
        {
            Assert.IsInstanceOf<BatchCommand> (instance, "instance is a BatchCommand");
        }

        
        /// <summary>
        /// Test the property 'Items' 
        /// </summary>
        [Test]
        public void ItemsTest()
        {
            // TODO: unit test for the property 'Items' 
        }
        
        /// <summary>
        /// Test the property 'CommandId' 
        /// </summary>
        [Test]
        public void CommandIdTest()
        {
            // TODO: unit test for the property 'CommandId' 
        }
        

    }

}
