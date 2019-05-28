using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Aeroportos.Domain.Interfaces.Repositories.Base
{
    public interface IWriteRepository<T>
    {
        Task AddAsync(T entity, CancellationToken cancellationToken);

        Task AddRangeAsync(IList<T> entities, CancellationToken cancellationToken);

        void Remove(T entity);

        void RemoveRange(IList<T> entities);

        void Update(T entity);

        T Attach(T entity);
    }
}