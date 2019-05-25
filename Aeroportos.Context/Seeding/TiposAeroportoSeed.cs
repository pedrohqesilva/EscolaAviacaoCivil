using Aeroportos.Context.Seeding.Interfaces;
using Aeroportos.Domain.Entities;
using Aeroportos.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Aeroportos.Context.Seeding
{
    internal class TiposAeroportoSeed : ISeed
    {
        public void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<TipoAeroporto>()
                .HasData(
                    new TipoAeroporto(TiposAeroportos.Aeroporto, "Aeroporto"),
                    new TipoAeroporto(TiposAeroportos.Aerodromo, "Aerodromo"),
                    new TipoAeroporto(TiposAeroportos.Heliponto, "Heliponto")
                );
        }
    }
}