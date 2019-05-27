using Aeroportos.Domain.Interfaces.Repositories.Base;
using Aeroportos.Repository.Core;
using Microsoft.EntityFrameworkCore;

namespace Aeroportos.Repository.Base
{
    public class ReadOnlyBaseRepository<T> : ReadRepository<T>, IReadRepository<T> where T : class
    {
        protected Context.Context Context { get; }
        private readonly DbSet<T> DbSet;

        public ReadOnlyBaseRepository(Context.Context context) : base(context)
        {
            Context = context;
            DbSet = Context.Set<T>();
        }
    }
}