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
    public class TagModelTests
    {
        private TagModel instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TagModel();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of TagModel
        /// </summary>
        [Test]
        public void TagModelInstanceTest()
        {
            Assert.IsInstanceOf<TagModel> (instance, "instance is a TagModel");
        }

        
        /// <summary>
        /// Test the property 'Key' 
        /// </summary>
        [Test]
        public void KeyTest()
        {
            // TODO: unit test for the property 'Key' 
        }
        
        /// <summary>
        /// Test the property 'Value' 
        /// </summary>
        [Test]
        public void ValueTest()
        {
            // TODO: unit test for the property 'Value' 
        }
        

    }

}
