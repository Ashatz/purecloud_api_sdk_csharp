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
    public class PolicyActionsTests
    {
        private PolicyActions instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PolicyActions();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of PolicyActions
        /// </summary>
        [Test]
        public void PolicyActionsInstanceTest()
        {
            Assert.IsInstanceOf<PolicyActions> (instance, "instance is a PolicyActions");
        }

        
        /// <summary>
        /// Test the property 'RetainRecording' 
        /// </summary>
        [Test]
        public void RetainRecordingTest()
        {
            // TODO: unit test for the property 'RetainRecording' 
        }
        
        /// <summary>
        /// Test the property 'DeleteRecording' 
        /// </summary>
        [Test]
        public void DeleteRecordingTest()
        {
            // TODO: unit test for the property 'DeleteRecording' 
        }
        
        /// <summary>
        /// Test the property 'AssignEvaluations' 
        /// </summary>
        [Test]
        public void AssignEvaluationsTest()
        {
            // TODO: unit test for the property 'AssignEvaluations' 
        }
        
        /// <summary>
        /// Test the property 'AssignMeteredEvaluations' 
        /// </summary>
        [Test]
        public void AssignMeteredEvaluationsTest()
        {
            // TODO: unit test for the property 'AssignMeteredEvaluations' 
        }
        
        /// <summary>
        /// Test the property 'AssignCalibrations' 
        /// </summary>
        [Test]
        public void AssignCalibrationsTest()
        {
            // TODO: unit test for the property 'AssignCalibrations' 
        }
        
        /// <summary>
        /// Test the property 'RetentionDuration' 
        /// </summary>
        [Test]
        public void RetentionDurationTest()
        {
            // TODO: unit test for the property 'RetentionDuration' 
        }
        

    }

}
