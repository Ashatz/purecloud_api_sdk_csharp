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
    public class DependencyStatusTests
    {
        private DependencyStatus instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DependencyStatus();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DependencyStatus
        /// </summary>
        [Test]
        public void DependencyStatusInstanceTest()
        {
            Assert.IsInstanceOf<DependencyStatus> (instance, "instance is a DependencyStatus");
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
        /// Test the property 'BuildId' 
        /// </summary>
        [Test]
        public void BuildIdTest()
        {
            // TODO: unit test for the property 'BuildId' 
        }
        
        /// <summary>
        /// Test the property 'DateStarted' 
        /// </summary>
        [Test]
        public void DateStartedTest()
        {
            // TODO: unit test for the property 'DateStarted' 
        }
        
        /// <summary>
        /// Test the property 'DateCompleted' 
        /// </summary>
        [Test]
        public void DateCompletedTest()
        {
            // TODO: unit test for the property 'DateCompleted' 
        }
        
        /// <summary>
        /// Test the property 'Status' 
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO: unit test for the property 'Status' 
        }
        
        /// <summary>
        /// Test the property 'FailedObjects' 
        /// </summary>
        [Test]
        public void FailedObjectsTest()
        {
            // TODO: unit test for the property 'FailedObjects' 
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
