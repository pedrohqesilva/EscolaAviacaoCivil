using CrossCutting.Repository.Interfaces;

namespace Aeroportos.Domain.Interfaces.Repositories.Base
{
    public interface IBaseRepository<T> : IReadWriteRepository<T>
    {
    }
}