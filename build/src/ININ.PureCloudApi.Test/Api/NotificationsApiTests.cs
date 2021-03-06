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
    /// <summary>
    ///  Class for testing NotificationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
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
        /// Test DeleteChannelsChannelIdSubscriptions
        /// </summary>
        [Test]
        public void DeleteChannelsChannelIdSubscriptionsTest()
        {
            // TODO: add unit test for the method 'DeleteChannelsChannelIdSubscriptions'
            string channelId = null; // TODO: replace null with proper value
            var response = instance.DeleteChannelsChannelIdSubscriptions(channelId);
            Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetAvailabletopics
        /// </summary>
        [Test]
        public void GetAvailabletopicsTest()
        {
            // TODO: add unit test for the method 'GetAvailabletopics'
            List<string> expand = null; // TODO: replace null with proper value
            var response = instance.GetAvailabletopics(expand);
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
        /// Test GetChannelsChannelIdSubscriptions
        /// </summary>
        [Test]
        public void GetChannelsChannelIdSubscriptionsTest()
        {
            // TODO: add unit test for the method 'GetChannelsChannelIdSubscriptions'
            string channelId = null; // TODO: replace null with proper value
            var response = instance.GetChannelsChannelIdSubscriptions(channelId);
            Assert.IsInstanceOf<ChannelTopicEntityListing> (response, "response is ChannelTopicEntityListing");
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
        /// Test PostChannelsChannelIdSubscriptions
        /// </summary>
        [Test]
        public void PostChannelsChannelIdSubscriptionsTest()
        {
            // TODO: add unit test for the method 'PostChannelsChannelIdSubscriptions'
            string channelId = null; // TODO: replace null with proper value
            List<ChannelTopic> body = null; // TODO: replace null with proper value
            var response = instance.PostChannelsChannelIdSubscriptions(channelId, body);
            Assert.IsInstanceOf<ChannelTopicEntityListing> (response, "response is ChannelTopicEntityListing");
        }
        
        /// <summary>
        /// Test PutChannelsChannelIdSubscriptions
        /// </summary>
        [Test]
        public void PutChannelsChannelIdSubscriptionsTest()
        {
            // TODO: add unit test for the method 'PutChannelsChannelIdSubscriptions'
            string channelId = null; // TODO: replace null with proper value
            List<ChannelTopic> body = null; // TODO: replace null with proper value
            var response = instance.PutChannelsChannelIdSubscriptions(channelId, body);
            Assert.IsInstanceOf<ChannelTopicEntityListing> (response, "response is ChannelTopicEntityListing");
        }
        
    }

}
