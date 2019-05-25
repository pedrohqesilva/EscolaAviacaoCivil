using Aeroportos.Context.Mappings.Base;
using Aeroportos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroportos.Context.Mappings
{
    internal class PaisMap : BaseEntityMap<Pais>
    {
        public override void Configure(EntityTypeBuilder<Pais> builder)
        {
            base.Configure(builder);

            builder
                .ToTable("PAIS");

            builder
                .Property(p => p.Sigla)
                .HasColumnName("SIGLA")
                .HasMaxLength(5)
                .IsRequired();

            builder
                .Property(p => p.Descricao)
                .HasColumnName("DESCRICAO")
                .HasMaxLength(5)
                .IsRequired();
        }
    }
}