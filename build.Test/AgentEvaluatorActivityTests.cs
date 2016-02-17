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
    public class AgentEvaluatorActivityTests
    {
        private AgentEvaluatorActivity instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AgentEvaluatorActivity();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of AgentEvaluatorActivity
        /// </summary>
        [Test]
        public void AgentEvaluatorActivityInstanceTest()
        {
            Assert.IsInstanceOf<AgentEvaluatorActivity> (instance, "instance is a AgentEvaluatorActivity");
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
        /// Test the property 'Agent' 
        /// </summary>
        [Test]
        public void AgentTest()
        {
            // TODO: unit test for the property 'Agent' 
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
        /// Test the property 'NumEvaluations' 
        /// </summary>
        [Test]
        public void NumEvaluationsTest()
        {
            // TODO: unit test for the property 'NumEvaluations' 
        }
        
        /// <summary>
        /// Test the property 'AverageEvaluationScore' 
        /// </summary>
        [Test]
        public void AverageEvaluationScoreTest()
        {
            // TODO: unit test for the property 'AverageEvaluationScore' 
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
