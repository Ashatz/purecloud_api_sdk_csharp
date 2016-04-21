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
    public class BackendWorkItemDataElementTests
    {
        private BackendWorkItemDataElement instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BackendWorkItemDataElement();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of BackendWorkItemDataElement
        /// </summary>
        [Test]
        public void BackendWorkItemDataElementInstanceTest()
        {
            Assert.IsInstanceOf<BackendWorkItemDataElement> (instance, "instance is a BackendWorkItemDataElement");
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
        /// Test the property 'Prompt' 
        /// </summary>
        [Test]
        public void PromptTest()
        {
            // TODO: unit test for the property 'Prompt' 
        }
        
        /// <summary>
        /// Test the property 'DataItemId' 
        /// </summary>
        [Test]
        public void DataItemIdTest()
        {
            // TODO: unit test for the property 'DataItemId' 
        }
        
        /// <summary>
        /// Test the property 'ControlType' 
        /// </summary>
        [Test]
        public void ControlTypeTest()
        {
            // TODO: unit test for the property 'ControlType' 
        }
        

    }

}
