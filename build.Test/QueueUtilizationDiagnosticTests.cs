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
    public class QueueUtilizationDiagnosticTests
    {
        private QueueUtilizationDiagnostic instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new QueueUtilizationDiagnostic();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of QueueUtilizationDiagnostic
        /// </summary>
        [Test]
        public void QueueUtilizationDiagnosticInstanceTest()
        {
            Assert.IsInstanceOf<QueueUtilizationDiagnostic> (instance, "instance is a QueueUtilizationDiagnostic");
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
        /// Test the property 'UsersInQueue' 
        /// </summary>
        [Test]
        public void UsersInQueueTest()
        {
            // TODO: unit test for the property 'UsersInQueue' 
        }
        
        /// <summary>
        /// Test the property 'ActiveUsersInQueue' 
        /// </summary>
        [Test]
        public void ActiveUsersInQueueTest()
        {
            // TODO: unit test for the property 'ActiveUsersInQueue' 
        }
        
        /// <summary>
        /// Test the property 'UsersOnQueue' 
        /// </summary>
        [Test]
        public void UsersOnQueueTest()
        {
            // TODO: unit test for the property 'UsersOnQueue' 
        }
        
        /// <summary>
        /// Test the property 'UsersNotUtilized' 
        /// </summary>
        [Test]
        public void UsersNotUtilizedTest()
        {
            // TODO: unit test for the property 'UsersNotUtilized' 
        }
        
        /// <summary>
        /// Test the property 'UsersOnQueueWithStation' 
        /// </summary>
        [Test]
        public void UsersOnQueueWithStationTest()
        {
            // TODO: unit test for the property 'UsersOnQueueWithStation' 
        }
        
        /// <summary>
        /// Test the property 'UsersOnACampaignCall' 
        /// </summary>
        [Test]
        public void UsersOnACampaignCallTest()
        {
            // TODO: unit test for the property 'UsersOnACampaignCall' 
        }
        
        /// <summary>
        /// Test the property 'UsersOnANonCampaignCall' 
        /// </summary>
        [Test]
        public void UsersOnANonCampaignCallTest()
        {
            // TODO: unit test for the property 'UsersOnANonCampaignCall' 
        }
        

    }

}
