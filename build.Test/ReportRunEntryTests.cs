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
    public class ReportRunEntryTests
    {
        private ReportRunEntry instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ReportRunEntry();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ReportRunEntry
        /// </summary>
        [Test]
        public void ReportRunEntryInstanceTest()
        {
            Assert.IsInstanceOf<ReportRunEntry> (instance, "instance is a ReportRunEntry");
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
        /// Test the property 'ReportId' 
        /// </summary>
        [Test]
        public void ReportIdTest()
        {
            // TODO: unit test for the property 'ReportId' 
        }
        
        /// <summary>
        /// Test the property 'RunTime' 
        /// </summary>
        [Test]
        public void RunTimeTest()
        {
            // TODO: unit test for the property 'RunTime' 
        }
        
        /// <summary>
        /// Test the property 'RunStatus' 
        /// </summary>
        [Test]
        public void RunStatusTest()
        {
            // TODO: unit test for the property 'RunStatus' 
        }
        
        /// <summary>
        /// Test the property 'ErrorMessage' 
        /// </summary>
        [Test]
        public void ErrorMessageTest()
        {
            // TODO: unit test for the property 'ErrorMessage' 
        }
        
        /// <summary>
        /// Test the property 'RunDurationMsec' 
        /// </summary>
        [Test]
        public void RunDurationMsecTest()
        {
            // TODO: unit test for the property 'RunDurationMsec' 
        }
        
        /// <summary>
        /// Test the property 'ReportUrl' 
        /// </summary>
        [Test]
        public void ReportUrlTest()
        {
            // TODO: unit test for the property 'ReportUrl' 
        }
        
        /// <summary>
        /// Test the property 'ReportFormat' 
        /// </summary>
        [Test]
        public void ReportFormatTest()
        {
            // TODO: unit test for the property 'ReportFormat' 
        }
        
        /// <summary>
        /// Test the property 'ScheduleUri' 
        /// </summary>
        [Test]
        public void ScheduleUriTest()
        {
            // TODO: unit test for the property 'ScheduleUri' 
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
