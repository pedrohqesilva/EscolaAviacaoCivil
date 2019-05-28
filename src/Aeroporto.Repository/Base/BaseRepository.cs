using CrossCutting.Repository;
using Microsoft.EntityFrameworkCore;

namespace Aeroportos.Repository.Base
{
    public class BaseRepository<T> : ReadWriteRepository<T> where T : class
    {
        protected Context.Context Contexto { get; }
        private readonly DbSet<T> DbSet;

        public BaseRepository(Context.Context context) : base(context)
        {
            Contexto = context;
            DbSet = Contexto.Set<T>();
        }
    }

    public class BaseRepository
    {
        protected Context.Context Contexto { get; }

        public BaseRepository(Context.Context context)
        {
            Contexto = context;
        }
    }
}