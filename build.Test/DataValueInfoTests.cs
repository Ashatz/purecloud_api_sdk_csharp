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
    public class DataValueInfoTests
    {
        private DataValueInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DataValueInfo();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DataValueInfo
        /// </summary>
        [Test]
        public void DataValueInfoInstanceTest()
        {
            Assert.IsInstanceOf<DataValueInfo> (instance, "instance is a DataValueInfo");
        }

        
        /// <summary>
        /// Test the property 'DataItems' 
        /// </summary>
        [Test]
        public void DataItemsTest()
        {
            // TODO: unit test for the property 'DataItems' 
        }
        

    }

}
