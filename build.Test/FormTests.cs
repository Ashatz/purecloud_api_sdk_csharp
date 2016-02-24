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
    public class FormTests
    {
        private Form instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Form();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Form
        /// </summary>
        [Test]
        public void FormInstanceTest()
        {
            Assert.IsInstanceOf<Form> (instance, "instance is a Form");
        }

        
        /// <summary>
        /// Test the property 'Controls' 
        /// </summary>
        [Test]
        public void ControlsTest()
        {
            // TODO: unit test for the property 'Controls' 
        }
        

    }

}
