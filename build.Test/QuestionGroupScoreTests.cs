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
    public class QuestionGroupScoreTests
    {
        private QuestionGroupScore instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new QuestionGroupScore();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of QuestionGroupScore
        /// </summary>
        [Test]
        public void QuestionGroupScoreInstanceTest()
        {
            Assert.IsInstanceOf<QuestionGroupScore> (instance, "instance is a QuestionGroupScore");
        }

        
        /// <summary>
        /// Test the property 'QuestionGroupId' 
        /// </summary>
        [Test]
        public void QuestionGroupIdTest()
        {
            // TODO: unit test for the property 'QuestionGroupId' 
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
        /// Test the property 'MaxTotalScore' 
        /// </summary>
        [Test]
        public void MaxTotalScoreTest()
        {
            // TODO: unit test for the property 'MaxTotalScore' 
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
        /// Test the property 'MaxTotalCriticalScore' 
        /// </summary>
        [Test]
        public void MaxTotalCriticalScoreTest()
        {
            // TODO: unit test for the property 'MaxTotalCriticalScore' 
        }
        
        /// <summary>
        /// Test the property 'TotalScoreUnweighted' 
        /// </summary>
        [Test]
        public void TotalScoreUnweightedTest()
        {
            // TODO: unit test for the property 'TotalScoreUnweighted' 
        }
        
        /// <summary>
        /// Test the property 'MaxTotalScoreUnweighted' 
        /// </summary>
        [Test]
        public void MaxTotalScoreUnweightedTest()
        {
            // TODO: unit test for the property 'MaxTotalScoreUnweighted' 
        }
        
        /// <summary>
        /// Test the property 'TotalCriticalScoreUnweighted' 
        /// </summary>
        [Test]
        public void TotalCriticalScoreUnweightedTest()
        {
            // TODO: unit test for the property 'TotalCriticalScoreUnweighted' 
        }
        
        /// <summary>
        /// Test the property 'MaxTotalCriticalScoreUnweighted' 
        /// </summary>
        [Test]
        public void MaxTotalCriticalScoreUnweightedTest()
        {
            // TODO: unit test for the property 'MaxTotalCriticalScoreUnweighted' 
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
        /// Test the property 'QuestionScores' 
        /// </summary>
        [Test]
        public void QuestionScoresTest()
        {
            // TODO: unit test for the property 'QuestionScores' 
        }
        

    }

}
