using System;

namespace Core.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }

        public DateTime DataCriacao { get; private set; } = DateTime.Now;
        public DateTime? DataModificacao { get; private set; }
        public DateTime? DataExclusao { get; private set; }
        public bool IsExcluido { get; private set; } = false;
    }
}