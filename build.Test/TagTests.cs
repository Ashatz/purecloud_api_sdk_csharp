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
    public class TagTests
    {
        private Tag instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Tag();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Tag
        /// </summary>
        [Test]
        public void TagInstanceTest()
        {
            Assert.IsInstanceOf<Tag> (instance, "instance is a Tag");
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
        /// Test the property 'InteractionFlag' 
        /// </summary>
        [Test]
        public void InteractionFlagTest()
        {
            // TODO: unit test for the property 'InteractionFlag' 
        }
        

    }

}
