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
    public class WorkItemDetailsTests
    {
        private WorkItemDetails instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WorkItemDetails();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of WorkItemDetails
        /// </summary>
        [Test]
        public void WorkItemDetailsInstanceTest()
        {
            Assert.IsInstanceOf<WorkItemDetails> (instance, "instance is a WorkItemDetails");
        }

        
        /// <summary>
        /// Test the property 'Id' 
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id' 
        }
        
        /// <summary>
        /// Test the property 'Name' 
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name' 
        }
        
        /// <summary>
        /// Test the property 'WorkItemDefinition' 
        /// </summary>
        [Test]
        public void WorkItemDefinitionTest()
        {
            // TODO: unit test for the property 'WorkItemDefinition' 
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
        /// Test the property 'FlowCreateTime' 
        /// </summary>
        [Test]
        public void FlowCreateTimeTest()
        {
            // TODO: unit test for the property 'FlowCreateTime' 
        }
        
        /// <summary>
        /// Test the property 'CreateTime' 
        /// </summary>
        [Test]
        public void CreateTimeTest()
        {
            // TODO: unit test for the property 'CreateTime' 
        }
        
        /// <summary>
        /// Test the property 'Owner' 
        /// </summary>
        [Test]
        public void OwnerTest()
        {
            // TODO: unit test for the property 'Owner' 
        }
        
        /// <summary>
        /// Test the property 'OfferedToUsers' 
        /// </summary>
        [Test]
        public void OfferedToUsersTest()
        {
            // TODO: unit test for the property 'OfferedToUsers' 
        }
        
        /// <summary>
        /// Test the property 'OfferedToQueues' 
        /// </summary>
        [Test]
        public void OfferedToQueuesTest()
        {
            // TODO: unit test for the property 'OfferedToQueues' 
        }
        
        /// <summary>
        /// Test the property 'Title' 
        /// </summary>
        [Test]
        public void TitleTest()
        {
            // TODO: unit test for the property 'Title' 
        }
        
        /// <summary>
        /// Test the property 'Subtitle' 
        /// </summary>
        [Test]
        public void SubtitleTest()
        {
            // TODO: unit test for the property 'Subtitle' 
        }
        
        /// <summary>
        /// Test the property 'AssociatedDocuments' 
        /// </summary>
        [Test]
        public void AssociatedDocumentsTest()
        {
            // TODO: unit test for the property 'AssociatedDocuments' 
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
        /// Test the property 'DataValueInfo' 
        /// </summary>
        [Test]
        public void DataValueInfoTest()
        {
            // TODO: unit test for the property 'DataValueInfo' 
        }
        
        /// <summary>
        /// Test the property 'WorkItemCache' 
        /// </summary>
        [Test]
        public void WorkItemCacheTest()
        {
            // TODO: unit test for the property 'WorkItemCache' 
        }
        
        /// <summary>
        /// Test the property 'LastOfferedTime' 
        /// </summary>
        [Test]
        public void LastOfferedTimeTest()
        {
            // TODO: unit test for the property 'LastOfferedTime' 
        }
        
        /// <summary>
        /// Test the property 'LastOwnershipUpdateTime' 
        /// </summary>
        [Test]
        public void LastOwnershipUpdateTimeTest()
        {
            // TODO: unit test for the property 'LastOwnershipUpdateTime' 
        }
        
        /// <summary>
        /// Test the property 'CurrentTaskStartTime' 
        /// </summary>
        [Test]
        public void CurrentTaskStartTimeTest()
        {
            // TODO: unit test for the property 'CurrentTaskStartTime' 
        }
        
        /// <summary>
        /// Test the property 'SelfUri' 
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri' 
        }
        

    }

}
