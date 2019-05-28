using Aeroportos.Domain.Entities;
using Aeroportos.Domain.Enums;
using Core.Context.Seeding.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Aeroportos.Context.Seeding
{
    internal class TiposAeroportoSeed : ISeed
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<TipoAeroporto>()
                .HasData(
                    new TipoAeroporto((int)TiposAeroportos.Aeroporto, "AP", "Aeroporto"),
                    new TipoAeroporto((int)TiposAeroportos.Aerodromo, "AD", "Aerodromo"),
                    new TipoAeroporto((int)TiposAeroportos.Heliponto, "HP", "Heliponto")
                );
        }
    }
}