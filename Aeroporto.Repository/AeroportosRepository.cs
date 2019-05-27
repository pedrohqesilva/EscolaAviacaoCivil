using Aeroportos.Domain.Entities;
using Aeroportos.Repository.Base;

namespace Aeroportos.Repository
{
    internal class AeroportosRepository : BaseRepository<Aeroporto>
    {
        public AeroportosRepository(Context.Context context) : base(context)
        {
        }
    }
}