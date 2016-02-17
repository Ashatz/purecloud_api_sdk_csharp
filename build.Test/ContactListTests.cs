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
    public class ContactListTests
    {
        private ContactList instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ContactList();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ContactList
        /// </summary>
        [Test]
        public void ContactListInstanceTest()
        {
            Assert.IsInstanceOf<ContactList> (instance, "instance is a ContactList");
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
        /// Test the property 'ColumnNames' 
        /// </summary>
        [Test]
        public void ColumnNamesTest()
        {
            // TODO: unit test for the property 'ColumnNames' 
        }
        
        /// <summary>
        /// Test the property 'PhoneColumns' 
        /// </summary>
        [Test]
        public void PhoneColumnsTest()
        {
            // TODO: unit test for the property 'PhoneColumns' 
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
        /// Test the property 'PreviewModeColumnName' 
        /// </summary>
        [Test]
        public void PreviewModeColumnNameTest()
        {
            // TODO: unit test for the property 'PreviewModeColumnName' 
        }
        
        /// <summary>
        /// Test the property 'PreviewModeAcceptedValues' 
        /// </summary>
        [Test]
        public void PreviewModeAcceptedValuesTest()
        {
            // TODO: unit test for the property 'PreviewModeAcceptedValues' 
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