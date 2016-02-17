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
    public class EvaluationFormTests
    {
        private EvaluationForm instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EvaluationForm();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of EvaluationForm
        /// </summary>
        [Test]
        public void EvaluationFormInstanceTest()
        {
            Assert.IsInstanceOf<EvaluationForm> (instance, "instance is a EvaluationForm");
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
        /// Test the property 'ModifiedDate' 
        /// </summary>
        [Test]
        public void ModifiedDateTest()
        {
            // TODO: unit test for the property 'ModifiedDate' 
        }
        
        /// <summary>
        /// Test the property 'Published' 
        /// </summary>
        [Test]
        public void PublishedTest()
        {
            // TODO: unit test for the property 'Published' 
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
        /// Test the property 'QuestionGroups' 
        /// </summary>
        [Test]
        public void QuestionGroupsTest()
        {
            // TODO: unit test for the property 'QuestionGroups' 
        }
        
        /// <summary>
        /// Test the property 'PublishedVersions' 
        /// </summary>
        [Test]
        public void PublishedVersionsTest()
        {
            // TODO: unit test for the property 'PublishedVersions' 
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
