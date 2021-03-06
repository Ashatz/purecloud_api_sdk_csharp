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
    ///  Class for testing QueryRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class QueryRequestTests
    {
        private QueryRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new QueryRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of QueryRequest
        /// </summary>
        [Test]
        public void QueryRequestInstanceTest()
        {
            Assert.IsInstanceOf<QueryRequest> (instance, "instance is a QueryRequest");
        }

        /// <summary>
        /// Test the property 'QueryPhrase'
        /// </summary>
        [Test]
        public void QueryPhraseTest()
        {
            // TODO: unit test for the property 'QueryPhrase'
        }
        /// <summary>
        /// Test the property 'PageNumber'
        /// </summary>
        [Test]
        public void PageNumberTest()
        {
            // TODO: unit test for the property 'PageNumber'
        }
        /// <summary>
        /// Test the property 'PageSize'
        /// </summary>
        [Test]
        public void PageSizeTest()
        {
            // TODO: unit test for the property 'PageSize'
        }
        /// <summary>
        /// Test the property 'FacetNameRequests'
        /// </summary>
        [Test]
        public void FacetNameRequestsTest()
        {
            // TODO: unit test for the property 'FacetNameRequests'
        }
        /// <summary>
        /// Test the property 'Sort'
        /// </summary>
        [Test]
        public void SortTest()
        {
            // TODO: unit test for the property 'Sort'
        }
        /// <summary>
        /// Test the property 'Filters'
        /// </summary>
        [Test]
        public void FiltersTest()
        {
            // TODO: unit test for the property 'Filters'
        }
        /// <summary>
        /// Test the property 'AttributeFilters'
        /// </summary>
        [Test]
        public void AttributeFiltersTest()
        {
            // TODO: unit test for the property 'AttributeFilters'
        }
        /// <summary>
        /// Test the property 'IncludeShares'
        /// </summary>
        [Test]
        public void IncludeSharesTest()
        {
            // TODO: unit test for the property 'IncludeShares'
        }

    }

}
