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
    public class DncListTests
    {
        private DncList instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DncList();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DncList
        /// </summary>
        [Test]
        public void DncListInstanceTest()
        {
            Assert.IsInstanceOf<DncList> (instance, "instance is a DncList");
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
        /// Test the property 'DateCreated' 
        /// </summary>
        [Test]
        public void DateCreatedTest()
        {
            // TODO: unit test for the property 'DateCreated' 
        }
        
        /// <summary>
        /// Test the property 'DateModified' 
        /// </summary>
        [Test]
        public void DateModifiedTest()
        {
            // TODO: unit test for the property 'DateModified' 
        }
        
        /// <summary>
        /// Test the property 'Version' 
        /// </summary>
        [Test]
        public void VersionTest()
        {
            // TODO: unit test for the property 'Version' 
        }
        
        /// <summary>
        /// Test the property 'PhoneNumberColumns' 
        /// </summary>
        [Test]
        public void PhoneNumberColumnsTest()
        {
            // TODO: unit test for the property 'PhoneNumberColumns' 
        }
        
        /// <summary>
        /// Test the property 'ImportStatus' 
        /// </summary>
        [Test]
        public void ImportStatusTest()
        {
            // TODO: unit test for the property 'ImportStatus' 
        }
        
        /// <summary>
        /// Test the property 'FileKey' 
        /// </summary>
        [Test]
        public void FileKeyTest()
        {
            // TODO: unit test for the property 'FileKey' 
        }
        
        /// <summary>
        /// Test the property 'Size' 
        /// </summary>
        [Test]
        public void SizeTest()
        {
            // TODO: unit test for the property 'Size' 
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
