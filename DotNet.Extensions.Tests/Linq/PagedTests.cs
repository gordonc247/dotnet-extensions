using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace DotNet.Extensions.Tests
{
    [TestFixture]
    public class PagedTests
    {
        private List<string> _data;
        
        [SetUp]
        public void InitTest()
        {
            _data = new List<string>
            {
                "Value 1",
                "Value 2",
                "Value 3",
                "Value 4",
                "Value 5",
                "Value 6",
                "Value 7",
                "Value 8",
            };
        }

        [TestCaseSource(typeof(PagedTestCases), nameof(PagedTestCases.Paged))]
        public void PagedTest(int[] values, int pageNumber, int pageSize, int[] expected)
        {
            Assert.AreEqual(expected, values.Paged(pageNumber, pageSize), "Failed to page enumerable");
        }
    }
}
