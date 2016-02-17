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
    public class CoverSheetTests
    {
        private CoverSheet instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CoverSheet();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of CoverSheet
        /// </summary>
        [Test]
        public void CoverSheetInstanceTest()
        {
            Assert.IsInstanceOf<CoverSheet> (instance, "instance is a CoverSheet");
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
        /// Test the property 'Locale' 
        /// </summary>
        [Test]
        public void LocaleTest()
        {
            // TODO: unit test for the property 'Locale' 
        }
        

    }

}
