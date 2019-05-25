using Aeroportos.Context.Mappings.Base;
using Aeroportos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroportos.Context.Mappings
{
    internal class AeroportoMap : BaseEntityMap<Aeroporto>
    {
        public override void Configure(EntityTypeBuilder<Aeroporto> builder)
        {
            base.Configure(builder);

            builder
                .ToTable("AEROPORTO");

            builder
                .Property(p => p.CodigoIcao)
                .HasColumnName("CODIGO_ICAO")
                .HasMaxLength(5)
                .IsRequired();

            builder
                .Property(p => p.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(p => p.Descricao)
                .HasColumnName("DESCRICAO")
                .HasMaxLength(500)
                .IsRequired();

            builder
                .Property(p => p.EnderecoId)
                .HasColumnName("ENDERECO_ID")
                .IsRequired();

            builder
                .Property(p => p.TipoAeroportoId)
                .HasColumnName("TIPO_AEROPORTO_ID")
                .IsRequired();

            builder
                .HasOne(h => h.TipoAeroporto)
                .WithMany(w => w.Aeroportos)
                .HasForeignKey(h => h.TipoAeroportoId)
                .IsRequired();

            builder
                .HasOne(h => h.Endereco)
                .WithOne(w => w.Aeroporto)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey<Endereco>(h => h.AeroportoId)
                .IsRequired();
        }
    }
}