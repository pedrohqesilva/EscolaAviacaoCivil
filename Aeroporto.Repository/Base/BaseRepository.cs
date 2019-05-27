using Aeroportos.Infrastructure.Data.Core;
using Microsoft.EntityFrameworkCore;

namespace Aeroportos.Infrastructure.Data.Base
{
    public class BaseRepository<T> : ReadWriteRepository<T> where T : class
    {
        protected Aeroportos.Context.Context Contexto { get; }
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