using Aeroportos.Infrastructure.Data.Core;
using Microsoft.EntityFrameworkCore;

namespace Aeroportos.Infrastructure.Data.Base
{
    public class ReadOnlyBaseRepository<T> : ReadRepository<T> where T : class
    {
        protected Aeroportos.Context.Context Context { get; }
        private readonly DbSet<T> DbSet;

        public ReadOnlyBaseRepository(Aeroportos.Context.Context context) : base(context)
        {
            Context = context;
            DbSet = Context.Set<T>();
        }
    }
}