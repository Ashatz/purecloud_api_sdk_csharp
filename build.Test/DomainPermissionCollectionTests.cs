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
    public class DomainPermissionCollectionTests
    {
        private DomainPermissionCollection instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DomainPermissionCollection();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DomainPermissionCollection
        /// </summary>
        [Test]
        public void DomainPermissionCollectionInstanceTest()
        {
            Assert.IsInstanceOf<DomainPermissionCollection> (instance, "instance is a DomainPermissionCollection");
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
        /// Test the property 'Domain' 
        /// </summary>
        [Test]
        public void DomainTest()
        {
            // TODO: unit test for the property 'Domain' 
        }
        
        /// <summary>
        /// Test the property 'PermissionMap' 
        /// </summary>
        [Test]
        public void PermissionMapTest()
        {
            // TODO: unit test for the property 'PermissionMap' 
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
