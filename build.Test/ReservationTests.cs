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
    ///  Class for testing Reservation
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ReservationTests
    {
        private Reservation instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Reservation();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Reservation
        /// </summary>
        [Test]
        public void ReservationInstanceTest()
        {
            Assert.IsInstanceOf<Reservation> (instance, "instance is a Reservation");
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
        /// Test the property 'ReservedTn'
        /// </summary>
        [Test]
        public void ReservedTnTest()
        {
            // TODO: unit test for the property 'ReservedTn'
        }
        /// <summary>
        /// Test the property 'ReservationExpires'
        /// </summary>
        [Test]
        public void ReservationExpiresTest()
        {
            // TODO: unit test for the property 'ReservationExpires'
        }
        /// <summary>
        /// Test the property 'PhoneNumberType'
        /// </summary>
        [Test]
        public void PhoneNumberTypeTest()
        {
            // TODO: unit test for the property 'PhoneNumberType'
        }

    }

}
