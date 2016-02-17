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
    public class GroupImagesTests
    {
        private GroupImages instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GroupImages();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of GroupImages
        /// </summary>
        [Test]
        public void GroupImagesInstanceTest()
        {
            Assert.IsInstanceOf<GroupImages> (instance, "instance is a GroupImages");
        }

        
        /// <summary>
        /// Test the property 'ActiveImages' 
        /// </summary>
        [Test]
        public void ActiveImagesTest()
        {
            // TODO: unit test for the property 'ActiveImages' 
        }
        

    }

}
