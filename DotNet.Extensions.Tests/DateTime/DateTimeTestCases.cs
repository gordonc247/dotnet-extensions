using System;

namespace DotNet.Extensions.Tests
{
    class DateTimeTestCases
    {

        internal static object[] StartOfWeek =
        {
            new object[] { new DateTime(2020, 10, 14), DayOfWeek.Monday, new DateTime(2020, 10, 12) },
            new object[] { new DateTime(2020, 10, 14), DayOfWeek.Tuesday, new DateTime(2020, 10, 13) },
            new object[] { new DateTime(2020, 10, 14), DayOfWeek.Wednesday, new DateTime(2020, 10, 14) },
            new object[] { new DateTime(2020, 10, 14), DayOfWeek.Thursday, new DateTime(2020, 10, 8) },
            new object[] { new DateTime(2020, 10, 14), DayOfWeek.Friday, new DateTime(2020, 10, 9) },
            new object[] { new DateTime(2020, 10, 14), DayOfWeek.Saturday, new DateTime(2020, 10, 10) },
            new object[] { new DateTime(2020, 10, 14), DayOfWeek.Sunday, new DateTime(2020, 10, 11) },
        };

        internal static object[] EndOfWeek =
        {
            new object[] { new DateTime(2020, 10, 14), DayOfWeek.Monday, new DateTime(2020, 10, 19) },
            new object[] { new DateTime(2020, 10, 14), DayOfWeek.Tuesday, new DateTime(2020, 10, 20) },
            new object[] { new DateTime(2020, 10, 14), DayOfWeek.Wednesday, new DateTime(2020, 10, 14) },
            new object[] { new DateTime(2020, 10, 14), DayOfWeek.Thursday, new DateTime(2020, 10, 15) },
            new object[] { new DateTime(2020, 10, 14), DayOfWeek.Friday, new DateTime(2020, 10, 16) },
            new object[] { new DateTime(2020, 10, 14), DayOfWeek.Saturday, new DateTime(2020, 10, 17) },
            new object[] { new DateTime(2020, 10, 14), DayOfWeek.Sunday, new DateTime(2020, 10, 18) },
        };

        internal static object[] EndOfMonth =
        {
            new object[] { new DateTime(2020, 10, 14), new DateTime(2020, 10, 31) },
            new object[] { new DateTime(2020, 6, 14), new DateTime(2020, 6, 30) },
            new object[] { new DateTime(2019, 2, 14), new DateTime(2019, 2, 28) },
            new object[] { new DateTime(2020, 2, 14), new DateTime(2020, 2, 29) },
        };
    }
}