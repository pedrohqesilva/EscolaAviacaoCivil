using Aeroportos.Context.Mappings.Base;
using Aeroportos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroportos.Context.Mappings
{
    internal class EstadoMap : BaseEntityMap<Estado>
    {
        public override void Configure(EntityTypeBuilder<Estado> builder)
        {
            base.Configure(builder);

            builder
                .ToTable("ESTADO");

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

            builder
                .Property(p => p.PaisId)
                .HasColumnName("PAIS_ID")
                .IsRequired();

            builder
                .HasOne(h => h.Pais)
                .WithMany(w => w.Estados)
                .HasForeignKey(h => h.PaisId)
                .IsRequired();
        }
    }
}