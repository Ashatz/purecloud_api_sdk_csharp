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
    public class DomainEdgeSoftwareVersionDtoTests
    {
        private DomainEdgeSoftwareVersionDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DomainEdgeSoftwareVersionDto();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DomainEdgeSoftwareVersionDto
        /// </summary>
        [Test]
        public void DomainEdgeSoftwareVersionDtoInstanceTest()
        {
            Assert.IsInstanceOf<DomainEdgeSoftwareVersionDto> (instance, "instance is a DomainEdgeSoftwareVersionDto");
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
        /// Test the property 'EdgeVersion' 
        /// </summary>
        [Test]
        public void EdgeVersionTest()
        {
            // TODO: unit test for the property 'EdgeVersion' 
        }
        
        /// <summary>
        /// Test the property 'PublishDate' 
        /// </summary>
        [Test]
        public void PublishDateTest()
        {
            // TODO: unit test for the property 'PublishDate' 
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
        
        /// <summary>
        /// Test the property 'LatestRelease' 
        /// </summary>
        [Test]
        public void LatestReleaseTest()
        {
            // TODO: unit test for the property 'LatestRelease' 
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
