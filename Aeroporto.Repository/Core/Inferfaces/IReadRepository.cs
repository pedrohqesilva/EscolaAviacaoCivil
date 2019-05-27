using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Aeroportos.Infrastructure.Data.Core.Interfaces
{
    public interface IReadRepository<T>
    {
        Task<T> FindAsync(object[] keys, CancellationToken cancellationToken);

        Task<IEnumerable<T>> SearchAsync(ISpecification<T> specification, CancellationToken cancellationToken);

        Task<IEnumerable<T>> SearchAsync(ISpecification<T> specification, int pageNumber, int pageSize, CancellationToken cancellationToken);

        IQueryable<T> Where(Expression<Func<T, bool>> predicate);

        IQueryable<T> Where(ISpecification<T> specification);

        IQueryable<T> Where<TProperty>(Expression<Func<T, bool>> predicate, params Expression<Func<T, TProperty>>[] paths);

        Task<long> CountAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);

        Task<long> CountAsync(ISpecification<T> specification, CancellationToken cancellationToken);

        Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);

        Task<bool> ExistsAsync(ISpecification<T> specification, CancellationToken cancellationToken);

        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);

        Task<T> LastOrDefaultAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);

        IQueryable<T> AsQuerable();
    }
}