using Aeroportos.Context;
using CrossCutting.IoC.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

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