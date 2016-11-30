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
    /// <summary>
    ///  Class for testing UserDetailsQuery
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class UserDetailsQueryTests
    {
        private UserDetailsQuery instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserDetailsQuery();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserDetailsQuery
        /// </summary>
        [Test]
        public void UserDetailsQueryInstanceTest()
        {
            Assert.IsInstanceOf<UserDetailsQuery> (instance, "instance is a UserDetailsQuery");
        }

        /// <summary>
        /// Test the property 'Interval'
        /// </summary>
        [Test]
        public void IntervalTest()
        {
            // TODO: unit test for the property 'Interval'
        }
        /// <summary>
        /// Test the property 'UserFilters'
        /// </summary>
        [Test]
        public void UserFiltersTest()
        {
            // TODO: unit test for the property 'UserFilters'
        }
        /// <summary>
        /// Test the property 'PresenceFilters'
        /// </summary>
        [Test]
        public void PresenceFiltersTest()
        {
            // TODO: unit test for the property 'PresenceFilters'
        }
        /// <summary>
        /// Test the property 'RoutingStatusFilters'
        /// </summary>
        [Test]
        public void RoutingStatusFiltersTest()
        {
            // TODO: unit test for the property 'RoutingStatusFilters'
        }
        /// <summary>
        /// Test the property 'PresenceAggregations'
        /// </summary>
        [Test]
        public void PresenceAggregationsTest()
        {
            // TODO: unit test for the property 'PresenceAggregations'
        }
        /// <summary>
        /// Test the property 'RoutingStatusAggregations'
        /// </summary>
        [Test]
        public void RoutingStatusAggregationsTest()
        {
            // TODO: unit test for the property 'RoutingStatusAggregations'
        }
        /// <summary>
        /// Test the property 'Paging'
        /// </summary>
        [Test]
        public void PagingTest()
        {
            // TODO: unit test for the property 'Paging'
        }
        /// <summary>
        /// Test the property 'Order'
        /// </summary>
        [Test]
        public void OrderTest()
        {
            // TODO: unit test for the property 'Order'
        }

    }

}
