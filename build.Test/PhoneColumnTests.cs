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
    public class PhoneColumnTests
    {
        private PhoneColumn instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PhoneColumn();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of PhoneColumn
        /// </summary>
        [Test]
        public void PhoneColumnInstanceTest()
        {
            Assert.IsInstanceOf<PhoneColumn> (instance, "instance is a PhoneColumn");
        }

        
        /// <summary>
        /// Test the property 'ColumnName' 
        /// </summary>
        [Test]
        public void ColumnNameTest()
        {
            // TODO: unit test for the property 'ColumnName' 
        }
        
        /// <summary>
        /// Test the property 'Type' 
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO: unit test for the property 'Type' 
        }
        

    }

}
