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
    public class LockInfoTests
    {
        private LockInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LockInfo();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of LockInfo
        /// </summary>
        [Test]
        public void LockInfoInstanceTest()
        {
            Assert.IsInstanceOf<LockInfo> (instance, "instance is a LockInfo");
        }

        
        /// <summary>
        /// Test the property 'LockedBy' 
        /// </summary>
        [Test]
        public void LockedByTest()
        {
            // TODO: unit test for the property 'LockedBy' 
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
        /// Test the property 'DateExpires' 
        /// </summary>
        [Test]
        public void DateExpiresTest()
        {
            // TODO: unit test for the property 'DateExpires' 
        }
        
        /// <summary>
        /// Test the property 'Action' 
        /// </summary>
        [Test]
        public void ActionTest()
        {
            // TODO: unit test for the property 'Action' 
        }
        

    }

}
