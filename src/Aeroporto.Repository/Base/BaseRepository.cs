using Aeroportos.Domain.Interfaces.Repositories.Base;
using Aeroportos.Repository.Core;
using Microsoft.EntityFrameworkCore;

namespace Aeroportos.Repository.Base
{
    public class BaseRepository<T> : ReadWriteRepository<T>, IBaseRepository<T> where T : class
    {
        protected Context.Context Contexto { get; }
        private readonly DbSet<T> DbSet;

        public BaseRepository(Aeroportos.Context.Context context) : base(context)
        {
            Contexto = context;
            DbSet = Contexto.Set<T>();
        }
    }

    public class BaseRepository
    {
        protected Aeroportos.Context.Context Contexto { get; }

        public BaseRepository(Aeroportos.Context.Context context)
        {
            Contexto = context;
        }
    }
}