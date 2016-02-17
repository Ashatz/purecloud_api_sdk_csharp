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
    public class QuestionScoreTests
    {
        private QuestionScore instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new QuestionScore();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of QuestionScore
        /// </summary>
        [Test]
        public void QuestionScoreInstanceTest()
        {
            Assert.IsInstanceOf<QuestionScore> (instance, "instance is a QuestionScore");
        }

        
        /// <summary>
        /// Test the property 'QuestionId' 
        /// </summary>
        [Test]
        public void QuestionIdTest()
        {
            // TODO: unit test for the property 'QuestionId' 
        }
        
        /// <summary>
        /// Test the property 'AnswerId' 
        /// </summary>
        [Test]
        public void AnswerIdTest()
        {
            // TODO: unit test for the property 'AnswerId' 
        }
        
        /// <summary>
        /// Test the property 'Score' 
        /// </summary>
        [Test]
        public void ScoreTest()
        {
            // TODO: unit test for the property 'Score' 
        }
        
        /// <summary>
        /// Test the property 'MarkedNA' 
        /// </summary>
        [Test]
        public void MarkedNATest()
        {
            // TODO: unit test for the property 'MarkedNA' 
        }
        
        /// <summary>
        /// Test the property 'FailedKillQuestion' 
        /// </summary>
        [Test]
        public void FailedKillQuestionTest()
        {
            // TODO: unit test for the property 'FailedKillQuestion' 
        }
        
        /// <summary>
        /// Test the property 'Comments' 
        /// </summary>
        [Test]
        public void CommentsTest()
        {
            // TODO: unit test for the property 'Comments' 
        }
        

    }

}
