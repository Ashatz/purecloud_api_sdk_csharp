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
    public class FlowHistoryItemTests
    {
        private FlowHistoryItem instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FlowHistoryItem();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FlowHistoryItem
        /// </summary>
        [Test]
        public void FlowHistoryItemInstanceTest()
        {
            Assert.IsInstanceOf<FlowHistoryItem> (instance, "instance is a FlowHistoryItem");
        }

        
        /// <summary>
        /// Test the property 'HistoryEventTime' 
        /// </summary>
        [Test]
        public void HistoryEventTimeTest()
        {
            // TODO: unit test for the property 'HistoryEventTime' 
        }
        
        /// <summary>
        /// Test the property 'State' 
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO: unit test for the property 'State' 
        }
        
        /// <summary>
        /// Test the property 'WorkItem' 
        /// </summary>
        [Test]
        public void WorkItemTest()
        {
            // TODO: unit test for the property 'WorkItem' 
        }
        
        /// <summary>
        /// Test the property 'User' 
        /// </summary>
        [Test]
        public void UserTest()
        {
            // TODO: unit test for the property 'User' 
        }
        
        /// <summary>
        /// Test the property 'Queue' 
        /// </summary>
        [Test]
        public void QueueTest()
        {
            // TODO: unit test for the property 'Queue' 
        }
        
        /// <summary>
        /// Test the property 'HistoryEventData' 
        /// </summary>
        [Test]
        public void HistoryEventDataTest()
        {
            // TODO: unit test for the property 'HistoryEventData' 
        }
        
        /// <summary>
        /// Test the property 'HistoryEventType' 
        /// </summary>
        [Test]
        public void HistoryEventTypeTest()
        {
            // TODO: unit test for the property 'HistoryEventType' 
        }
        
        /// <summary>
        /// Test the property 'Success' 
        /// </summary>
        [Test]
        public void SuccessTest()
        {
            // TODO: unit test for the property 'Success' 
        }
        

    }

}
