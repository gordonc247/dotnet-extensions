using System;
using System.Collections.Generic;
using System.Linq;

namespace Codefire.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<TEntity> Filter<TEntity>(this IEnumerable<TEntity> source, ICriteria<TEntity> criteria)
            where TEntity : class
        {
            return criteria?.Apply(source.AsQueryable()).AsEnumerable();
        }

        public static IEnumerable<T> Paged<T>(this IEnumerable<T> source, int pageNumber, int pageSize)
        {
            var skip = (pageNumber - 1) * pageSize;

            return source.Skip(skip).Take(pageSize);
        }

        public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T> action)
        {
            foreach(T item in enumeration)
            {
                action(item);
            }
        }

        public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T, int> action)
        {
            var index = 0;
            
            foreach(T item in enumeration)
            {
                action(item, index++);
            }
        }

        public static string ToJoinedString(this IEnumerable<string> source, string separator = " ", bool ignoreEmpty = true)
        {
            var values = source.Where(x => !ignoreEmpty || !string.IsNullOrWhiteSpace(x));
            
            return string.Join(separator, values);
        }
    }
}