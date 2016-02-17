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
    public class EvaluatorActivityTests
    {
        private EvaluatorActivity instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EvaluatorActivity();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of EvaluatorActivity
        /// </summary>
        [Test]
        public void EvaluatorActivityInstanceTest()
        {
            Assert.IsInstanceOf<EvaluatorActivity> (instance, "instance is a EvaluatorActivity");
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
        /// Test the property 'Evaluator' 
        /// </summary>
        [Test]
        public void EvaluatorTest()
        {
            // TODO: unit test for the property 'Evaluator' 
        }
        
        /// <summary>
        /// Test the property 'NumEvaluationsAssigned' 
        /// </summary>
        [Test]
        public void NumEvaluationsAssignedTest()
        {
            // TODO: unit test for the property 'NumEvaluationsAssigned' 
        }
        
        /// <summary>
        /// Test the property 'NumEvaluationsStarted' 
        /// </summary>
        [Test]
        public void NumEvaluationsStartedTest()
        {
            // TODO: unit test for the property 'NumEvaluationsStarted' 
        }
        
        /// <summary>
        /// Test the property 'NumEvaluationsCompleted' 
        /// </summary>
        [Test]
        public void NumEvaluationsCompletedTest()
        {
            // TODO: unit test for the property 'NumEvaluationsCompleted' 
        }
        
        /// <summary>
        /// Test the property 'NumCalibrationsAssigned' 
        /// </summary>
        [Test]
        public void NumCalibrationsAssignedTest()
        {
            // TODO: unit test for the property 'NumCalibrationsAssigned' 
        }
        
        /// <summary>
        /// Test the property 'NumCalibrationsStarted' 
        /// </summary>
        [Test]
        public void NumCalibrationsStartedTest()
        {
            // TODO: unit test for the property 'NumCalibrationsStarted' 
        }
        
        /// <summary>
        /// Test the property 'NumCalibrationsCompleted' 
        /// </summary>
        [Test]
        public void NumCalibrationsCompletedTest()
        {
            // TODO: unit test for the property 'NumCalibrationsCompleted' 
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