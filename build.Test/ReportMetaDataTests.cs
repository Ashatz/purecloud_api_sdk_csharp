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
    public class ReportMetaDataTests
    {
        private ReportMetaData instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ReportMetaData();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ReportMetaData
        /// </summary>
        [Test]
        public void ReportMetaDataInstanceTest()
        {
            Assert.IsInstanceOf<ReportMetaData> (instance, "instance is a ReportMetaData");
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
        /// Test the property 'Name' 
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name' 
        }
        
        /// <summary>
        /// Test the property 'Title' 
        /// </summary>
        [Test]
        public void TitleTest()
        {
            // TODO: unit test for the property 'Title' 
        }
        
        /// <summary>
        /// Test the property 'Description' 
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO: unit test for the property 'Description' 
        }
        
        /// <summary>
        /// Test the property 'Keywords' 
        /// </summary>
        [Test]
        public void KeywordsTest()
        {
            // TODO: unit test for the property 'Keywords' 
        }
        
        /// <summary>
        /// Test the property 'AvailableLocales' 
        /// </summary>
        [Test]
        public void AvailableLocalesTest()
        {
            // TODO: unit test for the property 'AvailableLocales' 
        }
        
        /// <summary>
        /// Test the property 'Parameters' 
        /// </summary>
        [Test]
        public void ParametersTest()
        {
            // TODO: unit test for the property 'Parameters' 
        }
        
        /// <summary>
        /// Test the property 'ExampleUrl' 
        /// </summary>
        [Test]
        public void ExampleUrlTest()
        {
            // TODO: unit test for the property 'ExampleUrl' 
        }
        
        /// <summary>
        /// Test the property 'SelfUri' 
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri' 
        }
        

    }

}
