using System;

namespace Core.Domain.Entities
{
    public class Metadata
    {
        public DateTime DataCriacao { get; private set; } = DateTime.Now;
        public DateTime? DataModificacao { get; private set; }
        public DateTime? DataExclusao { get; private set; }

        public bool IsAtivo => DataCriacao < DateTime.Now && DateTime.Now.Date < DataExclusao;
    }
}