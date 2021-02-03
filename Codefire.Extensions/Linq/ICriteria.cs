using System.Linq;

namespace Codefire.Extensions {
    public interface ICriteria<TEntity>
        where TEntity: class
    {
        IQueryable<TEntity> Apply(IQueryable<TEntity> qry);
    }
}