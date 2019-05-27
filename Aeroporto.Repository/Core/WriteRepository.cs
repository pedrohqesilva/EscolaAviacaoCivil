﻿using Aeroportos.Infrastructure.Data.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Aeroportos.Infrastructure.Data.Core
{
    public class WriteRepository<T> : IWriteRepository<T> where T : class
    {
        private readonly Aeroportos.Context.Context _contexto;

        public WriteRepository(Aeroportos.Context.Context context)
        {
            _contexto = context;
        }

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
    }
}