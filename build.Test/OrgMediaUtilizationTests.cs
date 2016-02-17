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
    public class OrgMediaUtilizationTests
    {
        private OrgMediaUtilization instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrgMediaUtilization();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of OrgMediaUtilization
        /// </summary>
        [Test]
        public void OrgMediaUtilizationInstanceTest()
        {
            Assert.IsInstanceOf<OrgMediaUtilization> (instance, "instance is a OrgMediaUtilization");
        }

        
        /// <summary>
        /// Test the property 'MaximumCapacity' 
        /// </summary>
        [Test]
        public void MaximumCapacityTest()
        {
            // TODO: unit test for the property 'MaximumCapacity' 
        }
        
        /// <summary>
        /// Test the property 'InterruptableMediaTypes' 
        /// </summary>
        [Test]
        public void InterruptableMediaTypesTest()
        {
            // TODO: unit test for the property 'InterruptableMediaTypes' 
        }
        

    }

}
