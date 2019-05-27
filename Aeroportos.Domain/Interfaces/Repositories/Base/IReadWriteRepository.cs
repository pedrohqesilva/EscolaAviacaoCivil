namespace Aeroportos.Domain.Interfaces.Repositories.Base
{
    public interface IReadWriteRepository<T> : IReadRepository<T>, IWriteRepository<T>
    {
    }
}