using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace DotNet.Extensions.Tests
{
    [TestFixture]
    public class FilterTests
    {
        [Test]
        public void FilterAllTest()
        {
            var criteria = new PersonCriteria { };
            var results = FilterTestCases.DataSource.Filter(criteria).ToList();
            var expected = FilterTestCases.DataSource.ToList();

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FilterByAgeTest()
        {
            var criteria = new PersonCriteria { FromAge = 40 };
            var results = FilterTestCases.DataSource.Filter(criteria).ToList();
            var expected = new List<Person>
            {
                FilterTestCases.DataSource[0],
                FilterTestCases.DataSource[2]
            };

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FilterByAgeRangeTest()
        {
            var criteria = new PersonCriteria { FromAge = 40, ToAge = 50 };
            var results = FilterTestCases.DataSource.Filter(criteria).ToList();
            var expected = new List<Person>
            {
                FilterTestCases.DataSource[0]
            };

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FilterByAgeAndEmployedTest()
        {
            var criteria = new PersonCriteria { FromAge = 40, IsEmployed = true };
            var results = FilterTestCases.DataSource.Filter(criteria).ToList();
            var expected = new List<Person>
            {
                FilterTestCases.DataSource[2]
            };

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FilterByNameTest()
        {
            var criteria = new PersonCriteria { Name = "J" };
            var results = FilterTestCases.DataSource.Filter(criteria).ToList();
            var expected = new List<Person>
            {
                FilterTestCases.DataSource[0],
                FilterTestCases.DataSource[1]
            };

            Assert.AreEqual(expected, results);
        }
    }
}
