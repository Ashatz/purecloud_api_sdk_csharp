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
    public class CommandStatusTests
    {
        private CommandStatus instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CommandStatus();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of CommandStatus
        /// </summary>
        [Test]
        public void CommandStatusInstanceTest()
        {
            Assert.IsInstanceOf<CommandStatus> (instance, "instance is a CommandStatus");
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
        /// Test the property 'Expiration' 
        /// </summary>
        [Test]
        public void ExpirationTest()
        {
            // TODO: unit test for the property 'Expiration' 
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
        /// Test the property 'StatusCode' 
        /// </summary>
        [Test]
        public void StatusCodeTest()
        {
            // TODO: unit test for the property 'StatusCode' 
        }
        
        /// <summary>
        /// Test the property 'CommandType' 
        /// </summary>
        [Test]
        public void CommandTypeTest()
        {
            // TODO: unit test for the property 'CommandType' 
        }
        
        /// <summary>
        /// Test the property 'Document' 
        /// </summary>
        [Test]
        public void DocumentTest()
        {
            // TODO: unit test for the property 'Document' 
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
