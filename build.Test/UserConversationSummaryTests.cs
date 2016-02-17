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
    public class UserConversationSummaryTests
    {
        private UserConversationSummary instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserConversationSummary();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of UserConversationSummary
        /// </summary>
        [Test]
        public void UserConversationSummaryInstanceTest()
        {
            Assert.IsInstanceOf<UserConversationSummary> (instance, "instance is a UserConversationSummary");
        }

        
        /// <summary>
        /// Test the property 'UserId' 
        /// </summary>
        [Test]
        public void UserIdTest()
        {
            // TODO: unit test for the property 'UserId' 
        }
        
        /// <summary>
        /// Test the property 'Call' 
        /// </summary>
        [Test]
        public void CallTest()
        {
            // TODO: unit test for the property 'Call' 
        }
        
        /// <summary>
        /// Test the property 'Callback' 
        /// </summary>
        [Test]
        public void CallbackTest()
        {
            // TODO: unit test for the property 'Callback' 
        }
        
        /// <summary>
        /// Test the property 'Email' 
        /// </summary>
        [Test]
        public void EmailTest()
        {
            // TODO: unit test for the property 'Email' 
        }
        
        /// <summary>
        /// Test the property 'Chat' 
        /// </summary>
        [Test]
        public void ChatTest()
        {
            // TODO: unit test for the property 'Chat' 
        }
        
        /// <summary>
        /// Test the property 'SocialExpression' 
        /// </summary>
        [Test]
        public void SocialExpressionTest()
        {
            // TODO: unit test for the property 'SocialExpression' 
        }
        
        /// <summary>
        /// Test the property 'Video' 
        /// </summary>
        [Test]
        public void VideoTest()
        {
            // TODO: unit test for the property 'Video' 
        }
        

    }

}
