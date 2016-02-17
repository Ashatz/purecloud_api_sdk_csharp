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
    public class AccountManagerTests
    {
        private AccountManager instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AccountManager();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of AccountManager
        /// </summary>
        [Test]
        public void AccountManagerInstanceTest()
        {
            Assert.IsInstanceOf<AccountManager> (instance, "instance is a AccountManager");
        }

        
        /// <summary>
        /// Test the property 'FirstName' 
        /// </summary>
        [Test]
        public void FirstNameTest()
        {
            // TODO: unit test for the property 'FirstName' 
        }
        
        /// <summary>
        /// Test the property 'LastName' 
        /// </summary>
        [Test]
        public void LastNameTest()
        {
            // TODO: unit test for the property 'LastName' 
        }
        
        /// <summary>
        /// Test the property 'Phone' 
        /// </summary>
        [Test]
        public void PhoneTest()
        {
            // TODO: unit test for the property 'Phone' 
        }
        
        /// <summary>
        /// Test the property 'Email' 
        /// </summary>
        [Test]
        public void EmailTest()
        {
            // TODO: unit test for the property 'Email' 
        }
        

    }

}
