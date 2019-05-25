using Aeroportos.Context.Mappings.Base;
using Aeroportos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroportos.Context.Mappings
{
    internal class TipoAeroportoMap : BaseEntityMap<TipoAeroporto>
    {
        public override void Configure(EntityTypeBuilder<TipoAeroporto> builder)
        {
            base.Configure(builder);

            builder
                .ToTable("TIPO_AEROPORTO");

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