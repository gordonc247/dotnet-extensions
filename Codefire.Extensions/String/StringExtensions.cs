using System;

namespace Codefire.Extensions {
    public static class StringExtensions {
        public static int? ToInt32(this string input) {

            return int.TryParse(input, out var result) ? result : null;
        }

        public static long? ToInt64(this string input) {

            return long.TryParse(input, out var result) ? result : null;
        }

        public static decimal? ToDecimal(this string input) {

            return decimal.TryParse(input, out var result) ? result : null;
        }

        public static float? ToSingle(this string input) {

            return float.TryParse(input, out var result) ? result : null;
        }

        public static double? ToDouble(this string input) {

            return double.TryParse(input, out var result) ? result : null;
        }

        public static bool? ToBoolean(this string input) {

            return bool.TryParse(input, out var result) ? result : null;
        }

        public static DateTime? ToDateTime(this string input) {

            return DateTime.TryParse(input, out var result) ? result : null;
        }
    }
}