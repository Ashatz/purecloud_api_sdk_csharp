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
    public class OutOfOfficeTests
    {
        private OutOfOffice instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OutOfOffice();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of OutOfOffice
        /// </summary>
        [Test]
        public void OutOfOfficeInstanceTest()
        {
            Assert.IsInstanceOf<OutOfOffice> (instance, "instance is a OutOfOffice");
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
        /// Test the property 'StartDate' 
        /// </summary>
        [Test]
        public void StartDateTest()
        {
            // TODO: unit test for the property 'StartDate' 
        }
        
        /// <summary>
        /// Test the property 'EndDate' 
        /// </summary>
        [Test]
        public void EndDateTest()
        {
            // TODO: unit test for the property 'EndDate' 
        }
        
        /// <summary>
        /// Test the property 'Active' 
        /// </summary>
        [Test]
        public void ActiveTest()
        {
            // TODO: unit test for the property 'Active' 
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
