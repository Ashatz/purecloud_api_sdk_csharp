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
    public class ChatTests
    {
        private Chat instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Chat();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Chat
        /// </summary>
        [Test]
        public void ChatInstanceTest()
        {
            Assert.IsInstanceOf<Chat> (instance, "instance is a Chat");
        }

        
        /// <summary>
        /// Test the property 'JabberId' 
        /// </summary>
        [Test]
        public void JabberIdTest()
        {
            // TODO: unit test for the property 'JabberId' 
        }
        

    }

}
