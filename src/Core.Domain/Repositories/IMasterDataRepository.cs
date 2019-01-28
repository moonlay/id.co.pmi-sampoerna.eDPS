using System.Linq;

namespace Core.Domain.Repositories
{
    public interface IMasterDataRepository<TEntity> : IEntityRepository<TEntity>
    {
        IQueryable<TEntity> Query { get; }
    }
}