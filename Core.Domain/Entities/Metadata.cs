using System;

namespace Core.Domain.Entities
{
    public class Metadata
    {
        public DateTime DataCriacao { get; private set; } = DateTime.Now;
        public DateTime? DataModificacao { get; private set; }
        public DateTime? DataExclusao { get; private set; }
        public bool IsExcluido { get; private set; }

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