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
    public class PublicationTests
    {
        private Publication instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Publication();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Publication
        /// </summary>
        [Test]
        public void PublicationInstanceTest()
        {
            Assert.IsInstanceOf<Publication> (instance, "instance is a Publication");
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
        /// Test the property 'TweetText' 
        /// </summary>
        [Test]
        public void TweetTextTest()
        {
            // TODO: unit test for the property 'TweetText' 
        }
        
        /// <summary>
        /// Test the property 'RawTweetText' 
        /// </summary>
        [Test]
        public void RawTweetTextTest()
        {
            // TODO: unit test for the property 'RawTweetText' 
        }
        
        /// <summary>
        /// Test the property 'Approved' 
        /// </summary>
        [Test]
        public void ApprovedTest()
        {
            // TODO: unit test for the property 'Approved' 
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
