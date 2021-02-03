using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNet.Extensions
{
    public static class DateTimeExtensions {
        public static DateTime StartOfDay(this DateTime date)
        {
            return date.Date;
        }

        public static DateTime EndOfDay(this DateTime date)
        {
            return date.Date.AddDays(1).AddMilliseconds(-1);
        }

        public static DateTime StartOfWeek(this DateTime date, DayOfWeek startOfWeek)
        {
            int diff = date.DayOfWeek - startOfWeek;
            if (diff < 0)
            {
                diff += 7;
            }

            return date.AddDays(-diff).Date;
        }

        public static DateTime EndOfWeek(this DateTime date, DayOfWeek endOfWeek)
        {
            int diff = endOfWeek - date.DayOfWeek;
            if (diff < 0)
            {
                diff += 7;
            }

            return date.AddDays(diff).Date;
        }

        public static DateTime StartOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }

        public static DateTime EndOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1).AddMonths(1).AddDays(-1);
        }
 
        public static DateTime StartOfYear(this DateTime date)
        {
            return new DateTime(date.Year, 1, 1);
        }

        public static DateTime EndOfYear(this DateTime date)
        {
            return new DateTime(date.Year, 12, 31);
        }

        public static bool IsWeekDay(this DateTime date)
        {
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    return false;
                default:
                    return true;
            }
        }

        public static bool IsWorkDay(this DateTime date, WeekDays workDays = WeekDays.WorkDays)
        {
            var day = date.DayOfWeek;
            switch (day)
            {
                case DayOfWeek.Sunday:
                    return workDays.HasFlag(WeekDays.Sunday);
                case DayOfWeek.Monday:
                    return workDays.HasFlag(WeekDays.Monday);
                case DayOfWeek.Tuesday:
                    return workDays.HasFlag(WeekDays.Tuesday);
                case DayOfWeek.Wednesday:
                    return workDays.HasFlag(WeekDays.Wednesday);
                case DayOfWeek.Thursday:
                    return workDays.HasFlag(WeekDays.Thursday);
                case DayOfWeek.Friday:
                    return workDays.HasFlag(WeekDays.Friday);
                case DayOfWeek.Saturday:
                    return workDays.HasFlag(WeekDays.Saturday);
                default:
                    return false;
            }
        }

        public static bool IsWeekEnd(this DateTime date)
        {
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    return true;
                default:
                    return false;
            }
        }

        public static DateTime AddWorkDays(this DateTime date, int days, WeekDays workDays = WeekDays.WorkDays, IEnumerable<DateTime> excludeDates = null)
        {
            var exclusions = (excludeDates ?? Enumerable.Empty<DateTime>()).ToArray();

            for (int i = 0; i < days; ++i)
            {
                date = date.AddDays(1);

                while (date.IsWorkDay(workDays)) date = date.AddDays(1);

                if (exclusions?.Length > 0)
                {
                    while(exclusions.Contains(date)) date = date.AddDays(1);
                }
            }
            return date;
        }
        
        public static int GetWorkDays(this DateTime from, DateTime to, WeekDays workDays = WeekDays.WorkDays, IEnumerable<DateTime> excludeDates = null)
        {
            var normalizedFrom = from.Date;
            var normalizedTo = to.Date.AddDays(1);
            if (normalizedTo <= normalizedFrom) return 0;

            var days = (normalizedTo - normalizedFrom).Days;
            var exclusions = (excludeDates ?? Enumerable.Empty<DateTime>()).ToArray();

            // Determine the number of days to exclude
            var excludeDays = 0;
            var checkDate = normalizedFrom;
            for (var i = 0; i < days; i++)
            {
                var exclude = false;

                if (!checkDate.IsWorkDay(workDays)) exclude = true;

                if (exclusions?.Length > 0)
                {
                    if (exclusions.Contains(checkDate)) exclude = true;
                }

                if (exclude) excludeDays++;
                checkDate = checkDate.AddDays(1);
            }

            return days - excludeDays;
        }

        public static DateTime SetTime(this DateTime date, int hours, int minutes, int seconds)
        {
            return date.Date.AddHours(hours).AddMinutes(minutes).AddSeconds(seconds);
        }
   }
}