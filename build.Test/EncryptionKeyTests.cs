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
    public class EncryptionKeyTests
    {
        private EncryptionKey instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EncryptionKey();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of EncryptionKey
        /// </summary>
        [Test]
        public void EncryptionKeyInstanceTest()
        {
            Assert.IsInstanceOf<EncryptionKey> (instance, "instance is a EncryptionKey");
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
        /// Test the property 'CreateDate' 
        /// </summary>
        [Test]
        public void CreateDateTest()
        {
            // TODO: unit test for the property 'CreateDate' 
        }
        
        /// <summary>
        /// Test the property 'KeydataSummary' 
        /// </summary>
        [Test]
        public void KeydataSummaryTest()
        {
            // TODO: unit test for the property 'KeydataSummary' 
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
        /// Test the property 'SelfUri' 
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri' 
        }
        

    }

}
