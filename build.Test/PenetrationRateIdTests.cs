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
    public class PenetrationRateIdTests
    {
        private PenetrationRateId instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PenetrationRateId();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of PenetrationRateId
        /// </summary>
        [Test]
        public void PenetrationRateIdInstanceTest()
        {
            Assert.IsInstanceOf<PenetrationRateId> (instance, "instance is a PenetrationRateId");
        }

        
        /// <summary>
        /// Test the property 'ContactList' 
        /// </summary>
        [Test]
        public void ContactListTest()
        {
            // TODO: unit test for the property 'ContactList' 
        }
        
        /// <summary>
        /// Test the property 'Qualifier' 
        /// </summary>
        [Test]
        public void QualifierTest()
        {
            // TODO: unit test for the property 'Qualifier' 
        }
        

    }

}
