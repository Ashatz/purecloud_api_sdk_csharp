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
    public class SubDataItemTests
    {
        private SubDataItem instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SubDataItem();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of SubDataItem
        /// </summary>
        [Test]
        public void SubDataItemInstanceTest()
        {
            Assert.IsInstanceOf<SubDataItem> (instance, "instance is a SubDataItem");
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
        /// Test the property 'Type' 
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO: unit test for the property 'Type' 
        }
        
        /// <summary>
        /// Test the property 'Value' 
        /// </summary>
        [Test]
        public void ValueTest()
        {
            // TODO: unit test for the property 'Value' 
        }
        
        /// <summary>
        /// Test the property 'Prompt' 
        /// </summary>
        [Test]
        public void PromptTest()
        {
            // TODO: unit test for the property 'Prompt' 
        }
        
        /// <summary>
        /// Test the property 'DisplayValue' 
        /// </summary>
        [Test]
        public void DisplayValueTest()
        {
            // TODO: unit test for the property 'DisplayValue' 
        }
        

    }

}
