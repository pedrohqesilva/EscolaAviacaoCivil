﻿using Aeroportos.Domain.Interfaces.Repositories.Base;
using Aeroportos.Domain.Interfaces.Specifications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Aeroportos.Repository.Core
{
    public class ReadRepository<T> : IReadRepository<T> where T : class
    {
        private readonly Context.Context _contexto;

        public ReadRepository(Context.Context context)
        {
            _contexto = context;
        }

        public virtual async Task<T> FindAsync(object[] keys, CancellationToken cancellationToken)
        {
            var entity = await _contexto.Set<T>().FindAsync(keys, cancellationToken);
            return entity;
        }

        public virtual async Task<IEnumerable<T>> SearchAsync(ISpecification<T> specification, CancellationToken cancellationToken)
        {
            var query = specification.Prepare(_contexto.Set<T>().AsQueryable());
            var result = await query.ToListAsync(cancellationToken);
            return result;
        }

        public virtual async Task<IEnumerable<T>> SearchAsync(ISpecification<T> specification, int pageNumber, int pageSize, CancellationToken cancellationToken)
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

        public virtual async Task<long> CountAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
        {
            var result = await _contexto.Set<T>().LongCountAsync(predicate, cancellationToken);
            return result;
        }

        public virtual async Task<long> CountAsync(ISpecification<T> specification, CancellationToken cancellationToken)
        {
            return await CountAsync(specification.Predicate, cancellationToken);
        }

        public virtual async Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
        {
            var count = await CountAsync(predicate, cancellationToken);
            return count > 0;
        }

        public virtual async Task<bool> ExistsAsync(ISpecification<T> specification, CancellationToken cancellationToken)
        {
            return await ExistsAsync(specification.Predicate, cancellationToken);
        }

        public virtual async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
        {
            var entity = await _contexto.Set<T>().FirstOrDefaultAsync(predicate, cancellationToken);
            return entity;
        }

        public virtual async Task<T> LastOrDefaultAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
        {
            var entity = await _contexto.Set<T>().LastOrDefaultAsync(predicate, cancellationToken);
            return entity;
        }

        public virtual IQueryable<T> AsQueryable()
        {
            return _contexto.Set<T>().AsQueryable();
        }
    }
}