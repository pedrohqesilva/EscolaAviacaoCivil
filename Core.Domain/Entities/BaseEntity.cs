using System;

namespace Core.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; protected set; }
        public Guid Guid { get; protected set; }
        public virtual Metadata Metadata { get; protected set; }
    }
}