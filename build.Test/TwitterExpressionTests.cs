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
    public class TwitterExpressionTests
    {
        private TwitterExpression instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TwitterExpression();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of TwitterExpression
        /// </summary>
        [Test]
        public void TwitterExpressionInstanceTest()
        {
            Assert.IsInstanceOf<TwitterExpression> (instance, "instance is a TwitterExpression");
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
        /// Test the property 'IsDispositioned' 
        /// </summary>
        [Test]
        public void IsDispositionedTest()
        {
            // TODO: unit test for the property 'IsDispositioned' 
        }
        
        /// <summary>
        /// Test the property 'IsNoise' 
        /// </summary>
        [Test]
        public void IsNoiseTest()
        {
            // TODO: unit test for the property 'IsNoise' 
        }
        
        /// <summary>
        /// Test the property 'Gistener' 
        /// </summary>
        [Test]
        public void GistenerTest()
        {
            // TODO: unit test for the property 'Gistener' 
        }
        
        /// <summary>
        /// Test the property 'TweetId' 
        /// </summary>
        [Test]
        public void TweetIdTest()
        {
            // TODO: unit test for the property 'TweetId' 
        }
        
        /// <summary>
        /// Test the property 'Text' 
        /// </summary>
        [Test]
        public void TextTest()
        {
            // TODO: unit test for the property 'Text' 
        }
        
        /// <summary>
        /// Test the property 'TweetCreated' 
        /// </summary>
        [Test]
        public void TweetCreatedTest()
        {
            // TODO: unit test for the property 'TweetCreated' 
        }
        
        /// <summary>
        /// Test the property 'IsReply' 
        /// </summary>
        [Test]
        public void IsReplyTest()
        {
            // TODO: unit test for the property 'IsReply' 
        }
        
        /// <summary>
        /// Test the property 'IsRetweet' 
        /// </summary>
        [Test]
        public void IsRetweetTest()
        {
            // TODO: unit test for the property 'IsRetweet' 
        }
        
        /// <summary>
        /// Test the property 'RetweetParentId' 
        /// </summary>
        [Test]
        public void RetweetParentIdTest()
        {
            // TODO: unit test for the property 'RetweetParentId' 
        }
        
        /// <summary>
        /// Test the property 'RetweetCount' 
        /// </summary>
        [Test]
        public void RetweetCountTest()
        {
            // TODO: unit test for the property 'RetweetCount' 
        }
        
        /// <summary>
        /// Test the property 'IsQuotedTweet' 
        /// </summary>
        [Test]
        public void IsQuotedTweetTest()
        {
            // TODO: unit test for the property 'IsQuotedTweet' 
        }
        
        /// <summary>
        /// Test the property 'QuotedParentId' 
        /// </summary>
        [Test]
        public void QuotedParentIdTest()
        {
            // TODO: unit test for the property 'QuotedParentId' 
        }
        
        /// <summary>
        /// Test the property 'UserId' 
        /// </summary>
        [Test]
        public void UserIdTest()
        {
            // TODO: unit test for the property 'UserId' 
        }
        
        /// <summary>
        /// Test the property 'UserName' 
        /// </summary>
        [Test]
        public void UserNameTest()
        {
            // TODO: unit test for the property 'UserName' 
        }
        
        /// <summary>
        /// Test the property 'UserScreenName' 
        /// </summary>
        [Test]
        public void UserScreenNameTest()
        {
            // TODO: unit test for the property 'UserScreenName' 
        }
        
        /// <summary>
        /// Test the property 'UserTweetCount' 
        /// </summary>
        [Test]
        public void UserTweetCountTest()
        {
            // TODO: unit test for the property 'UserTweetCount' 
        }
        
        /// <summary>
        /// Test the property 'UserFollowersCount' 
        /// </summary>
        [Test]
        public void UserFollowersCountTest()
        {
            // TODO: unit test for the property 'UserFollowersCount' 
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
        /// Test the property 'Routed' 
        /// </summary>
        [Test]
        public void RoutedTest()
        {
            // TODO: unit test for the property 'Routed' 
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