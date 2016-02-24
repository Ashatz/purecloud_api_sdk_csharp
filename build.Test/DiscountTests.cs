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
    public class DiscountTests
    {
        private Discount instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Discount();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Discount
        /// </summary>
        [Test]
        public void DiscountInstanceTest()
        {
            Assert.IsInstanceOf<Discount> (instance, "instance is a Discount");
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
        /// Test the property 'AnnualPrePay' 
        /// </summary>
        [Test]
        public void AnnualPrePayTest()
        {
            // TODO: unit test for the property 'AnnualPrePay' 
        }
        
        /// <summary>
        /// Test the property '_Discount' 
        /// </summary>
        [Test]
        public void _DiscountTest()
        {
            // TODO: unit test for the property '_Discount' 
        }
        
        /// <summary>
        /// Test the property 'Maximum' 
        /// </summary>
        [Test]
        public void MaximumTest()
        {
            // TODO: unit test for the property 'Maximum' 
        }
        
        /// <summary>
        /// Test the property 'Minimum' 
        /// </summary>
        [Test]
        public void MinimumTest()
        {
            // TODO: unit test for the property 'Minimum' 
        }
        
        /// <summary>
        /// Test the property 'ProductCategory' 
        /// </summary>
        [Test]
        public void ProductCategoryTest()
        {
            // TODO: unit test for the property 'ProductCategory' 
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
