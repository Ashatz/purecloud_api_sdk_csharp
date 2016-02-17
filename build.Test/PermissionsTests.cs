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
    public class PermissionsTests
    {
        private Permissions instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Permissions();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Permissions
        /// </summary>
        [Test]
        public void PermissionsInstanceTest()
        {
            Assert.IsInstanceOf<Permissions> (instance, "instance is a Permissions");
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
        /// Test the property 'Ids' 
        /// </summary>
        [Test]
        public void IdsTest()
        {
            // TODO: unit test for the property 'Ids' 
        }
        

    }

}
