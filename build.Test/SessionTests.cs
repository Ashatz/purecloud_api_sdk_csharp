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
    public class SessionTests
    {
        private Session instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Session();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Session
        /// </summary>
        [Test]
        public void SessionInstanceTest()
        {
            Assert.IsInstanceOf<Session> (instance, "instance is a Session");
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
        /// Test the property 'MinutesToLive' 
        /// </summary>
        [Test]
        public void MinutesToLiveTest()
        {
            // TODO: unit test for the property 'MinutesToLive' 
        }
        
        /// <summary>
        /// Test the property 'UserAgent' 
        /// </summary>
        [Test]
        public void UserAgentTest()
        {
            // TODO: unit test for the property 'UserAgent' 
        }
        
        /// <summary>
        /// Test the property 'CreatedOn' 
        /// </summary>
        [Test]
        public void CreatedOnTest()
        {
            // TODO: unit test for the property 'CreatedOn' 
        }
        
        /// <summary>
        /// Test the property 'User' 
        /// </summary>
        [Test]
        public void UserTest()
        {
            // TODO: unit test for the property 'User' 
        }
        
        /// <summary>
        /// Test the property 'Language' 
        /// </summary>
        [Test]
        public void LanguageTest()
        {
            // TODO: unit test for the property 'Language' 
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
