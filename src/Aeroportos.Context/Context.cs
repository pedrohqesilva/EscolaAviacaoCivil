using Aeroportos.Context.Mappings;
using Aeroportos.Domain.Entities;
using Core.Context;
using Core.Context.Seeding.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Aeroportos.Context
{
    public class Context : CoreContext
    {
        public Context() : base()
        {
        }

        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Aeroporto> Aeroporto { get; set; }
        public DbSet<TipoAeroporto> TipoAeroporto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            StringConfiguration(modelBuilder);

            modelBuilder
                .HasDefaultSchema("dbAeroportos")
                .ApplyConfiguration(new AeroportoMap())
                .ApplyConfiguration(new TipoAeroportoMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder
                    .UseLazyLoadingProxies()
                    .UseInMemoryDatabase("dbAeroportos");
        }

        private void RunSeeds(ModelBuilder modelBuilder)
        {
            var typeSeed = typeof(ISeed);

            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => typeSeed.IsAssignableFrom(p)
                            && !p.IsInterface
                            && !p.IsAbstract);

            foreach (var type in types)
            {
                var instance = (ISeed)Activator.CreateInstance(type);
                instance.Seed(modelBuilder);
            }
        }
    }
}