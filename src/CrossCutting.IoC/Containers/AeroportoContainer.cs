using Aeroportos.Application.Interfaces;
using Aeroportos.Application.Services;
using Aeroportos.Context;
using Aeroportos.Domain.Interfaces.Repositories;
using Aeroportos.Domain.Interfaces.Services;
using Aeroportos.Domain.Services;
using Aeroportos.Repository;
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

            services.AddScoped(typeof(IAeroportoAppService), typeof(AeroportoAppService));
            services.AddScoped(typeof(IAeroportoService), typeof(AeroportoService));
            services.AddScoped(typeof(IAeroportoRepository), typeof(AeroportoRepository));
        }
    }
}