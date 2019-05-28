using CrossCutting.Repository.Interfaces;

namespace Aeroportos.Domain.Interfaces.Repositories.Base
{
    public interface IReadOnlyBaseRepository<T> : IReadRepository<T>
    {
    }
}