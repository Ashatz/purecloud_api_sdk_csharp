using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Model;

namespace ININ.PureCloudApi.Test
{
    [TestFixture]
    public class NotificationsApiTests
    {
        private NotificationsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new NotificationsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NotificationsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<NotificationsApi> (instance, "instance is a NotificationsApi");
        }

        
        /// <summary>
        /// Test GetAvailabletopics
        /// </summary>
        [Test]
        public void GetAvailabletopicsTest()
        {
            // TODO: add unit test for the method 'GetAvailabletopics'
            
            var response = instance.GetAvailabletopics();
            Assert.IsInstanceOf<AvailableTopicEntityListing> (response, "response is AvailableTopicEntityListing"); 
        }
        
        /// <summary>
        /// Test GetChannels
        /// </summary>
        [Test]
        public void GetChannelsTest()
        {
            // TODO: add unit test for the method 'GetChannels'
            
            var response = instance.GetChannels();
            Assert.IsInstanceOf<ChannelEntityListing> (response, "response is ChannelEntityListing"); 
        }
        
        /// <summary>
        /// Test PostChannels
        /// </summary>
        [Test]
        public void PostChannelsTest()
        {
            // TODO: add unit test for the method 'PostChannels'
            
            var response = instance.PostChannels();
            Assert.IsInstanceOf<Channel> (response, "response is Channel"); 
        }
        
        /// <summary>
        /// Test GetChannelSubscriptions
        /// </summary>
        [Test]
        public void GetChannelSubscriptionsTest()
        {
            // TODO: add unit test for the method 'GetChannelSubscriptions'
            string channelId = null; // TODO: replace null with proper value
            
            var response = instance.GetChannelSubscriptions(channelId);
            Assert.IsInstanceOf<ChannelTopicEntityListing> (response, "response is ChannelTopicEntityListing"); 
        }
        
        /// <summary>
        /// Test PutChannelSubscriptions
        /// </summary>
        [Test]
        public void PutChannelSubscriptionsTest()
        {
            // TODO: add unit test for the method 'PutChannelSubscriptions'
            string channelId = null; // TODO: replace null with proper value
            List<ChannelTopic> body = null; // TODO: replace null with proper value
            
            var response = instance.PutChannelSubscriptions(channelId, body);
            Assert.IsInstanceOf<ChannelTopicEntityListing> (response, "response is ChannelTopicEntityListing"); 
        }
        
        /// <summary>
        /// Test PostChannelSubscriptions
        /// </summary>
        [Test]
        public void PostChannelSubscriptionsTest()
        {
            // TODO: add unit test for the method 'PostChannelSubscriptions'
            string channelId = null; // TODO: replace null with proper value
            List<ChannelTopic> body = null; // TODO: replace null with proper value
            
            var response = instance.PostChannelSubscriptions(channelId, body);
            Assert.IsInstanceOf<ChannelTopicEntityListing> (response, "response is ChannelTopicEntityListing"); 
        }
        
        /// <summary>
        /// Test DeleteChannelSubscriptions
        /// </summary>
        [Test]
        public void DeleteChannelSubscriptionsTest()
        {
            // TODO: add unit test for the method 'DeleteChannelSubscriptions'
            string channelId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteChannelSubscriptions(channelId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
    }

}
