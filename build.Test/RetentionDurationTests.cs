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
    public class RetentionDurationTests
    {
        private RetentionDuration instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RetentionDuration();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of RetentionDuration
        /// </summary>
        [Test]
        public void RetentionDurationInstanceTest()
        {
            Assert.IsInstanceOf<RetentionDuration> (instance, "instance is a RetentionDuration");
        }

        
        /// <summary>
        /// Test the property 'ArchiveRetention' 
        /// </summary>
        [Test]
        public void ArchiveRetentionTest()
        {
            // TODO: unit test for the property 'ArchiveRetention' 
        }
        
        /// <summary>
        /// Test the property 'DeleteRetention' 
        /// </summary>
        [Test]
        public void DeleteRetentionTest()
        {
            // TODO: unit test for the property 'DeleteRetention' 
        }
        

    }

}
