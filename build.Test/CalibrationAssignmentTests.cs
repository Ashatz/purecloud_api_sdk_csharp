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
    ///  Class for testing CalibrationAssignment
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CalibrationAssignmentTests
    {
        private CalibrationAssignment instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CalibrationAssignment();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CalibrationAssignment
        /// </summary>
        [Test]
        public void CalibrationAssignmentInstanceTest()
        {
            Assert.IsInstanceOf<CalibrationAssignment> (instance, "instance is a CalibrationAssignment");
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
        /// Test the property 'Evaluators'
        /// </summary>
        [Test]
        public void EvaluatorsTest()
        {
            // TODO: unit test for the property 'Evaluators'
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
        /// Test the property 'ExpertEvaluator'
        /// </summary>
        [Test]
        public void ExpertEvaluatorTest()
        {
            // TODO: unit test for the property 'ExpertEvaluator'
        }

    }

}
