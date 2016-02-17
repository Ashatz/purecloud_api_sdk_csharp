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
    public class ArchiveRetentionTests
    {
        private ArchiveRetention instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ArchiveRetention();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ArchiveRetention
        /// </summary>
        [Test]
        public void ArchiveRetentionInstanceTest()
        {
            Assert.IsInstanceOf<ArchiveRetention> (instance, "instance is a ArchiveRetention");
        }

        
        /// <summary>
        /// Test the property 'Days' 
        /// </summary>
        [Test]
        public void DaysTest()
        {
            // TODO: unit test for the property 'Days' 
        }
        
        /// <summary>
        /// Test the property 'StorageMedium' 
        /// </summary>
        [Test]
        public void StorageMediumTest()
        {
            // TODO: unit test for the property 'StorageMedium' 
        }
        

    }

}