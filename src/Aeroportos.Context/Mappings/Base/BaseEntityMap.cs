using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroportos.Context.Mappings.Base
{
    internal abstract class BaseEntityMap<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder
                .HasKey(h => h.Id);

            builder
                .HasAlternateKey(p => p.Guid);

            builder
                .Property(p => p.Id)
                .HasColumnName("ID");

            builder
                .Property(p => p.Guid)
                .HasColumnName("GUID")
                .HasDefaultValueSql("NEWID()")
                .IsRequired();

            builder
                .OwnsOne(o => o.Metadata, x =>
                {
                    x.Property(p => p.DataCriacao)
                        .HasColumnName("DATA_CRIACAO")
                        .IsRequired();

                    x.Property(p => p.DataModificacao)
                        .HasColumnName("DATA_MODIFICACAO")
                        .IsRequired(false);

                    x.Property(p => p.DataExclusao)
                        .HasColumnName("DATA_EXCLUSAO")
                        .IsRequired(false);
                });
        }
    }
}