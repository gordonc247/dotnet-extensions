using System.Linq;

namespace DotNet.Extensions
{
    public static class LinqExtensions
    {
        public static IQueryable<TEntity> Filter<TEntity>(this IQueryable<TEntity> source, ICriteria<TEntity> criteria)
            where TEntity : class
        {
            return criteria?.Apply(source);
        }

        public static IQueryable<T> Paged<T>(this IQueryable<T> source, int pageNumber, int pageSize)
        {
            var skip = (pageNumber - 1) * pageSize;

            return source.Skip(skip).Take(pageSize);
        }
    }
}