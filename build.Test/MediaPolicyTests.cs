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
    public class MediaPolicyTests
    {
        private MediaPolicy instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MediaPolicy();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of MediaPolicy
        /// </summary>
        [Test]
        public void MediaPolicyInstanceTest()
        {
            Assert.IsInstanceOf<MediaPolicy> (instance, "instance is a MediaPolicy");
        }

        
        /// <summary>
        /// Test the property 'EvaluationCriteria' 
        /// </summary>
        [Test]
        public void EvaluationCriteriaTest()
        {
            // TODO: unit test for the property 'EvaluationCriteria' 
        }
        
        /// <summary>
        /// Test the property 'Conditions' 
        /// </summary>
        [Test]
        public void ConditionsTest()
        {
            // TODO: unit test for the property 'Conditions' 
        }
        
        /// <summary>
        /// Test the property 'Actions' 
        /// </summary>
        [Test]
        public void ActionsTest()
        {
            // TODO: unit test for the property 'Actions' 
        }
        

    }

}