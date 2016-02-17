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
    public class EvaluationScoringSetTests
    {
        private EvaluationScoringSet instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EvaluationScoringSet();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of EvaluationScoringSet
        /// </summary>
        [Test]
        public void EvaluationScoringSetInstanceTest()
        {
            Assert.IsInstanceOf<EvaluationScoringSet> (instance, "instance is a EvaluationScoringSet");
        }

        
        /// <summary>
        /// Test the property 'TotalScore' 
        /// </summary>
        [Test]
        public void TotalScoreTest()
        {
            // TODO: unit test for the property 'TotalScore' 
        }
        
        /// <summary>
        /// Test the property 'TotalCriticalScore' 
        /// </summary>
        [Test]
        public void TotalCriticalScoreTest()
        {
            // TODO: unit test for the property 'TotalCriticalScore' 
        }
        
        /// <summary>
        /// Test the property 'QuestionGroupScores' 
        /// </summary>
        [Test]
        public void QuestionGroupScoresTest()
        {
            // TODO: unit test for the property 'QuestionGroupScores' 
        }
        
        /// <summary>
        /// Test the property 'AnyFailedKillQuestions' 
        /// </summary>
        [Test]
        public void AnyFailedKillQuestionsTest()
        {
            // TODO: unit test for the property 'AnyFailedKillQuestions' 
        }
        
        /// <summary>
        /// Test the property 'Comments' 
        /// </summary>
        [Test]
        public void CommentsTest()
        {
            // TODO: unit test for the property 'Comments' 
        }
        
        /// <summary>
        /// Test the property 'AgentComments' 
        /// </summary>
        [Test]
        public void AgentCommentsTest()
        {
            // TODO: unit test for the property 'AgentComments' 
        }
        

    }

}
