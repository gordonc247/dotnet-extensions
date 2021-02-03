using System;

namespace Codefire.Extensions.Tests
{
    class StringTestCases
    {
        internal static object[] ParseInt32 =
        {
            new object[] { "abc", null },
            new object[] { "100", 100 },
            new object[] { "-100", -100 },
            new object[] { "100.23", null },
            new object[] { "-100.23", null },
            new object[] { "4294967296", null },
        };

        internal static object[] ParseInt64 =
        {
            new object[] { "abc", null },
            new object[] { "100", 100L },
            new object[] { "-100", -100L },
            new object[] { "100.23", null },
            new object[] { "-100.23", null },
            new object[] { "4294967296", 4294967296L },
            new object[] { "18446744073709551616", null },
        };

        internal static object[] ParseDecimal =
        {
            new object[] { "abc", null },
            new object[] { "100", 100M },
            new object[] { "-100", -100M },
            new object[] { "0.123456789", 0.123456789M },
            new object[] { "-0.123456789", -0.123456789M },
            new object[] { ".123456789", 0.123456789M },
            new object[] { "-.123456789", -0.123456789M },
            new object[] { "100.23", 100.23M },
            new object[] { "-100.23", -100.23M },
            new object[] { "4294967296", 4294967296M },
            new object[] { "-4294967296", -4294967296M },
            new object[] { "18446744073709551616", 18446744073709551616M },
            new object[] { "-18446744073709551616", -18446744073709551616M },
        };

        internal static object[] ParseBoolean =
        {
            new object[] { "abc", null },
            new object[] { "true", true },
            new object[] { "True", true },
            new object[] { "TRUE", true },
            new object[] { "false", false },
            new object[] { "False", false },
            new object[] { "FALSE", false },
            new object[] { "1", null },
            new object[] { "0", null },
        };

        internal static object[] ParseDateTime =
        {
            new object[] { "abc", null },
            new object[] { "2020/02/29", new DateTime(2020, 2, 29) },
            new object[] { "2020-02-29", new DateTime(2020, 2, 29) },
            new object[] { "2020-02-30", null },
            new object[] { "2020-02-29 15:30", new DateTime(2020, 2, 29, 15, 30, 0) },
            new object[] { "2020-02-29 15:30:23", new DateTime(2020, 2, 29, 15, 30, 23) },
        };
    }
}