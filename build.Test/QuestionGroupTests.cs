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
    public class QuestionGroupTests
    {
        private QuestionGroup instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new QuestionGroup();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of QuestionGroup
        /// </summary>
        [Test]
        public void QuestionGroupInstanceTest()
        {
            Assert.IsInstanceOf<QuestionGroup> (instance, "instance is a QuestionGroup");
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
        /// Test the property 'Type' 
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO: unit test for the property 'Type' 
        }
        
        /// <summary>
        /// Test the property 'DefaultAnswersToHighest' 
        /// </summary>
        [Test]
        public void DefaultAnswersToHighestTest()
        {
            // TODO: unit test for the property 'DefaultAnswersToHighest' 
        }
        
        /// <summary>
        /// Test the property 'DefaultAnswersToNA' 
        /// </summary>
        [Test]
        public void DefaultAnswersToNATest()
        {
            // TODO: unit test for the property 'DefaultAnswersToNA' 
        }
        
        /// <summary>
        /// Test the property 'NaEnabled' 
        /// </summary>
        [Test]
        public void NaEnabledTest()
        {
            // TODO: unit test for the property 'NaEnabled' 
        }
        
        /// <summary>
        /// Test the property 'Weight' 
        /// </summary>
        [Test]
        public void WeightTest()
        {
            // TODO: unit test for the property 'Weight' 
        }
        
        /// <summary>
        /// Test the property 'ManualWeight' 
        /// </summary>
        [Test]
        public void ManualWeightTest()
        {
            // TODO: unit test for the property 'ManualWeight' 
        }
        
        /// <summary>
        /// Test the property 'Questions' 
        /// </summary>
        [Test]
        public void QuestionsTest()
        {
            // TODO: unit test for the property 'Questions' 
        }
        

    }

}
