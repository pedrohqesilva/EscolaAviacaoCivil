using Aeroportos.Domain.Entities;
using Aeroportos.Domain.Interfaces.Repositories;
using Aeroportos.Repository.Base;

namespace Aeroportos.Repository
{
    public class AeroportoRepository : BaseRepository<Aeroporto>, IAeroportoRepository
    {
        public AeroportoRepository(Context.Context context) : base(context)
        {
        }
    }
}