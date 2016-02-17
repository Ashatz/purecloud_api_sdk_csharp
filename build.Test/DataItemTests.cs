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
    public class DataItemTests
    {
        private DataItem instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DataItem();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DataItem
        /// </summary>
        [Test]
        public void DataItemInstanceTest()
        {
            Assert.IsInstanceOf<DataItem> (instance, "instance is a DataItem");
        }

        
        /// <summary>
        /// Test the property 'ParameterName' 
        /// </summary>
        [Test]
        public void ParameterNameTest()
        {
            // TODO: unit test for the property 'ParameterName' 
        }
        
        /// <summary>
        /// Test the property 'ParameterType' 
        /// </summary>
        [Test]
        public void ParameterTypeTest()
        {
            // TODO: unit test for the property 'ParameterType' 
        }
        
        /// <summary>
        /// Test the property 'ParameterValues' 
        /// </summary>
        [Test]
        public void ParameterValuesTest()
        {
            // TODO: unit test for the property 'ParameterValues' 
        }
        

    }

}