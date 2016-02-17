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
    public class EmbeddedSignatureViewTests
    {
        private EmbeddedSignatureView instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EmbeddedSignatureView();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of EmbeddedSignatureView
        /// </summary>
        [Test]
        public void EmbeddedSignatureViewInstanceTest()
        {
            Assert.IsInstanceOf<EmbeddedSignatureView> (instance, "instance is a EmbeddedSignatureView");
        }

        
        /// <summary>
        /// Test the property 'View' 
        /// </summary>
        [Test]
        public void ViewTest()
        {
            // TODO: unit test for the property 'View' 
        }
        

    }

}
