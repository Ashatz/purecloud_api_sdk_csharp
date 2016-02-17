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
    public class ImportStatusTests
    {
        private ImportStatus instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ImportStatus();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ImportStatus
        /// </summary>
        [Test]
        public void ImportStatusInstanceTest()
        {
            Assert.IsInstanceOf<ImportStatus> (instance, "instance is a ImportStatus");
        }

        
        /// <summary>
        /// Test the property 'State' 
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO: unit test for the property 'State' 
        }
        
        /// <summary>
        /// Test the property 'TotalRecords' 
        /// </summary>
        [Test]
        public void TotalRecordsTest()
        {
            // TODO: unit test for the property 'TotalRecords' 
        }
        
        /// <summary>
        /// Test the property 'CompletedRecords' 
        /// </summary>
        [Test]
        public void CompletedRecordsTest()
        {
            // TODO: unit test for the property 'CompletedRecords' 
        }
        
        /// <summary>
        /// Test the property 'PercentComplete' 
        /// </summary>
        [Test]
        public void PercentCompleteTest()
        {
            // TODO: unit test for the property 'PercentComplete' 
        }
        
        /// <summary>
        /// Test the property 'FailureReason' 
        /// </summary>
        [Test]
        public void FailureReasonTest()
        {
            // TODO: unit test for the property 'FailureReason' 
        }
        

    }

}
