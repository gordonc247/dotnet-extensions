using System;

namespace DotNet.Extensions.Tests
{
    class EnumerableTestCases
    {
        internal static object[] JoinedString =
        {
            new object[] { new string[] { "aa", "bb", "cc"}, ":", true, "aa:bb:cc" },
            new object[] { new string[] { "aa", " ", null, "cc"}, ",", false, "aa, ,,cc" },
            new object[] { new string[] { "aa", " ", null, "cc"}, ",", true, "aa,cc" },
            new object[] { new string[] { "aa" }, ",", true, "aa" },
            new object[] { Array.Empty<string>(), ",", true, "" },
        };
    }
}