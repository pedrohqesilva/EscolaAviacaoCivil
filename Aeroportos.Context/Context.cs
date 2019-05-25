using Aeroportos.Context.Mappings;
using Aeroportos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Aeroportos.Context
{
    public class Context : DbContext
    {
        public Context() : base()
        {
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Aeroporto> Aeroporto { get; set; }
        public DbSet<TipoAeroporto> TipoAeroporto { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Pais> Pais { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            StringConfiguration(modelBuilder);

            modelBuilder
                .HasDefaultSchema("dbAeroportos")
                .ApplyConfiguration(new AeroportoMap())
                .ApplyConfiguration(new TipoAeroportoMap())
                .ApplyConfiguration(new EnderecoMap())
                .ApplyConfiguration(new CidadeMap())
                .ApplyConfiguration(new EstadoMap())
                .ApplyConfiguration(new PaisMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseLazyLoadingProxies()
                    .UseInMemoryDatabase("dbAeroportos");
            }
        }

        private void StringConfiguration(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(string)))
            {
                property.IsUnicode(true);
            }
        }
    }
}