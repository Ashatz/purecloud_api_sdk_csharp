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
    public class ValueTests
    {
        private Value instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Value();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Value
        /// </summary>
        [Test]
        public void ValueInstanceTest()
        {
            Assert.IsInstanceOf<Value> (instance, "instance is a Value");
        }

        
        /// <summary>
        /// Test the property 'StringItems' 
        /// </summary>
        [Test]
        public void StringItemsTest()
        {
            // TODO: unit test for the property 'StringItems' 
        }
        
        /// <summary>
        /// Test the property 'IntegerItems' 
        /// </summary>
        [Test]
        public void IntegerItemsTest()
        {
            // TODO: unit test for the property 'IntegerItems' 
        }
        
        /// <summary>
        /// Test the property 'RealItems' 
        /// </summary>
        [Test]
        public void RealItemsTest()
        {
            // TODO: unit test for the property 'RealItems' 
        }
        
        /// <summary>
        /// Test the property 'DateItems' 
        /// </summary>
        [Test]
        public void DateItemsTest()
        {
            // TODO: unit test for the property 'DateItems' 
        }
        
        /// <summary>
        /// Test the property 'UserItems' 
        /// </summary>
        [Test]
        public void UserItemsTest()
        {
            // TODO: unit test for the property 'UserItems' 
        }
        
        /// <summary>
        /// Test the property 'QueueItems' 
        /// </summary>
        [Test]
        public void QueueItemsTest()
        {
            // TODO: unit test for the property 'QueueItems' 
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
