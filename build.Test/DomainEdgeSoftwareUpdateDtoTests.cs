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
    public class DomainEdgeSoftwareUpdateDtoTests
    {
        private DomainEdgeSoftwareUpdateDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DomainEdgeSoftwareUpdateDto();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DomainEdgeSoftwareUpdateDto
        /// </summary>
        [Test]
        public void DomainEdgeSoftwareUpdateDtoInstanceTest()
        {
            Assert.IsInstanceOf<DomainEdgeSoftwareUpdateDto> (instance, "instance is a DomainEdgeSoftwareUpdateDto");
        }

        
        /// <summary>
        /// Test the property 'Version' 
        /// </summary>
        [Test]
        public void VersionTest()
        {
            // TODO: unit test for the property 'Version' 
        }
        
        /// <summary>
        /// Test the property 'MaxDownloadRate' 
        /// </summary>
        [Test]
        public void MaxDownloadRateTest()
        {
            // TODO: unit test for the property 'MaxDownloadRate' 
        }
        
        /// <summary>
        /// Test the property 'DownloadStartTime' 
        /// </summary>
        [Test]
        public void DownloadStartTimeTest()
        {
            // TODO: unit test for the property 'DownloadStartTime' 
        }
        
        /// <summary>
        /// Test the property 'ExecuteStartTime' 
        /// </summary>
        [Test]
        public void ExecuteStartTimeTest()
        {
            // TODO: unit test for the property 'ExecuteStartTime' 
        }
        
        /// <summary>
        /// Test the property 'ExecuteStopTime' 
        /// </summary>
        [Test]
        public void ExecuteStopTimeTest()
        {
            // TODO: unit test for the property 'ExecuteStopTime' 
        }
        
        /// <summary>
        /// Test the property 'ExecuteOnIdle' 
        /// </summary>
        [Test]
        public void ExecuteOnIdleTest()
        {
            // TODO: unit test for the property 'ExecuteOnIdle' 
        }
        
        /// <summary>
        /// Test the property 'Status' 
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO: unit test for the property 'Status' 
        }
        
        /// <summary>
        /// Test the property 'EdgeUri' 
        /// </summary>
        [Test]
        public void EdgeUriTest()
        {
            // TODO: unit test for the property 'EdgeUri' 
        }
        
        /// <summary>
        /// Test the property 'Current' 
        /// </summary>
        [Test]
        public void CurrentTest()
        {
            // TODO: unit test for the property 'Current' 
        }
        

    }

}
