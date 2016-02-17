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
    public class DomainPermissionTests
    {
        private DomainPermission instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DomainPermission();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DomainPermission
        /// </summary>
        [Test]
        public void DomainPermissionInstanceTest()
        {
            Assert.IsInstanceOf<DomainPermission> (instance, "instance is a DomainPermission");
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
        /// Test the property 'EntityType' 
        /// </summary>
        [Test]
        public void EntityTypeTest()
        {
            // TODO: unit test for the property 'EntityType' 
        }
        
        /// <summary>
        /// Test the property 'Action' 
        /// </summary>
        [Test]
        public void ActionTest()
        {
            // TODO: unit test for the property 'Action' 
        }
        
        /// <summary>
        /// Test the property 'Label' 
        /// </summary>
        [Test]
        public void LabelTest()
        {
            // TODO: unit test for the property 'Label' 
        }
        
        /// <summary>
        /// Test the property 'Licenses' 
        /// </summary>
        [Test]
        public void LicensesTest()
        {
            // TODO: unit test for the property 'Licenses' 
        }
        
        /// <summary>
        /// Test the property 'AllowsConditions' 
        /// </summary>
        [Test]
        public void AllowsConditionsTest()
        {
            // TODO: unit test for the property 'AllowsConditions' 
        }
        

    }

}
