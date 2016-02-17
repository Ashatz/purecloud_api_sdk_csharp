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
    public class ChatMessageUserTests
    {
        private ChatMessageUser instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ChatMessageUser();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ChatMessageUser
        /// </summary>
        [Test]
        public void ChatMessageUserInstanceTest()
        {
            Assert.IsInstanceOf<ChatMessageUser> (instance, "instance is a ChatMessageUser");
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
        /// Test the property 'DisplayName' 
        /// </summary>
        [Test]
        public void DisplayNameTest()
        {
            // TODO: unit test for the property 'DisplayName' 
        }
        
        /// <summary>
        /// Test the property 'Username' 
        /// </summary>
        [Test]
        public void UsernameTest()
        {
            // TODO: unit test for the property 'Username' 
        }
        
        /// <summary>
        /// Test the property 'Images' 
        /// </summary>
        [Test]
        public void ImagesTest()
        {
            // TODO: unit test for the property 'Images' 
        }
        

    }

}
