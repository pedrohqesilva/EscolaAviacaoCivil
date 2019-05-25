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
                .HasKey(h => h.Id)
                .HasName("ID");

            builder
                .Property(p => p.Guid)
                .HasColumnName("GUID")
                .HasMaxLength(36);
        }
    }
}