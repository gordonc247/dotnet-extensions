using NUnit.Framework;

namespace Codefire.Extensions.Tests
{
    [TestFixture]
    public class EnumerableTests
    {
        [Test]
        public void ForEachTest()
        {
            var values = new string[] { "a", "b", "c", "d" };
            var expected = "ABCD";

            var result = "";
            values.ForEach(x => result += x.ToUpper());

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ForEachWithIndexTest()
        {
            var values = new string[] { "a", "b", "c", "d" };
            var expected = "a0b1c2d3";

            var result = "";
            values.ForEach((x, index) => result += x + index.ToString());

            Assert.AreEqual(expected, result);
        }

        [TestCaseSource(typeof(EnumerableTestCases), nameof(EnumerableTestCases.JoinedString))]
        public void ToJoinedStringTest(string[] values, string separator, bool ignoreEmpty, string expected)
        {
            Assert.AreEqual(expected, values.ToJoinedString(separator, ignoreEmpty), "Failed to join string array");
        }

    }
}
