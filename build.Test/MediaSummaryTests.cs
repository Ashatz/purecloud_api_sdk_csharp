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
    public class MediaSummaryTests
    {
        private MediaSummary instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MediaSummary();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of MediaSummary
        /// </summary>
        [Test]
        public void MediaSummaryInstanceTest()
        {
            Assert.IsInstanceOf<MediaSummary> (instance, "instance is a MediaSummary");
        }

        
        /// <summary>
        /// Test the property 'ContactCenter' 
        /// </summary>
        [Test]
        public void ContactCenterTest()
        {
            // TODO: unit test for the property 'ContactCenter' 
        }
        
        /// <summary>
        /// Test the property 'Enterprise' 
        /// </summary>
        [Test]
        public void EnterpriseTest()
        {
            // TODO: unit test for the property 'Enterprise' 
        }
        

    }

}
