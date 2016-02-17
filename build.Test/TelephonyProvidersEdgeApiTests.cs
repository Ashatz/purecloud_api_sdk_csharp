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
    public class TelephonyProvidersEdgeApiTests
    {
        private TelephonyProvidersEdgeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new TelephonyProvidersEdgeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TelephonyProvidersEdgeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<TelephonyProvidersEdgeApi> (instance, "instance is a TelephonyProvidersEdgeApi");
        }

        
        /// <summary>
        /// Test GetTelephonyProvidersEdgeEdgegroups
        /// </summary>
        [Test]
        public void GetTelephonyProvidersEdgeEdgegroupsTest()
        {
            // TODO: add unit test for the method 'GetTelephonyProvidersEdgeEdgegroups'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            
            var response = instance.GetTelephonyProvidersEdgeEdgegroups(pageSize, pageNumber, name, sortBy);
            Assert.IsInstanceOf<EdgeGroupEntityListing> (response, "response is EdgeGroupEntityListing"); 
        }
        
        /// <summary>
        /// Test PostTelephonyProvidersEdgeEdgegroups
        /// </summary>
        [Test]
        public void PostTelephonyProvidersEdgeEdgegroupsTest()
        {
            // TODO: add unit test for the method 'PostTelephonyProvidersEdgeEdgegroups'
            EdgeGroup body = null; // TODO: replace null with proper value
            
            var response = instance.PostTelephonyProvidersEdgeEdgegroups(body);
            Assert.IsInstanceOf<EdgeGroup> (response, "response is EdgeGroup"); 
        }
        
        /// <summary>
        /// Test GetTelephonyProvidersEdgeEdgegroup
        /// </summary>
        [Test]
        public void GetTelephonyProvidersEdgeEdgegroupTest()
        {
            // TODO: add unit test for the method 'GetTelephonyProvidersEdgeEdgegroup'
            string edgeGroupId = null; // TODO: replace null with proper value
            
            var response = instance.GetTelephonyProvidersEdgeEdgegroup(edgeGroupId);
            Assert.IsInstanceOf<EdgeGroup> (response, "response is EdgeGroup"); 
        }
        
        /// <summary>
        /// Test PutTelephonyProvidersEdgeEdgegroup
        /// </summary>
        [Test]
        public void PutTelephonyProvidersEdgeEdgegroupTest()
        {
            // TODO: add unit test for the method 'PutTelephonyProvidersEdgeEdgegroup'
            string edgeGroupId = null; // TODO: replace null with proper value
            EdgeGroup body = null; // TODO: replace null with proper value
            
            var response = instance.PutTelephonyProvidersEdgeEdgegroup(edgeGroupId, body);
            Assert.IsInstanceOf<EdgeGroup> (response, "response is EdgeGroup"); 
        }
        
        /// <summary>
        /// Test DeleteTelephonyProvidersEdgeEdgegroup
        /// </summary>
        [Test]
        public void DeleteTelephonyProvidersEdgeEdgegroupTest()
        {
            // TODO: add unit test for the method 'DeleteTelephonyProvidersEdgeEdgegroup'
            string edgeGroupId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteTelephonyProvidersEdgeEdgegroup(edgeGroupId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetTelephonyProvidersEdgeLinebasesettings
        /// </summary>
        [Test]
        public void GetTelephonyProvidersEdgeLinebasesettingsTest()
        {
            // TODO: add unit test for the method 'GetTelephonyProvidersEdgeLinebasesettings'
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetTelephonyProvidersEdgeLinebasesettings(pageNumber, pageSize, sortBy, sortOrder);
            Assert.IsInstanceOf<LineBaseEntityListing> (response, "response is LineBaseEntityListing"); 
        }
        
        /// <summary>
        /// Test GetTelephonyProvidersEdgeLinebasesetting
        /// </summary>
        [Test]
        public void GetTelephonyProvidersEdgeLinebasesettingTest()
        {
            // TODO: add unit test for the method 'GetTelephonyProvidersEdgeLinebasesetting'
            string lineBaseId = null; // TODO: replace null with proper value
            
            var response = instance.GetTelephonyProvidersEdgeLinebasesetting(lineBaseId);
            Assert.IsInstanceOf<LineBase> (response, "response is LineBase"); 
        }
        
        /// <summary>
        /// Test GetTelephonyProvidersEdgeLines
        /// </summary>
        [Test]
        public void GetTelephonyProvidersEdgeLinesTest()
        {
            // TODO: add unit test for the method 'GetTelephonyProvidersEdgeLines'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            
            var response = instance.GetTelephonyProvidersEdgeLines(pageSize, pageNumber, name, sortBy, expand);
            Assert.IsInstanceOf<LineEntityListing> (response, "response is LineEntityListing"); 
        }
        
        /// <summary>
        /// Test GetTelephonyProvidersEdgeLinesTemplate
        /// </summary>
        [Test]
        public void GetTelephonyProvidersEdgeLinesTemplateTest()
        {
            // TODO: add unit test for the method 'GetTelephonyProvidersEdgeLinesTemplate'
            string lineBaseSettingsId = null; // TODO: replace null with proper value
            
            var response = instance.GetTelephonyProvidersEdgeLinesTemplate(lineBaseSettingsId);
            Assert.IsInstanceOf<Line> (response, "response is Line"); 
        }
        
        /// <summary>
        /// Test GetTelephonyProvidersEdgeLine
        /// </summary>
        [Test]
        public void GetTelephonyProvidersEdgeLineTest()
        {
            // TODO: add unit test for the method 'GetTelephonyProvidersEdgeLine'
            string lineId = null; // TODO: replace null with proper value
            
            var response = instance.GetTelephonyProvidersEdgeLine(lineId);
            Assert.IsInstanceOf<Line> (response, "response is Line"); 
        }
        
        /// <summary>
        /// Test GetTelephonyProvidersEdgeOutboundroutes
        /// </summary>
        [Test]
        public void GetTelephonyProvidersEdgeOutboundroutesTest()
        {
            // TODO: add unit test for the method 'GetTelephonyProvidersEdgeOutboundroutes'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string siteId = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            
            var response = instance.GetTelephonyProvidersEdgeOutboundroutes(pageSize, pageNumber, name, siteId, sortBy);
            Assert.IsInstanceOf<OutboundRouteEntityListing> (response, "response is OutboundRouteEntityListing"); 
        }
        
        /// <summary>
        /// Test PostTelephonyProvidersEdgeOutboundroutes
        /// </summary>
        [Test]
        public void PostTelephonyProvidersEdgeOutboundroutesTest()
        {
            // TODO: add unit test for the method 'PostTelephonyProvidersEdgeOutboundroutes'
            OutboundRoute body = null; // TODO: replace null with proper value
            
            var response = instance.PostTelephonyProvidersEdgeOutboundroutes(body);
            Assert.IsInstanceOf<OutboundRoute> (response, "response is OutboundRoute"); 
        }
        
        /// <summary>
        /// Test GetTelephonyProvidersEdgeOutboundroute
        /// </summary>
        [Test]
        public void GetTelephonyProvidersEdgeOutboundrouteTest()
        {
            // TODO: add unit test for the method 'GetTelephonyProvidersEdgeOutboundroute'
            string outboundRouteId = null; // TODO: replace null with proper value
            
            var response = instance.GetTelephonyProvidersEdgeOutboundroute(outboundRouteId);
            Assert.IsInstanceOf<OutboundRoute> (response, "response is OutboundRoute"); 
        }
        
        /// <summary>
        /// Test PutTelephonyProvidersEdgeOutboundroute
        /// </summary>
        [Test]
        public void PutTelephonyProvidersEdgeOutboundrouteTest()
        {
            // TODO: add unit test for the method 'PutTelephonyProvidersEdgeOutboundroute'
            string outboundRouteId = null; // TODO: replace null with proper value
            OutboundRoute body = null; // TODO: replace null with proper value
            
            var response = instance.PutTelephonyProvidersEdgeOutboundroute(outboundRouteId, body);
            Assert.IsInstanceOf<OutboundRoute> (response, "response is OutboundRoute"); 
        }
        
        /// <summary>
        /// Test DeleteTelephonyProvidersEdgeOutboundroute
        /// </summary>
        [Test]
        public void DeleteTelephonyProvidersEdgeOutboundrouteTest()
        {
            // TODO: add unit test for the method 'DeleteTelephonyProvidersEdgeOutboundroute'
            string outboundRouteId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteTelephonyProvidersEdgeOutboundroute(outboundRouteId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetTelephonyProvidersEdgePhonebasesettings
        /// </summary>
        [Test]
        public void GetTelephonyProvidersEdgePhonebasesettingsTest()
        {
            // TODO: add unit test for the method 'GetTelephonyProvidersEdgePhonebasesettings'
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetTelephonyProvidersEdgePhonebasesettings(pageNumber, pageSize, sortBy, sortOrder);
            Assert.IsInstanceOf<PhoneBaseEntityListing> (response, "response is PhoneBaseEntityListing"); 
        }
        
        /// <summary>
        /// Test PostTelephonyProvidersEdgePhonebasesettings
        /// </summary>
        [Test]
        public void PostTelephonyProvidersEdgePhonebasesettingsTest()
        {
            // TODO: add unit test for the method 'PostTelephonyProvidersEdgePhonebasesettings'
            PhoneBase body = null; // TODO: replace null with proper value
            
            var response = instance.PostTelephonyProvidersEdgePhonebasesettings(body);
            Assert.IsInstanceOf<PhoneBase> (response, "response is PhoneBase"); 
        }
        
        /// <summary>
        /// Test GetTelephonyProvidersEdgePhonebasesettingsAvailablemetabases
        /// </summary>
        [Test]
        public void GetTelephonyProvidersEdgePhonebasesettingsAvailablemetabasesTest()
        {
            // TODO: add unit test for the method 'GetTelephonyProvidersEdgePhonebasesettingsAvailablemetabases'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetTelephonyProvidersEdgePhonebasesettingsAvailablemetabases(pageSize, pageNumber);
            Assert.IsInstanceOf<PhoneMetaBaseEntityListing> (response, "response is PhoneMetaBaseEntityListing"); 
        }
        
        /// <summary>
        /// Test GetTelephonyProvidersEdgePhonebasesettingsTemplate
        /// </summary>
        [Test]
        public void GetTelephonyProvidersEdgePhonebasesettingsTemplateTest()
        {
            // TODO: add unit test for the method 'GetTelephonyProvidersEdgePhonebasesettingsTemplate'
            string phoneMetabaseId = null; // TODO: replace null with proper value
            
            var response = instance.GetTelephonyProvidersEdgePhonebasesettingsTemplate(phoneMetabaseId);
            Assert.IsInstanceOf<PhoneBase> (response, "response is PhoneBase"); 
        }
        
        /// <summary>
        /// Test GetTelephonyProvidersEdgePhonebasesetting
        /// </summary>
        [Test]
        public void GetTelephonyProvidersEdgePhonebasesettingTest()
        {
            // TODO: add unit test for the method 'GetTelephonyProvidersEdgePhonebasesetting'
            string phoneBaseId = null; // TODO: replace null with proper value
            
            var response = instance.GetTelephonyProvidersEdgePhonebasesetting(phoneBaseId);
            Assert.IsInstanceOf<PhoneBase> (response, "response is PhoneBase"); 
        }
        
        /// <summary>
        /// Test PutTelephonyProvidersEdgePhonebasesetting
        /// </summary>
        [Test]
        public void PutTelephonyProvidersEdgePhonebasesettingTest()
        {
            // TODO: add unit test for the method 'PutTelephonyProvidersEdgePhonebasesetting'
            string phoneBaseId = null; // TODO: replace null with proper value
            PhoneBase body = null; // TODO: replace null with proper value
            
            var response = instance.PutTelephonyProvidersEdgePhonebasesetting(phoneBaseId, body);
            Assert.IsInstanceOf<PhoneBase> (response, "response is PhoneBase"); 
        }
        
        /// <summary>
        /// Test DeleteTelephonyProvidersEdgePhonebasesetting
        /// </summary>
        [Test]
        public void DeleteTelephonyProvidersEdgePhonebasesettingTest()
        {
            // TODO: add unit test for the method 'DeleteTelephonyProvidersEdgePhonebasesetting'
            string phoneBaseId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteTelephonyProvidersEdgePhonebasesetting(phoneBaseId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetTelephonyProvidersEdgePhones
        /// </summary>
        [Test]
        public void GetTelephonyProvidersEdgePhonesTest()
        {
            // TODO: add unit test for the method 'GetTelephonyProvidersEdgePhones'
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            string siteId = null; // TODO: replace null with proper value
            string phoneBaseSettingsId = null; // TODO: replace null with proper value
            string phoneHardwareId = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            List<string> fields = null; // TODO: replace null with proper value
            
            var response = instance.GetTelephonyProvidersEdgePhones(pageNumber, pageSize, sortBy, sortOrder, siteId, phoneBaseSettingsId, phoneHardwareId, expand, fields);
            Assert.IsInstanceOf<PhoneEntityListing> (response, "response is PhoneEntityListing"); 
        }
        
        /// <summary>
        /// Test PostTelephonyProvidersEdgePhones
        /// </summary>
        [Test]
        public void PostTelephonyProvidersEdgePhonesTest()
        {
            // TODO: add unit test for the method 'PostTelephonyProvidersEdgePhones'
            Phone body = null; // TODO: replace null with proper value
            
            var response = instance.PostTelephonyProvidersEdgePhones(body);
            Assert.IsInstanceOf<Phone> (response, "response is Phone"); 
        }
        
        /// <summary>
        /// Test PostTelephonyProvidersEdgePhonesReboot
        /// </summary>
        [Test]
        public void PostTelephonyProvidersEdgePhonesRebootTest()
        {
            // TODO: add unit test for the method 'PostTelephonyProvidersEdgePhonesReboot'
            PhonesReboot body = null; // TODO: replace null with proper value
            
            instance.PostTelephonyProvidersEdgePhonesReboot(body);
             
        }
        
        /// <summary>
        /// Test GetTelephonyProvidersEdgePhonesTemplate
        /// </summary>
        [Test]
        public void GetTelephonyProvidersEdgePhonesTemplateTest()
        {
            // TODO: add unit test for the method 'GetTelephonyProvidersEdgePhonesTemplate'
            string phoneBaseSettingsId = null; // TODO: replace null with proper value
            
            var response = instance.GetTelephonyProvidersEdgePhonesTemplate(phoneBaseSettingsId);
            Assert.IsInstanceOf<Phone> (response, "response is Phone"); 
        }
        
        /// <summary>
        /// Test GetTelephonyProvidersEdgePhone
        /// </summary>
        [Test]
        public void GetTelephonyProvidersEdgePhoneTest()
        {
            // TODO: add unit test for the method 'GetTelephonyProvidersEdgePhone'
            string phoneId = null; // TODO: replace null with proper value
            
            var response = instance.GetTelephonyProvidersEdgePhone(phoneId);
            Assert.IsInstanceOf<Phone> (response, "response is Phone"); 
        }
        
        /// <summary>
        /// Test PutTelephonyProvidersEdgePhone
        /// </summary>
        [Test]
        public void PutTelephonyProvidersEdgePhoneTest()
        {
            // TODO: add unit test for the method 'PutTelephonyProvidersEdgePhone'
            string phoneId = null; // TODO: replace null with proper value
            Phone body = null; // TODO: replace null with proper value
            
            var response = instance.PutTelephonyProvidersEdgePhone(phoneId, body);
            Assert.IsInstanceOf<Phone> (response, "response is Phone"); 
        }
        
        /// <summary>
        /// Test DeleteTelephonyProvidersEdgePhone
        /// </summary>
        [Test]
        public void DeleteTelephonyProvidersEdgePhoneTest()
        {
            // TODO: add unit test for the method 'DeleteTelephonyProvidersEdgePhone'
            string phoneId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteTelephonyProvidersEdgePhone(phoneId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test PostTelephonyProvidersEdgePhoneReboot
        /// </summary>
        [Test]
        public void PostTelephonyProvidersEdgePhoneRebootTest()
        {
            // TODO: add unit test for the method 'PostTelephonyProvidersEdgePhoneReboot'
            string phoneId = null; // TODO: replace null with proper value
            
            instance.PostTelephonyProvidersEdgePhoneReboot(phoneId);
             
        }
        
        /// <summary>
        /// Test GetTelephonyProvidersEdgeTimezones
        /// </summary>
        [Test]
        public void GetTelephonyProvidersEdgeTimezonesTest()
        {
            // TODO: add unit test for the method 'GetTelephonyProvidersEdgeTimezones'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetTelephonyProvidersEdgeTimezones(pageSize, pageNumber);
            Assert.IsInstanceOf<TimeZoneEntityListing> (response, "response is TimeZoneEntityListing"); 
        }
        
        /// <summary>
        /// Test GetTelephonyProvidersEdgeTrunkbasesettings
        /// </summary>
        [Test]
        public void GetTelephonyProvidersEdgeTrunkbasesettingsTest()
        {
            // TODO: add unit test for the method 'GetTelephonyProvidersEdgeTrunkbasesettings'
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetTelephonyProvidersEdgeTrunkbasesettings(pageNumber, pageSize, sortBy, sortOrder);
            Assert.IsInstanceOf<TrunkBase> (response, "response is TrunkBase"); 
        }
        
        /// <summary>
        /// Test PostTelephonyProvidersEdgeTrunkbasesettings
        /// </summary>
        [Test]
        public void PostTelephonyProvidersEdgeTrunkbasesettingsTest()
        {
            // TODO: add unit test for the method 'PostTelephonyProvidersEdgeTrunkbasesettings'
            TrunkBase body = null; // TODO: replace null with proper value
            
            var response = instance.PostTelephonyProvidersEdgeTrunkbasesettings(body);
            Assert.IsInstanceOf<TrunkBase> (response, "response is TrunkBase"); 
        }
        
        /// <summary>
        /// Test GetTelephonyProvidersEdgeTrunkbasesettingsAvailablemetabases
        /// </summary>
        [Test]
        public void GetTelephonyProvidersEdgeTrunkbasesettingsAvailablemetabasesTest()
        {
            // TODO: add unit test for the method 'GetTelephonyProvidersEdgeTrunkbasesettingsAvailablemetabases'
            string type = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetTelephonyProvidersEdgeTrunkbasesettingsAvailablemetabases(type, pageSize, pageNumber);
            Assert.IsInstanceOf<TrunkMetabaseEntityListing> (response, "response is TrunkMetabaseEntityListing"); 
        }
        
        /// <summary>
        /// Test GetTelephonyProvidersEdgeTrunkbasesettingsTemplate
        /// </summary>
        [Test]
        public void GetTelephonyProvidersEdgeTrunkbasesettingsTemplateTest()
        {
            // TODO: add unit test for the method 'GetTelephonyProvidersEdgeTrunkbasesettingsTemplate'
            string trunkMetabaseId = null; // TODO: replace null with proper value
            
            var response = instance.GetTelephonyProvidersEdgeTrunkbasesettingsTemplate(trunkMetabaseId);
            Assert.IsInstanceOf<TrunkBase> (response, "response is TrunkBase"); 
        }
        
        /// <summary>
        /// Test GetTelephonyProvidersEdgeTrunkbasesetting
        /// </summary>
        [Test]
        public void GetTelephonyProvidersEdgeTrunkbasesettingTest()
        {
            // TODO: add unit test for the method 'GetTelephonyProvidersEdgeTrunkbasesetting'
            string trunkBaseSettingsId = null; // TODO: replace null with proper value
            
            var response = instance.GetTelephonyProvidersEdgeTrunkbasesetting(trunkBaseSettingsId);
            Assert.IsInstanceOf<TrunkBase> (response, "response is TrunkBase"); 
        }
        
        /// <summary>
        /// Test PutTelephonyProvidersEdgeTrunkbasesetting
        /// </summary>
        [Test]
        public void PutTelephonyProvidersEdgeTrunkbasesettingTest()
        {
            // TODO: add unit test for the method 'PutTelephonyProvidersEdgeTrunkbasesetting'
            string trunkBaseSettingsId = null; // TODO: replace null with proper value
            TrunkBase body = null; // TODO: replace null with proper value
            
            var response = instance.PutTelephonyProvidersEdgeTrunkbasesetting(trunkBaseSettingsId, body);
            Assert.IsInstanceOf<TrunkBase> (response, "response is TrunkBase"); 
        }
        
        /// <summary>
        /// Test DeleteTelephonyProvidersEdgeTrunkbasesetting
        /// </summary>
        [Test]
        public void DeleteTelephonyProvidersEdgeTrunkbasesettingTest()
        {
            // TODO: add unit test for the method 'DeleteTelephonyProvidersEdgeTrunkbasesetting'
            string trunkBaseSettingsId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteTelephonyProvidersEdgeTrunkbasesetting(trunkBaseSettingsId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
    }

}
