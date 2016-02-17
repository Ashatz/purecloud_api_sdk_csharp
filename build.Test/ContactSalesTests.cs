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
    public class ContactSalesTests
    {
        private ContactSales instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ContactSales();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ContactSales
        /// </summary>
        [Test]
        public void ContactSalesInstanceTest()
        {
            Assert.IsInstanceOf<ContactSales> (instance, "instance is a ContactSales");
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
        /// Test the property 'Email' 
        /// </summary>
        [Test]
        public void EmailTest()
        {
            // TODO: unit test for the property 'Email' 
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
        /// Test the property 'ContactPhone' 
        /// </summary>
        [Test]
        public void ContactPhoneTest()
        {
            // TODO: unit test for the property 'ContactPhone' 
        }
        
        /// <summary>
        /// Test the property 'Country' 
        /// </summary>
        [Test]
        public void CountryTest()
        {
            // TODO: unit test for the property 'Country' 
        }
        
        /// <summary>
        /// Test the property 'Title' 
        /// </summary>
        [Test]
        public void TitleTest()
        {
            // TODO: unit test for the property 'Title' 
        }
        
        /// <summary>
        /// Test the property 'Message' 
        /// </summary>
        [Test]
        public void MessageTest()
        {
            // TODO: unit test for the property 'Message' 
        }
        
        /// <summary>
        /// Test the property 'Language' 
        /// </summary>
        [Test]
        public void LanguageTest()
        {
            // TODO: unit test for the property 'Language' 
        }
        
        /// <summary>
        /// Test the property 'ProductName' 
        /// </summary>
        [Test]
        public void ProductNameTest()
        {
            // TODO: unit test for the property 'ProductName' 
        }
        
        /// <summary>
        /// Test the property 'QuoteId' 
        /// </summary>
        [Test]
        public void QuoteIdTest()
        {
            // TODO: unit test for the property 'QuoteId' 
        }
        
        /// <summary>
        /// Test the property 'Industry' 
        /// </summary>
        [Test]
        public void IndustryTest()
        {
            // TODO: unit test for the property 'Industry' 
        }
        
        /// <summary>
        /// Test the property 'EstimatedUsers' 
        /// </summary>
        [Test]
        public void EstimatedUsersTest()
        {
            // TODO: unit test for the property 'EstimatedUsers' 
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
