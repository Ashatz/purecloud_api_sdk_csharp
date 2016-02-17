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
    public class UserParamTests
    {
        private UserParam instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserParam();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of UserParam
        /// </summary>
        [Test]
        public void UserParamInstanceTest()
        {
            Assert.IsInstanceOf<UserParam> (instance, "instance is a UserParam");
        }

        
        /// <summary>
        /// Test the property 'Key' 
        /// </summary>
        [Test]
        public void KeyTest()
        {
            // TODO: unit test for the property 'Key' 
        }
        
        /// <summary>
        /// Test the property 'Value' 
        /// </summary>
        [Test]
        public void ValueTest()
        {
            // TODO: unit test for the property 'Value' 
        }
        

    }

}
