using Aeroportos.Context;
using CrossCutting.IoC.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CrossCutting.IoC.Containers
{
    public class AeroportoContainer : IContainer
    {
        public void Register(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<Context>(opt => opt
                .UseSqlServer(connectionString, x => x.MigrationsHistoryTable("MIGRACOES", "dbAeroportos"))
                .UseLazyLoadingProxies());
        }
    }
}