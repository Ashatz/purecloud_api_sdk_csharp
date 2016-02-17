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
    public class EvaluationQueryRequestTests
    {
        private EvaluationQueryRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EvaluationQueryRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of EvaluationQueryRequest
        /// </summary>
        [Test]
        public void EvaluationQueryRequestInstanceTest()
        {
            Assert.IsInstanceOf<EvaluationQueryRequest> (instance, "instance is a EvaluationQueryRequest");
        }

        
        /// <summary>
        /// Test the property 'ConversationId' 
        /// </summary>
        [Test]
        public void ConversationIdTest()
        {
            // TODO: unit test for the property 'ConversationId' 
        }
        
        /// <summary>
        /// Test the property 'UserType' 
        /// </summary>
        [Test]
        public void UserTypeTest()
        {
            // TODO: unit test for the property 'UserType' 
        }
        
        /// <summary>
        /// Test the property 'CurrentUserId' 
        /// </summary>
        [Test]
        public void CurrentUserIdTest()
        {
            // TODO: unit test for the property 'CurrentUserId' 
        }
        
        /// <summary>
        /// Test the property 'AgentId' 
        /// </summary>
        [Test]
        public void AgentIdTest()
        {
            // TODO: unit test for the property 'AgentId' 
        }
        
        /// <summary>
        /// Test the property 'QueueId' 
        /// </summary>
        [Test]
        public void QueueIdTest()
        {
            // TODO: unit test for the property 'QueueId' 
        }
        
        /// <summary>
        /// Test the property 'Interval' 
        /// </summary>
        [Test]
        public void IntervalTest()
        {
            // TODO: unit test for the property 'Interval' 
        }
        
        /// <summary>
        /// Test the property 'EvaluationState' 
        /// </summary>
        [Test]
        public void EvaluationStateTest()
        {
            // TODO: unit test for the property 'EvaluationState' 
        }
        
        /// <summary>
        /// Test the property 'IsReleased' 
        /// </summary>
        [Test]
        public void IsReleasedTest()
        {
            // TODO: unit test for the property 'IsReleased' 
        }
        
        /// <summary>
        /// Test the property 'AgentHasRead' 
        /// </summary>
        [Test]
        public void AgentHasReadTest()
        {
            // TODO: unit test for the property 'AgentHasRead' 
        }
        
        /// <summary>
        /// Test the property 'ExpandAnswerTotalScores' 
        /// </summary>
        [Test]
        public void ExpandAnswerTotalScoresTest()
        {
            // TODO: unit test for the property 'ExpandAnswerTotalScores' 
        }
        
        /// <summary>
        /// Test the property 'Maximum' 
        /// </summary>
        [Test]
        public void MaximumTest()
        {
            // TODO: unit test for the property 'Maximum' 
        }
        

    }

}
