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
    public class ReportScheduleTests
    {
        private ReportSchedule instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ReportSchedule();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ReportSchedule
        /// </summary>
        [Test]
        public void ReportScheduleInstanceTest()
        {
            Assert.IsInstanceOf<ReportSchedule> (instance, "instance is a ReportSchedule");
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
        /// Test the property 'QuartzCronExpression' 
        /// </summary>
        [Test]
        public void QuartzCronExpressionTest()
        {
            // TODO: unit test for the property 'QuartzCronExpression' 
        }
        
        /// <summary>
        /// Test the property 'NextFireTime' 
        /// </summary>
        [Test]
        public void NextFireTimeTest()
        {
            // TODO: unit test for the property 'NextFireTime' 
        }
        
        /// <summary>
        /// Test the property 'DateCreated' 
        /// </summary>
        [Test]
        public void DateCreatedTest()
        {
            // TODO: unit test for the property 'DateCreated' 
        }
        
        /// <summary>
        /// Test the property 'DateModified' 
        /// </summary>
        [Test]
        public void DateModifiedTest()
        {
            // TODO: unit test for the property 'DateModified' 
        }
        
        /// <summary>
        /// Test the property 'Description' 
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO: unit test for the property 'Description' 
        }
        
        /// <summary>
        /// Test the property 'TimeZone' 
        /// </summary>
        [Test]
        public void TimeZoneTest()
        {
            // TODO: unit test for the property 'TimeZone' 
        }
        
        /// <summary>
        /// Test the property 'TimePeriod' 
        /// </summary>
        [Test]
        public void TimePeriodTest()
        {
            // TODO: unit test for the property 'TimePeriod' 
        }
        
        /// <summary>
        /// Test the property 'Interval' 
        /// </summary>
        [Test]
        public void IntervalTest()
        {
            // TODO: unit test for the property 'Interval' 
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
        /// Test the property 'Locale' 
        /// </summary>
        [Test]
        public void LocaleTest()
        {
            // TODO: unit test for the property 'Locale' 
        }
        
        /// <summary>
        /// Test the property 'Enabled' 
        /// </summary>
        [Test]
        public void EnabledTest()
        {
            // TODO: unit test for the property 'Enabled' 
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
        /// Test the property 'Parameters' 
        /// </summary>
        [Test]
        public void ParametersTest()
        {
            // TODO: unit test for the property 'Parameters' 
        }
        
        /// <summary>
        /// Test the property 'LastRun' 
        /// </summary>
        [Test]
        public void LastRunTest()
        {
            // TODO: unit test for the property 'LastRun' 
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
