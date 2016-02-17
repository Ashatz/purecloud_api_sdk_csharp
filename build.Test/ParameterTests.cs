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
    public class ParameterTests
    {
        private Parameter instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Parameter();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Parameter
        /// </summary>
        [Test]
        public void ParameterInstanceTest()
        {
            Assert.IsInstanceOf<Parameter> (instance, "instance is a Parameter");
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
        /// Test the property 'ParameterType' 
        /// </summary>
        [Test]
        public void ParameterTypeTest()
        {
            // TODO: unit test for the property 'ParameterType' 
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
        /// Test the property 'Required' 
        /// </summary>
        [Test]
        public void RequiredTest()
        {
            // TODO: unit test for the property 'Required' 
        }
        

    }

}
