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
    public class AuditChangeTests
    {
        private AuditChange instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AuditChange();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of AuditChange
        /// </summary>
        [Test]
        public void AuditChangeInstanceTest()
        {
            Assert.IsInstanceOf<AuditChange> (instance, "instance is a AuditChange");
        }

        
        /// <summary>
        /// Test the property 'Property' 
        /// </summary>
        [Test]
        public void PropertyTest()
        {
            // TODO: unit test for the property 'Property' 
        }
        
        /// <summary>
        /// Test the property 'Entity' 
        /// </summary>
        [Test]
        public void EntityTest()
        {
            // TODO: unit test for the property 'Entity' 
        }
        
        /// <summary>
        /// Test the property 'OldValues' 
        /// </summary>
        [Test]
        public void OldValuesTest()
        {
            // TODO: unit test for the property 'OldValues' 
        }
        
        /// <summary>
        /// Test the property 'NewValues' 
        /// </summary>
        [Test]
        public void NewValuesTest()
        {
            // TODO: unit test for the property 'NewValues' 
        }
        

    }

}
