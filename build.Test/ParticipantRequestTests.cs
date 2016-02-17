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
    public class ParticipantRequestTests
    {
        private ParticipantRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ParticipantRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ParticipantRequest
        /// </summary>
        [Test]
        public void ParticipantRequestInstanceTest()
        {
            Assert.IsInstanceOf<ParticipantRequest> (instance, "instance is a ParticipantRequest");
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
        /// Test the property 'Wrapup' 
        /// </summary>
        [Test]
        public void WrapupTest()
        {
            // TODO: unit test for the property 'Wrapup' 
        }
        
        /// <summary>
        /// Test the property 'State' 
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO: unit test for the property 'State' 
        }
        
        /// <summary>
        /// Test the property 'Recording' 
        /// </summary>
        [Test]
        public void RecordingTest()
        {
            // TODO: unit test for the property 'Recording' 
        }
        
        /// <summary>
        /// Test the property 'Muted' 
        /// </summary>
        [Test]
        public void MutedTest()
        {
            // TODO: unit test for the property 'Muted' 
        }
        
        /// <summary>
        /// Test the property 'Confined' 
        /// </summary>
        [Test]
        public void ConfinedTest()
        {
            // TODO: unit test for the property 'Confined' 
        }
        
        /// <summary>
        /// Test the property 'Held' 
        /// </summary>
        [Test]
        public void HeldTest()
        {
            // TODO: unit test for the property 'Held' 
        }
        
        /// <summary>
        /// Test the property 'WrapupSkipped' 
        /// </summary>
        [Test]
        public void WrapupSkippedTest()
        {
            // TODO: unit test for the property 'WrapupSkipped' 
        }
        

    }

}
