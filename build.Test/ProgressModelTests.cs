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
    public class ProgressModelTests
    {
        private ProgressModel instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProgressModel();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ProgressModel
        /// </summary>
        [Test]
        public void ProgressModelInstanceTest()
        {
            Assert.IsInstanceOf<ProgressModel> (instance, "instance is a ProgressModel");
        }

        
        /// <summary>
        /// Test the property 'Phase' 
        /// </summary>
        [Test]
        public void PhaseTest()
        {
            // TODO: unit test for the property 'Phase' 
        }
        
        /// <summary>
        /// Test the property 'IterationsDone' 
        /// </summary>
        [Test]
        public void IterationsDoneTest()
        {
            // TODO: unit test for the property 'IterationsDone' 
        }
        
        /// <summary>
        /// Test the property 'IterationsInPhase' 
        /// </summary>
        [Test]
        public void IterationsInPhaseTest()
        {
            // TODO: unit test for the property 'IterationsInPhase' 
        }
        

    }

}
