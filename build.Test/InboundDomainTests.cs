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
    public class InboundDomainTests
    {
        private InboundDomain instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new InboundDomain();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of InboundDomain
        /// </summary>
        [Test]
        public void InboundDomainInstanceTest()
        {
            Assert.IsInstanceOf<InboundDomain> (instance, "instance is a InboundDomain");
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
        /// Test the property 'MxRecordStatus' 
        /// </summary>
        [Test]
        public void MxRecordStatusTest()
        {
            // TODO: unit test for the property 'MxRecordStatus' 
        }
        
        /// <summary>
        /// Test the property 'SubDomain' 
        /// </summary>
        [Test]
        public void SubDomainTest()
        {
            // TODO: unit test for the property 'SubDomain' 
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
