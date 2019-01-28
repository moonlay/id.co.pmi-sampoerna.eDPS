using Core.Domain.Abstractions;
using System.Threading.Tasks;

namespace Core.Domain.Repositories
{
    public interface IEntityRepository<TEntity> : IRepository
    {
        Task Update(TEntity entity);
    }
}