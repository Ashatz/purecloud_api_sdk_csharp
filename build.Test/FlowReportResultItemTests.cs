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
    public class FlowReportResultItemTests
    {
        private FlowReportResultItem instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FlowReportResultItem();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FlowReportResultItem
        /// </summary>
        [Test]
        public void FlowReportResultItemInstanceTest()
        {
            Assert.IsInstanceOf<FlowReportResultItem> (instance, "instance is a FlowReportResultItem");
        }

        
        /// <summary>
        /// Test the property 'FlowExecId' 
        /// </summary>
        [Test]
        public void FlowExecIdTest()
        {
            // TODO: unit test for the property 'FlowExecId' 
        }
        
        /// <summary>
        /// Test the property 'FlowConfigId' 
        /// </summary>
        [Test]
        public void FlowConfigIdTest()
        {
            // TODO: unit test for the property 'FlowConfigId' 
        }
        
        /// <summary>
        /// Test the property 'FlowInstanceName' 
        /// </summary>
        [Test]
        public void FlowInstanceNameTest()
        {
            // TODO: unit test for the property 'FlowInstanceName' 
        }
        
        /// <summary>
        /// Test the property 'AssociatedDocument' 
        /// </summary>
        [Test]
        public void AssociatedDocumentTest()
        {
            // TODO: unit test for the property 'AssociatedDocument' 
        }
        
        /// <summary>
        /// Test the property 'FlowStatus' 
        /// </summary>
        [Test]
        public void FlowStatusTest()
        {
            // TODO: unit test for the property 'FlowStatus' 
        }
        
        /// <summary>
        /// Test the property 'CurrentState' 
        /// </summary>
        [Test]
        public void CurrentStateTest()
        {
            // TODO: unit test for the property 'CurrentState' 
        }
        
        /// <summary>
        /// Test the property 'StartDateTime' 
        /// </summary>
        [Test]
        public void StartDateTimeTest()
        {
            // TODO: unit test for the property 'StartDateTime' 
        }
        
        /// <summary>
        /// Test the property 'EndDateTime' 
        /// </summary>
        [Test]
        public void EndDateTimeTest()
        {
            // TODO: unit test for the property 'EndDateTime' 
        }
        
        /// <summary>
        /// Test the property 'WorkItemUserAssignees' 
        /// </summary>
        [Test]
        public void WorkItemUserAssigneesTest()
        {
            // TODO: unit test for the property 'WorkItemUserAssignees' 
        }
        
        /// <summary>
        /// Test the property 'CompletedUser' 
        /// </summary>
        [Test]
        public void CompletedUserTest()
        {
            // TODO: unit test for the property 'CompletedUser' 
        }
        
        /// <summary>
        /// Test the property 'CompletionReason' 
        /// </summary>
        [Test]
        public void CompletionReasonTest()
        {
            // TODO: unit test for the property 'CompletionReason' 
        }
        
        /// <summary>
        /// Test the property 'FlowErrorInfo' 
        /// </summary>
        [Test]
        public void FlowErrorInfoTest()
        {
            // TODO: unit test for the property 'FlowErrorInfo' 
        }
        

    }

}
