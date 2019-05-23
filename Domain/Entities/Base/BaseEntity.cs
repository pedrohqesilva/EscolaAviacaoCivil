using System;

namespace Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        public int Id { get; protected set; }
        public Guid Guid { get; protected set; }
        public Metadata Metadata { get; protected set; }
    }

    public class Metadata
    {
        public DateTime DataCriacao { get; private set; } = DateTime.Now;
        public DateTime? DataModificacao { get; private set; }
        public DateTime? DataExclusao { get; private set; }

        public bool IsExcluido { get; private set; }

        public static Metadata Create() => new Metadata();

        public Metadata Update()
        {
            DataModificacao = DateTime.Now;
            return this;
        }

        public Metadata Remove()
        {
            DataExclusao = DateTime.Now;
            IsExcluido = true;
            return this;
        }
    }
}