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
    public class UserPresenceTests
    {
        private UserPresence instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserPresence();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of UserPresence
        /// </summary>
        [Test]
        public void UserPresenceInstanceTest()
        {
            Assert.IsInstanceOf<UserPresence> (instance, "instance is a UserPresence");
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
        /// Test the property 'User' 
        /// </summary>
        [Test]
        public void UserTest()
        {
            // TODO: unit test for the property 'User' 
        }
        
        /// <summary>
        /// Test the property 'Source' 
        /// </summary>
        [Test]
        public void SourceTest()
        {
            // TODO: unit test for the property 'Source' 
        }
        
        /// <summary>
        /// Test the property 'PresenceDefinition' 
        /// </summary>
        [Test]
        public void PresenceDefinitionTest()
        {
            // TODO: unit test for the property 'PresenceDefinition' 
        }
        
        /// <summary>
        /// Test the property 'Message' 
        /// </summary>
        [Test]
        public void MessageTest()
        {
            // TODO: unit test for the property 'Message' 
        }
        
        /// <summary>
        /// Test the property 'ModifiedBy' 
        /// </summary>
        [Test]
        public void ModifiedByTest()
        {
            // TODO: unit test for the property 'ModifiedBy' 
        }
        
        /// <summary>
        /// Test the property 'ModifiedDate' 
        /// </summary>
        [Test]
        public void ModifiedDateTest()
        {
            // TODO: unit test for the property 'ModifiedDate' 
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