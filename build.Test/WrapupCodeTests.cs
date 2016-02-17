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
    public class WrapupCodeTests
    {
        private WrapupCode instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WrapupCode();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of WrapupCode
        /// </summary>
        [Test]
        public void WrapupCodeInstanceTest()
        {
            Assert.IsInstanceOf<WrapupCode> (instance, "instance is a WrapupCode");
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
        /// Test the property 'Code' 
        /// </summary>
        [Test]
        public void CodeTest()
        {
            // TODO: unit test for the property 'Code' 
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
        /// Test the property 'Notes' 
        /// </summary>
        [Test]
        public void NotesTest()
        {
            // TODO: unit test for the property 'Notes' 
        }
        
        /// <summary>
        /// Test the property 'Tags' 
        /// </summary>
        [Test]
        public void TagsTest()
        {
            // TODO: unit test for the property 'Tags' 
        }
        
        /// <summary>
        /// Test the property 'Duration' 
        /// </summary>
        [Test]
        public void DurationTest()
        {
            // TODO: unit test for the property 'Duration' 
        }
        

    }

}
