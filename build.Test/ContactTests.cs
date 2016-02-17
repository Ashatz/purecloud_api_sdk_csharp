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
    public class ContactTests
    {
        private Contact instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Contact();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Contact
        /// </summary>
        [Test]
        public void ContactInstanceTest()
        {
            Assert.IsInstanceOf<Contact> (instance, "instance is a Contact");
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
        /// Test the property 'ContactListId' 
        /// </summary>
        [Test]
        public void ContactListIdTest()
        {
            // TODO: unit test for the property 'ContactListId' 
        }
        
        /// <summary>
        /// Test the property 'Data' 
        /// </summary>
        [Test]
        public void DataTest()
        {
            // TODO: unit test for the property 'Data' 
        }
        
        /// <summary>
        /// Test the property 'CallRecords' 
        /// </summary>
        [Test]
        public void CallRecordsTest()
        {
            // TODO: unit test for the property 'CallRecords' 
        }
        
        /// <summary>
        /// Test the property 'Callable' 
        /// </summary>
        [Test]
        public void CallableTest()
        {
            // TODO: unit test for the property 'Callable' 
        }
        
        /// <summary>
        /// Test the property 'PhoneNumberStatus' 
        /// </summary>
        [Test]
        public void PhoneNumberStatusTest()
        {
            // TODO: unit test for the property 'PhoneNumberStatus' 
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