using Aeroportos.Repository.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Aeroportos.Repository.Core
{
    public class ReadWriteRepository<T> : IReadWriteRepository<T> where T : class
    {
        private readonly Aeroportos.Context.Context _contexto;

        public ReadWriteRepository(Aeroportos.Context.Context context)
        {
            _contexto = context;
        }

        #region Read Repository

        public async virtual Task<T> FindAsync(object[] keys, CancellationToken cancellationToken)
        {
            var entity = await _contexto.Set<T>().FindAsync(keys, cancellationToken);
            return entity;
        }

        public async virtual Task<IEnumerable<T>> SearchAsync(ISpecification<T> specification, CancellationToken cancellationToken)
        {
            var query = specification.Prepare(_contexto.Set<T>().AsQueryable());
            var result = await query.ToListAsync(cancellationToken);
            return result;
        }

        public async virtual Task<IEnumerable<T>> SearchAsync(ISpecification<T> specification, int pageNumber, int pageSize, CancellationToken cancellationToken)
        {
            var entities = await specification
                .Prepare(_contexto.Set<T>().AsQueryable())
                .Skip(pageNumber)
                .Take(pageSize)
                .ToListAsync(cancellationToken);
            return entities;
        }

        public virtual IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        {
            var query = _contexto.Set<T>().Where(predicate);
            return query;
        }

        public virtual IQueryable<T> Where<TProperty>(Expression<Func<T, bool>> predicate, params Expression<Func<T, TProperty>>[] paths)
        {
            var query = _contexto.Set<T>().Where(predicate);

            foreach (var path in paths)
                query.Include(path);

            return query;
        }

        public virtual IQueryable<T> Where(ISpecification<T> specification)
        {
            return Where(specification.Predicate);
        }

        public async virtual Task<long> CountAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
        {
            var result = await _contexto.Set<T>().LongCountAsync(predicate, cancellationToken);
            return result;
        }

        public async virtual Task<long> CountAsync(ISpecification<T> specification, CancellationToken cancellationToken)
        {
            return await CountAsync(specification.Predicate, cancellationToken);
        }

        public async virtual Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
        {
            var count = await CountAsync(predicate, cancellationToken);
            return count > 0;
        }

        public async virtual Task<bool> ExistsAsync(ISpecification<T> specification, CancellationToken cancellationToken)
        {
            return await ExistsAsync(specification.Predicate, cancellationToken);
        }

        public async virtual Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
        {
            var entity = await _contexto.Set<T>().FirstOrDefaultAsync(predicate, cancellationToken);
            return entity;
        }

        public async virtual Task<T> LastOrDefaultAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
        {
            var entity = await _contexto.Set<T>().LastOrDefaultAsync(predicate, cancellationToken);
            return entity;
        }

        public virtual IQueryable<T> AsQuerable()
        {
            return _contexto.Set<T>().AsQueryable();
        }

        #endregion Read Repository

        #region Write Repository

        public virtual Task AddAsync(T entity, CancellationToken cancellationToken)
        {
            var result = _contexto.Set<T>().AddAsync(entity);
            return result;
        }

        public virtual Task AddRangeAsync(IList<T> entities, CancellationToken cancellationToken)
        {
            var result = _contexto.Set<T>().AddRangeAsync(entities, cancellationToken);
            return result;
        }

        public virtual void Remove(T entity)
        {
            _contexto.Set<T>().Remove(entity);
        }

        public virtual void RemoveRange(IList<T> entities)
        {
            _contexto.Set<T>().RemoveRange(entities);
        }

        public virtual void Update(T entity)
        {
            Attach(entity);
            SetModified(entity);
        }

        public virtual void SetModified(T entity)
        {
            _contexto.Entry(entity).State = EntityState.Modified;
        }

        public virtual T Attach(T entity)
        {
            var entry = _contexto.Entry(entity);

            if (entry.State == EntityState.Detached)
                _contexto.Set<T>().Attach(entity);

            return entity;
        }

        #endregion Write Repository
    }
}