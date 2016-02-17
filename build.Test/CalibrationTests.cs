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
    public class CalibrationTests
    {
        private Calibration instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Calibration();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Calibration
        /// </summary>
        [Test]
        public void CalibrationInstanceTest()
        {
            Assert.IsInstanceOf<Calibration> (instance, "instance is a Calibration");
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
        /// Test the property 'Calibrator' 
        /// </summary>
        [Test]
        public void CalibratorTest()
        {
            // TODO: unit test for the property 'Calibrator' 
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
        /// Test the property 'ContextId' 
        /// </summary>
        [Test]
        public void ContextIdTest()
        {
            // TODO: unit test for the property 'ContextId' 
        }
        
        /// <summary>
        /// Test the property 'AverageScore' 
        /// </summary>
        [Test]
        public void AverageScoreTest()
        {
            // TODO: unit test for the property 'AverageScore' 
        }
        
        /// <summary>
        /// Test the property 'HighScore' 
        /// </summary>
        [Test]
        public void HighScoreTest()
        {
            // TODO: unit test for the property 'HighScore' 
        }
        
        /// <summary>
        /// Test the property 'LowScore' 
        /// </summary>
        [Test]
        public void LowScoreTest()
        {
            // TODO: unit test for the property 'LowScore' 
        }
        
        /// <summary>
        /// Test the property 'CreatedDate' 
        /// </summary>
        [Test]
        public void CreatedDateTest()
        {
            // TODO: unit test for the property 'CreatedDate' 
        }
        
        /// <summary>
        /// Test the property 'Evaluations' 
        /// </summary>
        [Test]
        public void EvaluationsTest()
        {
            // TODO: unit test for the property 'Evaluations' 
        }
        
        /// <summary>
        /// Test the property 'Evaluators' 
        /// </summary>
        [Test]
        public void EvaluatorsTest()
        {
            // TODO: unit test for the property 'Evaluators' 
        }
        
        /// <summary>
        /// Test the property 'ScoringIndex' 
        /// </summary>
        [Test]
        public void ScoringIndexTest()
        {
            // TODO: unit test for the property 'ScoringIndex' 
        }
        
        /// <summary>
        /// Test the property 'ExpertEvaluator' 
        /// </summary>
        [Test]
        public void ExpertEvaluatorTest()
        {
            // TODO: unit test for the property 'ExpertEvaluator' 
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
