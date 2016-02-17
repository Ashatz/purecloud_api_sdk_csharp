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
    public class PhoneTests
    {
        private Phone instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Phone();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Phone
        /// </summary>
        [Test]
        public void PhoneInstanceTest()
        {
            Assert.IsInstanceOf<Phone> (instance, "instance is a Phone");
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
        /// Test the property 'Version' 
        /// </summary>
        [Test]
        public void VersionTest()
        {
            // TODO: unit test for the property 'Version' 
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
        /// Test the property 'ModifiedBy' 
        /// </summary>
        [Test]
        public void ModifiedByTest()
        {
            // TODO: unit test for the property 'ModifiedBy' 
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
        /// Test the property 'State' 
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO: unit test for the property 'State' 
        }
        
        /// <summary>
        /// Test the property 'ModifiedByApp' 
        /// </summary>
        [Test]
        public void ModifiedByAppTest()
        {
            // TODO: unit test for the property 'ModifiedByApp' 
        }
        
        /// <summary>
        /// Test the property 'CreatedByApp' 
        /// </summary>
        [Test]
        public void CreatedByAppTest()
        {
            // TODO: unit test for the property 'CreatedByApp' 
        }
        
        /// <summary>
        /// Test the property 'EdgeGroup' 
        /// </summary>
        [Test]
        public void EdgeGroupTest()
        {
            // TODO: unit test for the property 'EdgeGroup' 
        }
        
        /// <summary>
        /// Test the property 'Site' 
        /// </summary>
        [Test]
        public void SiteTest()
        {
            // TODO: unit test for the property 'Site' 
        }
        
        /// <summary>
        /// Test the property 'PhoneBaseSettings' 
        /// </summary>
        [Test]
        public void PhoneBaseSettingsTest()
        {
            // TODO: unit test for the property 'PhoneBaseSettings' 
        }
        
        /// <summary>
        /// Test the property 'LineBaseSettings' 
        /// </summary>
        [Test]
        public void LineBaseSettingsTest()
        {
            // TODO: unit test for the property 'LineBaseSettings' 
        }
        
        /// <summary>
        /// Test the property 'PhoneMetaBase' 
        /// </summary>
        [Test]
        public void PhoneMetaBaseTest()
        {
            // TODO: unit test for the property 'PhoneMetaBase' 
        }
        
        /// <summary>
        /// Test the property 'Lines' 
        /// </summary>
        [Test]
        public void LinesTest()
        {
            // TODO: unit test for the property 'Lines' 
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
        /// Test the property 'SecondaryStatus' 
        /// </summary>
        [Test]
        public void SecondaryStatusTest()
        {
            // TODO: unit test for the property 'SecondaryStatus' 
        }
        
        /// <summary>
        /// Test the property 'Properties' 
        /// </summary>
        [Test]
        public void PropertiesTest()
        {
            // TODO: unit test for the property 'Properties' 
        }
        
        /// <summary>
        /// Test the property 'Capabilities' 
        /// </summary>
        [Test]
        public void CapabilitiesTest()
        {
            // TODO: unit test for the property 'Capabilities' 
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
