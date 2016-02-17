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
    public class ConversationTests
    {
        private Conversation instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Conversation();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Conversation
        /// </summary>
        [Test]
        public void ConversationInstanceTest()
        {
            Assert.IsInstanceOf<Conversation> (instance, "instance is a Conversation");
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
        /// Test the property 'StartTime' 
        /// </summary>
        [Test]
        public void StartTimeTest()
        {
            // TODO: unit test for the property 'StartTime' 
        }
        
        /// <summary>
        /// Test the property 'EndTime' 
        /// </summary>
        [Test]
        public void EndTimeTest()
        {
            // TODO: unit test for the property 'EndTime' 
        }
        
        /// <summary>
        /// Test the property 'Address' 
        /// </summary>
        [Test]
        public void AddressTest()
        {
            // TODO: unit test for the property 'Address' 
        }
        
        /// <summary>
        /// Test the property 'Participants' 
        /// </summary>
        [Test]
        public void ParticipantsTest()
        {
            // TODO: unit test for the property 'Participants' 
        }
        
        /// <summary>
        /// Test the property 'ConversationIds' 
        /// </summary>
        [Test]
        public void ConversationIdsTest()
        {
            // TODO: unit test for the property 'ConversationIds' 
        }
        
        /// <summary>
        /// Test the property 'MaxParticipants' 
        /// </summary>
        [Test]
        public void MaxParticipantsTest()
        {
            // TODO: unit test for the property 'MaxParticipants' 
        }
        
        /// <summary>
        /// Test the property 'RecordingState' 
        /// </summary>
        [Test]
        public void RecordingStateTest()
        {
            // TODO: unit test for the property 'RecordingState' 
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
