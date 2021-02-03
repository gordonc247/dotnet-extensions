using System;
using NUnit.Framework;

namespace DotNet.Extensions.Tests
{
    [TestFixture]
    public class StringTests
    {
        [TestCaseSource(typeof(StringTestCases), nameof(StringTestCases.ParseInt32))]
        public void ToInt32Test(string input, int? expected)
        {
            Assert.AreEqual(expected, input.ToInt32(), $"ToInt32 failed");
        }

        [TestCaseSource(typeof(StringTestCases), nameof(StringTestCases.ParseInt64))]
        public void ToInt64Test(string input, long? expected)
        {
            Assert.AreEqual(expected, input.ToInt64(), $"ToInt64 failed");
        }

        [TestCaseSource(typeof(StringTestCases), nameof(StringTestCases.ParseDecimal))]
        public void ToDecimalTest(string input, decimal? expected)
        {
            Assert.AreEqual(expected, input.ToDecimal(), $"ToDecimal failed");
        }

        [TestCaseSource(typeof(StringTestCases), nameof(StringTestCases.ParseBoolean))]
        public void ToBooleanTest(string input, bool? expected)
        {
            Assert.AreEqual(expected, input.ToBoolean(), $"ToBoolean failed");
        }

        [TestCaseSource(typeof(StringTestCases), nameof(StringTestCases.ParseDateTime))]
        public void ToDateTimeTest(string input, DateTime? expected)
        {
            Assert.AreEqual(expected, input.ToDateTime(), $"ToDateTime failed");
        }
    }
}
