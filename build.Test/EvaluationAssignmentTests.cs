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
    public class EvaluationAssignmentTests
    {
        private EvaluationAssignment instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EvaluationAssignment();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of EvaluationAssignment
        /// </summary>
        [Test]
        public void EvaluationAssignmentInstanceTest()
        {
            Assert.IsInstanceOf<EvaluationAssignment> (instance, "instance is a EvaluationAssignment");
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
        /// Test the property 'User' 
        /// </summary>
        [Test]
        public void UserTest()
        {
            // TODO: unit test for the property 'User' 
        }
        

    }

}
