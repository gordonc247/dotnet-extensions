using System;
using DotNet.Extensions;
using NUnit.Framework;

namespace DotNet.Extensions.Tests
{
    [TestFixture]
    public class DateTimeTests
    {
        [TestCaseSource(typeof(DateTimeTestCases), nameof(DateTimeTestCases.StartOfWeek))]
        public void StartOfWeekTest(DateTime date, DayOfWeek startOfWeek, DateTime expected)
        {
            Assert.AreEqual(expected, date.StartOfWeek(startOfWeek), $"Start of week for {startOfWeek} failed");
        }

        [TestCaseSource(typeof(DateTimeTestCases), nameof(DateTimeTestCases.EndOfWeek))]
        public void EndOfWeekTest(DateTime date, DayOfWeek endOfWeek, DateTime expected)
        {
            Assert.AreEqual(expected, date.EndOfWeek(endOfWeek), $"End of week for {endOfWeek} failed");
        }

        [TestCaseSource(typeof(DateTimeTestCases), nameof(DateTimeTestCases.EndOfMonth))]
        public void EndOfMonthTest(DateTime date, DateTime expected)
        {
            Assert.AreEqual(expected, date.EndOfMonth(), "End of month failed");
        }

        // [TestCaseSource(nameof(AddWorkDaysCases))]
        // public void AddWorkDaysTest(DateTime date, DateTime expected)
        // {
        //     Assert.AreEqual(expected, date.AddWorkDays(), "End of month failed");
        // }
    }
}
