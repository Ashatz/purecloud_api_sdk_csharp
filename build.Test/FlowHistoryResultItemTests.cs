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
    public class FlowHistoryResultItemTests
    {
        private FlowHistoryResultItem instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FlowHistoryResultItem();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FlowHistoryResultItem
        /// </summary>
        [Test]
        public void FlowHistoryResultItemInstanceTest()
        {
            Assert.IsInstanceOf<FlowHistoryResultItem> (instance, "instance is a FlowHistoryResultItem");
        }

        
        /// <summary>
        /// Test the property 'FlowInstance' 
        /// </summary>
        [Test]
        public void FlowInstanceTest()
        {
            // TODO: unit test for the property 'FlowInstance' 
        }
        
        /// <summary>
        /// Test the property 'AvailableActions' 
        /// </summary>
        [Test]
        public void AvailableActionsTest()
        {
            // TODO: unit test for the property 'AvailableActions' 
        }
        
        /// <summary>
        /// Test the property 'HistoryItems' 
        /// </summary>
        [Test]
        public void HistoryItemsTest()
        {
            // TODO: unit test for the property 'HistoryItems' 
        }
        

    }

}
