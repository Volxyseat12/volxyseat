using Volxyseat.Domain.Core;

namespace Volxyseat.Domain.Repositories
{
    public interface IRepository<TEntity, TKey> where TEntity : Entity
    {
        void AddAsync(TEntity obj);
        TEntity GetAsync (TKey id);
        void Update(TEntity obj);
        IUnitOfWork UnitOfWork { get; }
    }
}
