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
    public class EvaluationTests
    {
        private Evaluation instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Evaluation();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Evaluation
        /// </summary>
        [Test]
        public void EvaluationInstanceTest()
        {
            Assert.IsInstanceOf<Evaluation> (instance, "instance is a Evaluation");
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
        /// Test the property 'Conversation' 
        /// </summary>
        [Test]
        public void ConversationTest()
        {
            // TODO: unit test for the property 'Conversation' 
        }
        
        /// <summary>
        /// Test the property 'EvaluationForm' 
        /// </summary>
        [Test]
        public void EvaluationFormTest()
        {
            // TODO: unit test for the property 'EvaluationForm' 
        }
        
        /// <summary>
        /// Test the property 'Evaluator' 
        /// </summary>
        [Test]
        public void EvaluatorTest()
        {
            // TODO: unit test for the property 'Evaluator' 
        }
        
        /// <summary>
        /// Test the property 'Agent' 
        /// </summary>
        [Test]
        public void AgentTest()
        {
            // TODO: unit test for the property 'Agent' 
        }
        
        /// <summary>
        /// Test the property 'Calibration' 
        /// </summary>
        [Test]
        public void CalibrationTest()
        {
            // TODO: unit test for the property 'Calibration' 
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
        /// Test the property 'Answers' 
        /// </summary>
        [Test]
        public void AnswersTest()
        {
            // TODO: unit test for the property 'Answers' 
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
        /// Test the property 'ReleaseDate' 
        /// </summary>
        [Test]
        public void ReleaseDateTest()
        {
            // TODO: unit test for the property 'ReleaseDate' 
        }
        
        /// <summary>
        /// Test the property 'AssignedDate' 
        /// </summary>
        [Test]
        public void AssignedDateTest()
        {
            // TODO: unit test for the property 'AssignedDate' 
        }
        
        /// <summary>
        /// Test the property 'ChangedDate' 
        /// </summary>
        [Test]
        public void ChangedDateTest()
        {
            // TODO: unit test for the property 'ChangedDate' 
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
        /// Test the property 'ResourceId' 
        /// </summary>
        [Test]
        public void ResourceIdTest()
        {
            // TODO: unit test for the property 'ResourceId' 
        }
        
        /// <summary>
        /// Test the property 'ResourceType' 
        /// </summary>
        [Test]
        public void ResourceTypeTest()
        {
            // TODO: unit test for the property 'ResourceType' 
        }
        
        /// <summary>
        /// Test the property 'Redacted' 
        /// </summary>
        [Test]
        public void RedactedTest()
        {
            // TODO: unit test for the property 'Redacted' 
        }
        
        /// <summary>
        /// Test the property 'IsScoringIndex' 
        /// </summary>
        [Test]
        public void IsScoringIndexTest()
        {
            // TODO: unit test for the property 'IsScoringIndex' 
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
