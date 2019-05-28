namespace CrossCutting.Repository.Interfaces
{
    public interface IReadWriteRepository<T> : IReadRepository<T>, IWriteRepository<T>
    {
    }
}