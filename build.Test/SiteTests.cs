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
    public class SiteTests
    {
        private Site instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Site();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Site
        /// </summary>
        [Test]
        public void SiteInstanceTest()
        {
            Assert.IsInstanceOf<Site> (instance, "instance is a Site");
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
        /// Test the property 'PrimarySites' 
        /// </summary>
        [Test]
        public void PrimarySitesTest()
        {
            // TODO: unit test for the property 'PrimarySites' 
        }
        
        /// <summary>
        /// Test the property 'SecondarySites' 
        /// </summary>
        [Test]
        public void SecondarySitesTest()
        {
            // TODO: unit test for the property 'SecondarySites' 
        }
        
        /// <summary>
        /// Test the property 'PrimaryEdges' 
        /// </summary>
        [Test]
        public void PrimaryEdgesTest()
        {
            // TODO: unit test for the property 'PrimaryEdges' 
        }
        
        /// <summary>
        /// Test the property 'SecondaryEdges' 
        /// </summary>
        [Test]
        public void SecondaryEdgesTest()
        {
            // TODO: unit test for the property 'SecondaryEdges' 
        }
        
        /// <summary>
        /// Test the property 'Addresses' 
        /// </summary>
        [Test]
        public void AddressesTest()
        {
            // TODO: unit test for the property 'Addresses' 
        }
        
        /// <summary>
        /// Test the property 'Edges' 
        /// </summary>
        [Test]
        public void EdgesTest()
        {
            // TODO: unit test for the property 'Edges' 
        }
        
        /// <summary>
        /// Test the property 'EdgeAutoUpdateConfig' 
        /// </summary>
        [Test]
        public void EdgeAutoUpdateConfigTest()
        {
            // TODO: unit test for the property 'EdgeAutoUpdateConfig' 
        }
        
        /// <summary>
        /// Test the property 'Location' 
        /// </summary>
        [Test]
        public void LocationTest()
        {
            // TODO: unit test for the property 'Location' 
        }
        
        /// <summary>
        /// Test the property 'Managed' 
        /// </summary>
        [Test]
        public void ManagedTest()
        {
            // TODO: unit test for the property 'Managed' 
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
