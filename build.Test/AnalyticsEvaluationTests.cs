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
    /// <summary>
    ///  Class for testing AnalyticsEvaluation
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AnalyticsEvaluationTests
    {
        private AnalyticsEvaluation instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AnalyticsEvaluation();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AnalyticsEvaluation
        /// </summary>
        [Test]
        public void AnalyticsEvaluationInstanceTest()
        {
            Assert.IsInstanceOf<AnalyticsEvaluation> (instance, "instance is a AnalyticsEvaluation");
        }

        /// <summary>
        /// Test the property 'EvaluationId'
        /// </summary>
        [Test]
        public void EvaluationIdTest()
        {
            // TODO: unit test for the property 'EvaluationId'
        }
        /// <summary>
        /// Test the property 'EvaluatorId'
        /// </summary>
        [Test]
        public void EvaluatorIdTest()
        {
            // TODO: unit test for the property 'EvaluatorId'
        }
        /// <summary>
        /// Test the property 'UserId'
        /// </summary>
        [Test]
        public void UserIdTest()
        {
            // TODO: unit test for the property 'UserId'
        }
        /// <summary>
        /// Test the property 'EventTime'
        /// </summary>
        [Test]
        public void EventTimeTest()
        {
            // TODO: unit test for the property 'EventTime'
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
        /// Test the property 'FormId'
        /// </summary>
        [Test]
        public void FormIdTest()
        {
            // TODO: unit test for the property 'FormId'
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
        /// Test the property 'FormName'
        /// </summary>
        [Test]
        public void FormNameTest()
        {
            // TODO: unit test for the property 'FormName'
        }
        /// <summary>
        /// Test the property 'GetoTotalScore'
        /// </summary>
        [Test]
        public void GetoTotalScoreTest()
        {
            // TODO: unit test for the property 'GetoTotalScore'
        }
        /// <summary>
        /// Test the property 'GetoTotalCriticalScore'
        /// </summary>
        [Test]
        public void GetoTotalCriticalScoreTest()
        {
            // TODO: unit test for the property 'GetoTotalCriticalScore'
        }

    }

}
