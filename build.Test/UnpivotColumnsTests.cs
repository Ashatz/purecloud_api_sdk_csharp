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
    public class UnpivotColumnsTests
    {
        private UnpivotColumns instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UnpivotColumns();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of UnpivotColumns
        /// </summary>
        [Test]
        public void UnpivotColumnsInstanceTest()
        {
            Assert.IsInstanceOf<UnpivotColumns> (instance, "instance is a UnpivotColumns");
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
