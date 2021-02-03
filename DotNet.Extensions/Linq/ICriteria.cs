using System.Linq;

namespace DotNet.Extensions {
    public interface ICriteria<TEntity>
        where TEntity: class
    {
        IQueryable<TEntity> Apply(IQueryable<TEntity> qry);
    }
}