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
    public class WorkItemCacheTests
    {
        private WorkItemCache instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WorkItemCache();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of WorkItemCache
        /// </summary>
        [Test]
        public void WorkItemCacheInstanceTest()
        {
            Assert.IsInstanceOf<WorkItemCache> (instance, "instance is a WorkItemCache");
        }

        
        /// <summary>
        /// Test the property 'WorkItemExecId' 
        /// </summary>
        [Test]
        public void WorkItemExecIdTest()
        {
            // TODO: unit test for the property 'WorkItemExecId' 
        }
        
        /// <summary>
        /// Test the property 'SaveTime' 
        /// </summary>
        [Test]
        public void SaveTimeTest()
        {
            // TODO: unit test for the property 'SaveTime' 
        }
        
        /// <summary>
        /// Test the property 'SaveUser' 
        /// </summary>
        [Test]
        public void SaveUserTest()
        {
            // TODO: unit test for the property 'SaveUser' 
        }
        
        /// <summary>
        /// Test the property 'SaveComment' 
        /// </summary>
        [Test]
        public void SaveCommentTest()
        {
            // TODO: unit test for the property 'SaveComment' 
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
