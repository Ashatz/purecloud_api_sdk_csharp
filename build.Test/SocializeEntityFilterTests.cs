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
    public class SocializeEntityFilterTests
    {
        private SocializeEntityFilter instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SocializeEntityFilter();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of SocializeEntityFilter
        /// </summary>
        [Test]
        public void SocializeEntityFilterInstanceTest()
        {
            Assert.IsInstanceOf<SocializeEntityFilter> (instance, "instance is a SocializeEntityFilter");
        }

        
        /// <summary>
        /// Test the property 'FieldName' 
        /// </summary>
        [Test]
        public void FieldNameTest()
        {
            // TODO: unit test for the property 'FieldName' 
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
        /// Test the property 'FieldValue' 
        /// </summary>
        [Test]
        public void FieldValueTest()
        {
            // TODO: unit test for the property 'FieldValue' 
        }
        

    }

}
