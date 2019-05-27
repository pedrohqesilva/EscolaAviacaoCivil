using Aeroportos.Domain.Entities;
using Aeroportos.Repository.Core;

namespace Aeroportos.Repository
{
    internal class AeroportosRepository : WriteRepository<Aeroporto>
    {
        public AeroportosRepository(Context.Context context) : base(context)
        {
        }
    }
}