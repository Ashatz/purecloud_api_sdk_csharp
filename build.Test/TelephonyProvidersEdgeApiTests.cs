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
        /// Test GetProvidersEdgeEdgegroups
        /// </summary>
        [Test]
        public void GetProvidersEdgeEdgegroupsTest()
        {
            // TODO: add unit test for the method 'GetProvidersEdgeEdgegroups'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            
            var response = instance.GetProvidersEdgeEdgegroups(pageSize, pageNumber, name, sortBy);
            Assert.IsInstanceOf<EdgeGroupEntityListing> (response, "response is EdgeGroupEntityListing"); 
        }
        
        /// <summary>
        /// Test PostProvidersEdgeEdgegroups
        /// </summary>
        [Test]
        public void PostProvidersEdgeEdgegroupsTest()
        {
            // TODO: add unit test for the method 'PostProvidersEdgeEdgegroups'
            EdgeGroup body = null; // TODO: replace null with proper value
            
            var response = instance.PostProvidersEdgeEdgegroups(body);
            Assert.IsInstanceOf<EdgeGroup> (response, "response is EdgeGroup"); 
        }
        
        /// <summary>
        /// Test GetProvidersEdgeEdgegroupsEdgegroupId
        /// </summary>
        [Test]
        public void GetProvidersEdgeEdgegroupsEdgegroupIdTest()
        {
            // TODO: add unit test for the method 'GetProvidersEdgeEdgegroupsEdgegroupId'
            string edgeGroupId = null; // TODO: replace null with proper value
            
            var response = instance.GetProvidersEdgeEdgegroupsEdgegroupId(edgeGroupId);
            Assert.IsInstanceOf<EdgeGroup> (response, "response is EdgeGroup"); 
        }
        
        /// <summary>
        /// Test PutProvidersEdgeEdgegroupsEdgegroupId
        /// </summary>
        [Test]
        public void PutProvidersEdgeEdgegroupsEdgegroupIdTest()
        {
            // TODO: add unit test for the method 'PutProvidersEdgeEdgegroupsEdgegroupId'
            string edgeGroupId = null; // TODO: replace null with proper value
            EdgeGroup body = null; // TODO: replace null with proper value
            
            var response = instance.PutProvidersEdgeEdgegroupsEdgegroupId(edgeGroupId, body);
            Assert.IsInstanceOf<EdgeGroup> (response, "response is EdgeGroup"); 
        }
        
        /// <summary>
        /// Test DeleteProvidersEdgeEdgegroupsEdgegroupId
        /// </summary>
        [Test]
        public void DeleteProvidersEdgeEdgegroupsEdgegroupIdTest()
        {
            // TODO: add unit test for the method 'DeleteProvidersEdgeEdgegroupsEdgegroupId'
            string edgeGroupId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteProvidersEdgeEdgegroupsEdgegroupId(edgeGroupId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetProvidersEdgeLinebasesettings
        /// </summary>
        [Test]
        public void GetProvidersEdgeLinebasesettingsTest()
        {
            // TODO: add unit test for the method 'GetProvidersEdgeLinebasesettings'
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetProvidersEdgeLinebasesettings(pageNumber, pageSize, sortBy, sortOrder);
            Assert.IsInstanceOf<LineBaseEntityListing> (response, "response is LineBaseEntityListing"); 
        }
        
        /// <summary>
        /// Test GetProvidersEdgeLinebasesettingsLinebaseId
        /// </summary>
        [Test]
        public void GetProvidersEdgeLinebasesettingsLinebaseIdTest()
        {
            // TODO: add unit test for the method 'GetProvidersEdgeLinebasesettingsLinebaseId'
            string lineBaseId = null; // TODO: replace null with proper value
            
            var response = instance.GetProvidersEdgeLinebasesettingsLinebaseId(lineBaseId);
            Assert.IsInstanceOf<LineBase> (response, "response is LineBase"); 
        }
        
        /// <summary>
        /// Test GetProvidersEdgeLines
        /// </summary>
        [Test]
        public void GetProvidersEdgeLinesTest()
        {
            // TODO: add unit test for the method 'GetProvidersEdgeLines'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            
            var response = instance.GetProvidersEdgeLines(pageSize, pageNumber, name, sortBy, expand);
            Assert.IsInstanceOf<LineEntityListing> (response, "response is LineEntityListing"); 
        }
        
        /// <summary>
        /// Test GetProvidersEdgeLinesTemplate
        /// </summary>
        [Test]
        public void GetProvidersEdgeLinesTemplateTest()
        {
            // TODO: add unit test for the method 'GetProvidersEdgeLinesTemplate'
            string lineBaseSettingsId = null; // TODO: replace null with proper value
            
            var response = instance.GetProvidersEdgeLinesTemplate(lineBaseSettingsId);
            Assert.IsInstanceOf<Line> (response, "response is Line"); 
        }
        
        /// <summary>
        /// Test GetProvidersEdgeLinesLineId
        /// </summary>
        [Test]
        public void GetProvidersEdgeLinesLineIdTest()
        {
            // TODO: add unit test for the method 'GetProvidersEdgeLinesLineId'
            string lineId = null; // TODO: replace null with proper value
            
            var response = instance.GetProvidersEdgeLinesLineId(lineId);
            Assert.IsInstanceOf<Line> (response, "response is Line"); 
        }
        
        /// <summary>
        /// Test GetProvidersEdgeOutboundroutes
        /// </summary>
        [Test]
        public void GetProvidersEdgeOutboundroutesTest()
        {
            // TODO: add unit test for the method 'GetProvidersEdgeOutboundroutes'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string siteId = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            
            var response = instance.GetProvidersEdgeOutboundroutes(pageSize, pageNumber, name, siteId, sortBy);
            Assert.IsInstanceOf<OutboundRouteEntityListing> (response, "response is OutboundRouteEntityListing"); 
        }
        
        /// <summary>
        /// Test PostProvidersEdgeOutboundroutes
        /// </summary>
        [Test]
        public void PostProvidersEdgeOutboundroutesTest()
        {
            // TODO: add unit test for the method 'PostProvidersEdgeOutboundroutes'
            OutboundRoute body = null; // TODO: replace null with proper value
            
            var response = instance.PostProvidersEdgeOutboundroutes(body);
            Assert.IsInstanceOf<OutboundRoute> (response, "response is OutboundRoute"); 
        }
        
        /// <summary>
        /// Test GetProvidersEdgeOutboundroutesOutboundrouteId
        /// </summary>
        [Test]
        public void GetProvidersEdgeOutboundroutesOutboundrouteIdTest()
        {
            // TODO: add unit test for the method 'GetProvidersEdgeOutboundroutesOutboundrouteId'
            string outboundRouteId = null; // TODO: replace null with proper value
            
            var response = instance.GetProvidersEdgeOutboundroutesOutboundrouteId(outboundRouteId);
            Assert.IsInstanceOf<OutboundRoute> (response, "response is OutboundRoute"); 
        }
        
        /// <summary>
        /// Test PutProvidersEdgeOutboundroutesOutboundrouteId
        /// </summary>
        [Test]
        public void PutProvidersEdgeOutboundroutesOutboundrouteIdTest()
        {
            // TODO: add unit test for the method 'PutProvidersEdgeOutboundroutesOutboundrouteId'
            string outboundRouteId = null; // TODO: replace null with proper value
            OutboundRoute body = null; // TODO: replace null with proper value
            
            var response = instance.PutProvidersEdgeOutboundroutesOutboundrouteId(outboundRouteId, body);
            Assert.IsInstanceOf<OutboundRoute> (response, "response is OutboundRoute"); 
        }
        
        /// <summary>
        /// Test DeleteProvidersEdgeOutboundroutesOutboundrouteId
        /// </summary>
        [Test]
        public void DeleteProvidersEdgeOutboundroutesOutboundrouteIdTest()
        {
            // TODO: add unit test for the method 'DeleteProvidersEdgeOutboundroutesOutboundrouteId'
            string outboundRouteId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteProvidersEdgeOutboundroutesOutboundrouteId(outboundRouteId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetProvidersEdgePhonebasesettings
        /// </summary>
        [Test]
        public void GetProvidersEdgePhonebasesettingsTest()
        {
            // TODO: add unit test for the method 'GetProvidersEdgePhonebasesettings'
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetProvidersEdgePhonebasesettings(pageNumber, pageSize, sortBy, sortOrder);
            Assert.IsInstanceOf<PhoneBaseEntityListing> (response, "response is PhoneBaseEntityListing"); 
        }
        
        /// <summary>
        /// Test PostProvidersEdgePhonebasesettings
        /// </summary>
        [Test]
        public void PostProvidersEdgePhonebasesettingsTest()
        {
            // TODO: add unit test for the method 'PostProvidersEdgePhonebasesettings'
            PhoneBase body = null; // TODO: replace null with proper value
            
            var response = instance.PostProvidersEdgePhonebasesettings(body);
            Assert.IsInstanceOf<PhoneBase> (response, "response is PhoneBase"); 
        }
        
        /// <summary>
        /// Test GetProvidersEdgePhonebasesettingsAvailablemetabases
        /// </summary>
        [Test]
        public void GetProvidersEdgePhonebasesettingsAvailablemetabasesTest()
        {
            // TODO: add unit test for the method 'GetProvidersEdgePhonebasesettingsAvailablemetabases'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetProvidersEdgePhonebasesettingsAvailablemetabases(pageSize, pageNumber);
            Assert.IsInstanceOf<PhoneMetaBaseEntityListing> (response, "response is PhoneMetaBaseEntityListing"); 
        }
        
        /// <summary>
        /// Test GetProvidersEdgePhonebasesettingsTemplate
        /// </summary>
        [Test]
        public void GetProvidersEdgePhonebasesettingsTemplateTest()
        {
            // TODO: add unit test for the method 'GetProvidersEdgePhonebasesettingsTemplate'
            string phoneMetabaseId = null; // TODO: replace null with proper value
            
            var response = instance.GetProvidersEdgePhonebasesettingsTemplate(phoneMetabaseId);
            Assert.IsInstanceOf<PhoneBase> (response, "response is PhoneBase"); 
        }
        
        /// <summary>
        /// Test GetProvidersEdgePhonebasesettingsPhonebaseId
        /// </summary>
        [Test]
        public void GetProvidersEdgePhonebasesettingsPhonebaseIdTest()
        {
            // TODO: add unit test for the method 'GetProvidersEdgePhonebasesettingsPhonebaseId'
            string phoneBaseId = null; // TODO: replace null with proper value
            
            var response = instance.GetProvidersEdgePhonebasesettingsPhonebaseId(phoneBaseId);
            Assert.IsInstanceOf<PhoneBase> (response, "response is PhoneBase"); 
        }
        
        /// <summary>
        /// Test PutProvidersEdgePhonebasesettingsPhonebaseId
        /// </summary>
        [Test]
        public void PutProvidersEdgePhonebasesettingsPhonebaseIdTest()
        {
            // TODO: add unit test for the method 'PutProvidersEdgePhonebasesettingsPhonebaseId'
            string phoneBaseId = null; // TODO: replace null with proper value
            PhoneBase body = null; // TODO: replace null with proper value
            
            var response = instance.PutProvidersEdgePhonebasesettingsPhonebaseId(phoneBaseId, body);
            Assert.IsInstanceOf<PhoneBase> (response, "response is PhoneBase"); 
        }
        
        /// <summary>
        /// Test DeleteProvidersEdgePhonebasesettingsPhonebaseId
        /// </summary>
        [Test]
        public void DeleteProvidersEdgePhonebasesettingsPhonebaseIdTest()
        {
            // TODO: add unit test for the method 'DeleteProvidersEdgePhonebasesettingsPhonebaseId'
            string phoneBaseId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteProvidersEdgePhonebasesettingsPhonebaseId(phoneBaseId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetProvidersEdgePhones
        /// </summary>
        [Test]
        public void GetProvidersEdgePhonesTest()
        {
            // TODO: add unit test for the method 'GetProvidersEdgePhones'
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            string siteId = null; // TODO: replace null with proper value
            string phoneBaseSettingsId = null; // TODO: replace null with proper value
            string phoneHardwareId = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            List<string> fields = null; // TODO: replace null with proper value
            
            var response = instance.GetProvidersEdgePhones(pageNumber, pageSize, sortBy, sortOrder, siteId, phoneBaseSettingsId, phoneHardwareId, expand, fields);
            Assert.IsInstanceOf<PhoneEntityListing> (response, "response is PhoneEntityListing"); 
        }
        
        /// <summary>
        /// Test PostProvidersEdgePhones
        /// </summary>
        [Test]
        public void PostProvidersEdgePhonesTest()
        {
            // TODO: add unit test for the method 'PostProvidersEdgePhones'
            Phone body = null; // TODO: replace null with proper value
            
            var response = instance.PostProvidersEdgePhones(body);
            Assert.IsInstanceOf<Phone> (response, "response is Phone"); 
        }
        
        /// <summary>
        /// Test PostProvidersEdgePhonesReboot
        /// </summary>
        [Test]
        public void PostProvidersEdgePhonesRebootTest()
        {
            // TODO: add unit test for the method 'PostProvidersEdgePhonesReboot'
            PhonesReboot body = null; // TODO: replace null with proper value
            
            instance.PostProvidersEdgePhonesReboot(body);
             
        }
        
        /// <summary>
        /// Test GetProvidersEdgePhonesTemplate
        /// </summary>
        [Test]
        public void GetProvidersEdgePhonesTemplateTest()
        {
            // TODO: add unit test for the method 'GetProvidersEdgePhonesTemplate'
            string phoneBaseSettingsId = null; // TODO: replace null with proper value
            
            var response = instance.GetProvidersEdgePhonesTemplate(phoneBaseSettingsId);
            Assert.IsInstanceOf<Phone> (response, "response is Phone"); 
        }
        
        /// <summary>
        /// Test GetProvidersEdgePhonesPhoneId
        /// </summary>
        [Test]
        public void GetProvidersEdgePhonesPhoneIdTest()
        {
            // TODO: add unit test for the method 'GetProvidersEdgePhonesPhoneId'
            string phoneId = null; // TODO: replace null with proper value
            
            var response = instance.GetProvidersEdgePhonesPhoneId(phoneId);
            Assert.IsInstanceOf<Phone> (response, "response is Phone"); 
        }
        
        /// <summary>
        /// Test PutProvidersEdgePhonesPhoneId
        /// </summary>
        [Test]
        public void PutProvidersEdgePhonesPhoneIdTest()
        {
            // TODO: add unit test for the method 'PutProvidersEdgePhonesPhoneId'
            string phoneId = null; // TODO: replace null with proper value
            Phone body = null; // TODO: replace null with proper value
            
            var response = instance.PutProvidersEdgePhonesPhoneId(phoneId, body);
            Assert.IsInstanceOf<Phone> (response, "response is Phone"); 
        }
        
        /// <summary>
        /// Test DeleteProvidersEdgePhonesPhoneId
        /// </summary>
        [Test]
        public void DeleteProvidersEdgePhonesPhoneIdTest()
        {
            // TODO: add unit test for the method 'DeleteProvidersEdgePhonesPhoneId'
            string phoneId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteProvidersEdgePhonesPhoneId(phoneId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test PostProvidersEdgePhonesPhoneIdReboot
        /// </summary>
        [Test]
        public void PostProvidersEdgePhonesPhoneIdRebootTest()
        {
            // TODO: add unit test for the method 'PostProvidersEdgePhonesPhoneIdReboot'
            string phoneId = null; // TODO: replace null with proper value
            
            instance.PostProvidersEdgePhonesPhoneIdReboot(phoneId);
             
        }
        
        /// <summary>
        /// Test GetProvidersEdgeTimezones
        /// </summary>
        [Test]
        public void GetProvidersEdgeTimezonesTest()
        {
            // TODO: add unit test for the method 'GetProvidersEdgeTimezones'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetProvidersEdgeTimezones(pageSize, pageNumber);
            Assert.IsInstanceOf<TimeZoneEntityListing> (response, "response is TimeZoneEntityListing"); 
        }
        
        /// <summary>
        /// Test GetProvidersEdgeTrunkbasesettings
        /// </summary>
        [Test]
        public void GetProvidersEdgeTrunkbasesettingsTest()
        {
            // TODO: add unit test for the method 'GetProvidersEdgeTrunkbasesettings'
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetProvidersEdgeTrunkbasesettings(pageNumber, pageSize, sortBy, sortOrder);
            Assert.IsInstanceOf<TrunkBase> (response, "response is TrunkBase"); 
        }
        
        /// <summary>
        /// Test PostProvidersEdgeTrunkbasesettings
        /// </summary>
        [Test]
        public void PostProvidersEdgeTrunkbasesettingsTest()
        {
            // TODO: add unit test for the method 'PostProvidersEdgeTrunkbasesettings'
            TrunkBase body = null; // TODO: replace null with proper value
            
            var response = instance.PostProvidersEdgeTrunkbasesettings(body);
            Assert.IsInstanceOf<TrunkBase> (response, "response is TrunkBase"); 
        }
        
        /// <summary>
        /// Test GetProvidersEdgeTrunkbasesettingsAvailablemetabases
        /// </summary>
        [Test]
        public void GetProvidersEdgeTrunkbasesettingsAvailablemetabasesTest()
        {
            // TODO: add unit test for the method 'GetProvidersEdgeTrunkbasesettingsAvailablemetabases'
            string type = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetProvidersEdgeTrunkbasesettingsAvailablemetabases(type, pageSize, pageNumber);
            Assert.IsInstanceOf<TrunkMetabaseEntityListing> (response, "response is TrunkMetabaseEntityListing"); 
        }
        
        /// <summary>
        /// Test GetProvidersEdgeTrunkbasesettingsTemplate
        /// </summary>
        [Test]
        public void GetProvidersEdgeTrunkbasesettingsTemplateTest()
        {
            // TODO: add unit test for the method 'GetProvidersEdgeTrunkbasesettingsTemplate'
            string trunkMetabaseId = null; // TODO: replace null with proper value
            
            var response = instance.GetProvidersEdgeTrunkbasesettingsTemplate(trunkMetabaseId);
            Assert.IsInstanceOf<TrunkBase> (response, "response is TrunkBase"); 
        }
        
        /// <summary>
        /// Test GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsId
        /// </summary>
        [Test]
        public void GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdTest()
        {
            // TODO: add unit test for the method 'GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsId'
            string trunkBaseSettingsId = null; // TODO: replace null with proper value
            
            var response = instance.GetProvidersEdgeTrunkbasesettingsTrunkbasesettingsId(trunkBaseSettingsId);
            Assert.IsInstanceOf<TrunkBase> (response, "response is TrunkBase"); 
        }
        
        /// <summary>
        /// Test PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsId
        /// </summary>
        [Test]
        public void PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdTest()
        {
            // TODO: add unit test for the method 'PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsId'
            string trunkBaseSettingsId = null; // TODO: replace null with proper value
            TrunkBase body = null; // TODO: replace null with proper value
            
            var response = instance.PutProvidersEdgeTrunkbasesettingsTrunkbasesettingsId(trunkBaseSettingsId, body);
            Assert.IsInstanceOf<TrunkBase> (response, "response is TrunkBase"); 
        }
        
        /// <summary>
        /// Test DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsId
        /// </summary>
        [Test]
        public void DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsIdTest()
        {
            // TODO: add unit test for the method 'DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsId'
            string trunkBaseSettingsId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteProvidersEdgeTrunkbasesettingsTrunkbasesettingsId(trunkBaseSettingsId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
    }

}
