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
    public class UserRecordingTests
    {
        private UserRecording instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserRecording();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of UserRecording
        /// </summary>
        [Test]
        public void UserRecordingInstanceTest()
        {
            Assert.IsInstanceOf<UserRecording> (instance, "instance is a UserRecording");
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
        /// Test the property 'DateCreated' 
        /// </summary>
        [Test]
        public void DateCreatedTest()
        {
            // TODO: unit test for the property 'DateCreated' 
        }
        
        /// <summary>
        /// Test the property 'DateModified' 
        /// </summary>
        [Test]
        public void DateModifiedTest()
        {
            // TODO: unit test for the property 'DateModified' 
        }
        
        /// <summary>
        /// Test the property 'ContentUri' 
        /// </summary>
        [Test]
        public void ContentUriTest()
        {
            // TODO: unit test for the property 'ContentUri' 
        }
        
        /// <summary>
        /// Test the property 'Workspace' 
        /// </summary>
        [Test]
        public void WorkspaceTest()
        {
            // TODO: unit test for the property 'Workspace' 
        }
        
        /// <summary>
        /// Test the property 'CreatedBy' 
        /// </summary>
        [Test]
        public void CreatedByTest()
        {
            // TODO: unit test for the property 'CreatedBy' 
        }
        
        /// <summary>
        /// Test the property 'Conversation' 
        /// </summary>
        [Test]
        public void ConversationTest()
        {
            // TODO: unit test for the property 'Conversation' 
        }
        
        /// <summary>
        /// Test the property 'ContentLength' 
        /// </summary>
        [Test]
        public void ContentLengthTest()
        {
            // TODO: unit test for the property 'ContentLength' 
        }
        
        /// <summary>
        /// Test the property 'DurationMilliseconds' 
        /// </summary>
        [Test]
        public void DurationMillisecondsTest()
        {
            // TODO: unit test for the property 'DurationMilliseconds' 
        }
        
        /// <summary>
        /// Test the property 'Thumbnails' 
        /// </summary>
        [Test]
        public void ThumbnailsTest()
        {
            // TODO: unit test for the property 'Thumbnails' 
        }
        
        /// <summary>
        /// Test the property 'Read' 
        /// </summary>
        [Test]
        public void ReadTest()
        {
            // TODO: unit test for the property 'Read' 
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
