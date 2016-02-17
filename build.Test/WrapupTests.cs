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
    public class WrapupTests
    {
        private Wrapup instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Wrapup();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Wrapup
        /// </summary>
        [Test]
        public void WrapupInstanceTest()
        {
            Assert.IsInstanceOf<Wrapup> (instance, "instance is a Wrapup");
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
        /// Test the property 'Name' 
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name' 
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
        /// Test the property 'DurationSeconds' 
        /// </summary>
        [Test]
        public void DurationSecondsTest()
        {
            // TODO: unit test for the property 'DurationSeconds' 
        }
        
        /// <summary>
        /// Test the property 'EndTime' 
        /// </summary>
        [Test]
        public void EndTimeTest()
        {
            // TODO: unit test for the property 'EndTime' 
        }
        
        /// <summary>
        /// Test the property 'Provisional' 
        /// </summary>
        [Test]
        public void ProvisionalTest()
        {
            // TODO: unit test for the property 'Provisional' 
        }
        

    }

}
