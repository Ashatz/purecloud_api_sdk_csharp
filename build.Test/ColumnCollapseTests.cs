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
    public class ColumnCollapseTests
    {
        private ColumnCollapse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ColumnCollapse();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ColumnCollapse
        /// </summary>
        [Test]
        public void ColumnCollapseInstanceTest()
        {
            Assert.IsInstanceOf<ColumnCollapse> (instance, "instance is a ColumnCollapse");
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
        /// Test the property 'Columns' 
        /// </summary>
        [Test]
        public void ColumnsTest()
        {
            // TODO: unit test for the property 'Columns' 
        }
        

    }

}
