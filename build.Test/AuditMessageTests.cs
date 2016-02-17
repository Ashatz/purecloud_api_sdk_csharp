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
    public class AuditMessageTests
    {
        private AuditMessage instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AuditMessage();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of AuditMessage
        /// </summary>
        [Test]
        public void AuditMessageInstanceTest()
        {
            Assert.IsInstanceOf<AuditMessage> (instance, "instance is a AuditMessage");
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
        /// Test the property 'User' 
        /// </summary>
        [Test]
        public void UserTest()
        {
            // TODO: unit test for the property 'User' 
        }
        
        /// <summary>
        /// Test the property 'CorrelationId' 
        /// </summary>
        [Test]
        public void CorrelationIdTest()
        {
            // TODO: unit test for the property 'CorrelationId' 
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
        /// Test the property 'ReceivedTimestamp' 
        /// </summary>
        [Test]
        public void ReceivedTimestampTest()
        {
            // TODO: unit test for the property 'ReceivedTimestamp' 
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
        /// Test the property 'Changes' 
        /// </summary>
        [Test]
        public void ChangesTest()
        {
            // TODO: unit test for the property 'Changes' 
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
        /// Test the property 'ServiceContext' 
        /// </summary>
        [Test]
        public void ServiceContextTest()
        {
            // TODO: unit test for the property 'ServiceContext' 
        }
        

    }

}
