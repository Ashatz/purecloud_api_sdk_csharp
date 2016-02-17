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
    public class DefaultGreetingListTests
    {
        private DefaultGreetingList instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DefaultGreetingList();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DefaultGreetingList
        /// </summary>
        [Test]
        public void DefaultGreetingListInstanceTest()
        {
            Assert.IsInstanceOf<DefaultGreetingList> (instance, "instance is a DefaultGreetingList");
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
        /// Test the property 'Owner' 
        /// </summary>
        [Test]
        public void OwnerTest()
        {
            // TODO: unit test for the property 'Owner' 
        }
        
        /// <summary>
        /// Test the property 'OwnerType' 
        /// </summary>
        [Test]
        public void OwnerTypeTest()
        {
            // TODO: unit test for the property 'OwnerType' 
        }
        
        /// <summary>
        /// Test the property 'Greetings' 
        /// </summary>
        [Test]
        public void GreetingsTest()
        {
            // TODO: unit test for the property 'Greetings' 
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
        /// Test the property 'CreatedBy' 
        /// </summary>
        [Test]
        public void CreatedByTest()
        {
            // TODO: unit test for the property 'CreatedBy' 
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
        /// Test the property 'ModifiedBy' 
        /// </summary>
        [Test]
        public void ModifiedByTest()
        {
            // TODO: unit test for the property 'ModifiedBy' 
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
