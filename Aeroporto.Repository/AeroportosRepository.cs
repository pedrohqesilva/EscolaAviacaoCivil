using Aeroportos.Domain.Entities;
using Aeroportos.Domain.Interfaces.Repositories;
using Aeroportos.Repository.Base;

namespace Aeroportos.Repository
{
    internal class AeroportosRepository : BaseRepository<Aeroporto>, IAeroportoRepository
    {
        public AeroportosRepository(Context.Context context) : base(context)
        {
        }
    }
}