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
    public class ControlTests
    {
        private Control instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Control();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Control
        /// </summary>
        [Test]
        public void ControlInstanceTest()
        {
            Assert.IsInstanceOf<Control> (instance, "instance is a Control");
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
        /// Test the property 'Label' 
        /// </summary>
        [Test]
        public void LabelTest()
        {
            // TODO: unit test for the property 'Label' 
        }
        
        /// <summary>
        /// Test the property 'Options' 
        /// </summary>
        [Test]
        public void OptionsTest()
        {
            // TODO: unit test for the property 'Options' 
        }
        
        /// <summary>
        /// Test the property 'Required' 
        /// </summary>
        [Test]
        public void RequiredTest()
        {
            // TODO: unit test for the property 'Required' 
        }
        
        /// <summary>
        /// Test the property 'ReadOnly' 
        /// </summary>
        [Test]
        public void ReadOnlyTest()
        {
            // TODO: unit test for the property 'ReadOnly' 
        }
        
        /// <summary>
        /// Test the property 'VariableBindingId' 
        /// </summary>
        [Test]
        public void VariableBindingIdTest()
        {
            // TODO: unit test for the property 'VariableBindingId' 
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
