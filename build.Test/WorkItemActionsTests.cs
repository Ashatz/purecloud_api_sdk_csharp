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
    public class WorkItemActionsTests
    {
        private WorkItemActions instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WorkItemActions();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of WorkItemActions
        /// </summary>
        [Test]
        public void WorkItemActionsInstanceTest()
        {
            Assert.IsInstanceOf<WorkItemActions> (instance, "instance is a WorkItemActions");
        }

        
        /// <summary>
        /// Test the property 'CanSubmit' 
        /// </summary>
        [Test]
        public void CanSubmitTest()
        {
            // TODO: unit test for the property 'CanSubmit' 
        }
        

    }

}
