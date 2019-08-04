using System;

namespace Core.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public Metadata Metadata { get; set; }
    }
}