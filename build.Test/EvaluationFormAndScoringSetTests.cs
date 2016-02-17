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
    public class EvaluationFormAndScoringSetTests
    {
        private EvaluationFormAndScoringSet instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EvaluationFormAndScoringSet();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of EvaluationFormAndScoringSet
        /// </summary>
        [Test]
        public void EvaluationFormAndScoringSetInstanceTest()
        {
            Assert.IsInstanceOf<EvaluationFormAndScoringSet> (instance, "instance is a EvaluationFormAndScoringSet");
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
        /// Test the property 'Answers' 
        /// </summary>
        [Test]
        public void AnswersTest()
        {
            // TODO: unit test for the property 'Answers' 
        }
        

    }

}
