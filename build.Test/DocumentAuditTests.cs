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
    public class DocumentAuditTests
    {
        private DocumentAudit instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DocumentAudit();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DocumentAudit
        /// </summary>
        [Test]
        public void DocumentAuditInstanceTest()
        {
            Assert.IsInstanceOf<DocumentAudit> (instance, "instance is a DocumentAudit");
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
        /// Test the property 'User' 
        /// </summary>
        [Test]
        public void UserTest()
        {
            // TODO: unit test for the property 'User' 
        }
        
        /// <summary>
        /// Test the property 'Workspace' 
        /// </summary>
        [Test]
        public void WorkspaceTest()
        {
            // TODO: unit test for the property 'Workspace' 
        }
        
        /// <summary>
        /// Test the property 'TransactionId' 
        /// </summary>
        [Test]
        public void TransactionIdTest()
        {
            // TODO: unit test for the property 'TransactionId' 
        }
        
        /// <summary>
        /// Test the property 'TransactionInitiator' 
        /// </summary>
        [Test]
        public void TransactionInitiatorTest()
        {
            // TODO: unit test for the property 'TransactionInitiator' 
        }
        
        /// <summary>
        /// Test the property 'Application' 
        /// </summary>
        [Test]
        public void ApplicationTest()
        {
            // TODO: unit test for the property 'Application' 
        }
        
        /// <summary>
        /// Test the property 'ServiceName' 
        /// </summary>
        [Test]
        public void ServiceNameTest()
        {
            // TODO: unit test for the property 'ServiceName' 
        }
        
        /// <summary>
        /// Test the property 'Level' 
        /// </summary>
        [Test]
        public void LevelTest()
        {
            // TODO: unit test for the property 'Level' 
        }
        
        /// <summary>
        /// Test the property 'Timestamp' 
        /// </summary>
        [Test]
        public void TimestampTest()
        {
            // TODO: unit test for the property 'Timestamp' 
        }
        
        /// <summary>
        /// Test the property 'Status' 
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO: unit test for the property 'Status' 
        }
        
        /// <summary>
        /// Test the property 'ActionContext' 
        /// </summary>
        [Test]
        public void ActionContextTest()
        {
            // TODO: unit test for the property 'ActionContext' 
        }
        
        /// <summary>
        /// Test the property 'Action' 
        /// </summary>
        [Test]
        public void ActionTest()
        {
            // TODO: unit test for the property 'Action' 
        }
        
        /// <summary>
        /// Test the property 'Entity' 
        /// </summary>
        [Test]
        public void EntityTest()
        {
            // TODO: unit test for the property 'Entity' 
        }
        
        /// <summary>
        /// Test the property 'Changes' 
        /// </summary>
        [Test]
        public void ChangesTest()
        {
            // TODO: unit test for the property 'Changes' 
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
