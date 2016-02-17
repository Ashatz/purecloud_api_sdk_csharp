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
    public class GistenerTests
    {
        private Gistener instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Gistener();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Gistener
        /// </summary>
        [Test]
        public void GistenerInstanceTest()
        {
            Assert.IsInstanceOf<Gistener> (instance, "instance is a Gistener");
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
        /// Test the property 'Enabled' 
        /// </summary>
        [Test]
        public void EnabledTest()
        {
            // TODO: unit test for the property 'Enabled' 
        }
        
        /// <summary>
        /// Test the property 'AnyWords' 
        /// </summary>
        [Test]
        public void AnyWordsTest()
        {
            // TODO: unit test for the property 'AnyWords' 
        }
        
        /// <summary>
        /// Test the property 'AllWords' 
        /// </summary>
        [Test]
        public void AllWordsTest()
        {
            // TODO: unit test for the property 'AllWords' 
        }
        
        /// <summary>
        /// Test the property 'ExcludeWords' 
        /// </summary>
        [Test]
        public void ExcludeWordsTest()
        {
            // TODO: unit test for the property 'ExcludeWords' 
        }
        
        /// <summary>
        /// Test the property 'ExactPhrase' 
        /// </summary>
        [Test]
        public void ExactPhraseTest()
        {
            // TODO: unit test for the property 'ExactPhrase' 
        }
        
        /// <summary>
        /// Test the property 'GroupTags' 
        /// </summary>
        [Test]
        public void GroupTagsTest()
        {
            // TODO: unit test for the property 'GroupTags' 
        }
        
        /// <summary>
        /// Test the property 'SocialAccount' 
        /// </summary>
        [Test]
        public void SocialAccountTest()
        {
            // TODO: unit test for the property 'SocialAccount' 
        }
        
        /// <summary>
        /// Test the property 'Queue' 
        /// </summary>
        [Test]
        public void QueueTest()
        {
            // TODO: unit test for the property 'Queue' 
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
