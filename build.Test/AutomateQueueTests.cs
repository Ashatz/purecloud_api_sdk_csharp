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
    public class AutomateQueueTests
    {
        private AutomateQueue instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AutomateQueue();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of AutomateQueue
        /// </summary>
        [Test]
        public void AutomateQueueInstanceTest()
        {
            Assert.IsInstanceOf<AutomateQueue> (instance, "instance is a AutomateQueue");
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
        /// Test the property 'Description' 
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO: unit test for the property 'Description' 
        }
        
        /// <summary>
        /// Test the property 'Members' 
        /// </summary>
        [Test]
        public void MembersTest()
        {
            // TODO: unit test for the property 'Members' 
        }
        
        /// <summary>
        /// Test the property 'LastUpdateTime' 
        /// </summary>
        [Test]
        public void LastUpdateTimeTest()
        {
            // TODO: unit test for the property 'LastUpdateTime' 
        }
        
        /// <summary>
        /// Test the property 'LastUpdateUser' 
        /// </summary>
        [Test]
        public void LastUpdateUserTest()
        {
            // TODO: unit test for the property 'LastUpdateUser' 
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
