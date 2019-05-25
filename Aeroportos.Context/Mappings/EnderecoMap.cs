using Aeroportos.Context.Mappings.Base;
using Aeroportos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aeroportos.Context.Mappings
{
    internal class EnderecoMap : BaseEntityMap<Endereco>
    {
        public override void Configure(EntityTypeBuilder<Endereco> builder)
        {
            base.Configure(builder);

            builder
                .ToTable("ENDERECO");

            builder
                .Property(p => p.Cep)
                .HasColumnName("CEP")
                .HasMaxLength(8)
                .IsRequired();

            builder
                .Property(p => p.Logradouro)
                .HasColumnName("LOGRADOURO")
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(p => p.Numero)
                .HasColumnName("NUMERO")
                .IsRequired();

            builder
                .Property(p => p.Complemento)
                .HasColumnName("COMPLEMENTO")
                .HasMaxLength(50)
                .IsRequired(false);

            builder
                .Property(p => p.Bairro)
                .HasColumnName("BAIRRO")
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(p => p.CidadeId)
                .HasColumnName("CIDADE_ID")
                .IsRequired();

            builder
                .Property(p => p.AeroportoId)
                .HasColumnName("AEROPORTO_ID")
                .IsRequired();

            builder
                .HasOne(h => h.Cidade)
                .WithMany(w => w.Enderecos)
                .HasForeignKey(h => h.CidadeId)
                .IsRequired();

            builder
                .HasOne(h => h.Aeroporto)
                .WithOne(w => w.Endereco)
                .HasForeignKey<Aeroporto>(h => h.EnderecoId)
                .IsRequired();
        }
    }
}