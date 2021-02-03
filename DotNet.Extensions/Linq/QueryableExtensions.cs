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

        public static IQueryable<TEntity> Paged<TEntity>(this IQueryable<TEntity> source, int pageNumber, int pageSize)
            where TEntity : class
        {
            var skip = (pageNumber - 1) * pageSize;

            return source.Skip(skip).Take(pageSize);
        }
    }
}