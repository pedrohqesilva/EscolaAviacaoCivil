namespace Aeroportos.Infrastructure.Data.Core.Interfaces
{
    public interface IReadWriteRepository<T> : IReadRepository<T>, IWriteRepository<T>
    {
    }
}