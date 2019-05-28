using Microsoft.Extensions.DependencyInjection;

namespace CrossCutting.IoC.Interfaces
{
    internal interface IContainer
    {
        void Register(IServiceCollection services, string connectionString);
    }
}