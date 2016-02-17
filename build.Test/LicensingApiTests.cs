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
    public class LicensingApiTests
    {
        private LicensingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new LicensingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LicensingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<LicensingApi> (instance, "instance is a LicensingApi");
        }

        
        /// <summary>
        /// Test GetLicenses
        /// </summary>
        [Test]
        public void GetLicensesTest()
        {
            // TODO: add unit test for the method 'GetLicenses'
            List<string> permission = null; // TODO: replace null with proper value
            
            var response = instance.GetLicenses(permission);
            Assert.IsInstanceOf<List<License>> (response, "response is List<License>"); 
        }
        
        /// <summary>
        /// Test GetOrgassignments
        /// </summary>
        [Test]
        public void GetOrgassignmentsTest()
        {
            // TODO: add unit test for the method 'GetOrgassignments'
            
            var response = instance.GetOrgassignments();
            Assert.IsInstanceOf<OrgLicenseAssignment> (response, "response is OrgLicenseAssignment"); 
        }
        
        /// <summary>
        /// Test GetOrgassignments_0
        /// </summary>
        [Test]
        public void GetOrgassignments_0Test()
        {
            // TODO: add unit test for the method 'GetOrgassignments_0'
            string id = null; // TODO: replace null with proper value
            
            var response = instance.GetOrgassignments_0(id);
            Assert.IsInstanceOf<OrgLicenseAssignment> (response, "response is OrgLicenseAssignment"); 
        }
        
        /// <summary>
        /// Test GetPermissions
        /// </summary>
        [Test]
        public void GetPermissionsTest()
        {
            // TODO: add unit test for the method 'GetPermissions'
            List<string> id = null; // TODO: replace null with proper value
            
            var response = instance.GetPermissions(id);
            Assert.IsInstanceOf<List<LicensesByPermission>> (response, "response is List<LicensesByPermission>"); 
        }
        
        /// <summary>
        /// Test PostPermissions
        /// </summary>
        [Test]
        public void PostPermissionsTest()
        {
            // TODO: add unit test for the method 'PostPermissions'
            List<string> id = null; // TODO: replace null with proper value
            Permissions body = null; // TODO: replace null with proper value
            
            var response = instance.PostPermissions(id, body);
            Assert.IsInstanceOf<List<LicensesByPermission>> (response, "response is List<LicensesByPermission>"); 
        }
        
        /// <summary>
        /// Test GetUserassignments
        /// </summary>
        [Test]
        public void GetUserassignmentsTest()
        {
            // TODO: add unit test for the method 'GetUserassignments'
            
            var response = instance.GetUserassignments();
            Assert.IsInstanceOf<UserLicenseAssignment> (response, "response is UserLicenseAssignment"); 
        }
        
        /// <summary>
        /// Test GetUserassignments_0
        /// </summary>
        [Test]
        public void GetUserassignments_0Test()
        {
            // TODO: add unit test for the method 'GetUserassignments_0'
            string id = null; // TODO: replace null with proper value
            
            var response = instance.GetUserassignments_0(id);
            Assert.IsInstanceOf<UserLicenseAssignment> (response, "response is UserLicenseAssignment"); 
        }
        
    }

}