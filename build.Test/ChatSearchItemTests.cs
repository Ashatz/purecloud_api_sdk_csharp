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
    public class ChatSearchItemTests
    {
        private ChatSearchItem instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ChatSearchItem();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ChatSearchItem
        /// </summary>
        [Test]
        public void ChatSearchItemInstanceTest()
        {
            Assert.IsInstanceOf<ChatSearchItem> (instance, "instance is a ChatSearchItem");
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
        /// Test the property 'CreatedDate' 
        /// </summary>
        [Test]
        public void CreatedDateTest()
        {
            // TODO: unit test for the property 'CreatedDate' 
        }
        
        /// <summary>
        /// Test the property 'From' 
        /// </summary>
        [Test]
        public void FromTest()
        {
            // TODO: unit test for the property 'From' 
        }
        
        /// <summary>
        /// Test the property 'To' 
        /// </summary>
        [Test]
        public void ToTest()
        {
            // TODO: unit test for the property 'To' 
        }
        
        /// <summary>
        /// Test the property 'Body' 
        /// </summary>
        [Test]
        public void BodyTest()
        {
            // TODO: unit test for the property 'Body' 
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
