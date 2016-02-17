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
    public class IVRTests
    {
        private IVR instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new IVR();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of IVR
        /// </summary>
        [Test]
        public void IVRInstanceTest()
        {
            Assert.IsInstanceOf<IVR> (instance, "instance is a IVR");
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
        /// Test the property 'Description' 
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO: unit test for the property 'Description' 
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
        /// Test the property 'ModifiedBy' 
        /// </summary>
        [Test]
        public void ModifiedByTest()
        {
            // TODO: unit test for the property 'ModifiedBy' 
        }
        
        /// <summary>
        /// Test the property 'CreatedBy' 
        /// </summary>
        [Test]
        public void CreatedByTest()
        {
            // TODO: unit test for the property 'CreatedBy' 
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
        /// Test the property 'ModifiedByApp' 
        /// </summary>
        [Test]
        public void ModifiedByAppTest()
        {
            // TODO: unit test for the property 'ModifiedByApp' 
        }
        
        /// <summary>
        /// Test the property 'CreatedByApp' 
        /// </summary>
        [Test]
        public void CreatedByAppTest()
        {
            // TODO: unit test for the property 'CreatedByApp' 
        }
        
        /// <summary>
        /// Test the property 'IvrUri' 
        /// </summary>
        [Test]
        public void IvrUriTest()
        {
            // TODO: unit test for the property 'IvrUri' 
        }
        
        /// <summary>
        /// Test the property 'Dnis' 
        /// </summary>
        [Test]
        public void DnisTest()
        {
            // TODO: unit test for the property 'Dnis' 
        }
        
        /// <summary>
        /// Test the property 'FlowId' 
        /// </summary>
        [Test]
        public void FlowIdTest()
        {
            // TODO: unit test for the property 'FlowId' 
        }
        
        /// <summary>
        /// Test the property 'ScheduleId' 
        /// </summary>
        [Test]
        public void ScheduleIdTest()
        {
            // TODO: unit test for the property 'ScheduleId' 
        }
        
        /// <summary>
        /// Test the property 'OpenHoursFlow' 
        /// </summary>
        [Test]
        public void OpenHoursFlowTest()
        {
            // TODO: unit test for the property 'OpenHoursFlow' 
        }
        
        /// <summary>
        /// Test the property 'ClosedHoursFlow' 
        /// </summary>
        [Test]
        public void ClosedHoursFlowTest()
        {
            // TODO: unit test for the property 'ClosedHoursFlow' 
        }
        
        /// <summary>
        /// Test the property 'ScheduleGroup' 
        /// </summary>
        [Test]
        public void ScheduleGroupTest()
        {
            // TODO: unit test for the property 'ScheduleGroup' 
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
