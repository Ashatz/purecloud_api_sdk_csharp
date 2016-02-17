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
    public class ContractTests
    {
        private Contract instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Contract();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Contract
        /// </summary>
        [Test]
        public void ContractInstanceTest()
        {
            Assert.IsInstanceOf<Contract> (instance, "instance is a Contract");
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
        /// Test the property 'Quote' 
        /// </summary>
        [Test]
        public void QuoteTest()
        {
            // TODO: unit test for the property 'Quote' 
        }
        
        /// <summary>
        /// Test the property 'SignerUrl' 
        /// </summary>
        [Test]
        public void SignerUrlTest()
        {
            // TODO: unit test for the property 'SignerUrl' 
        }
        
        /// <summary>
        /// Test the property 'Job' 
        /// </summary>
        [Test]
        public void JobTest()
        {
            // TODO: unit test for the property 'Job' 
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
