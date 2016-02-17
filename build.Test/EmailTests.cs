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
    public class EmailTests
    {
        private Email instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Email();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Email
        /// </summary>
        [Test]
        public void EmailInstanceTest()
        {
            Assert.IsInstanceOf<Email> (instance, "instance is a Email");
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
        /// Test the property 'Id' 
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id' 
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
        /// Test the property 'Subject' 
        /// </summary>
        [Test]
        public void SubjectTest()
        {
            // TODO: unit test for the property 'Subject' 
        }
        
        /// <summary>
        /// Test the property 'MessagesSent' 
        /// </summary>
        [Test]
        public void MessagesSentTest()
        {
            // TODO: unit test for the property 'MessagesSent' 
        }
        
        /// <summary>
        /// Test the property 'Segments' 
        /// </summary>
        [Test]
        public void SegmentsTest()
        {
            // TODO: unit test for the property 'Segments' 
        }
        
        /// <summary>
        /// Test the property 'Direction' 
        /// </summary>
        [Test]
        public void DirectionTest()
        {
            // TODO: unit test for the property 'Direction' 
        }
        
        /// <summary>
        /// Test the property 'RecordingId' 
        /// </summary>
        [Test]
        public void RecordingIdTest()
        {
            // TODO: unit test for the property 'RecordingId' 
        }
        
        /// <summary>
        /// Test the property 'ErrorInfo' 
        /// </summary>
        [Test]
        public void ErrorInfoTest()
        {
            // TODO: unit test for the property 'ErrorInfo' 
        }
        
        /// <summary>
        /// Test the property 'DisconnectType' 
        /// </summary>
        [Test]
        public void DisconnectTypeTest()
        {
            // TODO: unit test for the property 'DisconnectType' 
        }
        
        /// <summary>
        /// Test the property 'StartHoldTime' 
        /// </summary>
        [Test]
        public void StartHoldTimeTest()
        {
            // TODO: unit test for the property 'StartHoldTime' 
        }
        

    }

}
