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
    public class ContentAttributeFilterItemTests
    {
        private ContentAttributeFilterItem instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ContentAttributeFilterItem();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ContentAttributeFilterItem
        /// </summary>
        [Test]
        public void ContentAttributeFilterItemInstanceTest()
        {
            Assert.IsInstanceOf<ContentAttributeFilterItem> (instance, "instance is a ContentAttributeFilterItem");
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
        /// Test the property 'Operator' 
        /// </summary>
        [Test]
        public void OperatorTest()
        {
            // TODO: unit test for the property 'Operator' 
        }
        
        /// <summary>
        /// Test the property 'Values' 
        /// </summary>
        [Test]
        public void ValuesTest()
        {
            // TODO: unit test for the property 'Values' 
        }
        

    }

}
