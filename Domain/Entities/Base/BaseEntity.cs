using System;

namespace Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public Metadata Metadata { get; set; }
    }

    public class Metadata
    {
        public DateTime DataCriacao { get; private set; }
        public DateTime? DataAtualizacao { get; private set; }
        public DateTime? DataRemocao { get; private set; }

        public bool IsRemovido { get; private set; }

        public static Metadata Create() => new Metadata { DataCriacao = DateTime.Now };

        public Metadata Update()
        {
            DataAtualizacao = DateTime.Now;
            return this;
        }

        public Metadata Remove()
        {
            DataRemocao = DateTime.Now;
            IsRemovido = true;
            return this;
        }
    }
}