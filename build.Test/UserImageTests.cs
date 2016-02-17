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
    public class UserImageTests
    {
        private UserImage instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserImage();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of UserImage
        /// </summary>
        [Test]
        public void UserImageInstanceTest()
        {
            Assert.IsInstanceOf<UserImage> (instance, "instance is a UserImage");
        }

        
        /// <summary>
        /// Test the property 'Resolution' 
        /// </summary>
        [Test]
        public void ResolutionTest()
        {
            // TODO: unit test for the property 'Resolution' 
        }
        
        /// <summary>
        /// Test the property 'ImageUri' 
        /// </summary>
        [Test]
        public void ImageUriTest()
        {
            // TODO: unit test for the property 'ImageUri' 
        }
        

    }

}
