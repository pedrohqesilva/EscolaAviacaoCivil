using Aeroportos.Context.Mappings.Base;
using Aeroportos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroportos.Context.Mappings
{
    internal class CidadeMap : BaseEntityMap<Cidade>
    {
        public override void Configure(EntityTypeBuilder<Cidade> builder)
        {
            base.Configure(builder);

            builder
                .ToTable("CIDADE");

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
                .Property(p => p.EstadoId)
                .HasColumnName("ESTADO_ID")
                .IsRequired();

            builder
                .HasOne(h => h.Estado)
                .WithMany(w => w.Cidades)
                .HasForeignKey(h => h.EstadoId)
                .IsRequired();
        }
    }
}